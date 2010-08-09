using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace ShomreiTorah.Singularity.Designer.Model {
	public partial class ColumnModel : INotifyPropertyChanged {
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
				if (PropertyName == Name)
					PropertyName = value;
				if (String.IsNullOrEmpty(Description) || Description == String.Format(CultureInfo.InvariantCulture, DefaultDescriptionFormat, Name.SplitWords(), Owner.RowClassName.SplitWords()))
					Description = String.Format(CultureInfo.InvariantCulture, DefaultDescriptionFormat, value.SplitWords(), Owner.RowClassName.SplitWords());

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
				if ("".Equals(value) && DataType != typeof(string))	//Fix for editor UI
					value = null;
				if (value != null)
					Expression = null;
				defaultValue = DataType == null || value == null ? value : Convert.ChangeType(value, DataType, CultureInfo.CurrentCulture);
				OnPropertyChanged("DefaultValue");
			}
		}
		string expression;
		///<summary>Gets or sets the expression for a calculated column.</summary>
		[SuppressMessage("Microsoft.Performance", "CA1820:TestForEmptyStringsUsingStringLength"), Description("Gets or sets the expression for a calculated column.")]
		[Category("Data")]
		public string Expression {
			get { return expression; }
			set {
				if (expression == value) return;
				if (value == "") value = null;
				if (!String.IsNullOrEmpty(value)) {
					DefaultValue = null;
					GenerateSqlMapping = false;
				}
				expression = value;
				OnPropertyChanged("Expression");
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
				value = value && String.IsNullOrEmpty(Expression);
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
		[Category("Relations")]
		public SchemaModel ForeignSchema {
			get { return foreignSchema; }
			set {
				if (ForeignSchema == value) return;

				if (ForeignSchema != null)
					ForeignSchema.RemoveChild(Owner);

				foreignSchema = value;

				if (ForeignSchema != null)
					ForeignSchema.AddChild(Owner);

				if (ForeignSchema == null) {
					DataType = typeof(string);
					ForeignRelationName = ForeignRelationPropertyName = null;
				} else {
					DataType = typeof(Row);
					ForeignRelationName = Owner.RowClassName + "s";
				}

				Owner.Owner.OnTreeChanged();
			}
		}
		string foreignRelationName;
		///<summary>Gets or sets the name of the ChildRelation in the column's foreign schema.</summary>
		[Description("Gets or sets the name of the ChildRelation in the column's foreign schema.")]
		[Category("Relations")]
		public string ForeignRelationName {
			get { return foreignRelationName; }
			set {
				if (ForeignRelationPropertyName == ForeignRelationName)
					ForeignRelationPropertyName = value;

				if (String.IsNullOrEmpty(ForeignRelationPropertyDescription)
				 || ForeignRelationPropertyDescription == String.Format(CultureInfo.InvariantCulture, DefaultFrpDescriptionFormat, ForeignRelationName.SplitWords(), Owner.RowClassName.SplitWords()))
					ForeignRelationPropertyDescription = String.Format(CultureInfo.InvariantCulture, DefaultFrpDescriptionFormat, value.SplitWords(), ForeignSchema.RowClassName.SplitWords());

				foreignRelationName = value;
				OnPropertyChanged("ForeignRelationName");
			}
		}
		string foreignRelationPropertyName;
		///<summary>Gets or sets the name of the property in the foreign schema that returns the child rows.</summary>
		[Description("Gets or sets the name of the property in the foreign schema that returns the child rows.")]
		[Category("Code Generation")]
		public string ForeignRelationPropertyName {
			get { return foreignRelationPropertyName; }
			set { foreignRelationPropertyName = value; OnPropertyChanged("ForeignRelationPropertyName"); }
		}
		string foreignRelationPropertyDescription;
		///<summary>Gets or sets the XML comment for the property in the foreign schema that returns the child rows.</summary>
		[Description("Gets or sets the XML comment for the property in the foreign schema that returns the child rows.")]
		[Category("Code Generation")]
		public string ForeignRelationPropertyDescription {
			get { return foreignRelationPropertyDescription; }
			set { foreignRelationPropertyDescription = value; OnPropertyChanged("ForeignRelationPropertyDescription"); }
		}
		const string DefaultFrpDescriptionFormat = "Gets the {0} of the {1}.";

		MemberVisibility propertyVisibility = MemberVisibility.Public;
		///<summary>Gets or sets the access modifier for the column's property in the strongly-typed Row class.</summary>
		[Description("Gets or sets the access modifier for the column's property in the strongly-typed Row class.")]
		[Category("Code Generation")]
		public MemberVisibility PropertyVisibility {
			get { return propertyVisibility; }
			set { propertyVisibility = value; OnPropertyChanged("PropertyVisibility"); }
		}
		string propertyName;
		///<summary>Gets or sets the name of the column's property in the strongly-typed Row class.</summary>
		[Description("Gets or sets the name of the column's property in the strongly-typed Row class.")]
		[Category("Code Generation")]
		public string PropertyName {
			get { return propertyName; }
			set { propertyName = value; OnPropertyChanged("PropertyName"); }
		}
		string description;
		///<summary>Gets or sets the description of the column.  This will be used as the XML comment for the column's accessor instance property.</summary>
		[Description("Gets or sets the description of the column.  This will be used as the XML comment for the column's accessor instance property.")]
		[Category("Code Generation")]
		public string Description {
			get { return description; }
			set { description = value; OnPropertyChanged("Description"); }
		}
		const string DefaultDescriptionFormat = "Gets or sets the {0} of the {1}.";

		public override string ToString() {
			return Name;
		}
		///<summary>Occurs when a property value is changed.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		///<summary>Raises the PropertyChanged event.</summary>
		///<param name="name">The name of the property that changed.</param>
		void OnPropertyChanged(string propName) { OnPropertyChanged(new PropertyChangedEventArgs(propName)); }
		///<summary>Raises the PropertyChanged event.</summary>
		///<param name="e">An EventArgs object that provides the event data.</param>
		void OnPropertyChanged(PropertyChangedEventArgs e) {
			if (PropertyChanged != null)
				PropertyChanged(this, e);
		}
	}
}
