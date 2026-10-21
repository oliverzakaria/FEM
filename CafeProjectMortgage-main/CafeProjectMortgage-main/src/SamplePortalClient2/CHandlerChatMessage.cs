// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerChatMessage
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CHandlerChatMessage : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;

    public CHandlerChatMessage(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDEntitySendText payload = (UDEntitySendText) pEvent.Payload;
      Console.WriteLine("CallId<{0}>, EntityName<{1}>, EntityType<{2}>, Message<{3}>\t[{4}]", (object) payload.callId, (object) payload.entityName, (object) payload.entity, (object) payload.text, (object) this.GetType());
      this.mpApp.OnChatMessage(new CChatMessageArgs(payload.callId, (ChatEntityType) payload.entity, payload.entityName, payload.text));
    }
  }
}
