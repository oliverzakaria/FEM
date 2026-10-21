// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerLogin
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerLogin : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerLogin(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDLogin payload = (UDLogin) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerLogin.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Gateway ID<" + payload.ntSwitchId.ToString() + "> enableUCF<" + payload.enableUCF.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      this.mpApp.CurrentAgent.gatewayId = payload.ntSwitchId;
      this.mpApp.OnLoggedIn();
    }
  }
}
