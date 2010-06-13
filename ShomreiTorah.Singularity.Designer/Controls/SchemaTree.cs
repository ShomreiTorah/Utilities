using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace ShomreiTorah.Singularity.Designer.Controls {
	[DefaultEvent("SelectionChanged")]
	partial class SchemaTree : XtraUserControl {
		public SchemaTree() {
			InitializeComponent();
		}

		public IList<SchemaModel> Schemas { get; set; }

		public void RefreshList() {
			tree.BeginUnboundLoad();

			foreach (var schema in Schemas) {
				AddSchemaTree(schema, null);
			}
			tree.BestFitColumns();
			tree.EndUnboundLoad();
		}
		void AddSchemaTree(SchemaModel schema, TreeListNode parentNode) {
			var node = tree.AppendNode(new object[] { schema.Name, schema.SqlSchemaName }, parentNode, schema);

			foreach (var child in schema.ChildSchemas) {
				AddSchemaTree(child, node);
			}
		}

		[Browsable(false)]
		public SchemaModel SelectedSchema {
			get {
				if (tree.FocusedNode == null) return null;
				return (SchemaModel)tree.FocusedNode.Tag;
			}
		}

		private void tree_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
			OnSelectionChanged();
		}


		private void tree_MouseDoubleClick(object sender, MouseEventArgs e) {
			var hitInfo = tree.CalcHitInfo(e.Location);
			tree.FocusedNode = hitInfo.Node;
			if (hitInfo.Node != null)
				OnNodeDoubleClick();
		}

		///<summary>Occurs when a schema is selected.</summary>
		public event EventHandler SelectionChanged;
		///<summary>Raises the SelectionChanged event.</summary>
		internal protected virtual void OnSelectionChanged() { OnSelectionChanged(EventArgs.Empty); }
		///<summary>Raises the SelectionChanged event.</summary>
		///<param name="e">An EventArgs object that provides the event data.</param>
		internal protected virtual void OnSelectionChanged(EventArgs e) {
			if (SelectionChanged != null)
				SelectionChanged(this, e);
		}
		///<summary>Occurs when a node is double-clicked.</summary>
		public event EventHandler NodeDoubleClick;
		///<summary>Raises the NodeDoubleClick event.</summary>
		internal protected virtual void OnNodeDoubleClick() { OnNodeDoubleClick(EventArgs.Empty); }
		///<summary>Raises the NodeDoubleClick event.</summary>
		///<param name="e">An EventArgs object that provides the event data.</param>
		internal protected virtual void OnNodeDoubleClick(EventArgs e) {
			if (NodeDoubleClick != null)
				NodeDoubleClick(this, e);
		}

	}
}
