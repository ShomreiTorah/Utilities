using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShomreiTorah.Common;

namespace ShomreiTorah.Backup {
	class Program {
		static void Main() {
			try {
				ExecOperation(DbBackup.DoBackup(), "Database");
			} catch (Exception ex) {
				Email.Warn("Database Backup Exception", ex.ToString());
			}
		}
		static void ExecOperation(IEnumerator<string> operation, string name) {
			using (operation) {
				string current = "Loading";
				while (true) {
					try {
						if (!operation.MoveNext()) return;
						current = operation.Current;
					} catch (Exception ex) {
						Email.Warn(name + "Backup Exception" + current, ex.ToString());
					}
				}
			}
		}
	}
}
