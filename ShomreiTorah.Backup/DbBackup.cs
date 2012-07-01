using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using ShomreiTorah.Common;

namespace ShomreiTorah.Backup {
	static class DbBackup {
		public static IEnumerator<string> DoBackup() {
			foreach (var dbElem in Config.GetElement("Databases").Elements()) {
				if (dbElem.Element("Backup") == null) continue;
				var dbName = dbElem.Name.ToString();
				yield return dbName.ToString();

				var db = new DBConnector(dbElem);
				var backupPath = Environment.ExpandEnvironmentVariables(
					String.Format(CultureInfo.InvariantCulture, dbElem.Element("Backup").Attribute("Path").Value, DateTime.Now)
				);

				Directory.CreateDirectory(Path.GetDirectoryName(backupPath));

				using (var dataSet = new DataSet(dbName) { Locale = CultureInfo.InvariantCulture })
				using (var original = db.OpenConnection()) {
					var tables = original.ExecuteReader("SELECT s.name + '.' + o.name FROM sys.objects o JOIN sys.schemas s ON o.schema_id = s.schema_id WHERE type = 'U'")
										 .Cast<IDataRecord>()
										 .Select(dr => dr.GetString(0))
										 .Select(name => new {
											 Name = name,
											 Adapter = DB.Default.Factory.CreateDataAdapter(original, "SELECT * FROM " + name)
										 });

					foreach (var table in tables) {
						table.Adapter.TableMappings.Add("Table", table.Name);
						table.Adapter.Fill(dataSet);
						table.Adapter.Dispose();
					}

					using (var stream = new GZipStream(File.Create(backupPath), CompressionMode.Compress)) {
						dataSet.WriteXml(stream, XmlWriteMode.WriteSchema);
					}
				}

				if (Directory.GetFiles(Path.GetDirectoryName(backupPath))
										   .Except(new[] { backupPath })
										   .Any(p => Program.AreEqual(backupPath, p)))
					File.Delete(backupPath);
			}
		}
	}
}
