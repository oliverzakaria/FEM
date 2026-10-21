// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerChatEntityRemoved
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CHandlerChatEntityRemoved : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;

    public CHandlerChatEntityRemoved(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDEntity payload = (UDEntity) pEvent.Payload;
      Console.WriteLine("EntityName<{0}>, EntityType<{1}>, EntityId<{2}>\t[{3}]", new object[4]
      {
        (object) payload.name,
        (object) payload.entity,
        (object) payload.entityID,
        (object) this.GetType()
      });
      this.mpApp.OnChatEntityRemoved(new CChatEntityArgs(payload.name, (ChatEntityType) payload.entity, payload.entityID));
    }
  }
}
