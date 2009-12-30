using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ShomreiTorah.Common;
using System.Globalization;

namespace ShomreiTorah.Backup {
	static class JournalBackup {

		static string[] fileNames = new[] { "Journal.pptx", "Ads.xml" };

		public static IEnumerator<string> DoBackup() {
			var journalPath = Config.ReadAttribute("Journal", "Path");

			var backupFolder = Environment.ExpandEnvironmentVariables(
				String.Format(CultureInfo.InvariantCulture, Config.ReadAttribute("Journal", "BackupPath"), DateTime.Now)
			);

			Directory.CreateDirectory(Path.GetDirectoryName(backupFolder));

			var files = fileNames.Select(file => new {
				Name = file,
				SourcePath = Path.Combine(journalPath, file),
				DestPath = Path.Combine(backupFolder, file)
			});

			if (files.Any(f =>	//If any of the files don't have existing equal copies,
				!Directory.GetFiles(Path.GetDirectoryName(backupFolder), f.Name, SearchOption.AllDirectories).Any(p => Program.AreEqual(f.SourcePath, p))
			)) {
				Directory.CreateDirectory(backupFolder);
				foreach (var file in files) {
					yield return file.Name;

					File.Copy(file.SourcePath, file.DestPath);
				}
			}
		}
	}
}

