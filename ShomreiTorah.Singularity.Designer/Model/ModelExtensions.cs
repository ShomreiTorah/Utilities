using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShomreiTorah.Singularity.Designer.Model {
	static class ModelExtensions {
		public static IEnumerable<ColumnModel> NonCalculated(this IEnumerable<ColumnModel> columns) {
			return columns.Where(c => string.IsNullOrEmpty(c.Expression));
		}
	}
}
