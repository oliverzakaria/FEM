// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerCallReleasedXferred
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerCallReleasedXferred : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerCallReleasedXferred(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDCallReleasedXferred payload = (UDCallReleasedXferred) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerCallReleasedXferred.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Call ID<" + payload.callID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (this.mpApp.CallManager.Contains((object) payload.callID))
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey);
        this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.FirstPartyCall);
      }
      else if (this.mpApp.ThreeWayCallManager.Contains((object) payload.callID))
      {
        C3WayCall byKey = this.mpApp.ThreeWayCallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey.ParentCall);
        this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.ParentCall.FirstPartyCall);
        if (byKey is C3WayCallConference)
        {
          this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey);
          this.mpApp.ThreeWayCallManager.RemoveByKey(payload.callID);
        }
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
