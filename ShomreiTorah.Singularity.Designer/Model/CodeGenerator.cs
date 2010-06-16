using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class CodeGenerator {
		public static string Quote(this string value) {
			if (value == null) return "null";
			StringBuilder b = new StringBuilder(value.Length + 5);

			b.Append("\"");	//Adapted from .Net source (Microsoft.CSharp.CSharpCodeGenerator.QuoteSnippetStringCStyle)

			for (int i = 0; i < value.Length; i++) {
				switch (value[i]) {
					case '\r':
						b.Append(@"\r");
						break;
					case '\t':
						b.Append(@"\t");
						break;
					case '\"':
						b.Append(@"\""");
						break;
					case '\'':
						b.Append(@"\'");
						break;
					case '\\':
						b.Append(@"\\");
						break;
					case '\0':
						b.Append(@"\0");
						break;
					case '\n':
						b.Append(@"\n");
						break;
					case '\u2028':
					case '\u2029':
						b.Append(@"\u");
						b.Append(((int)value[i]).ToString("X4", CultureInfo.InvariantCulture));
						break;

					default:
						b.Append(value[i]);
						break;
				}
			}

			b.Append("\"");

			return b.ToString();
		}

		public static void WriteClasses(this DataContextModel model, TextWriter writer) {
			if (model == null) throw new ArgumentNullException("model");
			if (writer == null) throw new ArgumentNullException("writer");

			var indentedWriter = new IndentedTextWriter(writer);
			indentedWriter.WriteLine("using System;");
			indentedWriter.WriteLine("using System.CodeDom.Compiler;");
			indentedWriter.WriteLine("using System.Diagnostics;");
			indentedWriter.WriteLine("using ShomreiTorah.Singularity;");
			indentedWriter.WriteLine("using ShomreiTorah.Singularity.Sql;");
			indentedWriter.WriteLine();
			indentedWriter.WriteLine("namespace " + model.Namespace + " {");
			indentedWriter.Indent++;

			bool first = true;
			foreach (var schema in model.Schemas) {
				if (first)
					first = false;
				else
					indentedWriter.WriteLine();
				WriteSchema(schema, indentedWriter);
			}

			indentedWriter.Indent--;
			indentedWriter.WriteLine("}");
		}

		static void WriteSchema(SchemaModel schema, IndentedTextWriter writer) {
			writer.WriteLine(schema.RowClassVisibility.ToString().ToLowerInvariant() + " partial class " + schema.RowClassName + " : Row {");
			writer.Indent++;

			writer.WriteLine(@"///<summary>Creates a new  " + schema.RowClassName + @" instance.</summary>");
			writer.WriteLine("public " + schema.RowClassName + " () : base(Schema) { Initialize(); }");
			writer.WriteLine("partial void Initialize();");

			writer.WriteLine();

			writer.WriteLine(@"///<summary>Creates a strongly-typed  " + schema.Name + @" table.</summary>");
			writer.WriteLine("public static TypedTable<" + schema.RowClassName + "> CreateTable() "
								+ "{ return new TypedTable<" + schema.RowClassName + ">(Schema, () => new " + schema.RowClassName + "()); }");

			writer.WriteLine();
			foreach (var column in schema.Columns) {
				writer.WriteLine(@"///<summary>Gets the schema's " + column.Name + @" column.</summary>");
				writer.WriteLine("public static " + column.ColumnType.Name + " " + column.ColumnPropertyName + " { get; private set; }");
			}
			writer.WriteLine();


			writer.WriteLine(@"///<summary>Gets the " + schema.Name + @" schema instance.</summary>");
			writer.WriteLine("public static new TypedSchema<" + schema.RowClassName + "> Schema { get; private set; }");

			writer.WriteLine(@"///<summary>Gets the SchemaMapping that maps this schema to the SQL Server " + schema.SqlName + @" table.</summary>");
			writer.WriteLine("public static SchemaMapping SchemaMapping { get; private set; }");

			writer.WriteLine();
			writer.WriteGeneratedCodeAttribute();
			writer.WriteLine("static " + schema.RowClassName + "() {");
			writer.Indent++;
			writer.WriteLine("#region Create Schema");
			writer.WriteLine("Schema = new TypedSchema<" + schema.RowClassName + ">(" + schema.Name.Quote() + ");");
			foreach (var column in schema.Columns) {
				writer.WriteLine();
				WriteColumnCreation(column, writer);
			}
			writer.WriteLine("#endregion");
			writer.WriteLine();

			writer.WriteLine("#region Create SchemaMapping");
			writer.WriteLine("SchemaMapping = new SchemaMapping(Schema, false);");
			writer.WriteLine("SchemaMapping.SqlName = " + schema.SqlName.Quote() + ";");
			writer.WriteLine("SchemaMapping.SqlSchemaName = " + schema.SqlSchemaName.Quote() + ";");
			writer.WriteLine();
			foreach (var column in schema.Columns)
				writer.WriteLine("SchemaMapping.Columns.AddMapping(" + column.PropertyName + "Column, " + column.SqlName.Quote() + ");");
			writer.WriteLine("#endregion");

			writer.Indent--;
			writer.WriteLine("}");

			writer.WriteLine();

			writer.WriteLine("#region Value Properties");
			foreach (var column in schema.Columns)
				WriteValueProperty(column, writer);
			writer.WriteLine("#endregion");

			writer.WriteLine();

			writer.Write("#region Partial Methods");
			foreach (var column in schema.Columns) {	//TODO: Where not calculated
				writer.WriteLine();
				WriteColumnPartials(column, writer);
			}
			writer.WriteLine("#endregion");

			writer.WriteLine();

			writer.WriteLine("#region Column Callbacks");
			#region ValidateValue
			writer.WriteLine(@"///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>");
			writer.WriteLine(@"///<param name=""column"">The column containing the value.</param>");
			writer.WriteLine(@"///<param name=""newValue"">The value to validate.</param>");
			writer.WriteLine(@"///<returns>An error message, or null if the value is valid.</returns>");
			writer.WriteLine(@"///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>");
			writer.WriteGeneratedCodeAttribute();
			writer.WriteLine("public override string ValidateValue(Column column, object newValue) {");
			writer.Indent++;
			writer.WriteLine("string error = base.ValidateValue(column, newValue);");
			writer.WriteLine("if (!String.IsNullOrEmpty(error)) return error;");
			writer.WriteLine("Action<string> reporter = s => error = s;");
			writer.WriteLine();

			bool first = true;
			foreach (var column in schema.Columns) {	//TODO: Where not calculated
				if (first)
					first = false;
				else
					writer.Write("} else ");
				writer.WriteLine("if (column == " + column.PropertyName + "Column) {");
				writer.Indent++;
				writer.WriteLine("Validate" + column.PropertyName + "((" + column.ActualType + ")newValue, reporter);");
				writer.WriteLine("if (!String.IsNullOrEmpty(error)) return error;");
				writer.Indent--;
			}
			writer.WriteLine("}");

			writer.WriteLine("return null;");

			writer.Indent--;
			writer.WriteLine("}");
			#endregion
			#region OnValueChanged
			writer.WriteLine(@"///<summary>Processes an explicit change of a column value.</summary>");
			writer.WriteGeneratedCodeAttribute();
			writer.WriteLine("protected override void OnValueChanged(Column column, object oldValue, object newValue) {");
			writer.Indent++;

			first = true;
			foreach (var column in schema.Columns) {	//TODO: Where not calculated
				if (first)
					first = false;
				else
					writer.Write("else ");
				writer.WriteLine("if (column == " + column.PropertyName + "Column)");
				writer.WriteLine("\tOn" + column.PropertyName + "Changed((" + column.ActualType + ")oldValue, (" + column.ActualType + ")newValue);");
			}
			writer.WriteLine();
			writer.WriteLine("base.OnValueChanged(column, oldValue, newValue);");

			writer.Indent--;
			writer.WriteLine("}");
			#endregion
			writer.WriteLine("#endregion");

			writer.Indent--;
			writer.WriteLine("}");
		}

		static void WriteColumnCreation(ColumnModel column, IndentedTextWriter writer) {
			//TODO: Calculated Columns

			if (column == column.Owner.PrimaryKey)
				writer.Write("Schema.PrimaryKey = ");
			if (column.ForeignSchema != null) {
				writer.WriteLine(column.ColumnPropertyName
					+ " = Schema.Columns.AddForeignKey(" + column.Name.Quote() + ", " + column.ForeignSchema.RowClassName + ".Schema, " + column.ForeignRelationName.Quote() + ");");
			} else {
				writer.WriteLine(column.ColumnPropertyName
					+ " = Schema.Columns.AddValueColumn(" + column.Name.Quote() + ", typeof(" + column.DataType.Name + "), " + column.DefaultValueCode + ");");
			}
			if (column.IsUnique)
				writer.WriteLine(column.ColumnPropertyName + ".Unique = true;");
			writer.WriteLine(column.ColumnPropertyName + ".AllowNulls = " + column.AllowNulls.ToString().ToLowerInvariant() + ";");
		}

		static void WriteColumnPartials(ColumnModel column, IndentedTextWriter writer) {
			writer.WriteLine("partial void Validate" + column.PropertyName + "(" + column.ActualType + " newValue, Action<string> error);");
			writer.WriteLine("partial void On" + column.PropertyName + "Changed(" + column.ActualType + " oldValue, " + column.ActualType + " newValue);");
		}

		static void WriteValueProperty(ColumnModel column, IndentedTextWriter writer) {
			writer.WriteGeneratedCodeAttribute();
			writer.WriteLine(column.PropertyVisibility.ToString().ToLowerInvariant() + " " + column.ActualType + " " + column.PropertyName + " {");
			writer.Indent++;
			writer.WriteLine("get { return base.Field<" + column.ActualType + ">(" + column.ColumnPropertyName + "); }");
			writer.WriteLine("set { base[" + column.ColumnPropertyName + "] = value; }");
			writer.Indent--;
			writer.WriteLine("}");
		}

		static void WriteGeneratedCodeAttribute(this TextWriter writer) {
			writer.WriteLine(@"[DebuggerNonUserCode]");
			writer.WriteLine(@"[GeneratedCode(""ShomreiTorah.Singularity.Designer"", ""1.0"")]");
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
