// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerNotReady
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerNotReady : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerNotReady(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDNotReady payload = (UDNotReady) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerNotReady.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      this.mpApp.CallManager.CurrentCall = (CCall) null;
      if (payload.toParkState)
        this.mpEventHelper.SetApplicationState(AgentStateId.asPARKED, pEvent);
      else
        this.mpEventHelper.SetApplicationState(AgentStateId.asNOT_READY, pEvent);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
