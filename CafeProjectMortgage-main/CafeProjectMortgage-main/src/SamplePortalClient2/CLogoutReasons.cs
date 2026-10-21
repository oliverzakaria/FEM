// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CLogoutReasons
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CLogoutReasons : CList
  {
    private CApp mpApp;

    internal CLogoutReasons(CApp pApp) => this.mpApp = pApp;

    public CLogoutReason this[int index] => (CLogoutReason) base[index];

    public CLogoutReason GetByKey(object key) => (CLogoutReason) base.GetByKey(key);

    internal void Load()
    {
      try
      {
        this.Clear();
        CLogoutReason clogoutReason1 = new CLogoutReason(-99, "[Panic Logout]");
        this.Add((object) clogoutReason1.Id, (object) clogoutReason1);
        StatusReasons[] info = (StatusReasons[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 102,
          statusReasonsType = 20
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CLogoutReason clogoutReason2 = new CLogoutReason(info[index].reasonid, info[index].description);
          this.Add((object) clogoutReason2.Id, (object) clogoutReason2);
        }
        if (this.Count != 1)
          return;
        CLogoutReason clogoutReason3 = new CLogoutReason(0, "[None]");
        this.Add((object) clogoutReason3.Id, (object) clogoutReason3);
      }
      catch (Exception ex)
      {
        throw new Exception("Logout Reason list load failed - ", ex);
      }
    }
  }
}
