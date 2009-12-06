using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

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
		public static bool ShowPrompt(Form parent) {
			if (!String.IsNullOrEmpty(password)) return true;

			using (var dialog = new Password()) {
				if (dialog.ShowDialog(parent) == DialogResult.Cancel) return false;
				password = dialog.text.Text;
			}
			return true;
		}
		#endregion

		public static byte[] CreateKey(byte[] salt, int size) {
			if (salt == null) throw new ArgumentNullException("salt");

			if (!ShowPrompt(null)) return null;

			var deriver = new Rfc2898DeriveBytes(password, salt);
			return deriver.GetBytes(size);
		}
	}
}