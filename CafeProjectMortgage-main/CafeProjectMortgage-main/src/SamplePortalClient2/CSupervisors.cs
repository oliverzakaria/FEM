// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CSupervisors
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CSupervisors : CList
  {
    private CApp mpApp;

    internal CSupervisors(CApp pApp) => this.mpApp = pApp;

    public CUser this[int index] => (CUser) base[index];

    public CUser GetByKey(object key) => (CUser) base.GetByKey(key);

    internal void Load(int serviceId)
    {
      this.Clear();
      try
      {
        DirectorXfer[] info = (DirectorXfer[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 104,
          serviceId = serviceId
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CUser cuser = new CUser(info[index].userid, info[index].userfname, info[index].userlname);
          this.Add((object) cuser.Id, (object) cuser);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Director list load failed - ", ex);
      }
    }
  }
}
