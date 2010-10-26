using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShomreiTorah.Data.UI.DisplaySettings;
using ShomreiTorah.Data;

namespace YKLookup {
	public partial class LookupForm : XtraForm {
		public LookupForm() {
			InitializeComponent();
			EditorRepository.PersonLookup.Apply(selector.Properties);
		}
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			SetState(null);
		}
		protected override void OnShown(EventArgs e) {
			base.OnShown(e);
		}
		private void selector_EditValueChanged(object sender, EventArgs e) {
			SetState((Person)selector.EditValue);
		}

		void SetState(Person person) {
			if (person == null) {
				SetHeight(selector.Height);
			} else {
				map.Text = person.FullName;

				var address = new StringBuilder();
				if (!String.IsNullOrEmpty(person.Address)) address.AppendLine(person.Address);
				if (!String.IsNullOrEmpty(person.City)
				 && !String.IsNullOrEmpty(person.State)) {
					address.Append(person.City).Append(", ").Append(person.State);
					if (!String.IsNullOrEmpty(person.Zip)) address.Append(" ").Append(person.Zip);
				}
				map.AddressString = address.ToString();

				string body =person.VeryFullName+Environment.NewLine + Environment.NewLine+ person.MailingAddress;
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
	}
}
