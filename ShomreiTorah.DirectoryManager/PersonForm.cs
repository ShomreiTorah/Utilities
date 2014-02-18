using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
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
	}
}
