namespace OmerCreator {
	partial class UI {
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
			this.label1 = new System.Windows.Forms.Label();
			this.hebrewYear = new System.Windows.Forms.NumericUpDown();
			this.includeנקודות = new System.Windows.Forms.CheckBox();
			this.go = new System.Windows.Forms.Button();
			this.output = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.hebrewYear)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hebrew Year:";
			// 
			// hebrewYear
			// 
			this.hebrewYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.hebrewYear.Location = new System.Drawing.Point(90, 7);
			this.hebrewYear.Maximum = new decimal(new int[] {
            5999,
            0,
            0,
            0});
			this.hebrewYear.Minimum = new decimal(new int[] {
            5344,
            0,
            0,
            0});
			this.hebrewYear.Name = "hebrewYear";
			this.hebrewYear.Size = new System.Drawing.Size(54, 20);
			this.hebrewYear.TabIndex = 1;
			this.hebrewYear.Value = new decimal(new int[] {
            5769,
            0,
            0,
            0});
			// 
			// includeנקודות
			// 
			this.includeנקודות.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.includeנקודות.Checked = true;
			this.includeנקודות.CheckState = System.Windows.Forms.CheckState.Checked;
			this.includeנקודות.Location = new System.Drawing.Point(12, 33);
			this.includeנקודות.Name = "includeנקודות";
			this.includeנקודות.Size = new System.Drawing.Size(132, 17);
			this.includeנקודות.TabIndex = 2;
			this.includeנקודות.Text = "Include נקודות";
			this.includeנקודות.UseVisualStyleBackColor = true;
			// 
			// go
			// 
			this.go.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.go.Location = new System.Drawing.Point(12, 84);
			this.go.Name = "go";
			this.go.Size = new System.Drawing.Size(132, 23);
			this.go.TabIndex = 3;
			this.go.Text = "Create";
			this.go.UseVisualStyleBackColor = true;
			this.go.Click += new System.EventHandler(this.go_Click);
			// 
			// output
			// 
			this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.output.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.output.FormattingEnabled = true;
			this.output.Items.AddRange(new object[] {
            "Dialog Box",
            "Word Document"});
			this.output.Location = new System.Drawing.Point(12, 56);
			this.output.Name = "output";
			this.output.Size = new System.Drawing.Size(132, 21);
			this.output.TabIndex = 4;
			// 
			// UI
			// 
			this.AcceptButton = this.go;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(156, 119);
			this.Controls.Add(this.output);
			this.Controls.Add(this.go);
			this.Controls.Add(this.includeנקודות);
			this.Controls.Add(this.hebrewYear);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UI";
			this.Text = "ספירת העומר";
			((System.ComponentModel.ISupportInitialize)(this.hebrewYear)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown hebrewYear;
		private System.Windows.Forms.CheckBox includeנקודות;
		private System.Windows.Forms.Button go;
		private System.Windows.Forms.ComboBox output;
	}
}

