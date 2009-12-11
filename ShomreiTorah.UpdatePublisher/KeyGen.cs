using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraEditors;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using System.Globalization;
using System.Xml;
using System.Runtime.InteropServices;

namespace ShomreiTorah.UpdatePublisher {
	partial class KeyGen : XtraForm {
		public KeyGen() {
			InitializeComponent();
			ClientSize = settingsPanel.Size;

			try {
				LoadCurrentValues();
			} catch (ConfigurationException) { }
		}
		protected override void OnShown(EventArgs e) {
			base.OnShown(e);
			SetTabs(cs.MaskBox);
			SetTabs(xml.MaskBox);
		}
		void LoadCurrentValues() {
			try {
				baseUri.Text = Config.ReadAttribute("Updates", "BaseUri");
			} catch (ConfigurationException) { }
			try {
				blobDecryptorAlg.Text = Config.ReadAttribute("Updates", "Cryptography", "BlobDecryptor", "Algorithm");
			} catch (ConfigurationException) { }

			try {
				rsaKeySize.Value = PrivateKey.CreateRSA().KeySize;
			} catch (CryptographicException) { }
		}

		#region UI
		static class NativeMethods {
			[DllImport("user32.dll")]
			public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, ref int lParam);
		}
		static void SetTabs(TextBox box) {
			//EM_SETTABSTOPS - http://msdn.microsoft.com/en-us/library/bb761663%28VS.85%29.aspx
			int lParam = 16;
			NativeMethods.SendMessage(box.Handle, 0x00CB, new IntPtr(1), ref lParam);
		}
		private void Text_DoubleClick(object sender, EventArgs e) {
			var box = (MemoEdit)sender;
			box.SelectAll();
			box.Copy();
		}
		private void baseUri_Properties_Validating(object sender, CancelEventArgs e) {
			Uri uri;
			e.Cancel = !Uri.TryCreate(baseUri.Text, UriKind.Absolute, out uri);
		}
		#endregion

		private void reencrypt_Click(object sender, EventArgs e) {
			GenerateCS(PrivateKey.CreateRSA());

			cs.Height += xml.Bottom - cs.Bottom;
			xml.Hide(); xmlLabel.Hide();

			settingsPanel.Hide();
		}
		private void newPair_Click(object sender, EventArgs e) {
			var updateVerifier = new RSACryptoServiceProvider((int)rsaKeySize.Value);
			var blobDecryptor = SymmetricAlgorithm.Create(blobDecryptorAlg.Text);
			blobDecryptor.BlockSize = blobDecryptor.KeySize = 256;

			GenerateCS(updateVerifier);
			GenerateXml(updateVerifier, blobDecryptor);
			settingsPanel.Hide();
		}

		void OnGenerated() {
			settingsPanel.Hide();
			FormBorderStyle = FormBorderStyle.Sizable;
			WindowState = FormWindowState.Maximized;
		}

		#region Code Generation
		static readonly RNGCryptoServiceProvider cryptoRandom = new RNGCryptoServiceProvider();

		const int BytesPerLine = 32;
		void GenerateCS(RSA updateVerifier) {
			byte[] keySalt = new byte[32];
			byte[] ivSalt = new byte[32];
			byte[] cipherText;

			cryptoRandom.GetBytes(keySalt);
			cryptoRandom.GetBytes(ivSalt);

			using (var encryptor = new RijndaelManaged {
				KeySize = 256,
				BlockSize = 256,

				Key = Password.CreateKey(keySalt, 256 / 8),
				IV = Password.CreateKey(ivSalt, 256 / 8)
			})
				cipherText = encryptor.Encrypt(Encoding.ASCII.GetBytes(updateVerifier.ToXmlString(true)));

			var builder = new StringBuilder(20000);

			builder.Append("		static readonly byte[] KeySalt = { ")
				.AppendJoin(keySalt.Select(b => b.ToString("000", CultureInfo.InvariantCulture)), ", ").AppendLine(" };");
			builder.Append("		static readonly byte[] IVSalt = { ")
				.AppendJoin(ivSalt.Select(b => b.ToString("000", CultureInfo.InvariantCulture)), ", ").AppendLine(" };");
			builder.AppendLine();

			builder.AppendLine("		static readonly byte[] CipherText = { ");
			for (int line = 0; line < cipherText.Length / BytesPerLine; line++) {
				if (line > 0) builder.AppendLine(", ");
				builder.Append("												");
				builder.AppendJoin(cipherText.Skip(line * BytesPerLine).Take(BytesPerLine).Select(b => b.ToString("000", CultureInfo.InvariantCulture)), ", ");
			}
			builder.AppendLine();
			builder.AppendLine("											};");
			cs.Text = builder.ToString();
		}
		void GenerateXml(RSA updateVerifier, SymmetricAlgorithm blobDecryptor) {
			var element = new XElement("Updates", new XAttribute("BaseUri", baseUri.Text),
				new XElement("Cryptography",
					new XElement("BlobDecryptor", new XAttribute("Algorithm", blobDecryptorAlg.Text),
						new XElement("Key", Convert.ToBase64String(blobDecryptor.Key)),
						new XElement("IV", Convert.ToBase64String(blobDecryptor.IV))
					),
					new XElement("UpdateVerifier", XElement.Parse(updateVerifier.ToXmlString(false)))
				)
			);

			var builder = new StringBuilder("\t", 1200);
			using (var w = XmlWriter.Create(builder, new XmlWriterSettings {
				IndentChars = "\t",
				NewLineChars = "\r\n\t",
				OmitXmlDeclaration = true,
				Indent = true
			})) {
				element.WriteTo(w);
			}
			xml.Text = builder.ToString();
		}
		#endregion
	}
}