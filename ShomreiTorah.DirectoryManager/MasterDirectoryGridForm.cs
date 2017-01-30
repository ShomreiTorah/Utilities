using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ShomreiTorah.Data;

namespace ShomreiTorah.DirectoryManager {
	partial class MasterDirectoryGridForm : XtraForm {
		public MasterDirectoryGridForm() {
			InitializeComponent();
			gridView.ActiveFilterString = "TotalPledged <> 0 OR TotalPaid <> 0";
		}

		private void mergeSelected_ItemClick(object sender, ItemClickEventArgs e) {
			var selection = gridView.GetSelectedRows().Select(gridView.GetRow).Cast<Person>();
			new MergeForm(selection.Select(Program.DataManager.GetPerson)).ShowDialog(MdiParent);
		}

		private void gridView_SelectionChanged(object sender, SelectionChangedEventArgs e) {
			mergeSelected.Enabled = gridView.SelectedRowsCount > 1;
		}
	}
}