using System;
using ShomreiTorah.Singularity;
using ShomreiTorah.Singularity.Sql;
namespace ShomreiTorah {
	public partial class SSEmails : Row {
		public static TypedTable<SSEmails> CreateTable() { return new TypedTable<SSEmails>(Schema, () => new SSEmails()); }
		public SSEmails() : base(Schema) { }

		public static ForeignKeyColumn PledgeIdColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }

		public static new readonly TypedSchema<SSEmails> Schema = TypedSchema<SSEmails>.Create("SSEmails", schema => {
			PledgeIdColumn = schema.Columns.AddForeignKey("PledgeId", Pledges.Schema, "Pledges");
			PledgeIdColumn.Unique = true;
			PledgeIdColumn.AllowNulls = false;

			EmailColumn = schema.Columns.AddValueColumn("Email", typeof(String), null);
			EmailColumn.AllowNulls = false;
		});

		#region Value Properties
		public Row PledgeId {
			get { return base.Field<Row>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		#endregion

	}
	public partial class SSRequests : Row {
		public static TypedTable<SSRequests> CreateTable() { return new TypedTable<SSRequests>(Schema, () => new SSRequests()); }
		public SSRequests() : base(Schema) { }

		public static ValueColumn IDColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn FullNameColumn { get; private set; }
		public static ValueColumn PhoneColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn TextColumn { get; private set; }

		public static new readonly TypedSchema<SSRequests> Schema = TypedSchema<SSRequests>.Create("SSRequests", schema => {
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

		#region Value Properties
		public Int32 ID {
			get { return base.Field<Int32>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public String Text {
			get { return base.Field<String>(TextColumn); }
			set { base[TextColumn] = value; }
		}
		#endregion

	}
	public partial class MBList : Row {
		public static TypedTable<MBList> CreateTable() { return new TypedTable<MBList>(Schema, () => new MBList()); }
		public MBList() : base(Schema) { }

		public static ValueColumn IDColumn { get; private set; }
		public static ValueColumn FullNameColumn { get; private set; }
		public static ValueColumn PhoneColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn CholehNameColumn { get; private set; }
		public static ValueColumn UntilColumn { get; private set; }

		public static new readonly TypedSchema<MBList> Schema = TypedSchema<MBList>.Create("MBList", schema => {
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

		#region Value Properties
		public Int32 ID {
			get { return base.Field<Int32>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public String CholehName {
			get { return base.Field<String>(CholehNameColumn); }
			set { base[CholehNameColumn] = value; }
		}
		public DateTime Until {
			get { return base.Field<DateTime>(UntilColumn); }
			set { base[UntilColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_WebPartState_Paths : Row {
		public static TypedTable<vw_aspnet_WebPartState_Paths> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_Paths>(Schema, () => new vw_aspnet_WebPartState_Paths()); }
		public vw_aspnet_WebPartState_Paths() : base(Schema) { }

		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn PathIdColumn { get; private set; }
		public static ValueColumn PathColumn { get; private set; }
		public static ValueColumn LoweredPathColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_WebPartState_Paths> Schema = TypedSchema<vw_aspnet_WebPartState_Paths>.Create("vw_aspnet_WebPartState_Paths", schema => {
			ApplicationIdColumn = schema.Columns.AddValueColumn("ApplicationId", typeof(Guid), null);
			ApplicationIdColumn.AllowNulls = false;

			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = false;

			PathColumn = schema.Columns.AddValueColumn("Path", typeof(String), null);
			PathColumn.AllowNulls = false;

			LoweredPathColumn = schema.Columns.AddValueColumn("LoweredPath", typeof(String), null);
			LoweredPathColumn.AllowNulls = false;
		});

		#region Value Properties
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public String Path {
			get { return base.Field<String>(PathColumn); }
			set { base[PathColumn] = value; }
		}
		public String LoweredPath {
			get { return base.Field<String>(LoweredPathColumn); }
			set { base[LoweredPathColumn] = value; }
		}
		#endregion

	}
	public partial class ScheduleDates : Row {
		public static TypedTable<ScheduleDates> CreateTable() { return new TypedTable<ScheduleDates>(Schema, () => new ScheduleDates()); }
		public ScheduleDates() : base(Schema) { }

		public static ValueColumn IDColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn TitleColumn { get; private set; }

		public static new readonly TypedSchema<ScheduleDates> Schema = TypedSchema<ScheduleDates>.Create("ScheduleDates", schema => {
			schema.PrimaryKey = IDColumn = schema.Columns.AddValueColumn("ID", typeof(Guid), null);
			IDColumn.Unique = true;
			IDColumn.AllowNulls = false;

			DateColumn = schema.Columns.AddValueColumn("Date", typeof(DateTime), null);
			DateColumn.Unique = true;
			DateColumn.AllowNulls = false;

			TitleColumn = schema.Columns.AddValueColumn("Title", typeof(String), null);
			TitleColumn.AllowNulls = false;
		});

		#region Value Properties
		public Guid ID {
			get { return base.Field<Guid>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_WebPartState_Shared : Row {
		public static TypedTable<vw_aspnet_WebPartState_Shared> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_Shared>(Schema, () => new vw_aspnet_WebPartState_Shared()); }
		public vw_aspnet_WebPartState_Shared() : base(Schema) { }

		public static ValueColumn PathIdColumn { get; private set; }
		public static ValueColumn DataSizeColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_WebPartState_Shared> Schema = TypedSchema<vw_aspnet_WebPartState_Shared>.Create("vw_aspnet_WebPartState_Shared", schema => {
			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = false;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});

		#region Value Properties
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_WebPartState_User : Row {
		public static TypedTable<vw_aspnet_WebPartState_User> CreateTable() { return new TypedTable<vw_aspnet_WebPartState_User>(Schema, () => new vw_aspnet_WebPartState_User()); }
		public vw_aspnet_WebPartState_User() : base(Schema) { }

		public static ValueColumn PathIdColumn { get; private set; }
		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn DataSizeColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_WebPartState_User> Schema = TypedSchema<vw_aspnet_WebPartState_User>.Create("vw_aspnet_WebPartState_User", schema => {
			PathIdColumn = schema.Columns.AddValueColumn("PathId", typeof(Guid), null);
			PathIdColumn.AllowNulls = true;

			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = true;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});

		#region Value Properties
		public Guid? PathId {
			get { return base.Field<Guid?>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public Guid? UserId {
			get { return base.Field<Guid?>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_WebEvent_Events : Row {
		public static TypedTable<aspnet_WebEvent_Events> CreateTable() { return new TypedTable<aspnet_WebEvent_Events>(Schema, () => new aspnet_WebEvent_Events()); }
		public aspnet_WebEvent_Events() : base(Schema) { }

		public static ValueColumn EventIdColumn { get; private set; }
		public static ValueColumn EventTimeUtcColumn { get; private set; }
		public static ValueColumn EventTimeColumn { get; private set; }
		public static ValueColumn EventTypeColumn { get; private set; }
		public static ValueColumn EventSequenceColumn { get; private set; }
		public static ValueColumn EventOccurrenceColumn { get; private set; }
		public static ValueColumn EventCodeColumn { get; private set; }
		public static ValueColumn EventDetailCodeColumn { get; private set; }
		public static ValueColumn MessageColumn { get; private set; }
		public static ValueColumn ApplicationPathColumn { get; private set; }
		public static ValueColumn ApplicationVirtualPathColumn { get; private set; }
		public static ValueColumn MachineNameColumn { get; private set; }
		public static ValueColumn RequestUrlColumn { get; private set; }
		public static ValueColumn ExceptionTypeColumn { get; private set; }
		public static ValueColumn DetailsColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_WebEvent_Events> Schema = TypedSchema<aspnet_WebEvent_Events>.Create("aspnet_WebEvent_Events", schema => {
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

		#region Value Properties
		public String EventId {
			get { return base.Field<String>(EventIdColumn); }
			set { base[EventIdColumn] = value; }
		}
		public DateTime EventTimeUtc {
			get { return base.Field<DateTime>(EventTimeUtcColumn); }
			set { base[EventTimeUtcColumn] = value; }
		}
		public DateTime EventTime {
			get { return base.Field<DateTime>(EventTimeColumn); }
			set { base[EventTimeColumn] = value; }
		}
		public String EventType {
			get { return base.Field<String>(EventTypeColumn); }
			set { base[EventTypeColumn] = value; }
		}
		public Decimal EventSequence {
			get { return base.Field<Decimal>(EventSequenceColumn); }
			set { base[EventSequenceColumn] = value; }
		}
		public Decimal EventOccurrence {
			get { return base.Field<Decimal>(EventOccurrenceColumn); }
			set { base[EventOccurrenceColumn] = value; }
		}
		public Int32 EventCode {
			get { return base.Field<Int32>(EventCodeColumn); }
			set { base[EventCodeColumn] = value; }
		}
		public Int32 EventDetailCode {
			get { return base.Field<Int32>(EventDetailCodeColumn); }
			set { base[EventDetailCodeColumn] = value; }
		}
		public String Message {
			get { return base.Field<String>(MessageColumn); }
			set { base[MessageColumn] = value; }
		}
		public String ApplicationPath {
			get { return base.Field<String>(ApplicationPathColumn); }
			set { base[ApplicationPathColumn] = value; }
		}
		public String ApplicationVirtualPath {
			get { return base.Field<String>(ApplicationVirtualPathColumn); }
			set { base[ApplicationVirtualPathColumn] = value; }
		}
		public String MachineName {
			get { return base.Field<String>(MachineNameColumn); }
			set { base[MachineNameColumn] = value; }
		}
		public String RequestUrl {
			get { return base.Field<String>(RequestUrlColumn); }
			set { base[RequestUrlColumn] = value; }
		}
		public String ExceptionType {
			get { return base.Field<String>(ExceptionTypeColumn); }
			set { base[ExceptionTypeColumn] = value; }
		}
		public String Details {
			get { return base.Field<String>(DetailsColumn); }
			set { base[DetailsColumn] = value; }
		}
		#endregion

	}
	public partial class ScheduleTimes : Row {
		public static TypedTable<ScheduleTimes> CreateTable() { return new TypedTable<ScheduleTimes>(Schema, () => new ScheduleTimes()); }
		public ScheduleTimes() : base(Schema) { }

		public static ValueColumn IDColumn { get; private set; }
		public static ForeignKeyColumn CellIDColumn { get; private set; }
		public static ValueColumn NameColumn { get; private set; }
		public static ValueColumn TimeColumn { get; private set; }
		public static ValueColumn IsBoldColumn { get; private set; }
		public static ValueColumn LastModifiedColumn { get; private set; }

		public static new readonly TypedSchema<ScheduleTimes> Schema = TypedSchema<ScheduleTimes>.Create("ScheduleTimes", schema => {
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

		#region Value Properties
		public Guid ID {
			get { return base.Field<Guid>(IDColumn); }
			set { base[IDColumn] = value; }
		}
		public Row CellID {
			get { return base.Field<Row>(CellIDColumn); }
			set { base[CellIDColumn] = value; }
		}
		public String Name {
			get { return base.Field<String>(NameColumn); }
			set { base[NameColumn] = value; }
		}
		public DateTime Time {
			get { return base.Field<DateTime>(TimeColumn); }
			set { base[TimeColumn] = value; }
		}
		public Boolean IsBold {
			get { return base.Field<Boolean>(IsBoldColumn); }
			set { base[IsBoldColumn] = value; }
		}
		public DateTime LastModified {
			get { return base.Field<DateTime>(LastModifiedColumn); }
			set { base[LastModifiedColumn] = value; }
		}
		#endregion

	}
	public partial class Deposits : Row {
		public static TypedTable<Deposits> CreateTable() { return new TypedTable<Deposits>(Schema, () => new Deposits()); }
		public Deposits() : base(Schema) { }

		public static ValueColumn DepositIdColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn NumberColumn { get; private set; }
		public static ValueColumn AccountColumn { get; private set; }

		public static new readonly TypedSchema<Deposits> Schema = TypedSchema<Deposits>.Create("Deposits", schema => {
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

		#region Value Properties
		public Guid DepositId {
			get { return base.Field<Guid>(DepositIdColumn); }
			set { base[DepositIdColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public Int32 Number {
			get { return base.Field<Int32>(NumberColumn); }
			set { base[NumberColumn] = value; }
		}
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		#endregion

	}
	public partial class tblMLMembers : Row {
		public static TypedTable<tblMLMembers> CreateTable() { return new TypedTable<tblMLMembers>(Schema, () => new tblMLMembers()); }
		public tblMLMembers() : base(Schema) { }

		public static ValueColumn Mail_IDColumn { get; private set; }
		public static ValueColumn NameColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn ID_CodeColumn { get; private set; }
		public static ValueColumn PasswordColumn { get; private set; }
		public static ValueColumn SaltColumn { get; private set; }
		public static ValueColumn ActiveColumn { get; private set; }
		public static ValueColumn Join_DateColumn { get; private set; }
		public static ValueColumn HTMLformatColumn { get; private set; }
		public static ForeignKeyColumn PersonIdColumn { get; private set; }

		public static new readonly TypedSchema<tblMLMembers> Schema = TypedSchema<tblMLMembers>.Create("tblMLMembers", schema => {
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

		#region Value Properties
		public Int32 Mail_ID {
			get { return base.Field<Int32>(Mail_IDColumn); }
			set { base[Mail_IDColumn] = value; }
		}
		public String Name {
			get { return base.Field<String>(NameColumn); }
			set { base[NameColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public String ID_Code {
			get { return base.Field<String>(ID_CodeColumn); }
			set { base[ID_CodeColumn] = value; }
		}
		public String Password {
			get { return base.Field<String>(PasswordColumn); }
			set { base[PasswordColumn] = value; }
		}
		public String Salt {
			get { return base.Field<String>(SaltColumn); }
			set { base[SaltColumn] = value; }
		}
		public Boolean Active {
			get { return base.Field<Boolean>(ActiveColumn); }
			set { base[ActiveColumn] = value; }
		}
		public DateTime Join_Date {
			get { return base.Field<DateTime>(Join_DateColumn); }
			set { base[Join_DateColumn] = value; }
		}
		public Boolean HTMLformat {
			get { return base.Field<Boolean>(HTMLformatColumn); }
			set { base[HTMLformatColumn] = value; }
		}
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		#endregion

	}
	public partial class StatementLog : Row {
		public static TypedTable<StatementLog> CreateTable() { return new TypedTable<StatementLog>(Schema, () => new StatementLog()); }
		public StatementLog() : base(Schema) { }

		public static ValueColumn IdColumn { get; private set; }
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		public static ValueColumn DateGeneratedColumn { get; private set; }
		public static ValueColumn MediaColumn { get; private set; }
		public static ValueColumn StatementKindColumn { get; private set; }
		public static ValueColumn StartDateColumn { get; private set; }
		public static ValueColumn EndDateColumn { get; private set; }
		public static ValueColumn UserNameColumn { get; private set; }

		public static new readonly TypedSchema<StatementLog> Schema = TypedSchema<StatementLog>.Create("StatementLog", schema => {
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

		#region Value Properties
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		public DateTime DateGenerated {
			get { return base.Field<DateTime>(DateGeneratedColumn); }
			set { base[DateGeneratedColumn] = value; }
		}
		public String Media {
			get { return base.Field<String>(MediaColumn); }
			set { base[MediaColumn] = value; }
		}
		public String StatementKind {
			get { return base.Field<String>(StatementKindColumn); }
			set { base[StatementKindColumn] = value; }
		}
		public DateTime StartDate {
			get { return base.Field<DateTime>(StartDateColumn); }
			set { base[StartDateColumn] = value; }
		}
		public DateTime EndDate {
			get { return base.Field<DateTime>(EndDateColumn); }
			set { base[EndDateColumn] = value; }
		}
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		#endregion

	}
	public partial class MasterDirectory : Row {
		public static TypedTable<MasterDirectory> CreateTable() { return new TypedTable<MasterDirectory>(Schema, () => new MasterDirectory()); }
		public MasterDirectory() : base(Schema) { }

		public static ValueColumn IdColumn { get; private set; }
		public static ValueColumn YKIDColumn { get; private set; }
		public static ValueColumn LastNameColumn { get; private set; }
		public static ValueColumn HisNameColumn { get; private set; }
		public static ValueColumn HerNameColumn { get; private set; }
		public static ValueColumn FullNameColumn { get; private set; }
		public static ValueColumn AddressColumn { get; private set; }
		public static ValueColumn CityColumn { get; private set; }
		public static ValueColumn StateColumn { get; private set; }
		public static ValueColumn ZipColumn { get; private set; }
		public static ValueColumn PhoneColumn { get; private set; }
		public static ValueColumn SourceColumn { get; private set; }

		public static new readonly TypedSchema<MasterDirectory> Schema = TypedSchema<MasterDirectory>.Create("MasterDirectory", schema => {
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

		#region Value Properties
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		public Int32? YKID {
			get { return base.Field<Int32?>(YKIDColumn); }
			set { base[YKIDColumn] = value; }
		}
		public String LastName {
			get { return base.Field<String>(LastNameColumn); }
			set { base[LastNameColumn] = value; }
		}
		public String HisName {
			get { return base.Field<String>(HisNameColumn); }
			set { base[HisNameColumn] = value; }
		}
		public String HerName {
			get { return base.Field<String>(HerNameColumn); }
			set { base[HerNameColumn] = value; }
		}
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		public String Address {
			get { return base.Field<String>(AddressColumn); }
			set { base[AddressColumn] = value; }
		}
		public String City {
			get { return base.Field<String>(CityColumn); }
			set { base[CityColumn] = value; }
		}
		public String State {
			get { return base.Field<String>(StateColumn); }
			set { base[StateColumn] = value; }
		}
		public String Zip {
			get { return base.Field<String>(ZipColumn); }
			set { base[ZipColumn] = value; }
		}
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		public String Source {
			get { return base.Field<String>(SourceColumn); }
			set { base[SourceColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Applications : Row {
		public static TypedTable<aspnet_Applications> CreateTable() { return new TypedTable<aspnet_Applications>(Schema, () => new aspnet_Applications()); }
		public aspnet_Applications() : base(Schema) { }

		public static ValueColumn ApplicationNameColumn { get; private set; }
		public static ValueColumn LoweredApplicationNameColumn { get; private set; }
		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn DescriptionColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Applications> Schema = TypedSchema<aspnet_Applications>.Create("aspnet_Applications", schema => {
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

		#region Value Properties
		public String ApplicationName {
			get { return base.Field<String>(ApplicationNameColumn); }
			set { base[ApplicationNameColumn] = value; }
		}
		public String LoweredApplicationName {
			get { return base.Field<String>(LoweredApplicationNameColumn); }
			set { base[LoweredApplicationNameColumn] = value; }
		}
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

	}
	public partial class Pages : Row {
		public static TypedTable<Pages> CreateTable() { return new TypedTable<Pages>(Schema, () => new Pages()); }
		public Pages() : base(Schema) { }

		public static ValueColumn IdColumn { get; private set; }
		public static ValueColumn PageNameColumn { get; private set; }
		public static ValueColumn TitleColumn { get; private set; }
		public static ValueColumn ContentColumn { get; private set; }
		public static ValueColumn DateModifiedColumn { get; private set; }

		public static new readonly TypedSchema<Pages> Schema = TypedSchema<Pages>.Create("Pages", schema => {
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

		#region Value Properties
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		public String PageName {
			get { return base.Field<String>(PageNameColumn); }
			set { base[PageNameColumn] = value; }
		}
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		public String Content {
			get { return base.Field<String>(ContentColumn); }
			set { base[ContentColumn] = value; }
		}
		public DateTime DateModified {
			get { return base.Field<DateTime>(DateModifiedColumn); }
			set { base[DateModifiedColumn] = value; }
		}
		#endregion

	}
	public partial class sysdiagrams : Row {
		public static TypedTable<sysdiagrams> CreateTable() { return new TypedTable<sysdiagrams>(Schema, () => new sysdiagrams()); }
		public sysdiagrams() : base(Schema) { }

		public static ValueColumn nameColumn { get; private set; }
		public static ValueColumn principal_idColumn { get; private set; }
		public static ValueColumn diagram_idColumn { get; private set; }
		public static ValueColumn versionColumn { get; private set; }
		public static ValueColumn definitionColumn { get; private set; }

		public static new readonly TypedSchema<sysdiagrams> Schema = TypedSchema<sysdiagrams>.Create("sysdiagrams", schema => {
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

		#region Value Properties
		public String name {
			get { return base.Field<String>(nameColumn); }
			set { base[nameColumn] = value; }
		}
		public Int32 principal_id {
			get { return base.Field<Int32>(principal_idColumn); }
			set { base[principal_idColumn] = value; }
		}
		public Int32 diagram_id {
			get { return base.Field<Int32>(diagram_idColumn); }
			set { base[diagram_idColumn] = value; }
		}
		public Int32? version {
			get { return base.Field<Int32?>(versionColumn); }
			set { base[versionColumn] = value; }
		}
		public Byte[] definition {
			get { return base.Field<Byte[]>(definitionColumn); }
			set { base[definitionColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Users : Row {
		public static TypedTable<aspnet_Users> CreateTable() { return new TypedTable<aspnet_Users>(Schema, () => new aspnet_Users()); }
		public aspnet_Users() : base(Schema) { }

		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn UserNameColumn { get; private set; }
		public static ValueColumn LoweredUserNameColumn { get; private set; }
		public static ValueColumn MobileAliasColumn { get; private set; }
		public static ValueColumn IsAnonymousColumn { get; private set; }
		public static ValueColumn LastActivityDateColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Users> Schema = TypedSchema<aspnet_Users>.Create("aspnet_Users", schema => {
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

		#region Value Properties
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		public String LoweredUserName {
			get { return base.Field<String>(LoweredUserNameColumn); }
			set { base[LoweredUserNameColumn] = value; }
		}
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

	}
	public partial class PublicPages : Row {
		public static TypedTable<PublicPages> CreateTable() { return new TypedTable<PublicPages>(Schema, () => new PublicPages()); }
		public PublicPages() : base(Schema) { }

		public static ValueColumn IdColumn { get; private set; }
		public static ValueColumn PageNameColumn { get; private set; }
		public static ValueColumn TitleColumn { get; private set; }
		public static ValueColumn ContentColumn { get; private set; }
		public static ValueColumn DateModifiedColumn { get; private set; }

		public static new readonly TypedSchema<PublicPages> Schema = TypedSchema<PublicPages>.Create("PublicPages", schema => {
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

		#region Value Properties
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		public String PageName {
			get { return base.Field<String>(PageNameColumn); }
			set { base[PageNameColumn] = value; }
		}
		public String Title {
			get { return base.Field<String>(TitleColumn); }
			set { base[TitleColumn] = value; }
		}
		public String Content {
			get { return base.Field<String>(ContentColumn); }
			set { base[ContentColumn] = value; }
		}
		public DateTime DateModified {
			get { return base.Field<DateTime>(DateModifiedColumn); }
			set { base[DateModifiedColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_SchemaVersions : Row {
		public static TypedTable<aspnet_SchemaVersions> CreateTable() { return new TypedTable<aspnet_SchemaVersions>(Schema, () => new aspnet_SchemaVersions()); }
		public aspnet_SchemaVersions() : base(Schema) { }

		public static ValueColumn FeatureColumn { get; private set; }
		public static ValueColumn CompatibleSchemaVersionColumn { get; private set; }
		public static ValueColumn IsCurrentVersionColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_SchemaVersions> Schema = TypedSchema<aspnet_SchemaVersions>.Create("aspnet_SchemaVersions", schema => {
			FeatureColumn = schema.Columns.AddValueColumn("Feature", typeof(String), null);
			FeatureColumn.AllowNulls = false;

			schema.PrimaryKey = CompatibleSchemaVersionColumn = schema.Columns.AddValueColumn("CompatibleSchemaVersion", typeof(String), null);
			CompatibleSchemaVersionColumn.Unique = true;
			CompatibleSchemaVersionColumn.AllowNulls = false;

			IsCurrentVersionColumn = schema.Columns.AddValueColumn("IsCurrentVersion", typeof(Boolean), null);
			IsCurrentVersionColumn.AllowNulls = false;
		});

		#region Value Properties
		public String Feature {
			get { return base.Field<String>(FeatureColumn); }
			set { base[FeatureColumn] = value; }
		}
		public String CompatibleSchemaVersion {
			get { return base.Field<String>(CompatibleSchemaVersionColumn); }
			set { base[CompatibleSchemaVersionColumn] = value; }
		}
		public Boolean IsCurrentVersion {
			get { return base.Field<Boolean>(IsCurrentVersionColumn); }
			set { base[IsCurrentVersionColumn] = value; }
		}
		#endregion

	}
	public partial class ProcessedEmails : Row {
		public static TypedTable<ProcessedEmails> CreateTable() { return new TypedTable<ProcessedEmails>(Schema, () => new ProcessedEmails()); }
		public ProcessedEmails() : base(Schema) { }

		public static ValueColumn UIDColumn { get; private set; }
		public static ValueColumn DateProcessedColumn { get; private set; }

		public static new readonly TypedSchema<ProcessedEmails> Schema = TypedSchema<ProcessedEmails>.Create("ProcessedEmails", schema => {
			schema.PrimaryKey = UIDColumn = schema.Columns.AddValueColumn("UID", typeof(String), null);
			UIDColumn.Unique = true;
			UIDColumn.AllowNulls = false;

			DateProcessedColumn = schema.Columns.AddValueColumn("DateProcessed", typeof(DateTime), null);
			DateProcessedColumn.AllowNulls = false;
		});

		#region Value Properties
		public String UID {
			get { return base.Field<String>(UIDColumn); }
			set { base[UIDColumn] = value; }
		}
		public DateTime DateProcessed {
			get { return base.Field<DateTime>(DateProcessedColumn); }
			set { base[DateProcessedColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_Applications : Row {
		public static TypedTable<vw_aspnet_Applications> CreateTable() { return new TypedTable<vw_aspnet_Applications>(Schema, () => new vw_aspnet_Applications()); }
		public vw_aspnet_Applications() : base(Schema) { }

		public static ValueColumn ApplicationNameColumn { get; private set; }
		public static ValueColumn LoweredApplicationNameColumn { get; private set; }
		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn DescriptionColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_Applications> Schema = TypedSchema<vw_aspnet_Applications>.Create("vw_aspnet_Applications", schema => {
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

		#region Value Properties
		public String ApplicationName {
			get { return base.Field<String>(ApplicationNameColumn); }
			set { base[ApplicationNameColumn] = value; }
		}
		public String LoweredApplicationName {
			get { return base.Field<String>(LoweredApplicationNameColumn); }
			set { base[LoweredApplicationNameColumn] = value; }
		}
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_Users : Row {
		public static TypedTable<vw_aspnet_Users> CreateTable() { return new TypedTable<vw_aspnet_Users>(Schema, () => new vw_aspnet_Users()); }
		public vw_aspnet_Users() : base(Schema) { }

		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn UserNameColumn { get; private set; }
		public static ValueColumn LoweredUserNameColumn { get; private set; }
		public static ValueColumn MobileAliasColumn { get; private set; }
		public static ValueColumn IsAnonymousColumn { get; private set; }
		public static ValueColumn LastActivityDateColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_Users> Schema = TypedSchema<vw_aspnet_Users>.Create("vw_aspnet_Users", schema => {
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

		#region Value Properties
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		public String LoweredUserName {
			get { return base.Field<String>(LoweredUserNameColumn); }
			set { base[LoweredUserNameColumn] = value; }
		}
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Membership : Row {
		public static TypedTable<aspnet_Membership> CreateTable() { return new TypedTable<aspnet_Membership>(Schema, () => new aspnet_Membership()); }
		public aspnet_Membership() : base(Schema) { }

		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		public static ValueColumn PasswordColumn { get; private set; }
		public static ValueColumn PasswordFormatColumn { get; private set; }
		public static ValueColumn PasswordSaltColumn { get; private set; }
		public static ValueColumn MobilePINColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn LoweredEmailColumn { get; private set; }
		public static ValueColumn PasswordQuestionColumn { get; private set; }
		public static ValueColumn PasswordAnswerColumn { get; private set; }
		public static ValueColumn IsApprovedColumn { get; private set; }
		public static ValueColumn IsLockedOutColumn { get; private set; }
		public static ValueColumn CreateDateColumn { get; private set; }
		public static ValueColumn LastLoginDateColumn { get; private set; }
		public static ValueColumn LastPasswordChangedDateColumn { get; private set; }
		public static ValueColumn LastLockoutDateColumn { get; private set; }
		public static ValueColumn FailedPasswordAttemptCountColumn { get; private set; }
		public static ValueColumn FailedPasswordAttemptWindowStartColumn { get; private set; }
		public static ValueColumn FailedPasswordAnswerAttemptCountColumn { get; private set; }
		public static ValueColumn FailedPasswordAnswerAttemptWindowStartColumn { get; private set; }
		public static ValueColumn CommentColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Membership> Schema = TypedSchema<aspnet_Membership>.Create("aspnet_Membership", schema => {
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

		#region Value Properties
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public String Password {
			get { return base.Field<String>(PasswordColumn); }
			set { base[PasswordColumn] = value; }
		}
		public Int32 PasswordFormat {
			get { return base.Field<Int32>(PasswordFormatColumn); }
			set { base[PasswordFormatColumn] = value; }
		}
		public String PasswordSalt {
			get { return base.Field<String>(PasswordSaltColumn); }
			set { base[PasswordSaltColumn] = value; }
		}
		public String MobilePIN {
			get { return base.Field<String>(MobilePINColumn); }
			set { base[MobilePINColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public String LoweredEmail {
			get { return base.Field<String>(LoweredEmailColumn); }
			set { base[LoweredEmailColumn] = value; }
		}
		public String PasswordQuestion {
			get { return base.Field<String>(PasswordQuestionColumn); }
			set { base[PasswordQuestionColumn] = value; }
		}
		public String PasswordAnswer {
			get { return base.Field<String>(PasswordAnswerColumn); }
			set { base[PasswordAnswerColumn] = value; }
		}
		public Boolean IsApproved {
			get { return base.Field<Boolean>(IsApprovedColumn); }
			set { base[IsApprovedColumn] = value; }
		}
		public Boolean IsLockedOut {
			get { return base.Field<Boolean>(IsLockedOutColumn); }
			set { base[IsLockedOutColumn] = value; }
		}
		public DateTime CreateDate {
			get { return base.Field<DateTime>(CreateDateColumn); }
			set { base[CreateDateColumn] = value; }
		}
		public DateTime LastLoginDate {
			get { return base.Field<DateTime>(LastLoginDateColumn); }
			set { base[LastLoginDateColumn] = value; }
		}
		public DateTime LastPasswordChangedDate {
			get { return base.Field<DateTime>(LastPasswordChangedDateColumn); }
			set { base[LastPasswordChangedDateColumn] = value; }
		}
		public DateTime LastLockoutDate {
			get { return base.Field<DateTime>(LastLockoutDateColumn); }
			set { base[LastLockoutDateColumn] = value; }
		}
		public Int32 FailedPasswordAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAttemptCountColumn); }
			set { base[FailedPasswordAttemptCountColumn] = value; }
		}
		public DateTime FailedPasswordAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAttemptWindowStartColumn); }
			set { base[FailedPasswordAttemptWindowStartColumn] = value; }
		}
		public Int32 FailedPasswordAnswerAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAnswerAttemptCountColumn); }
			set { base[FailedPasswordAnswerAttemptCountColumn] = value; }
		}
		public DateTime FailedPasswordAnswerAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAnswerAttemptWindowStartColumn); }
			set { base[FailedPasswordAnswerAttemptWindowStartColumn] = value; }
		}
		public String Comment {
			get { return base.Field<String>(CommentColumn); }
			set { base[CommentColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_MembershipUsers : Row {
		public static TypedTable<vw_aspnet_MembershipUsers> CreateTable() { return new TypedTable<vw_aspnet_MembershipUsers>(Schema, () => new vw_aspnet_MembershipUsers()); }
		public vw_aspnet_MembershipUsers() : base(Schema) { }

		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn PasswordFormatColumn { get; private set; }
		public static ValueColumn MobilePINColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn LoweredEmailColumn { get; private set; }
		public static ValueColumn PasswordQuestionColumn { get; private set; }
		public static ValueColumn PasswordAnswerColumn { get; private set; }
		public static ValueColumn IsApprovedColumn { get; private set; }
		public static ValueColumn IsLockedOutColumn { get; private set; }
		public static ValueColumn CreateDateColumn { get; private set; }
		public static ValueColumn LastLoginDateColumn { get; private set; }
		public static ValueColumn LastPasswordChangedDateColumn { get; private set; }
		public static ValueColumn LastLockoutDateColumn { get; private set; }
		public static ValueColumn FailedPasswordAttemptCountColumn { get; private set; }
		public static ValueColumn FailedPasswordAttemptWindowStartColumn { get; private set; }
		public static ValueColumn FailedPasswordAnswerAttemptCountColumn { get; private set; }
		public static ValueColumn FailedPasswordAnswerAttemptWindowStartColumn { get; private set; }
		public static ValueColumn CommentColumn { get; private set; }
		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn UserNameColumn { get; private set; }
		public static ValueColumn MobileAliasColumn { get; private set; }
		public static ValueColumn IsAnonymousColumn { get; private set; }
		public static ValueColumn LastActivityDateColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_MembershipUsers> Schema = TypedSchema<vw_aspnet_MembershipUsers>.Create("vw_aspnet_MembershipUsers", schema => {
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

		#region Value Properties
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public Int32 PasswordFormat {
			get { return base.Field<Int32>(PasswordFormatColumn); }
			set { base[PasswordFormatColumn] = value; }
		}
		public String MobilePIN {
			get { return base.Field<String>(MobilePINColumn); }
			set { base[MobilePINColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public String LoweredEmail {
			get { return base.Field<String>(LoweredEmailColumn); }
			set { base[LoweredEmailColumn] = value; }
		}
		public String PasswordQuestion {
			get { return base.Field<String>(PasswordQuestionColumn); }
			set { base[PasswordQuestionColumn] = value; }
		}
		public String PasswordAnswer {
			get { return base.Field<String>(PasswordAnswerColumn); }
			set { base[PasswordAnswerColumn] = value; }
		}
		public Boolean IsApproved {
			get { return base.Field<Boolean>(IsApprovedColumn); }
			set { base[IsApprovedColumn] = value; }
		}
		public Boolean IsLockedOut {
			get { return base.Field<Boolean>(IsLockedOutColumn); }
			set { base[IsLockedOutColumn] = value; }
		}
		public DateTime CreateDate {
			get { return base.Field<DateTime>(CreateDateColumn); }
			set { base[CreateDateColumn] = value; }
		}
		public DateTime LastLoginDate {
			get { return base.Field<DateTime>(LastLoginDateColumn); }
			set { base[LastLoginDateColumn] = value; }
		}
		public DateTime LastPasswordChangedDate {
			get { return base.Field<DateTime>(LastPasswordChangedDateColumn); }
			set { base[LastPasswordChangedDateColumn] = value; }
		}
		public DateTime LastLockoutDate {
			get { return base.Field<DateTime>(LastLockoutDateColumn); }
			set { base[LastLockoutDateColumn] = value; }
		}
		public Int32 FailedPasswordAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAttemptCountColumn); }
			set { base[FailedPasswordAttemptCountColumn] = value; }
		}
		public DateTime FailedPasswordAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAttemptWindowStartColumn); }
			set { base[FailedPasswordAttemptWindowStartColumn] = value; }
		}
		public Int32 FailedPasswordAnswerAttemptCount {
			get { return base.Field<Int32>(FailedPasswordAnswerAttemptCountColumn); }
			set { base[FailedPasswordAnswerAttemptCountColumn] = value; }
		}
		public DateTime FailedPasswordAnswerAttemptWindowStart {
			get { return base.Field<DateTime>(FailedPasswordAnswerAttemptWindowStartColumn); }
			set { base[FailedPasswordAnswerAttemptWindowStartColumn] = value; }
		}
		public String Comment {
			get { return base.Field<String>(CommentColumn); }
			set { base[CommentColumn] = value; }
		}
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public String UserName {
			get { return base.Field<String>(UserNameColumn); }
			set { base[UserNameColumn] = value; }
		}
		public String MobileAlias {
			get { return base.Field<String>(MobileAliasColumn); }
			set { base[MobileAliasColumn] = value; }
		}
		public Boolean IsAnonymous {
			get { return base.Field<Boolean>(IsAnonymousColumn); }
			set { base[IsAnonymousColumn] = value; }
		}
		public DateTime LastActivityDate {
			get { return base.Field<DateTime>(LastActivityDateColumn); }
			set { base[LastActivityDateColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Profile : Row {
		public static TypedTable<aspnet_Profile> CreateTable() { return new TypedTable<aspnet_Profile>(Schema, () => new aspnet_Profile()); }
		public aspnet_Profile() : base(Schema) { }

		public static ForeignKeyColumn UserIdColumn { get; private set; }
		public static ValueColumn PropertyNamesColumn { get; private set; }
		public static ValueColumn PropertyValuesStringColumn { get; private set; }
		public static ValueColumn PropertyValuesBinaryColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Profile> Schema = TypedSchema<aspnet_Profile>.Create("aspnet_Profile", schema => {
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

		#region Value Properties
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public String PropertyNames {
			get { return base.Field<String>(PropertyNamesColumn); }
			set { base[PropertyNamesColumn] = value; }
		}
		public String PropertyValuesString {
			get { return base.Field<String>(PropertyValuesStringColumn); }
			set { base[PropertyValuesStringColumn] = value; }
		}
		public Byte[] PropertyValuesBinary {
			get { return base.Field<Byte[]>(PropertyValuesBinaryColumn); }
			set { base[PropertyValuesBinaryColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_Profiles : Row {
		public static TypedTable<vw_aspnet_Profiles> CreateTable() { return new TypedTable<vw_aspnet_Profiles>(Schema, () => new vw_aspnet_Profiles()); }
		public vw_aspnet_Profiles() : base(Schema) { }

		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }
		public static ValueColumn DataSizeColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_Profiles> Schema = TypedSchema<vw_aspnet_Profiles>.Create("vw_aspnet_Profiles", schema => {
			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;

			DataSizeColumn = schema.Columns.AddValueColumn("DataSize", typeof(Int32), null);
			DataSizeColumn.AllowNulls = true;
		});

		#region Value Properties
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		public Int32? DataSize {
			get { return base.Field<Int32?>(DataSizeColumn); }
			set { base[DataSizeColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Roles : Row {
		public static TypedTable<aspnet_Roles> CreateTable() { return new TypedTable<aspnet_Roles>(Schema, () => new aspnet_Roles()); }
		public aspnet_Roles() : base(Schema) { }

		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn RoleIdColumn { get; private set; }
		public static ValueColumn RoleNameColumn { get; private set; }
		public static ValueColumn LoweredRoleNameColumn { get; private set; }
		public static ValueColumn DescriptionColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Roles> Schema = TypedSchema<aspnet_Roles>.Create("aspnet_Roles", schema => {
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

		#region Value Properties
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		public String RoleName {
			get { return base.Field<String>(RoleNameColumn); }
			set { base[RoleNameColumn] = value; }
		}
		public String LoweredRoleName {
			get { return base.Field<String>(LoweredRoleNameColumn); }
			set { base[LoweredRoleNameColumn] = value; }
		}
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

	}
	public partial class Pledges : Row {
		public static TypedTable<Pledges> CreateTable() { return new TypedTable<Pledges>(Schema, () => new Pledges()); }
		public Pledges() : base(Schema) { }

		public static ValueColumn PledgeIdColumn { get; private set; }
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn TypeColumn { get; private set; }
		public static ValueColumn SubTypeColumn { get; private set; }
		public static ValueColumn AccountColumn { get; private set; }
		public static ValueColumn AmountColumn { get; private set; }
		public static ValueColumn NoteColumn { get; private set; }
		public static ValueColumn CommentsColumn { get; private set; }
		public static ValueColumn ModifiedColumn { get; private set; }
		public static ValueColumn ModifierColumn { get; private set; }
		public static ValueColumn ExternalSourceColumn { get; private set; }
		public static ValueColumn ExternalIDColumn { get; private set; }

		public static new readonly TypedSchema<Pledges> Schema = TypedSchema<Pledges>.Create("Pledges", schema => {
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

		#region Value Properties
		public Guid PledgeId {
			get { return base.Field<Guid>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public String Type {
			get { return base.Field<String>(TypeColumn); }
			set { base[TypeColumn] = value; }
		}
		public String SubType {
			get { return base.Field<String>(SubTypeColumn); }
			set { base[SubTypeColumn] = value; }
		}
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		public String Note {
			get { return base.Field<String>(NoteColumn); }
			set { base[NoteColumn] = value; }
		}
		public String Comments {
			get { return base.Field<String>(CommentsColumn); }
			set { base[CommentsColumn] = value; }
		}
		public DateTime Modified {
			get { return base.Field<DateTime>(ModifiedColumn); }
			set { base[ModifiedColumn] = value; }
		}
		public String Modifier {
			get { return base.Field<String>(ModifierColumn); }
			set { base[ModifierColumn] = value; }
		}
		public String ExternalSource {
			get { return base.Field<String>(ExternalSourceColumn); }
			set { base[ExternalSourceColumn] = value; }
		}
		public Int32? ExternalID {
			get { return base.Field<Int32?>(ExternalIDColumn); }
			set { base[ExternalIDColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_UsersInRoles : Row {
		public static TypedTable<aspnet_UsersInRoles> CreateTable() { return new TypedTable<aspnet_UsersInRoles>(Schema, () => new aspnet_UsersInRoles()); }
		public aspnet_UsersInRoles() : base(Schema) { }

		public static ForeignKeyColumn UserIdColumn { get; private set; }
		public static ForeignKeyColumn RoleIdColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_UsersInRoles> Schema = TypedSchema<aspnet_UsersInRoles>.Create("aspnet_UsersInRoles", schema => {
			UserIdColumn = schema.Columns.AddForeignKey("UserId", aspnet_Users.Schema, "aspnet_Users");
			UserIdColumn.AllowNulls = false;

			schema.PrimaryKey = RoleIdColumn = schema.Columns.AddForeignKey("RoleId", aspnet_Roles.Schema, "aspnet_Roles");
			RoleIdColumn.Unique = true;
			RoleIdColumn.AllowNulls = false;
		});

		#region Value Properties
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public Row RoleId {
			get { return base.Field<Row>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		#endregion

	}
	public partial class Payments : Row {
		public static TypedTable<Payments> CreateTable() { return new TypedTable<Payments>(Schema, () => new Payments()); }
		public Payments() : base(Schema) { }

		public static ValueColumn PaymentIdColumn { get; private set; }
		public static ForeignKeyColumn PersonIdColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn MethodColumn { get; private set; }
		public static ValueColumn CheckNumberColumn { get; private set; }
		public static ValueColumn AccountColumn { get; private set; }
		public static ValueColumn AmountColumn { get; private set; }
		public static ValueColumn CommentsColumn { get; private set; }
		public static ValueColumn ModifiedColumn { get; private set; }
		public static ValueColumn ModifierColumn { get; private set; }
		public static ValueColumn DepositDateColumn { get; private set; }
		public static ValueColumn ExternalSourceColumn { get; private set; }
		public static ValueColumn ExternalIDColumn { get; private set; }
		public static ForeignKeyColumn DepositIdColumn { get; private set; }
		public static ValueColumn CheckIntegerColumn { get; private set; }

		public static new readonly TypedSchema<Payments> Schema = TypedSchema<Payments>.Create("Payments", schema => {
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

		#region Value Properties
		public Guid PaymentId {
			get { return base.Field<Guid>(PaymentIdColumn); }
			set { base[PaymentIdColumn] = value; }
		}
		public Row PersonId {
			get { return base.Field<Row>(PersonIdColumn); }
			set { base[PersonIdColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public String Method {
			get { return base.Field<String>(MethodColumn); }
			set { base[MethodColumn] = value; }
		}
		public String CheckNumber {
			get { return base.Field<String>(CheckNumberColumn); }
			set { base[CheckNumberColumn] = value; }
		}
		public String Account {
			get { return base.Field<String>(AccountColumn); }
			set { base[AccountColumn] = value; }
		}
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		public String Comments {
			get { return base.Field<String>(CommentsColumn); }
			set { base[CommentsColumn] = value; }
		}
		public DateTime Modified {
			get { return base.Field<DateTime>(ModifiedColumn); }
			set { base[ModifiedColumn] = value; }
		}
		public String Modifier {
			get { return base.Field<String>(ModifierColumn); }
			set { base[ModifierColumn] = value; }
		}
		public DateTime? DepositDate {
			get { return base.Field<DateTime?>(DepositDateColumn); }
			set { base[DepositDateColumn] = value; }
		}
		public String ExternalSource {
			get { return base.Field<String>(ExternalSourceColumn); }
			set { base[ExternalSourceColumn] = value; }
		}
		public Int32? ExternalID {
			get { return base.Field<Int32?>(ExternalIDColumn); }
			set { base[ExternalIDColumn] = value; }
		}
		public Row DepositId {
			get { return base.Field<Row>(DepositIdColumn); }
			set { base[DepositIdColumn] = value; }
		}
		public Int32? CheckInteger {
			get { return base.Field<Int32?>(CheckIntegerColumn); }
			set { base[CheckIntegerColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_Roles : Row {
		public static TypedTable<vw_aspnet_Roles> CreateTable() { return new TypedTable<vw_aspnet_Roles>(Schema, () => new vw_aspnet_Roles()); }
		public vw_aspnet_Roles() : base(Schema) { }

		public static ValueColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn RoleIdColumn { get; private set; }
		public static ValueColumn RoleNameColumn { get; private set; }
		public static ValueColumn LoweredRoleNameColumn { get; private set; }
		public static ValueColumn DescriptionColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_Roles> Schema = TypedSchema<vw_aspnet_Roles>.Create("vw_aspnet_Roles", schema => {
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

		#region Value Properties
		public Guid ApplicationId {
			get { return base.Field<Guid>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		public String RoleName {
			get { return base.Field<String>(RoleNameColumn); }
			set { base[RoleNameColumn] = value; }
		}
		public String LoweredRoleName {
			get { return base.Field<String>(LoweredRoleNameColumn); }
			set { base[LoweredRoleNameColumn] = value; }
		}
		public String Description {
			get { return base.Field<String>(DescriptionColumn); }
			set { base[DescriptionColumn] = value; }
		}
		#endregion

	}
	public partial class vw_aspnet_UsersInRoles : Row {
		public static TypedTable<vw_aspnet_UsersInRoles> CreateTable() { return new TypedTable<vw_aspnet_UsersInRoles>(Schema, () => new vw_aspnet_UsersInRoles()); }
		public vw_aspnet_UsersInRoles() : base(Schema) { }

		public static ValueColumn UserIdColumn { get; private set; }
		public static ValueColumn RoleIdColumn { get; private set; }

		public static new readonly TypedSchema<vw_aspnet_UsersInRoles> Schema = TypedSchema<vw_aspnet_UsersInRoles>.Create("vw_aspnet_UsersInRoles", schema => {
			UserIdColumn = schema.Columns.AddValueColumn("UserId", typeof(Guid), null);
			UserIdColumn.AllowNulls = false;

			RoleIdColumn = schema.Columns.AddValueColumn("RoleId", typeof(Guid), null);
			RoleIdColumn.AllowNulls = false;
		});

		#region Value Properties
		public Guid UserId {
			get { return base.Field<Guid>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public Guid RoleId {
			get { return base.Field<Guid>(RoleIdColumn); }
			set { base[RoleIdColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_Paths : Row {
		public static TypedTable<aspnet_Paths> CreateTable() { return new TypedTable<aspnet_Paths>(Schema, () => new aspnet_Paths()); }
		public aspnet_Paths() : base(Schema) { }

		public static ForeignKeyColumn ApplicationIdColumn { get; private set; }
		public static ValueColumn PathIdColumn { get; private set; }
		public static ValueColumn PathColumn { get; private set; }
		public static ValueColumn LoweredPathColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_Paths> Schema = TypedSchema<aspnet_Paths>.Create("aspnet_Paths", schema => {
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

		#region Value Properties
		public Row ApplicationId {
			get { return base.Field<Row>(ApplicationIdColumn); }
			set { base[ApplicationIdColumn] = value; }
		}
		public Guid PathId {
			get { return base.Field<Guid>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public String Path {
			get { return base.Field<String>(PathColumn); }
			set { base[PathColumn] = value; }
		}
		public String LoweredPath {
			get { return base.Field<String>(LoweredPathColumn); }
			set { base[LoweredPathColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_PersonalizationAllUsers : Row {
		public static TypedTable<aspnet_PersonalizationAllUsers> CreateTable() { return new TypedTable<aspnet_PersonalizationAllUsers>(Schema, () => new aspnet_PersonalizationAllUsers()); }
		public aspnet_PersonalizationAllUsers() : base(Schema) { }

		public static ForeignKeyColumn PathIdColumn { get; private set; }
		public static ValueColumn PageSettingsColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_PersonalizationAllUsers> Schema = TypedSchema<aspnet_PersonalizationAllUsers>.Create("aspnet_PersonalizationAllUsers", schema => {
			schema.PrimaryKey = PathIdColumn = schema.Columns.AddForeignKey("PathId", aspnet_Paths.Schema, "aspnet_Paths");
			PathIdColumn.Unique = true;
			PathIdColumn.AllowNulls = false;

			PageSettingsColumn = schema.Columns.AddValueColumn("PageSettings", typeof(Byte[]), null);
			PageSettingsColumn.AllowNulls = false;

			LastUpdatedDateColumn = schema.Columns.AddValueColumn("LastUpdatedDate", typeof(DateTime), null);
			LastUpdatedDateColumn.AllowNulls = false;
		});

		#region Value Properties
		public Row PathId {
			get { return base.Field<Row>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public Byte[] PageSettings {
			get { return base.Field<Byte[]>(PageSettingsColumn); }
			set { base[PageSettingsColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

	}
	public partial class aspnet_PersonalizationPerUser : Row {
		public static TypedTable<aspnet_PersonalizationPerUser> CreateTable() { return new TypedTable<aspnet_PersonalizationPerUser>(Schema, () => new aspnet_PersonalizationPerUser()); }
		public aspnet_PersonalizationPerUser() : base(Schema) { }

		public static ValueColumn IdColumn { get; private set; }
		public static ForeignKeyColumn PathIdColumn { get; private set; }
		public static ForeignKeyColumn UserIdColumn { get; private set; }
		public static ValueColumn PageSettingsColumn { get; private set; }
		public static ValueColumn LastUpdatedDateColumn { get; private set; }

		public static new readonly TypedSchema<aspnet_PersonalizationPerUser> Schema = TypedSchema<aspnet_PersonalizationPerUser>.Create("aspnet_PersonalizationPerUser", schema => {
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

		#region Value Properties
		public Guid Id {
			get { return base.Field<Guid>(IdColumn); }
			set { base[IdColumn] = value; }
		}
		public Row PathId {
			get { return base.Field<Row>(PathIdColumn); }
			set { base[PathIdColumn] = value; }
		}
		public Row UserId {
			get { return base.Field<Row>(UserIdColumn); }
			set { base[UserIdColumn] = value; }
		}
		public Byte[] PageSettings {
			get { return base.Field<Byte[]>(PageSettingsColumn); }
			set { base[PageSettingsColumn] = value; }
		}
		public DateTime LastUpdatedDate {
			get { return base.Field<DateTime>(LastUpdatedDateColumn); }
			set { base[LastUpdatedDateColumn] = value; }
		}
		#endregion

	}
	public partial class SSSponsors : Row {
		public static TypedTable<SSSponsors> CreateTable() { return new TypedTable<SSSponsors>(Schema, () => new SSSponsors()); }
		public SSSponsors() : base(Schema) { }

		public static ValueColumn PledgeIdColumn { get; private set; }
		public static ValueColumn DateColumn { get; private set; }
		public static ValueColumn FullNameColumn { get; private set; }
		public static ValueColumn PhoneColumn { get; private set; }
		public static ValueColumn EmailColumn { get; private set; }
		public static ValueColumn AmountColumn { get; private set; }
		public static ValueColumn TextColumn { get; private set; }

		public static new readonly TypedSchema<SSSponsors> Schema = TypedSchema<SSSponsors>.Create("SSSponsors", schema => {
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

		#region Value Properties
		public Guid PledgeId {
			get { return base.Field<Guid>(PledgeIdColumn); }
			set { base[PledgeIdColumn] = value; }
		}
		public DateTime Date {
			get { return base.Field<DateTime>(DateColumn); }
			set { base[DateColumn] = value; }
		}
		public String FullName {
			get { return base.Field<String>(FullNameColumn); }
			set { base[FullNameColumn] = value; }
		}
		public String Phone {
			get { return base.Field<String>(PhoneColumn); }
			set { base[PhoneColumn] = value; }
		}
		public String Email {
			get { return base.Field<String>(EmailColumn); }
			set { base[EmailColumn] = value; }
		}
		public Decimal Amount {
			get { return base.Field<Decimal>(AmountColumn); }
			set { base[AmountColumn] = value; }
		}
		public String Text {
			get { return base.Field<String>(TextColumn); }
			set { base[TextColumn] = value; }
		}
		#endregion

	}
}
