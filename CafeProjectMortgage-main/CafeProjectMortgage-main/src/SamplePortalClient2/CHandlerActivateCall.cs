// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerActivateCall
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerActivateCall : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerActivateCall(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDActivateCall payload = (UDActivateCall) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerActivateCall.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Call ID<" + payload.callID.ToString() + "> Type<" + this.GetType().ToString() + " >");
      CCall byKey = this.mpApp.CallManager.GetByKey(payload.callID);
      CCall currentCall = this.mpApp.CallManager.CurrentCall;
      this.mpApp.CallManager.CurrentCall = byKey;
      this.mpEventHelper.SetApplicationState(byKey.CurrentState.Id, pEvent, byKey);
      this.mpApp.OnCallActivated(new CCallActivatedArgs(currentCall, this.mpApp.CallManager.CurrentCall));
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
