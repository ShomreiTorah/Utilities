using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
namespace ShomreiTorah {
	public partial class SSEmails : Row {
		public static TypedTable<SSEmails> CreateTable() { return new TypedTable<SSEmails>(Schema, () => new SSEmails()); }
		///<summary>Creates a new  SSEmails instance.</summary>
		public SSEmails() : base(Schema) { }

		///<summary>Gets the PledgeId column.</summary>
		public static ForeignKeyColumn PledgeIdColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the SSEmails schema.</summary>
		public static new TypedSchema<SSEmails> Schema { get { return schema; } }
		private static readonly TypedSchema<SSEmails> schema = TypedSchema<SSEmails>.Create("SSEmails", schema => {
			PledgeIdColumn = schema.Columns.AddForeignKey("PledgeId", Pledges.Schema, "Pledges");
			PledgeIdColumn.Unique = true;
			PledgeIdColumn.AllowNulls = false;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PledgeId {
			get { return base.Field<Row>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePledgeId(Row newValue, Action<string> error);
		partial void OnPledgeIdChanged(Row oldValue, Row newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PledgeIdColumn) {
				ValidatePledgeId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PledgeIdColumn)
				OnPledgeIdChanged((Row)oldValue, (Row)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class SSRequests : Row {
		public static TypedTable<SSRequests> CreateTable() { return new TypedTable<SSRequests>(Schema, () => new SSRequests()); }
		///<summary>Creates a new  SSRequests instance.</summary>
		public SSRequests() : base(Schema) { }

		///<summary>Gets the ID column.</summary>
		public static ValueColumn IDColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the FullName column.</summary>
		public static ValueColumn FullNameColumn { get; private set; }
		///<summary>Gets the Phone column.</summary>
		public static ValueColumn PhoneColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the Text column.</summary>
		public static ValueColumn TextColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the SSRequests schema.</summary>
		public static new TypedSchema<SSRequests> Schema { get { return schema; } }
		private static readonly TypedSchema<SSRequests> schema = TypedSchema<SSRequests>.Create("SSRequests", schema => {
			IDColumn = schema.Columns.AddValueColumn("ID", typeof(Int32), null);
			IDColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			FullNameColumn = schema.Columns.AddValueColumn("FullName", typeof(String), null);
			FullNameColumn.AllowNulls = false;

			PhoneColumn = schema.Columns.AddValueColumn("Phone", typeof(String), null);
			PhoneColumn.AllowNulls = false;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;

			TextColumn = schema.Columns.AddValueColumn("Text", typeof(String), null);
			TextColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 ID {
			get { return base.Field<Int32>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Text {
			get { return base.Field<String>(TextColumn); }
			set { base[TextColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateID(Int32 newValue, Action<string> error);
		partial void OnIDChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFullName(String newValue, Action<string> error);
		partial void OnFullNameChanged(String oldValue, String newValue);

		partial void ValidatePhone(String newValue, Action<string> error);
		partial void OnPhoneChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateText(String newValue, Action<string> error);
		partial void OnTextChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IDColumn) {
				ValidateID((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FullNameColumn) {
				ValidateFullName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PhoneColumn) {
				ValidatePhone((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TextColumn) {
				ValidateText((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IDColumn)
				OnIDChanged((Int32)oldValue, (Int32)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FullNameColumn)
				OnFullNameChanged((String)oldValue, (String)newValue);
			else if (column == PhoneColumn)
				OnPhoneChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == TextColumn)
				OnTextChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class MBList : Row {
		public static TypedTable<MBList> CreateTable() { return new TypedTable<MBList>(Schema, () => new MBList()); }
		///<summary>Creates a new  MBList instance.</summary>
		public MBList() : base(Schema) { }

		///<summary>Gets the ID column.</summary>
		public static ValueColumn IDColumn { get; private set; }
		///<summary>Gets the FullName column.</summary>
		public static ValueColumn FullNameColumn { get; private set; }
		///<summary>Gets the Phone column.</summary>
		public static ValueColumn PhoneColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the CholehName column.</summary>
		public static ValueColumn CholehNameColumn { get; private set; }
		///<summary>Gets the Until column.</summary>
		public static ValueColumn UntilColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the MBList schema.</summary>
		public static new TypedSchema<MBList> Schema { get { return schema; } }
		private static readonly TypedSchema<MBList> schema = TypedSchema<MBList>.Create("MBList", schema => {
			IDColumn = schema.Columns.AddValueColumn("ID", typeof(Int32), null);
			IDColumn.AllowNulls = false;

			FullNameColumn = schema.Columns.AddValueColumn("FullName", typeof(String), null);
			FullNameColumn.AllowNulls = false;

			PhoneColumn = schema.Columns.AddValueColumn("Phone", typeof(String), null);
			PhoneColumn.AllowNulls = false;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;

			CholehNameColumn = schema.Columns.AddValueColumn("CholehName", typeof(String), null);
			CholehNameColumn.AllowNulls = false;

			UntilColumn = schema.Columns.AddValueColumn("Until", typeof(DateTime), null);
			UntilColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 ID {
			get { return base.Field<Int32>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String CholehName {
			get { return base.Field<String>(CholehNameColumn); }
			set { base[CholehNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Until {
			get { return base.Field<DateTime>(UntilColumn); }
			set { base[UntilColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateID(Int32 newValue, Action<string> error);
		partial void OnIDChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateFullName(String newValue, Action<string> error);
		partial void OnFullNameChanged(String oldValue, String newValue);

		partial void ValidatePhone(String newValue, Action<string> error);
		partial void OnPhoneChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateCholehName(String newValue, Action<string> error);
		partial void OnCholehNameChanged(String oldValue, String newValue);

		partial void ValidateUntil(DateTime newValue, Action<string> error);
		partial void OnUntilChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IDColumn) {
				ValidateID((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FullNameColumn) {
				ValidateFullName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PhoneColumn) {
				ValidatePhone((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CholehNameColumn) {
				ValidateCholehName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UntilColumn) {
				ValidateUntil((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IDColumn)
				OnIDChanged((Int32)oldValue, (Int32)newValue);
			else if (column == FullNameColumn)
				OnFullNameChanged((String)oldValue, (String)newValue);
			else if (column == PhoneColumn)
				OnPhoneChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == CholehNameColumn)
				OnCholehNameChanged((String)oldValue, (String)newValue);
			else if (column == UntilColumn)
				OnUntilChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_WebPartState_Paths : Row {
		public static TypedTable<vw_aspnet_WebPartState_Paths> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_Paths>(Schema, () => new vw_aspnet_WebPartState_Paths()); }
		///<summary>Creates a new  vw_aspnet_WebPartState_Paths instance.</summary>
		public vw_aspnet_WebPartState_Paths() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the PathId column.</summary>
		public static ValueColumn PathIdColumn { get; private set; }
		///<summary>Gets the Path column.</summary>
		public static ValueColumn PathColumn { get; private set; }
		///<summary>Gets the LoweredPath column.</summary>
		public static ValueColumn LoweredPathColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_WebPartState_Paths schema.</summary>
		public static new TypedSchema<vw_aspnet_WebPartState_Paths> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_WebPartState_Paths> schema = TypedSchema<vw_aspnet_WebPartState_Paths>.Create("vw_aspnet_WebPartState_Paths", schema => {
			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = false;

			PathColumn = schema.Columns.AddValueColumn("Path", typeof(String), null);
			PathColumn.AllowNulls = false;

			LoweredPathColumn = schema.Columns.AddValueColumn("LoweredPath", typeof(String), null);
			LoweredPathColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Path {
			get { return base.Field<String>(PathColumn); }
			set { base[PathColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredPath {
			get { return base.Field<String>(LoweredPathColumn); }
			set { base[LoweredPathColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePathId(Guid newValue, Action<string> error);
		partial void OnPathIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePath(String newValue, Action<string> error);
		partial void OnPathChanged(String oldValue, String newValue);

		partial void ValidateLoweredPath(String newValue, Action<string> error);
		partial void OnLoweredPathChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PathIdColumn) {
				ValidatePathId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PathColumn) {
				ValidatePath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredPathColumn) {
				ValidateLoweredPath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PathIdColumn)
				OnPathIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PathColumn)
				OnPathChanged((String)oldValue, (String)newValue);
			else if (column == LoweredPathColumn)
				OnLoweredPathChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class ScheduleDates : Row {
		public static TypedTable<ScheduleDates> CreateTable() { return new TypedTable<ScheduleDates>(Schema, () => new ScheduleDates()); }
		///<summary>Creates a new  ScheduleDates instance.</summary>
		public ScheduleDates() : base(Schema) { }

		///<summary>Gets the ID column.</summary>
		public static ValueColumn IDColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the Title column.</summary>
		public static ValueColumn TitleColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the ScheduleDates schema.</summary>
		public static new TypedSchema<ScheduleDates> Schema { get { return schema; } }
		private static readonly TypedSchema<ScheduleDates> schema = TypedSchema<ScheduleDates>.Create("ScheduleDates", schema => {
			schema.PrimaryKey = IDColumn = schema.Columns.AddValueColumn("ID", typeof(Guid), null);
			IDColumn.Unique = true;
			IDColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			TitleColumn = schema.Columns.AddValueColumn("Title", typeof(String), null);
			TitleColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ID {
			get { return base.Field<Guid>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateID(Guid newValue, Action<string> error);
		partial void OnIDChanged(Guid oldValue, Guid newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateTitle(String newValue, Action<string> error);
		partial void OnTitleChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IDColumn) {
				ValidateID((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TitleColumn) {
				ValidateTitle((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IDColumn)
				OnIDChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == TitleColumn)
				OnTitleChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_WebPartState_Shared : Row {
		public static TypedTable<vw_aspnet_WebPartState_Shared> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_Shared>(Schema, () => new vw_aspnet_WebPartState_Shared()); }
		///<summary>Creates a new  vw_aspnet_WebPartState_Shared instance.</summary>
		public vw_aspnet_WebPartState_Shared() : base(Schema) { }

		///<summary>Gets the PathId column.</summary>
		public static ValueColumn PathIdColumn { get; private set; }
		///<summary>Gets the DataSize column.</summary>
		public static ValueColumn DataSizeColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_WebPartState_Shared schema.</summary>
		public static new TypedSchema<vw_aspnet_WebPartState_Shared> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_WebPartState_Shared> schema = TypedSchema<vw_aspnet_WebPartState_Shared>.Create("vw_aspnet_WebPartState_Shared", schema => {
			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = false;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePathId(Guid newValue, Action<string> error);
		partial void OnPathIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateDataSize(Int32? newValue, Action<string> error);
		partial void OnDataSizeChanged(Int32? oldValue, Int32? newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PathIdColumn) {
				ValidatePathId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DataSizeColumn) {
				ValidateDataSize((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PathIdColumn)
				OnPathIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DataSizeColumn)
				OnDataSizeChanged((Int32?)oldValue, (Int32?)newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_WebPartState_User : Row {
		public static TypedTable<vw_aspnet_WebPartState_User> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_User>(Schema, () => new vw_aspnet_WebPartState_User()); }
		///<summary>Creates a new  vw_aspnet_WebPartState_User instance.</summary>
		public vw_aspnet_WebPartState_User() : base(Schema) { }

		///<summary>Gets the PathId column.</summary>
		public static ValueColumn PathIdColumn { get; private set; }
		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the DataSize column.</summary>
		public static ValueColumn DataSizeColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_WebPartState_User schema.</summary>
		public static new TypedSchema<vw_aspnet_WebPartState_User> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_WebPartState_User> schema = TypedSchema<vw_aspnet_WebPartState_User>.Create("vw_aspnet_WebPartState_User", schema => {
			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = true;

			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = true;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid? PathId {
			get { return base.Field<Guid?>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid? UserId {
			get { return base.Field<Guid?>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePathId(Guid? newValue, Action<string> error);
		partial void OnPathIdChanged(Guid? oldValue, Guid? newValue);

		partial void ValidateUserId(Guid? newValue, Action<string> error);
		partial void OnUserIdChanged(Guid? oldValue, Guid? newValue);

		partial void ValidateDataSize(Int32? newValue, Action<string> error);
		partial void OnDataSizeChanged(Int32? oldValue, Int32? newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PathIdColumn) {
				ValidatePathId((Guid?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserIdColumn) {
				ValidateUserId((Guid?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DataSizeColumn) {
				ValidateDataSize((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PathIdColumn)
				OnPathIdChanged((Guid?)oldValue, (Guid?)newValue);
			else if (column == UserIdColumn)
				OnUserIdChanged((Guid?)oldValue, (Guid?)newValue);
			else if (column == DataSizeColumn)
				OnDataSizeChanged((Int32?)oldValue, (Int32?)newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_WebEvent_Events : Row {
		public static TypedTable<aspnet_WebEvent_Events> CreateTable() { return new TypedTable<aspnet_WebEvent_Events>(Schema, () => new aspnet_WebEvent_Events()); }
		///<summary>Creates a new  aspnet_WebEvent_Events instance.</summary>
		public aspnet_WebEvent_Events() : base(Schema) { }

		///<summary>Gets the EventId column.</summary>
		public static ValueColumn EventIdColumn { get; private set; }
		///<summary>Gets the EventTimeUtc column.</summary>
		public static ValueColumn EventTimeUtcColumn { get; private set; }
		///<summary>Gets the EventTime column.</summary>
		public static ValueColumn EventTimeColumn { get; private set; }
		///<summary>Gets the EventType column.</summary>
		public static ValueColumn EventTypeColumn { get; private set; }
		///<summary>Gets the EventSequence column.</summary>
		public static ValueColumn EventSequenceColumn { get; private set; }
		///<summary>Gets the EventOccurrence column.</summary>
		public static ValueColumn EventOccurrenceColumn { get; private set; }
		///<summary>Gets the EventCode column.</summary>
		public static ValueColumn EventCodeColumn { get; private set; }
		///<summary>Gets the EventDetailCode column.</summary>
		public static ValueColumn EventDetailCodeColumn { get; private set; }
		///<summary>Gets the Message column.</summary>
		public static ValueColumn MessageColumn { get; private set; }
		///<summary>Gets the ApplicationPath column.</summary>
		public static ValueColumn ApplicationPathColumn { get; private set; }
		///<summary>Gets the ApplicationVirtualPath column.</summary>
		public static ValueColumn ApplicationVirtualPathColumn { get; private set; }
		///<summary>Gets the MachineName column.</summary>
		public static ValueColumn MachineNameColumn { get; private set; }
		///<summary>Gets the RequestUrl column.</summary>
		public static ValueColumn RequestUrlColumn { get; private set; }
		///<summary>Gets the ExceptionType column.</summary>
		public static ValueColumn ExceptionTypeColumn { get; private set; }
		///<summary>Gets the Details column.</summary>
		public static ValueColumn DetailsColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_WebEvent_Events schema.</summary>
		public static new TypedSchema<aspnet_WebEvent_Events> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_WebEvent_Events> schema = TypedSchema<aspnet_WebEvent_Events>.Create("aspnet_WebEvent_Events", schema => {
			schema.PrimaryKey = EventIdColumn = schema.Columns.AddValueColumn("EventId", typeof(String), null);
			EventIdColumn.Unique = true;
			EventIdColumn.AllowNulls = false;

			EventTimeUtcColumn = schema.Columns.AddValueColumn("EventTimeUtc", typeof(DateTime), null);
			EventTimeUtcColumn.AllowNulls = false;

			EventTimeColumn = schema.Columns.AddValueColumn("EventTime", typeof(DateTime), null);
			EventTimeColumn.AllowNulls = false;

			EventTypeColumn = schema.Columns.AddValueColumn("EventType", typeof(String), null);
			EventTypeColumn.AllowNulls = false;

			EventSequenceColumn = schema.Columns.AddValueColumn("EventSequence", typeof(Decimal), null);
			EventSequenceColumn.AllowNulls = false;

			EventOccurrenceColumn = schema.Columns.AddValueColumn("EventOccurrence", typeof(Decimal), null);
			EventOccurrenceColumn.AllowNulls = false;

			EventCodeColumn = schema.Columns.AddValueColumn("EventCode", typeof(Int32), null);
			EventCodeColumn.AllowNulls = false;

			EventDetailCodeColumn = schema.Columns.AddValueColumn("EventDetailCode", typeof(Int32), null);
			EventDetailCodeColumn.AllowNulls = false;

			MessageColumn = schema.Columns.AddValueColumn("Message", typeof(String), null);
			MessageColumn.AllowNulls = true;

			ApplicationPathColumn = schema.Columns.AddValueColumn("ApplicationPath", typeof(String), null);
			ApplicationPathColumn.AllowNulls = true;

			ApplicationVirtualPathColumn = schema.Columns.AddValueColumn("ApplicationVirtualPath", typeof(String), null);
			ApplicationVirtualPathColumn.AllowNulls = true;

			MachineNameColumn = schema.Columns.AddValueColumn("MachineName", typeof(String), null);
			MachineNameColumn.AllowNulls = false;

			RequestUrlColumn = schema.Columns.AddValueColumn("RequestUrl", typeof(String), null);
			RequestUrlColumn.AllowNulls = true;

			ExceptionTypeColumn = schema.Columns.AddValueColumn("ExceptionType", typeof(String), null);
			ExceptionTypeColumn.AllowNulls = true;

			DetailsColumn = schema.Columns.AddValueColumn("Details", typeof(String), null);
			DetailsColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String EventId {
			get { return base.Field<String>(EventIdColumn); }
			set { base[EventIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime EventTimeUtc {
			get { return base.Field<DateTime>(EventTimeUtcColumn); }
			set { base[EventTimeUtcColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime EventTime {
			get { return base.Field<DateTime>(EventTimeColumn); }
			set { base[EventTimeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String EventType {
			get { return base.Field<String>(EventTypeColumn); }
			set { base[EventTypeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Decimal EventSequence {
			get { return base.Field<Decimal>(EventSequenceColumn); }
			set { base[EventSequenceColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Decimal EventOccurrence {
			get { return base.Field<Decimal>(EventOccurrenceColumn); }
			set { base[EventOccurrenceColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 EventCode {
			get { return base.Field<Int32>(EventCodeColumn); }
			set { base[EventCodeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 EventDetailCode {
			get { return base.Field<Int32>(EventDetailCodeColumn); }
			set { base[EventDetailCodeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Message {
			get { return base.Field<String>(MessageColumn); }
			set { base[MessageColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ApplicationPath {
			get { return base.Field<String>(ApplicationPathColumn); }
			set { base[ApplicationPathColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ApplicationVirtualPath {
			get { return base.Field<String>(ApplicationVirtualPathColumn); }
			set { base[ApplicationVirtualPathColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MachineName {
			get { return base.Field<String>(MachineNameColumn); }
			set { base[MachineNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String RequestUrl {
			get { return base.Field<String>(RequestUrlColumn); }
			set { base[RequestUrlColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ExceptionType {
			get { return base.Field<String>(ExceptionTypeColumn); }
			set { base[ExceptionTypeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Details {
			get { return base.Field<String>(DetailsColumn); }
			set { base[DetailsColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateEventId(String newValue, Action<string> error);
		partial void OnEventIdChanged(String oldValue, String newValue);

		partial void ValidateEventTimeUtc(DateTime newValue, Action<string> error);
		partial void OnEventTimeUtcChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateEventTime(DateTime newValue, Action<string> error);
		partial void OnEventTimeChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateEventType(String newValue, Action<string> error);
		partial void OnEventTypeChanged(String oldValue, String newValue);

		partial void ValidateEventSequence(Decimal newValue, Action<string> error);
		partial void OnEventSequenceChanged(Decimal oldValue, Decimal newValue);

		partial void ValidateEventOccurrence(Decimal newValue, Action<string> error);
		partial void OnEventOccurrenceChanged(Decimal oldValue, Decimal newValue);

		partial void ValidateEventCode(Int32 newValue, Action<string> error);
		partial void OnEventCodeChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateEventDetailCode(Int32 newValue, Action<string> error);
		partial void OnEventDetailCodeChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateMessage(String newValue, Action<string> error);
		partial void OnMessageChanged(String oldValue, String newValue);

		partial void ValidateApplicationPath(String newValue, Action<string> error);
		partial void OnApplicationPathChanged(String oldValue, String newValue);

		partial void ValidateApplicationVirtualPath(String newValue, Action<string> error);
		partial void OnApplicationVirtualPathChanged(String oldValue, String newValue);

		partial void ValidateMachineName(String newValue, Action<string> error);
		partial void OnMachineNameChanged(String oldValue, String newValue);

		partial void ValidateRequestUrl(String newValue, Action<string> error);
		partial void OnRequestUrlChanged(String oldValue, String newValue);

		partial void ValidateExceptionType(String newValue, Action<string> error);
		partial void OnExceptionTypeChanged(String oldValue, String newValue);

		partial void ValidateDetails(String newValue, Action<string> error);
		partial void OnDetailsChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == EventIdColumn) {
				ValidateEventId((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventTimeUtcColumn) {
				ValidateEventTimeUtc((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventTimeColumn) {
				ValidateEventTime((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventTypeColumn) {
				ValidateEventType((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventSequenceColumn) {
				ValidateEventSequence((Decimal)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventOccurrenceColumn) {
				ValidateEventOccurrence((Decimal)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventCodeColumn) {
				ValidateEventCode((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EventDetailCodeColumn) {
				ValidateEventDetailCode((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MessageColumn) {
				ValidateMessage((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ApplicationPathColumn) {
				ValidateApplicationPath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ApplicationVirtualPathColumn) {
				ValidateApplicationVirtualPath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MachineNameColumn) {
				ValidateMachineName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RequestUrlColumn) {
				ValidateRequestUrl((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ExceptionTypeColumn) {
				ValidateExceptionType((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DetailsColumn) {
				ValidateDetails((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == EventIdColumn)
				OnEventIdChanged((String)oldValue, (String)newValue);
			else if (column == EventTimeUtcColumn)
				OnEventTimeUtcChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == EventTimeColumn)
				OnEventTimeChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == EventTypeColumn)
				OnEventTypeChanged((String)oldValue, (String)newValue);
			else if (column == EventSequenceColumn)
				OnEventSequenceChanged((Decimal)oldValue, (Decimal)newValue);
			else if (column == EventOccurrenceColumn)
				OnEventOccurrenceChanged((Decimal)oldValue, (Decimal)newValue);
			else if (column == EventCodeColumn)
				OnEventCodeChanged((Int32)oldValue, (Int32)newValue);
			else if (column == EventDetailCodeColumn)
				OnEventDetailCodeChanged((Int32)oldValue, (Int32)newValue);
			else if (column == MessageColumn)
				OnMessageChanged((String)oldValue, (String)newValue);
			else if (column == ApplicationPathColumn)
				OnApplicationPathChanged((String)oldValue, (String)newValue);
			else if (column == ApplicationVirtualPathColumn)
				OnApplicationVirtualPathChanged((String)oldValue, (String)newValue);
			else if (column == MachineNameColumn)
				OnMachineNameChanged((String)oldValue, (String)newValue);
			else if (column == RequestUrlColumn)
				OnRequestUrlChanged((String)oldValue, (String)newValue);
			else if (column == ExceptionTypeColumn)
				OnExceptionTypeChanged((String)oldValue, (String)newValue);
			else if (column == DetailsColumn)
				OnDetailsChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class ScheduleTimes : Row {
		public static TypedTable<ScheduleTimes> CreateTable() { return new TypedTable<ScheduleTimes>(Schema, () => new ScheduleTimes()); }
		///<summary>Creates a new  ScheduleTimes instance.</summary>
		public ScheduleTimes() : base(Schema) { }

		///<summary>Gets the ID column.</summary>
		public static ValueColumn IDColumn { get; private set; }
		///<summary>Gets the CellID column.</summary>
		public static ForeignKeyColumn CellIDColumn { get; private set; }
		///<summary>Gets the Name column.</summary>
		public static ValueColumn NameColumn { get; private set; }
		///<summary>Gets the Time column.</summary>
		public static ValueColumn TimeColumn { get; private set; }
		///<summary>Gets the IsBold column.</summary>
		public static ValueColumn IsBoldColumn { get; private set; }
		///<summary>Gets the LastModified column.</summary>
		public static ValueColumn LastModifiedColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the ScheduleTimes schema.</summary>
		public static new TypedSchema<ScheduleTimes> Schema { get { return schema; } }
		private static readonly TypedSchema<ScheduleTimes> schema = TypedSchema<ScheduleTimes>.Create("ScheduleTimes", schema => {
			schema.PrimaryKey = IDColumn = schema.Columns.AddValueColumn("ID", typeof(Guid), null);
			IDColumn.Unique = true;
			IDColumn.AllowNulls = false;

			CellIDColumn = schema.Columns.AddForeignKey("CellID", ScheduleDates.Schema, "ScheduleDates");
			CellIDColumn.AllowNulls = false;

			NameColumn = schema.Columns.AddValueColumn("Name", typeof(String), null);
			NameColumn.Unique = true;
			NameColumn.AllowNulls = false;

			TimeColumn = schema.Columns.AddValueColumn("Time", typeof(DateTime), null);
			TimeColumn.AllowNulls = false;

			IsBoldColumn = schema.Columns.AddValueColumn("IsBold", typeof(Boolean), null);
			IsBoldColumn.AllowNulls = false;

			LastModifiedColumn = schema.Columns.AddValueColumn("LastModified", typeof(DateTime), null);
			LastModifiedColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ID {
			get { return base.Field<Guid>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row CellID {
			get { return base.Field<Row>(CellIDColumn); }
			set { base[CellIDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Name {
			get { return base.Field<String>(NameColumn); }
			set { base[NameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Time {
			get { return base.Field<DateTime>(TimeColumn); }
			set { base[TimeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsBold {
			get { return base.Field<Boolean>(IsBoldColumn); }
			set { base[IsBoldColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastModified {
			get { return base.Field<DateTime>(LastModifiedColumn); }
			set { base[LastModifiedColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateID(Guid newValue, Action<string> error);
		partial void OnIDChanged(Guid oldValue, Guid newValue);

		partial void ValidateCellID(Row newValue, Action<string> error);
		partial void OnCellIDChanged(Row oldValue, Row newValue);

		partial void ValidateName(String newValue, Action<string> error);
		partial void OnNameChanged(String oldValue, String newValue);

		partial void ValidateTime(DateTime newValue, Action<string> error);
		partial void OnTimeChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateIsBold(Boolean newValue, Action<string> error);
		partial void OnIsBoldChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateLastModified(DateTime newValue, Action<string> error);
		partial void OnLastModifiedChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IDColumn) {
				ValidateID((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CellIDColumn) {
				ValidateCellID((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == NameColumn) {
				ValidateName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TimeColumn) {
				ValidateTime((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsBoldColumn) {
				ValidateIsBold((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastModifiedColumn) {
				ValidateLastModified((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IDColumn)
				OnIDChanged((Guid)oldValue, (Guid)newValue);
			else if (column == CellIDColumn)
				OnCellIDChanged((Row)oldValue, (Row)newValue);
			else if (column == NameColumn)
				OnNameChanged((String)oldValue, (String)newValue);
			else if (column == TimeColumn)
				OnTimeChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == IsBoldColumn)
				OnIsBoldChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == LastModifiedColumn)
				OnLastModifiedChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class Deposits : Row {
		public static TypedTable<Deposits> CreateTable() { return new TypedTable<Deposits>(Schema, () => new Deposits()); }
		///<summary>Creates a new  Deposits instance.</summary>
		public Deposits() : base(Schema) { }

		///<summary>Gets the DepositId column.</summary>
		public static ValueColumn DepositIdColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the Number column.</summary>
		public static ValueColumn NumberColumn { get; private set; }
		///<summary>Gets the Account column.</summary>
		public static ValueColumn AccountColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the Deposits schema.</summary>
		public static new TypedSchema<Deposits> Schema { get { return schema; } }
		private static readonly TypedSchema<Deposits> schema = TypedSchema<Deposits>.Create("Deposits", schema => {
			schema.PrimaryKey = DepositIdColumn = schema.Columns.AddValueColumn("DepositId", typeof(Guid), null);
			DepositIdColumn.Unique = true;
			DepositIdColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			NumberColumn = schema.Columns.AddValueColumn("Number", typeof(Int32), null);
			NumberColumn.Unique = true;
			NumberColumn.AllowNulls = false;

			AccountColumn = schema.Columns.AddValueColumn("Account", typeof(String), null);
			AccountColumn.Unique = true;
			AccountColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid DepositId {
			get { return base.Field<Guid>(DepositIdColumn); }
			set { base[DepositIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 Number {
			get { return base.Field<Int32>(NumberColumn); }
			set { base[NumberColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateDepositId(Guid newValue, Action<string> error);
		partial void OnDepositIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateNumber(Int32 newValue, Action<string> error);
		partial void OnNumberChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateAccount(String newValue, Action<string> error);
		partial void OnAccountChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == DepositIdColumn) {
				ValidateDepositId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == NumberColumn) {
				ValidateNumber((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AccountColumn) {
				ValidateAccount((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == DepositIdColumn)
				OnDepositIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == NumberColumn)
				OnNumberChanged((Int32)oldValue, (Int32)newValue);
			else if (column == AccountColumn)
				OnAccountChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class tblMLMembers : Row {
		public static TypedTable<tblMLMembers> CreateTable() { return new TypedTable<tblMLMembers>(Schema, () => new tblMLMembers()); }
		///<summary>Creates a new  tblMLMembers instance.</summary>
		public tblMLMembers() : base(Schema) { }

		///<summary>Gets the Mail_ID column.</summary>
		public static ValueColumn Mail_IDColumn { get; private set; }
		///<summary>Gets the Name column.</summary>
		public static ValueColumn NameColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the ID_Code column.</summary>
		public static ValueColumn ID_CodeColumn { get; private set; }
		///<summary>Gets the Password column.</summary>
		public static ValueColumn PasswordColumn { get; private set; }
		///<summary>Gets the Salt column.</summary>
		public static ValueColumn SaltColumn { get; private set; }
		///<summary>Gets the Active column.</summary>
		public static ValueColumn ActiveColumn { get; private set; }
		///<summary>Gets the Join_Date column.</summary>
		public static ValueColumn Join_DateColumn { get; private set; }
		///<summary>Gets the HTMLformat column.</summary>
		public static ValueColumn HTMLformatColumn { get; private set; }
		///<summary>Gets the PersonId column.</summary>
		public static ForeignKeyColumn PersonIdColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the tblMLMembers schema.</summary>
		public static new TypedSchema<tblMLMembers> Schema { get { return schema; } }
		private static readonly TypedSchema<tblMLMembers> schema = TypedSchema<tblMLMembers>.Create("tblMLMembers", schema => {
			schema.PrimaryKey = Mail_IDColumn = schema.Columns.AddValueColumn("Mail_ID", typeof(Int32), null);
			Mail_IDColumn.Unique = true;
			Mail_IDColumn.AllowNulls = false;

			NameColumn = schema.Columns.AddValueColumn("Name", typeof(String), null);
			NameColumn.Unique = true;
			NameColumn.AllowNulls = true;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;

			ID_CodeColumn = schema.Columns.AddValueColumn("ID_Code", typeof(String), null);
			ID_CodeColumn.AllowNulls = true;

			PasswordColumn = schema.Columns.AddValueColumn("Password", typeof(String), null);
			PasswordColumn.AllowNulls = true;

			SaltColumn = schema.Columns.AddValueColumn("Salt", typeof(String), null);
			SaltColumn.AllowNulls = true;

			ActiveColumn = schema.Columns.AddValueColumn("Active", typeof(Boolean), null);
			ActiveColumn.AllowNulls = false;

			Join_DateColumn = schema.Columns.AddValueColumn("Join_Date", typeof(DateTime), null);
			Join_DateColumn.AllowNulls = false;

			HTMLformatColumn = schema.Columns.AddValueColumn("HTMLformat", typeof(Boolean), null);
			HTMLformatColumn.AllowNulls = false;

			PersonIdColumn = schema.Columns.AddForeignKey("PersonId", MasterDirectory.Schema, "MasterDirectory");
			PersonIdColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 Mail_ID {
			get { return base.Field<Int32>(Mail_IDColumn); }
			set { base[Mail_IDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Name {
			get { return base.Field<String>(NameColumn); }
			set { base[NameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ID_Code {
			get { return base.Field<String>(ID_CodeColumn); }
			set { base[ID_CodeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Password {
			get { return base.Field<String>(PasswordColumn); }
			set { base[PasswordColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Salt {
			get { return base.Field<String>(SaltColumn); }
			set { base[SaltColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean Active {
			get { return base.Field<Boolean>(ActiveColumn); }
			set { base[ActiveColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Join_Date {
			get { return base.Field<DateTime>(Join_DateColumn); }
			set { base[Join_DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean HTMLformat {
			get { return base.Field<Boolean>(HTMLformatColumn); }
			set { base[HTMLformatColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateMail_ID(Int32 newValue, Action<string> error);
		partial void OnMail_IDChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateName(String newValue, Action<string> error);
		partial void OnNameChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateID_Code(String newValue, Action<string> error);
		partial void OnID_CodeChanged(String oldValue, String newValue);

		partial void ValidatePassword(String newValue, Action<string> error);
		partial void OnPasswordChanged(String oldValue, String newValue);

		partial void ValidateSalt(String newValue, Action<string> error);
		partial void OnSaltChanged(String oldValue, String newValue);

		partial void ValidateActive(Boolean newValue, Action<string> error);
		partial void OnActiveChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateJoin_Date(DateTime newValue, Action<string> error);
		partial void OnJoin_DateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateHTMLformat(Boolean newValue, Action<string> error);
		partial void OnHTMLformatChanged(Boolean oldValue, Boolean newValue);

		partial void ValidatePersonId(Row newValue, Action<string> error);
		partial void OnPersonIdChanged(Row oldValue, Row newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == Mail_IDColumn) {
				ValidateMail_ID((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == NameColumn) {
				ValidateName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ID_CodeColumn) {
				ValidateID_Code((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordColumn) {
				ValidatePassword((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == SaltColumn) {
				ValidateSalt((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ActiveColumn) {
				ValidateActive((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == Join_DateColumn) {
				ValidateJoin_Date((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == HTMLformatColumn) {
				ValidateHTMLformat((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PersonIdColumn) {
				ValidatePersonId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == Mail_IDColumn)
				OnMail_IDChanged((Int32)oldValue, (Int32)newValue);
			else if (column == NameColumn)
				OnNameChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == ID_CodeColumn)
				OnID_CodeChanged((String)oldValue, (String)newValue);
			else if (column == PasswordColumn)
				OnPasswordChanged((String)oldValue, (String)newValue);
			else if (column == SaltColumn)
				OnSaltChanged((String)oldValue, (String)newValue);
			else if (column == ActiveColumn)
				OnActiveChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == Join_DateColumn)
				OnJoin_DateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == HTMLformatColumn)
				OnHTMLformatChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == PersonIdColumn)
				OnPersonIdChanged((Row)oldValue, (Row)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class StatementLog : Row {
		public static TypedTable<StatementLog> CreateTable() { return new TypedTable<StatementLog>(Schema, () => new StatementLog()); }
		///<summary>Creates a new  StatementLog instance.</summary>
		public StatementLog() : base(Schema) { }

		///<summary>Gets the Id column.</summary>
		public static ValueColumn IdColumn { get; private set; }
		///<summary>Gets the PersonId column.</summary>
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		///<summary>Gets the DateGenerated column.</summary>
		public static ValueColumn DateGeneratedColumn { get; private set; }
		///<summary>Gets the Media column.</summary>
		public static ValueColumn MediaColumn { get; private set; }
		///<summary>Gets the StatementKind column.</summary>
		public static ValueColumn StatementKindColumn { get; private set; }
		///<summary>Gets the StartDate column.</summary>
		public static ValueColumn StartDateColumn { get; private set; }
		///<summary>Gets the EndDate column.</summary>
		public static ValueColumn EndDateColumn { get; private set; }
		///<summary>Gets the UserName column.</summary>
		public static ValueColumn UserNameColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the StatementLog schema.</summary>
		public static new TypedSchema<StatementLog> Schema { get { return schema; } }
		private static readonly TypedSchema<StatementLog> schema = TypedSchema<StatementLog>.Create("StatementLog", schema => {
			schema.PrimaryKey = IdColumn = schema.Columns.AddValueColumn("Id", typeof(Guid), null);
			IdColumn.Unique = true;
			IdColumn.AllowNulls = false;

			PersonIdColumn = schema.Columns.AddForeignKey("PersonId", MasterDirectory.Schema, "MasterDirectory");
			PersonIdColumn.AllowNulls = false;

			DateGeneratedColumn = schema.Columns.AddValueColumn("DateGenerated", typeof(DateTime), null);
			DateGeneratedColumn.AllowNulls = false;

			MediaColumn = schema.Columns.AddValueColumn("Media", typeof(String), null);
			MediaColumn.AllowNulls = false;

			StatementKindColumn = schema.Columns.AddValueColumn("StatementKind", typeof(String), null);
			StatementKindColumn.AllowNulls = false;

			StartDateColumn = schema.Columns.AddValueColumn("StartDate", typeof(DateTime), null);
			StartDateColumn.AllowNulls = false;

			EndDateColumn = schema.Columns.AddValueColumn("EndDate", typeof(DateTime), null);
			EndDateColumn.AllowNulls = false;

			UserNameColumn = schema.Columns.AddValueColumn("UserName", typeof(String), null);
			UserNameColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime DateGenerated {
			get { return base.Field<DateTime>(DateGeneratedColumn); }
			set { base[DateGeneratedColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Media {
			get { return base.Field<String>(MediaColumn); }
			set { base[MediaColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String StatementKind {
			get { return base.Field<String>(StatementKindColumn); }
			set { base[StatementKindColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime StartDate {
			get { return base.Field<DateTime>(StartDateColumn); }
			set { base[StartDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime EndDate {
			get { return base.Field<DateTime>(EndDateColumn); }
			set { base[EndDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateId(Guid newValue, Action<string> error);
		partial void OnIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePersonId(Row newValue, Action<string> error);
		partial void OnPersonIdChanged(Row oldValue, Row newValue);

		partial void ValidateDateGenerated(DateTime newValue, Action<string> error);
		partial void OnDateGeneratedChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateMedia(String newValue, Action<string> error);
		partial void OnMediaChanged(String oldValue, String newValue);

		partial void ValidateStatementKind(String newValue, Action<string> error);
		partial void OnStatementKindChanged(String oldValue, String newValue);

		partial void ValidateStartDate(DateTime newValue, Action<string> error);
		partial void OnStartDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateEndDate(DateTime newValue, Action<string> error);
		partial void OnEndDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateUserName(String newValue, Action<string> error);
		partial void OnUserNameChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IdColumn) {
				ValidateId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PersonIdColumn) {
				ValidatePersonId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateGeneratedColumn) {
				ValidateDateGenerated((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MediaColumn) {
				ValidateMedia((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == StatementKindColumn) {
				ValidateStatementKind((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == StartDateColumn) {
				ValidateStartDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EndDateColumn) {
				ValidateEndDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserNameColumn) {
				ValidateUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IdColumn)
				OnIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PersonIdColumn)
				OnPersonIdChanged((Row)oldValue, (Row)newValue);
			else if (column == DateGeneratedColumn)
				OnDateGeneratedChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == MediaColumn)
				OnMediaChanged((String)oldValue, (String)newValue);
			else if (column == StatementKindColumn)
				OnStatementKindChanged((String)oldValue, (String)newValue);
			else if (column == StartDateColumn)
				OnStartDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == EndDateColumn)
				OnEndDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == UserNameColumn)
				OnUserNameChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class MasterDirectory : Row {
		public static TypedTable<MasterDirectory> CreateTable() { return new TypedTable<MasterDirectory>(Schema, () => new MasterDirectory()); }
		///<summary>Creates a new  MasterDirectory instance.</summary>
		public MasterDirectory() : base(Schema) { }

		///<summary>Gets the Id column.</summary>
		public static ValueColumn IdColumn { get; private set; }
		///<summary>Gets the YKID column.</summary>
		public static ValueColumn YKIDColumn { get; private set; }
		///<summary>Gets the LastName column.</summary>
		public static ValueColumn LastNameColumn { get; private set; }
		///<summary>Gets the HisName column.</summary>
		public static ValueColumn HisNameColumn { get; private set; }
		///<summary>Gets the HerName column.</summary>
		public static ValueColumn HerNameColumn { get; private set; }
		///<summary>Gets the FullName column.</summary>
		public static ValueColumn FullNameColumn { get; private set; }
		///<summary>Gets the Address column.</summary>
		public static ValueColumn AddressColumn { get; private set; }
		///<summary>Gets the City column.</summary>
		public static ValueColumn CityColumn { get; private set; }
		///<summary>Gets the State column.</summary>
		public static ValueColumn StateColumn { get; private set; }
		///<summary>Gets the Zip column.</summary>
		public static ValueColumn ZipColumn { get; private set; }
		///<summary>Gets the Phone column.</summary>
		public static ValueColumn PhoneColumn { get; private set; }
		///<summary>Gets the Source column.</summary>
		public static ValueColumn SourceColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the MasterDirectory schema.</summary>
		public static new TypedSchema<MasterDirectory> Schema { get { return schema; } }
		private static readonly TypedSchema<MasterDirectory> schema = TypedSchema<MasterDirectory>.Create("MasterDirectory", schema => {
			schema.PrimaryKey = IdColumn = schema.Columns.AddValueColumn("Id", typeof(Guid), null);
			IdColumn.Unique = true;
			IdColumn.AllowNulls = false;

			YKIDColumn = schema.Columns.AddValueColumn("YKID", typeof(Int32), null);
			YKIDColumn.AllowNulls = true;

			LastNameColumn = schema.Columns.AddValueColumn("LastName", typeof(String), null);
			LastNameColumn.AllowNulls = false;

			HisNameColumn = schema.Columns.AddValueColumn("HisName", typeof(String), null);
			HisNameColumn.AllowNulls = true;

			HerNameColumn = schema.Columns.AddValueColumn("HerName", typeof(String), null);
			HerNameColumn.AllowNulls = true;

			FullNameColumn = schema.Columns.AddValueColumn("FullName", typeof(String), null);
			FullNameColumn.AllowNulls = true;

			AddressColumn = schema.Columns.AddValueColumn("Address", typeof(String), null);
			AddressColumn.AllowNulls = true;

			CityColumn = schema.Columns.AddValueColumn("City", typeof(String), null);
			CityColumn.AllowNulls = true;

			StateColumn = schema.Columns.AddValueColumn("State", typeof(String), null);
			StateColumn.AllowNulls = true;

			ZipColumn = schema.Columns.AddValueColumn("Zip", typeof(String), null);
			ZipColumn.AllowNulls = true;

			PhoneColumn = schema.Columns.AddValueColumn("Phone", typeof(String), null);
			PhoneColumn.AllowNulls = false;

			SourceColumn = schema.Columns.AddValueColumn("Source", typeof(String), null);
			SourceColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? YKID {
			get { return base.Field<Int32?>(YKIDColumn); }
			set { base[YKIDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LastName {
			get { return base.Field<String>(LastNameColumn); }
			set { base[LastNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String HisName {
			get { return base.Field<String>(HisNameColumn); }
			set { base[HisNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String HerName {
			get { return base.Field<String>(HerNameColumn); }
			set { base[HerNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Address {
			get { return base.Field<String>(AddressColumn); }
			set { base[AddressColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String City {
			get { return base.Field<String>(CityColumn); }
			set { base[CityColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String State {
			get { return base.Field<String>(StateColumn); }
			set { base[StateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Zip {
			get { return base.Field<String>(ZipColumn); }
			set { base[ZipColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Source {
			get { return base.Field<String>(SourceColumn); }
			set { base[SourceColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateId(Guid newValue, Action<string> error);
		partial void OnIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateYKID(Int32? newValue, Action<string> error);
		partial void OnYKIDChanged(Int32? oldValue, Int32? newValue);

		partial void ValidateLastName(String newValue, Action<string> error);
		partial void OnLastNameChanged(String oldValue, String newValue);

		partial void ValidateHisName(String newValue, Action<string> error);
		partial void OnHisNameChanged(String oldValue, String newValue);

		partial void ValidateHerName(String newValue, Action<string> error);
		partial void OnHerNameChanged(String oldValue, String newValue);

		partial void ValidateFullName(String newValue, Action<string> error);
		partial void OnFullNameChanged(String oldValue, String newValue);

		partial void ValidateAddress(String newValue, Action<string> error);
		partial void OnAddressChanged(String oldValue, String newValue);

		partial void ValidateCity(String newValue, Action<string> error);
		partial void OnCityChanged(String oldValue, String newValue);

		partial void ValidateState(String newValue, Action<string> error);
		partial void OnStateChanged(String oldValue, String newValue);

		partial void ValidateZip(String newValue, Action<string> error);
		partial void OnZipChanged(String oldValue, String newValue);

		partial void ValidatePhone(String newValue, Action<string> error);
		partial void OnPhoneChanged(String oldValue, String newValue);

		partial void ValidateSource(String newValue, Action<string> error);
		partial void OnSourceChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IdColumn) {
				ValidateId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == YKIDColumn) {
				ValidateYKID((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastNameColumn) {
				ValidateLastName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == HisNameColumn) {
				ValidateHisName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == HerNameColumn) {
				ValidateHerName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FullNameColumn) {
				ValidateFullName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AddressColumn) {
				ValidateAddress((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CityColumn) {
				ValidateCity((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == StateColumn) {
				ValidateState((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ZipColumn) {
				ValidateZip((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PhoneColumn) {
				ValidatePhone((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == SourceColumn) {
				ValidateSource((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IdColumn)
				OnIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == YKIDColumn)
				OnYKIDChanged((Int32?)oldValue, (Int32?)newValue);
			else if (column == LastNameColumn)
				OnLastNameChanged((String)oldValue, (String)newValue);
			else if (column == HisNameColumn)
				OnHisNameChanged((String)oldValue, (String)newValue);
			else if (column == HerNameColumn)
				OnHerNameChanged((String)oldValue, (String)newValue);
			else if (column == FullNameColumn)
				OnFullNameChanged((String)oldValue, (String)newValue);
			else if (column == AddressColumn)
				OnAddressChanged((String)oldValue, (String)newValue);
			else if (column == CityColumn)
				OnCityChanged((String)oldValue, (String)newValue);
			else if (column == StateColumn)
				OnStateChanged((String)oldValue, (String)newValue);
			else if (column == ZipColumn)
				OnZipChanged((String)oldValue, (String)newValue);
			else if (column == PhoneColumn)
				OnPhoneChanged((String)oldValue, (String)newValue);
			else if (column == SourceColumn)
				OnSourceChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Applications : Row {
		public static TypedTable<aspnet_Applications> CreateTable() { return new TypedTable<aspnet_Applications>(Schema, () => new aspnet_Applications()); }
		///<summary>Creates a new  aspnet_Applications instance.</summary>
		public aspnet_Applications() : base(Schema) { }

		///<summary>Gets the ApplicationName column.</summary>
		public static ValueColumn ApplicationNameColumn { get; private set; }
		///<summary>Gets the LoweredApplicationName column.</summary>
		public static ValueColumn LoweredApplicationNameColumn { get; private set; }
		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the Description column.</summary>
		public static ValueColumn DescriptionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Applications schema.</summary>
		public static new TypedSchema<aspnet_Applications> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Applications> schema = TypedSchema<aspnet_Applications>.Create("aspnet_Applications", schema => {
			ApplicationNameColumn = schema.Columns.AddValueColumn("ApplicationName", typeof(String), null);
			ApplicationNameColumn.Unique = true;
			ApplicationNameColumn.AllowNulls = false;

			LoweredApplicationNameColumn = schema.Columns.AddValueColumn("LoweredApplicationName", typeof(String), null);
			LoweredApplicationNameColumn.Unique = true;
			LoweredApplicationNameColumn.AllowNulls = false;

			schema.PrimaryKey = ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.Unique = true;
			ApplicationIdColumn.AllowNulls = false;

			DescriptionColumn = schema.Columns.AddValueColumn("Description", typeof(String), null);
			DescriptionColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ApplicationName {
			get { return base.Field<String>(ApplicationNameColumn); }
			set { base[ApplicationNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredApplicationName {
			get { return base.Field<String>(LoweredApplicationNameColumn); }
			set { base[LoweredApplicationNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationName(String newValue, Action<string> error);
		partial void OnApplicationNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredApplicationName(String newValue, Action<string> error);
		partial void OnLoweredApplicationNameChanged(String oldValue, String newValue);

		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateDescription(String newValue, Action<string> error);
		partial void OnDescriptionChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationNameColumn) {
				ValidateApplicationName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredApplicationNameColumn) {
				ValidateLoweredApplicationName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DescriptionColumn) {
				ValidateDescription((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationNameColumn)
				OnApplicationNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredApplicationNameColumn)
				OnLoweredApplicationNameChanged((String)oldValue, (String)newValue);
			else if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DescriptionColumn)
				OnDescriptionChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class Pages : Row {
		public static TypedTable<Pages> CreateTable() { return new TypedTable<Pages>(Schema, () => new Pages()); }
		///<summary>Creates a new  Pages instance.</summary>
		public Pages() : base(Schema) { }

		///<summary>Gets the Id column.</summary>
		public static ValueColumn IdColumn { get; private set; }
		///<summary>Gets the PageName column.</summary>
		public static ValueColumn PageNameColumn { get; private set; }
		///<summary>Gets the Title column.</summary>
		public static ValueColumn TitleColumn { get; private set; }
		///<summary>Gets the Content column.</summary>
		public static ValueColumn ContentColumn { get; private set; }
		///<summary>Gets the DateModified column.</summary>
		public static ValueColumn DateModifiedColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the Pages schema.</summary>
		public static new TypedSchema<Pages> Schema { get { return schema; } }
		private static readonly TypedSchema<Pages> schema = TypedSchema<Pages>.Create("Pages", schema => {
			schema.PrimaryKey = IdColumn = schema.Columns.AddValueColumn("Id", typeof(Guid), null);
			IdColumn.Unique = true;
			IdColumn.AllowNulls = false;

			PageNameColumn = schema.Columns.AddValueColumn("PageName", typeof(String), null);
			PageNameColumn.Unique = true;
			PageNameColumn.AllowNulls = false;

			TitleColumn = schema.Columns.AddValueColumn("Title", typeof(String), null);
			TitleColumn.AllowNulls = false;

			ContentColumn = schema.Columns.AddValueColumn("Content", typeof(String), null);
			ContentColumn.AllowNulls = false;

			DateModifiedColumn = schema.Columns.AddValueColumn("DateModified", typeof(DateTime), null);
			DateModifiedColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PageName {
			get { return base.Field<String>(PageNameColumn); }
			set { base[PageNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Content {
			get { return base.Field<String>(ContentColumn); }
			set { base[ContentColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime DateModified {
			get { return base.Field<DateTime>(DateModifiedColumn); }
			set { base[DateModifiedColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateId(Guid newValue, Action<string> error);
		partial void OnIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePageName(String newValue, Action<string> error);
		partial void OnPageNameChanged(String oldValue, String newValue);

		partial void ValidateTitle(String newValue, Action<string> error);
		partial void OnTitleChanged(String oldValue, String newValue);

		partial void ValidateContent(String newValue, Action<string> error);
		partial void OnContentChanged(String oldValue, String newValue);

		partial void ValidateDateModified(DateTime newValue, Action<string> error);
		partial void OnDateModifiedChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IdColumn) {
				ValidateId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PageNameColumn) {
				ValidatePageName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TitleColumn) {
				ValidateTitle((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ContentColumn) {
				ValidateContent((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateModifiedColumn) {
				ValidateDateModified((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IdColumn)
				OnIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PageNameColumn)
				OnPageNameChanged((String)oldValue, (String)newValue);
			else if (column == TitleColumn)
				OnTitleChanged((String)oldValue, (String)newValue);
			else if (column == ContentColumn)
				OnContentChanged((String)oldValue, (String)newValue);
			else if (column == DateModifiedColumn)
				OnDateModifiedChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class sysdiagrams : Row {
		public static TypedTable<sysdiagrams> CreateTable() { return new TypedTable<sysdiagrams>(Schema, () => new sysdiagrams()); }
		///<summary>Creates a new  sysdiagrams instance.</summary>
		public sysdiagrams() : base(Schema) { }

		///<summary>Gets the name column.</summary>
		public static ValueColumn nameColumn { get; private set; }
		///<summary>Gets the principal_id column.</summary>
		public static ValueColumn principal_idColumn { get; private set; }
		///<summary>Gets the diagram_id column.</summary>
		public static ValueColumn diagram_idColumn { get; private set; }
		///<summary>Gets the version column.</summary>
		public static ValueColumn versionColumn { get; private set; }
		///<summary>Gets the definition column.</summary>
		public static ValueColumn definitionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the sysdiagrams schema.</summary>
		public static new TypedSchema<sysdiagrams> Schema { get { return schema; } }
		private static readonly TypedSchema<sysdiagrams> schema = TypedSchema<sysdiagrams>.Create("sysdiagrams", schema => {
			nameColumn = schema.Columns.AddValueColumn("name", typeof(String), null);
			nameColumn.Unique = true;
			nameColumn.AllowNulls = false;

			principal_idColumn = schema.Columns.AddValueColumn("principal_id", typeof(Int32), null);
			principal_idColumn.Unique = true;
			principal_idColumn.AllowNulls = false;

			schema.PrimaryKey = diagram_idColumn = schema.Columns.AddValueColumn("diagram_id", typeof(Int32), null);
			diagram_idColumn.Unique = true;
			diagram_idColumn.AllowNulls = false;

			versionColumn = schema.Columns.AddValueColumn("version", typeof(Int32), null);
			versionColumn.AllowNulls = true;

			definitionColumn = schema.Columns.AddValueColumn("definition", typeof(Byte[]), null);
			definitionColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String name {
			get { return base.Field<String>(nameColumn); }
			set { base[nameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 principal_id {
			get { return base.Field<Int32>(principal_idColumn); }
			set { base[principal_idColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 diagram_id {
			get { return base.Field<Int32>(diagram_idColumn); }
			set { base[diagram_idColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? version {
			get { return base.Field<Int32?>(versionColumn); }
			set { base[versionColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Byte[] definition {
			get { return base.Field<Byte[]>(definitionColumn); }
			set { base[definitionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void Validatename(String newValue, Action<string> error);
		partial void OnnameChanged(String oldValue, String newValue);

		partial void Validateprincipal_id(Int32 newValue, Action<string> error);
		partial void Onprincipal_idChanged(Int32 oldValue, Int32 newValue);

		partial void Validatediagram_id(Int32 newValue, Action<string> error);
		partial void Ondiagram_idChanged(Int32 oldValue, Int32 newValue);

		partial void Validateversion(Int32? newValue, Action<string> error);
		partial void OnversionChanged(Int32? oldValue, Int32? newValue);

		partial void Validatedefinition(Byte[] newValue, Action<string> error);
		partial void OndefinitionChanged(Byte[] oldValue, Byte[] newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == nameColumn) {
				Validatename((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == principal_idColumn) {
				Validateprincipal_id((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == diagram_idColumn) {
				Validatediagram_id((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == versionColumn) {
				Validateversion((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == definitionColumn) {
				Validatedefinition((Byte[])newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == nameColumn)
				OnnameChanged((String)oldValue, (String)newValue);
			else if (column == principal_idColumn)
				Onprincipal_idChanged((Int32)oldValue, (Int32)newValue);
			else if (column == diagram_idColumn)
				Ondiagram_idChanged((Int32)oldValue, (Int32)newValue);
			else if (column == versionColumn)
				OnversionChanged((Int32?)oldValue, (Int32?)newValue);
			else if (column == definitionColumn)
				OndefinitionChanged((Byte[])oldValue, (Byte[])newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Users : Row {
		public static TypedTable<aspnet_Users> CreateTable() { return new TypedTable<aspnet_Users>(Schema, () => new aspnet_Users()); }
		///<summary>Creates a new  aspnet_Users instance.</summary>
		public aspnet_Users() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the UserName column.</summary>
		public static ValueColumn UserNameColumn { get; private set; }
		///<summary>Gets the LoweredUserName column.</summary>
		public static ValueColumn LoweredUserNameColumn { get; private set; }
		///<summary>Gets the MobileAlias column.</summary>
		public static ValueColumn MobileAliasColumn { get; private set; }
		///<summary>Gets the IsAnonymous column.</summary>
		public static ValueColumn IsAnonymousColumn { get; private set; }
		///<summary>Gets the LastActivityDate column.</summary>
		public static ValueColumn LastActivityDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Users schema.</summary>
		public static new TypedSchema<aspnet_Users> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Users> schema = TypedSchema<aspnet_Users>.Create("aspnet_Users", schema => {
			ApplicationIdColumn = schema.Columns.AddForeignKey("ApplicationId", aspnet_Applications.Schema, "aspnet_Applications");
			ApplicationIdColumn.AllowNulls = false;

			schema.PrimaryKey = UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.Unique = true;
			UserIdColumn.AllowNulls = false;

			UserNameColumn = schema.Columns.AddValueColumn("UserName", typeof(String), null);
			UserNameColumn.AllowNulls = false;

			LoweredUserNameColumn = schema.Columns.AddValueColumn("LoweredUserName", typeof(String), null);
			LoweredUserNameColumn.AllowNulls = false;

			MobileAliasColumn = schema.Columns.AddValueColumn("MobileAlias", typeof(String), null);
			MobileAliasColumn.AllowNulls = true;

			IsAnonymousColumn = schema.Columns.AddValueColumn("IsAnonymous", typeof(Boolean), null);
			IsAnonymousColumn.AllowNulls = false;

			LastActivityDateColumn = schema.Columns.AddValueColumn("LastActivityDate", typeof(DateTime), null);
			LastActivityDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredUserName {
			get { return base.Field<String>(LoweredUserNameColumn); }
			set { base[LoweredUserNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Row newValue, Action<string> error);
		partial void OnApplicationIdChanged(Row oldValue, Row newValue);

		partial void ValidateUserId(Guid newValue, Action<string> error);
		partial void OnUserIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateUserName(String newValue, Action<string> error);
		partial void OnUserNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredUserName(String newValue, Action<string> error);
		partial void OnLoweredUserNameChanged(String oldValue, String newValue);

		partial void ValidateMobileAlias(String newValue, Action<string> error);
		partial void OnMobileAliasChanged(String oldValue, String newValue);

		partial void ValidateIsAnonymous(Boolean newValue, Action<string> error);
		partial void OnIsAnonymousChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateLastActivityDate(DateTime newValue, Action<string> error);
		partial void OnLastActivityDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserIdColumn) {
				ValidateUserId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserNameColumn) {
				ValidateUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredUserNameColumn) {
				ValidateLoweredUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MobileAliasColumn) {
				ValidateMobileAlias((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsAnonymousColumn) {
				ValidateIsAnonymous((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastActivityDateColumn) {
				ValidateLastActivityDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Row)oldValue, (Row)newValue);
			else if (column == UserIdColumn)
				OnUserIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == UserNameColumn)
				OnUserNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredUserNameColumn)
				OnLoweredUserNameChanged((String)oldValue, (String)newValue);
			else if (column == MobileAliasColumn)
				OnMobileAliasChanged((String)oldValue, (String)newValue);
			else if (column == IsAnonymousColumn)
				OnIsAnonymousChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == LastActivityDateColumn)
				OnLastActivityDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class PublicPages : Row {
		public static TypedTable<PublicPages> CreateTable() { return new TypedTable<PublicPages>(Schema, () => new PublicPages()); }
		///<summary>Creates a new  PublicPages instance.</summary>
		public PublicPages() : base(Schema) { }

		///<summary>Gets the Id column.</summary>
		public static ValueColumn IdColumn { get; private set; }
		///<summary>Gets the PageName column.</summary>
		public static ValueColumn PageNameColumn { get; private set; }
		///<summary>Gets the Title column.</summary>
		public static ValueColumn TitleColumn { get; private set; }
		///<summary>Gets the Content column.</summary>
		public static ValueColumn ContentColumn { get; private set; }
		///<summary>Gets the DateModified column.</summary>
		public static ValueColumn DateModifiedColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the PublicPages schema.</summary>
		public static new TypedSchema<PublicPages> Schema { get { return schema; } }
		private static readonly TypedSchema<PublicPages> schema = TypedSchema<PublicPages>.Create("PublicPages", schema => {
			IdColumn = schema.Columns.AddValueColumn("Id", typeof(Guid), null);
			IdColumn.AllowNulls = false;

			PageNameColumn = schema.Columns.AddValueColumn("PageName", typeof(String), null);
			PageNameColumn.Unique = true;
			PageNameColumn.AllowNulls = false;

			TitleColumn = schema.Columns.AddValueColumn("Title", typeof(String), null);
			TitleColumn.AllowNulls = false;

			ContentColumn = schema.Columns.AddValueColumn("Content", typeof(String), null);
			ContentColumn.AllowNulls = false;

			DateModifiedColumn = schema.Columns.AddValueColumn("DateModified", typeof(DateTime), null);
			DateModifiedColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PageName {
			get { return base.Field<String>(PageNameColumn); }
			set { base[PageNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Content {
			get { return base.Field<String>(ContentColumn); }
			set { base[ContentColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime DateModified {
			get { return base.Field<DateTime>(DateModifiedColumn); }
			set { base[DateModifiedColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateId(Guid newValue, Action<string> error);
		partial void OnIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePageName(String newValue, Action<string> error);
		partial void OnPageNameChanged(String oldValue, String newValue);

		partial void ValidateTitle(String newValue, Action<string> error);
		partial void OnTitleChanged(String oldValue, String newValue);

		partial void ValidateContent(String newValue, Action<string> error);
		partial void OnContentChanged(String oldValue, String newValue);

		partial void ValidateDateModified(DateTime newValue, Action<string> error);
		partial void OnDateModifiedChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IdColumn) {
				ValidateId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PageNameColumn) {
				ValidatePageName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TitleColumn) {
				ValidateTitle((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ContentColumn) {
				ValidateContent((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateModifiedColumn) {
				ValidateDateModified((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IdColumn)
				OnIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PageNameColumn)
				OnPageNameChanged((String)oldValue, (String)newValue);
			else if (column == TitleColumn)
				OnTitleChanged((String)oldValue, (String)newValue);
			else if (column == ContentColumn)
				OnContentChanged((String)oldValue, (String)newValue);
			else if (column == DateModifiedColumn)
				OnDateModifiedChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_SchemaVersions : Row {
		public static TypedTable<aspnet_SchemaVersions> CreateTable() { return new TypedTable<aspnet_SchemaVersions>(Schema, () => new aspnet_SchemaVersions()); }
		///<summary>Creates a new  aspnet_SchemaVersions instance.</summary>
		public aspnet_SchemaVersions() : base(Schema) { }

		///<summary>Gets the Feature column.</summary>
		public static ValueColumn FeatureColumn { get; private set; }
		///<summary>Gets the CompatibleSchemaVersion column.</summary>
		public static ValueColumn CompatibleSchemaVersionColumn { get; private set; }
		///<summary>Gets the IsCurrentVersion column.</summary>
		public static ValueColumn IsCurrentVersionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_SchemaVersions schema.</summary>
		public static new TypedSchema<aspnet_SchemaVersions> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_SchemaVersions> schema = TypedSchema<aspnet_SchemaVersions>.Create("aspnet_SchemaVersions", schema => {
			FeatureColumn = schema.Columns.AddValueColumn("Feature", typeof(String), null);
			FeatureColumn.AllowNulls = false;

			schema.PrimaryKey = CompatibleSchemaVersionColumn = schema.Columns.AddValueColumn("CompatibleSchemaVersion", typeof(String), null);
			CompatibleSchemaVersionColumn.Unique = true;
			CompatibleSchemaVersionColumn.AllowNulls = false;

			IsCurrentVersionColumn = schema.Columns.AddValueColumn("IsCurrentVersion", typeof(Boolean), null);
			IsCurrentVersionColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Feature {
			get { return base.Field<String>(FeatureColumn); }
			set { base[FeatureColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String CompatibleSchemaVersion {
			get { return base.Field<String>(CompatibleSchemaVersionColumn); }
			set { base[CompatibleSchemaVersionColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsCurrentVersion {
			get { return base.Field<Boolean>(IsCurrentVersionColumn); }
			set { base[IsCurrentVersionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateFeature(String newValue, Action<string> error);
		partial void OnFeatureChanged(String oldValue, String newValue);

		partial void ValidateCompatibleSchemaVersion(String newValue, Action<string> error);
		partial void OnCompatibleSchemaVersionChanged(String oldValue, String newValue);

		partial void ValidateIsCurrentVersion(Boolean newValue, Action<string> error);
		partial void OnIsCurrentVersionChanged(Boolean oldValue, Boolean newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == FeatureColumn) {
				ValidateFeature((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CompatibleSchemaVersionColumn) {
				ValidateCompatibleSchemaVersion((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsCurrentVersionColumn) {
				ValidateIsCurrentVersion((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == FeatureColumn)
				OnFeatureChanged((String)oldValue, (String)newValue);
			else if (column == CompatibleSchemaVersionColumn)
				OnCompatibleSchemaVersionChanged((String)oldValue, (String)newValue);
			else if (column == IsCurrentVersionColumn)
				OnIsCurrentVersionChanged((Boolean)oldValue, (Boolean)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class ProcessedEmails : Row {
		public static TypedTable<ProcessedEmails> CreateTable() { return new TypedTable<ProcessedEmails>(Schema, () => new ProcessedEmails()); }
		///<summary>Creates a new  ProcessedEmails instance.</summary>
		public ProcessedEmails() : base(Schema) { }

		///<summary>Gets the UID column.</summary>
		public static ValueColumn UIDColumn { get; private set; }
		///<summary>Gets the DateProcessed column.</summary>
		public static ValueColumn DateProcessedColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the ProcessedEmails schema.</summary>
		public static new TypedSchema<ProcessedEmails> Schema { get { return schema; } }
		private static readonly TypedSchema<ProcessedEmails> schema = TypedSchema<ProcessedEmails>.Create("ProcessedEmails", schema => {
			schema.PrimaryKey = UIDColumn = schema.Columns.AddValueColumn("UID", typeof(String), null);
			UIDColumn.Unique = true;
			UIDColumn.AllowNulls = false;

			DateProcessedColumn = schema.Columns.AddValueColumn("DateProcessed", typeof(DateTime), null);
			DateProcessedColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String UID {
			get { return base.Field<String>(UIDColumn); }
			set { base[UIDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime DateProcessed {
			get { return base.Field<DateTime>(DateProcessedColumn); }
			set { base[DateProcessedColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUID(String newValue, Action<string> error);
		partial void OnUIDChanged(String oldValue, String newValue);

		partial void ValidateDateProcessed(DateTime newValue, Action<string> error);
		partial void OnDateProcessedChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UIDColumn) {
				ValidateUID((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateProcessedColumn) {
				ValidateDateProcessed((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UIDColumn)
				OnUIDChanged((String)oldValue, (String)newValue);
			else if (column == DateProcessedColumn)
				OnDateProcessedChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_Applications : Row {
		public static TypedTable<vw_aspnet_Applications> CreateTable() { return new TypedTable<vw_aspnet_Applications>(Schema, () => new vw_aspnet_Applications()); }
		///<summary>Creates a new  vw_aspnet_Applications instance.</summary>
		public vw_aspnet_Applications() : base(Schema) { }

		///<summary>Gets the ApplicationName column.</summary>
		public static ValueColumn ApplicationNameColumn { get; private set; }
		///<summary>Gets the LoweredApplicationName column.</summary>
		public static ValueColumn LoweredApplicationNameColumn { get; private set; }
		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the Description column.</summary>
		public static ValueColumn DescriptionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_Applications schema.</summary>
		public static new TypedSchema<vw_aspnet_Applications> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_Applications> schema = TypedSchema<vw_aspnet_Applications>.Create("vw_aspnet_Applications", schema => {
			ApplicationNameColumn = schema.Columns.AddValueColumn("ApplicationName", typeof(String), null);
			ApplicationNameColumn.Unique = true;
			ApplicationNameColumn.AllowNulls = false;

			LoweredApplicationNameColumn = schema.Columns.AddValueColumn("LoweredApplicationName", typeof(String), null);
			LoweredApplicationNameColumn.Unique = true;
			LoweredApplicationNameColumn.AllowNulls = false;

			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			DescriptionColumn = schema.Columns.AddValueColumn("Description", typeof(String), null);
			DescriptionColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ApplicationName {
			get { return base.Field<String>(ApplicationNameColumn); }
			set { base[ApplicationNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredApplicationName {
			get { return base.Field<String>(LoweredApplicationNameColumn); }
			set { base[LoweredApplicationNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationName(String newValue, Action<string> error);
		partial void OnApplicationNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredApplicationName(String newValue, Action<string> error);
		partial void OnLoweredApplicationNameChanged(String oldValue, String newValue);

		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateDescription(String newValue, Action<string> error);
		partial void OnDescriptionChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationNameColumn) {
				ValidateApplicationName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredApplicationNameColumn) {
				ValidateLoweredApplicationName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DescriptionColumn) {
				ValidateDescription((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationNameColumn)
				OnApplicationNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredApplicationNameColumn)
				OnLoweredApplicationNameChanged((String)oldValue, (String)newValue);
			else if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DescriptionColumn)
				OnDescriptionChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_Users : Row {
		public static TypedTable<vw_aspnet_Users> CreateTable() { return new TypedTable<vw_aspnet_Users>(Schema, () => new vw_aspnet_Users()); }
		///<summary>Creates a new  vw_aspnet_Users instance.</summary>
		public vw_aspnet_Users() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the UserName column.</summary>
		public static ValueColumn UserNameColumn { get; private set; }
		///<summary>Gets the LoweredUserName column.</summary>
		public static ValueColumn LoweredUserNameColumn { get; private set; }
		///<summary>Gets the MobileAlias column.</summary>
		public static ValueColumn MobileAliasColumn { get; private set; }
		///<summary>Gets the IsAnonymous column.</summary>
		public static ValueColumn IsAnonymousColumn { get; private set; }
		///<summary>Gets the LastActivityDate column.</summary>
		public static ValueColumn LastActivityDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_Users schema.</summary>
		public static new TypedSchema<vw_aspnet_Users> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_Users> schema = TypedSchema<vw_aspnet_Users>.Create("vw_aspnet_Users", schema => {
			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			UserNameColumn = schema.Columns.AddValueColumn("UserName", typeof(String), null);
			UserNameColumn.AllowNulls = false;

			LoweredUserNameColumn = schema.Columns.AddValueColumn("LoweredUserName", typeof(String), null);
			LoweredUserNameColumn.AllowNulls = false;

			MobileAliasColumn = schema.Columns.AddValueColumn("MobileAlias", typeof(String), null);
			MobileAliasColumn.AllowNulls = true;

			IsAnonymousColumn = schema.Columns.AddValueColumn("IsAnonymous", typeof(Boolean), null);
			IsAnonymousColumn.AllowNulls = false;

			LastActivityDateColumn = schema.Columns.AddValueColumn("LastActivityDate", typeof(DateTime), null);
			LastActivityDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredUserName {
			get { return base.Field<String>(LoweredUserNameColumn); }
			set { base[LoweredUserNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateUserId(Guid newValue, Action<string> error);
		partial void OnUserIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateUserName(String newValue, Action<string> error);
		partial void OnUserNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredUserName(String newValue, Action<string> error);
		partial void OnLoweredUserNameChanged(String oldValue, String newValue);

		partial void ValidateMobileAlias(String newValue, Action<string> error);
		partial void OnMobileAliasChanged(String oldValue, String newValue);

		partial void ValidateIsAnonymous(Boolean newValue, Action<string> error);
		partial void OnIsAnonymousChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateLastActivityDate(DateTime newValue, Action<string> error);
		partial void OnLastActivityDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserIdColumn) {
				ValidateUserId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserNameColumn) {
				ValidateUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredUserNameColumn) {
				ValidateLoweredUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MobileAliasColumn) {
				ValidateMobileAlias((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsAnonymousColumn) {
				ValidateIsAnonymous((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastActivityDateColumn) {
				ValidateLastActivityDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == UserIdColumn)
				OnUserIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == UserNameColumn)
				OnUserNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredUserNameColumn)
				OnLoweredUserNameChanged((String)oldValue, (String)newValue);
			else if (column == MobileAliasColumn)
				OnMobileAliasChanged((String)oldValue, (String)newValue);
			else if (column == IsAnonymousColumn)
				OnIsAnonymousChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == LastActivityDateColumn)
				OnLastActivityDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Membership : Row {
		public static TypedTable<aspnet_Membership> CreateTable() { return new TypedTable<aspnet_Membership>(Schema, () => new aspnet_Membership()); }
		///<summary>Creates a new  aspnet_Membership instance.</summary>
		public aspnet_Membership() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the UserId column.</summary>
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		///<summary>Gets the Password column.</summary>
		public static ValueColumn PasswordColumn { get; private set; }
		///<summary>Gets the PasswordFormat column.</summary>
		public static ValueColumn PasswordFormatColumn { get; private set; }
		///<summary>Gets the PasswordSalt column.</summary>
		public static ValueColumn PasswordSaltColumn { get; private set; }
		///<summary>Gets the MobilePIN column.</summary>
		public static ValueColumn MobilePINColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the LoweredEmail column.</summary>
		public static ValueColumn LoweredEmailColumn { get; private set; }
		///<summary>Gets the PasswordQuestion column.</summary>
		public static ValueColumn PasswordQuestionColumn { get; private set; }
		///<summary>Gets the PasswordAnswer column.</summary>
		public static ValueColumn PasswordAnswerColumn { get; private set; }
		///<summary>Gets the IsApproved column.</summary>
		public static ValueColumn IsApprovedColumn { get; private set; }
		///<summary>Gets the IsLockedOut column.</summary>
		public static ValueColumn IsLockedOutColumn { get; private set; }
		///<summary>Gets the CreateDate column.</summary>
		public static ValueColumn CreateDateColumn { get; private set; }
		///<summary>Gets the LastLoginDate column.</summary>
		public static ValueColumn LastLoginDateColumn { get; private set; }
		///<summary>Gets the LastPasswordChangedDate column.</summary>
		public static ValueColumn LastPasswordChangedDateColumn { get; private set; }
		///<summary>Gets the LastLockoutDate column.</summary>
		public static ValueColumn LastLockoutDateColumn { get; private set; }
		///<summary>Gets the FailedPasswordAttemptCount column.</summary>
		public static ValueColumn FailedPasswordAttemptCountColumn { get; private set; }
		///<summary>Gets the FailedPasswordAttemptWindowStart column.</summary>
		public static ValueColumn FailedPasswordAttemptWindowStartColumn { get; private set; }
		///<summary>Gets the FailedPasswordAnswerAttemptCount column.</summary>
		public static ValueColumn FailedPasswordAnswerAttemptCountColumn { get; private set; }
		///<summary>Gets the FailedPasswordAnswerAttemptWindowStart column.</summary>
		public static ValueColumn FailedPasswordAnswerAttemptWindowStartColumn { get; private set; }
		///<summary>Gets the Comment column.</summary>
		public static ValueColumn CommentColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Membership schema.</summary>
		public static new TypedSchema<aspnet_Membership> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Membership> schema = TypedSchema<aspnet_Membership>.Create("aspnet_Membership", schema => {
			ApplicationIdColumn = schema.Columns.AddForeignKey("ApplicationId", aspnet_Applications.Schema, "aspnet_Applications");
			ApplicationIdColumn.AllowNulls = false;

			schema.PrimaryKey = UserIdColumn = schema.Columns.AddForeignKey("UserId", aspnet_Users.Schema, "aspnet_Users");
			UserIdColumn.Unique = true;
			UserIdColumn.AllowNulls = false;

			PasswordColumn = schema.Columns.AddValueColumn("Password", typeof(String), null);
			PasswordColumn.AllowNulls = false;

			PasswordFormatColumn = schema.Columns.AddValueColumn("PasswordFormat", typeof(Int32), null);
			PasswordFormatColumn.AllowNulls = false;

			PasswordSaltColumn = schema.Columns.AddValueColumn("PasswordSalt", typeof(String), null);
			PasswordSaltColumn.AllowNulls = false;

			MobilePINColumn = schema.Columns.AddValueColumn("MobilePIN", typeof(String), null);
			MobilePINColumn.AllowNulls = true;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = true;

			LoweredEmailColumn = schema.Columns.AddValueColumn("LoweredEmail", typeof(String), null);
			LoweredEmailColumn.AllowNulls = true;

			PasswordQuestionColumn = schema.Columns.AddValueColumn("PasswordQuestion", typeof(String), null);
			PasswordQuestionColumn.AllowNulls = true;

			PasswordAnswerColumn = schema.Columns.AddValueColumn("PasswordAnswer", typeof(String), null);
			PasswordAnswerColumn.AllowNulls = true;

			IsApprovedColumn = schema.Columns.AddValueColumn("IsApproved", typeof(Boolean), null);
			IsApprovedColumn.AllowNulls = false;

			IsLockedOutColumn = schema.Columns.AddValueColumn("IsLockedOut", typeof(Boolean), null);
			IsLockedOutColumn.AllowNulls = false;

			CreateDateColumn = schema.Columns.AddValueColumn("CreateDate", typeof(DateTime), null);
			CreateDateColumn.AllowNulls = false;

			LastLoginDateColumn = schema.Columns.AddValueColumn("LastLoginDate", typeof(DateTime), null);
			LastLoginDateColumn.AllowNulls = false;

			LastPasswordChangedDateColumn = schema.Columns.AddValueColumn("LastPasswordChangedDate", typeof(DateTime), null);
			LastPasswordChangedDateColumn.AllowNulls = false;

			LastLockoutDateColumn = schema.Columns.AddValueColumn("LastLockoutDate", typeof(DateTime), null);
			LastLockoutDateColumn.AllowNulls = false;

			FailedPasswordAttemptCountColumn = schema.Columns.AddValueColumn("FailedPasswordAttemptCount", typeof(Int32), null);
			FailedPasswordAttemptCountColumn.AllowNulls = false;

			FailedPasswordAttemptWindowStartColumn = schema.Columns.AddValueColumn("FailedPasswordAttemptWindowStart", typeof(DateTime), null);
			FailedPasswordAttemptWindowStartColumn.AllowNulls = false;

			FailedPasswordAnswerAttemptCountColumn = schema.Columns.AddValueColumn("FailedPasswordAnswerAttemptCount", typeof(Int32), null);
			FailedPasswordAnswerAttemptCountColumn.AllowNulls = false;

			FailedPasswordAnswerAttemptWindowStartColumn = schema.Columns.AddValueColumn("FailedPasswordAnswerAttemptWindowStart", typeof(DateTime), null);
			FailedPasswordAnswerAttemptWindowStartColumn.AllowNulls = false;

			CommentColumn = schema.Columns.AddValueColumn("Comment", typeof(String), null);
			CommentColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Password {
			get { return base.Field<String>(PasswordColumn); }
			set { base[PasswordColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 PasswordFormat {
			get { return base.Field<Int32>(PasswordFormatColumn); }
			set { base[PasswordFormatColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PasswordSalt {
			get { return base.Field<String>(PasswordSaltColumn); }
			set { base[PasswordSaltColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MobilePIN {
			get { return base.Field<String>(MobilePINColumn); }
			set { base[MobilePINColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredEmail {
			get { return base.Field<String>(LoweredEmailColumn); }
			set { base[LoweredEmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PasswordQuestion {
			get { return base.Field<String>(PasswordQuestionColumn); }
			set { base[PasswordQuestionColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PasswordAnswer {
			get { return base.Field<String>(PasswordAnswerColumn); }
			set { base[PasswordAnswerColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsApproved {
			get { return base.Field<Boolean>(IsApprovedColumn); }
			set { base[IsApprovedColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsLockedOut {
			get { return base.Field<Boolean>(IsLockedOutColumn); }
			set { base[IsLockedOutColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime CreateDate {
			get { return base.Field<DateTime>(CreateDateColumn); }
			set { base[CreateDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastLoginDate {
			get { return base.Field<DateTime>(LastLoginDateColumn); }
			set { base[LastLoginDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastPasswordChangedDate {
			get { return base.Field<DateTime>(LastPasswordChangedDateColumn); }
			set { base[LastPasswordChangedDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastLockoutDate {
			get { return base.Field<DateTime>(LastLockoutDateColumn); }
			set { base[LastLockoutDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 FailedPasswordAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAttemptCountColumn); }
			set { base[FailedPasswordAttemptCountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime FailedPasswordAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAttemptWindowStartColumn); }
			set { base[FailedPasswordAttemptWindowStartColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 FailedPasswordAnswerAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAnswerAttemptCountColumn); }
			set { base[FailedPasswordAnswerAttemptCountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime FailedPasswordAnswerAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAnswerAttemptWindowStartColumn); }
			set { base[FailedPasswordAnswerAttemptWindowStartColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Comment {
			get { return base.Field<String>(CommentColumn); }
			set { base[CommentColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Row newValue, Action<string> error);
		partial void OnApplicationIdChanged(Row oldValue, Row newValue);

		partial void ValidateUserId(Row newValue, Action<string> error);
		partial void OnUserIdChanged(Row oldValue, Row newValue);

		partial void ValidatePassword(String newValue, Action<string> error);
		partial void OnPasswordChanged(String oldValue, String newValue);

		partial void ValidatePasswordFormat(Int32 newValue, Action<string> error);
		partial void OnPasswordFormatChanged(Int32 oldValue, Int32 newValue);

		partial void ValidatePasswordSalt(String newValue, Action<string> error);
		partial void OnPasswordSaltChanged(String oldValue, String newValue);

		partial void ValidateMobilePIN(String newValue, Action<string> error);
		partial void OnMobilePINChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateLoweredEmail(String newValue, Action<string> error);
		partial void OnLoweredEmailChanged(String oldValue, String newValue);

		partial void ValidatePasswordQuestion(String newValue, Action<string> error);
		partial void OnPasswordQuestionChanged(String oldValue, String newValue);

		partial void ValidatePasswordAnswer(String newValue, Action<string> error);
		partial void OnPasswordAnswerChanged(String oldValue, String newValue);

		partial void ValidateIsApproved(Boolean newValue, Action<string> error);
		partial void OnIsApprovedChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateIsLockedOut(Boolean newValue, Action<string> error);
		partial void OnIsLockedOutChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateCreateDate(DateTime newValue, Action<string> error);
		partial void OnCreateDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastLoginDate(DateTime newValue, Action<string> error);
		partial void OnLastLoginDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastPasswordChangedDate(DateTime newValue, Action<string> error);
		partial void OnLastPasswordChangedDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastLockoutDate(DateTime newValue, Action<string> error);
		partial void OnLastLockoutDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFailedPasswordAttemptCount(Int32 newValue, Action<string> error);
		partial void OnFailedPasswordAttemptCountChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateFailedPasswordAttemptWindowStart(DateTime newValue, Action<string> error);
		partial void OnFailedPasswordAttemptWindowStartChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFailedPasswordAnswerAttemptCount(Int32 newValue, Action<string> error);
		partial void OnFailedPasswordAnswerAttemptCountChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateFailedPasswordAnswerAttemptWindowStart(DateTime newValue, Action<string> error);
		partial void OnFailedPasswordAnswerAttemptWindowStartChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateComment(String newValue, Action<string> error);
		partial void OnCommentChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserIdColumn) {
				ValidateUserId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordColumn) {
				ValidatePassword((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordFormatColumn) {
				ValidatePasswordFormat((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordSaltColumn) {
				ValidatePasswordSalt((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MobilePINColumn) {
				ValidateMobilePIN((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredEmailColumn) {
				ValidateLoweredEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordQuestionColumn) {
				ValidatePasswordQuestion((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordAnswerColumn) {
				ValidatePasswordAnswer((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsApprovedColumn) {
				ValidateIsApproved((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsLockedOutColumn) {
				ValidateIsLockedOut((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CreateDateColumn) {
				ValidateCreateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastLoginDateColumn) {
				ValidateLastLoginDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastPasswordChangedDateColumn) {
				ValidateLastPasswordChangedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastLockoutDateColumn) {
				ValidateLastLockoutDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAttemptCountColumn) {
				ValidateFailedPasswordAttemptCount((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAttemptWindowStartColumn) {
				ValidateFailedPasswordAttemptWindowStart((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAnswerAttemptCountColumn) {
				ValidateFailedPasswordAnswerAttemptCount((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAnswerAttemptWindowStartColumn) {
				ValidateFailedPasswordAnswerAttemptWindowStart((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CommentColumn) {
				ValidateComment((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Row)oldValue, (Row)newValue);
			else if (column == UserIdColumn)
				OnUserIdChanged((Row)oldValue, (Row)newValue);
			else if (column == PasswordColumn)
				OnPasswordChanged((String)oldValue, (String)newValue);
			else if (column == PasswordFormatColumn)
				OnPasswordFormatChanged((Int32)oldValue, (Int32)newValue);
			else if (column == PasswordSaltColumn)
				OnPasswordSaltChanged((String)oldValue, (String)newValue);
			else if (column == MobilePINColumn)
				OnMobilePINChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == LoweredEmailColumn)
				OnLoweredEmailChanged((String)oldValue, (String)newValue);
			else if (column == PasswordQuestionColumn)
				OnPasswordQuestionChanged((String)oldValue, (String)newValue);
			else if (column == PasswordAnswerColumn)
				OnPasswordAnswerChanged((String)oldValue, (String)newValue);
			else if (column == IsApprovedColumn)
				OnIsApprovedChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == IsLockedOutColumn)
				OnIsLockedOutChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == CreateDateColumn)
				OnCreateDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastLoginDateColumn)
				OnLastLoginDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastPasswordChangedDateColumn)
				OnLastPasswordChangedDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastLockoutDateColumn)
				OnLastLockoutDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FailedPasswordAttemptCountColumn)
				OnFailedPasswordAttemptCountChanged((Int32)oldValue, (Int32)newValue);
			else if (column == FailedPasswordAttemptWindowStartColumn)
				OnFailedPasswordAttemptWindowStartChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FailedPasswordAnswerAttemptCountColumn)
				OnFailedPasswordAnswerAttemptCountChanged((Int32)oldValue, (Int32)newValue);
			else if (column == FailedPasswordAnswerAttemptWindowStartColumn)
				OnFailedPasswordAnswerAttemptWindowStartChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == CommentColumn)
				OnCommentChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_MembershipUsers : Row {
		public static TypedTable<vw_aspnet_MembershipUsers> CreateTable() { return new TypedTable<vw_aspnet_MembershipUsers>(Schema, () => new vw_aspnet_MembershipUsers()); }
		///<summary>Creates a new  vw_aspnet_MembershipUsers instance.</summary>
		public vw_aspnet_MembershipUsers() : base(Schema) { }

		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the PasswordFormat column.</summary>
		public static ValueColumn PasswordFormatColumn { get; private set; }
		///<summary>Gets the MobilePIN column.</summary>
		public static ValueColumn MobilePINColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the LoweredEmail column.</summary>
		public static ValueColumn LoweredEmailColumn { get; private set; }
		///<summary>Gets the PasswordQuestion column.</summary>
		public static ValueColumn PasswordQuestionColumn { get; private set; }
		///<summary>Gets the PasswordAnswer column.</summary>
		public static ValueColumn PasswordAnswerColumn { get; private set; }
		///<summary>Gets the IsApproved column.</summary>
		public static ValueColumn IsApprovedColumn { get; private set; }
		///<summary>Gets the IsLockedOut column.</summary>
		public static ValueColumn IsLockedOutColumn { get; private set; }
		///<summary>Gets the CreateDate column.</summary>
		public static ValueColumn CreateDateColumn { get; private set; }
		///<summary>Gets the LastLoginDate column.</summary>
		public static ValueColumn LastLoginDateColumn { get; private set; }
		///<summary>Gets the LastPasswordChangedDate column.</summary>
		public static ValueColumn LastPasswordChangedDateColumn { get; private set; }
		///<summary>Gets the LastLockoutDate column.</summary>
		public static ValueColumn LastLockoutDateColumn { get; private set; }
		///<summary>Gets the FailedPasswordAttemptCount column.</summary>
		public static ValueColumn FailedPasswordAttemptCountColumn { get; private set; }
		///<summary>Gets the FailedPasswordAttemptWindowStart column.</summary>
		public static ValueColumn FailedPasswordAttemptWindowStartColumn { get; private set; }
		///<summary>Gets the FailedPasswordAnswerAttemptCount column.</summary>
		public static ValueColumn FailedPasswordAnswerAttemptCountColumn { get; private set; }
		///<summary>Gets the FailedPasswordAnswerAttemptWindowStart column.</summary>
		public static ValueColumn FailedPasswordAnswerAttemptWindowStartColumn { get; private set; }
		///<summary>Gets the Comment column.</summary>
		public static ValueColumn CommentColumn { get; private set; }
		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the UserName column.</summary>
		public static ValueColumn UserNameColumn { get; private set; }
		///<summary>Gets the MobileAlias column.</summary>
		public static ValueColumn MobileAliasColumn { get; private set; }
		///<summary>Gets the IsAnonymous column.</summary>
		public static ValueColumn IsAnonymousColumn { get; private set; }
		///<summary>Gets the LastActivityDate column.</summary>
		public static ValueColumn LastActivityDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_MembershipUsers schema.</summary>
		public static new TypedSchema<vw_aspnet_MembershipUsers> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_MembershipUsers> schema = TypedSchema<vw_aspnet_MembershipUsers>.Create("vw_aspnet_MembershipUsers", schema => {
			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			PasswordFormatColumn = schema.Columns.AddValueColumn("PasswordFormat", typeof(Int32), null);
			PasswordFormatColumn.AllowNulls = false;

			MobilePINColumn = schema.Columns.AddValueColumn("MobilePIN", typeof(String), null);
			MobilePINColumn.AllowNulls = true;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = true;

			LoweredEmailColumn = schema.Columns.AddValueColumn("LoweredEmail", typeof(String), null);
			LoweredEmailColumn.AllowNulls = true;

			PasswordQuestionColumn = schema.Columns.AddValueColumn("PasswordQuestion", typeof(String), null);
			PasswordQuestionColumn.AllowNulls = true;

			PasswordAnswerColumn = schema.Columns.AddValueColumn("PasswordAnswer", typeof(String), null);
			PasswordAnswerColumn.AllowNulls = true;

			IsApprovedColumn = schema.Columns.AddValueColumn("IsApproved", typeof(Boolean), null);
			IsApprovedColumn.AllowNulls = false;

			IsLockedOutColumn = schema.Columns.AddValueColumn("IsLockedOut", typeof(Boolean), null);
			IsLockedOutColumn.AllowNulls = false;

			CreateDateColumn = schema.Columns.AddValueColumn("CreateDate", typeof(DateTime), null);
			CreateDateColumn.AllowNulls = false;

			LastLoginDateColumn = schema.Columns.AddValueColumn("LastLoginDate", typeof(DateTime), null);
			LastLoginDateColumn.AllowNulls = false;

			LastPasswordChangedDateColumn = schema.Columns.AddValueColumn("LastPasswordChangedDate", typeof(DateTime), null);
			LastPasswordChangedDateColumn.AllowNulls = false;

			LastLockoutDateColumn = schema.Columns.AddValueColumn("LastLockoutDate", typeof(DateTime), null);
			LastLockoutDateColumn.AllowNulls = false;

			FailedPasswordAttemptCountColumn = schema.Columns.AddValueColumn("FailedPasswordAttemptCount", typeof(Int32), null);
			FailedPasswordAttemptCountColumn.AllowNulls = false;

			FailedPasswordAttemptWindowStartColumn = schema.Columns.AddValueColumn("FailedPasswordAttemptWindowStart", typeof(DateTime), null);
			FailedPasswordAttemptWindowStartColumn.AllowNulls = false;

			FailedPasswordAnswerAttemptCountColumn = schema.Columns.AddValueColumn("FailedPasswordAnswerAttemptCount", typeof(Int32), null);
			FailedPasswordAnswerAttemptCountColumn.AllowNulls = false;

			FailedPasswordAnswerAttemptWindowStartColumn = schema.Columns.AddValueColumn("FailedPasswordAnswerAttemptWindowStart", typeof(DateTime), null);
			FailedPasswordAnswerAttemptWindowStartColumn.AllowNulls = false;

			CommentColumn = schema.Columns.AddValueColumn("Comment", typeof(String), null);
			CommentColumn.AllowNulls = true;

			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			UserNameColumn = schema.Columns.AddValueColumn("UserName", typeof(String), null);
			UserNameColumn.AllowNulls = false;

			MobileAliasColumn = schema.Columns.AddValueColumn("MobileAlias", typeof(String), null);
			MobileAliasColumn.AllowNulls = true;

			IsAnonymousColumn = schema.Columns.AddValueColumn("IsAnonymous", typeof(Boolean), null);
			IsAnonymousColumn.AllowNulls = false;

			LastActivityDateColumn = schema.Columns.AddValueColumn("LastActivityDate", typeof(DateTime), null);
			LastActivityDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 PasswordFormat {
			get { return base.Field<Int32>(PasswordFormatColumn); }
			set { base[PasswordFormatColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MobilePIN {
			get { return base.Field<String>(MobilePINColumn); }
			set { base[MobilePINColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredEmail {
			get { return base.Field<String>(LoweredEmailColumn); }
			set { base[LoweredEmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PasswordQuestion {
			get { return base.Field<String>(PasswordQuestionColumn); }
			set { base[PasswordQuestionColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PasswordAnswer {
			get { return base.Field<String>(PasswordAnswerColumn); }
			set { base[PasswordAnswerColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsApproved {
			get { return base.Field<Boolean>(IsApprovedColumn); }
			set { base[IsApprovedColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsLockedOut {
			get { return base.Field<Boolean>(IsLockedOutColumn); }
			set { base[IsLockedOutColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime CreateDate {
			get { return base.Field<DateTime>(CreateDateColumn); }
			set { base[CreateDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastLoginDate {
			get { return base.Field<DateTime>(LastLoginDateColumn); }
			set { base[LastLoginDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastPasswordChangedDate {
			get { return base.Field<DateTime>(LastPasswordChangedDateColumn); }
			set { base[LastPasswordChangedDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastLockoutDate {
			get { return base.Field<DateTime>(LastLockoutDateColumn); }
			set { base[LastLockoutDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 FailedPasswordAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAttemptCountColumn); }
			set { base[FailedPasswordAttemptCountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime FailedPasswordAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAttemptWindowStartColumn); }
			set { base[FailedPasswordAttemptWindowStartColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32 FailedPasswordAnswerAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAnswerAttemptCountColumn); }
			set { base[FailedPasswordAnswerAttemptCountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime FailedPasswordAnswerAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAnswerAttemptWindowStartColumn); }
			set { base[FailedPasswordAnswerAttemptWindowStartColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Comment {
			get { return base.Field<String>(CommentColumn); }
			set { base[CommentColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUserId(Guid newValue, Action<string> error);
		partial void OnUserIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePasswordFormat(Int32 newValue, Action<string> error);
		partial void OnPasswordFormatChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateMobilePIN(String newValue, Action<string> error);
		partial void OnMobilePINChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateLoweredEmail(String newValue, Action<string> error);
		partial void OnLoweredEmailChanged(String oldValue, String newValue);

		partial void ValidatePasswordQuestion(String newValue, Action<string> error);
		partial void OnPasswordQuestionChanged(String oldValue, String newValue);

		partial void ValidatePasswordAnswer(String newValue, Action<string> error);
		partial void OnPasswordAnswerChanged(String oldValue, String newValue);

		partial void ValidateIsApproved(Boolean newValue, Action<string> error);
		partial void OnIsApprovedChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateIsLockedOut(Boolean newValue, Action<string> error);
		partial void OnIsLockedOutChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateCreateDate(DateTime newValue, Action<string> error);
		partial void OnCreateDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastLoginDate(DateTime newValue, Action<string> error);
		partial void OnLastLoginDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastPasswordChangedDate(DateTime newValue, Action<string> error);
		partial void OnLastPasswordChangedDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateLastLockoutDate(DateTime newValue, Action<string> error);
		partial void OnLastLockoutDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFailedPasswordAttemptCount(Int32 newValue, Action<string> error);
		partial void OnFailedPasswordAttemptCountChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateFailedPasswordAttemptWindowStart(DateTime newValue, Action<string> error);
		partial void OnFailedPasswordAttemptWindowStartChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFailedPasswordAnswerAttemptCount(Int32 newValue, Action<string> error);
		partial void OnFailedPasswordAnswerAttemptCountChanged(Int32 oldValue, Int32 newValue);

		partial void ValidateFailedPasswordAnswerAttemptWindowStart(DateTime newValue, Action<string> error);
		partial void OnFailedPasswordAnswerAttemptWindowStartChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateComment(String newValue, Action<string> error);
		partial void OnCommentChanged(String oldValue, String newValue);

		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateUserName(String newValue, Action<string> error);
		partial void OnUserNameChanged(String oldValue, String newValue);

		partial void ValidateMobileAlias(String newValue, Action<string> error);
		partial void OnMobileAliasChanged(String oldValue, String newValue);

		partial void ValidateIsAnonymous(Boolean newValue, Action<string> error);
		partial void OnIsAnonymousChanged(Boolean oldValue, Boolean newValue);

		partial void ValidateLastActivityDate(DateTime newValue, Action<string> error);
		partial void OnLastActivityDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UserIdColumn) {
				ValidateUserId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordFormatColumn) {
				ValidatePasswordFormat((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MobilePINColumn) {
				ValidateMobilePIN((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredEmailColumn) {
				ValidateLoweredEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordQuestionColumn) {
				ValidatePasswordQuestion((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PasswordAnswerColumn) {
				ValidatePasswordAnswer((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsApprovedColumn) {
				ValidateIsApproved((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsLockedOutColumn) {
				ValidateIsLockedOut((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CreateDateColumn) {
				ValidateCreateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastLoginDateColumn) {
				ValidateLastLoginDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastPasswordChangedDateColumn) {
				ValidateLastPasswordChangedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastLockoutDateColumn) {
				ValidateLastLockoutDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAttemptCountColumn) {
				ValidateFailedPasswordAttemptCount((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAttemptWindowStartColumn) {
				ValidateFailedPasswordAttemptWindowStart((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAnswerAttemptCountColumn) {
				ValidateFailedPasswordAnswerAttemptCount((Int32)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FailedPasswordAnswerAttemptWindowStartColumn) {
				ValidateFailedPasswordAnswerAttemptWindowStart((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CommentColumn) {
				ValidateComment((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserNameColumn) {
				ValidateUserName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MobileAliasColumn) {
				ValidateMobileAlias((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == IsAnonymousColumn) {
				ValidateIsAnonymous((Boolean)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastActivityDateColumn) {
				ValidateLastActivityDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UserIdColumn)
				OnUserIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PasswordFormatColumn)
				OnPasswordFormatChanged((Int32)oldValue, (Int32)newValue);
			else if (column == MobilePINColumn)
				OnMobilePINChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == LoweredEmailColumn)
				OnLoweredEmailChanged((String)oldValue, (String)newValue);
			else if (column == PasswordQuestionColumn)
				OnPasswordQuestionChanged((String)oldValue, (String)newValue);
			else if (column == PasswordAnswerColumn)
				OnPasswordAnswerChanged((String)oldValue, (String)newValue);
			else if (column == IsApprovedColumn)
				OnIsApprovedChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == IsLockedOutColumn)
				OnIsLockedOutChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == CreateDateColumn)
				OnCreateDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastLoginDateColumn)
				OnLastLoginDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastPasswordChangedDateColumn)
				OnLastPasswordChangedDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == LastLockoutDateColumn)
				OnLastLockoutDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FailedPasswordAttemptCountColumn)
				OnFailedPasswordAttemptCountChanged((Int32)oldValue, (Int32)newValue);
			else if (column == FailedPasswordAttemptWindowStartColumn)
				OnFailedPasswordAttemptWindowStartChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FailedPasswordAnswerAttemptCountColumn)
				OnFailedPasswordAnswerAttemptCountChanged((Int32)oldValue, (Int32)newValue);
			else if (column == FailedPasswordAnswerAttemptWindowStartColumn)
				OnFailedPasswordAnswerAttemptWindowStartChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == CommentColumn)
				OnCommentChanged((String)oldValue, (String)newValue);
			else if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == UserNameColumn)
				OnUserNameChanged((String)oldValue, (String)newValue);
			else if (column == MobileAliasColumn)
				OnMobileAliasChanged((String)oldValue, (String)newValue);
			else if (column == IsAnonymousColumn)
				OnIsAnonymousChanged((Boolean)oldValue, (Boolean)newValue);
			else if (column == LastActivityDateColumn)
				OnLastActivityDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Profile : Row {
		public static TypedTable<aspnet_Profile> CreateTable() { return new TypedTable<aspnet_Profile>(Schema, () => new aspnet_Profile()); }
		///<summary>Creates a new  aspnet_Profile instance.</summary>
		public aspnet_Profile() : base(Schema) { }

		///<summary>Gets the UserId column.</summary>
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		///<summary>Gets the PropertyNames column.</summary>
		public static ValueColumn PropertyNamesColumn { get; private set; }
		///<summary>Gets the PropertyValuesString column.</summary>
		public static ValueColumn PropertyValuesStringColumn { get; private set; }
		///<summary>Gets the PropertyValuesBinary column.</summary>
		public static ValueColumn PropertyValuesBinaryColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Profile schema.</summary>
		public static new TypedSchema<aspnet_Profile> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Profile> schema = TypedSchema<aspnet_Profile>.Create("aspnet_Profile", schema => {
			schema.PrimaryKey = UserIdColumn = schema.Columns.AddForeignKey("UserId", aspnet_Users.Schema, "aspnet_Users");
			UserIdColumn.Unique = true;
			UserIdColumn.AllowNulls = false;

			PropertyNamesColumn = schema.Columns.AddValueColumn("PropertyNames", typeof(String), null);
			PropertyNamesColumn.AllowNulls = false;

			PropertyValuesStringColumn = schema.Columns.AddValueColumn("PropertyValuesString", typeof(String), null);
			PropertyValuesStringColumn.AllowNulls = false;

			PropertyValuesBinaryColumn = schema.Columns.AddValueColumn("PropertyValuesBinary", typeof(Byte[]), null);
			PropertyValuesBinaryColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PropertyNames {
			get { return base.Field<String>(PropertyNamesColumn); }
			set { base[PropertyNamesColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String PropertyValuesString {
			get { return base.Field<String>(PropertyValuesStringColumn); }
			set { base[PropertyValuesStringColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Byte[] PropertyValuesBinary {
			get { return base.Field<Byte[]>(PropertyValuesBinaryColumn); }
			set { base[PropertyValuesBinaryColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUserId(Row newValue, Action<string> error);
		partial void OnUserIdChanged(Row oldValue, Row newValue);

		partial void ValidatePropertyNames(String newValue, Action<string> error);
		partial void OnPropertyNamesChanged(String oldValue, String newValue);

		partial void ValidatePropertyValuesString(String newValue, Action<string> error);
		partial void OnPropertyValuesStringChanged(String oldValue, String newValue);

		partial void ValidatePropertyValuesBinary(Byte[] newValue, Action<string> error);
		partial void OnPropertyValuesBinaryChanged(Byte[] oldValue, Byte[] newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UserIdColumn) {
				ValidateUserId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PropertyNamesColumn) {
				ValidatePropertyNames((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PropertyValuesStringColumn) {
				ValidatePropertyValuesString((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PropertyValuesBinaryColumn) {
				ValidatePropertyValuesBinary((Byte[])newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UserIdColumn)
				OnUserIdChanged((Row)oldValue, (Row)newValue);
			else if (column == PropertyNamesColumn)
				OnPropertyNamesChanged((String)oldValue, (String)newValue);
			else if (column == PropertyValuesStringColumn)
				OnPropertyValuesStringChanged((String)oldValue, (String)newValue);
			else if (column == PropertyValuesBinaryColumn)
				OnPropertyValuesBinaryChanged((Byte[])oldValue, (Byte[])newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_Profiles : Row {
		public static TypedTable<vw_aspnet_Profiles> CreateTable() { return new TypedTable<vw_aspnet_Profiles>(Schema, () => new vw_aspnet_Profiles()); }
		///<summary>Creates a new  vw_aspnet_Profiles instance.</summary>
		public vw_aspnet_Profiles() : base(Schema) { }

		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }
		///<summary>Gets the DataSize column.</summary>
		public static ValueColumn DataSizeColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_Profiles schema.</summary>
		public static new TypedSchema<vw_aspnet_Profiles> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_Profiles> schema = TypedSchema<vw_aspnet_Profiles>.Create("vw_aspnet_Profiles", schema => {
			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUserId(Guid newValue, Action<string> error);
		partial void OnUserIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateDataSize(Int32? newValue, Action<string> error);
		partial void OnDataSizeChanged(Int32? oldValue, Int32? newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UserIdColumn) {
				ValidateUserId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DataSizeColumn) {
				ValidateDataSize((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UserIdColumn)
				OnUserIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == DataSizeColumn)
				OnDataSizeChanged((Int32?)oldValue, (Int32?)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Roles : Row {
		public static TypedTable<aspnet_Roles> CreateTable() { return new TypedTable<aspnet_Roles>(Schema, () => new aspnet_Roles()); }
		///<summary>Creates a new  aspnet_Roles instance.</summary>
		public aspnet_Roles() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the RoleId column.</summary>
		public static ValueColumn RoleIdColumn { get; private set; }
		///<summary>Gets the RoleName column.</summary>
		public static ValueColumn RoleNameColumn { get; private set; }
		///<summary>Gets the LoweredRoleName column.</summary>
		public static ValueColumn LoweredRoleNameColumn { get; private set; }
		///<summary>Gets the Description column.</summary>
		public static ValueColumn DescriptionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Roles schema.</summary>
		public static new TypedSchema<aspnet_Roles> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Roles> schema = TypedSchema<aspnet_Roles>.Create("aspnet_Roles", schema => {
			ApplicationIdColumn = schema.Columns.AddForeignKey("ApplicationId", aspnet_Applications.Schema, "aspnet_Applications");
			ApplicationIdColumn.AllowNulls = false;

			schema.PrimaryKey = RoleIdColumn = schema.Columns.AddValueColumn("RoleId", typeof(Guid), null);
			RoleIdColumn.Unique = true;
			RoleIdColumn.AllowNulls = false;

			RoleNameColumn = schema.Columns.AddValueColumn("RoleName", typeof(String), null);
			RoleNameColumn.AllowNulls = false;

			LoweredRoleNameColumn = schema.Columns.AddValueColumn("LoweredRoleName", typeof(String), null);
			LoweredRoleNameColumn.AllowNulls = false;

			DescriptionColumn = schema.Columns.AddValueColumn("Description", typeof(String), null);
			DescriptionColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String RoleName {
			get { return base.Field<String>(RoleNameColumn); }
			set { base[RoleNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredRoleName {
			get { return base.Field<String>(LoweredRoleNameColumn); }
			set { base[LoweredRoleNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Row newValue, Action<string> error);
		partial void OnApplicationIdChanged(Row oldValue, Row newValue);

		partial void ValidateRoleId(Guid newValue, Action<string> error);
		partial void OnRoleIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateRoleName(String newValue, Action<string> error);
		partial void OnRoleNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredRoleName(String newValue, Action<string> error);
		partial void OnLoweredRoleNameChanged(String oldValue, String newValue);

		partial void ValidateDescription(String newValue, Action<string> error);
		partial void OnDescriptionChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleIdColumn) {
				ValidateRoleId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleNameColumn) {
				ValidateRoleName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredRoleNameColumn) {
				ValidateLoweredRoleName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DescriptionColumn) {
				ValidateDescription((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Row)oldValue, (Row)newValue);
			else if (column == RoleIdColumn)
				OnRoleIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == RoleNameColumn)
				OnRoleNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredRoleNameColumn)
				OnLoweredRoleNameChanged((String)oldValue, (String)newValue);
			else if (column == DescriptionColumn)
				OnDescriptionChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class Pledges : Row {
		public static TypedTable<Pledges> CreateTable() { return new TypedTable<Pledges>(Schema, () => new Pledges()); }
		///<summary>Creates a new  Pledges instance.</summary>
		public Pledges() : base(Schema) { }

		///<summary>Gets the PledgeId column.</summary>
		public static ValueColumn PledgeIdColumn { get; private set; }
		///<summary>Gets the PersonId column.</summary>
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the Type column.</summary>
		public static ValueColumn TypeColumn { get; private set; }
		///<summary>Gets the SubType column.</summary>
		public static ValueColumn SubTypeColumn { get; private set; }
		///<summary>Gets the Account column.</summary>
		public static ValueColumn AccountColumn { get; private set; }
		///<summary>Gets the Amount column.</summary>
		public static ValueColumn AmountColumn { get; private set; }
		///<summary>Gets the Note column.</summary>
		public static ValueColumn NoteColumn { get; private set; }
		///<summary>Gets the Comments column.</summary>
		public static ValueColumn CommentsColumn { get; private set; }
		///<summary>Gets the Modified column.</summary>
		public static ValueColumn ModifiedColumn { get; private set; }
		///<summary>Gets the Modifier column.</summary>
		public static ValueColumn ModifierColumn { get; private set; }
		///<summary>Gets the ExternalSource column.</summary>
		public static ValueColumn ExternalSourceColumn { get; private set; }
		///<summary>Gets the ExternalID column.</summary>
		public static ValueColumn ExternalIDColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the Pledges schema.</summary>
		public static new TypedSchema<Pledges> Schema { get { return schema; } }
		private static readonly TypedSchema<Pledges> schema = TypedSchema<Pledges>.Create("Pledges", schema => {
			schema.PrimaryKey = PledgeIdColumn = schema.Columns.AddValueColumn("PledgeId", typeof(Guid), null);
			PledgeIdColumn.Unique = true;
			PledgeIdColumn.AllowNulls = false;

			PersonIdColumn = schema.Columns.AddForeignKey("PersonId", MasterDirectory.Schema, "MasterDirectory");
			PersonIdColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			TypeColumn = schema.Columns.AddValueColumn("Type", typeof(String), null);
			TypeColumn.AllowNulls = false;

			SubTypeColumn = schema.Columns.AddValueColumn("SubType", typeof(String), null);
			SubTypeColumn.AllowNulls = false;

			AccountColumn = schema.Columns.AddValueColumn("Account", typeof(String), null);
			AccountColumn.Unique = true;
			AccountColumn.AllowNulls = false;

			AmountColumn = schema.Columns.AddValueColumn("Amount", typeof(Decimal), null);
			AmountColumn.AllowNulls = false;

			NoteColumn = schema.Columns.AddValueColumn("Note", typeof(String), null);
			NoteColumn.AllowNulls = true;

			CommentsColumn = schema.Columns.AddValueColumn("Comments", typeof(String), null);
			CommentsColumn.AllowNulls = true;

			ModifiedColumn = schema.Columns.AddValueColumn("Modified", typeof(DateTime), null);
			ModifiedColumn.AllowNulls = false;

			ModifierColumn = schema.Columns.AddValueColumn("Modifier", typeof(String), null);
			ModifierColumn.AllowNulls = false;

			ExternalSourceColumn = schema.Columns.AddValueColumn("ExternalSource", typeof(String), null);
			ExternalSourceColumn.AllowNulls = true;

			ExternalIDColumn = schema.Columns.AddValueColumn("ExternalID", typeof(Int32), null);
			ExternalIDColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PledgeId {
			get { return base.Field<Guid>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Type {
			get { return base.Field<String>(TypeColumn); }
			set { base[TypeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String SubType {
			get { return base.Field<String>(SubTypeColumn); }
			set { base[SubTypeColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Note {
			get { return base.Field<String>(NoteColumn); }
			set { base[NoteColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Comments {
			get { return base.Field<String>(CommentsColumn); }
			set { base[CommentsColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Modified {
			get { return base.Field<DateTime>(ModifiedColumn); }
			set { base[ModifiedColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Modifier {
			get { return base.Field<String>(ModifierColumn); }
			set { base[ModifierColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ExternalSource {
			get { return base.Field<String>(ExternalSourceColumn); }
			set { base[ExternalSourceColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? ExternalID {
			get { return base.Field<Int32?>(ExternalIDColumn); }
			set { base[ExternalIDColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePledgeId(Guid newValue, Action<string> error);
		partial void OnPledgeIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePersonId(Row newValue, Action<string> error);
		partial void OnPersonIdChanged(Row oldValue, Row newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateType(String newValue, Action<string> error);
		partial void OnTypeChanged(String oldValue, String newValue);

		partial void ValidateSubType(String newValue, Action<string> error);
		partial void OnSubTypeChanged(String oldValue, String newValue);

		partial void ValidateAccount(String newValue, Action<string> error);
		partial void OnAccountChanged(String oldValue, String newValue);

		partial void ValidateAmount(Decimal newValue, Action<string> error);
		partial void OnAmountChanged(Decimal oldValue, Decimal newValue);

		partial void ValidateNote(String newValue, Action<string> error);
		partial void OnNoteChanged(String oldValue, String newValue);

		partial void ValidateComments(String newValue, Action<string> error);
		partial void OnCommentsChanged(String oldValue, String newValue);

		partial void ValidateModified(DateTime newValue, Action<string> error);
		partial void OnModifiedChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateModifier(String newValue, Action<string> error);
		partial void OnModifierChanged(String oldValue, String newValue);

		partial void ValidateExternalSource(String newValue, Action<string> error);
		partial void OnExternalSourceChanged(String oldValue, String newValue);

		partial void ValidateExternalID(Int32? newValue, Action<string> error);
		partial void OnExternalIDChanged(Int32? oldValue, Int32? newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PledgeIdColumn) {
				ValidatePledgeId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PersonIdColumn) {
				ValidatePersonId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TypeColumn) {
				ValidateType((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == SubTypeColumn) {
				ValidateSubType((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AccountColumn) {
				ValidateAccount((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AmountColumn) {
				ValidateAmount((Decimal)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == NoteColumn) {
				ValidateNote((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CommentsColumn) {
				ValidateComments((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ModifiedColumn) {
				ValidateModified((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ModifierColumn) {
				ValidateModifier((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ExternalSourceColumn) {
				ValidateExternalSource((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ExternalIDColumn) {
				ValidateExternalID((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PledgeIdColumn)
				OnPledgeIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PersonIdColumn)
				OnPersonIdChanged((Row)oldValue, (Row)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == TypeColumn)
				OnTypeChanged((String)oldValue, (String)newValue);
			else if (column == SubTypeColumn)
				OnSubTypeChanged((String)oldValue, (String)newValue);
			else if (column == AccountColumn)
				OnAccountChanged((String)oldValue, (String)newValue);
			else if (column == AmountColumn)
				OnAmountChanged((Decimal)oldValue, (Decimal)newValue);
			else if (column == NoteColumn)
				OnNoteChanged((String)oldValue, (String)newValue);
			else if (column == CommentsColumn)
				OnCommentsChanged((String)oldValue, (String)newValue);
			else if (column == ModifiedColumn)
				OnModifiedChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == ModifierColumn)
				OnModifierChanged((String)oldValue, (String)newValue);
			else if (column == ExternalSourceColumn)
				OnExternalSourceChanged((String)oldValue, (String)newValue);
			else if (column == ExternalIDColumn)
				OnExternalIDChanged((Int32?)oldValue, (Int32?)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_UsersInRoles : Row {
		public static TypedTable<aspnet_UsersInRoles> CreateTable() { return new TypedTable<aspnet_UsersInRoles>(Schema, () => new aspnet_UsersInRoles()); }
		///<summary>Creates a new  aspnet_UsersInRoles instance.</summary>
		public aspnet_UsersInRoles() : base(Schema) { }

		///<summary>Gets the UserId column.</summary>
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		///<summary>Gets the RoleId column.</summary>
		public static ForeignKeyColumn RoleIdColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_UsersInRoles schema.</summary>
		public static new TypedSchema<aspnet_UsersInRoles> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_UsersInRoles> schema = TypedSchema<aspnet_UsersInRoles>.Create("aspnet_UsersInRoles", schema => {
			UserIdColumn = schema.Columns.AddForeignKey("UserId", aspnet_Users.Schema, "aspnet_Users");
			UserIdColumn.AllowNulls = false;

			schema.PrimaryKey = RoleIdColumn = schema.Columns.AddForeignKey("RoleId", aspnet_Roles.Schema, "aspnet_Roles");
			RoleIdColumn.Unique = true;
			RoleIdColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row RoleId {
			get { return base.Field<Row>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUserId(Row newValue, Action<string> error);
		partial void OnUserIdChanged(Row oldValue, Row newValue);

		partial void ValidateRoleId(Row newValue, Action<string> error);
		partial void OnRoleIdChanged(Row oldValue, Row newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UserIdColumn) {
				ValidateUserId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleIdColumn) {
				ValidateRoleId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UserIdColumn)
				OnUserIdChanged((Row)oldValue, (Row)newValue);
			else if (column == RoleIdColumn)
				OnRoleIdChanged((Row)oldValue, (Row)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class Payments : Row {
		public static TypedTable<Payments> CreateTable() { return new TypedTable<Payments>(Schema, () => new Payments()); }
		///<summary>Creates a new  Payments instance.</summary>
		public Payments() : base(Schema) { }

		///<summary>Gets the PaymentId column.</summary>
		public static ValueColumn PaymentIdColumn { get; private set; }
		///<summary>Gets the PersonId column.</summary>
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the Method column.</summary>
		public static ValueColumn MethodColumn { get; private set; }
		///<summary>Gets the CheckNumber column.</summary>
		public static ValueColumn CheckNumberColumn { get; private set; }
		///<summary>Gets the Account column.</summary>
		public static ValueColumn AccountColumn { get; private set; }
		///<summary>Gets the Amount column.</summary>
		public static ValueColumn AmountColumn { get; private set; }
		///<summary>Gets the Comments column.</summary>
		public static ValueColumn CommentsColumn { get; private set; }
		///<summary>Gets the Modified column.</summary>
		public static ValueColumn ModifiedColumn { get; private set; }
		///<summary>Gets the Modifier column.</summary>
		public static ValueColumn ModifierColumn { get; private set; }
		///<summary>Gets the DepositDate column.</summary>
		public static ValueColumn DepositDateColumn { get; private set; }
		///<summary>Gets the ExternalSource column.</summary>
		public static ValueColumn ExternalSourceColumn { get; private set; }
		///<summary>Gets the ExternalID column.</summary>
		public static ValueColumn ExternalIDColumn { get; private set; }
		///<summary>Gets the DepositId column.</summary>
		public static ForeignKeyColumn DepositIdColumn { get; private set; }
		///<summary>Gets the CheckInteger column.</summary>
		public static ValueColumn CheckIntegerColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the Payments schema.</summary>
		public static new TypedSchema<Payments> Schema { get { return schema; } }
		private static readonly TypedSchema<Payments> schema = TypedSchema<Payments>.Create("Payments", schema => {
			schema.PrimaryKey = PaymentIdColumn = schema.Columns.AddValueColumn("PaymentId", typeof(Guid), null);
			PaymentIdColumn.Unique = true;
			PaymentIdColumn.AllowNulls = false;

			PersonIdColumn = schema.Columns.AddForeignKey("PersonId", MasterDirectory.Schema, "MasterDirectory");
			PersonIdColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			MethodColumn = schema.Columns.AddValueColumn("Method", typeof(String), null);
			MethodColumn.AllowNulls = false;

			CheckNumberColumn = schema.Columns.AddValueColumn("CheckNumber", typeof(String), null);
			CheckNumberColumn.AllowNulls = true;

			AccountColumn = schema.Columns.AddValueColumn("Account", typeof(String), null);
			AccountColumn.Unique = true;
			AccountColumn.AllowNulls = false;

			AmountColumn = schema.Columns.AddValueColumn("Amount", typeof(Decimal), null);
			AmountColumn.AllowNulls = false;

			CommentsColumn = schema.Columns.AddValueColumn("Comments", typeof(String), null);
			CommentsColumn.AllowNulls = true;

			ModifiedColumn = schema.Columns.AddValueColumn("Modified", typeof(DateTime), null);
			ModifiedColumn.AllowNulls = false;

			ModifierColumn = schema.Columns.AddValueColumn("Modifier", typeof(String), null);
			ModifierColumn.AllowNulls = false;

			DepositDateColumn = schema.Columns.AddValueColumn("DepositDate", typeof(DateTime), null);
			DepositDateColumn.AllowNulls = true;

			ExternalSourceColumn = schema.Columns.AddValueColumn("ExternalSource", typeof(String), null);
			ExternalSourceColumn.AllowNulls = true;

			ExternalIDColumn = schema.Columns.AddValueColumn("ExternalID", typeof(Int32), null);
			ExternalIDColumn.AllowNulls = true;

			DepositIdColumn = schema.Columns.AddForeignKey("DepositId", Deposits.Schema, "Deposits");
			DepositIdColumn.AllowNulls = true;

			CheckIntegerColumn = schema.Columns.AddValueColumn("CheckInteger", typeof(Int32), null);
			CheckIntegerColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PaymentId {
			get { return base.Field<Guid>(PaymentIdColumn); }
			set { base[PaymentIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Method {
			get { return base.Field<String>(MethodColumn); }
			set { base[MethodColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String CheckNumber {
			get { return base.Field<String>(CheckNumberColumn); }
			set { base[CheckNumberColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Comments {
			get { return base.Field<String>(CommentsColumn); }
			set { base[CommentsColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Modified {
			get { return base.Field<DateTime>(ModifiedColumn); }
			set { base[ModifiedColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Modifier {
			get { return base.Field<String>(ModifierColumn); }
			set { base[ModifierColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime? DepositDate {
			get { return base.Field<DateTime?>(DepositDateColumn); }
			set { base[DepositDateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String ExternalSource {
			get { return base.Field<String>(ExternalSourceColumn); }
			set { base[ExternalSourceColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? ExternalID {
			get { return base.Field<Int32?>(ExternalIDColumn); }
			set { base[ExternalIDColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row DepositId {
			get { return base.Field<Row>(DepositIdColumn); }
			set { base[DepositIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Int32? CheckInteger {
			get { return base.Field<Int32?>(CheckIntegerColumn); }
			set { base[CheckIntegerColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePaymentId(Guid newValue, Action<string> error);
		partial void OnPaymentIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePersonId(Row newValue, Action<string> error);
		partial void OnPersonIdChanged(Row oldValue, Row newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateMethod(String newValue, Action<string> error);
		partial void OnMethodChanged(String oldValue, String newValue);

		partial void ValidateCheckNumber(String newValue, Action<string> error);
		partial void OnCheckNumberChanged(String oldValue, String newValue);

		partial void ValidateAccount(String newValue, Action<string> error);
		partial void OnAccountChanged(String oldValue, String newValue);

		partial void ValidateAmount(Decimal newValue, Action<string> error);
		partial void OnAmountChanged(Decimal oldValue, Decimal newValue);

		partial void ValidateComments(String newValue, Action<string> error);
		partial void OnCommentsChanged(String oldValue, String newValue);

		partial void ValidateModified(DateTime newValue, Action<string> error);
		partial void OnModifiedChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateModifier(String newValue, Action<string> error);
		partial void OnModifierChanged(String oldValue, String newValue);

		partial void ValidateDepositDate(DateTime? newValue, Action<string> error);
		partial void OnDepositDateChanged(DateTime? oldValue, DateTime? newValue);

		partial void ValidateExternalSource(String newValue, Action<string> error);
		partial void OnExternalSourceChanged(String oldValue, String newValue);

		partial void ValidateExternalID(Int32? newValue, Action<string> error);
		partial void OnExternalIDChanged(Int32? oldValue, Int32? newValue);

		partial void ValidateDepositId(Row newValue, Action<string> error);
		partial void OnDepositIdChanged(Row oldValue, Row newValue);

		partial void ValidateCheckInteger(Int32? newValue, Action<string> error);
		partial void OnCheckIntegerChanged(Int32? oldValue, Int32? newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PaymentIdColumn) {
				ValidatePaymentId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PersonIdColumn) {
				ValidatePersonId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == MethodColumn) {
				ValidateMethod((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CheckNumberColumn) {
				ValidateCheckNumber((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AccountColumn) {
				ValidateAccount((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AmountColumn) {
				ValidateAmount((Decimal)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CommentsColumn) {
				ValidateComments((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ModifiedColumn) {
				ValidateModified((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ModifierColumn) {
				ValidateModifier((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DepositDateColumn) {
				ValidateDepositDate((DateTime?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ExternalSourceColumn) {
				ValidateExternalSource((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == ExternalIDColumn) {
				ValidateExternalID((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DepositIdColumn) {
				ValidateDepositId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == CheckIntegerColumn) {
				ValidateCheckInteger((Int32?)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PaymentIdColumn)
				OnPaymentIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PersonIdColumn)
				OnPersonIdChanged((Row)oldValue, (Row)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == MethodColumn)
				OnMethodChanged((String)oldValue, (String)newValue);
			else if (column == CheckNumberColumn)
				OnCheckNumberChanged((String)oldValue, (String)newValue);
			else if (column == AccountColumn)
				OnAccountChanged((String)oldValue, (String)newValue);
			else if (column == AmountColumn)
				OnAmountChanged((Decimal)oldValue, (Decimal)newValue);
			else if (column == CommentsColumn)
				OnCommentsChanged((String)oldValue, (String)newValue);
			else if (column == ModifiedColumn)
				OnModifiedChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == ModifierColumn)
				OnModifierChanged((String)oldValue, (String)newValue);
			else if (column == DepositDateColumn)
				OnDepositDateChanged((DateTime?)oldValue, (DateTime?)newValue);
			else if (column == ExternalSourceColumn)
				OnExternalSourceChanged((String)oldValue, (String)newValue);
			else if (column == ExternalIDColumn)
				OnExternalIDChanged((Int32?)oldValue, (Int32?)newValue);
			else if (column == DepositIdColumn)
				OnDepositIdChanged((Row)oldValue, (Row)newValue);
			else if (column == CheckIntegerColumn)
				OnCheckIntegerChanged((Int32?)oldValue, (Int32?)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_Roles : Row {
		public static TypedTable<vw_aspnet_Roles> CreateTable() { return new TypedTable<vw_aspnet_Roles>(Schema, () => new vw_aspnet_Roles()); }
		///<summary>Creates a new  vw_aspnet_Roles instance.</summary>
		public vw_aspnet_Roles() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ValueColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the RoleId column.</summary>
		public static ValueColumn RoleIdColumn { get; private set; }
		///<summary>Gets the RoleName column.</summary>
		public static ValueColumn RoleNameColumn { get; private set; }
		///<summary>Gets the LoweredRoleName column.</summary>
		public static ValueColumn LoweredRoleNameColumn { get; private set; }
		///<summary>Gets the Description column.</summary>
		public static ValueColumn DescriptionColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_Roles schema.</summary>
		public static new TypedSchema<vw_aspnet_Roles> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_Roles> schema = TypedSchema<vw_aspnet_Roles>.Create("vw_aspnet_Roles", schema => {
			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			RoleIdColumn = schema.Columns.AddValueColumn("RoleId", typeof(Guid), null);
			RoleIdColumn.AllowNulls = false;

			RoleNameColumn = schema.Columns.AddValueColumn("RoleName", typeof(String), null);
			RoleNameColumn.AllowNulls = false;

			LoweredRoleNameColumn = schema.Columns.AddValueColumn("LoweredRoleName", typeof(String), null);
			LoweredRoleNameColumn.AllowNulls = false;

			DescriptionColumn = schema.Columns.AddValueColumn("Description", typeof(String), null);
			DescriptionColumn.AllowNulls = true;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String RoleName {
			get { return base.Field<String>(RoleNameColumn); }
			set { base[RoleNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredRoleName {
			get { return base.Field<String>(LoweredRoleNameColumn); }
			set { base[LoweredRoleNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Guid newValue, Action<string> error);
		partial void OnApplicationIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateRoleId(Guid newValue, Action<string> error);
		partial void OnRoleIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateRoleName(String newValue, Action<string> error);
		partial void OnRoleNameChanged(String oldValue, String newValue);

		partial void ValidateLoweredRoleName(String newValue, Action<string> error);
		partial void OnLoweredRoleNameChanged(String oldValue, String newValue);

		partial void ValidateDescription(String newValue, Action<string> error);
		partial void OnDescriptionChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleIdColumn) {
				ValidateRoleId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleNameColumn) {
				ValidateRoleName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredRoleNameColumn) {
				ValidateLoweredRoleName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DescriptionColumn) {
				ValidateDescription((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == RoleIdColumn)
				OnRoleIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == RoleNameColumn)
				OnRoleNameChanged((String)oldValue, (String)newValue);
			else if (column == LoweredRoleNameColumn)
				OnLoweredRoleNameChanged((String)oldValue, (String)newValue);
			else if (column == DescriptionColumn)
				OnDescriptionChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class vw_aspnet_UsersInRoles : Row {
		public static TypedTable<vw_aspnet_UsersInRoles> CreateTable() { return new TypedTable<vw_aspnet_UsersInRoles>(Schema, () => new vw_aspnet_UsersInRoles()); }
		///<summary>Creates a new  vw_aspnet_UsersInRoles instance.</summary>
		public vw_aspnet_UsersInRoles() : base(Schema) { }

		///<summary>Gets the UserId column.</summary>
		public static ValueColumn UserIdColumn { get; private set; }
		///<summary>Gets the RoleId column.</summary>
		public static ValueColumn RoleIdColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the vw_aspnet_UsersInRoles schema.</summary>
		public static new TypedSchema<vw_aspnet_UsersInRoles> Schema { get { return schema; } }
		private static readonly TypedSchema<vw_aspnet_UsersInRoles> schema = TypedSchema<vw_aspnet_UsersInRoles>.Create("vw_aspnet_UsersInRoles", schema => {
			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			RoleIdColumn = schema.Columns.AddValueColumn("RoleId", typeof(Guid), null);
			RoleIdColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateUserId(Guid newValue, Action<string> error);
		partial void OnUserIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateRoleId(Guid newValue, Action<string> error);
		partial void OnRoleIdChanged(Guid oldValue, Guid newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == UserIdColumn) {
				ValidateUserId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == RoleIdColumn) {
				ValidateRoleId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == UserIdColumn)
				OnUserIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == RoleIdColumn)
				OnRoleIdChanged((Guid)oldValue, (Guid)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_Paths : Row {
		public static TypedTable<aspnet_Paths> CreateTable() { return new TypedTable<aspnet_Paths>(Schema, () => new aspnet_Paths()); }
		///<summary>Creates a new  aspnet_Paths instance.</summary>
		public aspnet_Paths() : base(Schema) { }

		///<summary>Gets the ApplicationId column.</summary>
		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		///<summary>Gets the PathId column.</summary>
		public static ValueColumn PathIdColumn { get; private set; }
		///<summary>Gets the Path column.</summary>
		public static ValueColumn PathColumn { get; private set; }
		///<summary>Gets the LoweredPath column.</summary>
		public static ValueColumn LoweredPathColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_Paths schema.</summary>
		public static new TypedSchema<aspnet_Paths> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_Paths> schema = TypedSchema<aspnet_Paths>.Create("aspnet_Paths", schema => {
			ApplicationIdColumn = schema.Columns.AddForeignKey("ApplicationId", aspnet_Applications.Schema, "aspnet_Applications");
			ApplicationIdColumn.AllowNulls = false;

			schema.PrimaryKey = PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.Unique = true;
			PathIdColumn.AllowNulls = false;

			PathColumn = schema.Columns.AddValueColumn("Path", typeof(String), null);
			PathColumn.AllowNulls = false;

			LoweredPathColumn = schema.Columns.AddValueColumn("LoweredPath", typeof(String), null);
			LoweredPathColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Path {
			get { return base.Field<String>(PathColumn); }
			set { base[PathColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String LoweredPath {
			get { return base.Field<String>(LoweredPathColumn); }
			set { base[LoweredPathColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateApplicationId(Row newValue, Action<string> error);
		partial void OnApplicationIdChanged(Row oldValue, Row newValue);

		partial void ValidatePathId(Guid newValue, Action<string> error);
		partial void OnPathIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePath(String newValue, Action<string> error);
		partial void OnPathChanged(String oldValue, String newValue);

		partial void ValidateLoweredPath(String newValue, Action<string> error);
		partial void OnLoweredPathChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == ApplicationIdColumn) {
				ValidateApplicationId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PathIdColumn) {
				ValidatePathId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PathColumn) {
				ValidatePath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LoweredPathColumn) {
				ValidateLoweredPath((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == ApplicationIdColumn)
				OnApplicationIdChanged((Row)oldValue, (Row)newValue);
			else if (column == PathIdColumn)
				OnPathIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PathColumn)
				OnPathChanged((String)oldValue, (String)newValue);
			else if (column == LoweredPathColumn)
				OnLoweredPathChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_PersonalizationAllUsers : Row {
		public static TypedTable<aspnet_PersonalizationAllUsers> CreateTable() { return new TypedTable<aspnet_PersonalizationAllUsers>(Schema, () => new aspnet_PersonalizationAllUsers()); }
		///<summary>Creates a new  aspnet_PersonalizationAllUsers instance.</summary>
		public aspnet_PersonalizationAllUsers() : base(Schema) { }

		///<summary>Gets the PathId column.</summary>
		public static ForeignKeyColumn PathIdColumn { get; private set; }
		///<summary>Gets the PageSettings column.</summary>
		public static ValueColumn PageSettingsColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_PersonalizationAllUsers schema.</summary>
		public static new TypedSchema<aspnet_PersonalizationAllUsers> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_PersonalizationAllUsers> schema = TypedSchema<aspnet_PersonalizationAllUsers>.Create("aspnet_PersonalizationAllUsers", schema => {
			schema.PrimaryKey = PathIdColumn = schema.Columns.AddForeignKey("PathId", aspnet_Paths.Schema, "aspnet_Paths");
			PathIdColumn.Unique = true;
			PathIdColumn.AllowNulls = false;

			PageSettingsColumn = schema.Columns.AddValueColumn("PageSettings", typeof(Byte[]), null);
			PageSettingsColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PathId {
			get { return base.Field<Row>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Byte[] PageSettings {
			get { return base.Field<Byte[]>(PageSettingsColumn); }
			set { base[PageSettingsColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePathId(Row newValue, Action<string> error);
		partial void OnPathIdChanged(Row oldValue, Row newValue);

		partial void ValidatePageSettings(Byte[] newValue, Action<string> error);
		partial void OnPageSettingsChanged(Byte[] oldValue, Byte[] newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PathIdColumn) {
				ValidatePathId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PageSettingsColumn) {
				ValidatePageSettings((Byte[])newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PathIdColumn)
				OnPathIdChanged((Row)oldValue, (Row)newValue);
			else if (column == PageSettingsColumn)
				OnPageSettingsChanged((Byte[])oldValue, (Byte[])newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class aspnet_PersonalizationPerUser : Row {
		public static TypedTable<aspnet_PersonalizationPerUser> CreateTable() { return new TypedTable<aspnet_PersonalizationPerUser>(Schema, () => new aspnet_PersonalizationPerUser()); }
		///<summary>Creates a new  aspnet_PersonalizationPerUser instance.</summary>
		public aspnet_PersonalizationPerUser() : base(Schema) { }

		///<summary>Gets the Id column.</summary>
		public static ValueColumn IdColumn { get; private set; }
		///<summary>Gets the PathId column.</summary>
		public static ForeignKeyColumn PathIdColumn { get; private set; }
		///<summary>Gets the UserId column.</summary>
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		///<summary>Gets the PageSettings column.</summary>
		public static ValueColumn PageSettingsColumn { get; private set; }
		///<summary>Gets the LastUpdatedDate column.</summary>
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the aspnet_PersonalizationPerUser schema.</summary>
		public static new TypedSchema<aspnet_PersonalizationPerUser> Schema { get { return schema; } }
		private static readonly TypedSchema<aspnet_PersonalizationPerUser> schema = TypedSchema<aspnet_PersonalizationPerUser>.Create("aspnet_PersonalizationPerUser", schema => {
			schema.PrimaryKey = IdColumn = schema.Columns.AddValueColumn("Id", typeof(Guid), null);
			IdColumn.Unique = true;
			IdColumn.AllowNulls = false;

			PathIdColumn = schema.Columns.AddForeignKey("PathId", aspnet_Paths.Schema, "aspnet_Paths");
			PathIdColumn.AllowNulls = true;

			UserIdColumn = schema.Columns.AddForeignKey("UserId", aspnet_Users.Schema, "aspnet_Users");
			UserIdColumn.AllowNulls = true;

			PageSettingsColumn = schema.Columns.AddValueColumn("PageSettings", typeof(Byte[]), null);
			PageSettingsColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row PathId {
			get { return base.Field<Row>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Byte[] PageSettings {
			get { return base.Field<Byte[]>(PageSettingsColumn); }
			set { base[PageSettingsColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidateId(Guid newValue, Action<string> error);
		partial void OnIdChanged(Guid oldValue, Guid newValue);

		partial void ValidatePathId(Row newValue, Action<string> error);
		partial void OnPathIdChanged(Row oldValue, Row newValue);

		partial void ValidateUserId(Row newValue, Action<string> error);
		partial void OnUserIdChanged(Row oldValue, Row newValue);

		partial void ValidatePageSettings(Byte[] newValue, Action<string> error);
		partial void OnPageSettingsChanged(Byte[] oldValue, Byte[] newValue);

		partial void ValidateLastUpdatedDate(DateTime newValue, Action<string> error);
		partial void OnLastUpdatedDateChanged(DateTime oldValue, DateTime newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == IdColumn) {
				ValidateId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PathIdColumn) {
				ValidatePathId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == UserIdColumn) {
				ValidateUserId((Row)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PageSettingsColumn) {
				ValidatePageSettings((Byte[])newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == LastUpdatedDateColumn) {
				ValidateLastUpdatedDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == IdColumn)
				OnIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == PathIdColumn)
				OnPathIdChanged((Row)oldValue, (Row)newValue);
			else if (column == UserIdColumn)
				OnUserIdChanged((Row)oldValue, (Row)newValue);
			else if (column == PageSettingsColumn)
				OnPageSettingsChanged((Byte[])oldValue, (Byte[])newValue);
			else if (column == LastUpdatedDateColumn)
				OnLastUpdatedDateChanged((DateTime)oldValue, (DateTime)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
	public partial class SSSponsors : Row {
		public static TypedTable<SSSponsors> CreateTable() { return new TypedTable<SSSponsors>(Schema, () => new SSSponsors()); }
		///<summary>Creates a new  SSSponsors instance.</summary>
		public SSSponsors() : base(Schema) { }

		///<summary>Gets the PledgeId column.</summary>
		public static ValueColumn PledgeIdColumn { get; private set; }
		///<summary>Gets the Date column.</summary>
		public static ValueColumn DateColumn { get; private set; }
		///<summary>Gets the FullName column.</summary>
		public static ValueColumn FullNameColumn { get; private set; }
		///<summary>Gets the Phone column.</summary>
		public static ValueColumn PhoneColumn { get; private set; }
		///<summary>Gets the Email column.</summary>
		public static ValueColumn EmailColumn { get; private set; }
		///<summary>Gets the Amount column.</summary>
		public static ValueColumn AmountColumn { get; private set; }
		///<summary>Gets the Text column.</summary>
		public static ValueColumn TextColumn { get; private set; }

		#region Create Schema
		///<summary>Gets the SSSponsors schema.</summary>
		public static new TypedSchema<SSSponsors> Schema { get { return schema; } }
		private static readonly TypedSchema<SSSponsors> schema = TypedSchema<SSSponsors>.Create("SSSponsors", schema => {
			PledgeIdColumn = schema.Columns.AddValueColumn("PledgeId", typeof(Guid), null);
			PledgeIdColumn.Unique = true;
			PledgeIdColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			FullNameColumn = schema.Columns.AddValueColumn("FullName", typeof(String), null);
			FullNameColumn.AllowNulls = true;

			PhoneColumn = schema.Columns.AddValueColumn("Phone", typeof(String), null);
			PhoneColumn.AllowNulls = false;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;

			AmountColumn = schema.Columns.AddValueColumn("Amount", typeof(Decimal), null);
			AmountColumn.AllowNulls = false;

			TextColumn = schema.Columns.AddValueColumn("Text", typeof(String), null);
			TextColumn.AllowNulls = false;
		});
		#endregion

		#region Value Properties
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Guid PledgeId {
			get { return base.Field<Guid>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public String Text {
			get { return base.Field<String>(TextColumn); }
			set { base[TextColumn] = value; }
		}
		#endregion

		#region Partial Methods
		partial void ValidatePledgeId(Guid newValue, Action<string> error);
		partial void OnPledgeIdChanged(Guid oldValue, Guid newValue);

		partial void ValidateDate(DateTime newValue, Action<string> error);
		partial void OnDateChanged(DateTime oldValue, DateTime newValue);

		partial void ValidateFullName(String newValue, Action<string> error);
		partial void OnFullNameChanged(String oldValue, String newValue);

		partial void ValidatePhone(String newValue, Action<string> error);
		partial void OnPhoneChanged(String oldValue, String newValue);

		partial void ValidateEmail(String newValue, Action<string> error);
		partial void OnEmailChanged(String oldValue, String newValue);

		partial void ValidateAmount(Decimal newValue, Action<string> error);
		partial void OnAmountChanged(Decimal oldValue, Decimal newValue);

		partial void ValidateText(String newValue, Action<string> error);
		partial void OnTextChanged(String oldValue, String newValue);
		#endregion

		#region Column Callbacks
		///<summary>Checks whether a value would be valid for a given column in an attached row.</summary>
		///<param name="column">The column containing the value.</param>
		///<param name="newValue">The value to validate.</param>
		///<returns>An error message, or null if the value is valid.</returns>
		///<remarks>This method is overridden by typed rows to perform custom validation logic.</remarks>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		public override string ValidateValue(Column column, object newValue) {
			string error = base.ValidateValue(column, newValue);
			if (!String.IsNullOrEmpty(error)) return error;
			Action<string> reporter = s => error = s;

			if (column == PledgeIdColumn) {
				ValidatePledgeId((Guid)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == DateColumn) {
				ValidateDate((DateTime)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == FullNameColumn) {
				ValidateFullName((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == PhoneColumn) {
				ValidatePhone((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == EmailColumn) {
				ValidateEmail((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == AmountColumn) {
				ValidateAmount((Decimal)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			} else if (column == TextColumn) {
				ValidateText((String)newValue, reporter);
				if (!String.IsNullOrEmpty(error)) return error;
			}
			return null;
		}
		///<summary>Processes an explicit change of a column value.</summary>
		[DebuggerNonUserCode]
		[GeneratedCode("ShomreiTorah.Singularity.Designer", "1.0")]
		protected override void OnValueChanged(Column column, object oldValue, object newValue) {
			if (column == PledgeIdColumn)
				OnPledgeIdChanged((Guid)oldValue, (Guid)newValue);
			else if (column == DateColumn)
				OnDateChanged((DateTime)oldValue, (DateTime)newValue);
			else if (column == FullNameColumn)
				OnFullNameChanged((String)oldValue, (String)newValue);
			else if (column == PhoneColumn)
				OnPhoneChanged((String)oldValue, (String)newValue);
			else if (column == EmailColumn)
				OnEmailChanged((String)oldValue, (String)newValue);
			else if (column == AmountColumn)
				OnAmountChanged((Decimal)oldValue, (Decimal)newValue);
			else if (column == TextColumn)
				OnTextChanged((String)oldValue, (String)newValue);

			base.OnValueChanged(column, oldValue, newValue);
		}
		#endregion
	}
}
