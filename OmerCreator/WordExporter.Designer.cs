namespace OmerCreator {
	partial class WordExporter {
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
			this.progress = new System.Windows.Forms.ProgressBar();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progress
			// 
			this.progress.Location = new System.Drawing.Point(12, 71);
			this.progress.Maximum = 49;
			this.progress.Name = "progress";
			this.progress.Size = new System.Drawing.Size(492, 23);
			this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.progress.TabIndex = 1;
			// 
			// label
			// 
			this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.label.AutoEllipsis = true;
			this.label.Font = new System.Drawing.Font("David", 14F);
			this.label.Location = new System.Drawing.Point(12, 9);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(492, 59);
			this.label.TabIndex = 2;
			this.label.Text = "Creating document...";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WordExporter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(516, 106);
			this.Controls.Add(this.label);
			this.Controls.Add(this.progress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "WordExporter";
			this.Text = "WordExporter";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar progress;
		private System.Windows.Forms.Label label;
	}
}