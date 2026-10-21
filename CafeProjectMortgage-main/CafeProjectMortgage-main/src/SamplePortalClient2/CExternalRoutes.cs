// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CExternalRoutes
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CExternalRoutes : CList
  {
    private CApp mpApp;

    internal CExternalRoutes(CApp pApp) => this.mpApp = pApp;

    public CExternalRoute this[int index] => (CExternalRoute) base[index];

    public CExternalRoute GetByKey(object key) => (CExternalRoute) base.GetByKey(key);

    internal void Load()
    {
      try
      {
        this.Clear();
        Externals[] info = (Externals[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 101
        });
        for (int index = 0; index < info.Length; ++index)
        {
          CExternalRoute cexternalRoute = new CExternalRoute(info[index].externalrouteid, info[index].externalroutedesc, info[index].phonenum, info[index].externalroutetype);
          this.Add((object) cexternalRoute.Id, (object) cexternalRoute);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("External Route Load failed - ", ex);
      }
    }

    internal void Load(int externalRouteId)
    {
      try
      {
        if (externalRouteId <= 0)
          throw new ArgumentException("You must specify an externalRouteId", nameof (externalRouteId));
        External info = (External) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 144,
          id = externalRouteId
        });
        if (this.Contains((object) externalRouteId))
        {
          CExternalRoute byKey = (CExternalRoute) base.GetByKey((object) externalRouteId);
          byKey.description = info.externalroutedesc;
          byKey.phoneNumber = info.phonenum;
          byKey.type = (ExternalRouteType) info.externalroutetype;
        }
        else
        {
          CExternalRoute cexternalRoute = new CExternalRoute(info.externalrouteid, info.externalroutedesc, info.phonenum, info.externalroutetype);
          this.Add((object) cexternalRoute.Id, (object) cexternalRoute);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Enternal Route Load with external route id failed - ", ex);
      }
    }
  }
}
