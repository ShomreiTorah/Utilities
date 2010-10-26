using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShomreiTorah.Data.UI;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.Singularity;
using ShomreiTorah.Data;
using ShomreiTorah.Common;
using ShomreiTorah.WinForms;

namespace YKLookup {
	class Program : AppFramework {
		[STAThread]
		static void Main() { new Program().Run(); }

		protected override ISplashScreen CreateSplash() { return null; }
		protected override void RegisterSettings() {
			Dialog.DefaultTitle = "YK Lookup";
		}

		protected override Form CreateMainForm() {
			return new LookupForm();
		}

		protected override DataSyncContext CreateDataContext() {
			var context = new DataContext();
			context.Tables.AddTable(Person.CreateTable());
			var dsc = new DataSyncContext(context, new SqlServerSqlProvider(DB.Default));
			dsc.Tables.AddPrimaryMappings();
			return dsc;
		}
	}
}
