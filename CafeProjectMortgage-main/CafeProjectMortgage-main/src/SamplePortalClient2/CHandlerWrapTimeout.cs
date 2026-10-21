// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerWrapTimeout
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerWrapTimeout : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerWrapTimeout(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDWrapTimeout payload = (UDWrapTimeout) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CWrapTimeout.ProcessEvent() -  Event Id< " + pEvent.Id.ToString() + ">, Agent Index <" + payload.agentIndex.ToString() + ">Type<" + this.GetType().ToString() + " >");
      if (payload.agentDispExpected != 1)
        return;
      this.mpApp.DisposeCall(this.mpApp.CurrentCall, new CDisposition(-2, "Max Wrap Time Exceeded", "", false, false, false));
    }
  }
}
