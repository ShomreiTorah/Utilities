namespace ShomreiTorah.Singularity.Designer {
	partial class MainForm {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.sqlServerImport = new DevExpress.XtraBars.BarButtonItem();
			this.addSchema = new DevExpress.XtraBars.BarButtonItem();
			this.deleteSchema = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.schemaTree = new ShomreiTorah.Singularity.Designer.Controls.SchemaTree();
			this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.dataContextVGrid = new DevExpress.XtraVerticalGrid.VGridControl();
			this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
			this.panelContainer1.SuspendLayout();
			this.dockPanel1.SuspendLayout();
			this.dockPanel1_Container.SuspendLayout();
			this.dockPanel2.SuspendLayout();
			this.dockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataContextVGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ApplicationButtonText = " ";
			this.ribbon.ApplicationCaption = "Singularity Designer";
			this.ribbon.ApplicationIcon = global::ShomreiTorah.Singularity.Designer.Properties.Resources.RibbonIcon;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.sqlServerImport,
            this.addSchema,
            this.deleteSchema});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 3;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbon.SelectedPage = this.ribbonPage1;
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
			this.ribbon.Size = new System.Drawing.Size(938, 148);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			// 
			// sqlServerImport
			// 
			this.sqlServerImport.Caption = "SQL Server";
			this.sqlServerImport.Id = 0;
			this.sqlServerImport.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.DatabaseServer32;
			this.sqlServerImport.Name = "sqlServerImport";
			this.sqlServerImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sqlServerImport_ItemClick);
			// 
			// addSchema
			// 
			this.addSchema.Caption = "Add Schema";
			this.addSchema.Id = 1;
			this.addSchema.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.AddTable32;
			this.addSchema.Name = "addSchema";
			this.addSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addSchema_ItemClick);
			// 
			// deleteSchema
			// 
			this.deleteSchema.Caption = "Delete Schema";
			this.deleteSchema.Id = 2;
			this.deleteSchema.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.DeleteTable32;
			this.deleteSchema.Name = "deleteSchema";
			this.deleteSchema.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteSchema_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "ribbonPage1";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.addSchema);
			this.ribbonPageGroup2.ItemLinks.Add(this.deleteSchema);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "Schemas";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.sqlServerImport);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "Import";
			// 
			// ribbonStatusBar
			// 
			this.ribbonStatusBar.Location = new System.Drawing.Point(0, 620);
			this.ribbonStatusBar.Name = "ribbonStatusBar";
			this.ribbonStatusBar.Ribbon = this.ribbon;
			this.ribbonStatusBar.Size = new System.Drawing.Size(938, 23);
			// 
			// dockManager
			// 
			this.dockManager.Form = this;
			this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
			this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
			// 
			// panelContainer1
			// 
			this.panelContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
			this.panelContainer1.Appearance.Options.UseBackColor = true;
			this.panelContainer1.Controls.Add(this.dockPanel1);
			this.panelContainer1.Controls.Add(this.dockPanel2);
			this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.panelContainer1.ID = new System.Guid("c8f41b99-e419-4749-99dc-0c00f0645310");
			this.panelContainer1.Location = new System.Drawing.Point(0, 148);
			this.panelContainer1.Name = "panelContainer1";
			this.panelContainer1.OriginalSize = new System.Drawing.Size(200, 200);
			this.panelContainer1.Size = new System.Drawing.Size(200, 472);
			this.panelContainer1.Text = "panelContainer1";
			// 
			// dockPanel1
			// 
			this.dockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
			this.dockPanel1.Appearance.Options.UseBackColor = true;
			this.dockPanel1.Controls.Add(this.dockPanel1_Container);
			this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
			this.dockPanel1.ID = new System.Guid("cb8061cf-b73e-46cd-b8a2-1b792dd354c8");
			this.dockPanel1.Location = new System.Drawing.Point(0, 0);
			this.dockPanel1.Name = "dockPanel1";
			this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
			this.dockPanel1.Size = new System.Drawing.Size(200, 372);
			this.dockPanel1.Text = "Schemas";
			// 
			// dockPanel1_Container
			// 
			this.dockPanel1_Container.Controls.Add(this.schemaTree);
			this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
			this.dockPanel1_Container.Name = "dockPanel1_Container";
			this.dockPanel1_Container.Size = new System.Drawing.Size(194, 344);
			this.dockPanel1_Container.TabIndex = 0;
			// 
			// schemaTree
			// 
			this.schemaTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.schemaTree.Location = new System.Drawing.Point(0, 0);
			this.schemaTree.Name = "schemaTree";
			this.schemaTree.Size = new System.Drawing.Size(194, 344);
			this.schemaTree.TabIndex = 0;
			this.schemaTree.SelectionChanged += new System.EventHandler(this.schemaTree_SelectionChanged);
			this.schemaTree.NodeDoubleClick += new System.EventHandler(this.schemaTree_NodeDoubleClick);
			// 
			// dockPanel2
			// 
			this.dockPanel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
			this.dockPanel2.Appearance.Options.UseBackColor = true;
			this.dockPanel2.Controls.Add(this.dockPanel2_Container);
			this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
			this.dockPanel2.ID = new System.Guid("a886d53e-bdc3-43b0-8182-7a3cb2f5b355");
			this.dockPanel2.Location = new System.Drawing.Point(0, 372);
			this.dockPanel2.Name = "dockPanel2";
			this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
			this.dockPanel2.Size = new System.Drawing.Size(200, 100);
			this.dockPanel2.Text = "DataContext Properties";
			// 
			// dockPanel2_Container
			// 
			this.dockPanel2_Container.Controls.Add(this.dataContextVGrid);
			this.dockPanel2_Container.Location = new System.Drawing.Point(3, 25);
			this.dockPanel2_Container.Name = "dockPanel2_Container";
			this.dockPanel2_Container.Size = new System.Drawing.Size(194, 72);
			this.dockPanel2_Container.TabIndex = 0;
			// 
			// dataContextVGrid
			// 
			this.dataContextVGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataContextVGrid.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
			this.dataContextVGrid.Location = new System.Drawing.Point(0, 0);
			this.dataContextVGrid.Name = "dataContextVGrid";
			this.dataContextVGrid.RecordWidth = 80;
			this.dataContextVGrid.RowHeaderWidth = 120;
			this.dataContextVGrid.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow1});
			this.dataContextVGrid.Size = new System.Drawing.Size(194, 72);
			this.dataContextVGrid.TabIndex = 0;
			// 
			// editorRow1
			// 
			this.editorRow1.Name = "editorRow1";
			this.editorRow1.Properties.Caption = "DataContext Name";
			this.editorRow1.Properties.CustomizationCaption = null;
			this.editorRow1.Properties.FieldName = "Name";
			// 
			// xtraTabbedMdiManager
			// 
			this.xtraTabbedMdiManager.MdiParent = this;
			this.xtraTabbedMdiManager.SetNextMdiChildMode = DevExpress.XtraTabbedMdi.SetNextMdiChildMode.TabControl;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 643);
			this.Controls.Add(this.panelContainer1);
			this.Controls.Add(this.ribbonStatusBar);
			this.Controls.Add(this.ribbon);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.Ribbon = this.ribbon;
			this.StatusBar = this.ribbonStatusBar;
			this.Text = "Singularity Designer";
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
			this.panelContainer1.ResumeLayout(false);
			this.dockPanel1.ResumeLayout(false);
			this.dockPanel1_Container.ResumeLayout(false);
			this.dockPanel2.ResumeLayout(false);
			this.dockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataContextVGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
		private DevExpress.XtraBars.BarButtonItem sqlServerImport;
		private DevExpress.XtraBars.Docking.DockManager dockManager;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
		private Controls.SchemaTree schemaTree;
		private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
		private DevExpress.XtraVerticalGrid.VGridControl dataContextVGrid;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
		private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
		private DevExpress.XtraBars.BarButtonItem addSchema;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem deleteSchema;
	}
}