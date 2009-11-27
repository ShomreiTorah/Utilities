namespace ShomreiTorah.UpdatePublisher {
	partial class UpdateDetails {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
			DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
			DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDetails));
			this.colState = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.descriptionText = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.files = new DevExpress.XtraTreeList.TreeList();
			this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colSize = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.colExt = new DevExpress.XtraTreeList.Columns.TreeListColumn();
			this.icons = new DevExpress.Utils.ImageCollection(this.components);
			this.caption = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.descriptionText.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.files)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icons)).BeginInit();
			this.SuspendLayout();
			// 
			// colState
			// 
			this.colState.Caption = "State";
			this.colState.FieldName = "State";
			this.colState.Name = "colState";
			this.colState.OptionsColumn.AllowEdit = false;
			this.colState.OptionsColumn.AllowFocus = false;
			this.colState.OptionsColumn.ShowInCustomizationForm = false;
			// 
			// descriptionText
			// 
			this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionText.Location = new System.Drawing.Point(12, 57);
			this.descriptionText.Name = "descriptionText";
			this.descriptionText.Size = new System.Drawing.Size(262, 96);
			this.descriptionText.TabIndex = 8;
			this.descriptionText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.descriptionText_KeyUp);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 38);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(95, 13);
			this.labelControl1.TabIndex = 7;
			this.labelControl1.Text = "Update Description:";
			// 
			// files
			// 
			this.files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.files.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colSize,
            this.colExt,
            this.colState});
			styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime;
			styleFormatCondition1.Appearance.Options.UseBackColor = true;
			styleFormatCondition1.ApplyToRow = true;
			styleFormatCondition1.Column = this.colState;
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
			styleFormatCondition1.Value1 = 1;
			styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Yellow;
			styleFormatCondition2.Appearance.Options.UseBackColor = true;
			styleFormatCondition2.ApplyToRow = true;
			styleFormatCondition2.Column = this.colState;
			styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
			styleFormatCondition2.Value1 = 2;
			styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			styleFormatCondition3.Appearance.Options.UseBackColor = true;
			styleFormatCondition3.ApplyToRow = true;
			styleFormatCondition3.Column = this.colState;
			styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
			styleFormatCondition3.Value1 = 3;
			this.files.FormatConditions.AddRange(new DevExpress.XtraTreeList.StyleFormatConditions.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3});
			this.files.KeyFieldName = "FullPath";
			this.files.Location = new System.Drawing.Point(12, 179);
			this.files.Name = "files";
			this.files.OptionsBehavior.Editable = false;
			this.files.OptionsBehavior.ResizeNodes = false;
			this.files.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.files.OptionsSelection.EnableAppearanceFocusedRow = false;
			this.files.OptionsView.ShowColumns = false;
			this.files.OptionsView.ShowHorzLines = false;
			this.files.OptionsView.ShowIndicator = false;
			this.files.OptionsView.ShowVertLines = false;
			this.files.ParentFieldName = "ParentDirectory";
			this.files.Size = new System.Drawing.Size(262, 358);
			this.files.StateImageList = this.icons;
			this.files.TabIndex = 6;
			this.files.GetStateImage += new DevExpress.XtraTreeList.GetStateImageEventHandler(this.files_GetStateImage);
			this.files.GetNodeDisplayValue += new DevExpress.XtraTreeList.GetNodeDisplayValueEventHandler(this.files_GetNodeDisplayValue);
			// 
			// colName
			// 
			this.colName.Caption = "Name";
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.OptionsColumn.AllowEdit = false;
			this.colName.OptionsColumn.AllowFocus = false;
			this.colName.OptionsColumn.ReadOnly = true;
			this.colName.Visible = true;
			this.colName.VisibleIndex = 0;
			this.colName.Width = 174;
			// 
			// colSize
			// 
			this.colSize.Caption = "Size";
			this.colSize.FieldName = "Size";
			this.colSize.MinWidth = 65;
			this.colSize.Name = "colSize";
			this.colSize.OptionsColumn.AllowEdit = false;
			this.colSize.OptionsColumn.AllowFocus = false;
			this.colSize.OptionsColumn.ReadOnly = true;
			this.colSize.Visible = true;
			this.colSize.VisibleIndex = 1;
			this.colSize.Width = 67;
			// 
			// colExt
			// 
			this.colExt.Caption = "Extension";
			this.colExt.FieldName = "Extension";
			this.colExt.Name = "colExt";
			this.colExt.OptionsColumn.AllowEdit = false;
			this.colExt.OptionsColumn.AllowFocus = false;
			this.colExt.OptionsColumn.ReadOnly = true;
			this.colExt.OptionsColumn.ShowInCustomizationForm = false;
			this.colExt.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			// 
			// icons
			// 
			this.icons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icons.ImageStream")));
			// 
			// caption
			// 
			this.caption.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.caption.Appearance.Options.UseFont = true;
			this.caption.Appearance.Options.UseTextOptions = true;
			this.caption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.caption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.caption.Dock = System.Windows.Forms.DockStyle.Top;
			this.caption.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
			this.caption.LineVisible = true;
			this.caption.Location = new System.Drawing.Point(0, 0);
			this.caption.Name = "caption";
			this.caption.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.caption.Size = new System.Drawing.Size(286, 26);
			this.caption.TabIndex = 5;
			this.caption.Text = "labelControl1";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 160);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(25, 13);
			this.labelControl2.TabIndex = 9;
			this.labelControl2.Text = "Files:";
			// 
			// UpdateDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.descriptionText);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.files);
			this.Controls.Add(this.caption);
			this.Name = "UpdateDetails";
			this.Size = new System.Drawing.Size(286, 543);
			((System.ComponentModel.ISupportInitialize)(this.descriptionText.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.files)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icons)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.MemoEdit descriptionText;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraTreeList.TreeList files;
		private DevExpress.XtraEditors.LabelControl caption;
		private DevExpress.Utils.ImageCollection icons;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colSize;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colExt;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraTreeList.Columns.TreeListColumn colState;
	}
}
