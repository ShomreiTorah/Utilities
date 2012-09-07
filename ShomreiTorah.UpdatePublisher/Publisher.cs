using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Linq;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using ShomreiTorah.WinForms;
using ShomreiTorah.WinForms.Forms;

namespace ShomreiTorah.UpdatePublisher {
	class Publisher {
		readonly UpdatableAttribute product;
		readonly XElement xml;
		readonly string basePath;
		readonly UpdateInfo oldUpdate;
		///<summary>The absolute path on the FTP server to the folder containing the update files for this product.</summary>
		readonly Uri remoteBaseFolder;
		readonly ReadOnlyCollection<string> updateFiles;

		readonly List<UpdateFile> allFiles = new List<UpdateFile>();
		readonly List<UpdateFile> newFiles = new List<UpdateFile>();
		readonly List<Uri> deleteFiles = new List<Uri>();

		public Publisher(UpdatableAttribute product, UpdateInfo oldUpdate, XElement xml, ReadOnlyCollection<string> updateFiles, string basePath) {
			this.oldUpdate = oldUpdate;
			this.xml = xml;
			this.updateFiles = updateFiles;
			this.basePath = basePath;
			this.product = product;

			remoteBaseFolder = Combine(UpdateConfig.Standard.RemotePath, product.ProductName + "/");
		}

		public bool Publish() {
			using (var rsa = GetRSA()) {
				if (rsa == null)
					return false;

				bool succeeded = false;
				ProgressWorker.Execute(ui => {
					ui.Caption = "Creating directory...";
					FtpClient.Default.CreateDirectory(remoteBaseFolder);

					GatherFiles(ui, rsa);

					xml.Add(new XElement("Files", allFiles.Select(uf => uf.ToXml())));

					DeleteOldFiles(ui);

					UploadFiles(ui);

					UploadXml(ui);

					succeeded = true;
				}, false);
				return succeeded;
			}
		}

		static string FindRoot(string path) {
			while (true) {
				if (String.IsNullOrEmpty(path))
					return null;
				if (Directory.Exists(Path.Combine(path, @"Setup\.git"))
				 && Directory.Exists(Path.Combine(path, @"Config")))
					return path;

				path = Path.GetDirectoryName(path);
			}
		}
		private static RSACryptoServiceProvider GetRSA() {
			string filePath = null;

			string rootFolder = FindRoot(typeof(Publisher).Assembly.Location) ?? FindRoot(Config.FilePath);
			if (rootFolder != null)
				filePath = Directory.EnumerateFiles(Path.Combine(rootFolder, "Config"), "*.private-key")
									.OrderByDescending(Path.GetFileName)
									.FirstOrDefault();

			if (filePath == null) {
				Dialog.Warn("Cannot find private key in expected locations (see source).\nPlease select a private key file.");
				using (var dialog = new OpenFileDialog {
					Filter = "ShomreiTorah Encrypted Private Key File (*.private-key)|*.private-key"
				}) {
					if (dialog.ShowDialog() == DialogResult.Cancel)
						return null;
				}
			}

			using (var file = File.OpenRead(filePath))
				return Password.ReadKey(file);
		}

