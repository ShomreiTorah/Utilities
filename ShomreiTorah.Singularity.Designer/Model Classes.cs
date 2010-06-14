using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using ShomreiTorah.Singularity.Designer.Model;

namespace ShomreiTorah.Singularity.Designer {
	class ModelBindingSource : BindingSource {
		public ModelBindingSource() : base(new BindingList<SchemaModel>(), null) { }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new object DataSource {
			get { return base.DataSource; }
			set { base.DataSource = value; }
		}
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new string DataMember {
			get { return base.DataMember; }
			set { base.DataMember = value; }
		}
	}
}
