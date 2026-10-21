// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerConference
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerConference : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerConference(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDConference payload = (UDConference) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerConference.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Call ID<" + payload.originalCallID.ToString() + "> Conference CallID<" + payload.conferenceCallID.ToString() + "> Consult ID<" + payload.consultCallID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      CCallVoice byKey = (CCallVoice) this.mpApp.CallManager.GetByKey(payload.originalCallID);
      byKey.ConferenceCall.callID = payload.conferenceCallID;
      this.mpApp.ThreeWayCallManager.Add(byKey.ConferenceCall.CallID, byKey.ConferenceCall);
      this.mpEventHelper.SetApplicationState(AgentStateId.asCONFERENCE, pEvent, (CCall) byKey);
      this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.FirstPartyCall);
      this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.ConferenceCall);
      this.mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, byKey.ThirdPartyCall);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
