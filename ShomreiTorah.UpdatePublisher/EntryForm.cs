using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using ShomreiTorah.Common;
using ShomreiTorah.Common.Updates;
using ShomreiTorah.WinForms.Forms;
using System.Globalization;
using System.Collections.ObjectModel;

namespace ShomreiTorah.UpdatePublisher {
	partial class EntryForm : XtraForm {
		const string DefaultDescription = @"  • TBA";
		public static XElement Show(UpdatableAttribute product, UpdateInfo oldUpdate, ReadOnlyCollection<string> updateFiles, string baseDir) {
			using (var form = new EntryForm()) {
				if (oldUpdate == null) {
					form.ClientSize = new Size(form.splitContainerControl1.Panel2.Width, form.ClientSize.Height);
					form.splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
				} else {
					form.oldUpdate.ShowOldFiles(oldUpdate, updateFiles, baseDir);
				}
				form.newUpdate.ShowNewFiles(product.CurrentVersion, DefaultDescription, updateFiles, baseDir, oldUpdate);

				form.Text = "Update " + product.ProductName;

				if (form.ShowDialog() == DialogResult.Cancel)
					return null;

				var newVersion = new UpdateVersion(DateTime.Now, product.CurrentVersion, form.newUpdate.Description);

				return new XElement("Update",
					new XAttribute("Name", product.ProductName),

					new XElement("Versions",
						newVersion.ToXml(),
						oldUpdate == null ? null : oldUpdate.Versions.Select(v => v.ToXml())
					)
					//The new files are added later
				);
			}
		}

		EntryForm() {
			InitializeComponent();
		}

		private void ok_Click(object sender, EventArgs e) {
			if (String.IsNullOrEmpty(newUpdate.Description) || newUpdate.Description == DefaultDescription)
				XtraMessageBox.Show("Please enter a description for the update.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else {
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}