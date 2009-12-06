using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Compression;
using System.Security.Cryptography;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using System.Net;
using ShomreiTorah.WinForms.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.IO;

namespace ShomreiTorah.UpdatePublisher {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args) {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			if (args.Length == 1 && args[0].Equals("KeyGen", StringComparison.InvariantCultureIgnoreCase)) {
				if (Password.ShowPrompt(null))
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

			var element = EntryForm.Show(baseDir);
			if (element == null) return;
			if (new Publisher(element, baseDir).Publish())
				XtraMessageBox.Show("The update has been uploaded to the server.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}