using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;

namespace ShomreiTorah.Singularity.Designer.Model {
	public class ColumnModel : INotifyPropertyChanged {
		public ColumnModel(SchemaModel owner) {
			if (owner == null) throw new ArgumentNullException("owner");

			Owner = owner;
		}

		[Browsable(false)]
		public SchemaModel Owner { get; private set; }

		string name;
		///<summary>Gets or sets name of the column.</summary>
		[Description("Gets or sets name of the column.")]
		[Category("General")]
		public string Name {
			get { return name; }
			set {
				if (Name == value) return;
				if (Owner.Columns.Any(c => c.Name == value))
					throw new ArgumentException("A column named " + value + " already exists.");
				if (GenerateSqlMapping && SqlName == Name)
					SqlName = value;
				name = value;
				OnPropertyChanged("Name");
			}
		}
		Type dataType = typeof(string);
		///<summary>Gets or sets the column's datatype.</summary>
		[Description("Gets or sets the column's datatype.")]
		[Category("Data")]
		public Type DataType {
			get { return dataType; }
			set { dataType = value; OnPropertyChanged("DataType"); }
		}
		object defaultValue;
		///<summary>Gets or sets the column's default value.</summary>
		[Description("Gets or sets the column's default value.")]
		[Category("Data")]
		public object DefaultValue {
			get { return defaultValue; }
			set {
				defaultValue = DataType == null ? value : Convert.ChangeType(value, DataType, CultureInfo.CurrentCulture);
				OnPropertyChanged("DefaultValue");
			}
		}

		bool allowNulls;
		///<summary>Gets or sets whether the column will accept null values.</summary>
		[Description("Gets or sets whether the column will accept null values.")]
		[Category("Data")]
		public bool AllowNulls {
			get { return allowNulls; }
			set { allowNulls = value; OnPropertyChanged("AllowNulls"); }
		}
		bool isUnique;
		///<summary>Gets or sets whether the column's values must be unique.</summary>
		[Description("Gets or sets whether the column's values must be unique.")]
		[Category("Data")]
		public bool IsUnique {
			get { return isUnique; }
			set { isUnique = Owner.PrimaryKey == this || value; OnPropertyChanged("IsUnique"); }
		}

		bool generateSqlMapping = true;
		///<summary>Gets or sets whether a ColumnMapping object will be created for this column.</summary>
		[Description("Gets or sets whether a ColumnMapping object will be created for this column.")]
		[Category("SQL")]
		public bool GenerateSqlMapping {
			get { return generateSqlMapping; }
			set {
				if (GenerateSqlMapping == value) return;

				generateSqlMapping = value;
				OnPropertyChanged("GenerateSqlMapping");
				SqlName = GenerateSqlMapping ? Name : null;
			}
		}
		string sqlName;
		///<summary>Gets or sets the name of the corresponding SQL column.</summary>
		[Description("Gets or sets the name of the corresponding SQL column.")]
		[Category("SQL")]
		public string SqlName {
			get { return sqlName; }
			set { sqlName = value; OnPropertyChanged("SqlName"); }
		}

		SchemaModel foreignSchema;
		///<summary>Gets or sets the schema that this column serves as a primary key for.</summary>
		[Description("Gets or sets the schema that this column serves as a primary key for.")]
		[Category("Data")]
		public SchemaModel ForeignSchema {
			get { return foreignSchema; }
			set {
				if (ForeignSchema == value) return;

				if (ForeignSchema != null)
					ForeignSchema.RemoveChild(Owner);

				foreignSchema = value;

				if (ForeignSchema != null)
					ForeignSchema.AddChild(Owner);

				if (ForeignSchema == null)
					DataType = typeof(string);
				else
					DataType = typeof(Row);

				Owner.Owner.OnTreeChanged();
			}
		}

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
}
