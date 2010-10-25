using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShomreiTorah.WinForms;
using System.IO;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace ShomreiTorah.Singularity.Designer {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Dialog.DefaultTitle = "Singularity Designer";
			Application.Run(new MainForm());
		}

		[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Error handling")]
		public static bool EnsureWritable(string path) {
			if (!new FileInfo(path).IsReadOnly)
				return true;
			try {
				var proc = Process.Start(new ProcessStartInfo("p4", "edit \"" + path + "\"") {
					RedirectStandardError = true,
					UseShellExecute = false,
					CreateNoWindow = true
				});
				proc.WaitForExit();
				var error = proc.StandardError.ReadToEnd();
				if (!String.IsNullOrWhiteSpace(error)) {
					Dialog.ShowError(error);
					return new FileInfo(path).IsReadOnly;
				}
			} catch (Exception ex) {
				Dialog.ShowError("Couldn't checkout " + path + ".\r\n\r\n" + ex);
				return false;
			}
			if (new FileInfo(path).IsReadOnly) {
				Dialog.ShowError("Couldn't checkout " + path + ".");
				return false;
			}
			return true;
		}
	}
}
