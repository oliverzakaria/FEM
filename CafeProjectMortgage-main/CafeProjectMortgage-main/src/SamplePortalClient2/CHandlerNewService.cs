// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerNewService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerNewService : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerNewService(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDNewService payload = (UDNewService) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerNewService.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Service ID<" + payload.serviceID.ToString() + "> Service Type ID<" + payload.serviceInfo.servicetypeid.ToString() + "> User ID<" + payload.serviceSettings.userid + "> Disposition Plan ID<" + payload.serviceInfo.dispplanid.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (this.mpApp.AssignedServices.Contains((object) payload.serviceID))
        this.mpApp.AssignedServices.GetByKey((object) payload.serviceID).removed = false;
      else
        this.mpApp.AssignedServices.Load(payload);
    }
  }
}
