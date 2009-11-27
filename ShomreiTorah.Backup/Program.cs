using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShomreiTorah.Common;
using System.IO;
using System.Threading;

namespace ShomreiTorah.Backup {
	class Program {
		static void Main() {
			try {
				ExecOperation(DbBackup.DoBackup(), "Database");
			} catch (Exception ex) {
				Email.Warn("Database Backup Exception", ex.ToString());
			}
			Thread.Sleep(TimeSpan.FromSeconds(10));	//Give the async error emails time to finish.  Yes, I know that this is a horrible thing to do.
		}
		static void ExecOperation(IEnumerator<string> operation, string name) {
			using (operation) {
				string current = "Loading";
				while (true) {
					try {
						if (!operation.MoveNext()) return;
						current = operation.Current;
					} catch (Exception ex) {
						Email.Warn(name + " Backup Exception: " + current, ex.ToString());
					}
				}
			}
		}

		public static bool AreEqual(string first, string second) {
			using (var stream1 = File.Open(first, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			using (var stream2 = File.Open(second, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
				return stream1.IsEqualTo(stream2);
			}
		}
	}
}
