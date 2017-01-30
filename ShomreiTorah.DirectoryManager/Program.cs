using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using ShomreiTorah.Common;
using ShomreiTorah.Data;
using ShomreiTorah.Data.UI;
using ShomreiTorah.Data.UI.DisplaySettings;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.WinForms;
using ShomreiTorah.WinForms.Controls.Lookup;

namespace ShomreiTorah.DirectoryManager {
	class Program : AppFramework {
		[STAThread]
		static void Main() { new Program().Run(); }

		protected override ISplashScreen CreateSplash() { return null; }
		protected override void RegisterSettings() {
			if (Config.IsDebug)
				UserLookAndFeel.Default.SkinName = "DevExpress Style";
			else
				UserLookAndFeel.Default.SkinName = "Office 2010 Blue";

			Dialog.DefaultTitle = Config.OrgName + " Directory Manager";
			SkinManager.EnableFormSkins();

			EditorRepository.PersonLookup.AddConfigurator(properties => {
				properties.Columns.RemoveAt(properties.Columns.Count - 1);
				properties.Columns.Add(new DataSourceColumn {
					FieldName = "BalanceDue",
					Caption = "Total Due",
					FormatString = "{0:c}",
				});
			});
		}

		public static ExternalDataManager DataManager { get; private set; }

		protected override Form CreateMainForm() {
			DataManager = new ExternalDataManager(DB.Default);
			RegisterRowDetail<Person>(person => new PersonForm(DataManager.GetPerson(person)) { MdiParent = MainForm }.Show());
			return new MainForm(DataManager);
		}

		protected override DataSyncContext CreateDataContext() {
			var context = new DataContext();

			//These columns cannot be added in the strongly-typed row
			//because the People table must be usable without pledges
			//or payments.  (eg, ListMaker or Rafflizer)
			if (!Person.Schema.Columns.Contains("TotalPaid")) { //This can be called multiple times in the designer AppDomain
				Person.Schema.Columns.AddCalculatedColumn<Person, decimal>("TotalPaid", person => person.Payments.Sum(p => p.Amount));
				Person.Schema.Columns.AddCalculatedColumn<Person, decimal>("TotalPledged", person => person.Pledges.Sum(p => p.Amount));
				Person.Schema.Columns.AddCalculatedColumn<decimal>("BalanceDue", person => person.Field<decimal>("TotalPledged") - person.Field<decimal>("TotalPaid"));

				Payment.Schema.Columns.RemoveColumn(Payment.DepositColumn);

				ValueColumn uiidColumn = Person.Schema.Columns.AddValueColumn(nameof(Extensions.UIId), typeof(int?), null);
				Person.SchemaMapping.Columns.RemoveMapping(uiidColumn);
			}


			context.Tables.AddTable(Pledge.CreateTable());
			context.Tables.AddTable(Payment.CreateTable());
			context.Tables.AddTable(EmailAddress.CreateTable());
			context.Tables.AddTable(Person.CreateTable());

			var dsc = new DataSyncContext(context, new SqlServerSqlProvider(DB.Default));
			dsc.Tables.AddPrimaryMappings();
			return dsc;
		}
	}

	static partial class Extensions {
		static int nextId = 0;
		public static int UIId(this Person person) {
			return person.Field<int?>(nameof(UIId)) ?? (int)(person[nameof(UIId)] = ++nextId);
		}

		public static TRow AssignFrom<TRow>(this TRow target, TRow source) where TRow : Row {
			foreach (var column in source.Schema.Columns) {
				if (!column.ReadOnly)
					target[column] = source[column];
			}
			return target;
		}
	}
}
