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
			this.deletePerson = new DevExpress.XtraBars.BarButtonItem();
			this.mergePerson = new DevExpress.XtraBars.BarButtonItem();
			this.infoSource = new DevExpress.XtraBars.BarStaticItem();
			this.infoStripeId = new DevExpress.XtraBars.BarStaticItem();
			this.infoYKID = new DevExpress.XtraBars.BarStaticItem();
			this.personInfo = new DevExpress.XtraBars.BarEditItem();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.tabs = new DevExpress.XtraTab.XtraTabControl();
			((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
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
            this.infoSource,
            this.infoStripeId,
            this.infoYKID,
            this.personInfo});
			this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
			this.ribbonControl1.MaxItemId = 8;
			this.ribbonControl1.Name = "ribbonControl1";
			this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
			this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
			this.ribbonControl1.Size = new System.Drawing.Size(927, 142);
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
			// infoSource
			// 
			this.infoSource.Caption = "Source: ";
			this.infoSource.Id = 4;
			this.infoSource.Name = "infoSource";
			this.infoSource.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// infoStripeId
			// 
			this.infoStripeId.Caption = "Stripe ID: ";
			this.infoStripeId.Id = 5;
			this.infoStripeId.Name = "infoStripeId";
			this.infoStripeId.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// infoYKID
			// 
			this.infoYKID.Caption = "YKID: ";
			this.infoYKID.Id = 6;
			this.infoYKID.Name = "infoYKID";
			this.infoYKID.TextAlignment = System.Drawing.StringAlignment.Near;
			// 
			// personInfo
			// 
			this.personInfo.CanOpenEdit = false;
			this.personInfo.Edit = this.repositoryItemMemoEdit1;
			this.personInfo.EditHeight = 60;
			this.personInfo.Id = 7;
			this.personInfo.ItemAppearance.Normal.BackColor = System.Drawing.Color.Transparent;
			this.personInfo.ItemAppearance.Normal.Options.UseBackColor = true;
			this.personInfo.Name = "personInfo";
			this.personInfo.Width = 160;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.AllowFocused = false;
			this.repositoryItemMemoEdit1.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.repositoryItemMemoEdit1.Appearance.Options.UseBackColor = true;
			this.repositoryItemMemoEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			this.repositoryItemMemoEdit1.ReadOnly = true;
			// 
			// ribbonPage1
			// 
			this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
			this.ribbonPage1.Name = "ribbonPage1";
			this.ribbonPage1.Text = "Person";
			// 
			// ribbonPageGroup2
			// 
			this.ribbonPageGroup2.ItemLinks.Add(this.personInfo, true);
			this.ribbonPageGroup2.ItemLinks.Add(this.infoSource, true);
			this.ribbonPageGroup2.ItemLinks.Add(this.infoStripeId);
			this.ribbonPageGroup2.ItemLinks.Add(this.infoYKID);
			this.ribbonPageGroup2.Name = "ribbonPageGroup2";
			this.ribbonPageGroup2.ShowCaptionButton = false;
			this.ribbonPageGroup2.Text = "Info";
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
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
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
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarStaticItem infoSource;
		private DevExpress.XtraBars.BarStaticItem infoStripeId;
		private DevExpress.XtraBars.BarStaticItem infoYKID;
		private DevExpress.XtraBars.BarEditItem personInfo;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
	}
}