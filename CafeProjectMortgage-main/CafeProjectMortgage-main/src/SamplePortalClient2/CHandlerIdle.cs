// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerIdle
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using Utilities;

namespace SamplePortalClient
{
  internal class CHandlerIdle : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerIdle(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDIdle payload = (UDIdle) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerIdle.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      if (payload != null && payload.statusReason == 0)
      {
        this.mpApp.CallManager.ClearAll();
        this.mpApp.CallManager.CurrentCall = (CCall) null;
      }
      else
        this.mpEventHelper.RemoveRemainingCalls();
      if (this.mpApp.CurrentCall == null)
      {
        ProcessChecker.Line1Busy = false;
        ProcessChecker.Line2Busy = false;
        ProcessChecker.ActiveLine = 0;
        this.mpEventHelper.SetApplicationState(AgentStateId.asIDLE, pEvent);
      }
      else if (this.mpApp.CurrentCall.CurrentState.Description.ToUpper() == "HELD" || this.mpApp.CurrentCall.CurrentState.Description.ToUpper() == "HOLD")
        this.mpApp.ReleaseHold();
      this.mpEventHelper.FireStateChangeEvents();
      ProcessChecker.Is3Way = false;
      ProcessChecker.LastCallClearCallId = 0;
    }
  }
}
