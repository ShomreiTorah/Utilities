using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.WinForms;

namespace YKLookup {
	class Program : AppFramework {
		[STAThread]
		static void Main() { new Program().Run(); }

		protected override ISplashScreen CreateSplash() { return null; }
		protected override void RegisterSettings() {
			Dialog.DefaultTitle = "YK Lookup";
			SkinManager.EnableFormSkins();
			UserLookAndFeel.Default.SkinName = "Blue";// "Office 2010 Blue";
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
