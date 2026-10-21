// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerChatURL
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CHandlerChatURL : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;

    public CHandlerChatURL(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDEntityPushUrl payload = (UDEntityPushUrl) pEvent.Payload;
      Console.WriteLine("CallId<{0}>, URL<{1}>, EntityType<{2}>, EntityName<{3}>\t[{4}]", (object) payload.callId, (object) payload.url, (object) payload.entity, (object) payload.entityName, (object) this.GetType());
      this.mpApp.OnChatURL(new CChatURLArgs(payload.callId, (ChatEntityType) payload.entity, payload.entityName, payload.url));
    }
  }
}
