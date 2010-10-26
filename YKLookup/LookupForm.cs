using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI.DisplaySettings;

namespace YKLookup {
	public partial class LookupForm : XtraForm {
		public LookupForm() {
			InitializeComponent();
			EditorRepository.PersonLookup.Apply(selector.Properties);
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
			if (keyData == Keys.Escape) {
				if (selector.EditValue != null)
					SetState(null);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}
		private void selector_Properties_ButtonClick(object sender, ButtonPressedEventArgs e) {
			if (e.Button.Index == 1)
				SetState(null);
		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			SetState(null);	//Fix sizing issue
			BeginInvoke(new Action<Person>(SetState), new object[] { null });
		}
		private void selector_EditValueChanged(object sender, EventArgs e) {
			SetState((Person)selector.EditValue);
		}

		void SetState(Person person) {
			selector.EditValue = person;
			if (person == null) {
				SetHeight(selector.Height);
				selector.Properties.Buttons[1].Visible = false;
			} else {
				selector.Properties.Buttons[1].Visible = true;
				map.Text = person.FullName;

				var address = new StringBuilder();
				if (!String.IsNullOrEmpty(person.Address)) address.AppendLine(person.Address);
				if (!String.IsNullOrEmpty(person.City)
				 && !String.IsNullOrEmpty(person.State)) {
					address.Append(person.City).Append(", ").Append(person.State);
					if (!String.IsNullOrEmpty(person.Zip)) address.Append(" ").Append(person.Zip);
				}
				map.AddressString = address.ToString();

				string body = person.VeryFullName + Environment.NewLine + Environment.NewLine + person.MailingAddress;
				if (!string.IsNullOrEmpty(person.Phone))
					body += Environment.NewLine + Environment.NewLine + person.Phone;
				personDetails.Text = body;
				SetHeight(175);
			}
		}

		void SetHeight(int clientHeight) {
			MinimumSize = MaximumSize = Size.Empty;
			ClientSize = new Size(ClientSize.Width, clientHeight);
			MaximumSize = new Size(Screen.FromControl(this).WorkingArea.Width, Height);
			MinimumSize = new Size(75, Height);
		}

		protected override void WndProc(ref Message m) {
			switch (m.Msg) {
				case 0x84:	//WM_NCHITTEST
					base.WndProc(ref m);
					var result = (HitTest)m.Result.ToInt32();
					if (result == HitTest.Bottom || result == HitTest.Top)
						m.Result = new IntPtr((int)HitTest.Caption);
					if (result == HitTest.BottomLeft || result == HitTest.TopLeft)
						m.Result = new IntPtr((int)HitTest.Left);
					if (result == HitTest.BottomRight || result == HitTest.TopRight)
						m.Result = new IntPtr((int)HitTest.Right);

					return;
			}
			base.WndProc(ref m);
		}
		enum HitTest {
			Caption = 2,
			Transparent = -1,
			Nowhere = 0,
			Client = 1,
			Left = 10,
			Right = 11,
			Top = 12,
			TopLeft = 13,
			TopRight = 14,
			Bottom = 15,
			BottomLeft = 16,
			BottomRight = 17,
			Border = 18
		}
	}
}
