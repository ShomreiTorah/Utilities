namespace ShomreiTorah.Singularity.Designer {
	partial class SchemaDetailForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.columnsGrid = new DevExpress.XtraGrid.GridControl();
			this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.schemaBindingSource = new ShomreiTorah.Singularity.Designer.ModelBindingSource();
			this.propertiesEditors = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
			this.dataTypeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.sqlSchemaEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.columnPickerEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDataType1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.foreignSchemaEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSqlSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrimaryKey = new DevExpress.XtraGrid.Columns.GridColumn();
			this.columnsView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDataType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDefaultValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllowNulls = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsUnique = new DevExpress.XtraGrid.Columns.GridColumn();
			this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
			this.schemaVGrid = new DevExpress.XtraVerticalGrid.VGridControl();
			this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowPrimaryKey = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.categoryRow3 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowSqlSchemaName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.columnsVGrid = new DevExpress.XtraVerticalGrid.VGridControl();
			this.columnSqlNameEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.syncSqlEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.categoryRow2 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.rowName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowDataType = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.rowSyncSql = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowColumnSqlName = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowDefaultValue = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowAllowNulls = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowIsUnique = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.rowForeignSchema = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.columnsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schemaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTypeEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlSchemaEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnPickerEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignSchemaEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
			this.splitContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.schemaVGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsVGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.columnSqlNameEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.syncSqlEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.columnsGrid);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(783, 552);
			this.splitContainerControl1.SplitterPosition = 443;
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// columnsGrid
			// 
			this.columnsGrid.DataSource = this.columnsBindingSource;
			this.columnsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.columnsGrid.ExternalRepository = this.propertiesEditors;
			this.columnsGrid.Location = new System.Drawing.Point(0, 0);
			this.columnsGrid.MainView = this.columnsView;
			this.columnsGrid.Name = "columnsGrid";
			this.columnsGrid.Size = new System.Drawing.Size(443, 552);
			this.columnsGrid.TabIndex = 0;
			this.columnsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.columnsView});
			// 
			// columnsBindingSource
			// 
			this.columnsBindingSource.DataMember = "Columns";
			this.columnsBindingSource.DataSource = this.schemaBindingSource;
			// 
			// propertiesEditors
			// 
			this.propertiesEditors.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dataTypeEdit,
            this.sqlSchemaEdit,
            this.columnPickerEdit,
            this.foreignSchemaEdit});
			// 
			// dataTypeEdit
			// 
			this.dataTypeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dataTypeEdit.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
			this.dataTypeEdit.Name = "dataTypeEdit";
			this.dataTypeEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// sqlSchemaEdit
			// 
			this.sqlSchemaEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.sqlSchemaEdit.Name = "sqlSchemaEdit";
			// 
			// columnPickerEdit
			// 
			this.columnPickerEdit.AutoHeight = false;
			this.columnPickerEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.columnPickerEdit.DataSource = this.columnsBindingSource;
			this.columnPickerEdit.DisplayMember = "Name";
			this.columnPickerEdit.Name = "columnPickerEdit";
			this.columnPickerEdit.NullText = "(None)";
			this.columnPickerEdit.View = this.repositoryItemGridLookUpEdit1View;
			// 
			// repositoryItemGridLookUpEdit1View
			// 
			this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colDataType1});
			this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
			this.repositoryItemGridLookUpEdit1View.OptionsBehavior.Editable = false;
			this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			this.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = false;
			// 
			// colName1
			// 
			this.colName1.FieldName = "Name";
			this.colName1.Name = "colName1";
			this.colName1.Visible = true;
			this.colName1.VisibleIndex = 0;
			// 
			// colDataType1
			// 
			this.colDataType1.FieldName = "DataType";
			this.colDataType1.Name = "colDataType1";
			this.colDataType1.Visible = true;
			this.colDataType1.VisibleIndex = 1;
			// 
			// foreignSchemaEdit
			// 
			this.foreignSchemaEdit.AutoHeight = false;
			this.foreignSchemaEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Clear", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Clear", null, null, true)});
			this.foreignSchemaEdit.DataSource = this.schemaBindingSource;
			this.foreignSchemaEdit.Name = "foreignSchemaEdit";
			this.foreignSchemaEdit.NullText = "(None)";
			this.foreignSchemaEdit.View = this.gridView1;
			this.foreignSchemaEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.foreignSchemaEdit_ButtonClick);
			this.foreignSchemaEdit.EditValueChanged += new System.EventHandler(this.foreignSchemaEdit_EditValueChanged);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName2,
            this.colSqlSchemaName,
            this.colPrimaryKey});
			this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.gridView1.OptionsView.ShowGroupPanel = false;
			this.gridView1.OptionsView.ShowIndicator = false;
			// 
			// colName2
			// 
			this.colName2.FieldName = "Name";
			this.colName2.Name = "colName2";
			this.colName2.Visible = true;
			this.colName2.VisibleIndex = 0;
			// 
			// colSqlSchemaName
			// 
			this.colSqlSchemaName.FieldName = "SqlSchemaName";
			this.colSqlSchemaName.Name = "colSqlSchemaName";
			this.colSqlSchemaName.Visible = true;
			this.colSqlSchemaName.VisibleIndex = 1;
			// 
			// colPrimaryKey
			// 
			this.colPrimaryKey.FieldName = "PrimaryKey";
			this.colPrimaryKey.Name = "colPrimaryKey";
			this.colPrimaryKey.Visible = true;
			this.colPrimaryKey.VisibleIndex = 2;
			// 
			// columnsView
			// 
			this.columnsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colDataType,
            this.colDefaultValue,
            this.colAllowNulls,
            this.colIsUnique});
			this.columnsView.GridControl = this.columnsGrid;
			this.columnsView.Name = "columnsView";
			// 
			// colName
			// 
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			// 
			// colDataType
			// 
			this.colDataType.ColumnEdit = this.dataTypeEdit;
			this.colDataType.FieldName = "DataType";
			this.colDataType.Name = "colDataType";
			this.colDataType.Visible = true;
			this.colDataType.VisibleIndex = 1;
			// 
			// colDefaultValue
			// 
			this.colDefaultValue.FieldName = "DefaultValue";
			this.colDefaultValue.Name = "colDefaultValue";
			this.colDefaultValue.Visible = true;
			this.colDefaultValue.VisibleIndex = 2;
			// 
			// colAllowNulls
			// 
			this.colAllowNulls.Caption = "Nullable";
			this.colAllowNulls.FieldName = "AllowNulls";
			this.colAllowNulls.Name = "colAllowNulls";
			this.colAllowNulls.Visible = true;
			this.colAllowNulls.VisibleIndex = 3;
			// 
			// colIsUnique
			// 
			this.colIsUnique.Caption = "Unique";
			this.colIsUnique.FieldName = "IsUnique";
			this.colIsUnique.Name = "colIsUnique";
			this.colIsUnique.Visible = true;
			this.colIsUnique.VisibleIndex = 4;
			// 
			// splitContainerControl2
			// 
			this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
			this.splitContainerControl2.Horizontal = false;
			this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl2.Name = "splitContainerControl2";
			this.splitContainerControl2.Panel1.Controls.Add(this.schemaVGrid);
			this.splitContainerControl2.Panel1.Text = "Panel1";
			this.splitContainerControl2.Panel2.Controls.Add(this.columnsVGrid);
			this.splitContainerControl2.Panel2.Text = "Panel2";
			this.splitContainerControl2.Size = new System.Drawing.Size(332, 552);
			this.splitContainerControl2.SplitterPosition = 276;
			this.splitContainerControl2.TabIndex = 0;
			this.splitContainerControl2.Text = "splitContainerControl2";
			// 
			// schemaVGrid
			// 
			this.schemaVGrid.DataSource = this.schemaBindingSource;
			this.schemaVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schemaVGrid.ExternalRepository = this.propertiesEditors;
			this.schemaVGrid.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
			this.schemaVGrid.Location = new System.Drawing.Point(0, 0);
			this.schemaVGrid.Name = "schemaVGrid";
			this.schemaVGrid.OptionsBehavior.ResizeRowHeaders = false;
			this.schemaVGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1,
            this.rowPrimaryKey,
            this.categoryRow3});
			this.schemaVGrid.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
			this.schemaVGrid.Size = new System.Drawing.Size(332, 276);
			this.schemaVGrid.TabIndex = 0;
			// 
			// editorRow1
			// 
			this.editorRow1.Name = "editorRow1";
			this.editorRow1.Properties.Caption = "Table Name";
			this.editorRow1.Properties.FieldName = "Name";
			// 
			// rowPrimaryKey
			// 
			this.rowPrimaryKey.Name = "rowPrimaryKey";
			this.rowPrimaryKey.Properties.Caption = "Primary Key";
			this.rowPrimaryKey.Properties.FieldName = "PrimaryKey";
			this.rowPrimaryKey.Properties.RowEdit = this.columnPickerEdit;
			// 
			// categoryRow3
			// 
			this.categoryRow3.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow2,
            this.rowSqlSchemaName});
			this.categoryRow3.Height = 19;
			this.categoryRow3.Name = "categoryRow3";
			this.categoryRow3.Properties.Caption = "SQL";
			// 
			// editorRow2
			// 
			this.editorRow2.Name = "editorRow2";
			this.editorRow2.Properties.Caption = "SQL Name";
			this.editorRow2.Properties.FieldName = "SqlName";
			// 
			// rowSqlSchemaName
			// 
			this.rowSqlSchemaName.Name = "rowSqlSchemaName";
			this.rowSqlSchemaName.Properties.Caption = "SQL Schema";
			this.rowSqlSchemaName.Properties.FieldName = "SqlSchemaName";
			// 
			// columnsVGrid
			// 
			this.columnsVGrid.DataSource = this.columnsBindingSource;
			this.columnsVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.columnsVGrid.ExternalRepository = this.propertiesEditors;
			this.columnsVGrid.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
			this.columnsVGrid.Location = new System.Drawing.Point(0, 0);
			this.columnsVGrid.Name = "columnsVGrid";
			this.columnsVGrid.OptionsBehavior.ResizeRowHeaders = false;
			this.columnsVGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.columnSqlNameEdit,
            this.syncSqlEdit});
			this.columnsVGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.categoryRow2,
            this.categoryRow1,
            this.rowDefaultValue,
            this.rowAllowNulls,
            this.rowIsUnique,
            this.rowForeignSchema});
			this.columnsVGrid.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways;
			this.columnsVGrid.Size = new System.Drawing.Size(332, 268);
			this.columnsVGrid.TabIndex = 0;
			this.columnsVGrid.FocusedRecordChanged += new DevExpress.XtraVerticalGrid.Events.IndexChangedEventHandler(this.columnsVGrid_FocusedRecordChanged);
			// 
			// columnSqlNameEdit
			// 
			this.columnSqlNameEdit.AutoHeight = false;
			this.columnSqlNameEdit.Name = "columnSqlNameEdit";
			this.columnSqlNameEdit.NullText = "(Not Synchronized)";
			// 
			// syncSqlEdit
			// 
			this.syncSqlEdit.AutoHeight = false;
			this.syncSqlEdit.Name = "syncSqlEdit";
			this.syncSqlEdit.CheckedChanged += new System.EventHandler(this.syncSqlEdit_CheckedChanged);
			// 
			// categoryRow2
			// 
			this.categoryRow2.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowName,
            this.rowDataType});
			this.categoryRow2.Name = "categoryRow2";
			this.categoryRow2.Properties.Caption = "General";
			// 
			// rowName
			// 
			this.rowName.Name = "rowName";
			this.rowName.Properties.Caption = "Column Name";
			this.rowName.Properties.FieldName = "Name";
			// 
			// rowDataType
			// 
			this.rowDataType.Name = "rowDataType";
			this.rowDataType.Properties.Caption = "Data Type";
			this.rowDataType.Properties.FieldName = "DataType";
			this.rowDataType.Properties.RowEdit = this.dataTypeEdit;
			// 
			// categoryRow1
			// 
			this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowSyncSql,
            this.rowColumnSqlName});
			this.categoryRow1.Name = "categoryRow1";
			this.categoryRow1.Properties.Caption = "SQL";
			// 
			// rowSyncSql
			// 
			this.rowSyncSql.Name = "rowSyncSql";
			this.rowSyncSql.Properties.Caption = "Sync to SQL Server";
			this.rowSyncSql.Properties.CustomizationCaption = null;
			this.rowSyncSql.Properties.FieldName = "GenerateSqlMapping";
			this.rowSyncSql.Properties.RowEdit = this.syncSqlEdit;
			// 
			// rowColumnSqlName
			// 
			this.rowColumnSqlName.Name = "rowColumnSqlName";
			this.rowColumnSqlName.Properties.Caption = "SQL Name";
			this.rowColumnSqlName.Properties.FieldName = "SqlName";
			this.rowColumnSqlName.Properties.RowEdit = this.columnSqlNameEdit;
			// 
			// rowDefaultValue
			// 
			this.rowDefaultValue.Name = "rowDefaultValue";
			this.rowDefaultValue.Properties.Caption = "Default Value";
			this.rowDefaultValue.Properties.FieldName = "DefaultValue";
			// 
			// rowAllowNulls
			// 
			this.rowAllowNulls.Name = "rowAllowNulls";
			this.rowAllowNulls.Properties.Caption = "Allow Nulls";
			this.rowAllowNulls.Properties.FieldName = "AllowNulls";
			// 
			// rowIsUnique
			// 
			this.rowIsUnique.Name = "rowIsUnique";
			this.rowIsUnique.Properties.Caption = "Is Unique";
			this.rowIsUnique.Properties.FieldName = "IsUnique";
			// 
			// rowForeignSchema
			// 
			this.rowForeignSchema.Name = "rowForeignSchema";
			this.rowForeignSchema.Properties.Caption = "Foreign Schema";
			this.rowForeignSchema.Properties.FieldName = "ForeignSchema";
			this.rowForeignSchema.Properties.RowEdit = this.foreignSchemaEdit;
			// 
			// SchemaDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(783, 552);
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "SchemaDetailForm";
			this.Text = "SchemaDetailForm";
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.columnsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schemaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTypeEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sqlSchemaEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnPickerEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.foreignSchemaEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
			this.splitContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.schemaVGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnsVGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.columnSqlNameEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.syncSqlEdit)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraGrid.GridControl columnsGrid;
		private System.Windows.Forms.BindingSource columnsBindingSource;
		private ModelBindingSource schemaBindingSource;
		private DevExpress.XtraEditors.Repository.PersistentRepository propertiesEditors;
		private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dataTypeEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit sqlSchemaEdit;
		private DevExpress.XtraGrid.Views.Grid.GridView columnsView;
		private DevExpress.XtraGrid.Columns.GridColumn colName;
		private DevExpress.XtraGrid.Columns.GridColumn colDataType;
		private DevExpress.XtraGrid.Columns.GridColumn colDefaultValue;
		private DevExpress.XtraGrid.Columns.GridColumn colAllowNulls;
		private DevExpress.XtraGrid.Columns.GridColumn colIsUnique;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
		private DevExpress.XtraVerticalGrid.VGridControl columnsVGrid;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow2;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowName;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDataType;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowColumnSqlName;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowDefaultValue;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowAllowNulls;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowIsUnique;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowForeignSchema;
		private DevExpress.XtraVerticalGrid.VGridControl schemaVGrid;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowPrimaryKey;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow3;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSqlSchemaName;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit columnPickerEdit;
		private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
		private DevExpress.XtraGrid.Columns.GridColumn colName1;
		private DevExpress.XtraGrid.Columns.GridColumn colDataType1;
		private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit foreignSchemaEdit;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colName2;
		private DevExpress.XtraGrid.Columns.GridColumn colSqlSchemaName;
		private DevExpress.XtraGrid.Columns.GridColumn colPrimaryKey;
		private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit columnSqlNameEdit;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow rowSyncSql;
		private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit syncSqlEdit;
	}
}