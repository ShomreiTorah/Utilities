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
				var encryptor = new RijndaelManaged { BlockSize = UpdateChecker.UpdateBlockSize, KeySize = UpdateChecker.UpdateKeySize };
				byte[] hash;

				var fullUri = new Uri(UpdateChecker.BaseUri, new Uri(element.Attribute("Name").Value + ".Update", UriKind.Relative));
				var relativeUri = new Uri(UpdateChecker.BaseUri.GetLeftPart(UriPartial.Authority), UriKind.Absolute).MakeRelativeUri(fullUri);

				var ftpRequest = FtpClient.Default.CreateRequest(relativeUri);
				ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
				if (ui.WasCanceled) return;

				ui.Caption = "Connecting to server...";
				using (var transform = encryptor.CreateEncryptor())
				using (var hasher = new SHA512CryptoServiceProvider())

				using (var requestStream = ftpRequest.GetRequestStream())
				using (var hashingStream = new CryptoStream(requestStream, hasher, CryptoStreamMode.Write))
				using (var encryptingStream = new CryptoStream(hashingStream, transform, CryptoStreamMode.Write))
				using (var zipper = new GZipStream(encryptingStream, CompressionMode.Compress)) {
					UpdateStreamer.WriteArchive(zipper, baseDir, ui);
					encryptingStream.FlushFinalBlock();

					hash = hasher.Hash;
				}
				if (ui.WasCanceled)
					return;
				ui.Caption = "Uploading update...";
				ui.Maximum = -1;
				ftpRequest.GetResponse().Close();

				ui.Caption = "Encrypting blob...";
				byte[] signature;
				using (var rsa = PrivateKey.CreateRSA())
					signature = rsa.SignHash(hash, CryptoConfig.MapNameToOID("SHA512"));

				var key = encryptor.Key;
				var iv = encryptor.IV;
				byte[] blob = new byte[key.Length + iv.Length + signature.Length];

				Buffer.BlockCopy(key, 0, blob, 0, key.Length);
				Buffer.BlockCopy(iv, 0, blob, key.Length, iv.Length);
				Buffer.BlockCopy(signature, 0, blob, key.Length + iv.Length, signature.Length);

				element.Add(new XElement("Blob", Convert.ToBase64String(UpdateChecker.CreateBlobEncryptor().TransformBytes(blob))));

				ui.Caption = "Uploading XML...";
				fullUri = new Uri(UpdateChecker.BaseUri, new Uri(element.Attribute("Name").Value + ".xml", UriKind.Relative));
				relativeUri = new Uri(UpdateChecker.BaseUri.GetLeftPart(UriPartial.Authority), UriKind.Absolute).MakeRelativeUri(fullUri);

				using (var stream = new MemoryStream())
				using (var writer = new StreamWriter(stream)) {
					element.Save(writer);
					writer.Flush();
					stream.Position = 0;
					FtpClient.Default.UploadFile(relativeUri, stream, ui);
				}
			}, true))
				XtraMessageBox.Show("The update has been uploaded to the server.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}