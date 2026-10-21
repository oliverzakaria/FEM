// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateConsulting
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateConsulting : CCallState
  {
    public override bool Enable3Way => true;

    public override bool EnableRecord => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowRecord;

    public override bool EnablePlay => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowPlay;

    public override bool EnableConference => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowConference;

    public override bool EnableTransfer => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowWarmXfer;

    internal CStateConsulting(
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
