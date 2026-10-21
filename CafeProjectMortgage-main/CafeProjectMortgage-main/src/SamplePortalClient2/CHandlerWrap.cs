// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerWrap
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using Utilities;

namespace SamplePortalClient
{
  internal class CHandlerWrap : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerWrap(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDWrap payload = (UDWrap) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerWrap.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> CallID<" + payload.callID.ToString() + "> Reason<" + payload.statusReason.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      CCall byKey1 = this.mpApp.CallManager.GetByKey(payload.callID);
      ProcessChecker.LastCallClearCallId = byKey1.CallID;
      CService byKey2 = this.mpApp.AssignedServices.GetByKey((object) byKey1.ServiceID);
      if (byKey1.MediaType == AgentMediaType.amINTERNAL_CONSULT)
        this.mpApp.DisposeCall(this.mpApp.CurrentCall, (CDisposition) null);
      if (byKey2.RequireWrap == WrapType.wtOPTIONAL && !byKey2.RequireDisposition)
        this.mpApp.DisposeCall(this.mpApp.CurrentCall, (CDisposition) null);
      else
        this.mpEventHelper.SetApplicationState(AgentStateId.asWRAP, pEvent, byKey1);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
