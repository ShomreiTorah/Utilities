namespace ShomreiTorah.DirectoryManager {
	partial class PersonForm {
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
			this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.tabs = new DevExpress.XtraTab.XtraTabControl();
			this.deletePerson = new DevExpress.XtraBars.BarButtonItem();
			this.mergePerson = new DevExpress.XtraBars.BarButtonItem();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.personInfo = new DevExpress.XtraBars.BarStaticItem();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabs)).BeginInit();
			this.SuspendLayout();
			// 
			// ribbonControl1
			// 
			this.ribbonControl1.ExpandCollapseItem.Id = 0;
			this.ribbonControl1.ExpandCollapseItem.Name = "";
			this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.deletePerson,
            this.mergePerson,
            this.personInfo});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 4;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.Size = new System.Drawing.Size(927, 142);
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Person";
			// 
			// ribbonPageGroup1
			// 
			this.ribbonPageGroup1.ItemLinks.Add(this.mergePerson);
			this.ribbonPageGroup1.ItemLinks.Add(this.deletePerson);
			this.ribbonPageGroup1.Name = "ribbonPageGroup1";
			this.ribbonPageGroup1.ShowCaptionButton = false;
			this.ribbonPageGroup1.Text = "Operations";
			// 
			// tabs
			// 
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 142);
			this.tabs.Name = "tabs";
			this.tabs.Size = new System.Drawing.Size(927, 230);
			this.tabs.TabIndex = 1;
			// 
			// deletePerson
			// 
			this.deletePerson.Caption = "Delete";
			this.deletePerson.Id = 1;
			this.deletePerson.Name = "deletePerson";
			// 
			// mergePerson
			// 
			this.mergePerson.Caption = "Merge into other";
			this.mergePerson.Id = 2;
			this.mergePerson.Name = "mergePerson";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.personInfo);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "Info";
			// 
			// personInfo
			// 
			this.personInfo.Caption = "personInfo";
			this.personInfo.Id = 3;
			this.personInfo.Name = "personInfo";
			this.personInfo.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// PersonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 372);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.ribbonControl1);
			this.Name = "PersonForm";
			this.Text = "PersonForm";
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabs)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
		private DevExpress.XtraBars.BarButtonItem deletePerson;
		private DevExpress.XtraBars.BarButtonItem mergePerson;
		private DevExpress.XtraTab.XtraTabControl tabs;
		private DevExpress.XtraBars.BarStaticItem personInfo;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
	}
}