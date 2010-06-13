using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace ShomreiTorah.Singularity.Designer {
	class ModelBindingSource : BindingSource {
		public ModelBindingSource() : base(new BindingList<SchemaModel>(), null) { }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new object DataSource {
			get { return base.DataSource; }
			set { base.DataSource = value; }
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new string DataMember {
			get { return base.DataMember; }
			set { base.DataMember = value; }
		}
	}
	public class DataContextModel {
		public DataContextModel() { Schemas = new BindingList<SchemaModel>(); }

		public string Name { get; set; }
		public BindingList<SchemaModel> Schemas { get; private set; }
	}
	public class SchemaModel {
		public SchemaModel() {
			Columns = new BindingList<ColumnModel>();
			Columns.AddingNew += (s, e) => e.NewObject = new ColumnModel(this);
			ChildSchemas = new ReadOnlyObservableCollection<SchemaModel>(childSchemas);
		}

		public string Name { get; set; }
		public string SqlName { get; set; }
		public string SqlSchemaName { get; set; }

		public ColumnModel PrimaryKey { get; set; }

		public BindingList<ColumnModel> Columns { get; private set; }
		public ReadOnlyObservableCollection<SchemaModel> ChildSchemas { get; private set; }

		ObservableCollection<SchemaModel> childSchemas = new ObservableCollection<SchemaModel>();
		internal void AddChild(SchemaModel schema) { childSchemas.Add(schema); }
		internal void RemoveChild(SchemaModel schema) { childSchemas.Remove(schema); }

		public override string ToString() {
			return SqlName;
		}
	}
	public class ColumnModel {
		public ColumnModel(SchemaModel owner) {
			if (owner == null) throw new ArgumentNullException("owner");

			Owner = owner;
		}

		[Browsable(false)]
		public SchemaModel Owner { get; private set; }

		public string Name { get; set; }
		public Type DataType { get; set; }
		public object DefaultValue { get; set; }

		public bool AllowNulls { get; set; }
		public bool IsUnique { get; set; }

		public bool GenerateSqlMapping { get; set; }
		public string SqlName { get; set; }

		SchemaModel foreignSchema;
		public SchemaModel ForeignSchema {
			get { return foreignSchema; }
			set {
				if (ForeignSchema != null)
					ForeignSchema.RemoveChild(Owner);

				foreignSchema = value;

				if (ForeignSchema != null)
					ForeignSchema.AddChild(Owner);
			}
		}

		public override string ToString() {
			return Name;
		}
	}
}
