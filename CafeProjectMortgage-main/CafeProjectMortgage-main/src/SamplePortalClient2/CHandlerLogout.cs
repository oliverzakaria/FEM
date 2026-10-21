// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerLogout
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;

namespace SamplePortalClient
{
  internal class CHandlerLogout : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerLogout(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      this.mpApp.EnableKeepAlives = false;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerLogout.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerLogout.ProcessEvent() - Stop Sending Keep Alive", 3);
      try
      {
        this.mpApp.Portal.Unregister(this.mpApp.CurrentAgent.AgentArg);
        LogFile logFile = this.logFile;
        string[] strArray = new string[19];
        strArray[0] = " |INFO| CEventManager.CHandlerLogout.ProcessEvent() -  Event Id<";
        strArray[1] = pEvent.Id.ToString();
        strArray[2] = ">, Description <";
        strArray[3] = pEvent.ToString();
        strArray[4] = "> Agent Index<";
        int num = this.mpApp.CurrentAgent.AgentArg.agentIndex;
        strArray[5] = num.ToString();
        strArray[6] = "> Login Name<";
        strArray[7] = this.mpApp.CurrentAgent.AgentArg.agentLoginName.ToString();
        strArray[8] = "> LDAPUserID <";
        strArray[9] = this.mpApp.CurrentAgent.AgentArg.LDAPUserId.ToString();
        strArray[10] = "> Client Role<";
        num = this.mpApp.CurrentAgent.AgentArg.clientRole;
        strArray[11] = num.ToString();
        strArray[12] = "> InitState<";
        num = this.mpApp.CurrentAgent.AgentArg.initState;
        strArray[13] = num.ToString();
        strArray[14] = "> Server Type<";
        num = this.mpApp.CurrentAgent.AgentArg.serverType;
        strArray[15] = num.ToString();
        strArray[16] = "> Type<";
        strArray[17] = this.GetType().ToString();
        strArray[18] = " >";
        string message = string.Concat(strArray);
        logFile.LogMessageToFile(message, 3);
      }
      catch (Exception ex)
      {
        this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerLogout.ProcessEvent() - Handle Logout failed " + ex.Message.ToString() + ex.StackTrace.ToString());
        Console.WriteLine(ex.StackTrace);
      }
      this.mpEventHelper.SetApplicationState(AgentStateId.asLOGGED_OUT, pEvent);
      this.mpEventHelper.FireStateChangeEvents();
    }
  }
}
