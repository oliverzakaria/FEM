// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CCallRejectionReasons
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CCallRejectionReasons : CList
  {
    private CApp mpApp;

    internal CCallRejectionReasons(CApp pApp) => this.mpApp = pApp;

    public CCallRejectionReason this[int index] => (CCallRejectionReason) base[index];

    public CCallRejectionReason GetByKey(object key) => (CCallRejectionReason) base.GetByKey(key);

    internal void Load()
    {
      try
      {
        this.Clear();
        StatusReasons[] info = (StatusReasons[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 102,
          statusReasonsType = 29
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CCallRejectionReason ccallRejectionReason = new CCallRejectionReason(info[index].reasonid, info[index].description);
          this.Add((object) ccallRejectionReason.Id, (object) ccallRejectionReason);
        }
        if (this.Count != 0)
          return;
        CCallRejectionReason ccallRejectionReason1 = new CCallRejectionReason(0, "[None]");
        this.Add((object) ccallRejectionReason1.Id, (object) ccallRejectionReason1);
      }
      catch (Exception ex)
      {
        throw new Exception("Status Reason list load failed - ", ex);
      }
    }
  }
}
