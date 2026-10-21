// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerCallClear
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;
using Utilities;

namespace SamplePortalClient
{
  internal class CHandlerCallClear : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerCallClear(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDCallClear payload = (UDCallClear) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerCallClear.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Call ID<" + payload.callID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      Console.WriteLine("Processing Call Clear event...CallId<{0}>\t[{1}]", (object) payload.callID, (object) this.GetType());
      ProcessChecker.LastCallClearCallId = payload.callID;
      if (this.mpApp.CallManager.Contains((object) payload.callID))
      {
        CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
        switch (byKey)
        {
          case CCallRemainingConsultation _:
            this.mpApp.CallManager.RemoveByKey(byKey.CallID);
            this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey);
            this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.FirstPartyCall);
            this.mpEventHelper.FireStateChangeEvents();
            this.mpApp.CallManager.CurrentCall = ((CCallRemainingConsultation) byKey).Root3rdPartyCall.ParentCall;
            this.mpEventHelper.SetApplicationState(this.mpApp.CallManager.CurrentCall.CurrentState.Id, pEvent, this.mpApp.CallManager.CurrentCall);
            this.mpEventHelper.SetCallState(this.mpApp.CallManager.CurrentCall.FirstPartyCall.CurrentState.Id, pEvent, this.mpApp.CallManager.CurrentCall.FirstPartyCall);
            this.mpApp.OnCallActivated(new CCallActivatedArgs(byKey, this.mpApp.CallManager.CurrentCall));
            break;
          case CCallVoice _:
            CCallVoice ccallVoice = (CCallVoice) byKey;
            if (ccallVoice.ThirdPartyCall.CurrentState != null && !(ccallVoice.ThirdPartyCall.CurrentState is CStateInactive))
            {
              this.mpApp.ThreeWayCallManager.RemoveByKey(ccallVoice.ThirdPartyCall.CallID);
              CState currentState = ccallVoice.ThirdPartyCall.CurrentState;
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, ccallVoice.ThirdPartyCall);
              this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, ccallVoice.ThirdPartyCall.ParentCall);
              this.mpEventHelper.FireStateChangeEvents();
              CCallRemainingConsultation pCall = new CCallRemainingConsultation((C3WayCall3rdParty) ccallVoice.ThirdPartyCall);
              this.mpApp.CallManager.Add(pCall.CallID, (CCall) pCall);
              this.mpApp.CallManager.CurrentCall = (CCall) pCall;
              if (currentState is CStateActive && ((C3WayCall3rdParty) ccallVoice.ThirdPartyCall).MediaType == AgentMediaType.amINTERNAL_CONSULT)
                this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, (CCall) pCall);
              else
                this.mpEventHelper.SetApplicationState(currentState.Id, pEvent, (CCall) pCall);
              this.mpEventHelper.SetCallState(currentState.Id, pEvent, pCall.FirstPartyCall);
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.ThirdPartyCall);
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.ConferenceCall);
              this.mpApp.OnCallActivated(new CCallActivatedArgs(ccallVoice.ThirdPartyCall.ParentCall, this.mpApp.CallManager.CurrentCall));
              break;
            }
            if (this.mpEventHelper.CurrentState is CStateActiveInternal)
            {
              this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey);
              this.mpEventHelper.SetCallState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey.FirstPartyCall);
            }
            else if (this.mpEventHelper.CurrentState is CStateWrap)
            {
              this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey);
              this.mpEventHelper.SetCallState(AgentStateId.asACTIVE_INTERNAL, pEvent, byKey.FirstPartyCall);
            }
            else
            {
              this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey);
              this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.FirstPartyCall);
            }
            break;
          default:
            this.mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, byKey);
            this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey.FirstPartyCall);
            break;
        }
      }
      else if (this.mpApp.ThreeWayCallManager.Contains((object) payload.callID))
      {
        C3WayCall byKey = this.mpApp.ThreeWayCallManager.GetByKey(payload.callID);
        this.mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, byKey);
        switch (byKey)
        {
          case C3WayCall3rdParty _:
            this.mpEventHelper.SetApplicationState(byKey.ParentCall.FirstPartyCall.CurrentState.Id, pEvent, byKey.ParentCall);
            this.mpEventHelper.SetCallState(byKey.ParentCall.FirstPartyCall.CurrentState.Id, pEvent, byKey.ParentCall.FirstPartyCall);
            break;
        }
        this.mpApp.ThreeWayCallManager.RemoveByKey(payload.callID);
      }
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
