using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShomreiTorah.Singularity.Designer.Controls {
	partial class CodeEditor : UserControl {
		public CodeEditor() {
			InitializeComponent();
		}

		public string Source {
			get { return textEditor.Text; }
			set { textEditor.Text = value; }
		}
	}
}
