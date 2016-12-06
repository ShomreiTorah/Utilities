using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ShomreiTorah.Singularity.Sql;
using ShomreiTorah.Singularity.Designer.Model;
using System.CodeDom.Compiler;
using ShomreiTorah.Common;
using System.Linq;
using Microsoft.CSharp;
using System.Reflection;
using System.IO;
using System.Threading;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList;

namespace ShomreiTorah.Singularity.Designer.Dialogs {
	partial class DataPreview : XtraForm {
		#region Compile
		static readonly Assembly[] References = new[] { typeof(DataContext).Assembly, typeof(DB).Assembly, typeof(Enumerable).Assembly, typeof(Component).Assembly };
		public static SchemaMapping[] Compile(DataContextModel model) {
			var options = new CompilerParameters(References.Select(a => a.Location).ToArray()) {
				GenerateInMemory = true
			};
			try {
				var sourceFile = options.TempFiles.AddExtension("cs");

				using (var writer = new StreamWriter(sourceFile))
					model.WriteClasses(writer);

				var compiler = new CSharpCodeProvider(new Dictionary<string, string> { { "CompilerVersion", "v4.0" } });

				var results = compiler.CompileAssemblyFromFile(options, sourceFile);

				if (results.Errors.Count > 0)
					throw new InvalidOperationException(results.Errors.Cast<CompilerError>().Join(Environment.NewLine, ce => ce.ErrorText));

				return
					model.Schemas.Select(s =>
						(SchemaMapping)
							results.CompiledAssembly
								   .GetType(model.Namespace + "." + s.RowClassName)
								   .GetProperty("SchemaMapping").GetValue(null, null)
					).SortDependencies(sm => sm.Schema)
					 .ToArray();
			} finally { options.TempFiles.Delete(); }
		}
		#endregion
		readonly Dictionary<TreeListNode, LoadableTable> tableNodes = new Dictionary<TreeListNode, LoadableTable>();
		readonly Dictionary<TableSchema, LoadableTable> schemaTables;
		readonly DataContext context = new DataContext();
		readonly IReadOnlyList<LoadableTable> tables;
		public DataPreview(SchemaMapping[] schemas) {
			InitializeComponent();

			tables = schemas
				.SortDependencies(sm => sm.Schema)
				.Reverse()
				.Select(sm => new LoadableTable(context, sm))
				.ToList();
			schemaTables = tables.ToDictionary(t => t.Schema);

			schemaTree.BeginUnboundLoad();
			schemaTree.ClearNodes();

			foreach (var table in tables) {
				AddSchemaTree(table, null);
			}
			schemaTree.BestFitColumns();
			schemaTree.EndUnboundLoad();
		}
		void AddSchemaTree(LoadableTable table, TreeListNode parentNode) {
			var node = schemaTree.AppendNode(new object[] { table.Schema.Name, null }, parentNode, table);
			tableNodes.Add(node, table);

			foreach (var child in table.Schema.ChildRelations.Select(cr => schemaTables[cr.ChildSchema]))
				AddSchemaTree(child, node);
		}
		IEnumerable<TreeListNode> GetNodes(LoadableTable table) { return tableNodes.Where(kvp => kvp.Value == table).Select(kvp => kvp.Key); }

		static readonly ISqlProvider sqlProvider = new SqlServerSqlProvider(DB.Default);

		class LoadableTable {
			public LoadableTable(DataContext context, SchemaMapping mapping) {
				Mapping = mapping;

				Synchronizer = new TableSynchronizer(CreateTable(), Mapping, sqlProvider);
				context.Tables.AddTable(Synchronizer.Table);
			}
			public TableState State { get; private set; }
			public SchemaMapping Mapping { get; private set; }
			public TableSchema Schema { get { return Mapping.Schema; } }
			public TableSynchronizer Synchronizer { get; private set; }
			public Table Table { get { return Synchronizer.Table; } }

			public void Load(Action callback) {
				if (State != TableState.NotLoaded) return;
				var context = SynchronizationContext.Current;
				State = TableState.Loading;

				ThreadPool.QueueUserWorkItem(delegate {
					Synchronizer.ReadData();
					context.Post(delegate { State = TableState.Loaded; callback(); }, null);
				});
			}

			Table CreateTable() {
				return (Table)Schema.GetType().GetGenericArguments()[0].GetMethod("CreateTable").Invoke(null, null);
			}
		}
		enum TableState {
			NotLoaded,
			Loading,
			Loaded
		}

		private void loaderEdit_ButtonClick(object sender, ButtonPressedEventArgs e) {
			var table = (LoadableTable)schemaTree.FocusedNode.Tag;
			LoadTable(table);
		}

		void LoadTable(LoadableTable table, Action callback = null) {
			var nodes = GetNodes(table).ToArray();

			table.Load(delegate {
				string caption = table.Table.Rows.Count == 1 ? "1 Row" : table.Table.Rows.Count + " Rows";
				foreach (var node in nodes)
					node.SetValue(colContent, caption);
				UpdateLoadAllButton();

				if (callback != null) callback();
			});
			schemaTree.HideEditor();
			schemaTree.InvalidateNodes();
			UpdateLoadAllButton();
		}

		private void schemaTree_CustomNodeCellEdit(object sender, GetCustomNodeCellEditEventArgs e) {
			if (e.Column != colContent) return;
			var table = (LoadableTable)e.Node.Tag;
			switch (table.State) {
				case TableState.NotLoaded:
					e.RepositoryItem = loaderEdit;
					break;
				case TableState.Loading:
					e.RepositoryItem = loadingEdit;
					break;
				case TableState.Loaded:
				default:
					e.RepositoryItem = loadedEdit;
					break;
			}
		}

		private void schemaTree_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
			if (e.Node == null) return;
			var table = (LoadableTable)e.Node.Tag;
			grid.Visible = table.State == TableState.Loaded;
			if (table.State == TableState.Loaded) {
				grid.DataSource = table.Table;
				gridView.PopulateColumns();
				if (table.Schema.PrimaryKey != null)
					gridView.Columns[table.Schema.PrimaryKey.Name].Visible = false;
				gridView.BestFitColumns();
			}
		}

		private void loadAllTables_Click(object sender, EventArgs e) {
			loaderEdit.Buttons[0].Enabled = false;
			var tableQueue = new Queue<LoadableTable>(tables.SortDependencies(t => t.Schema).Where(t => t.State == TableState.NotLoaded));

			Action callback = null;
			callback = delegate { if (tableQueue.Any()) LoadTable(tableQueue.Dequeue(), callback); };
			callback();
		}
		void UpdateLoadAllButton() {
			if (loadAllTables.Visible = tables.Any(t => t.State == TableState.NotLoaded))
				loadAllTables.Enabled = tables.All(t => t.State != TableState.Loading);
		}
	}
}