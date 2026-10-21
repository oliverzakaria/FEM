// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerPreview
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerPreview : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerPreview(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      CCall call = this.mpApp.CallManager.CreateCall((UDPreview) pEvent.Payload);
      this.mpEventHelper.ProcessCallAppearance(call);
      this.mpEventHelper.SetApplicationState(AgentStateId.asPREVIEW, pEvent, call);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
