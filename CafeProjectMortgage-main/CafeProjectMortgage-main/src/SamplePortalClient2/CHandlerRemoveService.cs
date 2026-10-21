// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerRemoveService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerRemoveService : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerRemoveService(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDRemoveService payload = (UDRemoveService) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerRemoveService.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Service ID<" + payload.serviceID.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (this.mpApp.AssignedServices.Contains((object) payload.serviceID))
        this.mpApp.AssignedServices.GetByKey((object) payload.serviceID).removed = false;
      else
        this.mpApp.AssignedServices.Load(payload.serviceID);
    }
  }
}
