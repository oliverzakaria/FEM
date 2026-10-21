// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallState
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.Drawing;

namespace SamplePortalClient
{
  public class CCallState : CState
  {
    protected CCallGeneric mpCall;
    private LogFile logFile = new LogFile();

    internal CCallGeneric Call => this.mpCall;

    public override bool EnableHangup
    {
      get
      {
        if (this.mpCall is C3WayCall1stParty)
        {
          if (((C3WayCall) this.mpCall).ParentCall is CCallVoice)
          {
            if (((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateHeld)
              return false;
            if (((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateActive)
              return this.mpApp.AssignedServices.GetByKey((object) ((C3WayCall) this.mpCall).ParentCall.ServiceID).AllowHangup;
            if (((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateInactive)
              return false;
            if (this.mpCall.currentState is CStateHeld)
              return !(((C3WayCall) this.mpCall).ParentCall is CCallRemainingConsultation) && !(((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateConsulting);
            if (((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateConsulting)
              return this.mpApp.AssignedServices.GetByKey((object) ((C3WayCall) this.mpCall).ParentCall.ServiceID).AllowHangup;
            return ((C3WayCall) this.mpCall).ParentCall is CCallRemainingConsultation || this.mpApp.AssignedServices.GetByKey((object) ((C3WayCall) this.mpCall).ParentCall.ServiceID).AllowHangup;
          }
          return ((C3WayCall) this.mpCall).ParentCall is CCallChat && ((CServiceChat) this.mpApp.AssignedServices.GetByKey((object) ((C3WayCall) this.mpCall).ParentCall.ServiceID)).AllowChatDisconnect;
        }
        return this.mpCall is C3WayCall3rdParty ? (this.mpCall.currentState is CStateHeld ? !(((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateConsulting) : ((C3WayCall) this.mpCall).ParentCall.CurrentState is CStateConsulting || this.mpApp.AssignedServices.GetByKey((object) ((C3WayCall) this.mpCall).ParentCall.ServiceID).AllowConsultHangup) : !(this.mpCall is C3WayCallConference) && this.mpCall is CCall && ((CCall) this.mpCall).FirstPartyCall.CurrentState.EnableHangup;
      }
    }

    public override bool EnableHold
    {
      get
      {
        if (this.mpCall is C3WayCall1stParty)
        {
          if (!(((C3WayCall) this.mpCall).ParentCall is CCallVoice))
            return false;
          CCallVoice parentCall = (CCallVoice) ((C3WayCall) this.mpCall).ParentCall;
          if (parentCall is CCallRemainingConsultation)
            return true;
          if (parentCall.CurrentState is CStateActiveInternal || parentCall.CurrentState is CStateConference)
            return false;
          CState currentState = parentCall.CurrentState;
          if (false)
            return false;
          if (this.mpCall.CurrentState is CStateHeld)
          {
            if (parentCall.ThirdPartyCall.CurrentState is CStateActive)
              return false;
            return !(parentCall.CurrentState is CStateConsulting) || true;
          }
          return parentCall.CurrentState is CStateConsulting || this.mpApp.AssignedServices.GetByKey((object) parentCall.ServiceID).AllowHold;
        }
        if (this.mpCall is C3WayCall3rdParty)
        {
          CCallVoice parentCall = (CCallVoice) ((C3WayCall) this.mpCall).ParentCall;
          if (parentCall.CurrentState is CStateConference)
            return false;
          if (this.mpCall.CurrentState is CStateHeld)
          {
            if (parentCall.FirstPartyCall.CurrentState is CStateActive)
              return false;
            return !(parentCall.CurrentState is CStateConsulting) || true;
          }
          return !(parentCall.CurrentState is CStateConsulting) || true;
        }
        return this.mpCall is CCall && ((CCall) this.mpCall).FirstPartyCall.CurrentState.EnableHold;
      }
    }

    internal CCallState(
      AgentStateId eId,
      string sDescription,
      Color pBackColor,
      Color pForeColor,
      CApp pApp,
      CCallGeneric pCall)
      : base(eId, sDescription, pBackColor, pForeColor, pApp)
    {
      this.mpCall = pCall;
    }

    internal override void Enter(CAgentEvent pEvent)
    {
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CCallState.Enter() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + this.Description + "> Call ID <" + this.mpCall.callID.ToString() + ">  Type<" + this.GetType().ToString() + " >");
      Console.WriteLine("Entering {0}({1}), {2}<{3}>\t[{4}]", (object) this.Description, (object) (int) this.Id, (object) this.mpCall.GetType(), (object) this.mpCall.callID, (object) this.GetType());
    }

    internal override void Exit()
    {
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CCallState.Exit() -  Description <" + this.Description + "> Call ID <" + this.mpCall.callID.ToString() + ">  Type<" + this.GetType().ToString() + " >");
      Console.WriteLine("Exiting {0}({1}), {2}<{3}>\t[{4}]", (object) this.Description, (object) (int) this.Id, (object) this.mpCall.GetType(), (object) this.mpCall.callID, (object) this.GetType());
    }
  }
}
