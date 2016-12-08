using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using ShomreiTorah.Common;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class Utils {
		public static MemberVisibility ParseVisibility(string value) {
			return (MemberVisibility)Enum.Parse(typeof(MemberVisibility), value);
		}
		public static string NonEmpty(this string value) { return String.IsNullOrWhiteSpace(value) ? null : value; }
	}

	sealed partial class DataContextModel {
		///<summary>Loads a <see cref="DataContextModel"/> from an XML file, resolving relative paths to external schemas.</summary>
		public DataContextModel(string path)
			: this() {
			FilePath = path;
			var element = XElement.Load(path);
			Name = element.Attribute("Name").Value;
			Namespace = element.Attribute("Namespace").Value;

			if (element.Attribute("CodePath") != null)  //This property was introduced later; I must accept older files
				CodePath = element.Attribute("CodePath").Value;

			foreach (var import in element.Elements("Import"))
				ImportContext(import.Attribute("Path").Value);

			Schemas.AddRange(element.Elements("Schema").Select(e => new SchemaModel(this, e)));
		}

		public string FilePath { get; set; }

		readonly List<ImportedContext> imports = new List<ImportedContext>();
		public ReadOnlyCollection<ImportedContext> Imports { get; }

		public void ImportContext(string relativePath) {
			XElement element = XElement.Load(Path.Combine(Path.GetDirectoryName(FilePath), relativePath));

			// The SchemaModel deserializer relies on parent schemas existing in the context.
			// Therefore, I must immediately add them to this.Schemas as I create them.
			var schemas = new List<SchemaModel>();
			foreach (var schema in element.Elements("Schema")
					   .Select(e => new SchemaModel(this, e, isExternal: true))) {
				schemas.Add(schema);
				Schemas.AddRange(schema);
			}
			imports.Add(new ImportedContext(relativePath, element.Attribute("Name").Value, schemas));
			OnTreeChanged();
		}

		public void RemoveImport(ImportedContext import) {
			imports.Remove(import);
			foreach (var schema in import.Schemas)
				Schemas.Remove(schema);
		}

		public XDocument ToXml() {
			return new XDocument(
				new XElement("DataContext",
					new XAttribute("Name", this.Name ?? ""),
					new XAttribute("Namespace", this.Namespace),
					new XAttribute("CodePath", this.CodePath ?? ""),

					Imports.Select(ic => new XElement("Import", new XAttribute("Path", ic.RelativePath))),

					Schemas.SortDependencies().Where(s => !s.IsExternal).Select(s => s.ToXml())
				)
			);
		}
	}

	///<summary>A group of schemas that has been imported from another file.  These should not be modified.</summary>
	public class ImportedContext {
		public ImportedContext(string relativePath, string name, IEnumerable<SchemaModel> schemas) {
			RelativePath = relativePath;
			Schemas = schemas.ReadOnlyCopy();
			Name = name;
		}

		public string Name { get; }
		public string RelativePath { get; }
		public ReadOnlyCollection<SchemaModel> Schemas { get; }
	}

	sealed partial class SchemaModel {
		public SchemaModel(DataContextModel owner, XElement element)
			: this(owner) {
			Name = element.Attribute("Name").Value;

			RowClassVisibility = Utils.ParseVisibility(element.Attribute("RowClassVisibility").Value);
			RowClassName = element.Attribute("RowClassName").Value;
			RowClassDescription = element.Attribute("RowClassDescription").Value;
			SqlName = element.Attribute("SqlName").Value;
			SqlSchemaName = element.Attribute("SqlSchemaName").Value;

			Columns.AddRange(element.Elements("Column").Select(e => new ColumnModel(this, e)));

			var pKey = element.Attribute("PrimaryKeyName");
			if (pKey != null)
				PrimaryKey = Columns.Single(c => c.Name == pKey.Value);
		}

		public SchemaModel(DataContextModel owner, XElement element, bool isExternal) : this(owner, element) {
			IsExternal = isExternal;
		}

		///<summary>Indicates whether this schema was imported from a different XML file.  If so, it should not be modified.</summary>
		public bool IsExternal { get; }

		public XElement ToXml() {
			var retVal = new XElement("Schema",
				new XAttribute("Name", this.Name),

				new XAttribute("RowClassDescription", this.RowClassDescription),
				new XAttribute("RowClassName", this.RowClassName),
				new XAttribute("RowClassVisibility", this.RowClassVisibility),
				new XAttribute("SqlName", this.SqlName),
				new XAttribute("SqlSchemaName", this.SqlSchemaName),

				Columns.Select(s => s.ToXml())
			);
			if (PrimaryKey != null)
				retVal.Add(new XAttribute("PrimaryKeyName", PrimaryKey.Name));
			return retVal;
		}

	}
	sealed partial class ColumnModel {
		public ColumnModel(SchemaModel owner, XElement element)
			: this(owner) {
			name = element.Attribute("Name").Value;

			dataType = Type.GetType(element.Attribute("DataType").Value);

			var def = element.Element("DefaultValue");
			if (def.Element("Null") == null)    //If it's not <Null />
				DefaultValue = def.Value;

			allowNulls = (bool)element.Attribute("AllowNulls");
			description = element.Attribute("Description").Value;
			expression = element.Attribute("Expression").Value.NonEmpty();
			generateSqlMapping = (bool)element.Attribute("GenerateSqlMapping");
			isUnique = (bool)element.Attribute("IsUnique");
			propertyName = element.Attribute("PropertyName").Value;
			propertyVisibility = Utils.ParseVisibility(element.Attribute("PropertyVisibility").Value);
			sqlName = element.Attribute("SqlName").Value.NonEmpty();

			var pSchema = element.Attribute("ForeignSchemaName");
			if (pSchema != null)
				ForeignSchema = Owner.Owner.Schemas.Single(c => c.Name == pSchema.Value);
			//The ForeignSchema resets these properties
			foreignRelationName = element.Attribute("ForeignRelationName").Value.NonEmpty();
			foreignRelationPropertyDescription = element.Attribute("ForeignRelationPropertyDescription").Value.NonEmpty();
			foreignRelationPropertyName = element.Attribute("ForeignRelationPropertyName").Value.NonEmpty();
		}

		public XElement ToXml() {
			var retVal = new XElement("Column",
				new XAttribute("Name", this.Name),

				new XAttribute("AllowNulls", this.AllowNulls),
				new XAttribute("DataType", this.DataType.AssemblyQualifiedName),
				new XElement("DefaultValue", DefaultValue ?? new XElement("Null")),
				new XAttribute("Description", this.Description),
				new XAttribute("Expression", this.Expression ?? ""),
				new XAttribute("ForeignRelationName", this.ForeignRelationName ?? ""),
				new XAttribute("ForeignRelationPropertyDescription", this.ForeignRelationPropertyDescription ?? ""),
				new XAttribute("ForeignRelationPropertyName", this.ForeignRelationPropertyName ?? ""),
				new XAttribute("GenerateSqlMapping", this.GenerateSqlMapping),
				new XAttribute("IsUnique", this.IsUnique),
				new XAttribute("PropertyName", this.PropertyName),
				new XAttribute("PropertyVisibility", this.PropertyVisibility),
				new XAttribute("SqlName", this.SqlName ?? "")
			);

			if (ForeignSchema != null)
				retVal.Add(new XAttribute("ForeignSchemaName", ForeignSchema.Name));

			return retVal;
		}
	}
}
