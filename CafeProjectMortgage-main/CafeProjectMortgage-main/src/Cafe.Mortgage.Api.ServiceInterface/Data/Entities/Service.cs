namespace Cafe.Mortgage.Api.ServiceInterface.Data.Entities
{
	public class Service
	{
		public int Service_Id { get; set; }

		public int Priority { get; set; }
		public int Schedule_Id { get; set; }
		public int DispPlan_Id { get; set; }
		public int RouteAccess_Id { get; set; }
		public int ServiceType_Id { get; set; }
		public int Available_f { get; set; }
		public string Service_short { get; set; }
		public string Service_c { get; set; }

		public int Application_Id { get; set; }

		public int CCID { get; set; }
		public int BackUpCCID { get; set; }
		public int Music_Id { get; set; }
		public int OutgoingMask { get; set; }
		public int EverBeenActivated { get; set; }
		public int Msg_Id { get; set; }
		public int LanguageId { get; set; }
		public int CallDataDefId { get; set; }
		public int CatalogId { get; set; }
		public int PresentationIndicator { get; set; }
		public int CpnAllowOverride { get; set; }
		public string CallingNumber { get; set; }
		public int SerializeCallDataFlag { get; set; }
		public int ServiceNameMessageId { get; set; }
		public int ServiceNameLanguageId { get; set; }
		public int AffinityTimeout { get; set; }
		public int StaticPriority { get; set; }
		public int ServiceLevel { get; set; }
		public float CallToAgentRatio { get; set; }
		public int GoalQueueTime { get; set; }
		public int CARatioCalls { get; set; }
		public int CARatioAgents { get; set; }
		public string CallingPartyName { get; set; }
		public int RecordingScheduleId { get; set; }
		public int Preemptive { get; set; }
		public int RecordingDuplex { get; set; }
		public int RecordTariffTone { get; set; }
		public int RecordTariffToneDuplex { get; set; }
		public int MonitorTariffTone { get; set; }
		public int MonitorTariffToneDuplex { get; set; }
		public int RecordTariffToneInterval { get; set; }
		public int MonitorTariffToneInterval { get; set; }
		public int AuditableAlertForAcceptCall { get; set; }
		public int MultiLine { get; set; }
		public int MultiLineNoAnswerTimeout { get; set; }
		public int AutoRecordConsultation { get; set; }
		public int PGAllowed { get; set; }
		public int PG_Id { get; set; }
		public int PGSchedule_Id { get; set; }
		public int AutoRecordHeldCalls { get; set; }
		public int AcceptMsgId { get; set; }
		public int TimeZone_Id { get; set; }

		public int ResetStatsByTimeZone { get; set; }
	}
}
