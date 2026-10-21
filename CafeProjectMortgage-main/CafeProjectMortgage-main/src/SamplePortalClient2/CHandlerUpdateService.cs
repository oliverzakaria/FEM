// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerUpdateService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerUpdateService : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerUpdateService(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDUpdateService payload = (UDUpdateService) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerUpdateService.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Service ID<" + payload.serviceID.ToString() + "> Service Name<" + payload.serviceInfo.servicec.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (!this.mpApp.AssignedServices.Contains((object) payload.serviceID))
        return;
      this.mpApp.AssignedServices.Load(payload.serviceID);
    }
  }
}
