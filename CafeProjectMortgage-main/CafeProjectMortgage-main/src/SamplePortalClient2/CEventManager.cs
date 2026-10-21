// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CEventManager
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;
using System.Collections;
using System.Threading;

namespace SamplePortalClient
{
  internal class CEventManager
  {
    private Thread mpEventProcessingThread;
    private Queue mpEventQueue;
    private Hashtable mpEventHandlers;
    private CApp mpApp;
    private CEventManagerHelper mpManagerHelper;
    private LogFile logFile = new LogFile();

    public CState CurrentState => this.mpManagerHelper.CurrentState;

    public CEventManager(CApp pApp)
    {
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CEventManager() -  Constructor Started. ");
      this.mpApp = pApp;
      this.mpManagerHelper = new CEventManagerHelper(pApp);
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CEventManager() -  Constructor, Event Mapping Started. ");
      this.mpEventHandlers = this.CreateEventMap();
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CEventManager() -  Constructor, Event Mapping Completed. ");
      this.mpEventQueue = new Queue();
      this.mpEventProcessingThread = new Thread(new ThreadStart(this.ProcessEvents));
      this.mpEventProcessingThread.IsBackground = true;
      this.mpEventProcessingThread.Start();
      this.mpApp.Portal.EventArrival += new EventArrivalHandler(this.EventArrived);
      this.logFile.LogMessageToFile(" |INFO| CEventManager.CEventManager() -  Constructor completed. ");
    }

    private void EventArrived(object pSender, CEventArrivalArgs pArgs)
    {
      lock (this.mpEventQueue)
      {
        try
        {
          this.logFile.LogMessageToFile(" |INFO| CEventManager.EventArrived() -  Constructor, Event Arrived. ");
          this.logFile.LogMessageToFile(" |INFO| CEventManager.EventArrived() - Server Event Arrival: Id<" + pArgs.NextEvent.eventId.ToString() + ">, Payload<" + pArgs.NextEvent.payload.GetType()?.ToString() + ">");
          this.mpEventQueue.Enqueue((object) new CAgentEvent(pArgs.NextEvent.eventId, pArgs.NextEvent.payload));
          Monitor.Pulse((object) this.mpEventQueue);
        }
        catch (Exception ex)
        {
          this.logFile.LogMessageToFile(" |ERROR| CEventManager.EventArrived() -  Process failed " + ex.Message.ToString() + ex.StackTrace.ToString());
        }
      }
    }

    internal void RaiseEvent(AgentEventType eEventId, object pPayload) => this.RaiseEvent(eEventId, pPayload, true);

    internal void ActivateCall(CCall pCall)
    {
      this.mpApp.Portal.WSAgent.focus(this.mpApp.CurrentAgent.AgentArg, new UDFocus()
      {
        callId = pCall.callID,
        callIdTo = pCall.callID
      });
      CCall currentCall = this.mpApp.CallManager.CurrentCall;
      this.mpApp.CallManager.CurrentCall = pCall;
      this.mpManagerHelper.SetApplicationState(pCall.CurrentState.Id, (CAgentEvent) null, pCall);
      this.mpApp.OnCallActivated(new CCallActivatedArgs(currentCall, this.mpApp.CallManager.CurrentCall));
      this.mpManagerHelper.FireStateChangeEvents();
    }

    internal void RaiseEvent(AgentEventType eEventId, object pPayload, bool bAsync)
    {
      lock (this.mpEventQueue)
      {
        CAgentEventRaised pEvent = new CAgentEventRaised((int) eEventId, pPayload);
        if (bAsync)
        {
          Console.WriteLine("Raised Event Arrival: Id<" + eEventId.ToString() + ">, Payload<" + (pPayload == null ? "null" : pPayload.GetType().ToString()) + ">, Async<" + bAsync.ToString() + ">");
          this.mpEventQueue.Enqueue((object) pEvent);
          Monitor.Pulse((object) this.mpEventQueue);
        }
        else
          this.ProcessEvent((CAgentEvent) pEvent);
      }
    }

    private void ProcessEvents()
    {
      lock (this.mpEventQueue)
      {
        while (true)
        {
          if (this.mpEventQueue.Count == 0)
            Monitor.Wait((object) this.mpEventQueue);
          this.ProcessEvent((CAgentEvent) this.mpEventQueue.Dequeue());
        }
      }
    }

    private void ProcessEvent(CAgentEvent pEvent)
    {
      try
      {
        ((IEventHandler) this.mpEventHandlers[(object) (AgentEventType) pEvent.Id])?.ProcessEvent(pEvent);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }

    private Hashtable CreateEventMap() => new Hashtable()
    {
      {
        (object) AgentEventType.aeLOGINCONF,
        (object) new CHandlerLoginConf(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeLOGGINGIN,
        (object) new CHandlerLoggingIn(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aePASSCODE,
        (object) new CHandlerPasscode(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeNEWSERVICE,
        (object) new CHandlerNewService(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeUPDATESERVICE,
        (object) new CHandlerUpdateService(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeREMOVESERVICE,
        (object) new CHandlerRemoveService(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeLOGIN,
        (object) new CHandlerLogin(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeIDLE,
        (object) new CHandlerIdle(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeLOGOUT,
        (object) new CHandlerLogout(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeSCREENPOP,
        (object) new CHandlerScreenpop(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeACTIVE,
        (object) new CHandlerActive(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeWRAP,
        (object) new CHandlerWrap(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCALLCLEAR,
        (object) new CHandlerCallClear(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aePREVIEW,
        (object) new CHandlerPreview(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeLOGOUTPENDING,
        (object) new CHandlerLogoutPending(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeBADPASSCODE,
        (object) new CHandlerBadPasscode(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeAUTHENTICATED,
        (object) new CHandlerAuthenticated(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeACTIVATECALL,
        (object) new CHandlerActivateCall(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeDIALING,
        (object) new CHandlerDialing(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeUPDATEEXTERNALROUTE,
        (object) new CHandlerUpdateExternalRoute(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeUPDATEAGENTSTATUSREASONS,
        (object) new CHandlerUpdateAgentStatusReasons(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeHELD,
        (object) new CHandlerHeld(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeSYSTEMWAIT,
        (object) new CHandlerSystemWait(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeNOTREADY,
        (object) new CHandlerNotReady(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCONSULT,
        (object) new CHandlerConsulting(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCALLRELEASEDXFERRED,
        (object) new CHandlerCallReleasedXferred(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCONFERENCE,
        (object) new CHandlerConference(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCALLREROUTED,
        (object) new CHandlerCallReRouted(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCALLXFERRED,
        (object) new CHandlerCallXferred(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeAUDIOPATHCONNECTION,
        (object) new CHandlerAudioPathConnection(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeERROR,
        (object) new CHandlerError(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCHATENTITYADDED,
        (object) new CHandlerChatEntityAdded(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCHATENTITYREMOVED,
        (object) new CHandlerChatEntityRemoved(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCHATURL,
        (object) new CHandlerChatURL(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeCHATMESSAGE,
        (object) new CHandlerChatMessage(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeAGENTSTATS,
        (object) new CAgentStatistics(this.mpApp, this.mpManagerHelper)
      },
      {
        (object) AgentEventType.aeWRAPTIMEOUT,
        (object) new CHandlerWrapTimeout(this.mpApp, this.mpManagerHelper)
      }
    };
  }
}
