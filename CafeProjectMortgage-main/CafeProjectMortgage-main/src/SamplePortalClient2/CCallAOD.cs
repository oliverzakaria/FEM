// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallAOD
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CCallAOD : CCallVoice
  {
    internal int callTableRecordNum;
    internal int storeManagerId;
    internal string tableName;
    internal int targetManagerId;
    internal int callBackFlag;
    internal string callbackMemo;
    internal int callbackDialMode;
    internal bool callbackFailed;

    public int CallTableRecordNum => this.callTableRecordNum;

    public int StoreManagerId => this.storeManagerId;

    public string TableName => this.tableName;

    public int TargetManagerId => this.targetManagerId;

    public string CallbackMemo => this.callbackMemo;

    public int CallbackDialMode => this.callbackDialMode;

    public bool CallbackFailed => this.callbackFailed;

    internal CCallAOD(UDScreenPop pCall)
      : base(pCall)
    {
      this.callTableRecordNum = pCall.callInfo.aodData.callTableRecordNum;
      this.storeManagerId = pCall.callInfo.aodData.storeManagerId;
      this.tableName = pCall.callInfo.aodData.tableName;
      this.targetManagerId = pCall.callInfo.aodData.targetManagerId;
      this.callBackFlag = pCall.callInfo.callbackData.callBackFlag;
      this.callbackMemo = pCall.callInfo.callbackData.callbackMemo;
      this.callbackDialMode = pCall.callInfo.callbackData.dialModeCode;
      this.callbackFailed = false;
    }

    internal CCallAOD(UDPreview pCall)
      : base(pCall)
    {
      this.callTableRecordNum = pCall.callInfo.aodData.callTableRecordNum;
      this.storeManagerId = pCall.callInfo.aodData.storeManagerId;
      this.tableName = pCall.callInfo.aodData.tableName;
      this.targetManagerId = pCall.callInfo.aodData.targetManagerId;
      this.callBackFlag = pCall.callInfo.callbackData.callBackFlag;
      this.callbackMemo = pCall.callInfo.callbackData.callbackMemo;
      this.callbackDialMode = pCall.callInfo.callbackData.dialModeCode;
      this.callbackFailed = this.eventCode == 54;
    }
  }
}
