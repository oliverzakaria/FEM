// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CStateDialing
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System.Drawing;

namespace SamplePortalClient
{
  public class CStateDialing : CCallState
  {
    public override bool EnableHold => false;

    public override bool Enable3Way => this.mpCall is C3WayCall ? ((C3WayCall) this.mpCall).ParentCall.CurrentState.Enable3Way : this.mpApp.AssignedServices.GetByKey((object) ((CCall) this.mpCall).ServiceID).Allow3Way;

    internal CStateDialing(
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
