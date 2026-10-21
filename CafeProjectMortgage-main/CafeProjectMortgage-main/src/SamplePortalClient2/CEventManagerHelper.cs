// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CEventManagerHelper
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.Collections;
using System.Drawing;
using Utilities;

namespace SamplePortalClient
{
  internal class CEventManagerHelper
  {
    private CState mpCurrentState;
    private CApp mpApp;
    private Queue mpStateChangeQueue = new Queue();
    private LogFile logFile = new LogFile();

    internal CState CurrentState => this.mpCurrentState;

    internal CEventManagerHelper(CApp pApp)
    {
      this.mpApp = pApp;
      this.mpCurrentState = this.CreateState(AgentStateId.asLOGGED_OUT);
    }

    internal void RemoveRemainingCalls()
    {
      try
      {
        int lastCallClearCallId = ProcessChecker.LastCallClearCallId;
        this.logFile.LogMessageToFile(" |INFO| CEventManager.RemoveRemainingCalls(), CallIdToClear <" + lastCallClearCallId.ToString() + ">...");
        bool flag1 = false;
        bool flag2 = ProcessChecker.CheckAndSetIsLine1(lastCallClearCallId);
        if (!flag2)
        {
          ProcessChecker.Line2Busy = false;
          if (ProcessChecker.Line1Busy)
            ProcessChecker.ActiveLine = 1;
        }
        else
        {
          ProcessChecker.Line1Busy = false;
          if (ProcessChecker.Line2Busy)
            ProcessChecker.ActiveLine = 2;
        }
        this.logFile.LogMessageToFile(" |INFO| CEventManagerHelper.RemoveRemainingCalls(), Active line is [ " + ProcessChecker.ActiveLine.ToString() + "]  .");
        if (this.mpApp.CallManager.Count > 0)
        {
          LogFile logFile1 = this.logFile;
          string[] strArray1 = new string[7]
          {
            " |INFO| CEventManager.RemoveRemainingCalls(), Current service <",
            this.mpApp.CurrentService?.ToString(),
            "> , Required Wrap <",
            null,
            null,
            null,
            null
          };
          WrapType requireWrap = this.mpApp.CurrentService.RequireWrap;
          strArray1[3] = requireWrap.ToString();
          strArray1[4] = "> , Call Type<";
          AgentCallType callType = this.mpApp.CurrentCall.CallType;
          strArray1[5] = callType.ToString();
          strArray1[6] = ">...";
          string message1 = string.Concat(strArray1);
          logFile1.LogMessageToFile(message1);
          CCall byKey1 = this.mpApp.CallManager.GetByKey(lastCallClearCallId);
          if (byKey1 == null)
          {
            this.mpApp.CallManager.CurrentCall = this.GetOtherCall(lastCallClearCallId);
          }
          else
          {
            if (flag2 && this.mpApp.AssignedServices.Contains((object) byKey1.serviceID))
            {
              CService byKey2 = this.mpApp.AssignedServices.GetByKey((object) byKey1.serviceID);
              if (byKey2 != null)
              {
                LogFile logFile2 = this.logFile;
                string[] strArray2 = new string[7]
                {
                  " |INFO| CEventManager.RemoveRemainingCalls(), fetched service <",
                  byKey2?.ToString(),
                  "> , Required Wrap <",
                  null,
                  null,
                  null,
                  null
                };
                requireWrap = byKey2.RequireWrap;
                strArray2[3] = requireWrap.ToString();
                strArray2[4] = "> , Call Type<";
                callType = byKey1.CallType;
                strArray2[5] = callType.ToString();
                strArray2[6] = ">...";
                string message2 = string.Concat(strArray2);
                logFile2.LogMessageToFile(message2);
                if (byKey2.RequireWrap == WrapType.wtREQUIRED)
                  flag1 = true;
              }
            }
            if (byKey1.CallType != AgentCallType.acDID & flag1)
              return;
            Console.WriteLine("Removing call <{0}>...", (object) byKey1.CallID);
            this.logFile.LogMessageToFile(" |INFO| CEventManager.RemoveRemainingCalls(), Removing call <" + byKey1.CallID.ToString() + ">...");
            this.mpApp.CallManager.RemoveByKey(byKey1.CallID);
          }
        }
        else
          this.mpApp.CallManager.CurrentCall = (CCall) null;
      }
      catch (Exception ex)
      {
        this.logFile.LogMessageToFile(" |ERROR| CEventManager.RemoveRemainingCalls(),  <" + ex?.ToString() + ">...");
      }
    }

