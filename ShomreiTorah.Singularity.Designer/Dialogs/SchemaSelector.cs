using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using ShomreiTorah.Singularity.Designer.Model;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.Singularity.Designer.Dialogs {
	partial class SchemaSelector : XtraForm {
		readonly SchemaModel[] schemas;
		readonly HashSet<SchemaModel> selectedSchemas;

		public static IEnumerable<SchemaModel> ShowDialog(IEnumerable<SchemaModel> schemas) {
			using (var dialog = new SchemaSelector(schemas)) {
				if (dialog.ShowDialog() == DialogResult.Cancel)
					return null;
				return dialog.selectedSchemas;
			}
		}

		SchemaSelector(IEnumerable<SchemaModel> schemas) {
			InitializeComponent();

			grid.DataSource = this.schemas = schemas.ToArray();
			selectedSchemas = new HashSet<SchemaModel>(this.schemas);
			schemaView.BestFitColumns();

			CheckableGridController.Handle(colSelected);
		}

		private void grid_ViewRegistered(object sender, ViewOperationEventArgs e) {
			((GridView)e.View).BestFitColumns();
		}

		private void schemaView_DoubleClick(object sender, EventArgs e) {
			var info = schemaView.CalcHitInfo(grid.PointToClient(MousePosition));
			if (info.InRow) {
				schemaView.SetMasterRowExpanded(info.RowHandle, !schemaView.GetMasterRowExpanded(info.RowHandle));
			}
		}

		private void schemaView_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e) {
			if (e.Column == colSelected) {
				var schema = schemas[e.ListSourceRowIndex];
				if (e.IsGetData)
					e.Value = selectedSchemas.Contains(schema);
				else if (e.IsSetData) {
					if ((bool)e.Value)
						selectedSchemas.Add(schema);
					else
						selectedSchemas.Remove(schema);
				}
			}
		}
	}
}