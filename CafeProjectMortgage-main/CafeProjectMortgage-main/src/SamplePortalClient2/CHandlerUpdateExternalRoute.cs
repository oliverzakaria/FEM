// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerUpdateExternalRoute
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerUpdateExternalRoute : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerUpdateExternalRoute(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDExternalRoute payload = (UDExternalRoute) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerUpdateExternalRoute.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> External Route Type<" + payload.externalRequestType.ToString() + "> External Route ID<" + payload.externalRouteId.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      switch (payload.externalRequestType)
      {
        case 1:
          if (payload.externalRouteId == 0)
          {
            this.mpApp.ExternalRoutes.Load();
            break;
          }
          this.mpApp.ExternalRoutes.Load(payload.externalRouteId);
          break;
        case 2:
          this.mpApp.ExternalRoutes.RemoveByKey((object) payload.externalRouteId);
          break;
        case 3:
          this.mpApp.ExternalRoutes.Load(payload.externalRouteId);
          break;
        default:
          this.mpApp.ExternalRoutes.Load();
          break;
      }
    }
  }
}