    internal CCall GetOtherCall(int callId)
    {
      CCall otherCall = (CCall) null;
      foreach (CCall ccall in (CList) this.mpApp.CallManager)
      {
        if (ccall.CallID != callId)
        {
          otherCall = ccall;
          break;
        }
      }
      this.logFile.LogMessageToFile(" |INFO| CEventManager.GetOtherCall(),  Current call id changed to <" + otherCall.CallID.ToString() + ">...");
      return otherCall;
    }

    private CState CreateState(AgentStateId eState, CCallGeneric pCall)
    {
      if (pCall == null)
        throw new ArgumentNullException(nameof (pCall), "The creation of state <" + eState.ToString() + "> requires the Call parameter.");
      switch (eState)
      {
        case AgentStateId.asDIALING:
          return (CState) new CStateDialing(AgentStateId.asDIALING, "DIALING", Color.Cyan, Color.Black, this.mpApp, pCall);
        case AgentStateId.asDIALING_CONSULTATION:
          return (CState) new CStateDialingConsultation(AgentStateId.asDIALING_CONSULTATION, "DIALING CONSULT", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        case AgentStateId.asRINGING:
          return (CState) new CStateRinging(AgentStateId.asRINGING, "RINGING", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        case AgentStateId.asINACTIVE:
          return (CState) new CStateInactive(AgentStateId.asINACTIVE, "INACTIVE", Color.LightGray, Color.Black, this.mpApp, pCall);
        case AgentStateId.asPREVIEW:
          return (CState) new CStatePreview(AgentStateId.asPREVIEW, "PREVIEW", Color.DarkOrange, Color.White, this.mpApp, pCall);
        case AgentStateId.asACTIVE:
          return (CState) new CStateActive(AgentStateId.asACTIVE, "ACTIVE", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        case AgentStateId.asACTIVE_INTERNAL:
          return (CState) new CStateActiveInternal(AgentStateId.asACTIVE_INTERNAL, "INTERNAL", Color.MediumSeaGreen, Color.White, this.mpApp, pCall);
        case AgentStateId.asWRAP:
          return (CState) new CStateWrap(AgentStateId.asWRAP, "WRAP", Color.Yellow, Color.Black, this.mpApp, pCall);
        case AgentStateId.asHELD:
          return (CState) new CStateHeld(AgentStateId.asHELD, "HELD", Color.Red, Color.White, this.mpApp, pCall);
        case AgentStateId.asCONSULTING:
          return (CState) new CStateConsulting(AgentStateId.asCONSULTING, "CONSULTING", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        case AgentStateId.asCONFERENCE:
          return (CState) new CStateConference(AgentStateId.asCONFERENCE, "CONFERENCE", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        case AgentStateId.asCHATTING:
          return (CState) new CStateChatting(AgentStateId.asCHATTING, "CHATTING", Color.LimeGreen, Color.Black, this.mpApp, pCall);
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    private CState CreateState(AgentStateId eState)
    {
      switch (eState)
      {
        case AgentStateId.asLOGGING_IN:
          return (CState) new CStateLoggingIn(AgentStateId.asLOGGING_IN, "LOGGING IN", Color.Gray, Color.Black, this.mpApp);
        case AgentStateId.asAUTHENTICATED:
          return (CState) new CStateAuthenticated(AgentStateId.asAUTHENTICATED, "AUTHENTICATED", Color.LightGray, Color.Black, this.mpApp);
        case AgentStateId.asIDLE:
          return (CState) new CStateIdle(AgentStateId.asIDLE, "IDLE", Color.Blue, Color.White, this.mpApp);
        case AgentStateId.asACTIVE_INTERNAL:
          return (CState) new CStateActiveInternal(AgentStateId.asACTIVE_INTERNAL, "INTERNAL", Color.MediumSeaGreen, Color.White, this.mpApp, (CCallGeneric) null);
        case AgentStateId.asWRAP:
          return (CState) new CStateWrap(AgentStateId.asWRAP, "WRAPPED", Color.Red, Color.White, this.mpApp, (CCallGeneric) null);
        case AgentStateId.asHELD:
          return (CState) new CStateHeld(AgentStateId.asHELD, "HELD", Color.Red, Color.White, this.mpApp, (CCallGeneric) null);
        case AgentStateId.asWAITING:
          return (CState) new CStateWaiting(AgentStateId.asWAITING, "WAITING", Color.Cyan, Color.Black, this.mpApp);
        case AgentStateId.asLOGGED_OUT:
          return (CState) new CStateLoggedOut(AgentStateId.asLOGGED_OUT, "LOGGED OUT", Color.Gray, Color.Black, this.mpApp);
        case AgentStateId.asNOT_READY:
          return (CState) new CStateNotReady(AgentStateId.asNOT_READY, "NOT READY", Color.Red, Color.White, this.mpApp);
        case AgentStateId.asPARKED:
          return (CState) new CStateParked(AgentStateId.asPARKED, "PARKED", Color.Red, Color.White, this.mpApp);
        default:
          throw new ArgumentOutOfRangeException();
      }
    }

    internal void FireStateChangeEvents()
    {
      try
      {
        while (this.mpStateChangeQueue.Count > 0)
        {
          object pArgs = this.mpStateChangeQueue.Dequeue();
          switch (pArgs)
          {
            case CUnfocusedCallStateChangeArgs _:
              this.mpApp.OnUnfocusedCallStateChange((CUnfocusedCallStateChangeArgs) pArgs);
              break;
            case CCallStateChangeArgs _:
              this.mpApp.OnCallStateChange((CCallStateChangeArgs) pArgs);
              break;
            case CUnfocusedStateChangeArgs _:
              this.mpApp.OnUnfocusedStateChange((CUnfocusedStateChangeArgs) pArgs);
              break;
            case CStateChangeArgs _:
              this.mpApp.OnStateChange((CStateChangeArgs) pArgs);
              break;
            default:
              Console.WriteLine("Error - Invalid StateChange Args <" + pArgs.GetType()?.ToString() + ">.");
              break;
          }
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }

    internal void SetApplicationState(AgentStateId eState, CAgentEvent pEvent)
    {
      if (this.mpCurrentState != null)
        this.mpCurrentState.Exit();
      this.mpCurrentState = this.CreateState(eState);
      this.mpCurrentState.Enter(pEvent);
      this.mpStateChangeQueue.Enqueue((object) new CStateChangeArgs(this.mpCurrentState));
    }

    internal void SetApplicationState(AgentStateId eState, CAgentEvent pEvent, CCall pCall)
    {
      if (this.mpCurrentState != null && this.mpApp.CurrentCall == pCall)
        this.mpCurrentState.Exit();
      else if (pCall.currentState != null)
        pCall.currentState.Exit();
      pCall.currentState = this.CreateState(eState, (CCallGeneric) pCall);
      pCall.currentState.Enter(pEvent);
      if (pCall == this.mpApp.CurrentCall)
      {
        this.mpCurrentState = pCall.currentState;
        this.mpStateChangeQueue.Enqueue((object) new CStateChangeArgs(this.mpCurrentState));
      }
      else
        this.mpStateChangeQueue.Enqueue((object) new CUnfocusedStateChangeArgs(pCall.currentState, pCall));
    }

    internal void SetCallState(AgentStateId eState, CAgentEvent pEvent, C3WayCall pCall)
    {
      if (pCall.currentState != null)
        pCall.currentState.Exit();
      pCall.currentState = this.CreateState(eState, (CCallGeneric) pCall);
      pCall.currentState.Enter(pEvent);
      if (pCall.parentCall == this.mpApp.CurrentCall)
        this.mpStateChangeQueue.Enqueue((object) new CCallStateChangeArgs(pCall.currentState, pCall));
      else
        this.mpStateChangeQueue.Enqueue((object) new CUnfocusedCallStateChangeArgs(pCall.currentState, pCall));
    }

    internal void ProcessCallAppearance(CCall pCall)
    {
      if (!this.mpApp.AssignedServices.Contains((object) pCall.serviceID))
      {
        try
        {
          this.mpApp.AssignedServices.Load(pCall.serviceID);
        }
        catch (Exception ex)
        {
          this.logFile.LogMessageToFile(" |ERROR| CEventManagerHelper.ProcessCallAppearance() - Failed to process call " + ex.Message.ToString() + ex.StackTrace.ToString());
          Console.WriteLine(ex.StackTrace);
          pCall.serviceID = 0;
        }
      }
      this.mpApp.CallManager.Add(pCall.CallID, pCall);
      ++this.mpApp.AssignedServices.GetByKey((object) pCall.serviceID).totalCalls;
      this.mpApp.OnScreenpop(new CScreenpopArgs(pCall));
      if (this.mpApp.CallManager.Count != 1 && !Convert.ToBoolean(pCall.preemptive))
        return;
      CCall currentCall = this.mpApp.CallManager.CurrentCall;
      this.mpApp.CallManager.CurrentCall = pCall;
      if (currentCall != null)
        this.mpApp.OnCallActivated(new CCallActivatedArgs(currentCall, pCall));
    }
  }
}
