// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerConsulting
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerConsulting : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerConsulting(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDConsult payload = (UDConsult) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerConsulting.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Original Call ID<" + payload.originalCallID.ToString() + "> Consult Agent Index<" + payload.consultedAgentIndex.ToString() + "> Consult ID<" + payload.consultCallID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (!this.mpApp.ThreeWayCallManager.Contains((object) payload.consultCallID))
        return;
      C3WayCall byKey = this.mpApp.ThreeWayCallManager.GetByKey(payload.consultCallID);
      this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey);
      if (byKey.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
        this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, byKey.ParentCall.FirstPartyCall);
      this.mpEventHelper.SetApplicationState(AgentStateId.asCONSULTING, pEvent, byKey.ParentCall);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
