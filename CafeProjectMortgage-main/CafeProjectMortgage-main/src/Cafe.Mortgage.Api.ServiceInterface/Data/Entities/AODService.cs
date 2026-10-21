using System;

namespace Cafe.Mortgage.Api.ServiceInterface.Data.Entities
{
	public class AODService
	{
		public int Service_Id { get; set; }

		public int TimeZone_Group_Id { get; set; }
		public float SPH_Goal { get; set; }
		public int Ring_No_Ans_Rings_num { get; set; }
		public int Detection_Type_cd { get; set; }
		public int Ans_Mach_Res_cd { get; set; }
		public float Dial_to_Agent_Ratio_num { get; set; }
		public int Dial_Mode_cd { get; set; }
		public float Abandon_Target_pct { get; set; }
		public float Abandon_Alert_pct { get; set; }
		public int MaxCallSetupSecs { get; set; }
		public int MaxWrapSecs { get; set; }
		public int AgentQType_Id { get; set; }
		public int QMaxTime { get; set; }
		public int Priority { get; set; }
		public int FeedType { get; set; }

		public int TargetQTime { get; set; }
		public int TargetQLen { get; set; }
		public int WaitMessageId { get; set; }
		public int CircularAODTableList { get; set; }
		public int CallBackDays { get; set; }
		public int RedialHandledBy { get; set; }
		public int TimedPreviewFlag { get; set; }
		public int PreviewTimeoutInSecs { get; set; }
		public int NextServiceId { get; set; }
		public DateTime ReEstablishDt { get; set; }
		public int CBReloadOptionId { get; set; }
		public int CBDialModeFlag { get; set; }
		public int CBAgentToServicePromoteFlag { get; set; }
		public int CFLogAgentsInServiceFlag { get; set; }
		public int CBElapsedTimeAfterExpiration { get; set; }
		public int CBServiceCallbackFlag { get; set; }
		public int RecordingTypeInterval { get; set; }
		public int RecordingTypeId { get; set; }
		public int RecordingScheduleId { get; set; }
		public int PBXCTIServiceId { get; set; }
		public int NumOfCallsDialedPerSec { get; set; }
		public int ContinueRecordingFlag { get; set; }
		public int TransientCalls { get; set; }
		public int ExpectedHitRate { get; set; }
		public int AbandonTolerance { get; set; }
		public int DampeningFactor { get; set; }
		public int SlowDownFactor { get; set; }
		public int QuotaCriteriaFlag { get; set; }
		public int MaximumQuotaValue { get; set; }
		public int ScreenCaptureFlag { get; set; }
		public int Disp_Id { get; set; }
		public int ContinueDialOnAudioFlag { get; set; }
		public int SupercedeFlag { get; set; }
		public int ShortCallInterval { get; set; }
		public int ServiceLevelInterval { get; set; }
		public int RollingServiceLevelInterval { get; set; }
		public int ServiceLevelCalc { get; set; }
		public int MultiLineReRouteDestTypeVoice { get; set; }
		public int MultiLineReRouteDestVoice { get; set; }
		public int Ofcom_f { get; set; }
		public int AM_Disp_Id { get; set; }
		public int AcceptCBCParallel { get; set; }
		public int OfcomSettingsId { get; set; }
		public int UseRNA_Nums { get; set; }

		public int Ring_No_Ans_Rings_Secs { get; set; }
		public int AllowNonWhiteListNumber { get; set; }
		public int AllowCTIExternalRouting { get; set; }
		public int RouteRequestTimeout { get; set; }
	}
}
