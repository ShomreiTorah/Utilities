namespace ShomreiTorah.UpdatePublisher {
	partial class EntryForm {
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
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.cancel = new DevExpress.XtraEditors.SimpleButton();
			this.ok = new DevExpress.XtraEditors.SimpleButton();
			this.oldUpdate = new ShomreiTorah.UpdatePublisher.UpdateDetails();
			this.newUpdate = new ShomreiTorah.UpdatePublisher.UpdateDetails();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
			this.panelControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.oldUpdate);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.newUpdate);
			this.splitContainerControl1.Panel2.Controls.Add(this.panelControl1);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(674, 551);
			this.splitContainerControl1.SplitterPosition = 333;
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// panelControl1
			// 
			this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.panelControl1.Controls.Add(this.ok);
			this.panelControl1.Controls.Add(this.cancel);
			this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelControl1.Location = new System.Drawing.Point(0, 511);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new System.Drawing.Size(333, 40);
			this.panelControl1.TabIndex = 0;
			// 
			// cancel
			// 
			this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(246, 5);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 0;
			this.cancel.Text = "Quit";
			// 
			// ok
			// 
			this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ok.Location = new System.Drawing.Point(152, 5);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(88, 23);
			this.ok.TabIndex = 1;
			this.ok.Text = "Publish Update";
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// oldUpdate
			// 
			this.oldUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.oldUpdate.Location = new System.Drawing.Point(0, 0);
			this.oldUpdate.Name = "oldUpdate";
			this.oldUpdate.Size = new System.Drawing.Size(333, 551);
			this.oldUpdate.TabIndex = 0;
			// 
			// newUpdate
			// 
			this.newUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.newUpdate.Location = new System.Drawing.Point(0, 0);
			this.newUpdate.Name = "newUpdate";
			this.newUpdate.Size = new System.Drawing.Size(333, 511);
			this.newUpdate.TabIndex = 1;
			// 
			// EntryForm
			// 
			this.AcceptButton = this.ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(674, 551);
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "EntryForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private UpdateDetails oldUpdate;
		private DevExpress.XtraEditors.PanelControl panelControl1;
		private DevExpress.XtraEditors.SimpleButton cancel;
		private UpdateDetails newUpdate;
		private DevExpress.XtraEditors.SimpleButton ok;
	}
}