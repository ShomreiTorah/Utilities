using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using ShomreiTorah.WinForms;

namespace ShomreiTorah.DirectoryManager {
	public partial class PersonForm : XtraForm {
		static readonly ISet<string> hiddenFields = new HashSet<string> { "RowVersion", "RowId", "PersonId" };
		static PluralizationService pluralizer = PluralizationService.CreateService(CultureInfo.CurrentCulture);

		readonly PersonRowData person;

		public PersonForm(PersonRowData person) {
			InitializeComponent();

			this.person = person;

			Text = person.Person.FullName + " - " + person.Person.Id;
			personInfo.EditValue = person.Person.ToFullString();
			personInfo.SuperTip = Utilities.CreateSuperTip(body: person.Person.ToFullString());

			infoSource.Caption += person.Person.Source;
			infoStripeId.Caption += person.StripeId;
			infoYKID.Caption += person.Person.YKID;

			foreach (DataTable table in person.DataSet.Tables) {
				var grid = new GridControl() {
					Dock = DockStyle.Fill,
					DataSource = table,
				};

				tabs.TabPages.Add(new XtraTabPage {
					Text = table.TableName,
					Controls = { grid }
				});

				var view = new GridView();
				grid.MainView = view;
				view.PopulateColumns();

				view.OptionsBehavior.Editable = false;

				foreach (GridColumn column in view.Columns) {
					if (hiddenFields.Contains(column.FieldName)
					 || column.FieldName == pluralizer.Singularize(Path.GetExtension(table.TableName).TrimStart('.')) + "Id")
						column.Visible = false;
				}

				view.BestFitColumns();
			}
		}

		PersonForm[] otherForms;
		private void mergePerson_GetItemData(object sender, EventArgs e) {
			otherForms = MdiParent.MdiChildren
							 .OfType<PersonForm>()
							 .Where(f => f.person.Person.Id != this.person.Person.Id)
							 .ToArray();

			mergePerson.Strings.Clear();
			mergePerson.Strings.AddRange(Array.ConvertAll(otherForms, f => f.Text));
		}

		private void deletePerson_ItemClick(object sender, ItemClickEventArgs e) {
			using (var transaction = person.Owner.Connection.BeginTransaction()) {
				int rowCount = person.Owner.DeletePerson(transaction, person.Person);
				ConfirmOperation(
					transaction,
					"Are you sure you want to delete " + Text + "?\n"
				  + "This will obliterate " + rowCount + " rows"
				);
			}
		}

		private void mergePerson_ListItemClick(object sender, ListItemClickEventArgs e) {
			var target = otherForms[e.Index];

			using (var transaction = person.Owner.Connection.BeginTransaction()) {
				int rowCount = person.Owner.MergePerson(transaction, person, target.person.Person);
				ConfirmOperation(
					transaction,
					"Are you sure you want to commit merging " + Text + " into " + target.Text + "?\n"
				  + "This will affect " + rowCount + " rows, and will delete the row for " + Text
				);
			}
		}

		static void ConfirmOperation(DbTransaction transaction, string message) {
			if (Dialog.Warn(message)) {
				transaction.Commit();
				Program.Current.RefreshDatabase();
			} else
				transaction.Rollback();
		}
	}
}
