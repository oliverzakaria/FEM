// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public class CService : CSimpleService
  {
    internal string application;
    internal bool removed;
    internal int dialMask;
    internal bool allowHold;
    internal bool allow3Way;
    internal bool allowBlindXfer;
    internal bool allowWarmXfer;
    internal bool allowConference;
    internal bool allowConsult;
    internal bool allowConsultHangup;
    internal bool allowRecord;
    internal bool allowPlay;
    internal int totalCalls;
    internal bool allowDial;
    internal bool allowHangup;
    internal int wrapAlarmSecs;
    internal WrapType requireWrap;
    internal bool allowNextCall;
    internal int noDispMaxWrapSecs;
    internal bool showCallData;
    internal int showCallDataSecs;
    internal int callDataDefId;
    internal bool requireDisposition;
    internal CDispositionPlan dispositionPlan;
    internal int wrapMinSecs;
    internal int wrapMaxSecs;
    internal int wrapWarningDelay;
    internal int previewTimeoutSecs;
    internal int timedpreviewflag;
    internal int wrapExceedAction;
    internal int warmtransfer;
    internal int serviceid;
    internal int displayCallbackTimeWarningF;
    internal int cbservicecallbackflag;
    public int cbselfcallbackflag;
    internal int allowphonechangeinpreview;
    internal int callbackDays;

    public string Application => this.application;

    public bool Removed => this.removed;

    public int DialMask => this.dialMask;

    public bool AllowHold => this.allowHold;

    public bool Allow3Way => this.allow3Way;

    public bool AllowBlindXfer => this.allowBlindXfer;

    public bool AllowWarmXfer => this.allowWarmXfer;

    public bool AllowConference => this.allowConference;

    public bool AllowConsult => this.allowConsult;

    public bool AllowConsultHangup => this.allowConsultHangup;

    public bool AllowRecord => this.allowRecord;

    public bool AllowPlay => this.allowPlay;

    public int TotalCalls => this.totalCalls;

    public bool AllowDial => this.allowDial;

    public bool AllowHangup => this.allowHangup;

    public int WrapAlarmSecs => this.wrapAlarmSecs;

    public WrapType RequireWrap => this.requireWrap;

    public bool AllowNextCall => this.allowNextCall;

    public int NoDispMaxWrapSecs => this.noDispMaxWrapSecs;

    public bool ShowCallData => this.showCallData;

    public int ShowCallDataSecs => this.showCallDataSecs;

    public int CallDataDefId => this.callDataDefId;

    public bool RequireDisposition => this.requireDisposition;

    public int CallbackDays => this.callbackDays;

    public int WrapMinSecs => this.wrapMinSecs;

    public int WrapMaxSecs => this.wrapMaxSecs;

    public int WrapWarningDelaySecs => this.wrapWarningDelay;

    public int PreviewTimoutSecs => this.previewTimeoutSecs;

    public int Timedpreviewflag => this.timedpreviewflag;

    public int WrapExceedAction => this.wrapExceedAction;

    public int Warmtransfer => this.warmtransfer;

    public int DisplayCallbackTimeWarningF => this.displayCallbackTimeWarningF;

    public int Cbservicecallbackflag => this.cbservicecallbackflag;

    public int Allowphonechangeinpreview => this.allowphonechangeinpreview;

    public CDispositionPlan DispositionPlan => this.dispositionPlan;

    internal CService()
    {
    }

    public override string ToString() => this.serviceId.ToString() + "\t" + this.serviceName + "\t" + this.serviceType.ToString();
  }
}
