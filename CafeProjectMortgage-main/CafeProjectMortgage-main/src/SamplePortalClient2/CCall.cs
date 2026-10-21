// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCall
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CCall : CCallGeneric
  {
    internal int preemptive;
    internal int statusReason;
    internal int callCategory;
    internal AgentCallType callType;
    internal int eventCode;
    internal int originalServiceID;
    internal int serviceID;
    internal string ani;
    internal string callerID;
    internal string dnis;
    internal string firstName;
    internal string lastName;
    internal string phoneNumber;
    internal string callBackphoneNo;
    internal int CallbackFlag;
    internal string callBackMemo;
    internal UDCallInfoUserDefinedItem[] userDefinedItems;
    internal AgentMediaType mediaType;
    internal bool callbackRequested = false;
    internal bool exclusionRequested = false;
    internal C3WayCall firstPartyCall = (C3WayCall) new C3WayCall1stParty();
    internal bool responseRequired = false;
    internal bool rejectionReasonRequired = false;
    internal int responseTimeoutInSecs;
    internal bool playAudioAlert = false;

    internal override int callID
    {
      get => base.callID;
      set
      {
        base.callID = value;
        this.firstPartyCall.callID = value;
      }
    }

    public int Preemptive => this.preemptive;

    public int StatusReason => this.statusReason;

    public int CallCategory => this.callCategory;

    public AgentCallType CallType => this.callType;

    public int EventCode => this.eventCode;

    public int OriginalServiceID => this.originalServiceID;

    public int ServiceID => this.serviceID;

    public string Ani => this.ani;

    public string CallerID => this.callerID;

    public string Dnis => this.dnis;

    public string FirstName => this.firstName;

    public string LastName => this.lastName;

    public string PhoneNumber => this.phoneNumber;

    public string CallBackPhoneNumber => this.callBackphoneNo;

    public string CallBacMemo => this.callBackMemo;

    public int CallBackFlag => this.CallbackFlag;

    public UDCallInfoUserDefinedItem[] UserDefinedItems => this.userDefinedItems;

    public AgentMediaType MediaType => this.mediaType;

    public bool CallbackRequested => this.callbackRequested;

    public bool ExclusionRequested => this.exclusionRequested;

    public C3WayCall FirstPartyCall => this.firstPartyCall;

    public bool ResponseRequired => this.responseRequired;

    public bool RejectionReasonRequired => this.rejectionReasonRequired;

    public int ResponseTimeoutInSecs => this.responseTimeoutInSecs;

    public bool PlayAudioAlert => this.playAudioAlert;

    public CCall ParentCall { get; set; }

    internal CCall()
    {
      this.userDefinedItems = new UDCallInfoUserDefinedItem[20];
      for (int index = 0; index < this.userDefinedItems.Length; ++index)
      {
        this.userDefinedItems[index] = new UDCallInfoUserDefinedItem();
        this.userDefinedItems[index].key = "";
        this.userDefinedItems[index].value = "";
      }
      this.firstPartyCall.parentCall = this;
      this.callType = AgentCallType.acMANUAL;
    }

    internal CCall(UDScreenPop pCall)
    {
      this.callID = pCall.callID;
      this.preemptive = pCall.preemptive;
      this.statusReason = pCall.statusReason;
      this.callCategory = pCall.callInfo.otherData.callCategory;
      this.callType = (AgentCallType) pCall.callInfo.otherData.callType;
      this.eventCode = pCall.callInfo.otherData.eventCode;
      this.originalServiceID = pCall.callInfo.otherData.originalServiceID;
      this.serviceID = pCall.callInfo.otherData.serviceID;
      this.ani = pCall.callInfo.screenData.ani;
      this.callerID = pCall.callInfo.screenData.callerID;
      this.dnis = pCall.callInfo.screenData.dnis;
      this.firstName = pCall.callInfo.screenData.firstName;
      this.lastName = pCall.callInfo.screenData.lastName;
      this.phoneNumber = pCall.callInfo.screenData.phoneNumber;
      this.callBackphoneNo = pCall.callInfo.screenData.phoneNumber;
      this.userDefinedItems = pCall.callInfo.userDefinedData.userDefinedItems;
      this.responseRequired = pCall.requiredResponse;
      this.rejectionReasonRequired = pCall.requiredRejectReason;
      this.responseTimeoutInSecs = pCall.timeoutForAcceptCall;
      this.playAudioAlert = pCall.playAudioAlert;
      this.callBackMemo = pCall.callInfo.callbackData.callbackMemo;
      this.CallbackFlag = pCall.callInfo.callbackData.callBackFlag;
      this.firstPartyCall.parentCall = this;
    }

    internal CCall(UDPreview pCall)
    {
      this.callID = pCall.callID;
      this.preemptive = pCall.preemptive;
      this.statusReason = pCall.statusReason;
      this.callCategory = pCall.callInfo.otherData.callCategory;
      this.callType = (AgentCallType) pCall.callInfo.otherData.callType;
      this.eventCode = pCall.callInfo.otherData.eventCode;
      this.originalServiceID = pCall.callInfo.otherData.originalServiceID;
      this.serviceID = pCall.callInfo.otherData.serviceID;
      this.ani = pCall.callInfo.screenData.ani;
      this.callerID = pCall.callInfo.screenData.callerID;
      this.dnis = pCall.callInfo.screenData.dnis;
      this.firstName = pCall.callInfo.screenData.firstName;
      this.lastName = pCall.callInfo.screenData.lastName;
      this.phoneNumber = pCall.callInfo.screenData.phoneNumber;
      this.callBackphoneNo = pCall.callInfo.screenData.phoneNumber;
      this.userDefinedItems = pCall.callInfo.userDefinedData.userDefinedItems;
      this.callBackMemo = pCall.callInfo.callbackData.callbackMemo;
      this.CallbackFlag = pCall.callInfo.callbackData.callBackFlag;
      this.firstPartyCall.parentCall = this;
    }
  }
}
