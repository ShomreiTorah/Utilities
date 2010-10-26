namespace YKLookup {
	partial class LookupForm {
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
			this.groupControl = new DevExpress.XtraEditors.PanelControl();
			this.map = new ShomreiTorah.WinForms.Controls.GoogleMapControl();
			this.personDetails = new DevExpress.XtraEditors.MemoEdit();
			this.selector = new ShomreiTorah.WinForms.Controls.Lookup.ItemSelector();
			((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
			this.groupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.personDetails.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.selector.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// groupControl
			// 
			this.groupControl.Controls.Add(this.map);
			this.groupControl.Controls.Add(this.personDetails);
			this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl.Location = new System.Drawing.Point(0, 20);
			this.groupControl.Name = "groupControl";
			this.groupControl.Size = new System.Drawing.Size(520, 154);
			this.groupControl.TabIndex = 0;
			this.groupControl.Text = "groupControl1";
			// 
			// map
			// 
			this.map.Dock = System.Windows.Forms.DockStyle.Fill;
			this.map.Location = new System.Drawing.Point(181, 22);
			this.map.Name = "map";
			this.map.Size = new System.Drawing.Size(337, 130);
			this.map.TabIndex = 0;
			this.map.Text = "googleMapControl1";
			// 
			// personDetails
			// 
			this.personDetails.Dock = System.Windows.Forms.DockStyle.Left;
			this.personDetails.EditValue = "Address Goes Here";
			this.personDetails.Location = new System.Drawing.Point(2, 22);
			this.personDetails.Name = "personDetails";
			this.personDetails.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
			this.personDetails.Properties.Appearance.Options.UseFont = true;
			this.personDetails.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Window;
			this.personDetails.Properties.AppearanceReadOnly.Options.UseBackColor = true;
			this.personDetails.Properties.ReadOnly = true;
			this.personDetails.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.personDetails.Properties.UseParentBackground = true;
			this.personDetails.Size = new System.Drawing.Size(200, 130);
			this.personDetails.TabIndex = 1;
			// 
			// selector
			// 
			this.selector.Dock = System.Windows.Forms.DockStyle.Top;
			this.selector.Location = new System.Drawing.Point(0, 0);
			this.selector.Name = "selector";
			this.selector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.selector.Properties.NullValuePrompt = "Click here to select a person, or type to search";
			this.selector.Size = new System.Drawing.Size(520, 20);
			this.selector.TabIndex = 1;
			this.selector.EditValueChanged += new System.EventHandler(this.selector_EditValueChanged);
			// 
			// LookupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 174);
			this.Controls.Add(this.groupControl);
			this.Controls.Add(this.selector);
			this.MaximizeBox = false;
			this.Name = "LookupForm";
			this.Text = "YK Lookup";
			((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
			this.groupControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.personDetails.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.selector.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PanelControl groupControl;
		private ShomreiTorah.WinForms.Controls.GoogleMapControl map;
		private DevExpress.XtraEditors.MemoEdit personDetails;
		private ShomreiTorah.WinForms.Controls.Lookup.ItemSelector selector;
	}
}

