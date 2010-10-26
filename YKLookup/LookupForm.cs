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

namespace YKLookup {
	public partial class LookupForm : XtraForm {
		public LookupForm() {
			InitializeComponent();
			EditorRepository.PersonLookup.Apply(selector.Properties);
		}
	}
}
