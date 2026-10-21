// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateWrap
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateWrap : CCallState
  {
    public override bool EnableDial => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowDial;

    public override bool EnablePlay => this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).AllowPlay;

    public override bool EnableNextCall => true;

    public override bool EnableHold => false;

    public override bool EnableHangup => false;

    internal CStateWrap(
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
