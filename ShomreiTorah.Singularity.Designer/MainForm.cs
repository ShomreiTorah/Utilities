using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ShomreiTorah.Common;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ShomreiTorah.Singularity.Designer {
	partial class MainForm : RibbonForm {
		DataContextModel context = new DataContextModel();

		public MainForm() {
			InitializeComponent();
			schemaTree.Model = context;
			dataContextVGrid.DataSource = context;
		}

		private void sqlServerImport_ItemClick(object sender, ItemClickEventArgs e) {
			var newSchemas = Dialogs.SchemaSelector.ShowDialog( SqlReader.ReadSchemas(context,DB.Default));
			if (newSchemas != null)
				context.Schemas.AddRange(newSchemas);
		}

		private void schemaTree_NodeDoubleClick(object sender, EventArgs e) {
			new SchemaDetailForm(context, schemaTree.SelectedSchema) { MdiParent = this }.Show();
		}

		private void addSchema_ItemClick(object sender, ItemClickEventArgs e) {
			var newSchema = new SchemaModel(context) { Name = "Table" + (context.Schemas.Count + 1) };
			context.Schemas.Add(newSchema);
			new SchemaDetailForm(context, newSchema) { MdiParent = this }.Show();
		}

		private void deleteSchema_ItemClick(object sender, ItemClickEventArgs e) {
			if (DialogResult.Yes == XtraMessageBox.Show("Are you sure you want to delete " + schemaTree.SelectedSchema.Name + "?",
														"Singularity Designer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				context.Schemas.Remove(schemaTree.SelectedSchema);
		}

		private void schemaTree_SelectionChanged(object sender, EventArgs e) {
			if (schemaTree.SelectedSchema == null) {
				deleteSchema.Caption = "Delete Schema";
				deleteSchema.Enabled = false;
			} else {
				deleteSchema.Caption = "Delete " + schemaTree.SelectedSchema.Name;
				deleteSchema.Enabled = true;
			}
		}
	}
}