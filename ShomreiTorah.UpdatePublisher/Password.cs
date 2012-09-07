using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.IO;
using ShomreiTorah.Common;

namespace ShomreiTorah.UpdatePublisher {
	partial class Password : XtraForm {
		Password() { InitializeComponent(); }

		#region Verification
		const string Hash = "$2a$10$fH.7kdUxOMTr7rHsoo9ZTuAfmYZk9C4Fp4TpKOQG2DhrfEj9EG0/C";
		private void ok_Click(object sender, EventArgs e) {
			if (!BCrypt.CheckPassword(text.Text, Hash))
				XtraMessageBox.Show("Wrong password", "Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
				DialogResult = DialogResult.OK;
		}

		static string password;
		public static bool ShowPrompt() {
			if (!String.IsNullOrEmpty(password)) return true;

			using (var dialog = new Password()) {
				if (dialog.ShowDialog() == DialogResult.Cancel) return false;
				password = dialog.text.Text;
			}
			return true;
		}
		#endregion

		//This must be kept in sync with (identical to) Configurator.KeyStorage.
		const int BlockSize = 256 / 8;
		const int KeySaltSize = 16;

		public static RSACryptoServiceProvider ReadKey(Stream file) {
			if (!ShowPrompt()) return null;

			byte[] key = Unsalt(file, password);
			byte[] iv = Unsalt(file, password);

			using (var aes = new RijndaelManaged { KeySize = BlockSize * 8, BlockSize = BlockSize * 8, Key = key, IV = iv })
			using (var transform = aes.CreateDecryptor())
			using (var stream = new CryptoStream(file, transform, CryptoStreamMode.Read))
			using (var reader = new StreamReader(stream)) {
				var rsa = new RSACryptoServiceProvider();
				rsa.FromXmlString(reader.ReadToEnd());
				return rsa;
			}
		}
		static byte[] Unsalt(Stream source, string password) {
			byte[] salt = new byte[KeySaltSize];
			source.ReadFill(salt);
			var deriver = new Rfc2898DeriveBytes(password, salt);
			return deriver.GetBytes(BlockSize);
		}
	}
}