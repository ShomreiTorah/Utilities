using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using ShomreiTorah.WinForms.Forms;

namespace ShomreiTorah.UpdatePublisher {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length == 1 && args[0].Equals("KeyGen", StringComparison.OrdinalIgnoreCase)) {
				if (Password.ShowPrompt())
					Application.Run(new KeyGen());
				return;
			}

			string baseDir = Properties.Settings.Default.LastBaseDir;
			if (String.IsNullOrEmpty(baseDir)) baseDir = Environment.CurrentDirectory;
			using (var dialog = new FolderBrowserDialog {
				SelectedPath = baseDir,
				ShowNewFolderButton = false,
				Description = "Select the folder containing an update"
			}) {
				if (dialog.ShowDialog() == DialogResult.Cancel) return;
				baseDir = Properties.Settings.Default.LastBaseDir = dialog.SelectedPath;
			}
			Properties.Settings.Default.Save();

			var product = Directory.GetFiles(baseDir, "*.exe")
					   .Select(p => Assembly.LoadFile(p).GetCustomAttribute<UpdatableAttribute>())
					   .FirstOrDefault(a => a != null);

			if (product == null) {
				XtraMessageBox.Show(baseDir + " does not contain any updatable assemblies.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			UpdateInfo oldUpdate = UpdateChecker.Create(product.ProductName, new Version()).FindUpdate();	//We want to find the last update, so I search for an update for version 0.
			if (oldUpdate != null && product.CurrentVersion == oldUpdate.NewVersion
			 && DialogResult.No == XtraMessageBox.Show("The version number has not changed.\r\nCurrent clients will not download this update.\r\nDo you wish to continue?",
													   "Shomrei Torah Update Publisher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				return;

			ReadOnlyCollection<string> updateFiles = GetUpdateFiles(baseDir).ReadOnlyCopy();
			var element = EntryForm.Show(product, oldUpdate, updateFiles, baseDir);
			if (element == null) return;
			if (new Publisher(product, oldUpdate, element, updateFiles, baseDir).Publish())
				XtraMessageBox.Show("The update has been uploaded to the server.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		static readonly string[] ignoredExtensions = { ".pdb", ".bak", ".LastCodeAnalysisSucceeded" };
		static IEnumerable<string> GetUpdateFiles(string basePath) {
			var allFiles = Directory.EnumerateFiles(basePath, "*.*", SearchOption.AllDirectories);

			return allFiles
					.Where(p => p.IndexOf(".vshost.", StringComparison.OrdinalIgnoreCase) < 0)
					.Where(p => !ignoredExtensions.Contains(Path.GetExtension(p), StringComparer.OrdinalIgnoreCase))
					.Where(p => !p.EndsWith(".CodeAnalysisLog.xml", StringComparison.OrdinalIgnoreCase))
					.Where(p => !IsXmlDocFile(p));
		}
		static bool IsXmlDocFile(string path) {
			if (!Path.GetExtension(path).Equals(".xml", StringComparison.OrdinalIgnoreCase))
				return false;
			return File.Exists(Path.ChangeExtension(path, ".dll"))
				|| File.Exists(Path.ChangeExtension(path, ".exe"));
		}
	}
}