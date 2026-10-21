// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateIdle
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateIdle : CState
  {
    public override bool EnablePlay => this.mpApp.CurrentService.AllowPlay;

    public override bool EnableDial => this.mpApp.CurrentService.AllowDial;

    public override bool EnableUnavailable => true;

    internal CStateIdle(
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
