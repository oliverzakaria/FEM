// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallManager
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CCallManager : CList
  {
    private CCall mpCurrentCall;
    private CCall mpPendingManualCall;

    internal CCall CurrentCall
    {
      get => this.mpCurrentCall;
      set => this.mpCurrentCall = value;
    }

    internal CCall PendingManualCall
    {
      get => this.mpPendingManualCall;
      set => this.mpPendingManualCall = value;
    }

    internal CCallManager()
    {
    }

    internal void ClearAll() => this.Clear();

    internal void Add(int key, CCall value) => this.Add((object) key, (object) value);

    internal void RemoveByKey(int key) => this.RemoveByKey((object) key);

    internal new void RemoveAt(int index) => base.RemoveAt(index);

    internal CCall GetByKey(int key) => (CCall) this.GetByKey((object) key);

    internal CCall this[int index] => (CCall) base[index];

    internal CCall CreateCall(UDScreenPop pCall)
    {
      switch (pCall.callInfo.otherData.callType)
      {
        case 2:
          return (CCall) new CCallAOD(pCall);
        case 17:
          return (CCall) new CCallChat(pCall);
        case 19:
          return (CCall) new CCallEmail(pCall);
        case 20:
          return (CCall) new CCallEmail(pCall);
        case 21:
          return (CCall) new CCallEmail(pCall);
        default:
          return (CCall) new CCallVoice(pCall);
      }
    }

    internal CCall CreateCall(UDPreview pCall) => (CCall) new CCallAOD(pCall);

    public void CallRecord()
    {
    }

    public void PauseRecord()
    {
    }

    public void CancelRecord()
    {
    }
  }
}
