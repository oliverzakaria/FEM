// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerRemoveService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: D:\Riski\CAFE_1_0_0_2 - Copy\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerRemoveService : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;

    public CHandlerRemoveService(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDRemoveService payload = (UDRemoveService) pEvent.Payload;
      if (this.mpApp.AssignedServices.Contains((object) payload.serviceID))
        this.mpApp.AssignedServices.GetByKey((object) payload.serviceID).removed = false;
      else
        this.mpApp.AssignedServices.Load(payload.serviceID);
    }
  }
}
