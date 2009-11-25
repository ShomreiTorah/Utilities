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

namespace ShomreiTorah.UpdatePublisher {
	partial class EntryForm : XtraForm {
		const string DefaultDescription = @"This update provides the following features:
  • TBA
";
		public static XElement Show(string baseDir) {
			var product = Directory.GetFiles(baseDir, "*.exe")
								   .Select(p => Assembly.LoadFile(p).GetCustomAttribute<UpdatableAttribute>())
								   .FirstOrDefault(a => a != null);

			if (product == null) {
				XtraMessageBox.Show(baseDir + " does not contain any updatable assemblies.",
									"Shomrei Torah Update Publisher", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			UpdateInfo oldUpdate = null;
			string oldFilesPath = null;
			try {
				try {
					ProgressWorker.Execute(ui => {
						ui.Caption = "Searching for existing updates...";
						oldUpdate = new UpdateChecker(product.ProductName, new Version()).FindUpdate();	//We want to find the last update, so I search for an update for version 0.
						if (ui.WasCanceled || oldUpdate == null) return;
						oldFilesPath = oldUpdate.ExtractFiles(ui);
					}, true);
				} catch (TargetInvocationException) { }

				using (var form = new EntryForm()) {
					if (oldUpdate == null || String.IsNullOrEmpty(oldFilesPath)) {
						form.ClientSize = new Size(form.splitContainerControl1.Panel2.Width, form.ClientSize.Height);
						form.splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
					} else {
						form.oldUpdate.SetData(UpdateKind.Old, oldUpdate.NewVersion, oldUpdate.Description, oldFilesPath);
					}
					form.newUpdate.SetData(UpdateKind.New, product.CurrentVersion, DefaultDescription, baseDir);

					form.Text = "Update " + product.ProductName;

					if (form.ShowDialog() == DialogResult.Cancel)
						return null;
					return new XElement("Update",
						new XAttribute("Name", product.ProductName),
						new XAttribute("NewVersion", product.CurrentVersion.ToString()),
						new XAttribute("PublishDate", DateTime.Now.ToString("F", CultureInfo.InvariantCulture)),
						new XElement("Description", form.newUpdate.Description)
					);
				}
			} finally {
				if (oldFilesPath != null)
					Directory.Delete(oldFilesPath, true);
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