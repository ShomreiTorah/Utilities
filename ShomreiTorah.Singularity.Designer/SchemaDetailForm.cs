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
using DevExpress.XtraBars;
using ShomreiTorah.Singularity.Designer.Model;

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

			typeof(Row),

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
			dataTypeEdit.DropDownRows = standardColumnTypes.Length;

			columnPickerEdit.DataSource = schema.Columns;
			schemaBindingSource.DataSource = schema;
			schemaVGrid.DataSource = new[] { schema };

			UpdateNames();

			UpdateForeignSchemaEdit(true);
			UpdateColumnSqlNameEdit();

			schema.PropertyChanged += schema_PropertyChanged;
			context.Schemas.ListChanged += Schemas_ListChanged;
			columnsView.BestFitColumns();
			columnPickerEdit.View.BestFitColumns();
		}

		void schema_PropertyChanged(object sender, PropertyChangedEventArgs e) { UpdateNames(); }
		void UpdateNames() {
			if (!String.IsNullOrEmpty(schema.SqlSchemaName))
				Text = schema.SqlSchemaName + " / " + schema.Name;
			else
				Text = schema.Name;
			schemaGroup.Text = schema.Name + " Schema";
		}

		void Schemas_ListChanged(object sender, ListChangedEventArgs e) {
			if (e.ListChangedType == ListChangedType.ItemDeleted && !context.Schemas.Contains(schema))
				Close();
			else
				UpdateForeignSchemaEdit(true);
		}

		private void columnsBindingSource_CurrentItemChanged(object sender, EventArgs e) {
			if (FocusedColumn == null) {
				deleteColumn.Enabled = false;
				deleteColumn.Caption = "Delete Column";
			} else {
				deleteColumn.Enabled = true;
				deleteColumn.Caption = "Delete " + FocusedColumn.Name;
			}
		}

		ColumnModel FocusedColumn { get { return (ColumnModel)columnsBindingSource.Current; } }
		#region Grid editors
		EditorButton ClearForeignSchemaButton { get { return foreignSchemaEdit.Buttons[1]; } }

		private void columnsVGrid_FocusedRecordChanged(object sender, IndexChangedEventArgs e) {
			var invoker = IsHandleCreated ? new Action<Action>(a => BeginInvoke(a)) : a => a();

			invoker(delegate {
				UpdateForeignSchemaEdit(false);
				UpdateExpression();
				UpdateColumnSqlNameEdit();
				UpdateDefaultValue();
			});
		}
		private void foreignSchemaEdit_ButtonClick(object sender, ButtonPressedEventArgs e) {
			if (e.Button.Index == ClearForeignSchemaButton.Index) {
				FocusedColumn.ForeignSchema = null;
				UpdateForeignSchemaEdit(false);
			}
		}

		private void expressionEdit_Leave(object sender, EventArgs e) {
			columnsVGrid.CloseEditor();
			UpdateExpression();
			UpdateColumnSqlNameEdit();
		}
		private void defaultValueEdit_Leave(object sender, EventArgs e) {
			columnsVGrid.CloseEditor();
			UpdateDefaultValue();
		}
		private void foreignSchemaEdit_EditValueChanged(object sender, EventArgs e) {
			columnsVGrid.CloseEditor();
			UpdateForeignSchemaEdit(false);
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
			rowForeignRelationName.Enabled = rowForeignRelationPropertyName.Enabled = FocusedColumn == null || FocusedColumn.ForeignSchema != null;
		}
		void UpdateColumnSqlNameEdit() {
			rowColumnSqlName.Enabled = FocusedColumn == null || FocusedColumn.GenerateSqlMapping;
		}
		void UpdateExpression() {
			if (FocusedColumn == null || String.IsNullOrEmpty(FocusedColumn.Expression)) {
				defaultValueEdit.NullText = "(null)";
				rowDefaultValue.Enabled = true;
			} else {
				defaultValueEdit.NullText = "(Calculated column)";
				rowDefaultValue.Enabled = false;
			}
		}
		void UpdateDefaultValue() {
			rowExpression.Enabled = FocusedColumn == null || FocusedColumn.DefaultValue == null;
		}
		#endregion
		protected override void Dispose(bool disposing) {
			if (disposing) {
				schema.PropertyChanged -= schema_PropertyChanged;
				context.Schemas.ListChanged -= Schemas_ListChanged;
				if (components != null) components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void addColumn_ItemClick(object sender, ItemClickEventArgs e) {
			schema.Columns.AddNew();
			schema.Columns.EndNew(schema.Columns.Count - 1);
			columnsBindingSource.Position = schema.Columns.Count - 1;
		}

		private void deleteColumn_ItemClick(object sender, ItemClickEventArgs e) {
			schema.Columns.Remove(FocusedColumn);
		}

	}
}