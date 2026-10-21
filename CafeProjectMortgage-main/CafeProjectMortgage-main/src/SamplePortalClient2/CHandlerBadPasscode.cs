// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerBadPasscode
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerBadPasscode : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerBadPasscode(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDBadPassCode payload = (UDBadPassCode) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerBadPasscode.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      this.mpApp.OnPasscode(new CPasscodeArgs(payload.codeShouldBe, false));
    }
  }
}
