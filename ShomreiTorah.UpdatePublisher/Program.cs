using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO.Compression;
using System.Security.Cryptography;

namespace ShomreiTorah.UpdatePublisher {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

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
			//var encryptor = new RijndaelManaged { BlockSize = 256, KeySize = 256 };
			//byte[] hash;

			//using (var transform = encryptor.CreateDecryptor())
			//    using (var hasher = new SHA512CryptoServiceProvider())
			//    using (var unzipper = new GZipStream(hashingStream, CompressionMode.Decompress)) {
			//    using (var decryptingStream = new CryptoStream(cypherStream, transform, CryptoStreamMode.Read))
			//    using (var hashingStream = new CryptoStream(decryptingStream, hasher, CryptoStreamMode.Read))
			//    }
		}
	}
}
