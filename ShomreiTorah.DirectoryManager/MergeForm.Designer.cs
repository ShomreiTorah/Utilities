namespace ShomreiTorah.DirectoryManager {
	partial class MergeForm {
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
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.cancel = new DevExpress.XtraEditors.SimpleButton();
			this.merge = new DevExpress.XtraEditors.SimpleButton();
			this.label = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControl1
			// 
			this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridControl1.Location = new System.Drawing.Point(12, 79);
			this.gridControl1.MainView = this.gridView;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(706, 292);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
			// 
			// gridView
			// 
			this.gridView.GridControl = this.gridControl1;
			this.gridView.Name = "gridView";
			this.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
			this.gridView.OptionsDetail.EnableDetailToolTip = true;
			this.gridView.OptionsView.AllowCellMerge = true;
			this.gridView.OptionsView.ShowGroupPanel = false;
			this.gridView.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView_CellMerge);
			this.gridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_RowStyle);
			this.gridView.MasterRowGetLevelDefaultView += new DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventHandler(this.gridView_MasterRowGetLevelDefaultView);
			this.gridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView_ShowingEditor);
			this.gridView.DoubleClick += new System.EventHandler(this.gridView_DoubleClick);
			// 
			// cancel
			// 
			this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancel.Location = new System.Drawing.Point(643, 377);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(75, 23);
			this.cancel.TabIndex = 1;
			this.cancel.Text = "Cancel";
			// 
			// merge
			// 
			this.merge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.merge.Location = new System.Drawing.Point(562, 377);
			this.merge.Name = "merge";
			this.merge.Size = new System.Drawing.Size(75, 23);
			this.merge.TabIndex = 2;
			this.merge.Text = "Merge";
			this.merge.Click += new System.EventHandler(this.merge_Click);
			// 
			// label
			// 
			this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label.Appearance.Options.UseTextOptions = true;
			this.label.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.label.AutoEllipsis = true;
			this.label.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.label.Location = new System.Drawing.Point(12, 12);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(706, 49);
			this.label.TabIndex = 3;
			this.label.Text = "labelControl1\r\nLine 2";
			this.label.UseMnemonic = false;
			// 
			// MergeForm
			// 
			this.AcceptButton = this.merge;
			this.CancelButton = this.cancel;
			this.ClientSize = new System.Drawing.Size(730, 412);
			this.Controls.Add(this.label);
			this.Controls.Add(this.merge);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.gridControl1);
			this.Name = "MergeForm";
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl gridControl1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView;
		private DevExpress.XtraEditors.SimpleButton cancel;
		private DevExpress.XtraEditors.SimpleButton merge;
		private DevExpress.XtraEditors.LabelControl label;
	}
}
