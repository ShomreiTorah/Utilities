using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;

namespace ShomreiTorah.DirectoryManager {
	public partial class PersonForm : XtraForm {
		public PersonForm(PersonRowData person) {
			InitializeComponent();

			Text = person.Person.FullName + " - " + person.Person.Id;
			personInfo.Caption = person.Person.ToFullString();

			foreach (DataTable table in person.DataSet.Tables) {
				tabs.TabPages.Add(new XtraTabPage {

					Text = table.TableName,
					Controls =
					{
						new GridControl() {
							Dock = DockStyle.Fill,
							DataSource = table,
						}
					}
				});
			}
		}
	}
}
