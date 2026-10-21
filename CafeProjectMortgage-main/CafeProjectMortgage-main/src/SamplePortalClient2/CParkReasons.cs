// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CParkReasons
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CParkReasons : CList
  {
    private CApp mpApp;

    internal CParkReasons(CApp pApp) => this.mpApp = pApp;

    public CParkReasons this[int index] => (CParkReasons) base[index];

    public CParkReasons GetByKey(object key) => (CParkReasons) base.GetByKey(key);

    internal void Load()
    {
      try
      {
        this.Clear();
        StatusReasons[] info = (StatusReasons[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 102,
          statusReasonsType = 25
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CParkReason cparkReason = new CParkReason(info[index].reasonid, info[index].description);
          this.Add((object) cparkReason.Id, (object) cparkReason);
        }
        if (this.Count != 0)
          return;
        CParkReason cparkReason1 = new CParkReason(0, "[None]");
        this.Add((object) cparkReason1.Id, (object) cparkReason1);
      }
      catch (Exception ex)
      {
        throw new Exception("Not Ready Reason list load failed - ", ex);
      }
    }
  }
}
