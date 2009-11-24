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
			if (ProgressWorker.Execute(ui => {
				var encryptor = new RijndaelManaged { BlockSize = 256, KeySize = 256 };
				byte[] hash;

				var fullUri = new Uri(UpdateChecker.BaseUri, new Uri(element.Attribute("Name").Value + ".Update", UriKind.Relative));
				var ftpRequest = FtpClient.Default.CreateRequest(new Uri(UpdateChecker.BaseUri.GetLeftPart(UriPartial.Authority), UriKind.Absolute).MakeRelativeUri(fullUri));
				ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
				if (ui.WasCanceled) return;

				ui.Caption = "Connecting to server...";
				using (var transform = encryptor.CreateEncryptor())
				using (var hasher = new SHA512CryptoServiceProvider())

				using (var requestStream = ftpRequest.GetRequestStream())
				using (var zipper = new GZipStream(requestStream, CompressionMode.Compress))
				using (var hashingStream = new CryptoStream(zipper, hasher, CryptoStreamMode.Write))
				using (var encryptingStream = new CryptoStream(hashingStream, transform, CryptoStreamMode.Write)) {
					UpdateStreamer.WriteArchive(encryptingStream, baseDir, ui);
					encryptingStream.FlushFinalBlock();

					hash = hasher.Hash;
				}
				if (ui.WasCanceled)
					return;
				ui.Caption = "Uploading update...";
				ui.Maximum = -1;
				ftpRequest.GetResponse().Close();

				//TODO: Blob
			}, true))
				XtraMessageBox.Show("The update has been uploaded to the server.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}