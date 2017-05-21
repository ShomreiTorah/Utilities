using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Singularity;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.DirectoryManager {
	public partial class MergeForm : XtraForm {
		readonly GridList gridSource;
		readonly PersonRowData target;

		public MergeForm(IEnumerable<PersonRowData> sources, string caption) {
			InitializeComponent();

			gridSource = new GridList(sources);

			target = gridSource.Sources.Last();

			label.Text = caption;
			Text = $"Merge {gridSource.Sources.Count} people";

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
			var remainingConflicts = gridSource.RequiredColumns
				.Where(c => Equals(gridSource.TargetEditor[c], c.DefaultValue))
				.ToList();
			if (remainingConflicts.Any()
			&& !Dialog.Warn("The following columns had conflicting values and are still blank.  "
						  + "Are you sure you want to drop them from the merge?\n\n" + remainingConflicts.Join(", ", c => c.Name)))
				return;

			target.Person.AssignFrom(gridSource.TargetEditor);
			// Prevent errors from non-nullable columns.
			target.Person.Phone = target.Person.Phone ?? "";
			target.Person.Salutation = target.Person.Salutation ?? "";
			Program.Current.SaveDatabase();
			using (var transaction = target.Owner.Connection.BeginTransaction()) {
				PerformMerge(transaction);
				transaction.Commit();
			}
			Program.Current.RefreshDatabase();

			DialogResult = DialogResult.OK;
		}

		void ComputeCaption() {
			int rowCount;
			using (var transaction = target.Owner.Connection.BeginTransaction()) {
				rowCount = PerformMerge(transaction);
				transaction.Rollback();
			}
			var text = $"Are you sure you want to merge {gridSource.Sources.Count} people?  "
					 + $"This will affect {rowCount} rows.  Update the merged person at the bottom of this grid.";
			if (IsHandleCreated)
				BeginInvoke(new Action(() => label.Text = text));
			else
				Text = text;
		}

		int PerformMerge(DbTransaction transaction) {
			return gridSource.Sources.Where(s => s != target).Sum(s => s.Owner.MergePerson(transaction, s, target.Person));
		}

		private void gridView_RowStyle(object sender, RowStyleEventArgs e) {
			if (gridView.GetRow(e.RowHandle) == gridSource.TargetEditor)
				e.Appearance.FontStyleDelta = FontStyle.Bold;
			else
				e.Appearance.BackColor = SystemColors.Control;
		}

		private void gridView_ShowingEditor(object sender, CancelEventArgs e) {
			e.Cancel = gridView.GetFocusedRow() != gridSource.TargetEditor;
		}


		class GridList : Collection<Person>, IRelationListEx {
			public IReadOnlyList<PersonRowData> Sources { get; }
			public Person TargetEditor { get; }
			///<summary>Columns with conflicting source data that the user must manually resolve.</summary>
			public List<Column> RequiredColumns { get; } = new List<Column>();

			public GridList(IEnumerable<PersonRowData> sources) {
				Sources = sources.ToList();
				TargetEditor = InitializeTargetEditor();
				this.AddRange(Sources.Select(s => s.Person));
				this.Add(TargetEditor);
			}
			Person InitializeTargetEditor() {
				var retVal = new Person();

				foreach (var column in Person.Schema.Columns.Where(c => !c.ReadOnly && c.Name != nameof(Extensions.UIId))) {
					var values = Sources
						.Select(r => r.Person[column])
						.Where(v => !Equals(v, column.DefaultValue) && v != null && !v.Equals(""))
						.Distinct()
						.ToList();
					switch (values.Count) {
						case 0: break;  // If none of the source rows have data, we don't are about this column.
						case 1:         // If all of the source rows agree, use their value as-is.
							retVal[column] = values[0];
							break;
						default:        // If the source rows have conflicting values, force the user to choose.
							RequiredColumns.Add(column);
							break;
					}
				}
				retVal.Id = Sources.Last().Person.Id;
				retVal[nameof(Extensions.UIId)] = Sources.Last().Person.UIId();
				return retVal;
			}

			public int RelationCount => Sources.Max(prd => prd.DataSet.Tables.Count);

			public IList GetDetailList(int index, int relationIndex) {
				if (index < 0 || index == Count - 1)
					return null;
				return ((IListSource)Sources[index].DataSet.Tables[relationIndex]).GetList();
			}

			public int GetRelationCount(int index) {
				if (index < 0)
					return RelationCount;
				if (index == Count - 1)
					return 0;
				return Sources[index].DataSet.Tables.Count;
			}

			public string GetRelationDisplayName(int index, int relationIndex) {
				if (index < 0 || index == Count - 1)
					return null;
				return Sources[index].DataSet.Tables[relationIndex].TableName;
			}

			public string GetRelationName(int index, int relationIndex) {
				if (index < 0 || index == Count - 1)
					return null;
				return Sources[index].DataSet.Tables[relationIndex].TableName;
			}

			public bool IsMasterRowEmpty(int index, int relationIndex) {
				return index == Count - 1;
			}
		}

		private void gridView_CellMerge(object sender, CellMergeEventArgs e) {
			if (gridView.GetRow(e.RowHandle1) == gridSource.TargetEditor
			 || gridView.GetRow(e.RowHandle2) == gridSource.TargetEditor) {
				e.Handled = true;
				e.Merge = false;
			}
		}

		private void gridView_DoubleClick(object sender, EventArgs e) {
			var info = gridView.CalcHitInfo(gridView.GridControl.PointToClient(MousePosition));

			if (!info.InRowCell || gridView.GetRow(info.RowHandle) == gridSource.TargetEditor)
				return;
			if (e is DXMouseEventArgs dx) dx.Handled = true;

			gridView.SetRowCellValue(
				gridView.GetRowHandle(gridSource.Count - 1),
				info.Column,
				gridView.GetRowCellValue(info.RowHandle, info.Column)
			);
		}

		private void gridView_MasterRowGetLevelDefaultView(object sender, MasterRowGetLevelDefaultViewEventArgs e) {
			var rowData = gridSource.Sources[gridView.GetDataSourceRowIndex(e.RowHandle)];
			e.DefaultView = new GridView(gridControl1);
			e.DefaultView.DataSourceChanged += (senderClone, _) => {
				// senderClone is the clone for this expansion; e.DefaultView is the pattern view.
				PersonForm.CustomizeDetailView(rowData.DataSet.Tables[e.RelationIndex], (GridView)senderClone);
			};
		}
	}
}
