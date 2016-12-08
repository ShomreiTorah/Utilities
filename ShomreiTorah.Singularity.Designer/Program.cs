using System;
using System.Windows.Forms;
using ShomreiTorah.WinForms;

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
	}
}
