namespace ShomreiTorah.Singularity.Designer.Dialogs {
	partial class SchemaSelector {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			this.columnsView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSqlName1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDataType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllowNulls = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsUnique = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colParentSchema = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grid = new DevExpress.XtraGrid.GridControl();
			this.modelBindingSource1 = new ShomreiTorah.Singularity.Designer.ModelBindingSource();
			this.schemaView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSqlName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSqlSchemaName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrimaryKey = new DevExpress.XtraGrid.Columns.GridColumn();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.ok = new DevExpress.XtraEditors.SimpleButton();
			this.cancel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.columnsView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.schemaView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnsView
			// 
			this.columnsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSqlName1,
            this.colDataType,
            this.colAllowNulls,
            this.colIsUnique,
            this.colParentSchema});
			this.columnsView.DetailHeight = 200;
			this.columnsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.columnsView.GridControl = this.grid;
			this.columnsView.Name = "columnsView";
			this.columnsView.OptionsBehavior.Editable = false;
			this.columnsView.OptionsSelection.MultiSelect = true;
			this.columnsView.OptionsView.ColumnAutoWidth = false;
			this.columnsView.OptionsView.ShowGroupPanel = false;
			// 
			// colSqlName1
			// 
			this.colSqlName1.FieldName = "SqlName";
			this.colSqlName1.Name = "colSqlName1";
			this.colSqlName1.OptionsColumn.AllowFocus = false;
			this.colSqlName1.Visible = true;
			this.colSqlName1.VisibleIndex = 0;
			// 
			// colDataType
			// 
			this.colDataType.FieldName = "DataType";
			this.colDataType.Name = "colDataType";
			this.colDataType.OptionsColumn.AllowFocus = false;
			this.colDataType.Visible = true;
			this.colDataType.VisibleIndex = 1;
			// 
			// colAllowNulls
			// 
			this.colAllowNulls.FieldName = "AllowNulls";
			this.colAllowNulls.Name = "colAllowNulls";
			this.colAllowNulls.OptionsColumn.AllowFocus = false;
			this.colAllowNulls.Visible = true;
			this.colAllowNulls.VisibleIndex = 2;
			// 
			// colIsUnique
			// 
			this.colIsUnique.FieldName = "IsUnique";
			this.colIsUnique.Name = "colIsUnique";
			this.colIsUnique.OptionsColumn.AllowFocus = false;
			this.colIsUnique.Visible = true;
			this.colIsUnique.VisibleIndex = 3;
			// 
			// colParentSchema
			// 
			this.colParentSchema.FieldName = "ParentSchema";
			this.colParentSchema.Name = "colParentSchema";
			this.colParentSchema.OptionsColumn.AllowFocus = false;
			this.colParentSchema.Visible = true;
			this.colParentSchema.VisibleIndex = 4;
			// 
			// grid
			// 
			this.grid.DataSource = this.modelBindingSource1;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.columnsView;
			gridLevelNode1.RelationName = "Columns";
			this.grid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MainView = this.schemaView;
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(665, 518);
			this.grid.TabIndex = 0;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.schemaView,
            this.columnsView});
			this.grid.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grid_ViewRegistered);
			// 
			// schemaView
			// 
			this.schemaView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colSqlName,
            this.colSqlSchemaName,
            this.colPrimaryKey});
			this.schemaView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.schemaView.GridControl = this.grid;
			this.schemaView.Name = "schemaView";
			this.schemaView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
			this.schemaView.OptionsDetail.AllowZoomDetail = false;
			this.schemaView.OptionsDetail.ShowDetailTabs = false;
			this.schemaView.OptionsSelection.MultiSelect = true;
			this.schemaView.OptionsView.ColumnAutoWidth = false;
			this.schemaView.OptionsView.ShowGroupPanel = false;
			this.schemaView.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.schemaView_BeforeLeaveRow);
			this.schemaView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.schemaView_CustomUnboundColumnData);
			this.schemaView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.schemaView_KeyDown);
			this.schemaView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.schemaView_MouseUp);
			this.schemaView.DoubleClick += new System.EventHandler(this.schemaView_DoubleClick);
			// 
			// colSelected
			// 
			this.colSelected.Caption = " ";
			this.colSelected.FieldName = "colSelected";
			this.colSelected.Name = "colSelected";
			this.colSelected.OptionsColumn.AllowEdit = false;
			this.colSelected.OptionsColumn.AllowMove = false;
			this.colSelected.OptionsColumn.AllowSize = false;
			this.colSelected.OptionsColumn.FixedWidth = true;
			this.colSelected.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
			this.colSelected.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
			this.colSelected.Visible = true;
			this.colSelected.VisibleIndex = 0;
			this.colSelected.Width = 36;
			// 
			// colSqlName
			// 
			this.colSqlName.FieldName = "SqlName";
			this.colSqlName.Name = "colSqlName";
			this.colSqlName.OptionsColumn.AllowEdit = false;
			this.colSqlName.OptionsColumn.AllowFocus = false;
			this.colSqlName.Visible = true;
			this.colSqlName.VisibleIndex = 2;
			// 
			// colSqlSchemaName
			// 
			this.colSqlSchemaName.FieldName = "SqlSchemaName";
			this.colSqlSchemaName.Name = "colSqlSchemaName";
			this.colSqlSchemaName.OptionsColumn.AllowEdit = false;
			this.colSqlSchemaName.OptionsColumn.AllowFocus = false;
			this.colSqlSchemaName.Visible = true;
			this.colSqlSchemaName.VisibleIndex = 1;
			// 
			// colPrimaryKey
			// 
			this.colPrimaryKey.FieldName = "PrimaryKey";
			this.colPrimaryKey.Name = "colPrimaryKey";
			this.colPrimaryKey.OptionsColumn.AllowEdit = false;
			this.colPrimaryKey.OptionsColumn.AllowFocus = false;
			this.colPrimaryKey.Visible = true;
			this.colPrimaryKey.VisibleIndex = 3;
			// 
			// panelControl1
			// 
			this.panelControl1.Controls.Add(this.ok);
			this.panelControl1.Controls.Add(this.cancel);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 518);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(665, 41);
			this.panelControl1.TabIndex = 1;
			// 
			// ok
			// 
			this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.ok.Location = new System.Drawing.Point(497, 6);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(75, 23);
			this.ok.TabIndex = 1;
			this.ok.Text = "OK";
			// 
			// cancel
			// 
			this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(578, 6);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 0;
			this.cancel.Text = "Cancel";
			// 
			// SchemaSelector
			// 
			this.AcceptButton = this.ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(665, 559);
			this.ControlBox = false;
			this.Controls.Add(this.grid);
			this.Controls.Add(this.panelControl1);
			this.Name = "SchemaSelector";
			this.ShowIcon = false;
			this.Text = "Select Schemas";
			((System.ComponentModel.ISupportInitialize)(this.columnsView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.modelBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.schemaView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl grid;
		private DevExpress.XtraGrid.Views.Grid.GridView schemaView;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton cancel;
		private DevExpress.XtraEditors.SimpleButton ok;
		private DevExpress.XtraGrid.Columns.GridColumn colSqlName;
		private DevExpress.XtraGrid.Columns.GridColumn colSqlSchemaName;
		private DevExpress.XtraGrid.Columns.GridColumn colPrimaryKey;
		private ModelBindingSource modelBindingSource1;
		private DevExpress.XtraGrid.Views.Grid.GridView columnsView;
		private DevExpress.XtraGrid.Columns.GridColumn colSqlName1;
		private DevExpress.XtraGrid.Columns.GridColumn colDataType;
		private DevExpress.XtraGrid.Columns.GridColumn colAllowNulls;
		private DevExpress.XtraGrid.Columns.GridColumn colIsUnique;
		private DevExpress.XtraGrid.Columns.GridColumn colParentSchema;
		private DevExpress.XtraGrid.Columns.GridColumn colSelected;
	}
}