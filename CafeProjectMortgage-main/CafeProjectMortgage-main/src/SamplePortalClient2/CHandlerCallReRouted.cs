// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerCallReRouted
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using Utilities;

namespace SamplePortalClient
{
  internal class CHandlerCallReRouted : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerCallReRouted(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDCallReRouted payload = (UDCallReRouted) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerCallReRouted.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Call ID<" + payload.callID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (this.mpApp.CallManager.Contains((object) payload.callID))
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        ProcessChecker.LastCallClearCallId = byKey.CallID;
        this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey);
        this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.FirstPartyCall);
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
