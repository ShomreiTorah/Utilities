using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ShomreiTorah.Singularity.Designer.Model {
	public class DataContextModel : INotifyPropertyChanged {
		public DataContextModel() {
			Schemas = new BindingList<SchemaModel>();
			Schemas.ListChanged += delegate { OnTreeChanged(); };
		}

		string name;
		///<summary>Gets or sets the name of the DataContext.</summary>
		[Description("Gets or sets the name of the DataContext.")]
		[Category("General")]
		public string Name {
			get { return name; }
			set { name = value; OnPropertyChanged("Name"); }
		}
		public BindingList<SchemaModel> Schemas { get; private set; }

		string namespaceName="ShomreiTorah";
		///<summary>Gets or sets the namespace for the generated code.</summary>
		[Description("Gets or sets the namespace for the generated code.")]
		[Category("Code Generation")]
		public string Namespace {
			get { return namespaceName; }
			set { namespaceName = value; OnPropertyChanged("Namespace"); }
		}

		///<summary>Occurs when a property value is changed.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		///<summary>Raises the PropertyChanged event.</summary>
		///<param name="name">The name of the property that changed.</param>
		protected virtual void OnPropertyChanged(string propertyName) { OnPropertyChanged(new PropertyChangedEventArgs(propertyName)); }
		///<summary>Raises the PropertyChanged event.</summary>
		///<param name="e">An EventArgs object that provides the event data.</param>
		protected virtual void OnPropertyChanged(PropertyChangedEventArgs e) {
			if (PropertyChanged != null)
				PropertyChanged(this, e);
		}
		///<summary>Occurs when the schema tree is changed.</summary>
		public event EventHandler TreeChanged;
		///<summary>Raises the TreeChanged event.</summary>
		internal protected virtual void OnTreeChanged() { OnTreeChanged(EventArgs.Empty); }
		///<summary>Raises the TreeChanged event.</summary>
		///<param name="e">An EventArgs object that provides the event data.</param>
		internal protected virtual void OnTreeChanged(EventArgs e) {
			if (TreeChanged != null)
				TreeChanged(this, e);
		}
	}
}
