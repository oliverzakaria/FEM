// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CNotReadyReasons
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CNotReadyReasons : CList
  {
    private CApp mpApp;

    internal CNotReadyReasons(CApp pApp) => this.mpApp = pApp;

    public CNotReadyReason this[int index] => (CNotReadyReason) base[index];

    public CNotReadyReason GetByKey(object key) => (CNotReadyReason) base.GetByKey(key);

    internal void Load()
    {
      try
      {
        this.Clear();
        StatusReasons[] info = (StatusReasons[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 102,
          statusReasonsType = 5
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CNotReadyReason cnotReadyReason = new CNotReadyReason(info[index].reasonid, info[index].description);
          this.Add((object) cnotReadyReason.Id, (object) cnotReadyReason);
        }
        if (this.Count != 0)
          return;
        CNotReadyReason cnotReadyReason1 = new CNotReadyReason(0, "[None]");
        this.Add((object) cnotReadyReason1.Id, (object) cnotReadyReason1);
      }
      catch (Exception ex)
      {
        throw new Exception("Not Ready Reason list load failed - ", ex);
      }
    }
  }
}
