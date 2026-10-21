using SamplePortalClient.EPAgentWSP;
using SamplePortalClient.EPEventsWS;
using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading;
using Utilities;
using static SamplePortalClient.CServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace SamplePortalClient
{
    public enum AgentStateId
    {
        asLOGGING_IN = 0,
        asAUTHENTICATED = 1,          //The user was authenticated but has not yet registered to take/make calls.
        asIDLE = 2,
        asDIALING = 3,
        asDIALING_CONSULTATION = 4,   //Dialing a consultation call
        asRINGING = 5,                //Receiving a call offer (Screenpop)
        asINACTIVE = 6,               //The call cleared or has not yet been dialed
        asPREVIEW = 7,
        asACTIVE = 8,
        asACTIVE_INTERNAL = 9,        //Active on an internal call (ie, with another agent)
        asWRAP = 10,
        asHELD = 11,
        asWAITING = 12,               //Centercord or Gateway went down or are still starting up. 
        asLOGGED_OUT = 13,
        asNOT_READY = 14,
        asPARKED = 15,               //Not Ready but with ability to make manual calls
        asCONSULTING = 16,
        asCONFERENCE = 17,
        asCHATTING = 18,
        asACTIVE_IM_INTERNAL=19,
    };

    public enum ErrorId
    {
        //errCTINotReadyFailure = 4,
        //errGeneralFailure = 10,
        //errCallerIsInInvalidState = 11,
        //errXferToServiceFailed = 12,
        //errExternalRouteUnknown = 13,
        //errSpeedDialOperationFailed = 14,
        //errMonitoringFailure = 0xF,
        //errCTILoginFailure = 0x10,
        //errGatewayLoginFailure = 17,
        //errCTIServerDown = 18,
        //errNoActiveService = 19,
        //errInvalidAgentState = 20,
        //errTransferFailure = 28,
        //errMonitorStartFailure = 29,
        //errMonitorStopFailure = 30,
        //errHoldFailure = 0x1F,
        //errRetrieveHoldFailure = 0x20,
        //errMakeCallFailure = 33,
        //errHangupFailure = 34,
        //errConsultationFailure = 38,
        //errCallDisconnected = 40,
        //errConsultationXferFailure = 45,
        //errConsultationHangupFailure = 46,
        //errConferenceFailure = 69,
        //errCallInProgress = 100,
        //errAgentNotAvailable = 110,
        //errInvalidRouteAccess = 120,
        //errRouteBusy = 130,
        //errNumberNotInNumberingPlan = 131,
        //errTimeZoneFailure = 132,
        //errCustomerHungupWaitingForXfer = 140,
        //errESwitchServiceFailure = 150,
        //errAgentLicenseExceeded = 175,
        //errTrunkLicenseExceeded = 174,
        //errOperationFailure = 200,
        //errDestAgentNotAvailable = 201,
        //errOutOfResource = 202,
        //errInvalidAgentIndex = 203,
        //errInvalidServiceId = 204,
        //errInvalidCallIndex = 205,
        //errInvalidCallState = 206,
        //errInvalidAgentId = 207,
        //errInvalidStation = 208,
        //errInvalidCallType = 209,
        //errAudioPathFailure = 210,
        //errSendSwitchFailure = 211,
        //errInvalidSwitchId = 212,
        //errRecordExcluded = 213,
        //errInvalidNumber = 214,
        //errInvalidConsultType = 215,
        //errESwitchSMTPServerFailure = 216,
        //errESwitchClientConfigFailure = 217,
        //errStationNotAvailable = 218,
        //errAgentAlreadyLoggedIn = 219,
        //errInvalidParameter = 220,
        //errAnswerCallTimeout = 221,
        //errCallRejected = 222,
        //errCallRedirectToVoiceMail = 223,
        //errMinWrapTimeNotReached = 224,
        //errOperationNormal = 225,
        //errCallCanceled = 226,
        //errCallHeldByRemote = 227,
        //errCallRetrievedByRemote = 228,
        //errCallReplacedByHigherPriorityCall = 229,
        //errConsultedAgent = 248,
        //errExpertIMTimeout = 900,
        //errNoExpertsAreInAvailableState = 901,
        //errMuseConnectionFailure = 902
        errCTINotReadyFailure = 4,
        errGeneralFailure = 10,
        errCallerIsInInvalidState = 11,
        errXferToServiceFailed = 12,
        errExternalRouteUnknown = 13,
        errSpeedDialOperationFailed = 14,
        errMonitoringFailure = 15,
        errCTILoginFailure = 16,
        errGatewayLoginFailure = 17,
        errCTIServerDown = 18,
        errNoActiveService = 19,
        errInvalidAgentState = 20,
        errTransferFailure = 28,
        errMonitorStartFailure = 29,
        errMonitorStopFailure = 30,
        errHoldFailure = 31,
        errRetrieveHoldFailure = 32,
        errMakeCallFailure = 33,
        errHangupFailure = 34,
        errConsultationFailure = 38,
        errCallDisconnected = 40,
        errConsultationXferFailure = 45,
        errConsultationHangupFailure = 46,
        errConferenceFailure = 69,
        errCallInProgress = 100,
        errAgentNotAvailable = 110,
        errInvalidRouteAccess = 120,
        errRouteBusy = 130,
        errNumberNotInNumberingPlan = 131,
        errTimeZoneFailure = 132,
        errCustomerHungupWaitingForXfer = 140,
        errESwitchServiceFailure = 150,
        errAgentLicenseExceeded = 175,
        errTrunkLicenseExceeded = 174
    }
    internal class CAgentEvent
	{
		private int id;
		private Object payload;

		internal int Id{get{return id;}}
		internal Object	Payload{get{return payload;}}
		
		internal CAgentEvent(int id, Object payload)
		{
			this.id = id;
			this.payload = payload;
		}
	}
    public class AgentStatsEventArgs : EventArgs
    {
        private AgentStatData _agentStatData;

        public AgentStatData AgentStatData => _agentStatData;

        public AgentStatsEventArgs(AgentStatData iAgentStatData)
        {
            _agentStatData = iAgentStatData;
        }
    }
    public class AgentStatData
    {
        public AgentStat AgentStat { get; set; }

        public int AgentIndex { get; set; }

        public AgentStat[] AgentStats { get; set; }

        public override string ToString()
        {
            string text = "\r\n";
            StringBuilder stringBuilder = new StringBuilder();
            int num = 1;
            AgentStat[] agentStats = AgentStats;
            foreach (AgentStat agentStat in agentStats)
            {
                stringBuilder.AppendFormat("\nAgentStat Number: {0}", num++, text);
                stringBuilder.AppendFormat(agentStat.ToString(), text);
            }

            return stringBuilder.ToString();
        }
    }
    public class AgentStat
    {
        public int AcdCalls { get; set; }

        public int ActiveSeconds { get; set; }

        public int AgdCalls { get; set; }

        public int AgentIndex { get; set; }

        public int AodCalls { get; set; }

        public int ChatCalls { get; set; }

        public int CtiCalls { get; set; }

        public int DidCalls { get; set; }

        public int EMailCalls { get; set; }

        public int IMCalls { get; set; }

        public int IdleSeconds { get; set; }

        public int LoggedInSeconds { get; set; }

        public int NotReadySeconds { get; set; }

        public int NumberOfCallbacks { get; set; }

        public int NumberOfRefusals { get; set; }

        public int NumberOfSuccesses { get; set; }

        public int OtherSeconds { get; set; }

        public string Service { get; set; }

        public int ServiceId { get; set; }

        public string Station { get; set; }

        public int StatusSeconds { get; set; }

        public int StatusStartTimeMilitary { get; set; }

        public string UserId { get; set; }

        public int WrapSeconds { get; set; }

        public int ManualSeconds { get; set; }

        public int ParkSeconds { get; set; }

        public override string ToString()
        {
            string arg = "\r\n";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{1}AcdCalls<{0}>", AcdCalls, arg);
            stringBuilder.AppendFormat("{1}ActiveSeconds<{0}>", ActiveSeconds, arg);
            stringBuilder.AppendFormat("{1}AgdCalls<{0}>", AgdCalls, arg);
            stringBuilder.AppendFormat("{1}AgentIndex<{0}>", AgentIndex, arg);
            stringBuilder.AppendFormat("{1}AodCalls<{0}>", AodCalls, arg);
            stringBuilder.AppendFormat("{1}ChatCalls<{0}>", ChatCalls, arg);
            stringBuilder.AppendFormat("{1}CtiCalls<{0}>", CtiCalls, arg);
            stringBuilder.AppendFormat("{1}DidCalls<{0}>", DidCalls, arg);
            stringBuilder.AppendFormat("{1}EMailCalls<{0}>", EMailCalls, arg);
            stringBuilder.AppendFormat("{1}IMCalls<{0}>", IMCalls, arg);
            stringBuilder.AppendFormat("{1}IdleSeconds<{0}>", IdleSeconds, arg);
            stringBuilder.AppendFormat("{1}LoggedInSeconds<{0}>", LoggedInSeconds, arg);
            stringBuilder.AppendFormat("{1}NotReadySeconds<{0}>", NotReadySeconds, arg);
            stringBuilder.AppendFormat("{1}NumberOfCallbacks<{0}>", NumberOfCallbacks, arg);
            stringBuilder.AppendFormat("{1}NumberOfRefusals<{0}>", NumberOfRefusals, arg);
            stringBuilder.AppendFormat("{1}NumberOfSuccesses<{0}>", NumberOfSuccesses, arg);
            stringBuilder.AppendFormat("{1}OtherSeconds<{0}>", OtherSeconds, arg);
            stringBuilder.AppendFormat("{1}Service<{0}>", Service, arg);
            stringBuilder.AppendFormat("{1}ServiceId<{0}>", ServiceId, arg);
            stringBuilder.AppendFormat("{1}Station<{0}>", Station, arg);
            stringBuilder.AppendFormat("{1}StatusSeconds<{0}>", StatusSeconds, arg);
            stringBuilder.AppendFormat("{1}StatusStartTimeMilitary<{0}>", StatusStartTimeMilitary, arg);
            stringBuilder.AppendFormat("{1}UserId<{0}>", UserId, arg);
            stringBuilder.AppendFormat("{1}WrapSeconds<{0}>", WrapSeconds, arg);
            stringBuilder.AppendFormat("{1}ManualSeconds<{0}>", ManualSeconds, arg);
            stringBuilder.AppendFormat("{1}ParkSeconds<{0}>", ParkSeconds, arg);
            return stringBuilder.ToString();
        }
    }
    internal class CAgentEventRaised: CAgentEvent
	{
		internal CAgentEventRaised(int id, Object payload)
			:base(id, payload)
		{
		}
	}


	//StateChange event types
	public class CStateChangeArgs:EventArgs
	{
		private CState mpNewState;
		public CStateChangeArgs(CState pNewState){ mpNewState  = pNewState;}
		public CState NewState {get{return mpNewState;}}
	}
    public delegate void PortalRequestStatusEventHandler(object pSender, CApp.PortalRequestStatusEventArgs pArgs);
    public delegate void StateChangeHandler(Object pSender, CStateChangeArgs pArgs);
    public delegate void AgentStatsEventHandler(object pSender, AgentStatsEventArgs pArgs);

    //StateChange event types
    public class CUnfocusedStateChangeArgs:CStateChangeArgs 
	{
		private CCall mpCall;
		public CUnfocusedStateChangeArgs(CState pNewState, CCall pCall)
		:base(pNewState)
		{
			mpCall = pCall;
		}
		public CCall Call{get{return mpCall;}}
	}

	public delegate void UnfocusedStateChangeHandler(Object pSender, CUnfocusedStateChangeArgs pArgs);


    //CallStateChange event types
    public class CCallStateChangeArgs : CStateChangeArgs
    {
        private C3WayCall mpCall;
        public CCallStateChangeArgs(CState pNewState, C3WayCall pCall)
            : base(pNewState)
        {
            mpCall = pCall;
        }
        public C3WayCall Call { get { return mpCall; } }
    }

    //UnfocusedCallStateChange event types
    public class CUnfocusedCallStateChangeArgs : CCallStateChangeArgs
    {
        public CUnfocusedCallStateChangeArgs(CState pNewState, C3WayCall pCall)
            :base(pNewState, pCall)
        {
        }
    }
    public class AssignedServicesUpdateEventArgs : EventArgs
    {
        private CService mpService;

        public CService Service => mpService;

        public AssignedServicesUpdateEventArgs(CService pService)
        {
            mpService = pService;
        }
    }
    public class WrapTimeout
    {
        public int AgentDispExpected { get; set; }

        public int AgentIndex { get; set; }

        public int CallId { get; set; }
    }
    public class WrapTimeoutEventArgs : EventArgs
    {
        private WrapTimeout _wrapTimeout;

        public WrapTimeout WrapTimeout => _wrapTimeout;

        public WrapTimeoutEventArgs(WrapTimeout wrapTimeout)
        {
            _wrapTimeout = wrapTimeout;
        }
    }
    public class SessionTimedOutEventArgs : EventArgs
    {
        private int miAgentIndex;

        public int AgentIndex => miAgentIndex;

        public SessionTimedOutEventArgs(int iAgentIndex)
        {
            miAgentIndex = iAgentIndex;
        }
    }
   
    public delegate void WrapTimeoutEventHandler(object pSender, WrapTimeoutEventArgs pArgs);
    public delegate void CallStateChangeHandler(Object pSender, CCallStateChangeArgs pArgs);
    public delegate void UnfocusedCallStateChangeHandler(Object pSender, CUnfocusedCallStateChangeArgs pArgs);
   public delegate void AssignedServicesUpdateEventHandler(object pSender, AssignedServicesUpdateEventArgs pArgs);
    

    //Passcode event types
    public class CPasscodeArgs:EventArgs
	{
		private String msPasscode;
		private bool mbValid;
		public CPasscodeArgs(String sPasscode, bool bValid)
		{
			msPasscode = sPasscode;
			mbValid = bValid;
		}
		public String Passcode {get{return msPasscode;}}
		public bool Valid {get{return mbValid;}}
	}

	public delegate void PasscodeHandler(Object pSender, CPasscodeArgs pArgs);

	//LogoutPending event types
	public delegate void LogoutPendingHandler(Object pSender);

	//Screenpop event types
	public class CScreenpopArgs:EventArgs
	{
		private CCall mpCall;
		public CScreenpopArgs(CCall pCall)
		{
			mpCall = pCall;
		}
		public CCall Call{get{return mpCall;}}
	}

	public delegate void ScreenpopHandler(Object pSender, CScreenpopArgs pArgs);

    //CallActivated event types
    public class CCallActivatedArgs : EventArgs
    {
        private CCall mpActivatedCall;
        private CCall mpDeactivatedCall;

        public CCallActivatedArgs(CCall pDeactivatedCall, CCall pActivatedCall)
        {
            mpActivatedCall = pActivatedCall;
            mpDeactivatedCall = pDeactivatedCall;
        }
        public CCall ActivatedCall { get { return mpActivatedCall; } }
        public CCall DeactivatedCall { get { return mpDeactivatedCall; } }
    }

    public delegate void CallActivatedHandler(Object pSender, CCallActivatedArgs pArgs);


    //PhoneConnection event types
    public class CPhoneStatusArgs : EventArgs
    {
        private bool mbConnected;

        public CPhoneStatusArgs(bool bConnected)
        {
            mbConnected = bConnected;
        }
        public bool Connected { get { return mbConnected; } }
    }

    public delegate void PhoneStatusHandler(Object pSender, CPhoneStatusArgs pArgs);

    //Error event types
    public class CErrorArgs : EventArgs
    {
        private ErrorId meCode;
        private int miCallId;
        private String msDescription;

        public CErrorArgs(ErrorId eCode, String sDescription, int iCallId)
        {
            meCode = eCode;
            miCallId = iCallId;
            msDescription = sDescription;
        }

        public ErrorId Code { get { return meCode; } }
        public int CallId { get { return miCallId; } }
        public String Description { get { return msDescription; } }
    }

    public delegate void ErrorHandler(Object pSender, CErrorArgs pArgs);

    public delegate void LoggedInHandler(Object pSender);
    public delegate void SessionTimedOutEventHandler(object pSender, SessionTimedOutEventArgs pArgs);

    public class CChatEntityArgs : EventArgs
    {
        private String msEntityName;
        private ChatEntityType meEntityType;
        private int miEntityId;

        public CChatEntityArgs(String sEntityName, ChatEntityType eEntityType, int iEntityId)
        {
            msEntityName = sEntityName;
            meEntityType = eEntityType;
            miEntityId = iEntityId;
        }

        public String EntityName { get { return msEntityName; } }
        public ChatEntityType EntityType { get { return meEntityType; } }
        public int EntityId { get { return miEntityId; } }
    }

    public delegate void ChatEntityHandler(Object pSender, CChatEntityArgs pArgs);

    public class CChatURLArgs : EventArgs
    {
        private int miCallId;
        private String msURL;
        private ChatEntityType meEntityType;
        private String msEntityName;

        public CChatURLArgs(int iCallId, ChatEntityType eEntityType, String sEntityName, String sURL)
        {
            miCallId = iCallId;
            msURL = sURL;
            msEntityName = sEntityName;
            meEntityType = eEntityType;
        }

        public String URL { get { return msURL; } }
        public int CallId { get { return miCallId; } }
        public String EntityName { get { return msEntityName; } }
        public ChatEntityType EntityType { get { return meEntityType; } }
    }

    public delegate void ChatURLHandler(Object pSender, CChatURLArgs pArgs);


    public class CChatMessageArgs : EventArgs
    {
        private int miCallId;
        private String msMessage;
        private ChatEntityType meEntityType;
        private String msEntityName;

        public CChatMessageArgs(int iCallId, ChatEntityType eEntityType, String sEntityName, String sMessage)
        {
            miCallId = iCallId;
            msMessage = sMessage;
            msEntityName = sEntityName;
            meEntityType = eEntityType;
        }

        public String Message { get { return msMessage; } }
        public int CallId { get { return miCallId; } }
        public String EntityName { get { return msEntityName; } }
        public ChatEntityType EntityType { get { return meEntityType; } }
    }

    public delegate void ChatMessageHandler(Object pSender, CChatMessageArgs pArgs);

    /// <summary>
	/// Summary description for CEventManager.
	/// </summary>
	internal class CEventManager
	{
		public CState CurrentState{get{return mpManagerHelper.CurrentState;}}

		private Thread mpEventProcessingThread;
		private Queue mpEventQueue;
		private Hashtable mpEventHandlers;
		private CApp mpApp;
		private CEventManagerHelper mpManagerHelper;

		public CEventManager(CApp pApp)
		{
			mpApp = pApp;
			mpManagerHelper = new CEventManagerHelper(pApp);

			//Create Event-Handler mapping
			mpEventHandlers = CreateEventMap();

            //Create event queue
            mpEventQueue = new Queue();

			mpEventProcessingThread = new Thread(new ThreadStart(this.ProcessEvents));	
			mpEventProcessingThread.IsBackground = true;
			mpEventProcessingThread.Start();

			//Subscribe to events
			mpApp.Portal.EventArrival += new EventArrivalHandler(this.EventArrived);
		}
		
		private void EventArrived(Object pSender, CEventArrivalArgs pArgs)
		{
			lock(mpEventQueue)
			{
				Console.WriteLine("Server Event Arrival: Id<" + pArgs.NextEvent.eventId + ">, Payload<" + pArgs.NextEvent.payload.GetType() + ">");

				//Add event to queue
				mpEventQueue.Enqueue(new CAgentEvent(pArgs.NextEvent.eventId, pArgs.NextEvent.payload));
				
				//Signal processing thread that an event is available
				Monitor.Pulse(mpEventQueue);
			}
		}
		
		internal void RaiseEvent(AgentEventType eEventId, Object pPayload)
		{
			RaiseEvent(eEventId, pPayload, true);
		}
		
		internal void ActivateCall(CCall pCall)
		{
			EPAgentWS.UDFocus oFocus = new EPAgentWS.UDFocus();
			oFocus.callId = pCall.callID; 
			oFocus.callIdTo = pCall.callID;
			
			mpApp.Portal.WSAgent.focus(mpApp.CurrentAgent.AgentArg, oFocus);

			//If request goes through successfully then activate the call
            CCall pDeactivatedCall = mpApp.CallManager.CurrentCall;
            mpApp.CallManager.CurrentCall = pCall;

            mpManagerHelper.SetApplicationState(pCall.CurrentState.Id, null, pCall);

            mpApp.OnCallActivated(new CCallActivatedArgs(pDeactivatedCall, mpApp.CallManager.CurrentCall));

            mpManagerHelper.FireStateChangeEvents();
        }

		internal void RaiseEvent(AgentEventType eEventId, Object pPayload, bool bAsync)
		{
			lock(mpEventQueue)
			{
				CAgentEventRaised pEvent = new CAgentEventRaised((int)eEventId, pPayload);

				if (bAsync)
				{
					Console.WriteLine("Raised Event Arrival: Id<" + eEventId + ">, Payload<" + (pPayload == null ? "null" : pPayload.GetType().ToString()) + ">, Async<" + bAsync + ">");
					
					//Add event to queue
					mpEventQueue.Enqueue(pEvent);
					
					//Signal processing thread that an event is available
					Monitor.Pulse(mpEventQueue);
				}
				else
				{
					ProcessEvent(pEvent);
				}
			}
		}
		
		private void ProcessEvents()
		{
			//Process all events in queue, pause thread when queue empty
			lock(mpEventQueue)
			{
				while(true)
				{
					if (mpEventQueue.Count == 0)
						Monitor.Wait(mpEventQueue);
					
					//Get next event in queue and process it
					ProcessEvent((CAgentEvent)mpEventQueue.Dequeue());	
				}
			}
		}
		
		private void ProcessEvent(CAgentEvent pEvent)
		{
			//Send event to its handler for processing
			try
			{
				IEventHandler pEventHandler = (IEventHandler)mpEventHandlers[(AgentEventType)pEvent.Id];
				pEventHandler.ProcessEvent(pEvent);
			}
			catch(Exception pError)
			{
				Console.WriteLine(pError.StackTrace);
			}
		}
		
		private Hashtable CreateEventMap()
		{
			
			Hashtable oEventHandlers = new Hashtable();
			oEventHandlers.Add(AgentEventType.aeLOGINCONF, new CHandlerLoginConf(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeLOGGINGIN, new CHandlerLoggingIn(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aePASSCODE, new CHandlerPasscode(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeNEWSERVICE, new CHandlerNewService(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeLOGIN , new CHandlerLogin(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeIDLE, new CHandlerIdle(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeLOGOUT , new CHandlerLogout(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeSCREENPOP, new CHandlerScreenpop(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeACTIVE, new CHandlerActive(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeWRAP, new CHandlerWrap(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeCALLCLEAR, new CHandlerCallClear(mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aePREVIEW, new CHandlerPreview(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeLOGOUTPENDING, new CHandlerLogoutPending (mpApp, mpManagerHelper)); 
			oEventHandlers.Add(AgentEventType.aeBADPASSCODE, new CHandlerBadPasscode(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeAUTHENTICATED, new CHandlerAuthenticated(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeACTIVATECALL, new CHandlerActivateCall(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeDIALING, new CHandlerDialing(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeUPDATEEXTERNALROUTE, new CHandlerUpdateExternalRoute(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeUPDATEAGENTSTATUSREASONS, new CHandlerUpdateAgentStatusReasons(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeHELD, new CHandlerHeld(mpApp, mpManagerHelper));
			oEventHandlers.Add(AgentEventType.aeSYSTEMWAIT, new CHandlerSystemWait(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeNOTREADY, new CHandlerNotReady(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCONSULT, new CHandlerConsulting(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCALLRELEASEDXFERRED, new CHandlerCallReleasedXferred(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCONFERENCE, new CHandlerConference(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCALLREROUTED, new CHandlerCallReRouted(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCALLXFERRED, new CHandlerCallXferred(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeAUDIOPATHCONNECTION, new CHandlerAudioPathConnection(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeERROR, new CHandlerError(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCHATENTITYADDED, new CHandlerChatEntityAdded(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCHATENTITYREMOVED, new CHandlerChatEntityRemoved(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCHATURL, new CHandlerChatURL(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeCHATMESSAGE, new CHandlerChatMessage(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeWRAPTIMEOUT, new CHandlerWrapTimeout(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeSESSIONTIMED_OUT, new SessionTimedOutEventMessageHandler(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeAGENTSTATS, new AgentStatsEventMessageHandler(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeNOTREADYPENDING, new NotReadyPendingEventMessageHandler(mpApp, mpManagerHelper));
            oEventHandlers.Add(AgentEventType.aeUPDATESERVICE, new CHandlerUpdateService(mpApp, mpManagerHelper));
            return oEventHandlers;
		}
	}

	internal class CEventManagerHelper
	{
		internal CState CurrentState{get{return mpCurrentState;}}
		
		private CState mpCurrentState;
		private CApp mpApp;
        private Queue mpStateChangeQueue=new Queue();
        //internal void RemoveRemainingCalls()
        //{
        //    //Remove any rejected or timedout call offerings
        //    while (mpApp.CallManager.Count > 0)
        //    {
        //        CCall pCall = mpApp.CallManager[mpApp.CallManager.Count - 1];
        //        Console.WriteLine("Removing call <{0}>...", pCall.CallID);
        //        mpApp.CallManager.RemoveAt(mpApp.CallManager.Count - 1);
        //    }
        //}
        internal void RemoveRemainingCalls()
        {
            try
            {
                int lastCallClearCallId = ProcessChecker.LastCallClearCallId;
                //this.logFile.LogMessageToFile(" |INFO| CEventManager.RemoveRemainingCalls(), CallIdToClear <" + lastCallClearCallId.ToString() + ">...");
                bool flag1 = false;
                bool flag2 = ProcessChecker.CheckAndSetIsLine1(lastCallClearCallId);
                if (!flag2)
                {
                    ProcessChecker.Line2Busy = false;
                    if (ProcessChecker.Line1Busy)
                        ProcessChecker.ActiveLine = 1;
                }
                else
                {
                    ProcessChecker.Line1Busy = false;
                    if (ProcessChecker.Line2Busy)
                        ProcessChecker.ActiveLine = 2;
                }
               // this.logFile.LogMessageToFile(" |INFO| CEventManagerHelper.RemoveRemainingCalls(), Active line is [ " + ProcessChecker.ActiveLine.ToString() + "]  .");
                if (this.mpApp.CallManager.Count > 0)
                {
                   // LogFile logFile1 = this.logFile;
                    string[] strArray1 = new string[7]
                    {
            " |INFO| CEventManager.RemoveRemainingCalls(), Current service <",
            this.mpApp.CurrentService?.ToString(),
            "> , Required Wrap <",
            null,
            null,
            null,
            null
                    };
                    WrapType requireWrap = this.mpApp.CurrentService.RequireWrap;
                    strArray1[3] = requireWrap.ToString();
                    strArray1[4] = "> , Call Type<";
                    AgentCallType callType = this.mpApp.CurrentCall.CallType;
                    strArray1[5] = callType.ToString();
                    strArray1[6] = ">...";
                    string message1 = string.Concat(strArray1);
                   // logFile1.LogMessageToFile(message1);
                    CCall byKey1 = this.mpApp.CallManager.GetByKey(lastCallClearCallId);
                    if (byKey1 == null)
                    {
                        this.mpApp.CallManager.CurrentCall = this.GetOtherCall(lastCallClearCallId);
                    }
                    else
                    {
                        if (flag2 && this.mpApp.AssignedServices.Contains((object)byKey1.serviceID))
                        {
                            CService byKey2 = this.mpApp.AssignedServices.GetByKey((object)byKey1.serviceID);
                            if (byKey2 != null)
                            {
                             //   LogFile logFile2 = this.logFile;
                                string[] strArray2 = new string[7]
                                {
                  " |INFO| CEventManager.RemoveRemainingCalls(), fetched service <",
                  byKey2?.ToString(),
                  "> , Required Wrap <",
                  null,
                  null,
                  null,
                  null
                                };
                                requireWrap = byKey2.RequireWrap;
                                strArray2[3] = requireWrap.ToString();
                                strArray2[4] = "> , Call Type<";
                                callType = byKey1.CallType;
                                strArray2[5] = callType.ToString();
                                strArray2[6] = ">...";
                                string message2 = string.Concat(strArray2);
                               // logFile2.LogMessageToFile(message2);
                                if (byKey2.RequireWrap == WrapType.wtREQUIRED)
                                    flag1 = true;
                            }
                        }
                        if (byKey1.CallType != AgentCallType.acDID & flag1)
                            return;
                        Console.WriteLine("Removing call <{0}>...", (object)byKey1.CallID);
                       // this.logFile.LogMessageToFile(" |INFO| CEventManager.RemoveRemainingCalls(), Removing call <" + byKey1.CallID.ToString() + ">...");
                        this.mpApp.CallManager.RemoveByKey(byKey1.CallID);
                    }
                }
                else
                    this.mpApp.CallManager.CurrentCall = (CCall)null;
            }
            catch (Exception ex)
            {
                //this.logFile.LogMessageToFile(" |ERROR| CEventManager.RemoveRemainingCalls(),  <" + ex?.ToString() + ">...");
            }
        }

        internal CCall GetOtherCall(int callId)
        {
            CCall otherCall = (CCall)null;
            foreach (CCall ccall in (CList)this.mpApp.CallManager)
            {
                if (ccall.CallID != callId)
                {
                    otherCall = ccall;
                    break;
                }
            }
            //this.logFile.LogMessageToFile(" |INFO| CEventManager.GetOtherCall(),  Current call id changed to <" + otherCall.CallID.ToString() + ">...");
            return otherCall;
        }
        internal CEventManagerHelper(CApp pApp)
		{
			mpApp = pApp;	
            mpCurrentState = CreateState(AgentStateId.asLOGGED_OUT);
		}

		private CState CreateState(AgentStateId eState, CCallGeneric pCall)
		{	
			if (pCall == null)
				throw new ArgumentNullException("pCall", "The creation of state <" + eState + "> requires the Call parameter.");

            switch (eState)
            {

                case AgentStateId.asDIALING:
                    return (CState)new CStateDialing(AgentStateId.asDIALING, "Preview", Color.Cyan, Color.Black, this.mpApp, pCall);
                case AgentStateId.asDIALING_CONSULTATION:
                    return (CState)new CStateDialingConsultation(AgentStateId.asDIALING_CONSULTATION, "Dialing Consult.", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                case AgentStateId.asRINGING:
                    return (CState)new CStateRinging(AgentStateId.asRINGING, "Ringing", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                case AgentStateId.asINACTIVE:
                    return (CState)new CStateInactive(AgentStateId.asINACTIVE, "Inactive", Color.LightGray, Color.Black, this.mpApp, pCall);
                case AgentStateId.asPREVIEW:
                    return (CState)new CStatePreview(AgentStateId.asPREVIEW, "Preview", Color.DarkOrange, Color.White, this.mpApp, pCall);
                case AgentStateId.asACTIVE:
                    return (CState)new CStateActive(AgentStateId.asACTIVE, "Active", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                case AgentStateId.asACTIVE_INTERNAL:
                    return (CState)new CStateActiveInternal(AgentStateId.asACTIVE_INTERNAL, "Internal", Color.MediumSeaGreen, Color.White, this.mpApp, pCall);
                case AgentStateId.asWRAP:
                    return (CState)new CStateWrap(AgentStateId.asWRAP, "Wrap", Color.Yellow, Color.Black, this.mpApp, pCall);
                case AgentStateId.asHELD:
                    return (CState)new CStateHeld(AgentStateId.asHELD, "Held", Color.Red, Color.White, this.mpApp, pCall);
                case AgentStateId.asCONSULTING:
                    return (CState)new CStateConsulting(AgentStateId.asCONSULTING, "Consulting", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                case AgentStateId.asCONFERENCE:
                    return (CState)new CStateConference(AgentStateId.asCONFERENCE, "Conference", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                case AgentStateId.asCHATTING:
                    return (CState)new CStateChatting(AgentStateId.asCHATTING, "Chatting", Color.LimeGreen, Color.Black, this.mpApp, pCall);
                default:
                    throw new ArgumentOutOfRangeException();
            }
		}

		private CState CreateState(AgentStateId eState)
		{
			switch (eState)
			{
                case AgentStateId.asLOGGING_IN:
                    return (CState)new CStateLoggingIn(AgentStateId.asLOGGING_IN, "Logging In", Color.Gray, Color.Black, this.mpApp);
                case AgentStateId.asAUTHENTICATED:
                    return (CState)new CStateAuthenticated(AgentStateId.asAUTHENTICATED, "Authenticated", Color.LightGray, Color.Black, this.mpApp);
                case AgentStateId.asIDLE:
                    return (CState)new CStateIdle(AgentStateId.asIDLE, "Idle", Color.Blue, Color.White, this.mpApp);
                case AgentStateId.asACTIVE_INTERNAL:
                    return (CState)new CStateActiveInternal(AgentStateId.asACTIVE_INTERNAL, "Internal", Color.MediumSeaGreen, Color.White, this.mpApp, (CCallGeneric)null);
                case AgentStateId.asWRAP:
                    return (CState)new CStateWrap(AgentStateId.asWRAP, "Wrap", Color.Red, Color.White, this.mpApp, (CCallGeneric)null);
                case AgentStateId.asHELD:
                    return (CState)new CStateHeld(AgentStateId.asHELD, "Held", Color.Red, Color.White, this.mpApp, (CCallGeneric)null);
                case AgentStateId.asWAITING:
                    return (CState)new CStateWaiting(AgentStateId.asWAITING, "Waiting", Color.Cyan, Color.Black, this.mpApp);
                case AgentStateId.asLOGGED_OUT:
                    return (CState)new CStateLoggedOut(AgentStateId.asLOGGED_OUT, "Logged Out", Color.Gray, Color.Black, this.mpApp);
                case AgentStateId.asNOT_READY:
                    return (CState)new CStateNotReady(AgentStateId.asNOT_READY, "Not Ready", Color.Red, Color.White, this.mpApp);
                case AgentStateId.asPARKED:
                    return (CState)new CStateParked(AgentStateId.asPARKED, "Parked", Color.Red, Color.White, this.mpApp);
                default:
                    throw new ArgumentOutOfRangeException();
            }
		}

        //Fires all state change events queued by methods SetApplicationState and SetCallState. Some call states depend on the 
        //the current application state and viceversa (see EnableHangup property of CCallState) therefore we need to update both 
        //the application state and the call state before firing their corresponding state change events and invoking code that 
        //depend on the two state types being in-sync.
        internal void FireStateChangeEvents()
        {
            try
            {
                while (mpStateChangeQueue.Count > 0)
                {
                    Object pStateEventArgs = mpStateChangeQueue.Dequeue();
                    
                    if (pStateEventArgs is CUnfocusedCallStateChangeArgs)
                        mpApp.OnUnfocusedCallStateChange((CUnfocusedCallStateChangeArgs)pStateEventArgs);

                    else if (pStateEventArgs is CCallStateChangeArgs)
                        mpApp.OnCallStateChange((CCallStateChangeArgs)pStateEventArgs);
                    
                    else if (pStateEventArgs is CUnfocusedStateChangeArgs)
                        mpApp.OnUnfocusedStateChange((CUnfocusedStateChangeArgs)pStateEventArgs);

                    else if (pStateEventArgs is CStateChangeArgs)
                        mpApp.OnStateChange((CStateChangeArgs)pStateEventArgs);
                    
                    else
                        Console.WriteLine("Error - Invalid StateChange Args <" + pStateEventArgs.GetType() + ">.");
                }
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        //Sets the state of the application for states not associated with a current call.
        internal void SetApplicationState(AgentStateId eState, CAgentEvent pEvent)
		{
			if (mpCurrentState != null)
				mpCurrentState.Exit();

			mpCurrentState = CreateState(eState);
			mpCurrentState.Enter(pEvent);

            //Fire StateChange event
			//mpApp.OnStateChange(new CStateChangeArgs(mpCurrentState));
            mpStateChangeQueue.Enqueue(new CStateChangeArgs(mpCurrentState));
		}

        //Sets the main state of the specified call. The main state of the current call dictates the state of the application.
        //The main state (CCall.currentState) of the call can differ from the individual state (CCall.XPartyCall.currentState) of the call (eg, the main state of a call may be "Consulting" 
        //while the individual state of the call is "Held" or "Active". To change the call's state the method "SetCallState" is used instead.
		internal void SetApplicationState(AgentStateId eState, CAgentEvent pEvent, CCall pCall)
		{	
			//Exit the app's current state if this call is the current call.
			//Otherwise, exit the call's current state.
			if (mpCurrentState != null && mpApp.CurrentCall == pCall)
				mpCurrentState.Exit();
			else if (pCall.currentState != null)
				pCall.currentState.Exit();
				

			//Set the call's new state and enter it
			pCall.currentState = CreateState(eState, pCall);
			pCall.currentState.Enter(pEvent);
		
			//If call is the current call then update the app's current state and
			//raise the StateChange event.
			if (pCall == mpApp.CurrentCall)
			{
				mpCurrentState = pCall.currentState;
				//mpApp.OnStateChange(new CStateChangeArgs(mpCurrentState));
                mpStateChangeQueue.Enqueue(new CStateChangeArgs(mpCurrentState));
			}
			//Otherwise, raise the Unfocused_StateChange event.
			else
			{
				//mpApp.OnUnfocusedStateChange(new CUnfocusedStateChangeArgs(pCall.currentState, pCall));
                mpStateChangeQueue.Enqueue(new CUnfocusedStateChangeArgs(pCall.currentState, pCall));
			}
		}

        //Sets the individual state of the specified call. Does not change the call's main state. The main state of the current call dictates the state of the application.
        //The main state (CCall.currentState) of the call can differ from the individual state (CCall.XPartyCall.currentState) of the call (eg, the main state of a call may be "Consulting" 
        //while the individual state of the call is "Held" or "Active". To change the call's main state the method "SetApplicationState" is used instead.
        internal void SetCallState(AgentStateId eState, CAgentEvent pEvent, C3WayCall pCall)
        {
            if (pCall.currentState != null)
                pCall.currentState.Exit();

            //Set the call's new state. 
            pCall.currentState = CreateState(eState, pCall);

            pCall.currentState.Enter(pEvent);
		
            //If call is associated with the current call (1stPartyCall, 3rdPartyCall, or ConferenceCall of current call) then 
            //raise the CallStateChange event.
            if (pCall.parentCall == mpApp.CurrentCall)
                //Raise the CallStateChange event
                //mpApp.OnCallStateChange(new CCallStateChangeArgs(pCall.currentState, pCall));
                mpStateChangeQueue.Enqueue(new CCallStateChangeArgs(pCall.currentState, pCall));

            //Otherwise, raise the UnfocusedCallStateChange event.
            else
                //mpApp.OnUnfocusedCallStateChange(new CCallStateChangeArgs(pCall.currentState, pCall));
                mpStateChangeQueue.Enqueue(new CUnfocusedCallStateChangeArgs(pCall.currentState, pCall));
        }

		internal void ProcessCallAppearance(CCall pCall)
		{
			//If call's service has not yet been loaded, check if it still exists. If it does then
			//load it; otherwise, associate call with the default service;
			if (!mpApp.AssignedServices.Contains(pCall.serviceID))
			{
				//if (mpApp.ServiceExists(pCall.serviceID))
				try
                {
                    mpApp.AssignedServices.Load(pCall.serviceID);
				}
                catch (Exception pError)
                {
                    Console.WriteLine(pError.StackTrace);
                    pCall.serviceID = 0;
                }
			}

			//Add call to list
			mpApp.CallManager.Add(pCall.CallID, pCall);
			
			//Increment total calls of call's service
			mpApp.AssignedServices.GetByKey(pCall.serviceID).totalCalls++;

			//Fire screenpop event
			mpApp.OnScreenpop(new CScreenpopArgs(pCall));

			//If call is the only one or is preemptive then it is already 
			//activated so set it as the current call
            if (mpApp.CallManager.Count == 1 || Convert.ToBoolean(pCall.preemptive))
            {
                CCall pDeactivatedCall = mpApp.CallManager.CurrentCall;
                mpApp.CallManager.CurrentCall = pCall;
                if (pDeactivatedCall != null)
                    mpApp.OnCallActivated(new CCallActivatedArgs(pDeactivatedCall, pCall));
            }
		}

       
	}

	internal interface IEventHandler
	{
		void ProcessEvent(CAgentEvent pEvent);
	}

	internal class CHandlerLoginConf: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerLoginConf(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}
		
		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDLoginConf pEventData = (UDLoginConf)pEvent.Payload;
            mpApp.CurrentAgent.agentType = pEventData.agentType;
			mpApp.CurrentAgent.referenceId = pEventData.referenceID;
			mpApp.CurrentAgent.agentIndex = pEventData.agentIndex; 

			mpApp.EnableKeepAlives = true;
		}
	}

	internal class CHandlerLogin: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerLogin(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDLogin pEventData = (UDLogin)pEvent.Payload;
			mpApp.CurrentAgent.gatewayId = pEventData.ntSwitchId;

            mpApp.OnLoggedIn();
		}
	}

	internal class CHandlerLoggingIn: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerLoggingIn(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			mpEventHelper.SetApplicationState(AgentStateId.asLOGGING_IN, pEvent);
            mpEventHelper.FireStateChangeEvents();
		}
	}
	
	internal class CHandlerPasscode: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerPasscode(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDPasscode pEventData = (UDPasscode)pEvent.Payload;
			mpApp.OnPasscode(new CPasscodeArgs(pEventData.code, true));
		}
	}
	
	internal class CHandlerNewService: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerNewService(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDNewService pEventData = (UDNewService)pEvent.Payload;
			
			//If the service is already loaded, then it is a service from which the agent
			//was recently removed but to which it has been reassigned so clear its removed flag.
			if (mpApp.AssignedServices.Contains(pEventData.serviceID))
				mpApp.AssignedServices.GetByKey(pEventData.serviceID).removed = false;
			//Otherwise, load the service
			else
                //mpApp.AssignedServices.Load(pEventData.serviceID);
                mpApp.AssignedServices.Load(pEventData);
		}
	}

    internal class CHandlerNotReady : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerNotReady(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDNotReady pEventData = (UDNotReady)pEvent.Payload;

            mpApp.CallManager.CurrentCall = null;

            //Remove any rejected or timedout call offerings
           // mpEventHelper.RemoveRemainingCalls();
			
            if (pEventData.toParkState)
                mpEventHelper.SetApplicationState(AgentStateId.asPARKED, pEvent);
            else
                mpEventHelper.SetApplicationState(AgentStateId.asNOT_READY, pEvent);

            mpEventHelper.FireStateChangeEvents();
        }
    }

    internal class CHandlerAudioPathConnection : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerAudioPathConnection(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDAudioPathConnection pEventData = (UDAudioPathConnection)pEvent.Payload;

            mpApp.OnPhoneStatus(new CPhoneStatusArgs(pEventData.audioPath));
        }
    }

	internal class CHandlerIdle: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerIdle(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
            UDIdle payload = (UDIdle)pEvent.Payload;
            if (payload != null && payload.statusReason == 0)
            {
                this.mpApp.CallManager.ClearAll();
                mpApp.CallManager.CurrentCall = null;
            }
            else
                //Remove any rejected or timedout call offerings
                mpEventHelper.RemoveRemainingCalls();
            if (this.mpApp.CurrentCall == null)
            {
                ProcessChecker.Line1Busy = false;
                ProcessChecker.Line2Busy = false;
                ProcessChecker.ActiveLine = 0;
                mpEventHelper.SetApplicationState(AgentStateId.asIDLE, pEvent);
            }
            else if (this.mpApp.CurrentCall.CurrentState.Description.ToUpper() == "HELD" || this.mpApp.CurrentCall.CurrentState.Description.ToUpper() == "HOLD")
                this.mpApp.ReleaseHold();
            mpEventHelper.FireStateChangeEvents();
            ProcessChecker.Is3Way = false;
            ProcessChecker.LastCallClearCallId = 0;
        }
	}

	internal class CHandlerSystemWait: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerSystemWait(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			mpEventHelper.SetApplicationState(AgentStateId.asWAITING, pEvent);
            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerAuthenticated: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerAuthenticated(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			mpEventHelper.SetApplicationState(AgentStateId.asAUTHENTICATED, pEvent);
            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerLogout: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerLogout(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			//if (!(pEvent is CAgentEventRaised))
			//{
				//Stop sending KeepAlives
				mpApp.EnableKeepAlives = false;
				
				try
				{
					mpApp.Portal.Unregister(mpApp.CurrentAgent.AgentArg);
				}
				catch(Exception pError)
				{
					Console.WriteLine(pError.StackTrace);
				}
			//}

			//Transition to logout
			mpEventHelper.SetApplicationState(AgentStateId.asLOGGED_OUT, pEvent);
            mpEventHelper.FireStateChangeEvents();
        }
	}
	
	internal class CHandlerScreenpop: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerScreenpop(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			//Load call from event
			CCall pCall = mpApp.CallManager.CreateCall((UDScreenPop)pEvent.Payload);
			
			mpEventHelper.ProcessCallAppearance(pCall);

			//Go to Ringing state
			mpEventHelper.SetApplicationState(AgentStateId.asRINGING, pEvent, pCall);
            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerDialing: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerDialing(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDDialing pEventData = (UDDialing)pEvent.Payload;

            Console.WriteLine("Dialing CallId<{0}>, CallType<{1}> ...\t[{2}]", pEventData.callID, pEventData.statusReason, this.GetType());
			
			//If dialing a previewed call...
			if (pEventData.statusReason == (int)AgentMediaType.amOUTBOUND_AOD)
			{
				//Retrieve the previewed call
                CCall pAODCall = mpApp.CallManager.GetByKey(pEventData.callID);

                //Go to Dialing state
                mpEventHelper.SetApplicationState(AgentStateId.asDIALING, pEvent, pAODCall);
                mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, ((CCallVoice)pAODCall).FirstPartyCall);
            }

            else if (pEventData.statusReason == (int)AgentMediaType.amINTERNAL_CONSULT || pEventData.statusReason == (int)AgentMediaType.amOUTBOUND_CONSULT)
            {
                //Retrieve pending Consultation Call
                C3WayCall3rdParty pConsultationCall = mpApp.ThreeWayCallManager.PendingConsultationCall;
                mpApp.ThreeWayCallManager.PendingConsultationCall = null;

                //Update it and add it to the call list
                pConsultationCall.callID = pEventData.callID;
                pConsultationCall.mediaType = (AgentMediaType)pEventData.statusReason;

                mpApp.ThreeWayCallManager.Add(pConsultationCall.callID, pConsultationCall);

                //Go to Dialing_Consultation state on parent call and to Dialing state on 3rdParty call
                mpEventHelper.SetApplicationState(AgentStateId.asDIALING_CONSULTATION, pEvent, pConsultationCall.ParentCall);
                //hendro
                mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, pConsultationCall);
            }

            //Otherwise (dialing a manual call)...
            else
            {
                CState currentState = this.mpApp.CurrentState;

                //Retrieve pending Manual Call
                CCall pCall = mpApp.CallManager.PendingManualCall;
                mpApp.CallManager.PendingManualCall = null;

                //Update it and add it to the call list
                pCall.callID = pEventData.callID;

                mpApp.CallManager.Add(pCall.CallID, pCall);

                //Increment total calls of call's service
                mpApp.AssignedServices.GetByKey(pCall.serviceID).totalCalls++;

                //If call is the only one or is preemptive then it is already 
                //activated so set it as the current call
                //if (mpApp.CallManager.Count == 1 || Convert.ToBoolean(pCall.preemptive))
                    mpApp.CallManager.CurrentCall = pCall;

                //Go to Dialing state
                mpEventHelper.SetApplicationState(AgentStateId.asDIALING, pEvent, pCall);
                mpEventHelper.SetCallState(AgentStateId.asDIALING, pEvent, ((CCallVoice)pCall).FirstPartyCall);
            }


            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerActive: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerActive(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDActive pEventData = (UDActive)pEvent.Payload;

            //If the call is a main call...
            if (mpApp.CallManager.Contains(pEventData.callID))
            {
                CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);

                //We can receive an Active event for the main call in two scenarios:
                //1. If the call is going Active for the fist time.
                //2. If the call was retrieved from Hold.
                //If scenario #1, then initialize the call and set the call's state to Active
                //If scenario #2, then just set the call's state back to Active

                //If the main call is held, then just set state back to Active for both main and firstparty calls
                if (pCall.CurrentState is CStateHeld)
                {
                    if (pCall.MediaType == AgentMediaType.amINTERNAL_MANUAL)
                        mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall);
                    else
                        mpEventHelper.SetApplicationState(AgentStateId.asACTIVE, pEvent, pCall);


                    mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.FirstPartyCall);
                }

                //elseif the main call is consulting, dialing_consultation, or conferenced, then just set state back to Active for firstparty call.
                else if (pCall.CurrentState is CStateDialingConsultation || pCall.CurrentState is CStateConsulting || pCall.CurrentState is CStateConference)
                {
                    mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.FirstPartyCall);

                    //If the 3rd party call's state is Held, set its state to Held again to trigger a state change on it
                    //so the client updates its 3rd Party RetrieveHold button correctly (ie, disable retrieveHold on the 3rd party).
                    if (((CCallVoice)pCall).ThirdPartyCall.CurrentState is CStateHeld)
                        mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, ((CCallVoice)pCall).ThirdPartyCall);
                }

                //else, this is the first time the call goes to Active so initialize it with data from event and set the state to Active for both main and firstparty call
                else
                {
                    pCall.mediaType = (AgentMediaType)pEventData.mediaType;

                    switch (pCall.MediaType)
                    {
                        case AgentMediaType.amINTERNAL_MANUAL:
                        
                        case AgentMediaType.amINTERNAL_CONSULT:
                            mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall);
                            break;
                        
                        case AgentMediaType.amINBOUND_CHAT:
                            ((CCallChat)pCall).chatServerIP = pEventData.IPAddress;
                            ((CCallChat)pCall).chatServerPort = pEventData.portNumber;

                            mpApp.ConnectToChatServer((CCallChat)pCall);
                            
                            mpEventHelper.SetApplicationState(AgentStateId.asCHATTING, pEvent, pCall);
                            break;

                        default:
                            mpEventHelper.SetApplicationState(AgentStateId.asACTIVE, pEvent, pCall);
                            break;
                    }

                    mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.FirstPartyCall);

                    //Initialize the 3rdParty and Conference calls of this new voice call.
                    if (pCall is CCallVoice)
                    {
                        CCallVoice pVoiceCall = (CCallVoice)pCall;
                        if (pVoiceCall.ThirdPartyCall.CurrentState == null)
                            mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pVoiceCall.ThirdPartyCall);

                        if (pVoiceCall.ConferenceCall.CurrentState == null)
                            mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pVoiceCall.ConferenceCall);
                    }
                }
            }
            //If the call is a 3WayCall (ie, the 3rdParty call)...
            else if (mpApp.ThreeWayCallManager.Contains(pEventData.callID))
            {
                C3WayCall pConsultationCall = mpApp.ThreeWayCallManager.GetByKey(pEventData.callID);

                //The only way we can receive an Active event for the 3rdParty call is if we retrieved it from Hold
                //so just set the state of the 3rdParty call back to Active.
                mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pConsultationCall);

                //If the 1st party call's state is Held, set its state to Held again to trigger a state change on it
                //so the client updates its 1st Party RetrieveHold button correctly (ie, disable retrieveHold on the 3rd party).
                if (pConsultationCall.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
                    mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, pConsultationCall.ParentCall.FirstPartyCall);
            }
            
            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerWrap: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerWrap(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
        {
            UDWrap payload = (UDWrap)pEvent.Payload;
            CCall byKey1 = this.mpApp.CallManager.GetByKey(payload.callID);
            ProcessChecker.LastCallClearCallId = byKey1.CallID;

            UDWrap pEventData = (UDWrap)pEvent.Payload;
			
			CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);
			
			//If call's service doesn't require wrap then auto dispose the call
			CService pCurrentService = mpApp.AssignedServices.GetByKey(pCall.ServiceID);

            //If call was an internal consultation, automatically dispose call with default disposition.
            if (pCall.MediaType == AgentMediaType.amINTERNAL_CONSULT )
                mpApp.DisposeCall(mpApp.CurrentCall, null);

            //If call's service doesn't require wrap or a disposition, automatically dispose call with default disposition.
            if (pCurrentService.RequireWrap == WrapType.wtOPTIONAL && !pCurrentService.RequireDisposition)
                mpApp.DisposeCall(mpApp.CurrentCall, null);

            //Otherwise, go to Wrap state.
			else
				mpEventHelper.SetApplicationState(AgentStateId.asWRAP, pEvent, pCall);
        
            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerCallClear: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerCallClear(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
            UDCallClear pEventData = (UDCallClear)pEvent.Payload;

            Console.WriteLine("Processing Call Clear event...CallId<{0}>\t[{1}]", pEventData.callID, this.GetType());
			
            //If event is for a main call...
            if (mpApp.CallManager.Contains(pEventData.callID))
            {
                CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);
                ProcessChecker.LastCallClearCallId = pCall.callID;

                //If event is for a consultation call that had remained Active after the 1st party cleared...
                if (pCall is CCallRemainingConsultation)
                {
                    //Remove the consultation call from the call manager
                    mpApp.CallManager.RemoveByKey(pCall.CallID);

                    //Set the consultation call's state to Inactive
                    mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pCall);
                    mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.FirstPartyCall);

                    //Notify client of current call's state change
                    mpEventHelper.FireStateChangeEvents();

                    //Set the parent call of this consultation call as the current call.
                    mpApp.CallManager.CurrentCall = ((CCallRemainingConsultation)pCall).Root3rdPartyCall.ParentCall;

                    //Refresh the state of the parent call to trigger a StateChange event at the client causing it 
                    //to update the UI.
                    mpEventHelper.SetApplicationState(mpApp.CallManager.CurrentCall.CurrentState.Id, pEvent, mpApp.CallManager.CurrentCall);
                    mpEventHelper.SetCallState(mpApp.CallManager.CurrentCall.FirstPartyCall.CurrentState.Id, pEvent, mpApp.CallManager.CurrentCall.FirstPartyCall);

                    //Notify client that a different call is now the current call
                    mpApp.OnCallActivated(new CCallActivatedArgs(pCall, mpApp.CallManager.CurrentCall));
                }

                //If call is a voice call...
                else if (pCall is CCallVoice)
                {
                    CCallVoice pVoiceCall = (CCallVoice)pCall;

                    //If its third party call is not Inactive then...
                    if (pVoiceCall.ThirdPartyCall.CurrentState != null && !(pVoiceCall.ThirdPartyCall.CurrentState is CStateInactive))
                    {
                        //Remove the consultation call from the threeway call manager.
                        mpApp.ThreeWayCallManager.RemoveByKey(pVoiceCall.ThirdPartyCall.CallID);
                        
                        //Get consultation call's state
                        CState consultationCallState = pVoiceCall.ThirdPartyCall.CurrentState;

                        //Set the state of the consultation call to Inactive
                        mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pVoiceCall.ThirdPartyCall);
                        //Set the state of the consultation's parent call to Inactive (it's probably Consulting or Conference currently).
                        mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pVoiceCall.ThirdPartyCall.ParentCall);

                        //Notify client of current call's state change
                        mpEventHelper.FireStateChangeEvents();

                        //Create a special type of manual call from the consultation call
                        CCallRemainingConsultation pRemainingConsultation = new CCallRemainingConsultation((C3WayCall3rdParty)pVoiceCall.ThirdPartyCall);
                        mpApp.CallManager.Add(pRemainingConsultation.CallID, pRemainingConsultation);

                        //Make that manual call the current call
                        mpApp.CallManager.CurrentCall = pRemainingConsultation;

                        //Set the state of that manual call to that of the consultation. If it was an internal consultation and it
                        //is in the Active state, set the manual call's state to Active Internal.
                        if (consultationCallState is CStateActive && ((C3WayCall3rdParty)pVoiceCall.ThirdPartyCall).MediaType == AgentMediaType.amINTERNAL_CONSULT)
                            mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, pRemainingConsultation);
                        else
                            mpEventHelper.SetApplicationState(consultationCallState.Id, pEvent, pRemainingConsultation);

                        //Set the state of the manual call's 3way calls
                        mpEventHelper.SetCallState(consultationCallState.Id, pEvent, pRemainingConsultation.FirstPartyCall);
                        mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pRemainingConsultation.ThirdPartyCall);
                        mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pRemainingConsultation.ConferenceCall);

                        //Notify client that a different call is now the current call
                        mpApp.OnCallActivated(new CCallActivatedArgs(pVoiceCall.ThirdPartyCall.ParentCall, mpApp.CallManager.CurrentCall));
                    }
                    if (this.mpEventHelper.CurrentState is CStateActiveInternal)
                    {
                        this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall);
                        this.mpEventHelper.SetCallState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall.FirstPartyCall);
                    }
                    else if (this.mpEventHelper.CurrentState is CStateWrap)
                    {
                        this.mpEventHelper.SetApplicationState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall);
                        this.mpEventHelper.SetCallState(AgentStateId.asACTIVE_INTERNAL, pEvent, pCall.FirstPartyCall);
                    }
                  
                    else
                    {
                        //Set the main state of the application and of the FirstParty call to Inactive
                        mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pCall);
                        mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.FirstPartyCall);
                    }
                }
                else
                {
                    //Set the main state of the application and of the FirstParty call to Inactive
                    mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pCall);
                    mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.FirstPartyCall);
                }
                
            }

            //If event is for a 3Way call (ie, 3rdParty call or Conference call)...
            else if (mpApp.ThreeWayCallManager.Contains(pEventData.callID))
            {
                C3WayCall p3WayCall = mpApp.ThreeWayCallManager.GetByKey(pEventData.callID);

                //Set the 3Way call's state to Inactive
                mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, p3WayCall);

                //If the 3Way call is the 3rdParty call... 
                if (p3WayCall is C3WayCall3rdParty)
                {
                    //Set the main state of the application and parent call to the current state of the FirstParty call.
                    //(For example, if the consultation call clears, we change the state of the application to the
                    //state of the remaining call - the first party call - which in this case is usually the Held state)
                    mpEventHelper.SetApplicationState(p3WayCall.ParentCall.FirstPartyCall.CurrentState.Id, pEvent, p3WayCall.ParentCall);

                    //Refresh the state of the 1st party call. That is, set its state to the same state in 
                    //order to trigger a state change on it so the client updates its 1st Party commands  
                    //correctly (eg, enable retrieveHold on the 1st party). In this case, the 1st party will usually 
                    //be in Held state (if was consulting) or in Active (if was in Conference)
                    mpEventHelper.SetCallState(p3WayCall.ParentCall.FirstPartyCall.CurrentState.Id, pEvent, p3WayCall.ParentCall.FirstPartyCall);
                }
                else if (p3WayCall is C3WayCallConference)
                {
                    //No additional steps necessary.
                }
                
                //Remove the reference to the 3Way call from the collection.
                mpApp.ThreeWayCallManager.RemoveByKey(pEventData.callID);
            }
        
            mpEventHelper.FireStateChangeEvents();
        }
	}


    internal class CHandlerCallReleasedXferred : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerCallReleasedXferred(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDCallReleasedXferred pEventData = (UDCallReleasedXferred)pEvent.Payload;
            
            //If event is for a main call...
            if (mpApp.CallManager.Contains(pEventData.callID))
            {
                CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);

                //This event indicates that the main call was transferred to the consulted party so set the state of the 
                //main call to inactive. A "Call Clear" event will follow this one for the consultation call.
                mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pCall);
                
                mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.FirstPartyCall);
            }

            //If event is for a 3Way call (ie, 3rdParty call (if xferred while consulting) or Conference call (if xferred while in conference))....
            else if (mpApp.ThreeWayCallManager.Contains(pEventData.callID))
            {
                C3WayCall p3WayCall = mpApp.ThreeWayCallManager.GetByKey(pEventData.callID);

                //This event indicates that the main call was transferred to the consulted party so set the state of the 
                //main call to inactive. A "Call Clear" event will follow this one for the consultation call.
                mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, p3WayCall.ParentCall);

                mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, p3WayCall.ParentCall.FirstPartyCall);
                
                //When the call is transferred to the consulted party while in Conference, we don't get a Call Clear event
                //for the conference call but we get the conference callid in this event so set its state to Inactive and 
                //remove it from the threeway call manager here. In this case, we do however get a Call Clear event for the 
                //consultation call.
                if (p3WayCall is C3WayCallConference)
                {
                    mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, p3WayCall);
                    mpApp.ThreeWayCallManager.RemoveByKey(pEventData.callID);
                }
            }

            mpEventHelper.FireStateChangeEvents();
        }
    }


    internal class CHandlerCallReRouted : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerCallReRouted(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDCallReRouted pEventData = (UDCallReRouted)pEvent.Payload;

            //This is the only event we'll get after a successful blind transfer to a service so
            //set the 1st party state and main state to Inactive. This event is basically equivalent to a Call Clear on
            //the first party.
            if (mpApp.CallManager.Contains(pEventData.callID))
            {
                CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);
                ProcessChecker.LastCallClearCallId = pCall.CallID;

                //This event indicates that the main call was transferred (typically to some service) so set the state 
                //of the main call to inactive. 
                mpEventHelper.SetApplicationState(AgentStateId.asINACTIVE, pEvent, pCall);

                mpEventHelper.SetCallState(AgentStateId.asINACTIVE, pEvent, pCall.FirstPartyCall);
            }

            mpEventHelper.FireStateChangeEvents();
        }
    }

    internal class CHandlerCallXferred : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerCallXferred(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDCallXferred pEventData = (UDCallXferred)pEvent.Payload;

            //This event is received by a consulted agent when the consulting Agent transfers the call to him.
            //It contains the callid from the Screenpop received by the consulted Agent and a new callid which the 
            //consulted agent should from now use when refering to the transferred call.

            Console.WriteLine("OriginalCallId<{0}>, ConsultCallId<{1}>, NewCallId<{2}>\t[{3}]", pEventData.originalCallID, pEventData.consultCallID, pEventData.newCallID, this.GetType());

            CCall pCall=null;
            if (mpApp.CallManager.Contains(pEventData.consultCallID))
            {
                pCall = mpApp.CallManager.GetByKey(pEventData.consultCallID);
                mpApp.CallManager.RemoveByKey(pEventData.consultCallID);

                //Update the received consultation's callid
                pCall.callID = pEventData.newCallID;

                //Add the call back to the manager but associate with the new callid
                mpApp.CallManager.Add(pCall.callID, pCall);
            }
        }
    }

    internal class CHandlerConference: IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerConference(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDConference pEventData = (UDConference)pEvent.Payload;

            //Get the main call associated with this conference call. We're in Conference 
            //so we can assume the call is a voice call.
            CCallVoice pCall = (CCallVoice)mpApp.CallManager.GetByKey(pEventData.originalCallID);
            
            //Save the CallId of the Conference call.
            pCall.ConferenceCall.callID = pEventData.conferenceCallID;
                
            //Add the conference call to the threeway call manager
            mpApp.ThreeWayCallManager.Add(pCall.ConferenceCall.CallID, pCall.ConferenceCall);

            //Set the state of the main call and application to Conference
            mpEventHelper.SetApplicationState(AgentStateId.asCONFERENCE, pEvent, pCall);
            //hendro
            //Upon Conference, both the first party and third party calls become Active so set their states to Active.
            //
            //Set the state of the 3rdParty call to Active
            mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.FirstPartyCall);

            //Set the state of the Conference call to Active 
            mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.ConferenceCall);

            //Set the state of the 1stParty call to Active
            mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pCall.ThirdPartyCall);

            mpEventHelper.FireStateChangeEvents();
        }
    }

    internal class CHandlerConsulting: IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerConsulting(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDConsult pEventData = (UDConsult)pEvent.Payload;
             
            if (mpApp.ThreeWayCallManager.Contains(pEventData.consultCallID))
            {
                //Retrieve the associated 3rdParty call
                C3WayCall pConsultationCall = mpApp.ThreeWayCallManager.GetByKey(pEventData.consultCallID);

                //Set the state of the 3rdParty call to Active
                mpEventHelper.SetCallState(AgentStateId.asACTIVE, pEvent, pConsultationCall);

                //If the 1st party call's state is Held, set its state to Held again to trigger a state change on it
                //so the client updates its 1st Party RetrieveHold button correctly (ie, disable retrieveHold on the 1st party).
                if (pConsultationCall.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
                    mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, pConsultationCall.ParentCall.FirstPartyCall);

                //Set the main state of the parent call (also given by pEventData.originalCallID) to Consulting and
                //leave the state of the FirstParty call unchanged (it was probably placed in Held state due to consultation request).
                mpEventHelper.SetApplicationState(AgentStateId.asCONSULTING, pEvent, pConsultationCall.ParentCall);
                //hendro
                mpEventHelper.FireStateChangeEvents();
            }
        }
    }

	internal class CHandlerPreview: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerPreview(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			//Load call from event
			CCall pCall = mpApp.CallManager.CreateCall((UDPreview)pEvent.Payload);
			
			mpEventHelper.ProcessCallAppearance(pCall);

			//Go to preview state
			mpEventHelper.SetApplicationState(AgentStateId.asPREVIEW, pEvent, pCall);

            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerLogoutPending: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerLogoutPending(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			mpApp.OnLogoutPending();
		}
	}

	internal class CHandlerBadPasscode: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerBadPasscode(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDBadPassCode pEventData = (UDBadPassCode)pEvent.Payload;
			mpApp.OnPasscode(new CPasscodeArgs(pEventData.codeShouldBe, false));
		}
	}

	internal class CHandlerHeld: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerHeld(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDHeld pEventData = (UDHeld)pEvent.Payload;
			
            //If the call is a main call...
            if (mpApp.CallManager.Contains(pEventData.callID))
            {
                CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);
    			
                //If its main state is not Consulting and not Dialing_Consultation, set the 
                //main state of the call and application to Held
                if (!(pCall.CurrentState is CStateDialingConsultation || pCall.CurrentState is CStateConsulting || pCall.CurrentState is CStateConference))
			        mpEventHelper.SetApplicationState(AgentStateId.asHELD, pEvent, pCall);
                
                //Set the state of the FirstParty call
                mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, pCall.FirstPartyCall);
            
                //If the 3rd party call's state is Held, set its state to Held again to trigger a state change on it
                //so the client updates its 3rd Party RetrieveHold button correctly (eg, enable retrieveHold on the 3rd party).
                if (((CCallVoice)pCall).ThirdPartyCall.CurrentState is CStateHeld)
                    mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, ((CCallVoice)pCall).ThirdPartyCall);
            }
            
            //If the call is a 3Way call (ie, the 3rdParty call)...
            else if (mpApp.ThreeWayCallManager.Contains(pEventData.callID))
            {
                C3WayCall pConsultationCall = mpApp.ThreeWayCallManager.GetByKey(pEventData.callID);

                //Set the state of the 3rdParty call
                mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, pConsultationCall);

                //If the 1st party call's state is Held, set its state to Held again to trigger a state change on it
                //so the client updates its 1st Party RetrieveHold button correctly (eg, enable retrieveHold on the 1st party).
                if (pConsultationCall.ParentCall.FirstPartyCall.CurrentState is CStateHeld)
                    mpEventHelper.SetCallState(AgentStateId.asHELD, pEvent, pConsultationCall.ParentCall.FirstPartyCall);
            }

            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerActivateCall: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerActivateCall(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			UDActivateCall pEventData = (UDActivateCall)pEvent.Payload;
			
			//Activate the call chosen by Centercord
			//
			//Set the call as the current call
			CCall pCall = mpApp.CallManager.GetByKey(pEventData.callID);
            CCall pDeactivatedCall = mpApp.CallManager.CurrentCall;

            mpApp.CallManager.CurrentCall = pCall;

            //Re-enter its current state
            mpEventHelper.SetApplicationState(pCall.CurrentState.Id, pEvent, pCall);

            mpApp.OnCallActivated(new CCallActivatedArgs(pDeactivatedCall, mpApp.CallManager.CurrentCall));

            mpEventHelper.FireStateChangeEvents();
        }
	}

	internal class CHandlerUpdateExternalRoute: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerUpdateExternalRoute(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			const int ciUPDATE_TYPE_INSERT = 1;
			const int ciUPDATE_TYPE_DELETE = 2;
			const int ciUPDATE_TYPE_EDIT = 3;

			UDExternalRoute pEventData = (UDExternalRoute)pEvent.Payload;
			
			switch (pEventData.externalRequestType)
			{
				case ciUPDATE_TYPE_INSERT:
					if (pEventData.externalRouteId == 0)
						mpApp.ExternalRoutes.Load();
					else
						mpApp.ExternalRoutes.Load(pEventData.externalRouteId);
					break;

				case ciUPDATE_TYPE_EDIT:
					mpApp.ExternalRoutes.Load(pEventData.externalRouteId);
					break;

				case ciUPDATE_TYPE_DELETE:
					mpApp.ExternalRoutes.RemoveByKey(pEventData.externalRouteId);
					break;

				default:
					mpApp.ExternalRoutes.Load();
					break;
			}
		}
	}

	internal class CHandlerUpdateAgentStatusReasons: IEventHandler
	{
		private CApp mpApp;
		private CEventManagerHelper mpEventHelper;

		public CHandlerUpdateAgentStatusReasons(CApp pApp, CEventManagerHelper pEventHelper)
		{
			mpApp = pApp;
			mpEventHelper = pEventHelper;
		}

		public void ProcessEvent(CAgentEvent pEvent)
		{
			//Reload Logout Reasons
			mpApp.LogoutReasons.Load();
			
			//Reload NotReady Reasons
			mpApp.NotReadyReasons.Load();
        
            //Reload Call Rejection Reasons
            mpApp.CallRejectionReasons.Load();
        }
	}


    internal class CHandlerChatEntityAdded : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerChatEntityAdded(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDEntity pEventData = (UDEntity)pEvent.Payload;

            Console.WriteLine("EntityName<{0}>, EntityType<{1}>, EntityId<{2}>\t[{3}]", pEventData.name, pEventData.entity, pEventData.entityID, this.GetType());
            
            //Fire an entity added event
            mpApp.OnChatEntityAdded(new CChatEntityArgs(pEventData.name, (ChatEntityType)pEventData.entity, pEventData.entityID));
        }
    }


    internal class CHandlerChatEntityRemoved : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerChatEntityRemoved(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDEntity pEventData = (UDEntity)pEvent.Payload;

            Console.WriteLine("EntityName<{0}>, EntityType<{1}>, EntityId<{2}>\t[{3}]", pEventData.name, pEventData.entity, pEventData.entityID, this.GetType());

            //Fire an entity removed event
            mpApp.OnChatEntityRemoved(new CChatEntityArgs(pEventData.name, (ChatEntityType)pEventData.entity, pEventData.entityID));
        }
    }


    internal class CHandlerChatURL : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerChatURL(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDEntityPushUrl pEventData = (UDEntityPushUrl)pEvent.Payload;

            Console.WriteLine("CallId<{0}>, URL<{1}>, EntityType<{2}>, EntityName<{3}>\t[{4}]", pEventData.callId, pEventData.url, pEventData.entity, pEventData.entityName, this.GetType());

            //Fire a chat url event
            mpApp.OnChatURL(new CChatURLArgs(pEventData.callId, (ChatEntityType)pEventData.entity, pEventData.entityName, pEventData.url));
        }
    }
    internal class NotReadyPendingEventMessageHandler : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public NotReadyPendingEventMessageHandler(CApp pApp, CEventManagerHelper pEventHelper)
        {
            this.mpApp = pApp;
            this.mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            this.mpApp.isUnavailablePending = true;
        }
    }
    internal class SessionTimedOutEventMessageHandler : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;


        public SessionTimedOutEventMessageHandler(CApp pApp, CEventManagerHelper pEventHelper)
        {
            this.mpApp = pApp;
            this.mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDError payload = (UDError)pEvent.Payload;
            //SessionTimedOutEventMessageHandler.Log.DebugFormat("SessionTimedOut");
            this.mpApp.OnSessionTimedOut(new SessionTimedOutEventArgs(payload.agentIndex));
            //try
            //{
            //    if (this.mpApp._ClientServiceHost == null || this.mpApp._ClientServiceHost.ClientService == null)
            //        return;
            //    this.mpApp._ClientServiceHost.ClientService.ClientEvents.EventSessionTimeout(payload);
            //}
            //catch (Exception ex)
            //{
            //    //SessionTimedOutEventMessageHandler.Log.ErrorFormat("[{0}] {1}", (object)MethodBase.GetCurrentMethod().Name, (object)ex.StackTrace);
            //}
        }
    }
    //internal class UpdateServiceEventMessageHandler : IEventHandler
    //{
    //    private CApp mpApp;
    //    private CEventManagerHelper mpEventHelper;

    //    public UpdateServiceEventMessageHandler(CApp pApp, CEventManagerHelper pEventHelper)
    //    {
    //        this.mpApp = pApp;
    //        this.mpEventHelper = pEventHelper;
    //    }

    //    public void ProcessEvent(CAgentEvent pEvent)
    //    {
    //        UDUpdateService payload = (UDUpdateService)pEvent.Payload;
    //        //CService payload1 = (CService)pEvent.Payload;
    //        try
    //        {
    //            //this.mpApp.LoadAgentMAData();
    //            //if (!(pEvent is AgentEventMessageRaised) && payload.serviceID == 0 && !(this.mpApp.CurrentState is IdleState))
    //            //{
    //            //    this.mpApp.AgentEventMessageManager.PendingAgentSettingsUpdate = payload;
    //            //}
    //            //else
    //            //{
    //                if (payload.serviceID != 0)
    //                    this.mpApp.CallbackServices.Update(payload);
    //                if (this.mpApp.AssignedServices.Contains((object)payload.serviceID))
    //                {
    //                    this.mpApp.AssignedServices.Load(payload);
    //                    this.mpApp.OnAssignedServiceUpdated(new AssignedServicesUpdateEventArgs(this.mpApp.AssignedServices.GetByKey((object)payload1.ServiceId)));
    //                }

    //            if (mpApp.AssignedServices.Contains(pEventData.serviceID))
    //                mpApp.AssignedServices.GetByKey(pEventData.serviceID).removed = false;
    //            //Otherwise, load the service
    //            else
    //                //mpApp.AssignedServices.Load(pEventData.serviceID);
    //                mpApp.AssignedServices.Load(payload);
    //        }
    //        catch (Exception ex)
    //        {
    //        }
    //        //if (!(pEvent is AgentEventMessageRaised))
    //        //{
    //        //    try
    //        //    {
    //        //        if (this.mpApp._ClientServiceHost != null && this.mpApp._ClientServiceHost.ClientService != null)
    //        //            this.mpApp._ClientServiceHost.ClientService.ClientEvents.EventUpdateService(payload);
    //        //    }
    //        //    catch (Exception ex)
    //        //    {
    //        //        UpdateServiceEventMessageHandler.Log.ErrorFormat("[{0}] {1}", (object)MethodBase.GetCurrentMethod().Name, (object)ex.StackTrace);
    //        //    }
    //        //}
    //    }
    //}
    //internal class NewServiceEventMessageHandler : IEventHandler
    //{
    //    private CApp mpApp;
    //    private CEventManagerHelper mpEventHelper;

    //    public NewServiceEventMessageHandler(CApp pApp, CEventManagerHelper pEventHelper)
    //    {
    //        this.mpApp = pApp;
    //        this.mpEventHelper = pEventHelper;
    //    }

    //    public void ProcessEvent(CAgentEvent pEvent)
    //    {
    //        UDNewService payload = (UDNewService)pEvent.Payload;
    //        if (this.mpApp.IsLoggedIn)
    //            this.mpApp.CallbackServices.Update(payload);
    //        if (this.mpApp.AssignedServices.Contains((object)payload.serviceID))
    //        {
    //            this.mpApp.AssignedServices.GetByKey((object)payload.serviceID).removed = false;
    //            this.mpApp.OnAssignedServiceUpdated(new AssignedServicesUpdateEventArgs(this.mpApp.AssignedServices.GetByKey((object)payload.serviceID)));
    //        }
    //        ////else
    //        ////{
    //        ////    this.mpApp.AssignedServices.Load(payload);
    //        ////    this.mpApp.OnAssignedServiceAdded(new AssignedServicesUpdateEventArgs(this.mpApp.AssignedServices.GetByKey((object)payload.serviceID)));
    //        ////}
    //        ////try
    //        ////{
    //        ////    if (this.mpApp._ClientServiceHost != null && this.mpApp._ClientServiceHost.ClientService != null)
    //        ////        this.mpApp._ClientServiceHost.ClientService.ClientEvents.EventNewService(payload);
    //        ////}
    //        ////catch (Exception ex)
    //        ////{
    //        ////    NewServiceEventMessageHandler.Log.ErrorFormat("[{0}] {1}", (object)MethodBase.GetCurrentMethod().Name, (object)ex.StackTrace);
    //        ////}
    //        //NewServiceEventMessageHandler.Log.DebugFormat("[{0}] EXIT", (object)MethodBase.GetCurrentMethod().Name);
    //    }
    //}
    internal class CHandlerWrapTimeout : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerWrapTimeout(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }
        //public CHandlerWrapTimeout(CApp pApp, CEventManagerHelper pEventHelper)
        //{
        //    mpApp = pApp;
        //    mpEventHelper = pEventHelper;
        //}

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDWrapTimeout payload = (UDWrapTimeout)pEvent.Payload;
            WrapTimeout wrapTimeout = new WrapTimeout()
            {
                AgentDispExpected = payload.agentDispExpected,
                AgentIndex = payload.agentIndex,
                CallId = payload.callID
            };
            this.mpApp.OnWrapTimeout(new WrapTimeoutEventArgs(wrapTimeout));
        }
    }
    internal class CHandlerChatMessage : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerChatMessage(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDEntitySendText pEventData = (UDEntitySendText)pEvent.Payload;

            Console.WriteLine("CallId<{0}>, EntityName<{1}>, EntityType<{2}>, Message<{3}>\t[{4}]", pEventData.callId, pEventData.entityName, pEventData.entity, pEventData.text, this.GetType());

            //Fire a chat message event
            mpApp.OnChatMessage(new CChatMessageArgs(pEventData.callId, (ChatEntityType)pEventData.entity, pEventData.entityName, pEventData.text));
        }
    }


    internal class CHandlerError : IEventHandler
    {
        private CApp mpApp;
        private CEventManagerHelper mpEventHelper;

        public CHandlerError(CApp pApp, CEventManagerHelper pEventHelper)
        {
            mpApp = pApp;
            mpEventHelper = pEventHelper;
        }

        public void ProcessEvent(CAgentEvent pEvent)
        {
            UDError pEventData = (UDError)pEvent.Payload;

            Console.WriteLine("Error: Code[{0}], Desc[{1}], CallId[{2}]\t[{3}]", pEventData.failCode, pEventData.failReason, pEventData.callID, this.GetType());
            mpApp.OnError (new CErrorArgs((ErrorId)pEventData.failCode, pEventData.failReason, pEventData.callID));
        }
    }

	public class CState
	{
		private Color mpBackColor;
		private Color mpForeColor;
		private String msDescription;
		private AgentStateId meId;
		
		protected CApp mpApp;
		
		public virtual bool EnableHangup{get{return false;}}
		public virtual bool EnableHold{get{return false;}}
		public virtual bool Enable3Way{get{return false;}}
		public virtual bool EnableRecord{get{return false;}}
		public virtual bool EnableNextCall{get{return false;}}
		public virtual bool EnableLogout{get{return true;}}
		public virtual bool EnablePlay{get{return false;}}
		public virtual bool EnableDial{get{return false;}}
        public virtual bool EnableAvailable{get{return false;}}
        public virtual bool EnableUnavailable{get{return false;}}
        public virtual bool EnableConference { get { return false; } }
        public virtual bool EnableConsult { get { return false; } }
        public virtual bool EnableTransfer { get { return false; } }
        
		public Color BackColor{get{return mpBackColor;}}
		public Color ForeColor{get{return mpForeColor;}}
		public String Description{get{return msDescription;}}
		public AgentStateId Id{get{return meId;}}
		
		internal CState(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
		{
			this.meId = eId;
			this.msDescription = sDescription;
			this.mpBackColor = pBackColor;
			this.mpForeColor = pForeColor;
			this.mpApp = pApp;
		}

		internal virtual void Enter(CAgentEvent pEvent)
		{
			Console.WriteLine("Entering {0}({1})\t[{2}]", msDescription, meId, this.GetType());
		}

		internal virtual void Exit()
		{
			Console.WriteLine("Exiting {0}({1})\t[{2}]", msDescription, meId, this.GetType());
		}
	}

	public class CCallState: CState
	{
        internal CCallGeneric Call { get { return mpCall; } }
        protected CCallGeneric mpCall;

        //Default property values for CallStates
        public override bool EnableHangup
        {
            get
            {
                //If first party call then should enable based on service's settings
                if (mpCall is C3WayCall1stParty)
                {
                    if (((C3WayCall)mpCall).ParentCall is CCallVoice)
                    {
                        //If remaining consultation call, enable hangup
                        if (((C3WayCall)mpCall).ParentCall is CCallRemainingConsultation)
                            return true;
                        else
                            return mpApp.AssignedServices.GetByKey(((C3WayCall)mpCall).ParentCall.ServiceID).AllowHangup;
                    }
                    //If this is a chat call, enable the hangup function based on the AllowChatDisconnect setting.
                    else if (((C3WayCall)mpCall).ParentCall is CCallChat)
                        return ((CServiceChat)(mpApp.AssignedServices.GetByKey(((C3WayCall)mpCall).ParentCall.ServiceID))).AllowChatDisconnect;
                    //If parent call is not a voice call then always disable Hangup
                    else
                        return false;
                }
                //If third party call then should enable based on service's settings
                else if (mpCall is C3WayCall3rdParty)
                {
                    return mpApp.AssignedServices.GetByKey(((C3WayCall)mpCall).ParentCall.ServiceID).AllowConsultHangup;
                }
                //If conference call then should always disable. One cannot hangup a conference call.
                else if (mpCall is C3WayCallConference)
                {
                    return false;
                }

                //The main hangup and hold commands (eg, those from the toolbar) apply to the first party so they should always 
                //reflect the EnableHangup and EnableHold values of the first party. This is so because the first party will in
                //some cases be in a different state than the main call (eg, main call is Consulting while first party is Held
                //or Active)
                else if (mpCall is CCall)
                {
                    return ((CCall)mpCall).FirstPartyCall.CurrentState.EnableHangup;
                }
                else
                {
                    return false;
                }
            }
        }

        public override bool EnableHold
        {
            get
            {
                CCallVoice pParentCall;

                //If first party call then should enable based on service's settings
                if (mpCall is C3WayCall1stParty)
                {
                    if (((C3WayCall)mpCall).ParentCall is CCallVoice)
                    {
                        pParentCall = (CCallVoice)((C3WayCall)mpCall).ParentCall;

                        //If remaining consultation call, enable hold
                        if (pParentCall is CCallRemainingConsultation)
                            return true;

                        //If internal manual call, disable hold
                        else if (pParentCall.CurrentState is CStateActiveInternal)
                            return false;

                        //If parent call is Conferenced, disable hold
                        else if (pParentCall.CurrentState is CStateConference)
                            return false;
                        

                        //If 1st party is held then...
                        else if (mpCall.CurrentState is CStateHeld)
                        {
                            //If 3rd party is active, disable retrieveHold on 1st party
                            if (pParentCall.ThirdPartyCall.CurrentState is CStateActive)
                                return false;
                            //Otherwise, enable retrieveHold on 1st party
                            else
                                return true;
                        }
                        //Otherwise, enable Hold on 1st party based on service setting
                        else
                            return mpApp.AssignedServices.GetByKey(pParentCall.ServiceID).AllowHold;
                    }
                    //If parent call is not a voice call then disable Hold
                    else
                        return false;
                }

                //If third party call then should enable based on service's settings
                else if (mpCall is C3WayCall3rdParty)
                {
                    pParentCall = (CCallVoice)((C3WayCall)mpCall).ParentCall;

                    //If parent call is Conferenced, disable hold
                    if (pParentCall.CurrentState is CStateConference)
                        return false;
                    
                    //If 3rd party is held then...
                    else if (mpCall.CurrentState is CStateHeld)
                    {
                        //If 1st party is active, disable retrieveHold on 3rd party
                        if (pParentCall.FirstPartyCall.CurrentState is CStateActive)
                            return false;
                        //Otherwise, enable retrieveHold on 3rd party
                        else
                            return true;
                    }
                    //Otherwise, enable Hold on 3rd party (there's no service setting for 3rd party hold)
                    else
                        return true;

                
                }
                
                //The main hangup and hold commands (eg, those from the toolbar) apply to the first party so they should always 
                //reflect the EnableHangup and EnableHold values of the first party. This is so because the first party will in
                //some cases be in a different state than the main call (eg, main call is Consulting while first party is Held
                //or Active)
                else if (mpCall is CCall)
                    return ((CCall)mpCall).FirstPartyCall.CurrentState.EnableHold;
                
                else
                    return false;
            }
        }

        internal CCallState(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
		:base(eId, sDescription, pBackColor, pForeColor, pApp)
		{
			this.mpCall = pCall;
		}

		internal override void Enter(CAgentEvent pEvent)
		{
            Console.WriteLine("Entering {0}({1}), {2}<{3}>\t[{4}]", this.Description, (int)this.Id, mpCall.GetType(), mpCall.callID, this.GetType());
        }

		internal override void Exit()
		{
			Console.WriteLine("Exiting {0}({1}), {2}<{3}>\t[{4}]", this.Description, (int)this.Id, mpCall.GetType(), mpCall.callID, this.GetType());
		}
	}

	public class CStateAuthenticated: CState
	{
        internal CStateAuthenticated(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
			:base(eId, sDescription, pBackColor, pForeColor, pApp){}
	}
	
	public class CStateActive: CCallState
	{
        public override bool Enable3Way
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.Enable3Way;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).Allow3Way; 
            }
        }

        public override bool EnableRecord
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableRecord;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowRecord ; 
            }
        }

        public override bool EnablePlay
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnablePlay;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay;
            }
        }

        public override bool EnableConsult
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableConsult;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowConsult;
            }
        }

        public override bool EnableTransfer 
        { 
            get 
            { 
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableTransfer;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowBlindXfer; 
            } 
        }

        internal CStateActive(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}
	
	public class CStateActiveInternal: CCallState
	{
        public override bool EnablePlay
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnablePlay;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay;
            }
        }

        public override bool EnableRecord
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableRecord;
                else if (mpCall is CCallRemainingConsultation)
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowRecord;
                else
                    return false;
                
	        }
        }

        internal CStateActiveInternal(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}
	
	public class CStateDialing: CCallState
	{
        public override bool EnableHold { get { return false; } }

        public override bool Enable3Way
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.Enable3Way;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).Allow3Way;
            }
        }
 
        internal CStateDialing(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}

	public class CStateHeld: CCallState
	{
        public override bool Enable3Way
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.Enable3Way;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else

                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).Allow3Way;
            }
        }

        public override bool EnableRecord
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableRecord;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowRecord;
            }
        }

        public override bool EnablePlay
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnablePlay;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay;
            }
        }

        public override bool EnableConsult
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableConsult;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowConsult;
            }
        }

        public override bool EnableTransfer
        {
            get
            {
                //If call is a 3WayCall then return setting from its parent call as this is not a 3WayCall specific setting.
                if (mpCall is C3WayCall)
                    return ((C3WayCall)mpCall).ParentCall.CurrentState.EnableTransfer;
                else if (mpCall is CCallRemainingConsultation)
                    return false;
                //Otherwise (ie, call is the main call), return its service's setting
                else
                    return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowBlindXfer;
            }
        }


        internal CStateHeld(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}

    public class CStateChatting : CCallState
    {
        public override bool EnableHold { get { return false; } }
        
        internal CStateChatting(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
            : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall) { }
    }

	public class CStateLoggedOut: CState
	{
        public override bool EnableLogout { get { return false; } }

        internal CStateLoggedOut(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
			:base(eId, sDescription, pBackColor, pForeColor, pApp){}
	}
	
	public class CStateLoggingIn: CState
	{
		internal CStateLoggingIn(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
			:base(eId, sDescription, pBackColor, pForeColor, pApp){}
	}
	
	public class CStateIdle: CState
	{
		public override bool EnablePlay{get{return mpApp.CurrentService.AllowPlay;}}
		public override bool EnableDial{get{return mpApp.CurrentService.AllowDial;}}
        public override bool EnableUnavailable { get { return true; } }

		internal CStateIdle(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
			:base(eId, sDescription, pBackColor, pForeColor, pApp){}
	}
	
	public class CStatePreview: CCallState
	{
        //Dont worry about call type with these properties for now as currently only the main call (CCall) uses this state.
        public override bool EnableDial { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowDial; } }
        public override bool EnableNextCall { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowNextCall; } }
        //Hold doesn't make sense in this state; Disable it.
        public override bool EnableHold { get { return false; } }
        //Hangup doesn't make sense in this state; Disable it.
        public override bool EnableHangup { get { return false; } }

        internal CStatePreview(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}
	
	public class CStateRinging: CCallState
	{
        //Hold doesn't make sense in this state; Disable it.
        public override bool EnableHold { get { return false; } }
        //Hangup doesn't make sense in this state; Disable it.
        public override bool EnableHangup { get { return false; } }

        internal CStateRinging(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}
	
	public class CStateWrap: CCallState
	{
        //Dont worry about call type with these properties for now as currently only the main call (CCall) uses this state.
        public override bool EnableDial { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowDial; } }
        public override bool EnablePlay { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay; } }
		//Always enable the NextCall command while in Wrap state so user can dispose the call.
        public override bool EnableNextCall{get{return true;}}
        //Hold doesn't make sense in this state; Disable it.
        public override bool EnableHold { get { return false; } }
        //Hangup doesn't make sense in this state; Disable it.
        public override bool EnableHangup { get { return false; } }

        internal CStateWrap(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
			:base(eId, sDescription, pBackColor, pForeColor, pApp, pCall){}
	}

	public class CStateWaiting: CState
	{
		internal CStateWaiting(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
			:base(eId, sDescription, pBackColor, pForeColor, pApp){}
	}

    public class CStateNotReady : CState
    {
        public override bool EnableAvailable { get { return true; } }
        public override bool EnablePlay { get { return mpApp.CurrentService.AllowPlay; } }

        internal CStateNotReady(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
            : base(eId, sDescription, pBackColor, pForeColor, pApp) { }
    }

    public class CStateParked : CState
    {
        public override bool EnableDial {get{return mpApp.CurrentService.AllowDial;}}
        public override bool EnableAvailable { get { return true; } }
        public override bool EnablePlay { get { return mpApp.CurrentService.AllowPlay; } }
        
        internal CStateParked(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp)
            : base(eId, sDescription, pBackColor, pForeColor, pApp) { }
    }

    public class CStateInactive: CCallState
    {
        //Hold doesn't make sense in this state; Disable it.
        public override bool EnableHold { get { return false; } }
        //Hangup doesn't make sense in this state; Disable it.
        public override bool EnableHangup { get { return false; } }

        internal CStateInactive(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
            : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall) { }
    }

    public class CStateConsulting : CCallState
    {
        //In this case, we've already started a three way so ignore service setting (in case it was disabled 
        //after we started this 3way) and return true.
        public override bool Enable3Way { get { return true; } }

        //This state is only associated with the main call so in the following properties we can assume the call 
        //is a CCall, not a 3Way call.
        //
        public override bool EnableRecord { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowRecord; } }
        public override bool EnablePlay { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay; } }
        public override bool EnableConference { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowConference; } }
        //There's an active consultation call so this transfer would be a warm transfer.
        public override bool EnableTransfer { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowWarmXfer; } }

        internal CStateConsulting(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
            : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall) { }
    }


    public class CStateConference: CCallState
    {
        public override bool EnableHold { get { return false; } }

        //In this case, we've already started a three way so ignore service setting (in case it was disabled 
        //after we started this 3way) and return true.
        public override bool Enable3Way{get{return true;}}

        //This state is only associated with the main call so in the following properties we can assume the call 
        //is a CCall, not a 3Way call.
        //
        public override bool EnableRecord{get{return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowRecord;}}
        public override bool EnablePlay{get{return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowPlay;}}
        //There's an active consultation call so this transfer would be a warm transfer.
        public override bool EnableTransfer { get { return mpApp.AssignedServices.GetByKey(((CCall)mpCall).ServiceID).AllowWarmXfer; } }
        
        internal CStateConference(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
            : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall) { }
    }
    
    //This state should have the same property values as Active so have it derive from Active.
    public class CStateDialingConsultation : CCallState 
    {
        //In this case, we've already started a three way so ignore service setting (in case it was disabled 
        //after we started this 3way) and return true.
        public override bool Enable3Way { get { return true; } }

        internal CStateDialingConsultation(AgentStateId eId, String sDescription, Color pBackColor, Color pForeColor, CApp pApp, CCallGeneric pCall)
            : base(eId, sDescription, pBackColor, pForeColor, pApp, pCall) { }
    }

}
