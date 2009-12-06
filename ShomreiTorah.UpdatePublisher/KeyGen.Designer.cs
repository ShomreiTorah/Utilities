namespace ShomreiTorah.UpdatePublisher {
	partial class KeyGen {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGen));
			this.reencrypt = new DevExpress.XtraEditors.SimpleButton();
			this.newPair = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.cs = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.xml = new DevExpress.XtraEditors.MemoEdit();
			this.baseUri = new DevExpress.XtraEditors.TextEdit();
			this.blobDecryptorAlg = new DevExpress.XtraEditors.ComboBoxEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.rsaKeySize = new DevExpress.XtraEditors.SpinEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.cs.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xml.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.baseUri.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blobDecryptorAlg.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rsaKeySize.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// reencrypt
			// 
			this.reencrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.reencrypt.Location = new System.Drawing.Point(12, 12);
			this.reencrypt.Name = "reencrypt";
			this.reencrypt.Size = new System.Drawing.Size(447, 23);
			this.reencrypt.TabIndex = 0;
			this.reencrypt.Text = "Re-encrypt private key";
			this.reencrypt.Click += new System.EventHandler(this.reencrypt_Click);
			// 
			// newPair
			// 
			this.newPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.newPair.Location = new System.Drawing.Point(12, 41);
			this.newPair.Name = "newPair";
			this.newPair.Size = new System.Drawing.Size(447, 23);
			this.newPair.TabIndex = 0;
			this.newPair.Text = "Generate new keyset";
			this.newPair.Click += new System.EventHandler(this.newPair_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseTextOptions = true;
			this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
			this.labelControl1.LineVisible = true;
			this.labelControl1.Location = new System.Drawing.Point(12, 148);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.labelControl1.Size = new System.Drawing.Size(447, 25);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "PrivateKey.cs";
			// 
			// cs
			// 
			this.cs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cs.EditValue = "Please click a button above.";
			this.cs.Location = new System.Drawing.Point(12, 179);
			this.cs.Name = "cs";
			this.cs.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.cs.Properties.Appearance.Options.UseFont = true;
			this.cs.Properties.ReadOnly = true;
			this.cs.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.cs.Properties.WordWrap = false;
			this.cs.Size = new System.Drawing.Size(447, 128);
			this.cs.TabIndex = 2;
			this.cs.DoubleClick += new System.EventHandler(this.Text_DoubleClick);
			// 
			// labelControl2
			// 
			this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseTextOptions = true;
			this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
			this.labelControl2.LineVisible = true;
			this.labelControl2.Location = new System.Drawing.Point(12, 313);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.labelControl2.Size = new System.Drawing.Size(447, 25);
			this.labelControl2.TabIndex = 1;
			this.labelControl2.Text = "ShomreiTorahConfig.xml";
			// 
			// xml
			// 
			this.xml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.xml.EditValue = "Please click a button above.";
			this.xml.Location = new System.Drawing.Point(12, 344);
			this.xml.Name = "xml";
			this.xml.Properties.Appearance.Font = new System.Drawing.Font("Consolas", 8.25F);
			this.xml.Properties.Appearance.Options.UseFont = true;
			this.xml.Properties.ReadOnly = true;
			this.xml.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.xml.Properties.WordWrap = false;
			this.xml.Size = new System.Drawing.Size(447, 216);
			this.xml.TabIndex = 2;
			this.xml.DoubleClick += new System.EventHandler(this.Text_DoubleClick);
			// 
			// baseUri
			// 
			this.baseUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.baseUri.EditValue = "http://ShomreiTorah.us/Updates/";
			this.baseUri.Location = new System.Drawing.Point(90, 70);
			this.baseUri.Name = "baseUri";
			this.baseUri.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.baseUri_Properties_Validating);
			this.baseUri.Size = new System.Drawing.Size(369, 20);
			this.baseUri.TabIndex = 3;
			// 
			// blobDecryptorAlg
			// 
			this.blobDecryptorAlg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.blobDecryptorAlg.EditValue = "Rijndael";
			this.blobDecryptorAlg.Location = new System.Drawing.Point(90, 96);
			this.blobDecryptorAlg.Name = "blobDecryptorAlg";
			this.blobDecryptorAlg.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.blobDecryptorAlg.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
			this.blobDecryptorAlg.Properties.Items.AddRange(new object[] {
            "Rijndael"});
			this.blobDecryptorAlg.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.blobDecryptorAlg.Size = new System.Drawing.Size(369, 20);
			this.blobDecryptorAlg.TabIndex = 4;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 73);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(40, 13);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "BaseUri:";
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(12, 99);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(72, 13);
			this.labelControl4.TabIndex = 6;
			this.labelControl4.Text = "BlobDecryptor:";
			// 
			// rsaKeySize
			// 
			this.rsaKeySize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.rsaKeySize.EditValue = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			this.rsaKeySize.Location = new System.Drawing.Point(90, 122);
			this.rsaKeySize.Name = "rsaKeySize";
			this.rsaKeySize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.rsaKeySize.Properties.IsFloatValue = false;
			this.rsaKeySize.Properties.Mask.EditMask = "f0";
			this.rsaKeySize.Properties.MaxValue = new decimal(new int[] {
            16384,
            0,
            0,
            0});
			this.rsaKeySize.Properties.MinValue = new decimal(new int[] {
            1024,
            0,
            0,
            0});
			this.rsaKeySize.Size = new System.Drawing.Size(369, 20);
			this.rsaKeySize.TabIndex = 7;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(12, 125);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(67, 13);
			this.labelControl5.TabIndex = 8;
			this.labelControl5.Text = "RSA Key Size:";
			// 
			// KeyGen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 572);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.rsaKeySize);
			this.Controls.Add(this.labelControl4);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.blobDecryptorAlg);
			this.Controls.Add(this.baseUri);
			this.Controls.Add(this.xml);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.cs);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.newPair);
			this.Controls.Add(this.reencrypt);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KeyGen";
			this.Text = "Shomrei Torah Key Generator";
			((System.ComponentModel.ISupportInitialize)(this.cs.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xml.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.baseUri.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blobDecryptorAlg.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rsaKeySize.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton reencrypt;
		private DevExpress.XtraEditors.SimpleButton newPair;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.MemoEdit cs;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.MemoEdit xml;
		private DevExpress.XtraEditors.TextEdit baseUri;
		private DevExpress.XtraEditors.ComboBoxEdit blobDecryptorAlg;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl4;
		private DevExpress.XtraEditors.SpinEdit rsaKeySize;
		private DevExpress.XtraEditors.LabelControl labelControl5;

	}
}