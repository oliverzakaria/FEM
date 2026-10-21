// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerUpdateAgentStatusReasons
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  internal class CHandlerUpdateAgentStatusReasons : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerUpdateAgentStatusReasons(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerUpdateAgentStatusReasons.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      this.mpApp.LogoutReasons.Load();
      this.mpApp.NotReadyReasons.Load();
      this.mpApp.CallRejectionReasons.Load();
    }
  }
}
