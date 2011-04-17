using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShomreiTorah.Common.Calendar;

namespace OmerCreator {
	public partial class UI : Form {
		public UI() {
			InitializeComponent();
			hebrewYear.Value = HebrewDate.Today.HebrewYear;
			output.SelectedIndex = 1;
		}

		private void go_Click(object sender, EventArgs e) {
			switch (output.Text) {
				case "Dialog Box":
					new OmerDisplay((int)hebrewYear.Value, includeנקודות.Checked).Show(this);
					break;
				case "Word Document":
					WordExporter.Export((int)hebrewYear.Value, includeנקודות.Checked);
					break;
			}
		}
	}
}
