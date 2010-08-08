using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Globalization;

namespace ShomreiTorah.Singularity.Designer.Model {
	public class SchemaModel : INotifyPropertyChanged {
		public SchemaModel(DataContextModel owner) {
			Owner = owner;

			Columns = new ColumnList(this);

			ChildSchemas = new ReadOnlyObservableCollection<SchemaModel>(childSchemas);
		}
		[Browsable(false)]
		public DataContextModel Owner { get; private set; }

		class ColumnList : BindingList<ColumnModel> {
			readonly SchemaModel schema;
			public ColumnList(SchemaModel schema) { this.schema = schema; AllowNew = true; }

			protected override object AddNewCore() {
				int nameIndex = Count;
				string name;
				do {
					nameIndex++;
					name = "Column" + nameIndex;
				} while (this.Any(c => c.Name == name));

				var retVal = new ColumnModel(schema) { Name = name };
				Add(retVal);
				return retVal;
			}
			protected override void RemoveItem(int index) {
				if (schema.PrimaryKey == this[index])
					schema.PrimaryKey = null;
				this[index].ForeignSchema = null;
				base.RemoveItem(index);
			}
		}

		string name;
		///<summary>Gets or sets name of the schema.</summary>
		[Description("Gets or sets name of the schema.")]
		[Category("General")]
		public string Name {
			get { return name; }
			set {
				if (SqlName == Name)
					SqlName = value;
				if (RowClassName == Name.Depluralize())
					RowClassName = value.Depluralize();
				name = value;
				OnPropertyChanged("Name");
			}
		}
		string sqlName;
		///<summary>Gets or sets the name of the corresponding SQL table.</summary>
		[Description("Gets or sets the name of the corresponding SQL table.")]
		[Category("SQL")]
		public string SqlName {
			get { return sqlName; }
			set { sqlName = value; OnPropertyChanged("SqlName"); }
		}
		string sqlSchemaName;
		///<summary>Gets or sets the name of the corresponding SQL table's schema.</summary>
		[Description("Gets or sets the name of the corresponding SQL table's schema.")]
		[Category("SQL")]
		public string SqlSchemaName {
			get { return sqlSchemaName; }
			set { sqlSchemaName = value; OnPropertyChanged("SqlSchemaName"); }
		}
		ColumnModel primaryKey;
		///<summary>Gets or sets the schema's primary key.</summary>
		[Description("Gets or sets the schema's primary key.")]
		[Category("Data")]
		public ColumnModel PrimaryKey {
			get { return primaryKey; }
			set {
				if (value != null && value.Owner != this) throw new ArgumentException("The primary key must belong to its schema");
				if (value != null)
					value.IsUnique = true;
				primaryKey = value;
				OnPropertyChanged("PrimaryKey");
			}
		}

		string rowClassName;
		///<summary>Gets or sets the name of the strongly-typed Row class.</summary>
		[Description("Gets or sets the name of the strongly-typed Row class.")]
		[Category("Code Generation")]
		public string RowClassName {
			get { return rowClassName; }
			set {
				if (String.IsNullOrEmpty(RowClassDescription) || RowClassDescription == String.Format(CultureInfo.InvariantCulture, DefaultDescriptionFormat, RowClassName.SplitWords()))
					RowClassDescription = String.Format(CultureInfo.InvariantCulture, DefaultDescriptionFormat, value.SplitWords());
				rowClassName = value.Replace(' ', '_');
				OnPropertyChanged("RowClassName");
			}
		}
		MemberVisibility rowClassVisibility = MemberVisibility.Public;
		///<summary>Gets or sets the access modifiers of the strongly-typed Row class.</summary>
		[Description("Gets or sets the access modifiers of the strongly-typed Row class.")]
		[Category("Code Generation")]
		public MemberVisibility RowClassVisibility {
			get { return rowClassVisibility; }
			set { rowClassVisibility = value; OnPropertyChanged("RowClassVisibility"); }
		}

		string rowClassDescription;
		///<summary>Gets or sets the XML comment for the strongly-typed Row class.</summary>
		[Description("Gets or sets the XML comment for the strongly-typed Row class.")]
		[Category("Code Generation")]
		public string RowClassDescription {
			get { return rowClassDescription; }
			set { rowClassDescription = value; OnPropertyChanged("RowClassDescription"); }
		}
		const string DefaultDescriptionFormat = "Describes a {0}.";

		public BindingList<ColumnModel> Columns { get; private set; }
		public ReadOnlyObservableCollection<SchemaModel> ChildSchemas { get; private set; }

		ObservableCollection<SchemaModel> childSchemas = new ObservableCollection<SchemaModel>();
		internal void AddChild(SchemaModel schema) { childSchemas.Add(schema); }
		internal void RemoveChild(SchemaModel schema) { childSchemas.Remove(schema); }

		public override string ToString() {
			return Name;
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

	}
	public enum MemberVisibility {
		Private,
		Internal,
		Public
	}
}
