// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerCallXferred
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CHandlerCallXferred : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerCallXferred(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDCallXferred payload = (UDCallXferred) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerCallXferred.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Call ID<" + payload.originalCallID.ToString() + "> New CallID<" + payload.newCallID.ToString() + "> Consult ID<" + payload.consultCallID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      Console.WriteLine("OriginalCallId<{0}>, ConsultCallId<{1}>, NewCallId<{2}>\t[{3}]", new object[4]
      {
        (object) payload.originalCallID,
        (object) payload.consultCallID,
        (object) payload.newCallID,
        (object) this.GetType()
      });
      if (!this.mpApp.CallManager.Contains((object) payload.consultCallID))
        return;
      CCall byKey = this.mpApp.CallManager.GetByKey(payload.consultCallID);
      this.mpApp.CallManager.RemoveByKey(payload.consultCallID);
      byKey.callID = payload.newCallID;
      this.mpApp.CallManager.Add(byKey.callID, byKey);
    }
  }
}