		void GatherFiles(IProgressReporter ui, RSACryptoServiceProvider rsa) {
			ui.Caption = "Processing files...";
			ui.Maximum = -1;
			var rootUri = new Uri(basePath + "\\", UriKind.Absolute);

			var pendingFiles = updateFiles.ToList();

			if (oldUpdate != null) {
				foreach (var oldFile in oldUpdate.Files) {
					var absolutePath = Path.Combine(basePath, oldFile.RelativePath);

					if (updateFiles.Contains(absolutePath, StringComparer.OrdinalIgnoreCase)
					 && oldFile.Matches(basePath)) {
						//Since the file hasn't changed, we don't need to re-upload it.
						pendingFiles.RemoveAll(p => p.Equals(absolutePath, StringComparison.OrdinalIgnoreCase));

						allFiles.Add(UpdateFile.Create(basePath, oldFile.RelativePath, oldFile.RemoteUrl, rsa));	//Re-sign the file to allow for key changes.
					} else
						deleteFiles.Add(oldFile.RemoteUrl);
				}
			}

			foreach (var newFile in pendingFiles) {
				var uri = new Uri(newFile, UriKind.Absolute);
				var relativePath = Uri.UnescapeDataString(rootUri.MakeRelativeUri(uri).ToString()).Replace('/', '\\');

				//Hide the actual extensions from the server to prevent ASP.Net from interfering
				var remotePath = new Uri(product.ProductName + "/" + relativePath.Replace('\\', '$') + ".bin", UriKind.Relative);
				var uf = UpdateFile.Create(basePath, relativePath, remotePath, rsa);

				allFiles.Add(uf);
				newFiles.Add(uf);	//We need to upload it
			}
		}

		void DeleteOldFiles(IProgressReporter ui) {
			ui.Maximum = deleteFiles.Count;
			for (int i = 0; i < deleteFiles.Count; i++) {
				ui.Progress = i;
				ui.Caption = "Deleting " + deleteFiles[i];

				FtpClient.Default.DeleteFile(Combine(UpdateConfig.Standard.RemotePath, deleteFiles[i]));
			}
		}

		void UploadFiles(IProgressReporter ui) {
			ui.Maximum = newFiles.Sum(uf => uf.Length);
			foreach (var file in newFiles) {
				ui.Caption = "Uploading " + file.RelativePath;

				var ftpRequest = FtpClient.Default.CreateRequest(Combine(UpdateConfig.Standard.RemotePath, file.RemoteUrl));
				ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;

				using (var transform = UpdateChecker.CreateFileEncryptor())

				using (var requestStream = ftpRequest.GetRequestStream())
				using (var encryptingStream = new CryptoStream(requestStream, transform, CryptoStreamMode.Write))
				using (var zipper = new GZipStream(encryptingStream, CompressionMode.Compress, true))

				using (var fileStream = File.Open(Path.Combine(basePath, file.RelativePath), FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
					fileStream.CopyTo(zipper, file.Length, ui.ChildOperation());
				}

				ftpRequest.GetResponse().Close();
			}
		}

		void UploadXml(IProgressReporter ui) {
			ui.Caption = "Uploading XML...";

			using (var stream = new MemoryStream())
			using (var writer = new StreamWriter(stream)) {
				xml.Save(writer);
				writer.Flush();
				stream.Position = 0;
				FtpClient.Default.UploadFile(Combine(remoteBaseFolder, "Manifest.xml"), stream, ui);
			}
		}

		static readonly Uri combineBase = new Uri("invalid://");
		///<summary>Combines a relative Uri instance with an additional relative path.</summary>
		///<remarks>The new Uri(Uri, Uri) constructor cannot handle relative Uris.</remarks>
		static Uri Combine(Uri relativeUri, Uri additionalPath) {
			if (additionalPath == null) throw new ArgumentNullException("additionalPath");
			if (additionalPath.IsAbsoluteUri)
				throw new ArgumentException("Cannot combine with an absolute Uri.");
			return Combine(relativeUri, additionalPath.ToString());
		}
		///<summary>Combines a relative Uri instance with an additional relative path.</summary>
		///<remarks>The new Uri(Uri, string) constructor cannot handle relative Uris.</remarks>
		static Uri Combine(Uri relativeUri, string additionalPath) {
			if (relativeUri == null) throw new ArgumentNullException("relativeUri");
			if (additionalPath == null) throw new ArgumentNullException("additionalPath");

			if (relativeUri.IsAbsoluteUri)
				return new Uri(relativeUri, additionalPath);

			return combineBase.MakeRelativeUri(
				new Uri(new Uri(combineBase, relativeUri.OriginalString.TrimEnd('/', '\\') + '/'), additionalPath)
			);
		}
	}
}
