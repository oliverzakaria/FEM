// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerActive
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerActive : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerActive(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDActive payload = (UDActive) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerActive.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Call ID<" + payload.callID.ToString() + "> Status Reason<" + payload.statusReason.ToString() + "> Type<" + this.GetType().ToString() + " >");
      if (this.mpApp.CallManager.Contains((object) payload.callID))
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        if (byKey.CurrentState is CStateHeld)
        {
          if (byKey.MediaType == AgentMediaType.amINTERNAL_MANUAL)
            this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey);
          else
            this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE, pEvent, byKey);
          this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.FirstPartyCall);
        }
        else if (byKey.CurrentState is CStateDialingConsultation || byKey.CurrentState is CStateConsulting || byKey.CurrentState is CStateConference)
        {
          this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.FirstPartyCall);
          if (((CCallVoice) byKey).ThirdPartyCall.CurrentState is CStateHeld)
            this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, ((CCallVoice) byKey).ThirdPartyCall);
        }
        else
        {
          byKey.mediaType = (AgentMediaType) payload.mediaType;
          switch (byKey.MediaType)
          {
            case AgentMediaType.amINTERNAL_CONSULT:
            case AgentMediaType.amINTERNAL_MANUAL:
              this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey);
              break;
            case AgentMediaType.amINBOUND_CHAT:
              ((CCallChat) byKey).chatServerIP = payload.IPAddress;
              ((CCallChat) byKey).chatServerPort = payload.portNumber;
              this.mpApp.ConnectToChatServer((CCallChat) byKey);
              this.mpEventHelper.SetApplicationState(AgentStateId.asCHATTING, pEvent, byKey);
              break;
            default:
              this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE, pEvent, byKey);
              break;
          }
          this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.FirstPartyCall);
          if (byKey is CCallVoice)
          {
            CCallVoice ccallVoice = (CCallVoice) byKey;
            if (ccallVoice.ThirdPartyCall.CurrentState == null)
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, ccallVoice.ThirdPartyCall);
            if (ccallVoice.ConferenceCall.CurrentState == null)
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, ccallVoice.ConferenceCall);
          }
        }
      }
      else if (this.mpApp.ThreeWayCallManager.Contains((object) payload.callID))
      {
        C3WayCall byKey = this.mpApp.ThreeWayCallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey);
        if (byKey.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
          this.mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, byKey.ParentCall.FirstPartyCall);
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
