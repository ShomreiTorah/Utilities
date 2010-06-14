using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class CodeGenerator {
		public static string Quote(this string str) { return "\"" + str.Replace(@"\", @"\\") + "\""; }	//TODO: Improve

		public static void WriteClasses(this DataContextModel model, TextWriter writer) {
			if (model == null) throw new ArgumentNullException("model");
			if (writer == null) throw new ArgumentNullException("writer");

			var indentedWriter = new IndentedTextWriter(writer);
			indentedWriter.WriteLine("using System;");
			indentedWriter.WriteLine("using ShomreiTorah.Singularity;");
			indentedWriter.WriteLine("using ShomreiTorah.Singularity.Sql;");

			indentedWriter.WriteLine("namespace " + model.Namespace + " {");
			indentedWriter.Indent++;

			foreach (var schema in model.Schemas)
				WriteSchema(schema, indentedWriter);

			indentedWriter.Indent--;
			indentedWriter.WriteLine("}");
		}

		static void WriteSchema(SchemaModel schema, IndentedTextWriter writer) {
			writer.WriteLine(schema.RowClassVisibility.ToString().ToLowerInvariant() + " partial class " + schema.RowClassName + " : Row {");
			writer.Indent++;
			writer.WriteLine("public static TypedTable<" + schema.RowClassName + "> CreateTable() "
								+ "{ return new TypedTable<" + schema.RowClassName + ">(Schema, () => new " + schema.RowClassName + "()); }");
			writer.WriteLine("public " + schema.RowClassName + " () : base(Schema) { }");

			writer.WriteLine();
			foreach (var column in schema.Columns) {
				writer.WriteLine("public static " + column.ColumnType.Name + " " + column.ColumnPropertyName + " { get; private set; }");
			}
			writer.WriteLine();


			writer.Write("public static new readonly TypedSchema<" + schema.RowClassName + "> Schema "
								+ "= TypedSchema<" + schema.RowClassName + ">.Create(" + schema.Name.Quote() + ", schema => {");
			writer.Indent++;
			foreach (var column in schema.Columns) {
				writer.WriteLine();
				WriteColumnCreation(column, writer);
			}
			writer.Indent--;
			writer.WriteLine("});");

			writer.WriteLine();

			writer.WriteLine("#region Value Properties");

			foreach (var column in schema.Columns)
				WriteValueProperty(column, writer);

			writer.WriteLine("#endregion");

			writer.WriteLine();

			writer.Indent--;
			writer.WriteLine("}");
		}

		static void WriteColumnCreation(ColumnModel column, IndentedTextWriter writer) {
			//TODO: Calculated Columns

			if (column == column.Owner.PrimaryKey)
				writer.Write("schema.PrimaryKey = ");
			if (column.ForeignSchema != null) {
				writer.WriteLine(column.ColumnPropertyName
					+ " = schema.Columns.AddForeignKey(" + column.Name.Quote() + ", " + column.ForeignSchema.RowClassName + ".Schema, " + column.ForeignRelationName.Quote() + ");");
			} else {
				writer.WriteLine(column.ColumnPropertyName
					+ " = schema.Columns.AddValueColumn(" + column.Name.Quote() + ", typeof(" + column.DataType.Name + "), " + column.DefaultValueCode + ");");
			}
			if (column.IsUnique)
				writer.WriteLine(column.ColumnPropertyName + ".Unique = true;");
			writer.WriteLine(column.ColumnPropertyName + ".AllowNulls = " + column.AllowNulls.ToString().ToLowerInvariant() + ";");
		}

		static void WriteValueProperty(ColumnModel column, IndentedTextWriter writer) {
			writer.WriteLine(column.PropertyVisibility.ToString().ToLowerInvariant() + " " + column.ActualType + " " + column.PropertyName + " {");
			writer.Indent++;
			writer.WriteLine("get { return base.Field<" + column.ActualType + ">(" + column.ColumnPropertyName + "); }");
			writer.WriteLine("set { base[" + column.ColumnPropertyName + "] = value; }");
			writer.Indent--;
			writer.WriteLine("}");
		}
	}
	partial class ColumnModel {
		internal string ColumnPropertyName { get { return PropertyName + "Column"; } }
		internal Type ColumnType {
			get {
				if (ForeignSchema != null)
					return typeof(ForeignKeyColumn);
				//TODO: Calculated Columns
				return typeof(ValueColumn);
			}
		}
		internal string ActualType {
			get {
				if (AllowNulls && DataType.IsValueType)
					return DataType.Name + "?";
				return DataType.Name;
			}
		}

		internal string DefaultValueCode {
			get {
				if (defaultValue == null)
					return "null";
				//TODO: Improve
				return defaultValue.ToString().Quote();
			}
		}
	}
}
