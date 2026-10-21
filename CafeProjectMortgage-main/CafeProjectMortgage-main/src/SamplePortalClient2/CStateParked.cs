// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateParked
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateParked : CState
  {
    public override bool EnableDial => this.mpApp.CurrentService.AllowDial;

    public override bool EnableAvailable => true;

    public override bool EnablePlay => this.mpApp.CurrentService.AllowPlay;

    internal CStateParked(
      AgentStateId eId,
      string sDescription,
      Color pBackColor,
      Color pForeColor,
      CApp pApp)
      : base(eId, sDescription, pBackColor, pForeColor, pApp)
    {
    }
  }
}
