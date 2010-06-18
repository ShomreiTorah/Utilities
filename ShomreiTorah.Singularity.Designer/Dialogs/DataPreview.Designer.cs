namespace ShomreiTorah.Singularity.Designer.Dialogs {
	partial class DataPreview {
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
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.schemaTree = new DevExpress.XtraTreeList.TreeList();
			this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colContent = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.loadedEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.loaderEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.loadingEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
			this.grid = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.schemaTree)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loadedEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loaderEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loadingEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.schemaTree);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.grid);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(898, 571);
			this.splitContainerControl1.SplitterPosition = 244;
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// schemaTree
			// 
			this.schemaTree.Appearance.FocusedCell.BackColor = System.Drawing.Color.Transparent;
			this.schemaTree.Appearance.FocusedCell.Options.UseBackColor = true;
			this.schemaTree.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.HotTrack;
			this.schemaTree.Appearance.FocusedRow.Options.UseBackColor = true;
			this.schemaTree.Appearance.SelectedRow.BackColor = System.Drawing.SystemColors.HotTrack;
			this.schemaTree.Appearance.SelectedRow.Options.UseBackColor = true;
			this.schemaTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colContent});
			this.schemaTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schemaTree.Location = new System.Drawing.Point(0, 0);
			this.schemaTree.Name = "schemaTree";
			this.schemaTree.BeginUnboundLoad();
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, -1);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, 0);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, 1);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, 0);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, 0);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, -1);
			this.schemaTree.AppendNode(new object[] {
            null,
            null}, -1);
			this.schemaTree.EndUnboundLoad();
			this.schemaTree.OptionsView.ShowFocusedFrame = false;
			this.schemaTree.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.loaderEdit,
            this.loadingEdit,
            this.loadedEdit});
			this.schemaTree.RowHeight = 20;
			this.schemaTree.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways;
			this.schemaTree.Size = new System.Drawing.Size(244, 571);
			this.schemaTree.TabIndex = 0;
			this.schemaTree.CustomNodeCellEdit += new DevExpress.XtraTreeList.GetCustomNodeCellEditEventHandler(this.schemaTree_CustomNodeCellEdit);
			this.schemaTree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.schemaTree_FocusedNodeChanged);
			this.schemaTree.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.schemaTree_ShowingEditor);
			// 
			// colName
			// 
			this.colName.Caption = "Schema Name";
			this.colName.FieldName = "Schema Name";
			this.colName.MinWidth = 56;
			this.colName.Name = "colName";
			this.colName.OptionsColumn.AllowEdit = false;
			this.colName.OptionsColumn.AllowFocus = false;
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 110;
			// 
			// colContent
			// 
			this.colContent.Caption = " ";
			this.colContent.ColumnEdit = this.loadedEdit;
			this.colContent.FieldName = " ";
			this.colContent.Name = "colContent";
			this.colContent.Visible = true;
			this.colContent.VisibleIndex = 1;
			this.colContent.Width = 89;
			// 
			// loadedEdit
			// 
			this.loadedEdit.AllowFocused = false;
			this.loadedEdit.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
			this.loadedEdit.Appearance.Options.UseBackColor = true;
			this.loadedEdit.AutoHeight = false;
			this.loadedEdit.Name = "loadedEdit";
			this.loadedEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			// 
			// loaderEdit
			// 
			this.loaderEdit.AllowFocused = false;
			this.loaderEdit.Appearance.BackColor = System.Drawing.SystemColors.HotTrack;
			this.loaderEdit.Appearance.Options.UseBackColor = true;
			this.loaderEdit.AppearanceFocused.BackColor = System.Drawing.SystemColors.HotTrack;
			this.loaderEdit.AppearanceFocused.Options.UseBackColor = true;
			this.loaderEdit.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.HotTrack;
			this.loaderEdit.AppearanceReadOnly.Options.UseBackColor = true;
			this.loaderEdit.AutoHeight = false;
			this.loaderEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Load", 30, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
			this.loaderEdit.Name = "loaderEdit";
			this.loaderEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.loaderEdit.UseParentBackground = true;
			this.loaderEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.loaderEdit_ButtonClick);
			// 
			// loadingEdit
			// 
			this.loadingEdit.Name = "loadingEdit";
			// 
			// grid
			// 
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MainView = this.gridView;
			this.grid.Name = "grid";
			this.grid.Size = new System.Drawing.Size(646, 571);
			this.grid.TabIndex = 0;
			this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.GridControl = this.grid;
			this.gridView.Name = "gridView";
			// 
			// DataPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 571);
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "DataPreview";
			this.Text = "DataPreview";
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.schemaTree)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loadedEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loaderEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loadingEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraTreeList.TreeList schemaTree;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colContent;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit loaderEdit;
		private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar loadingEdit;
		private DevExpress.XtraGrid.GridControl grid;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit loadedEdit;
	}
}