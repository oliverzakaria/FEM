using SamplePortalClient.EPAgentWS;
using SamplePortalClient.EPAgentWSP;
using SamplePortalClient.EPEventsWS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;
using System.Threading;
using Utilities;
using static SamplePortalClient.CServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SamplePortalClient {
    public class DigitData
    {
        public int CallId { get; set; }

        public string Digits { get; set; }
    }

    /// <summary>
    /// Summary description for CApp.
    /// </summary>
    public enum AgentType
    {
        atNarrowBand = 1,
        atInternet = 3
    };

    public enum DialType
    {
        dtInternal = 1,
        dtExternal = 2,
        dtService = 3,
        dtPreview = 3
    };

    internal enum ConsultType
    {
        ctInternal = 1,
        ctExternal = 2,
        ctXferChatToAgent = 3,
        ctXferAGDToAgent = 4
    };

    internal enum TransferType
    {
        ttWarm = 1,
        ttBlind = 2
    };

    public enum ChatEntityType
    {
        ceAgent = 1,
        ceMonitoringSupervisor = 2,
        ceCustomer = 3
    };

    public class CAgent : CServiceManual
    {
        internal UDAgentStatsCollection awsStatistics = (UDAgentStatsCollection)null;
       
        public int InitState
        {
            get => this.mpAgentArg.initState;
            set => this.mpAgentArg.initState = value;
        }
        public String LDAPUserId { get { return ldapUserId; } }
        internal String ldapUserId
        {
            get { return mpAgentArg.LDAPUserId; }
            set { mpAgentArg.LDAPUserId = value; }
        }
        public string currentportal;
        public int ClientRole { get { return clientRole; } }
        internal int clientRole
        {
            get { return mpAgentArg.clientRole; }
            set { mpAgentArg.clientRole = value; }
        }

        public int ServerType { get { return serverType; } }
        internal int serverType
        {
            get { return mpAgentArg.serverType; }
            set
            {
                mpAgentArg.serverType = value;
                mpAgentInfoArg.serverType = value;
            }
        }

        public String LoginName { get { return loginName; } }
        internal String loginName
        {
            get { return mpAgentArg.agentLoginName; }
            set
            {
                mpAgentArg.agentLoginName = value;
                mpAgentInfoArg.agentLoginName = value;
            }
        }

        public String Password { get { return password; } }
        internal String password
        {
            get { return mpAgentInfoArg.password; }
            set { mpAgentInfoArg.password = value; }
        }

        public String Station { get { return station; } }
        internal String station
        {
            get { return mpAgentInfoArg.stationId; }
            set { mpAgentInfoArg.stationId = value; }
        }

        public int AgentType { get { return agentType; } }
        internal int agentType
        {
            get { return mpAgentInfoArg.agentType; }
            set { mpAgentInfoArg.agentType = value; }
        }

        public int WorkgroupId { get { return workgroupId; } }
        internal int workgroupId
        {
            get { return mpAgentInfoArg.agentWorkgroupID; }
            set { mpAgentInfoArg.agentWorkgroupID = value; }
        }

        public int ReferenceId { get { return referenceId; } }
        internal int referenceId
        {
            get { return mpAgentInfoArg.referenceID; }
            set { mpAgentInfoArg.referenceID = value; }
        }

        public int AgentIndex { get { return agentIndex; } }
        internal int agentIndex
        {
            get { return mpAgentInfoArg.agentIndex; }
            set { mpAgentInfoArg.agentIndex = value; }
        }

        public int GatewayId { get { return gatewayId; } }
        internal int gatewayId
        {
            get { return mpAgentInfoArg.ntSwitchID; }
            set { mpAgentInfoArg.ntSwitchID = value; }
        }
        public bool Multiline { get; set; }

        public UDAgentStatsCollection AgentStatistics
        {
            get => this.awsStatistics;
            set => this.awsStatistics = value;
        }
        public int Site { get { return site; } }
        internal int site = 0;

        public String AWSVersion { get { return awsVersion; } }
        internal String awsVersion = null;

        public String Tenant { get { return tenant; } }
        internal String tenant = null;

        public bool AllowPark { get { return allowPark; } }
        internal bool allowPark;

        public int ParkAlarmSecs { get { return parkAlarmSecs; } }
        internal int parkAlarmSecs;

        public int RouteAccessId { get { return routeAccessId; } }
        internal int routeAccessId;

        public String FirstName { get { return firstName; } }
        internal String firstName;

        public String LastName { get { return lastName; } }
        internal String lastName;

        public String AgentId { get { return mpAgentArg.agentLoginName; } }

       //// internal UDAgent AgentArg { get { return mpAgentArg; } }
        internal UDAgentInfo AgentInfoArg { get { return mpAgentInfoArg; } }
        private UDAgentInfo mpAgentInfoArg;
        private UDAgent mpAgentArg;
        public UDAgent AgentArg => this.mpAgentArg;

        internal CAgent()
        : base()
        {
            mpAgentArg = new UDAgent();
            mpAgentInfoArg = new UDAgentInfo();
        }
    }



    public class CApp
    {
        private bool _isUnavailablePending = false;
        public event PortalRequestStatusEventHandler GoUnavailableRequestStatus;

        public event AgentStatsEventHandler AgentStats;
        public event StateChangeHandler StateChange;
        public event UnfocusedStateChangeHandler UnfocusedStateChange;
        public event WrapTimeoutEventHandler WrapTimeout;
        public event CallStateChangeHandler CallStateChange;
        public event UnfocusedCallStateChangeHandler UnfocusedCallStateChange;
        public event AssignedServicesUpdateEventHandler AssignedServiceUpdated;
        private CallbackServices mpCallbackServices;
        public event PasscodeHandler Passcode;
        public event LogoutPendingHandler LogoutPending;
        public event ScreenpopHandler Screenpop;

        public event CallActivatedHandler CallActivated;
        public event PhoneStatusHandler PhoneStatus;
        public event ErrorHandler Error;
        public event LoggedInHandler LoggedIn;
        public event SessionTimedOutEventHandler SessionTimedOut;
        public event ChatEntityHandler ChatEntityAdded;
        public event ChatEntityHandler ChatEntityRemoved;
        public event ChatURLHandler ChatURL;
        public event ChatMessageHandler ChatMessage;
        private UDDisposition lastDisposition;
        public CallbackServices CallbackServices => this.mpCallbackServices;
        public CState CurrentState { get { return mpEventManager.CurrentState; } }
        public CAgent CurrentAgent { get { return mpCurrentAgent; } }
        public CCall CurrentCall { get { return mpCallManager.CurrentCall; } }
        public CLogoutReasons LogoutReasons { get { return mpLogoutReasons; } }
        public CNotReadyReasons NotReadyReasons { get { return mpNotReadyReasons; } }
        public CCallRejectionReasons CallRejectionReasons { get { return mpCallRejectionReasons; } }
        public CExternalRoutes ExternalRoutes { get { return mpExternalRoutes; } }
        public CAssignedServices AssignedServices { get { return mpAssignedServices; } }
        public CService CurrentService { get { return (this.CurrentCall == null ? mpCurrentAgent : mpAssignedServices.GetByKey(CurrentCall.serviceID)); } }

        internal CDispositionPlans DispositionPlans { get { return mpDispositionPlans; } }
        internal CPortal Portal { get { return mpPortal; } }
        internal CEventManager EventManager { get { return mpEventManager; } }
        internal CCallManager CallManager { get { return mpCallManager; } }
        internal C3WayCallManager ThreeWayCallManager { get { return mpThreeWayCallManager; } }
        public bool IsLoggedIn => this.isLoggedIn;
        internal UDCall LastUDCall
        {
            get
            {
                return lastCall;
            }
            set
            {
                lastCall = value;
            }
        }

        private UDCallback lastCallback;
        internal bool isLoggedIn;
        private UDCall lastCall;
        private CEventManager mpEventManager;
        private CPortal mpPortal;
        private CAgent mpCurrentAgent;
        private CCallManager mpCallManager;
        private Timer mpKeepAliveTimer;
        private CLogoutReasons mpLogoutReasons;
        private CNotReadyReasons mpNotReadyReasons;
        private CCallRejectionReasons mpCallRejectionReasons;
        private CAssignedServices mpAssignedServices;
        private CDispositionPlans mpDispositionPlans;
        private CExternalRoutes mpExternalRoutes;
        private C3WayCallManager mpThreeWayCallManager;
        private CParkReasons mpParkReasons;
        public CParkReasons ParkReasons => this.mpParkReasons;
        public CApp()
        {
            mpPortal = new CPortal();
            mpAssignedServices = new CAssignedServices(this);
            mpLogoutReasons = new CLogoutReasons(this);
            mpNotReadyReasons = new CNotReadyReasons(this);
            mpCallRejectionReasons = new CCallRejectionReasons(this);
            mpExternalRoutes = new CExternalRoutes(this);
            this.mpCallbackServices = new CallbackServices(this);
            //mpLogoutReasons.Load();

            ////Load not ready reasons
            //mpNotReadyReasons.Load();

            ////Load call rejections reasons
            //mpCallRejectionReasons.Load();

            ////Load external routes
            //mpExternalRoutes.Load();

            //mpEventManager.RaiseEvent(AgentEventType.aeAUTHENTICATED, null, false);
        }
        public void setEvent(string sPortal)
        {
            mpPortal.Setting();
            //string sProtocol = !true ? "http://" : "https://";
            ////System.Windows.Forms.MessageBox.Show("Masuk");
            //String sEventsUrl = GetServiceUrl(mpPortal.WSEvents.Url, sPortal, sProtocol);
            //String sAgentPUrl = GetServiceUrl(mpPortal.WSAgentP.Url, sPortal, sProtocol);
            //mpPortal.WSEvents.Url = sEventsUrl;
            //mpPortal.WSAgentP.Url = sAgentPUrl;

            mpEventManager = new CEventManager(this);
            mpCallManager = new CCallManager();


            mpDispositionPlans = new CDispositionPlans(this);

            mpThreeWayCallManager = new C3WayCallManager();
            this.mpParkReasons = new CParkReasons(this);
            mpEventManager.RaiseEvent(AgentEventType.aeAUTHENTICATED, null, false);

        }
        public void PlayDigits(DigitData digitData)
        {
            UDDigits digits = new UDDigits()
            {
                callId = digitData.CallId,
                digits = digitData.Digits
            };
            try
            {
                this.mpPortal.WSAgent.playDigits(this.mpCurrentAgent.AgentArg, digits);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Unable to connect to the remote server") || ex.Message.Contains("Could not acquire agent object"))
                {
                    throw new Exception("Ext", ex);
                }
                else
                {
                    throw new Exception("Ext", ex);
                }
            }
        }

        //public void PlayDigits(Contact call, string digits)
        //{
        //    try
        //    {
        //        if (call == null)
        //            throw new ArgumentNullException(nameof(call), "You must specify a call");
        //        if (string.IsNullOrWhiteSpace(digits))
        //            throw new ArgumentNullException(nameof(digits), "You must specify the digits to send");
        //        if (!new Regex("^([0-9]|\\*|#)+$").IsMatch(digits))
        //            throw new ArgumentException("The digits parameter may only contain the characters 0 through 9, *, and #", nameof(digits));
        //        UDDigits digits1 = new UDDigits()
        //        {
        //            callId = call.CallID
        //        };
        //        for (int startIndex = 0; startIndex < digits.Length; ++startIndex)
        //        {
        //            digits1.digits = digits.Substring(startIndex, 1);
        //            this.mpPortal.WSAgent.playDigits(this.mpCurrentAgent.AgentArg, digits1);
        //            if (startIndex < digits.Length - 1)
        //                Thread.Sleep(250);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex.Message.Contains("Unable to connect to the remote server") || ex.Message.Contains("Could not acquire agent object"))
        //        {
        //            this._mpAgentEventMessageManager.RaiseEvent(AgentEventType.aePORTALDOWN, (object)null, false);
        //        }
        //        else
        //        {
        //            this.HandleAWSExceptions(ex);
        //        }
        //    }
        //}
        public string[] LoadDomain(string sPortal, bool isSecure)
        {
            string sProtocol = !isSecure ? "http://" : "https://";
            String sAgentUrl = GetServiceUrl(mpPortal.SecurityWebService.Url, sPortal, sProtocol);
            return mpPortal.LoadDomain(sAgentUrl);
        }
        private String GetServiceUrl(String sDefaultUrl, String sPortal, string sProtocol)
        {
            if (sDefaultUrl == null || sDefaultUrl == "")
                return sDefaultUrl;

            int iStart = sDefaultUrl.IndexOf("//", 0);
            int iEnd = -1;
            if (iStart > -1)
                iEnd = sDefaultUrl.IndexOf("/", iStart + 2);

            if (iStart > -1 && iEnd > -1)
                return sDefaultUrl.Substring(0, iStart + 2) + sPortal + sDefaultUrl.Substring(iEnd);
            else
                return sDefaultUrl;

        }
        public void InvokeAgentStatistics()
        {
            try
            {
                this.mpPortal.WSAgent.requestAgentStats(this.mpCurrentAgent.AgentArg);
            }
            catch (Exception ex)
            {
                throw new Exception("Login", ex);
            }
        }


        public bool ScheduleCallback(UDCallback callbackData)
        {
            UDCallback uDCallback = new UDCallback
            {
                aodServiceID = callbackData.aodServiceID,
                callbackName = callbackData.callbackName,
                callID = callbackData.callID,
                dateTime = callbackData.dateTime,
                dialMode = callbackData.dialMode,
                memo = ((callbackData.memo == null) ? "" : callbackData.memo),
                phoneNumber = callbackData.phoneNumber,
                returnToSameAgent = callbackData.returnToSameAgent,
                snoozeTimeInMins = callbackData.snoozeTimeInMins,
                timeZoneID = callbackData.timeZoneID
            };
            try
            {
                mpPortal.WSAgent.scheduleCallback(mpCurrentAgent.AgentArg, uDCallback);
                return true;
                //lastCallback = uDCallback;
            }
            catch (Exception ex)
            {
                return false;
                //Log.LogException(ex, MethodBase.GetCurrentMethod().Name, null, logApplicationData: false);
                //HandleAWSExceptions(ex);
            }
        }
        public EPAgentWSP.TimeZone[] getTimeZones()
        {
            UDInfo uDInfo = new UDInfo();
            uDInfo.listType = 176;
            EPAgentWSP.TimeZone[] result = null;
            try
            {
                result = (EPAgentWSP.TimeZone[])
                    mpPortal.WSAgentP.getTimeZones();
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public EPAgentWS.CallBackService[] getCallbackServiceList()
        {
            //UDInfo oInfo = new UDInfo();
            //oInfo.listType = (int)AgentInfoType.GET_CALLBACK_SERVICE_LIST;
            ////oInfo.serviceType = (int)serviceType;
            //EPAgentWS.ServiceXfer[] result = null;
            //try
            //{
            //    result =  (EPAgentWS.ServiceXfer[])mpPortal.WSAgent.getInfo(mpCurrentAgent.AgentArg, oInfo);
            //}
            //catch (Exception ex)
            //{
            //    //Console.WriteLine("[0] {1}", MethodBase.GetCurrentMethod().Name, ex);
            //}


            UDInfo uDInfo = new UDInfo();
            uDInfo.listType = 114;
            EPAgentWS.CallBackService[] result = null;
            try
            {
                result = (EPAgentWS.CallBackService[])mpPortal.WSAgent.getInfo(mpCurrentAgent.AgentArg, uDInfo);
            }
            catch (Exception ex)
            {
                //Console.WriteLine("[0] {1}", MethodBase.GetCurrentMethod().Name, ex);
            }

            return result;

        }
        //public User GetAgent(UDAgent AgentArg)
        //{
        //    try
        //    {
        //        User info = (User)this.mpPortal.WSAgent.getInfo(AgentArg, new UDInfo()
        //        {
        //            listType = 162
        //        });
        //        return info;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Invalid Agent Details", ex);
        //    }
        //}
        public void Login(String sUser, String sPwd, String sStation, String sPortal, string sDomain,
      bool isSecure)
        {
            string sProtocol = !isSecure ? "http://" : "https://";
            //System.Windows.Forms.MessageBox.Show("Masuk");
            String sAgentUrl = GetServiceUrl(mpPortal.WSAgent.Url, sPortal, sProtocol);
            String sEventsUrl = GetServiceUrl(mpPortal.WSEvents.Url, sPortal, sProtocol);
            String sAgentPUrl = GetServiceUrl(mpPortal.WSAgentP.Url, sPortal, sProtocol);
            //System.Windows.Forms.MessageBox.Show(sAgentUrl);
            //Dynamically point each proxy to the portal specified by the user
            mpPortal.WSAgent.Url = sAgentUrl;
            mpPortal.WSEvents.Url = sEventsUrl;
            mpPortal.WSAgentP.Url = sAgentPUrl;
            //Check agent's existence
            string str = sDomain;
            if (str.Trim().Length > 0)
                str = "@" + str;
            CAgent pAgent = new CAgent();
            pAgent.ldapUserId = sUser + str;
            //System.Windows.Forms.MessageBox.Show(sAgentUrl);
            UDInfo pInfo = new UDInfo();
            pInfo.listType = (int)AgentInfoType.GET_LOGIN_USER;

            EPAgentWS.User pUser = (EPAgentWS.User)mpPortal.WSAgent.getInfo(pAgent.AgentArg, pInfo);
            //System.Windows.Forms.MessageBox.Show(pUser.usertypemask.ToString());
            if (pUser == null)
                throw (new Exception("UserId '" + sUser + "' not found"));

            //Authenticate agent
            pAgent.clientRole = pUser.usertypemask;
            pAgent.serverType = 1;
            pAgent.InitState = 5;
            pAgent.agentIndex = pUser.agentindex;
            pAgent.AgentArg.agentIndex = pUser.agentindex;
            pAgent.loginName = pUser.userid;
            pAgent.AgentInfoArg.ipAddress = DNSUtility.GetLocalIP();
            UDAgentInfo pAgentInfo = new UDAgentInfo();
            pAgent.password = sPwd;
            try
            {
                mpPortal.WSAgent.authenticate(pAgent.AgentArg, pAgent.AgentInfoArg);
            }
            catch (Exception pError)
            {
                throw (new Exception("Invalid User Name or Password.Please Tty again or consult your system administrator", pError));

            }

            //Set agent's additional properties
            pAgent.station = sStation;
            pAgent.agentType = (int)AgentType.atNarrowBand;
            pAgent.workgroupId = pUser.workgroupid;
            pAgent.routeAccessId = pUser.routeaccessid;
            pAgent.allowPark = Convert.ToBoolean(pUser.park);
            pAgent.parkAlarmSecs = pUser.parkdelay;
            pAgent.firstName = pUser.userfname;
            pAgent.lastName = pUser.userlname;
            pAgent.Multiline = Convert.ToBoolean(pUser.multiLine);
            pAgent.AgentArg.agentIndex = pUser.agentindex;
            //Set agent's general service properties (Agent's service properties are used for validation when there's no current service (eg, in Idle))
            pAgent.serviceId = 0;
            pAgent.serviceType = ServiceType.MANUAL;
            pAgent.serviceName = "Default";
            pAgent.dispositionPlan = null;
            pAgent.dialMask = pUser.outgoingmask;
            pAgent.InitState = pUser.allowNotReadyFlag != 1 ? 0 : 5;
            mpCurrentAgent = pAgent;

            //Load agent's service settings and add agent to list of assigned services.
            mpAssignedServices.Load(mpCurrentAgent);

            //Load logout reasons
            mpLogoutReasons.Load();

            //Load not ready reasons
            mpNotReadyReasons.Load();

            //Load call rejections reasons
            mpCallRejectionReasons.Load();

            //Load external routes
            mpExternalRoutes.Load();

           // mpEventManager.RaiseEvent(AgentEventType.aeAUTHENTICATED, null, false);
        }

        public void Logout(CLogoutReason pLogoutReason)
        {
            if (mpCurrentAgent.AgentIndex > 0)
            {
                if (pLogoutReason == null)
                    throw new ArgumentNullException("pLogoutReason", "You must specify a Logout Reason");

                UDReason oReason = new UDReason();
                oReason.reasonId = pLogoutReason.Id;
                mpPortal.WSAgent.requestLogout(mpCurrentAgent.AgentArg, oReason);
            }


            if (mpCurrentAgent.AgentIndex == 0 || pLogoutReason.Id == CLogoutReason.PANIC_LOGOUT_ID)
            {
                mpEventManager.RaiseEvent(AgentEventType.aeLOGOUT, null);
            }
        }
        public void Logout_Id(int Id)
        {
            if (mpCurrentAgent.AgentIndex > 0)
            {
             
                UDReason oReason = new UDReason();
                oReason.reasonId = Id;
                mpPortal.WSAgent.requestLogout(mpCurrentAgent.AgentArg, oReason);
            }


            if (mpCurrentAgent.AgentIndex == 0 || Id == CLogoutReason.PANIC_LOGOUT_ID)
            {
                mpEventManager.RaiseEvent(AgentEventType.aeLOGOUT, null);
            }
        }
        public void Hangup(CCall pCall)
        {
            if (pCall == null)
                throw new InvalidOperationException("Invalid request - Hangup. There's no current call to hang up.");

            if (!pCall.FirstPartyCall.CurrentState.EnableHangup)
                throw new InvalidOperationException("Invalid request - Hangup. Request not allowed in current state of current call.");

            UDParm pParam = new UDParm();
            pParam.callId = pCall.CallID;
            mpPortal.WSAgent.hangup(mpCurrentAgent.AgentArg, pParam);
        }

        public void HangupConsultation()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - HangupConsultation. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - HangupConsultation. The current call does not support consultations.");

            CCallVoice pCall = (CCallVoice)this.CurrentCall;

            if (pCall.thirdPartyCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - HangupConsultation. There is no current consultation call.");

            if (!pCall.thirdPartyCall.CurrentState.EnableHangup)
                throw new InvalidOperationException("Invalid request - HangupConsultation. Request not allowed in current state of consultation call.");

            UDParm pParam = new UDParm();
            pParam.callId = pCall.thirdPartyCall.CallID;
            mpPortal.WSAgent.hangup(mpCurrentAgent.AgentArg, pParam);
        }
        public void ExcludeContact(UDAgent oUDAgent, UDExclude oUDExclude)
        {
            try
            {
                this.Portal.WSAgent.excludeContact(oUDAgent, oUDExclude);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(" |ERROR| Exclude contact - ExcludeContact() . Exclusion Failed, " + ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        public class ServiceApplication : BusinessObject
        {
            internal ServiceApplication(int id, string description)
                : base(id, description)
            {
            }
        }
        internal EPAgentWS.GetIdDesc[] getApplications(int serviceId)
        {
            UDInfo uDInfo = new UDInfo();
            uDInfo.listType = 125;
            uDInfo.serviceId = serviceId;
            EPAgentWS.GetIdDesc[] result = null;
            try
            {
                result = (EPAgentWS.GetIdDesc[])mpPortal.WSAgent.getInfo(CurrentAgent.AgentArg, uDInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[0] {1}", MethodBase.GetCurrentMethod().Name, ex);
            }

            return result;
        }
        public ServiceApplication[] GetApplications(int serviceId)
        {
            EPAgentWS.GetIdDesc[] applications = getApplications(serviceId);
            ServiceApplication[] array = new ServiceApplication[applications.Length];
            int num = 0;
            EPAgentWS.GetIdDesc[] array2 = applications;
            foreach (EPAgentWS.GetIdDesc getIdDesc in array2)
            {
                ServiceApplication serviceApplication = (array[num] = new ServiceApplication(getIdDesc.id, getIdDesc.desc));
                num++;
            }

            return array;
        }
        public void DisposeCall(CCall call)
        {
            if (call == null)
            {
                throw new InvalidOperationException("Invalid request to DisposeCall. You must specify the call to dispose (Call/Contact is null).");
            }

            UDCallInfoUserDefinedItemIn[] array = new UDCallInfoUserDefinedItemIn[20];
            //if (call.userDefinedItems.Length < 20)
            //{
            //    Log.ErrorFormat("[{0}] userDefinedItems size<{1}> call.userDefinedItems size<{2}>", MethodBase.GetCurrentMethod().Name, array.Length.ToString(), call.userDefinedItems.Length.ToString());
            //}

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new UDCallInfoUserDefinedItemIn();
                if (i < call.userDefinedItems.Length)
                {
                    array[i].key = call.userDefinedItems[i].key;
                    array[i].value = call.userDefinedItems[i].value;
                    array[i].isMasked = call.userDefinedItems[i].isMasked;
                }
                else
                {
                    array[i].key = "";
                    array[i].value = "";
                    array[i].isMasked = false;
                }
            }

            UDDisposition uDDisposition = new UDDisposition();
            DispositionDispose disposition = new DispositionDispose(-2, "Max Wrap Time Exceeded", "", isSale: false, isCallback: false, isExclusion: false);
            uDDisposition.callId = call.CallID;
            uDDisposition.IDisposition = disposition.Id;
            uDDisposition.saleFlag = disposition.IsSale;
            uDDisposition.callBackFlag = disposition.IsCallback;
            uDDisposition.updatedCallInfoUserDefined = new UDCallInfoUserDefinedIn();
            uDDisposition.updatedCallInfoUserDefined.userDefinedItems = array;
            uDDisposition.wrapRequiredFlag = true;
            //try
            //{
            //    Log.InfoFormat("[{0}] callOutcome (callId<{1}>, idisposition<{2}>, saleFlag<{3}>, callbackFlag<{4}>, wrapRequiredFlag<{5}>)", MethodBase.GetCurrentMethod().Name, uDDisposition.callId, uDDisposition.IDisposition, uDDisposition.saleFlag, uDDisposition.callBackFlag, uDDisposition.wrapRequiredFlag);
            //}
            //catch (Exception ex)
            //{
            //    Log.ErrorFormat("[{0}] {1}", MethodBase.GetCurrentMethod().Name, ex.Message);
            //}

            try
            {
                mpPortal.WSAgent.callOutcome(mpCurrentAgent.AgentArg, uDDisposition);
                lastDisposition = uDDisposition;
                //call.pendingDisposition = disposition;
            }
            catch (Exception ex2)
            {
            }
        }
        
        public void DisposeCall(CCall pCall, CDisposition pDisposition)
        {
            if (pCall == null)
                throw new InvalidOperationException("Invalid request - DisposeCall. You must specify the call to dispose.");

            CService pCurrentService = mpAssignedServices.GetByKey(pCall.serviceID);

            //If disposition required then validate argument
            if (pCurrentService.RequireDisposition && pCurrentService.DispositionPlan != null && pCurrentService.DispositionPlan.Dispositions.Count > 0)
            {
                //Check that a disposition was specified
                if (pDisposition == null)
                    throw new ArgumentNullException("pDisposition", "You must specify a disposition to dispose the current call.");

                //Check that specified disposition is in list
                if (!pCurrentService.DispositionPlan.Dispositions.Contains(pDisposition.Id))
                    throw new ArgumentException("Invalid Disposition. You must specify a disposition from the disposition plan of the current call's service.");

                //If disposition is callback check that callback was requested
                if (pDisposition.IsCallback & !pCall.CallbackRequested)
                    throw new ArgumentException("Invalid Disposition. You must request a callback before disposing the current call with a callback disposition.");

                //If disposition is exclusion check that exclusion was requested
                if (pDisposition.IsExclusion && !pCall.ExclusionRequested)
                    throw new ArgumentException("Invalid Disposition. You must request an exclusion before disposing the current call with an exclusion disposition.");
            }
            //If disposition not required, use the default one
            else
            {
                pDisposition = new CDisposition(64, "[Default]", "", false, false, false);
            }

            //Copy call's user defined fields
            UDCallInfoUserDefinedItemIn[] items = new UDCallInfoUserDefinedItemIn[20];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new UDCallInfoUserDefinedItemIn();
                items[i].key = pCall.userDefinedItems[i].key;
                items[i].value = pCall.userDefinedItems[i].value;
            }

            //Dispose the call with its user defined fields and the
            //specified disposition
            UDDisposition pDisp = new UDDisposition();
            pDisp.callId = pCall.CallID;
            pDisp.IDisposition = pDisposition.Id;
            pDisp.saleFlag = pDisposition.IsSale;
            pDisp.callBackFlag = pCall.CallbackRequested;
            pDisp.updatedCallInfoUserDefined = new UDCallInfoUserDefinedIn();
            pDisp.updatedCallInfoUserDefined.userDefinedItems = items;

            mpPortal.WSAgent.callOutcome(mpCurrentAgent.AgentArg, pDisp);

            //If call was successfully disposed then remove it from list
            mpCallManager.RemoveByKey(pCall.CallID);
        }

        public void ActivateCall(CCall pCall)
        {
            mpEventManager.ActivateCall(pCall);
        } private InitialAgentStateId initialAgentState = InitialAgentStateId.iasIDLE;

        public enum InitialAgentStateId
        {
            iasIDLE = 1,
            iasNOT_READY = 5,
            iasPARKED = 25
        }
        public InitialAgentStateId InitialAgentState
        {
            get
            {
                return initialAgentState;
            }
            set
            {
                initialAgentState = value;
            }
        }
        public void TakeCalls()
        {
            //mpPortal.Register(mpCurrentAgent.AgentArg, mpCurrentAgent.AgentInfoArg);
            try
            {
                //if (mpCurrentAgent.agentIndex == 0)
                //{
                mpCurrentAgent.InitState = (int)(InitialAgentState);

                mpCurrentAgent.AgentInfoArg.ipAddress = DNSUtility.GetLocalIP();
                    mpPortal.RegisterEx(mpCurrentAgent.AgentArg, mpCurrentAgent.AgentInfoArg, mpCurrentAgent.Multiline);
                    //return;
                //}

                //throw new Exception("Unified IP Agent will shutdown due to the following reason(s) : - Session already exists");
            }
            catch (Exception ex)
            {
                throw ex;// new Exception("Unified IP Agent will shutdown due to the following reason(s) : - Session already exists");
            }
        }

        public void Dial(String UserId)
        {
            if (UserId == null || UserId.Trim().Length == 0)
                throw new ArgumentException("You must specify a UserId", "UserId");

            //Create manual call and save it waiting for dialing event
            CCall pCall = new CCallVoice();
            mpCallManager.PendingManualCall = pCall;

            UDCall pCallParams = new UDCall();
            pCallParams.makeCallType = (int)DialType.dtInternal;
            pCallParams.userID = UserId;

            mpPortal.WSAgent.dial(mpCurrentAgent.AgentArg, pCallParams);
        }
        public void Dial(string PhoneNumber, int ServiceId, int ExternalRouteId)
        {
            //Log.InfoFormat("[{0}] ENTER, PhoneNumber<{1}>, ServiceId<{2}>, ExternalRouteId<{3}>", MethodBase.GetCurrentMethod().Name, PhoneNumber, ServiceId, ExternalRoute?.Id ?? 0);
            //if ((CurrentCall == null || !(CurrentCall.CurrentState is PreviewCallState)) && !CurrentState.EnableDial)
            //{
            //    throw new InvalidOperationException("Invalid request - Dial. Request not allowed in the current state.");
            //}

            //if (PhoneNumber == null || PhoneNumber.Trim().Length == 0)
            //{
            //    throw new ArgumentException("Incorrect format specified for PhoneNumber ", "PhoneNumber");
            //}

            //PhoneNumber = PhoneNumber.ToDigitsOnly();
            //Log.InfoFormat("[{0}] ,  PhoneNumber<{1}> used to Dial ", MethodBase.GetCurrentMethod().Name, PhoneNumber);
            //Contact contact = null;
            //UDCall uDCall = new UDCall();
            //Contact contact2;
            //if (CurrentCall != null && CurrentCall.CurrentState is PreviewCallState)
            //{
            //    contact = CurrentCall;
            //    contact2 = CurrentCall;
            //    contact2.phoneNumber = PhoneNumber;
            //    uDCall.makeCallType = 3;
            //}
            //else
            //{
            //    if (CurrentCall != null && CurrentCall.CallLine.ParentCall.PendingDisposition == null)
            //    {
            //        contact = CurrentCall.CallLine.ParentCall;
            //    }

            //    contact2 = new ManualVoiceContact(contact, DialType.dtExternal, ExternalRoute);
            //    contact2.serviceID = ServiceId;
            //    contact2.phoneNumber = PhoneNumber;
            //    contact2.userDefinedItems = callInData.userDefinedItems;
            //    mpCallManager.PendingManualCall = (ManualVoiceContact)contact2;
            //    uDCall.makeCallType = 2;
            //}

            //if (contact != null)
            //{
            //    uDCall.callID = contact.CallID;
            //}

            //uDCall.externalRouteID = ExternalRoute?.Id ?? 0;
            //uDCall.serviceID = contact2.ServiceID;
            //uDCall.phoneNumber = contact2.PhoneNumber.ToDigitsOnly();
            //try
            //{
            //    mpPortal.AgentWebService.dial(mpCurrentAgent.AgentArg, uDCall);
            //    lastCall = uDCall;
            //}
            //catch (Exception ex)
            //{
            //}


            try
            {
                if (PhoneNumber == null || PhoneNumber.Trim().Length == 0)
                    throw new ArgumentException("You must specify a PhoneNumber", nameof(PhoneNumber));
                CCall ccall1 = (CCall)null;
                UDCall callinfo = new UDCall();
                CCall ccall2;
                if (this.CurrentCall != null && this.CurrentCall.CurrentState is CStatePreview)
                {
                    ccall2 = this.CurrentCall;
                    ccall1 = ccall2.ParentCall == null ? this.CurrentCall : ccall2.ParentCall;
                    ccall2.ParentCall = ccall1;
                    ccall2.phoneNumber = PhoneNumber;
                    callinfo.callID = ccall2.callID;
                    callinfo.makeCallType = 3;
                }
                else
                {
                    ccall2 = (CCall)new CCallVoice();
                    ccall2.serviceID = ServiceId;
                    ccall2.phoneNumber = PhoneNumber;
                    this.mpCallManager.PendingManualCall = ccall2;
                    callinfo.makeCallType = 2;
                    if (this.CurrentCall != null)
                    {
                        ccall1 = this.CurrentCall.ParentCall;
                        ccall2.ParentCall = ccall1;
                    }
                    else
                        ccall2.ParentCall = ccall2;
                }
                callinfo.externalRouteID = ExternalRouteId;
                callinfo.serviceID = ccall2.ServiceID;
                callinfo.phoneNumber = ccall2.PhoneNumber;
                if (ccall1 != null)
                    callinfo.callID = ccall1.callID;
                else if (this.CurrentState is CStateWrap || this.CurrentState is CStateInactive)
                {
                    if (lastCall != null)
                        callinfo.callID = lastCall.callID;
                    else
                    {
                        callinfo.callID = this.CurrentCall.callID;
                        lastCall = callinfo;
                    }
                        
                }
                   
                this.mpPortal.WSAgent.dial(this.mpCurrentAgent.AgentArg, callinfo);
               
            }
            catch (Exception ex)
            {
                throw new Exception(nameof(Dial), ex);
            }
        }

        public void Dial2(String PhoneNumber, int ServiceId, int ExternalRouteId)
        {
            if (PhoneNumber == null || PhoneNumber.Trim().Length == 0)
                throw new ArgumentException("You must specify a PhoneNumber", "PhoneNumber");

            CCall pCall;
            UDCall pCallParams = new UDCall();

            //If dialing a preview, retrieve preview call and update its phone number
            if (this.CurrentCall != null && this.CurrentCall.CurrentState is CStatePreview)
            {
                pCall = this.CurrentCall;
                //Overwrite preview's phone number with number specified by user
                //and use service of preview call
                pCall.phoneNumber = PhoneNumber;

                pCallParams.makeCallType = (int)DialType.dtPreview;
            }
            //Otherwise, create manual call and save it waiting for dialing event
            else
            {
                //Create manual call with number and service specified by user
                pCall = new CCallVoice();
                pCall.serviceID = ServiceId;
                pCall.phoneNumber = PhoneNumber;

                mpCallManager.PendingManualCall = pCall;

                pCallParams.makeCallType = (int)DialType.dtExternal;
            }
            pCallParams.callID = pCall.callID;
            pCallParams.externalRouteID = ExternalRouteId;
            pCallParams.serviceID = pCall.ServiceID;
            pCallParams.phoneNumber = pCall.PhoneNumber;
            //mpCurrentAgent.AgentArg.agentIndex = mpCurrentAgent.AgentIndex; ;

            mpPortal.WSAgent.dial(mpCurrentAgent.AgentArg, pCallParams);
        }

        public void Hold()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Hold. There's no current call to hold.");

            if (!(this.CurrentCall.FirstPartyCall.CurrentState is CStateActive))
                throw new InvalidOperationException("Invalid request - Hold. Request not allowed in current state of current call.");

            UDParm oParam = new UDParm();
            oParam.callId = this.CurrentCall.CallID;
            mpPortal.WSAgent.hold(mpCurrentAgent.AgentArg, oParam);
        }

        public void HoldConsultation()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - HoldConsultation. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - HoldConsultation. The current call does not support consultations.");

            CCallVoice pCall = (CCallVoice)this.CurrentCall;

            if (pCall.thirdPartyCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - HoldConsultation. There is no current consultation call.");

            if (!(pCall.thirdPartyCall.CurrentState is CStateActive))
                throw new InvalidOperationException("Invalid request - HoldConsultation. Request not allowed in current state of consultation call.");

            UDParm pParam = new UDParm();
            pParam.callId = pCall.thirdPartyCall.CallID;
            mpPortal.WSAgent.hold(mpCurrentAgent.AgentArg, pParam);
        }

        public void ReleaseHold()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - ReleaseHold. There's no current call on which to release a hold.");

            if (!(this.CurrentCall.FirstPartyCall.CurrentState is CStateHeld))
                throw new InvalidOperationException("Invalid request - ReleaseHold. Request not allowed in current state of current call.");

            UDParm oParam = new UDParm();
            oParam.callId = this.CurrentCall.CallID;
            mpPortal.WSAgent.retrieveHold(mpCurrentAgent.AgentArg, oParam);
        }

        public void ReleaseHoldOnConsultation()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. The current call does not support consultations.");

            CCallVoice pCall = (CCallVoice)this.CurrentCall;

            if (pCall.thirdPartyCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. There is no current consultation call.");

            if (!(pCall.thirdPartyCall.CurrentState is CStateHeld))
                throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. Request not allowed in current state of consultation call.");

            UDParm pParam = new UDParm();
            pParam.callId = pCall.thirdPartyCall.CallID;
            mpPortal.WSAgent.retrieveHold(mpCurrentAgent.AgentArg, pParam);
        }

        public void BecomeUnavailable(CNotReadyReason pNotReadyReason, bool Park)
        {
            if (pNotReadyReason == null)
                throw new ArgumentNullException("pNotReadyReason", "You must specify a NotReady Reason");

            UDReason oReason = new UDReason();
            oReason.reasonId = pNotReadyReason.Id;
            oReason.toParkState = Park;
            mpPortal.WSAgent.requestUnavailable(mpCurrentAgent.AgentArg, oReason);
        }
        public void BecomeUnavailableCancel()
        {

            mpPortal.WSAgent.cancelRequestUnavailable(mpCurrentAgent.AgentArg);
        }
        public void CancelLogOut()
        {

            mpPortal.WSAgent.cancelRequestLogout(mpCurrentAgent.AgentArg);
        }

        public void BecomeAvailable()
        {
            mpPortal.WSAgent.available(mpCurrentAgent.AgentArg);
        }

        private void Consult(UDConsultIn consultParams)
        {
            CCall pCall = this.CurrentCall;

            //Copy call's user defined fields
            UDCallInfoUserDefinedItemIn[] items = new UDCallInfoUserDefinedItemIn[20];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new UDCallInfoUserDefinedItemIn();
                items[i].key = pCall.userDefinedItems[i].key;
                items[i].value = pCall.userDefinedItems[i].value;
            }

            consultParams.callID = pCall.CallID;
            consultParams.userDefinedData = new UDCallInfoUserDefinedIn();
            consultParams.userDefinedData.userDefinedItems = items;

            mpPortal.WSAgent.consult(mpCurrentAgent.AgentArg, consultParams);
        }

        /// <summary>
        /// Consult the specified user
        /// </summary>
        public void Consult(CUser user)
        {
            if (user == null)
                throw new ArgumentException("You must specify a user.", "user");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");

            if (!(this.CurrentCall.CurrentState.EnableConsult))
                throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");

            //Save the information about the consultation to the current 3rdParty call in case we need to refer to it later.
            CCallVoice pCall = (CCallVoice)this.CurrentCall;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationEntity = user;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationPhoneNumber = "";
            //Point the PendingConsultation reference to the current 3rdParty call
            mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty)pCall.ThirdPartyCall;

            //Send the request
            UDConsultIn oParams = new UDConsultIn();
            oParams.consultType = (int)ConsultType.ctInternal;
            oParams.blindXferFlag = Convert.ToInt32(false);
            oParams.userID = user.Id;

            Consult(oParams);
        }

        /// <summary>
        /// Consult the specified service
        /// </summary>
        public void Consult(CSimpleService service)
        {
            if (service == null)
                throw new ArgumentException("You must specify a service.", "service");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");

            if (!(this.CurrentCall.CurrentState.EnableConsult))
                throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");

            //Save the information about the consultation to the current 3rdParty call in case we need to refer to it later.
            CCallVoice pCall = (CCallVoice)this.CurrentCall;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationEntity = service;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationPhoneNumber = "";
            //Point the PendingConsultation reference to the current 3rdParty call
            mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty)pCall.ThirdPartyCall;

            //Send the request
            UDConsultIn oParams = new UDConsultIn();
            oParams.consultType = (int)ConsultType.ctInternal;
            oParams.blindXferFlag = Convert.ToInt32(false);
            oParams.serviceID = service.ServiceId;

            Consult(oParams);
        }

        /// <summary>
        /// Consult the specified phone number
        /// </summary>
        public void Consult(String phoneNumber, CExternalRoute externalRoute)
        {
            if (phoneNumber == null)
                throw new ArgumentException("You must specify a phone number.", "phoneNumber");

            if (phoneNumber.Trim() == "")
                throw new ArgumentException("You must specify a phone number.", "phoneNumber");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Consult. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");

            if (!(this.CurrentCall.CurrentState.EnableConsult))
                throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");


            //Save the information about the consultation to the current 3rdParty call in case we need to refer to it later.
            CCallVoice pCall = (CCallVoice)this.CurrentCall;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationEntity = externalRoute;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationPhoneNumber = phoneNumber;
            //Point the PendingConsultation reference to the current 3rdParty call
            mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty)pCall.ThirdPartyCall;


            UDConsultIn oParams = new UDConsultIn();
            oParams.consultType = (int)ConsultType.ctExternal;
            oParams.blindXferFlag = Convert.ToInt32(false);
            oParams.phoneNumber = phoneNumber;
            if (externalRoute != null)
                oParams.externalRouteID = externalRoute.Id;

            Consult(oParams);
        }

        /// <summary>
        /// Consult the specified phone number
        /// </summary>
        public void Consult(String phoneNumber)
        {
            Consult(phoneNumber, null);
        }

        /// <summary>
        /// Transfer the current call to the specified user
        /// </summary>
        public void Transfer(CUser user)
        {
            if (user == null)
                throw new ArgumentException("You must specify a user.", "user");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (!this.CurrentCall.CurrentState.EnableTransfer)
                throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");

            //[Blind] Transfer to User is actually requested via the consult method with blindXferFlag=true.
            //
            //Save the information about the consultation to the current 3rdParty call in case we need to refer to it later.
            CCallVoice pCall = (CCallVoice)this.CurrentCall;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationEntity = user;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationPhoneNumber = "";
            //Point the PendingConsultation reference to the current 3rdParty call
            mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty)pCall.ThirdPartyCall;

            UDConsultIn oParams = new UDConsultIn();

            //Set consultType corresponding to calltype of current call 
            switch (this.CurrentCall.MediaType)
            {
                case AgentMediaType.amINBOUND_AGD:
                    oParams.consultType = (int)ConsultType.ctXferAGDToAgent;
                    break;

                case AgentMediaType.amINBOUND_CHAT:
                    oParams.consultType = (int)ConsultType.ctXferChatToAgent;
                    break;

                default:
                    oParams.consultType = (int)ConsultType.ctInternal;
                    break;
            }

            oParams.blindXferFlag = Convert.ToInt32(true);
            oParams.userID = user.Id;

            Consult(oParams);
        }

        /// <summary>
        /// Transfer the current call to the specified phone number
        /// </summary>
        public void Transfer(String phoneNumber)
        {
            Transfer(phoneNumber, null);
        }

        /// <summary>
        /// Transfer the current call to the specified phone number
        /// </summary>
        public void Transfer(String phoneNumber, CExternalRoute externalRoute)
        {
            if (phoneNumber == null)
                throw new ArgumentException("You must specify a phone number.", "phoneNumber");

            if (phoneNumber.Trim() == "")
                throw new ArgumentException("You must specify a phone number.", "phoneNumber");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (!this.CurrentCall.CurrentState.EnableTransfer)
                throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");


            //[Blind] Transfer to external is actually requested via the consult method with blindXferFlag=true
            //
            //Save the information about the consultation to the current 3rdParty call in case we need to refer to it later.
            CCallVoice pCall = (CCallVoice)this.CurrentCall;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationEntity = externalRoute;
            ((C3WayCall3rdParty)pCall.ThirdPartyCall).consultationPhoneNumber = phoneNumber;
            //Point the PendingConsultation reference to the current 3rdParty call
            mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty)pCall.ThirdPartyCall;


            UDConsultIn oParams = new UDConsultIn();
            oParams.consultType = (int)ConsultType.ctExternal;
            oParams.blindXferFlag = Convert.ToInt32(true);
            oParams.phoneNumber = phoneNumber;
            if (externalRoute != null)
                oParams.externalRouteID = externalRoute.Id;

            Consult(oParams);
        }

        private void Transfer(UDTransfer xferParams)
        {
            CCall pCall = this.CurrentCall;

            //Copy call's user defined fields
            UDCallInfoUserDefinedItemIn[] items = new UDCallInfoUserDefinedItemIn[20];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new UDCallInfoUserDefinedItemIn();
                items[i].key = pCall.userDefinedItems[i].key;
                items[i].value = pCall.userDefinedItems[i].value;
            }

            xferParams.originalCallID = this.CurrentCall.CallID;
            xferParams.callInfoUserDefined = new UDCallInfoUserDefinedIn();
            xferParams.callInfoUserDefined.userDefinedItems = items;

            mpPortal.WSAgent.transfer(mpCurrentAgent.AgentArg, xferParams);
        }

        /// <summary>
        /// Transfer the current call to the specified service
        /// </summary>
        public void Transfer(CSimpleService service)
        {
            if (service == null)
                throw new ArgumentException("You must specify a service.", "service");

            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (!this.CurrentCall.CurrentState.EnableTransfer)
                throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");

            UDTransfer oParams = new UDTransfer();
            oParams.serviceID = service.ServiceId;
            oParams.transferType = (int)TransferType.ttBlind;

            Transfer(oParams);
        }
        public void warning(int wtype)
        {
            try
            {
                UDWarning uDWarning = new UDWarning();
                uDWarning.warnType = wtype;
                mpPortal.WSAgent.warning(mpCurrentAgent.AgentArg, uDWarning);
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// Transfer the current call to the consulted/conferenced party
        /// </summary>
        public void Transfer()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                //This error message makes more sense for this request than "...current call does not support consultations..."
                throw new InvalidOperationException("Invalid request - Transfer. There is no current consultation call.");

            CCallVoice pCall = (CCallVoice)this.CurrentCall;

            if (pCall.thirdPartyCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Transfer. There is no current consultation call.");

            if (!this.CurrentCall.CurrentState.EnableTransfer)
                throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");

            UDTransfer oParams = new UDTransfer();
            oParams.serviceID = pCall.ServiceID;
            oParams.thirdParyCallID = pCall.ThirdPartyCall.CallID;
            //If not in Conference, the Conference CallID will be 0 which is fine - the Transfer to the consulted party will still be made.
            oParams.conferenceCallID = pCall.ConferenceCall.CallID;

            oParams.transferType = (int)TransferType.ttWarm;

            Transfer(oParams);
        }

        /// <summary>
        /// Conference-in the consulted party
        /// </summary>
        public void Conference()
        {
            if (this.CurrentCall == null)
                throw new InvalidOperationException("Invalid request - Conference. There is no current call.");

            if (this.CurrentCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Conference. There is no current call.");

            if (!(this.CurrentCall is CCallVoice))
                //This error message makes more sense for this request than "...current call does not support consultations..."
                throw new InvalidOperationException("Invalid request - Conference. There is no current consultation call.");

            CCallVoice pCall = (CCallVoice)this.CurrentCall;

            if (pCall.thirdPartyCall.CallID == 0)
                throw new InvalidOperationException("Invalid request - Conference. There is no current consultation call.");

            if (!this.CurrentCall.CurrentState.EnableConference)
                throw new InvalidOperationException("Invalid request - Conference. Request not allowed in current state of current call.");

            UDConferenceIn oParams = new UDConferenceIn();
            oParams.callID = this.CurrentCall.CallID;
            oParams.consultCallID = ((CCallVoice)this.CurrentCall).ThirdPartyCall.CallID;

            mpPortal.WSAgent.conference(mpCurrentAgent.AgentArg, oParams);
        }

        /// <summary>
        /// Accept the current call
        /// </summary>
        public void AcceptCall()
        {
            //TODO: Validate request

            UDAnswerCall oAnswer = new UDAnswerCall();
            oAnswer.result = Convert.ToInt32(false);
            oAnswer.agentIndex = mpCurrentAgent.AgentIndex;
            oAnswer.callID = mpCallManager.CurrentCall.CallID;

            mpPortal.WSAgent.answerCall(mpCurrentAgent.AgentArg, oAnswer);
        }

        /// <summary>
        /// Reject the current call with the specified reason
        /// </summary>
        public void RejectCall(CCallRejectionReason pRejectionReason)
        {
            //TODO: Validate request

            UDAnswerCall oAnswer = new UDAnswerCall();
            oAnswer.result = Convert.ToInt32(true);
            oAnswer.agentIndex = mpCurrentAgent.AgentIndex;
            oAnswer.callID = mpCallManager.CurrentCall.CallID;
            if (pRejectionReason != null)
                oAnswer.rejectReason = pRejectionReason.Id;

            mpPortal.WSAgent.answerCall(mpCurrentAgent.AgentArg, oAnswer);
        }

        /// <summary>
        /// Reject the current call
        /// </summary>
        public void RejectCall()
        {
            RejectCall(null);
        }

        public CAgents GetAgents()
        {
            CAgents oAgents = new CAgents(this);
            oAgents.Load(this.CurrentService.serviceId);
            return oAgents;
        }

        public CSupervisors GetSupervisors()
        {
            CSupervisors oSups = new CSupervisors(this);
            oSups.Load(this.CurrentService.serviceId);
            return oSups;
        }

        public CServices GetServices()
        {
            CServices oSvcs = new CServices(this);
            switch (this.CurrentService.ServiceType)
            {
                case ServiceType.CHAT:
                case ServiceType.AGD:
                case ServiceType.CTI:
                    oSvcs.Load(this.CurrentService.ServiceType);
                    break;
                default:
                    oSvcs.Load();
                    break;
            }

            return oSvcs;
        }

        public void SendChatMessage(CCallChat pCall, String sMessage)
        {
            //TODO: Validate request
            if (pCall == null)
                throw new InvalidOperationException("Invalid request - SendChatMessage. You must specify a call.");

            UDChatMessage oMessageParams = new UDChatMessage();
            //TODO: If there's also a voice call, the callid of the chat call may not be that of the current call.
            oMessageParams.callId = pCall.CallID;
            oMessageParams.text = sMessage;

            mpPortal.WSAgent.chatSendMessage(mpCurrentAgent.AgentArg, oMessageParams);
        }

        public void SendChatURL(CCallChat pCall, String sURL)
        {
            //TODO: Validate request
            if (pCall == null)
                throw new InvalidOperationException("Invalid request - SendChatURL. You must specify a call.");

            //Must send URLs with http or customer's web app won't handle them properly
            //Only check for http in case user specified https
            if (!(sURL.StartsWith("http", StringComparison.OrdinalIgnoreCase)))
                sURL = "http://" + sURL;

            UDChatURL oURLParams = new UDChatURL();
            //TODO: If there's also a voice call, the callid of the chat call may not be that of the current call.
            oURLParams.callId = pCall.CallID;
            oURLParams.url = sURL;

            mpPortal.WSAgent.chatSendURL(mpCurrentAgent.AgentArg, oURLParams);
        }

        internal void ConnectToChatServer(CCallChat pCall)
        {
            try
            {
                UDChatConnect oConnectParams = new UDChatConnect();
                oConnectParams.callId = pCall.CallID;
                oConnectParams.serviceId = pCall.ServiceID;
                oConnectParams.chatserverIP = pCall.ChatServerIP;
                oConnectParams.chatserverCSLPort = pCall.ChatServerPort;
                oConnectParams.entityType = (int)ChatEntityType.ceAgent;
                oConnectParams.firstName = mpCurrentAgent.FirstName;
                oConnectParams.lastName = mpCurrentAgent.LastName;

                mpPortal.WSAgent.chatConnect(mpCurrentAgent.AgentArg, oConnectParams);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        internal bool EnableKeepAlives
        {
            set
            {
                if (value && mpKeepAliveTimer == null)
                {
                    //Start sending KeepAlives
                    TimerCallback timerDelegate = new TimerCallback(SendKeepAlive);
                    mpKeepAliveTimer = new Timer(timerDelegate, this, 60000, 60000);
                }
                else if (!value && mpKeepAliveTimer != null)
                {
                    mpKeepAliveTimer.Dispose();
                    mpKeepAliveTimer = null;
                }
            }
        }

        private void SendKeepAlive(Object state)
        {
            try
            {
                mpPortal.WSAgent.keepAlive(CurrentAgent.AgentArg);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }
        internal void OnAgentStats(AgentStatsEventArgs pArgs)
        {
            if (this.AgentStats != null)
            {
                this.AgentStats(this, pArgs);
            }
        }
        internal void OnStateChange(CStateChangeArgs pArgs)
        {
            if (StateChange != null)
                StateChange(this, pArgs);
        }

        internal void OnUnfocusedStateChange(CUnfocusedStateChangeArgs pArgs)
        {
            if (UnfocusedStateChange != null)
                UnfocusedStateChange(this, pArgs);
        }

        internal void OnCallStateChange(CCallStateChangeArgs pArgs)
        {
            if (CallStateChange != null)
                CallStateChange(this, pArgs);
        }

        internal void OnUnfocusedCallStateChange(CUnfocusedCallStateChangeArgs pArgs)
        {
            if (UnfocusedCallStateChange != null)
                UnfocusedCallStateChange(this, pArgs);
        }

        internal void OnPasscode(CPasscodeArgs pArgs)
        {
            if (Passcode != null)
                Passcode(this, pArgs);
        }

        internal void OnLogoutPending()
        {
            if (LogoutPending != null)
                LogoutPending(this);
        }

        internal void OnScreenpop(CScreenpopArgs pArgs)
        {
            if (Screenpop != null)
                Screenpop(this, pArgs);
        }

        internal void OnCallActivated(CCallActivatedArgs pArgs)
        {
            if (CallActivated != null)
                CallActivated(this, pArgs);
        }

        internal void OnPhoneStatus(CPhoneStatusArgs pArgs)
        {
            if (PhoneStatus != null)
                PhoneStatus(this, pArgs);
        }

        internal void OnError(CErrorArgs pArgs)
        {
            if (Error != null)
                Error(this, pArgs);
        }

        internal void OnLoggedIn()
        {
            if (LoggedIn != null)
                LoggedIn(this);
        }
        internal void OnSessionTimedOut(SessionTimedOutEventArgs pArgs)
        {
            if (this.SessionTimedOut != null)
            {
                this.SessionTimedOut(this, pArgs);
            }
        }

        public bool IsUnavailablePending => this._isUnavailablePending;

        internal bool isUnavailablePending
        {
            get => this._isUnavailablePending;
            set
            {
                try
                {
                    if (this._isUnavailablePending != value)
                    {
                        this._isUnavailablePending = value;
                        this.OnGoUnavailableRequestStatus(new PortalRequestStatusEventArgs(this._isUnavailablePending));
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
        public class PortalRequestStatusEventArgs : EventArgs
        {
            private bool mbRequestPending;

            public PortalRequestStatusEventArgs(bool bRequestPending)
            {
                this.mbRequestPending = bRequestPending;
            }

            public bool RequestPending => this.mbRequestPending;
        }
        internal void OnGoUnavailableRequestStatus(PortalRequestStatusEventArgs pArgs)
        {
            if (this.GoUnavailableRequestStatus == null)
                return;
            this.GoUnavailableRequestStatus((object)this, pArgs);
        }
        internal void OnWrapTimeout(WrapTimeoutEventArgs pArgs)
        {
            if (this.WrapTimeout != null)
            {
                this.WrapTimeout(this, pArgs);
            }
        }
        internal void OnAssignedServiceUpdated(AssignedServicesUpdateEventArgs pArgs)
        {
            if (this.AssignedServiceUpdated != null)
            {
                this.AssignedServiceUpdated(this, pArgs);
            }
        }
        internal void OnChatEntityAdded(CChatEntityArgs pArgs)
        {
            if (ChatEntityAdded != null)
                ChatEntityAdded(this, pArgs);
        }

        internal void OnChatEntityRemoved(CChatEntityArgs pArgs)
        {
            if (ChatEntityRemoved != null)
                ChatEntityRemoved(this, pArgs);
        }

        internal void OnChatURL(CChatURLArgs pArgs)
        {
            if (ChatURL != null)
                ChatURL(this, pArgs);
        }

        internal void OnChatMessage(CChatMessageArgs pArgs)
        {
            if (ChatMessage != null)
                ChatMessage(this, pArgs);
        }

        internal bool ServiceExists(int ServiceId)
        {
            UDInfo oInfo = new UDInfo();
            oInfo.listType = (int)AgentInfoType.GET_CHECK_SERVICE_EXISTS;
            oInfo.serviceId = ServiceId;
            EPAgentWS.GetIdDesc oItem = (EPAgentWS.GetIdDesc)mpPortal.WSAgent.getInfo(mpCurrentAgent.AgentArg, oInfo);
            return Convert.ToBoolean(oItem.id);
        }

      
    }

    public class BusinessObject
    {
        private int id;

        internal string description;

        public int Id => id;

        public string Description => description;

        internal BusinessObject(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public override string ToString()
        {
            return id + "\t" + description;
        }
    }
    public class DispositionDispose : BusinessObject
    {

        internal string code;

        internal bool isSale;

        internal bool isCallback;

        internal bool isExclusion;

        public string Code => code;

        public bool IsSale => isSale;

        public bool IsCallback => isCallback;

        public bool IsExclusion => isExclusion;

        internal DispositionDispose(int id, string description, string code, bool isSale, bool isCallback, bool isExclusion)
            : base(id, description)
        {
            this.code = code;
            this.isSale = isSale;
            this.isExclusion = isExclusion;
            this.isCallback = isCallback;
        }

        public override string ToString()
        {
            return $"Id<{base.Id}>, Code<{Code}>, Desc<{base.Description}>, IsSale<{IsSale}>, IsCallback<{IsCallback}>, IsExclusion<{IsExclusion}>";
        }
    }
    public class CallbackServices : BusinessObjectCollection
    {
        private CApp _application;

        internal CallbackServices(CApp application) => this._application = application;

        public CallbackService this[int index] => (CallbackService)base[index];

        public CallbackService GetByKey(object key) => (CallbackService)base.GetByKey(key);

        internal void Load()
        {
            this.Clear();
            EPAgentWS.CallBackService[] callbackServiceList = _application.getCallbackServiceList();
            //CallBackService[] callbackServiceList = this._application.CurrentProvisioning.getCallbackServiceList();
            for (int index = 0; index < callbackServiceList.Length; ++index)
            {
                CallbackService callbackService = new CallbackService(callbackServiceList[index].serviceid, callbackServiceList[index].servicec, Convert.ToBoolean(callbackServiceList[index].cbservicecallbackflag), Convert.ToBoolean(callbackServiceList[index].cbselfcallbackflag), callbackServiceList[index].callbackdays);
                try
                {
                    this.Add((object)callbackService.ServiceId, (object)callbackService);
                }
                catch (Exception ex)
                {
                }
                finally
                {
                }
            }
        }

        public new IEnumerator GetEnumerator()
        {
            this.Load();
            return base.GetEnumerator();
        }

        internal void Update(EPEventsWS.UDUpdateService updatedService)
        {
            try
            {
                if (updatedService.serviceInfo.servicetypeid != 4)
                {
                }
                else
                {
                    CallbackService callbackService = new CallbackService(updatedService.serviceID, updatedService.serviceInfo.servicec, Convert.ToBoolean(updatedService.serviceSettings.cbservicecallbackflag), Convert.ToBoolean(updatedService.serviceSettings.cbselfcallbackflag), updatedService.serviceSettings.callbackdays);
                    if (this.Contains((object)callbackService.ServiceId))
                    {
                        if (!callbackService.AllowCallbacksToService && !callbackService.AllowCallbacksToAgent)
                        {
                            this.RemoveByKey((object)callbackService.ServiceId);
                        }
                        else
                        {
                            CallbackService byKey = (CallbackService)base.GetByKey((object)callbackService.ServiceId);
                            this.RemoveByKey((object)callbackService.ServiceId);
                            this.Add((object)callbackService.ServiceId, (object)callbackService);
                            this.Sort((IComparer)new CallbackServices.CallbackServiceComparer());
                        }
                    }
                    else if (callbackService.AllowCallbacksToService || callbackService.AllowCallbacksToAgent)
                    {
                        this.Add((object)callbackService.ServiceId, (object)callbackService);
                        this.Sort((IComparer)new CallbackServices.CallbackServiceComparer());
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        internal void Update(EPEventsWS.UDNewService newService)
        {
            try
            {
                if (newService.serviceInfo.servicetypeid != 4)
                {
                }
                else
                {
                    CallbackService callbackService = new CallbackService(newService.serviceID, newService.serviceInfo.servicec, Convert.ToBoolean(newService.serviceSettings.cbservicecallbackflag), Convert.ToBoolean(newService.serviceSettings.cbselfcallbackflag), newService.serviceSettings.callbackdays);
                   if (callbackService.AllowCallbacksToService || callbackService.AllowCallbacksToAgent)
                    {
                        this.Add((object)callbackService.ServiceId, (object)callbackService);
                        this.Sort((IComparer)new CallbackServices.CallbackServiceComparer());
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private class CallbackServiceComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                return (x as CallbackService).ServiceName.CompareTo((y as CallbackService).ServiceName);
            }
        }
    }

    public class BusinessObjectCollection : ICollection, IEnumerable
    {
        private ArrayList pValues;
        private ArrayList pKeys;

        protected BusinessObjectCollection()
        {
            this.pValues = new ArrayList();
            this.pKeys = new ArrayList();
        }

        public int Count => this.pValues.Count;

        public bool IsSynchronized => false;

        public object SyncRoot => (object)this;

        public void CopyTo(Array array, int index) => this.pValues.CopyTo(array, index);

        public IEnumerator GetEnumerator() => this.pValues.GetEnumerator();

        public bool Contains(object key)
        {
            return key != null ? this.pKeys.Contains(key) : throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
        }

        protected void Add(object key, object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
            if (this.pKeys.Contains(key))
                throw new ArgumentException("The specified key already exists. Duplicate keys are not allowed.", nameof(key));
            this.pValues.Add(value);
            this.pKeys.Add(key);
        }

        public object this[int index] => this.pValues[index];

        protected object GetByKey(object key)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
            return this.pValues[this.pKeys.IndexOf(key)];
        }

        protected void SetByKey(object key, object value)
        {
            if (key == null)
                throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
            this.pValues[this.pKeys.IndexOf(key)] = value;
        }

        public int IndexOf(object key)
        {
            return key != null ? this.pKeys.IndexOf(key) : throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
        }

        protected void RemoveAt(int index)
        {
            this.pValues.RemoveAt(index);
            this.pKeys.RemoveAt(index);
        }

        protected internal void RemoveByKey(object key)
        {
            int index = key != null ? this.pKeys.IndexOf(key) : throw new ArgumentNullException(nameof(key), "Null keys are not allowed");
            this.pKeys.RemoveAt(index);
            this.pValues.RemoveAt(index);
        }

        protected void Clear()
        {
            this.pKeys.Clear();
            this.pValues.Clear();
        }

        public void Sort(IComparer comparer)
        {
            List<KeyValuePair<object, object>> keyValuePairList = new List<KeyValuePair<object, object>>();
            for (int index = 0; index < this.pKeys.Count; ++index)
                keyValuePairList.Add(new KeyValuePair<object, object>(this.pKeys[index], this.pValues[index]));
            keyValuePairList.Sort((Comparison<KeyValuePair<object, object>>)((firstPair, nextPair) => comparer.Compare(firstPair.Value, nextPair.Value)));
            this.pKeys.Clear();
            this.pValues.Clear();
            foreach (KeyValuePair<object, object> keyValuePair in keyValuePairList)
            {
                this.pKeys.Add(keyValuePair.Key);
                this.pValues.Add(keyValuePair.Value);
            }
        }

        private class CContactListEnumerator : IEnumerator
        {
            private BusinessObjectCollection Items;
            private int Cursor;

            public CContactListEnumerator(BusinessObjectCollection Items)
            {
                this.Items = Items;
                this.Cursor = -1;
            }

            public void Reset() => this.Cursor = -1;

            public bool MoveNext()
            {
                if (this.Cursor < this.Items.Count)
                    ++this.Cursor;
                return this.Cursor != this.Items.Count;
            }

            public object Current
            {
                get
                {
                    if (this.Cursor < 0 || this.Cursor == this.Items.Count)
                        throw new InvalidOperationException();
                    return this.Items[this.Cursor];
                }
            }
        }
    }
    public class CallbackService : BusinessObject
    {
        private int serviceId;
        private string serviceName;
        private bool allowCallbacksToService;
        private bool allowCallbacksToAgent;
        private int maxCallbackDays;

        public int ServiceId => this.serviceId;

        public string ServiceName => this.serviceName;

        public bool AllowCallbacksToService => this.allowCallbacksToService;

        public bool AllowCallbacksToAgent => this.allowCallbacksToAgent;

        public int MaxCallbackDays => this.maxCallbackDays;

        internal CallbackService(
          int serviceId,
          string serviceName,
          bool allowCallbacksToService,
          bool allowCallbacksToAgent,
          int maxCallbackDays)
          : base(serviceId, serviceName)
        {
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.allowCallbacksToAgent = allowCallbacksToAgent;
            this.allowCallbacksToService = allowCallbacksToService;
            this.maxCallbackDays = maxCallbackDays;
        }

        public override string ToString()
        {
            return string.Format("ServiceId<{0}>, ServiceName<{1}>, AllowCallbacksToService<{2}>, AllowCallbacksToAgent<{3}>, MaxCallbackDays<{4}>", (object)this.ServiceId, (object)this.ServiceName, (object)this.AllowCallbacksToService, (object)this.AllowCallbacksToAgent, (object)this.MaxCallbackDays);
        }
    }
}
