// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStatePreview
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStatePreview : CCallState
  {
    public override bool EnableDial => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowDial;

    public override bool EnableNextCall => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowNextCall;

    public override bool EnableHold => false;

    public override bool EnableHangup => false;

    internal CStatePreview(
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
