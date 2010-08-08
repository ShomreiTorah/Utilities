using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class ModelExtensions {
		public static IEnumerable<ColumnModel> NonCalculated(this IEnumerable<ColumnModel> columns) {
			return columns.Where(c => string.IsNullOrEmpty(c.Expression));
		}

		static readonly Regex CamelCaseSplitter = new Regex(@"(?<![A-Z])(?=[A-Z]+)|(?<=[A-Z])(?=[A-Z][^A-Z])");
		public static string SplitWords(this string name) {
			if (name == null) return null;

			return String.Join(" ",
				CamelCaseSplitter.Split(name)
								 .Select(s => s.Any(Char.IsLower) ? s.ToLower(CultureInfo.CurrentCulture) : s)
			).Trim();
		}
		public static string Depluralize(this string name) {
			if (name == null) return null;
			return name.EndsWith("s") ? name.Remove(name.Length - 1) : name;
		}
	}
}
