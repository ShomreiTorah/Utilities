using System;
using System.Collections.Generic;
using System.Data.Entity.Design.PluralizationServices;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class ModelExtensions {
		///<summary>Sorts a set of schemas so that each schema is returned after all of its dependencies.</summary>
		///<remarks>If the schemas contain a cyclic dependency, an exception will be thrown.</remarks>
		public static IEnumerable<SchemaModel> SortDependencies(this IEnumerable<SchemaModel> items) { return items.SortDependencies(ts => ts); }
		///<summary>Sorts a set of schemas so that each schema is returned after all of its dependencies.</summary>
		///<remarks>If the schemas contain a cyclic dependency, an exception will be thrown.</remarks>
		public static IEnumerable<T> SortDependencies<T>(this IEnumerable<T> items, Func<T, SchemaModel> schemaSelector) {
			if (items == null) throw new ArgumentNullException("items");
			if (schemaSelector == null) throw new ArgumentNullException("schemaSelector");

			var pendingItems = items.ToList();
			var processedSchemas = new HashSet<SchemaModel>();

			var returnedTables = new List<T>();

			while (pendingItems.Any()) {
				returnedTables.Clear();

				foreach (var item in pendingItems) {
					var schema = schemaSelector(item);

					if (!schema.Columns.Select(c => c.ForeignSchema).Where(s => s != null).Except(processedSchemas).Any()) {
						returnedTables.Add(item);
						processedSchemas.Add(schema);

						yield return item;
					}
				}

				if (returnedTables.Count == 0)
					throw new InvalidOperationException("Cyclic dependency detected");
				pendingItems.RemoveAll(returnedTables.Contains);
			}
		}

		public static string GenerateSource(this DataContextModel context) {
			var writer = new StringWriter(CultureInfo.InvariantCulture);
			context.WriteClasses(writer);
			return writer.ToString();
		}

		public static IEnumerable<ColumnModel> NonCalculated(this IEnumerable<ColumnModel> columns) {
			return columns.Where(c => string.IsNullOrEmpty(c.Expression));
		}

		static Regex SpaceTrimmer = new Regex(@"\s+");
		static readonly Regex CamelCaseSplitter = new Regex(@"_|(?<![A-Z])(?=[A-Z]+)|(?<=[A-Z])(?=[A-Z][^A-Z_])");
		public static string SplitWords(this string name) {
			if (name == null) return null;

			return SpaceTrimmer.Replace(String.Join(" ",
				CamelCaseSplitter.Split(name)
								 .Select(s => s.Any(Char.IsLower) ? s.ToLower(CultureInfo.CurrentCulture) : s)
			), " ").Trim();
		}

		static PluralizationService pluralizer = PluralizationService.CreateService(CultureInfo.CurrentCulture);
		public static string Depluralize(this string name) {
			if (name == null) return null;
			return pluralizer.Singularize(name);
		}
		public static string Pluralize(this string name) {
			if (name == null) return null;
			return pluralizer.Pluralize(name);
		}
	}
}
