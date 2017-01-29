namespace ShomreiTorah.DirectoryManager {
	partial class MainForm {
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
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.showGridForm = new DevExpress.XtraBars.BarButtonItem();
			this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
			this.personSelector = new ShomreiTorah.Data.UI.Controls.PersonSelector();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personSelector.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.AutoSizeItems = true;
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.showGridForm});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 2;
			this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.PageHeaderItemLinks.Add(this.showGridForm);
			this.ribbonControl1.QuickToolbarItemLinks.Add(this.showGridForm);
			this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
			this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.ribbonControl1.Size = new System.Drawing.Size(921, 49);
			// 
			// showGridForm
			// 
			this.showGridForm.Caption = "Show all people";
			this.showGridForm.Id = 1;
			this.showGridForm.ImageOptions.Image = global::ShomreiTorah.DirectoryManager.Properties.Resources.Grid16;
			this.showGridForm.Name = "showGridForm";
			this.showGridForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showGridForm_ItemClick);
			// 
			// xtraTabbedMdiManager1
			// 
			this.xtraTabbedMdiManager1.FloatOnDrag = DevExpress.Utils.DefaultBoolean.True;
			this.xtraTabbedMdiManager1.MdiParent = this;
			// 
			// personSelector
			// 
			this.personSelector.Dock = System.Windows.Forms.DockStyle.Top;
			this.personSelector.Location = new System.Drawing.Point(0, 49);
			this.personSelector.MenuManager = this.ribbonControl1;
			this.personSelector.Name = "personSelector";
			toolTipItem1.Text = "Click to select a person";
			superToolTip1.Items.Add(toolTipItem1);
			toolTipTitleItem1.Text = "New Person...";
			toolTipItem2.Text = "Adds a new person to the master directory";
			superToolTip2.Items.Add(toolTipTitleItem1);
			superToolTip2.Items.Add(toolTipItem2);
			this.personSelector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, superToolTip1, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "New person...", 90, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleLeft, ((System.Drawing.Image)(resources.GetObject("personSelector.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, superToolTip2, true)});
			this.personSelector.Properties.NewPersonTemplate = null;
			this.personSelector.Size = new System.Drawing.Size(921, 20);
			this.personSelector.TabIndex = 2;
			this.personSelector.EditValueChanged += new System.EventHandler(this.personSelector_EditValueChanged);
			// 
			// MainForm
			// 
			this.AllowMdiBar = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 589);
			this.Controls.Add(this.personSelector);
			this.Controls.Add(this.ribbonControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Name = "MainForm";
			this.Ribbon = this.ribbonControl1;
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personSelector.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
		private Data.UI.Controls.PersonSelector personSelector;
		private DevExpress.XtraBars.BarButtonItem showGridForm;
	}
}