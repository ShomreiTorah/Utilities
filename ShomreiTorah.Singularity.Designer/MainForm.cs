using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ShomreiTorah.Common;
using ShomreiTorah.Singularity.Designer.Model;

namespace ShomreiTorah.Singularity.Designer {
	partial class MainForm : RibbonForm {
		DataContextModel context = new DataContextModel();

		public MainForm() {
			InitializeComponent();
			previewPanel.Visibility = DockVisibility.Hidden;
			BindToContext();

			CurrentFilePath = null; //Set menu state
		}

		void BindToContext() {
			schemaTree.Model = context;
			dataContextVGrid.DataSource = new[] { context };

			schemaTree.RefreshList();
			foreach (var child in MdiChildren)
				child.Close();
		}

		private void sqlServerImport_ItemClick(object sender, ItemClickEventArgs e) {
			var newSchemas = Dialogs.SchemaSelector.ShowDialog(SqlReader.ReadSchemas(context, DB.Default));
			if (newSchemas != null)
				context.Schemas.AddRange(newSchemas);
		}

		private void schemaTree_NodeDoubleClick(object sender, EventArgs e) {
			if (!schemaTree.SelectedSchema.IsExternal)
				new SchemaDetailForm(context, schemaTree.SelectedSchema) { MdiParent = this }.Show();
		}

		private void addSchema_ItemClick(object sender, ItemClickEventArgs e) {
			var newSchema = new SchemaModel(context) { Name = "Table" + (context.Schemas.Count + 1) };
			context.Schemas.Add(newSchema);
			new SchemaDetailForm(context, newSchema) { MdiParent = this }.Show();
		}

