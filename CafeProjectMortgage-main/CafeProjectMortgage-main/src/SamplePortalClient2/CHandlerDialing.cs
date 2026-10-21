// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerDialing
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerDialing : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerDialing(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDDialing payload = (UDDialing) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerDialing.ProcessEvent() -  Dialing CallId< " + payload.callID.ToString() + ">, CallType <" + payload.statusReason.ToString() + "> Type<" + this.GetType().ToString() + " >");
      if (payload.statusReason == 8)
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetApplicationState(AgentStateId.asDIALING, pEvent, byKey);
        this.mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, byKey.FirstPartyCall);
      }
      else if (payload.statusReason == 17 || payload.statusReason == 10)
      {
        C3WayCall3rdParty consultationCall = this.mpApp.ThreeWayCallManager.PendingConsultationCall;
        this.mpApp.ThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) null;
        consultationCall.callID = payload.callID;
        consultationCall.mediaType = (AgentMediaType) payload.statusReason;
        this.mpApp.ThreeWayCallManager.Add(consultationCall.callID, (C3WayCall) consultationCall);
        this.mpEventHelper.SetApplicationState(AgentStateId.asDIALING_CONSULTATION, pEvent, consultationCall.ParentCall);
        this.mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, (C3WayCall) consultationCall);
      }
      else
      {
        CState currentState = this.mpApp.CurrentState;
        CCall pendingManualCall = this.mpApp.CallManager.PendingManualCall;
        this.mpApp.CallManager.PendingManualCall = (CCall) null;
        pendingManualCall.callID = payload.callID;
        this.mpApp.CallManager.Add(pendingManualCall.CallID, pendingManualCall);
        ++this.mpApp.AssignedServices.GetByKey((object) pendingManualCall.serviceID).totalCalls;
        this.mpApp.CallManager.CurrentCall = pendingManualCall;
        this.mpEventHelper.SetApplicationState(AgentStateId.asDIALING, pEvent, pendingManualCall);
        this.mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, pendingManualCall.FirstPartyCall);
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
