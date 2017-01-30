using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Singularity;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.DirectoryManager {
	public partial class MergeForm : XtraForm {
		readonly IReadOnlyList<PersonRowData> sources;
		readonly List<Person> gridSource;
		readonly PersonRowData target;
		readonly Person targetEditor;

		///<summary>Columns with conflicting source data that the user must manually resolve.</summary>
		readonly List<Column> requiredColumns = new List<Column>();
		public MergeForm(IEnumerable<PersonRowData> sources, string caption) {
			InitializeComponent();

			sources = this.sources = sources.ToList();
			target = this.sources.Last();

			label.Text = caption;
			Text = $"Merge {this.sources.Count} people";

			targetEditor = InitializeTargetEditor();
			gridSource = this.sources.Select(s => s.Person).ToList();
			gridSource.Add(targetEditor);
			gridControl1.DataSource = gridSource;
			// Remove grid columns from detail views or other non-data properties
			foreach (var gridColumn in gridView.Columns.ToList()) {
				if (gridColumn.FieldName == nameof(Extensions.UIId)
				 || gridColumn.FieldName == Person.IdColumn.Name
				 || Person.Schema.Columns[gridColumn.FieldName]?.ReadOnly != false)
					gridView.Columns.Remove(gridColumn);
			}
			gridView.BestFitColumns();
		}

		public MergeForm(IEnumerable<PersonRowData> sources) : this(sources, "Loading...") {
			ThreadPool.QueueUserWorkItem(_ => ComputeCaption());
		}

		private void merge_Click(object sender, EventArgs e) {
			var remainingConflicts = requiredColumns
				.Where(c => Equals(targetEditor[c], c.DefaultValue))
				.ToList();
			if (remainingConflicts.Any()
			&& !Dialog.Warn("The following columns had conflicting values and are still blank.  "
						  + "Are you sure you want to drop them from the merge?\n\n" + remainingConflicts.Join(", ", c => c.Name)))
				return;

			target.Person.AssignFrom(targetEditor);
			DialogResult = DialogResult.OK;
		}

		void ComputeCaption() {
			int rowCount;
			using (var transaction = target.Owner.Connection.BeginTransaction()) {
				rowCount = PerformMerge(transaction);
				transaction.Rollback();
			}

			BeginInvoke(new Action(delegate {
				label.Text = $"Are you sure you want to merge {sources.Count} people?  "
						   + $"This will affect {rowCount} rows.  Update the merged person at the bottom of this grid.";
			}));
		}

		int PerformMerge(DbTransaction transaction) {
			return sources.Where(s => s != target).Sum(s => s.Owner.MergePerson(transaction, s, target.Person));
		}

		private void gridView_RowStyle(object sender, RowStyleEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == targetEditor)
				e.Appearance.FontStyleDelta = FontStyle.Bold;
			else
				e.Appearance.BackColor = SystemColors.Control;
		}

		private void gridView_ShowingEditor(object sender, CancelEventArgs e) {
			e.Cancel = gridView.GetFocusedRow() != targetEditor;
		}

		Person InitializeTargetEditor() {
			var retVal = new Person();

			foreach (var column in Person.Schema.Columns.Where(c => !c.ReadOnly && c.Name != nameof(Extensions.UIId))) {
				var values = sources
					.Select(r => r.Person[column])
					.Where(v => !Equals(v, column.DefaultValue))
					.Distinct()
					.ToList();
				switch (values.Count) {
					case 0: break;  // If none of the source rows have data, we don't are about this column.
					case 1:         // If all of the source rows agree, use their value as-is.
						retVal[column] = values[0];
						break;
					default:        // If the source rows have conflicting values, force the user to choose.
						requiredColumns.Add(column);
						break;
				}
			}
			retVal[nameof(Extensions.UIId)] = target.Person.UIId();
			return retVal;
		}

		#region Master-detail
		private void gridView_MasterRowGetChildList(object sender, MasterRowGetChildListEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == targetEditor)
				return;

			var rowData = sources[gridView.GetDataSourceRowIndex(e.RowHandle)];
			e.ChildList = ((IListSource)rowData.DataSet.Tables[e.RelationIndex]).GetList();
		}

		private void gridView_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == targetEditor)
				return;

			var rowData = sources[gridView.GetDataSourceRowIndex(e.RowHandle)];
			e.RelationCount = rowData.DataSet.Tables.Count;
		}

		private void gridView_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e) {
		}
		private void gridView_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == targetEditor)
				return;

			var rowData = sources[gridView.GetDataSourceRowIndex(e.RowHandle)];
			e.RelationName = rowData.DataSet.Tables[e.RelationName].TableName;
		}

		private void gridView_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == targetEditor)
				return;
			e.IsEmpty = false;
		}
		#endregion

		private void gridView_CellMerge(object sender, CellMergeEventArgs e) {
			if (gridView.GetRow(e.RowHandle1) == targetEditor
			 || gridView.GetRow(e.RowHandle2) == targetEditor) {
				e.Handled = true;
				e.Merge = false;
			}
		}

		private void gridView_DoubleClick(object sender, EventArgs e) {
			var info = gridView.CalcHitInfo(gridView.GridControl.PointToClient(MousePosition));

			if (!info.InRow || gridView.GetRow(info.RowHandle) == targetEditor)
				return;
			if (e is DXMouseEventArgs dx) dx.Handled = true;

			gridView.SetRowCellValue(
				gridView.GetRowHandle(gridSource.Count - 1),
				info.Column,
				gridView.GetRowCellValue(info.RowHandle, info.Column)
			);
		}

	}
}
