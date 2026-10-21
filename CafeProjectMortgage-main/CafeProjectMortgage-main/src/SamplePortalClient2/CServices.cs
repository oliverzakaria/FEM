// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CServices
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CServices : CList
  {
    private CApp mpApp;

    internal CServices(CApp pApp) => this.mpApp = pApp;

    public CSimpleService this[int index] => (CSimpleService) base[index];

    public CSimpleService GetByKey(object key) => (CSimpleService) base.GetByKey(key);

    internal void Load() => this.Load((ServiceType) 0);

    internal void Load(ServiceType serviceType)
    {
      this.Clear();
      try
      {
        ServiceXfer[] info = (ServiceXfer[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 105,
          serviceType = (int) serviceType
        });
        for (int index = 0; index < info.Length; ++index)
        {
          if (info[index].servicetypeid == 4)
          {
            CSimpleService csimpleService = new CSimpleService(info[index].serviceid, info[index].servicec, (ServiceType) info[index].servicetypeid);
            this.Add((object) csimpleService.ServiceId, (object) csimpleService);
          }
          else
          {
            CSimpleService csimpleService = new CSimpleService(info[index].serviceid, info[index].servicec, (ServiceType) info[index].servicetypeid);
            this.Add((object) csimpleService.ServiceId, (object) csimpleService);
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Service list for Transfer load failed - ", ex);
      }
    }

    internal void LoadAOD(ServiceType serviceType)
    {
      this.Clear();
      try
      {
        CallBackService[] info = (CallBackService[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 114,
          serviceType = (int) serviceType
        });
        for (int index = 0; index < info.Length; ++index)
        {
          if (info[index].cbservicecallbackflag == 1)
          {
            CSimpleService csimpleService = new CSimpleService(info[index].serviceid, info[index].servicec, ServiceType.AOD);
            this.Add((object) csimpleService.ServiceId, (object) csimpleService);
          }
          else if (info[index].cbselfcallbackflag == 1)
          {
            CSimpleService csimpleService = new CSimpleService(info[index].serviceid, info[index].servicec, ServiceType.AOD);
            this.Add((object) csimpleService.ServiceId, (object) csimpleService);
          }
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Service list for Transfer load failed - ", ex);
      }
    }
  }
}
