using DevExpress.XtraBars.Ribbon;

namespace ShomreiTorah.DirectoryManager {
	public partial class MainForm : RibbonForm {

		readonly ExternalDataManager data;
		public MainForm(ExternalDataManager data) {
			InitializeComponent();
			this.data = data;
			personSelector.Properties.Buttons.RemoveAt(1);
		}

		///<summary>Releases the unmanaged resources used by the MainForm and optionally releases the managed resources.</summary>
		///<param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				data.Dispose();
				if (components != null) components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void personSelector_EditValueChanged(object sender, System.EventArgs e) {
			if (personSelector.SelectedPerson == null) return;    //eg, DBNull
			new PersonForm(data.GetPerson(personSelector.SelectedPerson)) { MdiParent = this }.Show();
			personSelector.SelectedPerson = null;
		}
	}
}
