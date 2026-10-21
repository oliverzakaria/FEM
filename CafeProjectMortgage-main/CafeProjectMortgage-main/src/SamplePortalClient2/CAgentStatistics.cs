// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CAgentStatistics
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CAgentStatistics : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CAgentStatistics(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDAgentStatsCollection payload = (UDAgentStatsCollection) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CAgentStatistics.ProcessEvent() -  Event Id< " + pEvent.Id.ToString() + ">, Agent Index <" + payload.agentIndex.ToString() + ">Type<" + this.GetType().ToString() + " >");
      this.mpApp.CurrentAgent.AgentStatistics = payload;
      this.mpApp.CurrentAgent.agentIndex = payload.agentIndex;
      this.mpApp.EnableKeepAlives = true;
    }
  }
}
