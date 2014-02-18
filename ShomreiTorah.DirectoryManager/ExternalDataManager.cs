using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using ShomreiTorah.Common;
using ShomreiTorah.Data;

namespace ShomreiTorah.DirectoryManager {
	public class ExternalDataManager : IDisposable {
		private class ExternalTable {
			public ExternalTable(string schema, string name, IEnumerable<string> foreignKeys) {
				Schema = schema;
				Name = name;
				ForeignKeys = foreignKeys.ToList().AsReadOnly();

				SelectSql = "SELECT * FROM "
						  + schema.EscapeSqlIdentifier() + "." + name.EscapeSqlIdentifier()
						  + " WHERE " + foreignKeys.Join(" OR ", c => c.EscapeSqlIdentifier() + " = @personId");
				DeleteSql = "DELETE FROM "
						  + schema.EscapeSqlIdentifier() + "." + name.EscapeSqlIdentifier()
						  + " WHERE " + foreignKeys.Join(" OR ", c => c.EscapeSqlIdentifier() + " = @Id");
				UpdateSql = foreignKeys.Join(";\n", c =>
								"UPDATE "
							  + schema.EscapeSqlIdentifier() + "." + name.EscapeSqlIdentifier()
							  + " SET " + c.EscapeSqlIdentifier() + " = @newId"
							  + " WHERE " + c.EscapeSqlIdentifier() + " = @oldId"
				);
			}

			public string Schema { get; private set; }
			public string Name { get; private set; }
			public ReadOnlyCollection<string> ForeignKeys { get; private set; }

			public string SelectSql { get; private set; }
			public string UpdateSql { get; private set; }
			public string DeleteSql { get; private set; }
		}

		readonly ReadOnlyCollection<ExternalTable> tables;
		readonly DBConnector db;
		readonly DbConnection connection;

		public ExternalDataManager(DBConnector db, DbConnection connection = null) {
			this.db = db;
			this.connection = connection ?? db.OpenConnection();
			tables = GetTables();
		}


		public int DeletePerson(DbTransaction transaction, Person person) {
			return transaction.ExecuteNonQuery(tables.Join(";\n", t => t.DeleteSql) + ";\n\nDELETE FROM Data.MasterDirectory WHERE Id = @Id", new { person.Id });
		}
		public int MergePerson(DbTransaction transaction, PersonRowData oldPerson, Person newPerson) {

			return 
				transaction.ExecuteNonQuery(
					tables.Join(";\n\n\n", t => t.UpdateSql) 
				  + ";\n\n\nUPDATE Data.MasterDirectory SET StripeId = @oldStripeId WHERE Id = @newId AND StripeId IS NULL"
				  + ";\n\n\nDELETE FROM Data.MasterDirectory WHERE Id = @oldId", new { oldId = oldPerson.Person.Id, newId = newPerson.Id, oldStripeId = oldPerson.StripeId });
		}

		public PersonRowData GetPerson(Person person) {
			using (var adapter = db.Factory.CreateDataAdapter(connection, tables.Join(";\n", t => t.SelectSql))) {
				adapter.SelectCommand.AddParameter("personId", person.Id);
				var ds = new DataSet();
				adapter.Fill(ds);
				// Copy the collection before removing items
				foreach (var t in ds.Tables.Cast<DataTable>().Zip(tables, (Table, et) => new { Table, et.Schema, et.Name }).ToList()) {
					if (t.Table.Rows.Count == 0)
						ds.Tables.Remove(t.Table);
					else
						t.Table.TableName = t.Schema + "." + t.Name;
				}
				return new PersonRowData(this, person, ds, connection.Sql<string>("SELECT StripeId FROM Data.MasterDirectory WHERE Id = @Id").Execute(new { person.Id }));
			}
		}

		private ReadOnlyCollection<ExternalTable> GetTables() {
			using (var reader = connection.ExecuteReader(@"
SELECT
	ChildColumns.TABLE_SCHEMA,
	ChildColumns.TABLE_NAME,
	ChildColumns.COLUMN_NAME
FROM	INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS Refs
		JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE ChildColumns		ON Refs.CONSTRAINT_NAME = ChildColumns.CONSTRAINT_NAME
		JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS ParentConstraints	ON Refs.UNIQUE_CONSTRAINT_NAME = ParentConstraints.CONSTRAINT_NAME
WHERE ParentConstraints.TABLE_SCHEMA = @SqlSchemaName AND ParentConstraints.TABLE_NAME = @SqlName
", new { Person.SchemaMapping.SqlSchemaName, Person.SchemaMapping.SqlName })) {
				return (from DbDataRecord dr in reader.Cast<DbDataRecord>()
						let column = dr.GetString(2)
						group column by new { Schema = dr.GetString(0), Table = dr.GetString(1) } into g
						select new ExternalTable(g.Key.Schema, g.Key.Table, g)
						 ).ToList().AsReadOnly();
			}
		}


		///<summary>Releases all resources used by the ExternalDataManager.</summary>
		public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
		///<summary>Releases the unmanaged resources used by the ExternalDataManager and optionally releases the managed resources.</summary>
		///<param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing) {
			if (disposing) {
				connection.Dispose();
			}
		}
	}

	public class PersonRowData {
		public PersonRowData(ExternalDataManager owner, Person person, DataSet dataSet, string stripeId) {
			Owner = owner;
			Person = person;
			DataSet = dataSet;
			StripeId = stripeId;
		}

		public ExternalDataManager Owner { get; private set; }
		public Person Person { get; private set; }
		public DataSet DataSet { get; private set; }
		public string StripeId { get; private set; }
	}
	static class Extensions {
		public static string EscapeSqlIdentifier(this string identifier) {
			return "[" + identifier.Replace("]", "]]") + "]";
		}
	}
}