		private void deleteSchema_ItemClick(object sender, ItemClickEventArgs e) {
			if (schemaTree.SelectedImport != null) {
				var localChildSchemas = schemaTree.SelectedImport.Schemas
					.SelectMany(s => s.ChildSchemas.Where(c => !c.IsExternal));
				if (localChildSchemas.Any()) {
					XtraMessageBox.Show(this, "Cannot remove import because it's referenced by the following child schemas: " + localChildSchemas.Join(", ", c => c.Name),
										"Singularity Designer", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				context.RemoveImport(schemaTree.SelectedImport);
				return;
			}
			if (DialogResult.Yes == XtraMessageBox.Show("Are you sure you want to delete " + schemaTree.SelectedSchema.Name + "?",
														"Singularity Designer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
				context.Schemas.Remove(schemaTree.SelectedSchema);
		}

		private void schemaTree_SelectionChanged(object sender, EventArgs e) {
			if (schemaTree.SelectedImport != null) {
				deleteSchema.Caption = "Delete " + schemaTree.SelectedImport.Name ?? schemaTree.SelectedImport.RelativePath;
				deleteSchema.Enabled = true;
			} else if (schemaTree.SelectedSchema != null) {
				deleteSchema.Caption = "Delete " + schemaTree.SelectedSchema.Name;
				deleteSchema.Enabled = !schemaTree.SelectedSchema.IsExternal;
			} else {
				deleteSchema.Caption = "Delete Schema";
				deleteSchema.Enabled = false;
			}
		}

		[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Ignore errors in compilation or execution")]
		private void generateCode_ItemClick(object sender, ItemClickEventArgs e) {
			try {
				new Dialogs.DataPreview(Dialogs.DataPreview.Compile(context)).Show(this);
			} catch (Exception ex) {
				XtraMessageBox.Show("An error occurred.\r\n" + ex,
									"Generate Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void previewCode_ItemClick(object sender, ItemClickEventArgs e) {
			codeEditor.Source = context.GenerateSource();
			previewPanel.Show();
		}

		#region File Management
		string currentFilePath;
		string CurrentFilePath {
			get { return currentFilePath; }
			set {
				currentFilePath = value;

				viewChanges.Enabled = !string.IsNullOrEmpty(value);
			}
		}

		private void saveAs_ItemClick(object sender, ItemClickEventArgs e) { DoSaveAs(); }
		private void saveFile_ItemClick(object sender, ItemClickEventArgs e) { SaveFile(); }

		bool IsDirty() {
			if (string.IsNullOrEmpty(CurrentFilePath))
				return context.Schemas.Any();

			return !XNode.DeepEquals(XDocument.Load(CurrentFilePath), context.ToXml());
		}
		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);
			e.Cancel = !CheckDirty();
		}
		bool CheckDirty() {
			if (!IsDirty()) return true;

			switch (XtraMessageBox.Show("Do you want to save your changes?", "Singularity Designer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)) {
				case DialogResult.Yes:
					return SaveFile();
				case DialogResult.No:
					return true;
				case DialogResult.Cancel:
					return false;
			}
			throw new InvalidProgramException();
		}
		bool DoSaveAs() {
			using (var saveDialog = new SaveFileDialog {
				FileName = context.Name,
				Filter = "XML Files (*.xml)|*.xml",
				Title = "Save DataContext"
			}) {
				if (saveDialog.ShowDialog(this) != DialogResult.OK)
					return false;
				CurrentFilePath = saveDialog.FileName;
			}
			SaveFile();
			return true;
		}
		bool SaveFile() {
			if (string.IsNullOrEmpty(CurrentFilePath))
				return DoSaveAs();
			if (!Program.EnsureWritable(CurrentFilePath))
				return false;

			context.ToXml().Save(CurrentFilePath);
			return true;
		}

		private void newFile_ItemClick(object sender, ItemClickEventArgs e) {
			if (!CheckDirty()) return;
			CurrentFilePath = null;
			context = new DataContextModel();

			BindToContext();
		}

		private void openFile_ItemClick(object sender, ItemClickEventArgs e) {
			if (!CheckDirty()) return;

			using (var openDialog = new OpenFileDialog {
				FileName = context.Name,
				Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
				Title = "Open DataContext"
			}) {
				if (openDialog.ShowDialog(this) != DialogResult.OK)
					return;
				CurrentFilePath = openDialog.FileName;
			}
			context = new DataContextModel(CurrentFilePath);
			BindToContext();
		}

		#endregion
		private void importExternal_ItemClick(object sender, ItemClickEventArgs e) {
			if (string.IsNullOrEmpty(CurrentFilePath)) {
				XtraMessageBox.Show(this, "Cannot import external DataContexts until the current context has been saved (since imports use relative paths).",
									"Singularity Designer", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			using (var openDialog = new OpenFileDialog {
				FileName = context.Name,
				Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
				Title = "Import External DataContext"
			}) {
				if (openDialog.ShowDialog(this) != DialogResult.OK)
					return;
				CurrentFilePath = openDialog.FileName;
				context.ImportContext(
					Uri.UnescapeDataString(new Uri(CurrentFilePath).MakeRelativeUri(new Uri(openDialog.FileName)).ToString()));
			}
		}

		private void diffCode_ItemClick(object sender, ItemClickEventArgs e) {
			var path1 = Path.GetTempFileName();
			var path2 = Path.GetTempFileName();

			using (var writer = File.CreateText(path1))
				new DataContextModel(CurrentFilePath)
					.WriteClasses(writer);
			using (var writer = File.CreateText(path2))
				context.WriteClasses(writer);

			ShowDiff(path1, path2, true);
		}

		private void diffXml_ItemClick(object sender, ItemClickEventArgs e) {
			var path2 = Path.GetTempFileName();
			context.ToXml().Save(path2);
			ShowDiff(CurrentFilePath, path2, false);
		}
		[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Ignore IO errors")]
		static void ShowDiff(string path1, string path2, bool deleteFirst) {
			ThreadPool.QueueUserWorkItem(delegate {
				var proc = Process.Start("P4Merge", "\"" + path1.Replace("\"", "\"\"") + "\" \"" + path2.Replace("\"", "\"\"") + "\"");
				proc.WaitForExit();

				try {
					File.Delete(path2);
					if (deleteFirst)
						File.Delete(path1);
				} catch { }
			});
		}

		private void saveCode_ItemClick(object sender, ItemClickEventArgs e) {
			if (String.IsNullOrEmpty(CurrentFilePath)) {
				XtraMessageBox.Show("Please save the XML file first.",
									"Singularity Designer", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (String.IsNullOrEmpty(context.CodePath)) {
				XtraMessageBox.Show("Please enter the Code Path for the DataContext.",
									"Singularity Designer", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			var path = Path.Combine(Path.GetDirectoryName(CurrentFilePath), context.CodePath);
			if (!Program.EnsureWritable(path)) return;
			using (var writer = File.CreateText(path)) {
				context.WriteClasses(writer);
			}
		}
	}
}