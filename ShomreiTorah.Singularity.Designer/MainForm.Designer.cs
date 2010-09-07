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
			this.appMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
			this.newFile = new DevExpress.XtraBars.BarButtonItem();
			this.openFile = new DevExpress.XtraBars.BarButtonItem();
			this.saveFile = new DevExpress.XtraBars.BarButtonItem();
			this.saveAs = new DevExpress.XtraBars.BarButtonItem();
			this.viewChanges = new DevExpress.XtraBars.BarButtonItem();
			this.diffFormatMenu = new DevExpress.XtraBars.PopupMenu(this.components);
			this.diffXml = new DevExpress.XtraBars.BarButtonItem();
			this.diffCode = new DevExpress.XtraBars.BarButtonItem();
			this.sqlServerImport = new DevExpress.XtraBars.BarButtonItem();
			this.addSchema = new DevExpress.XtraBars.BarButtonItem();
			this.deleteSchema = new DevExpress.XtraBars.BarButtonItem();
			this.generateCode = new DevExpress.XtraBars.BarButtonItem();
			this.previewCode = new DevExpress.XtraBars.BarButtonItem();
			this.saveCode = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
			this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
			this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
			this.previewPanel = new DevExpress.XtraBars.Docking.DockPanel();
			this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.codeEditor = new ShomreiTorah.Singularity.Designer.Controls.CodeEditor();
			this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.diffFormatMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
			this.panelContainer1.SuspendLayout();
			this.dockPanel1.SuspendLayout();
			this.dockPanel1_Container.SuspendLayout();
			this.dockPanel2.SuspendLayout();
			this.dockPanel2_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataContextVGrid)).BeginInit();
			this.previewPanel.SuspendLayout();
			this.dockPanel3_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbon
			// 
			this.ribbon.ApplicationButtonDropDownControl = this.appMenu;
			this.ribbon.ApplicationButtonText = "File";
			this.ribbon.ApplicationCaption = "Singularity Designer";
			this.ribbon.ApplicationIcon = global::ShomreiTorah.Singularity.Designer.Properties.Resources.RibbonIcon;
			// 
			// 
			// 
			this.ribbon.ExpandCollapseItem.Id = 0;
			this.ribbon.ExpandCollapseItem.Name = "";
			this.ribbon.ExpandCollapseItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
			this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.sqlServerImport,
            this.addSchema,
            this.deleteSchema,
            this.generateCode,
            this.previewCode,
            this.saveFile,
            this.newFile,
            this.openFile,
            this.saveAs,
            this.viewChanges,
            this.diffXml,
            this.diffCode,
            this.saveCode});
			this.ribbon.Location = new System.Drawing.Point(0, 0);
			this.ribbon.MaxItemId = 13;
			this.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.ribbon.Name = "ribbon";
			this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
			this.ribbon.SelectedPage = this.ribbonPage1;
			this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.ShowOnMultiplePages;
			this.ribbon.Size = new System.Drawing.Size(938, 148);
			this.ribbon.StatusBar = this.ribbonStatusBar;
			this.ribbon.Toolbar.ItemLinks.Add(this.saveFile);
			// 
			// appMenu
			// 
			this.appMenu.BottomPaneControlContainer = null;
			this.appMenu.ItemLinks.Add(this.newFile);
			this.appMenu.ItemLinks.Add(this.openFile);
			this.appMenu.ItemLinks.Add(this.saveFile);
			this.appMenu.ItemLinks.Add(this.saveAs);
			this.appMenu.ItemLinks.Add(this.viewChanges, true);
			this.appMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText;
			this.appMenu.Name = "appMenu";
			this.appMenu.Ribbon = this.ribbon;
			this.appMenu.RightPaneControlContainer = null;
			this.appMenu.ShowRightPane = true;
			// 
			// newFile
			// 
			this.newFile.Caption = "&New DataContext";
			this.newFile.Id = 6;
			this.newFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
			this.newFile.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.NewFile32;
			this.newFile.Name = "newFile";
			this.newFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newFile_ItemClick);
			// 
			// openFile
			// 
			this.openFile.Caption = "&Open";
			this.openFile.Id = 7;
			this.openFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
			this.openFile.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.Open32;
			this.openFile.Name = "openFile";
			this.openFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.openFile_ItemClick);
			// 
			// saveFile
			// 
			this.saveFile.Caption = "Save";
			this.saveFile.Glyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.Save16;
			this.saveFile.Id = 5;
			this.saveFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
			this.saveFile.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.Save32;
			this.saveFile.Name = "saveFile";
			this.saveFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveFile_ItemClick);
			// 
			// saveAs
			// 
			this.saveAs.Caption = "Save &As";
			this.saveAs.Id = 8;
			this.saveAs.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12);
			this.saveAs.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.SaveAs32;
			this.saveAs.Name = "saveAs";
			this.saveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveAs_ItemClick);
			// 
			// viewChanges
			// 
			this.viewChanges.ActAsDropDown = true;
			this.viewChanges.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.viewChanges.Caption = "View &Changes";
			this.viewChanges.DropDownControl = this.diffFormatMenu;
			this.viewChanges.Id = 9;
			this.viewChanges.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.ViewChanges32;
			this.viewChanges.Name = "viewChanges";
			// 
			// diffFormatMenu
			// 
			this.diffFormatMenu.ItemLinks.Add(this.diffXml);
			this.diffFormatMenu.ItemLinks.Add(this.diffCode);
			this.diffFormatMenu.Name = "diffFormatMenu";
			this.diffFormatMenu.Ribbon = this.ribbon;
			// 
			// diffXml
			// 
			this.diffXml.Caption = "&XML";
			this.diffXml.Id = 10;
			this.diffXml.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.XML32;
			this.diffXml.Name = "diffXml";
			this.diffXml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.diffXml_ItemClick);
			// 
			// diffCode
			// 
			this.diffCode.Caption = "Generated &Code";
			this.diffCode.Id = 11;
			this.diffCode.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.CS32;
			this.diffCode.Name = "diffCode";
			this.diffCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.diffCode_ItemClick);
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
			// generateCode
			// 
			this.generateCode.Caption = "Generate Code";
			this.generateCode.Id = 3;
			this.generateCode.Name = "generateCode";
			this.generateCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.generateCode_ItemClick);
			// 
			// previewCode
			// 
			this.previewCode.Caption = "Preview Code";
			this.previewCode.Id = 4;
			this.previewCode.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.PreviewCode32;
			this.previewCode.Name = "previewCode";
			this.previewCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.previewCode_ItemClick);
			// 
			// saveCode
			// 
			this.saveCode.Caption = "Save Code";
			this.saveCode.Id = 12;
			this.saveCode.LargeGlyph = global::ShomreiTorah.Singularity.Designer.Properties.Resources.SaveCS32;
			this.saveCode.Name = "saveCode";
			this.saveCode.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveCode_ItemClick);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "DataContext";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.addSchema);
			this.ribbonPageGroup2.ItemLinks.Add(this.deleteSchema);
			this.ribbonPageGroup2.MergeOrder = 1;
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "Schemas";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.sqlServerImport);
			this.ribbonPageGroup1.MergeOrder = 99;
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "Import";
			// 
			// ribbonPageGroup3
			// 
			this.ribbonPageGroup3.ItemLinks.Add(this.previewCode);
			this.ribbonPageGroup3.ItemLinks.Add(this.saveCode);
			this.ribbonPageGroup3.ItemLinks.Add(this.generateCode);
			this.ribbonPageGroup3.Name = "ribbonPageGroup3";
			this.ribbonPageGroup3.ShowCaptionButton = false;
			this.ribbonPageGroup3.Text = "Code Generation";
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
            this.panelContainer1,
            this.previewPanel});
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
            this.editorRow1,
            this.editorRow3,
            this.categoryRow1});
			this.dataContextVGrid.Size = new System.Drawing.Size(194, 72);
			this.dataContextVGrid.TabIndex = 0;
			// 
			// editorRow1
			// 
			this.editorRow1.Name = "editorRow1";
			this.editorRow1.Properties.Caption = "DataContext Name";
			this.editorRow1.Properties.FieldName = "Name";
			// 
			// editorRow3
			// 
			this.editorRow3.Name = "editorRow3";
			this.editorRow3.Properties.Caption = "Code Path";
			this.editorRow3.Properties.FieldName = "CodePath";
			// 
			// categoryRow1
			// 
			this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow2});
			this.categoryRow1.Name = "categoryRow1";
			this.categoryRow1.Properties.Caption = "Code Generation";
			// 
			// editorRow2
			// 
			this.editorRow2.Name = "editorRow2";
			this.editorRow2.Properties.Caption = "Namespace";
			this.editorRow2.Properties.FieldName = "Namespace";
			// 
			// previewPanel
			// 
			this.previewPanel.Controls.Add(this.dockPanel3_Container);
			this.previewPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
			this.previewPanel.FloatLocation = new System.Drawing.Point(890, 455);
			this.previewPanel.FloatSize = new System.Drawing.Size(616, 560);
			this.previewPanel.ID = new System.Guid("29ee1638-9cb1-404e-a28c-493b8264be98");
			this.previewPanel.Location = new System.Drawing.Point(0, 0);
			this.previewPanel.Name = "previewPanel";
			this.previewPanel.OriginalSize = new System.Drawing.Size(200, 200);
			this.previewPanel.Size = new System.Drawing.Size(616, 560);
			this.previewPanel.Text = "Code Preview";
			// 
			// dockPanel3_Container
			// 
			this.dockPanel3_Container.Controls.Add(this.elementHost1);
			this.dockPanel3_Container.Location = new System.Drawing.Point(2, 22);
			this.dockPanel3_Container.Name = "dockPanel3_Container";
			this.dockPanel3_Container.Size = new System.Drawing.Size(612, 536);
			this.dockPanel3_Container.TabIndex = 0;
			// 
			// elementHost1
			// 
			this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elementHost1.Location = new System.Drawing.Point(0, 0);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(612, 536);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.codeEditor;
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
			((System.ComponentModel.ISupportInitialize)(this.appMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.diffFormatMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
			this.panelContainer1.ResumeLayout(false);
			this.dockPanel1.ResumeLayout(false);
			this.dockPanel1_Container.ResumeLayout(false);
			this.dockPanel2.ResumeLayout(false);
			this.dockPanel2_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataContextVGrid)).EndInit();
			this.previewPanel.ResumeLayout(false);
			this.dockPanel3_Container.ResumeLayout(false);
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
		private DevExpress.XtraBars.BarButtonItem generateCode;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
		private DevExpress.XtraBars.BarButtonItem previewCode;
		private DevExpress.XtraBars.Docking.DockPanel previewPanel;
		private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private Controls.CodeEditor codeEditor;
		private DevExpress.XtraBars.BarButtonItem saveFile;
		private DevExpress.XtraBars.BarButtonItem newFile;
		private DevExpress.XtraBars.Ribbon.ApplicationMenu appMenu;
		private DevExpress.XtraBars.BarButtonItem openFile;
		private DevExpress.XtraBars.BarButtonItem saveAs;
		private DevExpress.XtraBars.BarButtonItem viewChanges;
		private DevExpress.XtraBars.PopupMenu diffFormatMenu;
		private DevExpress.XtraBars.BarButtonItem diffXml;
		private DevExpress.XtraBars.BarButtonItem diffCode;
		private DevExpress.XtraBars.BarButtonItem saveCode;
		private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
	}
}