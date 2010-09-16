using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using ShomreiTorah.WinForms.Forms;

namespace ShomreiTorah.UpdatePublisher {
	class Publisher {
		readonly XElement xml;
		readonly string basePath;
		readonly UpdateInfo oldUpdate;
		///<summary>The absolute URL on the website to the folder containing the update files for this product.</summary>
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

			remoteBaseFolder = new Uri(UpdateChecker.BaseUri, product.ProductName + "/");
		}

		public bool Publish() {
			if (!Password.ShowPrompt()) return false;

			bool succeeded = false;
			ProgressWorker.Execute(ui => {
				ui.Caption = "Creating directory...";
				FtpClient.Default.CreateDirectory(CreateFtpUri(remoteBaseFolder));

				GatherFiles(ui);

				xml.Add(new XElement("Files", allFiles.Select(uf => uf.ToXml())));

				DeleteOldFiles(ui);

				UploadFiles(ui);

				UploadXml(ui);

				succeeded = true;
			}, false);
			return succeeded;
		}

		void GatherFiles(IProgressReporter ui) {
			ui.Caption = "Processing files...";
			ui.Maximum = -1;

			using (var rsa = PrivateKey.CreateRSA()) {
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
					var remotePath = new Uri(remoteBaseFolder, relativePath.Replace('\\', '$') + ".bin");
					var uf = UpdateFile.Create(basePath, relativePath, remotePath, rsa);

					allFiles.Add(uf);
					newFiles.Add(uf);	//We need to upload it
				}
			}
		}

		void DeleteOldFiles(IProgressReporter ui) {
			ui.Maximum = deleteFiles.Count;
			for (int i = 0; i < deleteFiles.Count; i++) {
				ui.Progress = i;
				ui.Caption = "Deleting " + deleteFiles[i].PathAndQuery;

				FtpClient.Default.DeleteFile(CreateFtpUri(deleteFiles[i]));
			}
		}

		void UploadFiles(IProgressReporter ui) {
			ui.Maximum = newFiles.Sum(uf => uf.Length);
			foreach (var file in newFiles) {
				ui.Caption = "Uploading " + file.RelativePath;

				var ftpRequest = FtpClient.Default.CreateRequest(CreateFtpUri(file.RemoteUrl));
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
				FtpClient.Default.UploadFile(CreateFtpUri(new Uri(remoteBaseFolder, "Manifest.xml")), stream, ui);
			}
		}

		static readonly Uri UpdateHostName = new Uri(UpdateChecker.BaseUri.GetLeftPart(UriPartial.Authority), UriKind.Absolute);
		///<summary>Converts an absolute URL on the website to an relative URL on the FTP site.</summary>
		static Uri CreateFtpUri(Uri relativeUrl) {
			return UpdateHostName.MakeRelativeUri(new Uri(UpdateChecker.BaseUri, relativeUrl));
		}
	}
}
