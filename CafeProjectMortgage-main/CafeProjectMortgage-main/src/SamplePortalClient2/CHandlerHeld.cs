// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerHeld
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerHeld : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerHeld(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDHeld payload = (UDHeld) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerHeld.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> CallID<" + payload.callID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (this.mpApp.CallManager.Contains((object) payload.callID))
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        if (!(byKey.CurrentState is CStateDialingConsultation) && !(byKey.CurrentState is CStateConsulting) && !(byKey.CurrentState is CStateConference))
          this.mpEventHelper.SetApplicationState(AgentStateId.asHELD, pEvent, byKey);
        this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, byKey.FirstPartyCall);
        if (((CCallVoice) byKey).ThirdPartyCall.CurrentState is CStateHeld)
          this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, ((CCallVoice) byKey).ThirdPartyCall);
      }
      else if (this.mpApp.ThreeWayCallManager.Contains((object) payload.callID))
      {
        C3WayCall byKey = this.mpApp.ThreeWayCallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, byKey);
        if (byKey.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
          this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, byKey.ParentCall.FirstPartyCall);
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
