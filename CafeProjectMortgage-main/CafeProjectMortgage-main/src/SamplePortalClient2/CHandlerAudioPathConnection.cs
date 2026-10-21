// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerAudioPathConnection
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  internal class CHandlerAudioPathConnection : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerAudioPathConnection(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDAudioPathConnection payload = (UDAudioPathConnection) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerAudioPathConnection.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> Type<" + this.GetType().ToString() + " >");
      this.mpApp.OnPhoneStatus(new CPhoneStatusArgs(payload.audioPath));
    }
  }
}
