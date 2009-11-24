using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using ShomreiTorah.Common.Updates;
using System.Security.Cryptography;
using ShomreiTorah.Common;
using System.Net;
using System.IO.Compression;
using ShomreiTorah.WinForms.Forms;
using System.IO;

namespace ShomreiTorah.UpdatePublisher {
	class Publisher {
		readonly XElement xml;
		readonly string basePath;
		public Publisher(XElement xml, string basePath) {
			this.xml = xml;
			this.basePath = basePath;
		}

		SymmetricAlgorithm updateAlg;
		byte[] updateHash;
		public bool Publish() {
			bool succeeded = false;
			ProgressWorker.Execute(ui => {
				updateAlg = new RijndaelManaged { BlockSize = UpdateChecker.UpdateBlockSize, KeySize = UpdateChecker.UpdateKeySize };

				UploadArchive(ui);
				ui.CanCancel = false;

				UploadXml(ui);

				succeeded = true;
			}, true);
			return succeeded;
		}
		void UploadArchive(IProgressReporter ui) {
			var ftpRequest = FtpClient.Default.CreateRequest(CreateFtpUri(xml.Attribute("Name").Value + ".Update"));
			ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
			if (ui.WasCanceled) return;

			ui.Caption = "Connecting...";
			using (var transform = updateAlg.CreateEncryptor())
			using (var hasher = new SHA512CryptoServiceProvider())

			using (var requestStream = ftpRequest.GetRequestStream())
			using (var hashingStream = new CryptoStream(requestStream, hasher, CryptoStreamMode.Write))
			using (var encryptingStream = new CryptoStream(hashingStream, transform, CryptoStreamMode.Write)) {
				using (var zipper = new GZipStream(encryptingStream, CompressionMode.Compress, true)) {
					UpdateStreamer.WriteArchive(zipper, basePath, ui);
				} //Close the GZipStream now, forcing it to write the end of the data.
				encryptingStream.FlushFinalBlock();

				updateHash = hasher.Hash;
			}
			if (ui.WasCanceled)
				return;
			ui.Caption = "Uploading update...";
			ui.Maximum = -1;
			ftpRequest.GetResponse().Close();
		}

		void UploadXml(IProgressReporter ui) {
			ui.Caption = "Encrypting blob...";
			byte[] signature;
			using (var rsa = PrivateKey.CreateRSA())
				signature = rsa.SignHash(updateHash, CryptoConfig.MapNameToOID("SHA512"));

			var key = updateAlg.Key;
			var iv = updateAlg.IV;
			byte[] blob = new byte[key.Length + iv.Length + signature.Length];

			Buffer.BlockCopy(key, 0, blob, 0, key.Length);
			Buffer.BlockCopy(iv, 0, blob, key.Length, iv.Length);
			Buffer.BlockCopy(signature, 0, blob, key.Length + iv.Length, signature.Length);

			xml.Add(new XElement("Blob", Convert.ToBase64String(UpdateChecker.CreateBlobEncryptor().TransformBytes(blob))));

			ui.Caption = "Uploading XML...";

			using (var stream = new MemoryStream())
			using (var writer = new StreamWriter(stream)) {
				xml.Save(writer);
				writer.Flush();
				stream.Position = 0;
				FtpClient.Default.UploadFile(CreateFtpUri(xml.Attribute("Name").Value + ".xml"), stream, ui);
			}
		}

		static readonly Uri UpdateHostName = new Uri(UpdateChecker.BaseUri.GetLeftPart(UriPartial.Authority), UriKind.Absolute);
		static Uri CreateFtpUri(string relativePath) {
			return UpdateHostName.MakeRelativeUri(new Uri(UpdateChecker.BaseUri, new Uri(relativePath, UriKind.Relative)));
		}
	}
}
