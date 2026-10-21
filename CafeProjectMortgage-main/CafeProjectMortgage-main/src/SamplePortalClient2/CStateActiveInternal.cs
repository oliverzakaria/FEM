// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateActiveInternal
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateActiveInternal : CCallState
  {
    public override bool EnablePlay => this.mpCall is C3WayCall ? ((C3WayCall) this.mpCall).ParentCall.CurrentState.EnablePlay : this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowPlay;

    public override bool EnableRecord
    {
      get
      {
        if (this.mpCall is C3WayCall)
          return ((C3WayCall) this.mpCall).ParentCall.CurrentState.EnableRecord;
        return this.mpCall is CCallRemainingConsultation && this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowRecord;
      }
    }

    internal CStateActiveInternal(
      AgentStateId eId,
      string sDescription,
      Color pBackColor,
      Color pForeColor,
      CApp pApp,
      CCallGeneric pCall)
      : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall)
    {
    }
  }
}
