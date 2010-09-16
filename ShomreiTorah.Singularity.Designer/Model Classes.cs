using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ShomreiTorah.Singularity.Designer.Model;

namespace ShomreiTorah.Singularity.Designer {
	class ModelBindingSource : BindingSource {
		public ModelBindingSource() : base(new BindingList<SchemaModel>(), null) { }

		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Override for designer properties")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new object DataSource {
			get { return base.DataSource; }
			set { base.DataSource = value; }
		}
		[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "Override for designer properties")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public new string DataMember {
			get { return base.DataMember; }
			set { base.DataMember = value; }
		}
	}
}
