using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraEditors.Controls;

namespace ShomreiTorah.Singularity.Designer {
	partial class SchemaDetailForm : XtraForm {
		readonly DataContextModel context;
		readonly SchemaModel schema;

		readonly Type[] standardColumnTypes = new[]{
			typeof(string),
			typeof(DateTime),
			typeof(Int32),
			typeof(decimal),
			typeof(Guid),

			typeof(byte),
			typeof(Int16),
			typeof(Int32),
			typeof(Int64),
			typeof(Single),
			typeof(Double),
		};

		public SchemaDetailForm(DataContextModel context, SchemaModel schema) {
			InitializeComponent();
			this.schema = schema;
			this.context = context;

			dataTypeEdit.Items.AddRange(standardColumnTypes);

			schemaBindingSource.DataSource = schema;
			schemaVGrid.DataSource = new[] { schema };

			if (!String.IsNullOrEmpty(schema.SqlSchemaName))
				Text = schema.SqlSchemaName + " / " + schema.Name;
			else
				Text = schema.Name;

			UpdateForeignSchemaEdit(true);
			UpdateColumnSqlNameEdit();

			context.Schemas.ListChanged += Schemas_ListChanged;
			columnsView.BestFitColumns();
			columnPickerEdit.View.BestFitColumns();
		}

		void Schemas_ListChanged(object sender, ListChangedEventArgs e) { UpdateForeignSchemaEdit(true); }


		EditorButton ClearForeignSchemaButton { get { return foreignSchemaEdit.Buttons[1]; } }

		ColumnModel FocusedColumn {
			get { return (ColumnModel)columnsVGrid.GetRecordObject(columnsVGrid.FocusedRecord); }
		}

		private void columnsVGrid_FocusedRecordChanged(object sender, IndexChangedEventArgs e) {
			UpdateForeignSchemaEdit(false);
			UpdateColumnSqlNameEdit();
		}
		private void foreignSchemaEdit_EditValueChanged(object sender, EventArgs e) {
			columnsVGrid.CloseEditor();
			UpdateForeignSchemaEdit(false);
		}
		private void foreignSchemaEdit_ButtonClick(object sender, ButtonPressedEventArgs e) {
			if (e.Button.Index == ClearForeignSchemaButton.Index) {
				FocusedColumn.ForeignSchema = null;
				UpdateForeignSchemaEdit(false);
			}
		}

		private void syncSqlEdit_CheckedChanged(object sender, EventArgs e) {
			columnsVGrid.CloseEditor();
			UpdateColumnSqlNameEdit();
		}
		void UpdateForeignSchemaEdit(bool setDataSource) {
			if (setDataSource) {
				foreignSchemaEdit.DataSource = context.Schemas.Where(s => s != schema).ToArray();
				foreignSchemaEdit.View.BestFitColumns();
			}
			ClearForeignSchemaButton.Enabled = FocusedColumn != null && FocusedColumn.ForeignSchema != null;
		}
		void UpdateColumnSqlNameEdit() {
			rowColumnSqlName.Enabled = FocusedColumn == null || FocusedColumn.GenerateSqlMapping;
		}
		protected override void Dispose(bool disposing) {
			if (disposing) {
				context.Schemas.ListChanged -= Schemas_ListChanged;
				if (components != null) components.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}