// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CHandlerError
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPEventsWS;
using System;

namespace SamplePortalClient
{
  internal class CHandlerError : IEventHandler
  {
    private CApp mpApp;
    private CEventManagerHelper mpEventHelper;
    private LogFile logFile = new LogFile();

    public CHandlerError(CApp pApp, CEventManagerHelper pEventHelper)
    {
      this.mpApp = pApp;
      this.mpEventHelper = pEventHelper;
    }

    public void ProcessEvent(CAgentEvent pEvent)
    {
      UDError payload = (UDError) pEvent.Payload;
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CHandlerError.ProcessEvent() -  Event Id<" + pEvent.Id.ToString() + ">, Description <" + pEvent.ToString() + "> Agent Index<" + payload.agentIndex.ToString() + "> CallID<" + payload.callID.ToString() + "> Fail Code<" + payload.failCode.ToString() + "> Failed reason<" + payload.failReason.ToString() + "> Type<" + this.GetType().ToString() + " >", 3);
      Console.WriteLine("Error: Code[{0}], Desc[{1}], CallId[{2}]\t[{3}]", new object[4]
      {
        (object) payload.failCode,
        (object) payload.failReason,
        (object) payload.callID,
        (object) this.GetType()
      });
      this.mpApp.OnError(new CErrorArgs((ErrorId) payload.failCode, payload.failReason, payload.callID));
    }
  }
}
