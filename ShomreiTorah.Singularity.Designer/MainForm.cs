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

namespace ShomreiTorah.Singularity.Designer {
	partial class MainForm : RibbonForm {
		DataContextModel context = new DataContextModel();

		public MainForm() {
			InitializeComponent();
			schemaTree.Schemas = context.Schemas;
			dataContextVGrid.DataSource = context;
		}

		private void sqlServerImport_ItemClick(object sender, ItemClickEventArgs e) {
			var newSchemas = Dialogs.SchemaSelector.ShowDialog(SqlReader.ReadSchemas(DB.Default));
			if (newSchemas != null)
				context.Schemas.AddRange(newSchemas);
			schemaTree.RefreshList();
		}

		private void schemaTree_NodeDoubleClick(object sender, EventArgs e) {
			new SchemaDetailForm(context, schemaTree.SelectedSchema) { MdiParent = this }.Show();
		}

	}
}