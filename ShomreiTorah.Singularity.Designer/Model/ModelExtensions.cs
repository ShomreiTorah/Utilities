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

		static Regex SpaceTrimmer = new Regex(@"\s+");
		static readonly Regex CamelCaseSplitter = new Regex(@"_|(?<![A-Z])(?=[A-Z]+)|(?<=[A-Z])(?=[A-Z][^A-Z_])");
		public static string SplitWords(this string name) {
			if (name == null) return null;

			return SpaceTrimmer.Replace(String.Join(" ",
				CamelCaseSplitter.Split(name)
								 .Select(s => s.Any(Char.IsLower) ? s.ToLower(CultureInfo.CurrentCulture) : s)
			), " ").Trim();
		}
		public static string Depluralize(this string name) {
			if (name == null) return null;
			return name[name.Length - 1] == 's' ? name.Remove(name.Length - 1) : name;
		}
	}
}
