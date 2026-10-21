// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CApp
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;
using System.Threading;
using Utilities;

namespace SamplePortalClient
{
  public class CApp
  {
    private CEventManager mpEventManager;
    private CPortal mpPortal;
    private CAgent mpCurrentAgent;
    private CCallManager mpCallManager;
    private Timer mpKeepAliveTimer;
    private CLogoutReasons mpLogoutReasons;
    private CNotReadyReasons mpNotReadyReasons;
    private CParkReasons mpParkReasons;
    private CCallRejectionReasons mpCallRejectionReasons;
    private CAssignedServices mpAssignedServices;
    private CDispositionPlans mpDispositionPlans;
    private CExternalRoutes mpExternalRoutes;
    private C3WayCallManager mpThreeWayCallManager;
    private LogFile logfile = new LogFile();

    public event StateChangeHandler StateChange;

    public event UnfocusedStateChangeHandler UnfocusedStateChange;

    public event CallStateChangeHandler CallStateChange;

    public event UnfocusedCallStateChangeHandler UnfocusedCallStateChange;

    public event PasscodeHandler Passcode;

    public event LogoutPendingHandler LogoutPending;

    public event ScreenpopHandler Screenpop;

    public event CallActivatedHandler CallActivated;

    public event PhoneStatusHandler PhoneStatus;

    public event ErrorHandler Error;

    public event LoggedInHandler LoggedIn;

    public event ChatEntityHandler ChatEntityAdded;

    public event ChatEntityHandler ChatEntityRemoved;

    public event ChatURLHandler ChatURL;

    public event ChatMessageHandler ChatMessage;

    public CState CurrentState => this.mpEventManager.CurrentState;

    public CAgent CurrentAgent => this.mpCurrentAgent;

    public CCall CurrentCall => this.mpCallManager.CurrentCall;

    public CLogoutReasons LogoutReasons => this.mpLogoutReasons;

    public CNotReadyReasons NotReadyReasons => this.mpNotReadyReasons;

    public CParkReasons ParkReasons => this.mpParkReasons;

    public CCallRejectionReasons CallRejectionReasons => this.mpCallRejectionReasons;

    public CExternalRoutes ExternalRoutes => this.mpExternalRoutes;

    public CAssignedServices AssignedServices => this.mpAssignedServices;

    public CService CurrentService => this.CurrentCall == null ? (CService) this.mpCurrentAgent : this.mpAssignedServices.GetByKey((object) this.CurrentCall.serviceID);

    internal CDispositionPlans DispositionPlans => this.mpDispositionPlans;

    internal CPortal Portal => this.mpPortal;

    internal CEventManager EventManager => this.mpEventManager;

    internal CCallManager CallManager => this.mpCallManager;

    internal C3WayCallManager ThreeWayCallManager => this.mpThreeWayCallManager;

    public CApp()
    {
      this.mpPortal = new CPortal();
      this.mpEventManager = new CEventManager(this);
      this.mpCallManager = new CCallManager();
      this.mpAssignedServices = new CAssignedServices(this);
      this.mpLogoutReasons = new CLogoutReasons(this);
      this.mpNotReadyReasons = new CNotReadyReasons(this);
      this.mpParkReasons = new CParkReasons(this);
      this.mpCallRejectionReasons = new CCallRejectionReasons(this);
      this.mpDispositionPlans = new CDispositionPlans(this);
      this.mpExternalRoutes = new CExternalRoutes(this);
      this.mpThreeWayCallManager = new C3WayCallManager();
    }

    private string GetServiceUrl(string sDefaultUrl, string sPortal, string sProtocol)
    {
      if (sDefaultUrl == null || sDefaultUrl == "")
        return sDefaultUrl;
      int num = sDefaultUrl.IndexOf("//", 0);
      int startIndex = -1;
      if (num > -1)
        startIndex = sDefaultUrl.IndexOf("/", num + 2);
      return num > -1 && startIndex > -1 ? sProtocol + sPortal + sDefaultUrl.Substring(startIndex) : sDefaultUrl;
    }

    public void InvokeAgentStatistics()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.InvokeAgentStatistics() , User Agent Statistics Initialized . . .");
        this.mpPortal.WSAgent.requestAgentStats(this.mpCurrentAgent.AgentArg);
        this.logfile.LogMessageToFile(" |INFO| CApp.InvokeAgentStatistics() , User Agent Statistics completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.InvokeAgentStatistics() , Agent InvokeAgentStatistics Failed " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Login", ex);
      }
    }

    public User GetAgent(UDAgent AgentArg)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.GetAgent() , GetAgents Initialized.");
        User info = (User) this.mpPortal.WSAgent.getInfo(AgentArg, new UDInfo()
        {
          listType = 162
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.GetAgent() , GetAgents completed.");
        return info;
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.GetAgent() , GetAgents failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Invalid Agent Details", ex);
      }
    }

    public AgentWebServiceService GetAgentWebService() => this.Portal.WSAgent;

    public void Login(
      string sUser,
      string sPwd,
      string sStation,
      string sPortal,
      string sDomain,
      bool isSecure)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , User Agent Login is Initialized.");
        string empty1 = string.Empty;
        string sProtocol = !isSecure ? "http://" : "https://";
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Protocol = " + sProtocol);
        string serviceUrl1 = this.GetServiceUrl(this.mpPortal.WSAgent.Url, sPortal, sProtocol);
        string serviceUrl2 = this.GetServiceUrl(this.mpPortal.WSEvents.Url, sPortal, sProtocol);
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Portal URL : " + serviceUrl1);
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Event Portal URL : " + serviceUrl2);
        this.mpPortal.WSAgent.Url = serviceUrl1;
        this.mpPortal.WSEvents.Url = serviceUrl2;
        CAgent cagent = new CAgent();
        string empty2 = string.Empty;
        string str = sDomain;
        if (str.Trim().Length > 0)
          str = "@" + str;
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent User ID : " + sUser + str);
        cagent.ldapUserId = sUser + str;
        cagent.serverType = 1;
        cagent.InitState = 5;
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent User Info Object Initialized. ");
        UDInfo info1 = new UDInfo();
        info1.listType = 143;
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent User Info Object creation started ");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent User Object creation initialized. ");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , UDInfo Argument [ List Type : " + info1.listType.ToString() + " , Seq No :" + info1.seqNum.ToString() + " , Service ID : " + info1.serviceId.ToString() + " , UDInfo ID : " + info1.id.ToString());
        LogFile logfile1 = this.logfile;
        string[] strArray = new string[12];
        strArray[0] = " |INFO| CApp.Login() , Agent Argument [ Agent Index : ";
        int num = cagent.AgentArg.agentIndex;
        strArray[1] = num.ToString();
        strArray[2] = " , agentLoginName : ";
        strArray[3] = cagent.AgentArg.agentLoginName;
        strArray[4] = " , Init State : ";
        num = cagent.AgentArg.initState;
        strArray[5] = num.ToString();
        strArray[6] = " , Agent ID : ";
        strArray[7] = cagent.AgentArg.LDAPUserId;
        strArray[8] = " , clientRole : ";
        num = cagent.AgentArg.clientRole;
        strArray[9] = num.ToString();
        strArray[10] = " , serverType : ";
        num = cagent.AgentArg.serverType;
        strArray[11] = num.ToString();
        string message1 = string.Concat(strArray);
        logfile1.LogMessageToFile(message1);
        User info2 = (User) this.mpPortal.WSAgent.getInfo(cagent.AgentArg, info1);
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent User Object created.");
        if (info2 == null)
          throw new ArgumentNullException(nameof (Login), "User ID '" + sUser + "' not found Please try again");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigning Local IP Address initialized. ");
        info2.ipaddress = DNSUtility.GetLocalIP();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigning Local IP Address completed. IP Address  : " + info2.ipaddress.ToString());
        UDAgentInfo udAgentInfo = new UDAgentInfo();
        cagent.loginName = sUser;
        cagent.password = sPwd;
        cagent.clientRole = info2.usertypemask;
        cagent.AgentInfoArg.ipAddress = DNSUtility.GetLocalIP();
        try
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent authentication Initialized. ");
          this.mpPortal.WSAgent.authenticate(cagent.AgentArg, cagent.AgentInfoArg);
          this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent authentication Successful. ");
        }
        catch (Exception ex)
        {
          throw new Exception("Invalid User ID or password", ex);
        }
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigning Agent paramaters started");
        LogFile logfile2 = this.logfile;
        num = info2.allowNotReadyFlag;
        string message2 = " |INFO| CApp.Login() , User Allow Not Ready Flag : " + num.ToString();
        logfile2.LogMessageToFile(message2);
        cagent.InitState = info2.allowNotReadyFlag != 1 ? 0 : 5;
        LogFile logfile3 = this.logfile;
        num = cagent.InitState;
        string message3 = " |INFO| CApp.Login() , Agent Initial State : " + num.ToString();
        logfile3.LogMessageToFile(message3);
        cagent.station = sStation;
        cagent.agentType = 1;
        cagent.loginName = info2.userid;
        cagent.agentIndex = info2.agentindex;
        cagent.AgentArg.agentIndex = info2.agentindex;
        cagent.workgroupId = info2.workgroupid;
        cagent.routeAccessId = info2.routeaccessid;
        cagent.allowPark = Convert.ToBoolean(info2.park);
        cagent.parkAlarmSecs = info2.parkdelay;
        cagent.firstName = info2.userfname;
        cagent.lastName = info2.userlname;
        cagent.Multiline = Convert.ToBoolean(info2.multiLine);
        cagent.serviceId = 0;
        cagent.serviceType = ServiceType.MANUAL;
        cagent.serviceName = "Default";
        cagent.dispositionPlan = (CDispositionPlan) null;
        cagent.dialMask = info2.outgoingmask;
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigning Agent paramaters completed. ");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Object created successfully. ");
        this.mpCurrentAgent = cagent;
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Logout reasons load initialized.");
        this.mpLogoutReasons.Load();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Logout reasons load completed.");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not ready reasons load initialized.");
        this.mpNotReadyReasons.Load();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not ready reasons load Completed.");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Park reasons load initialized.");
        this.mpParkReasons.Load();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Park reasons load Completed.");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not Call rejection reasons load initialized.");
        this.mpCallRejectionReasons.Load();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not Call rejection reasons load completed.");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not External route load initialized.");
        this.mpExternalRoutes.Load();
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent Not External route load completed.");
        this.mpEventManager.RaiseEvent(AgentEventType.aeAUTHENTICATED, (object) null, false);
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Agent authentication Event Fired.");
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigned Agent Services load initialized.");
        this.mpAssignedServices.Load((CService) this.mpCurrentAgent);
        this.logfile.LogMessageToFile(" |INFO| CApp.Login() , Assigned Agent Services load completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Login() , Agent Login Failed " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Login), ex);
      }
    }

    public void UpdateWrapWarning()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.WrapWarning() , Update Agent Wrap Warning initialized.", 1);
        this.mpPortal.WSAgent.warning(this.mpCurrentAgent.AgentArg, new UDWarning()
        {
          warnType = 1
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.WrapWarning() , Update Agent Wrap Warning Completed.", 1);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.WrapWarning() , Update Agent Wrap Warning failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    public void SendDigit(string sKeyDigit)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.SendDigit() , Keypad degit send to Telephone Server started.");
        this.mpPortal.WSAgent.playDigits(this.mpCurrentAgent.AgentArg, new UDDigits()
        {
          callId = this.CurrentCall.callID,
          digits = sKeyDigit
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.SendDigit() , Keypad degit send to Telephone Server complete.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.SendDigit() , Keypad degit send to Telephone Server failed." + ex.Message.ToString() + ex.Source.ToString());
        throw new Exception(nameof (SendDigit), ex);
      }
    }

    public void UndoLogout()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.UndoLogout() , Undo Agent logout initialized.", 2);
        if (this.mpCurrentAgent.AgentIndex > 0)
          this.mpPortal.WSAgent.cancelRequestLogout(this.mpCurrentAgent.AgentArg);
        this.logfile.LogMessageToFile(" |INFO| CApp.UndoLogout() , Undo Agent logout completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.UndoLogout() , Undo Agent logout failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Undo Logout", ex);
      }
    }

    public void Logout(CLogoutReason pLogoutReason)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Logout() , Agent logout initialized.", 2);
        if (this.mpCurrentAgent.AgentIndex > 0)
        {
          if (pLogoutReason == null)
            throw new ArgumentNullException("LogoutReason", "You must specify a Logout Reason");
          this.mpPortal.WSAgent.requestLogout(this.mpCurrentAgent.AgentArg, new UDReason()
          {
            reasonId = pLogoutReason.Id
          });
        }
        if (this.mpCurrentAgent.AgentIndex == 0 || pLogoutReason.Id == -99)
          this.mpEventManager.RaiseEvent(AgentEventType.aeLOGOUT, (object) null);
        this.logfile.LogMessageToFile(" |INFO| CApp.Logout() , Agent logout completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Logout() , Agent logout failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Logout), ex);
      }
    }

    public void panicLogout()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.panicLogout() , Agent panic logout initialized.", 2);
        this.mpPortal.WSAgent.requestLogout(this.mpCurrentAgent.AgentArg, new UDReason()
        {
          reasonId = -99
        });
        this.mpEventManager.RaiseEvent(AgentEventType.aeLOGOUT, (object) null);
        this.logfile.LogMessageToFile(" |INFO| CApp.panicLogout() , Agent panic logout completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.panicLogout() , Agent panic logout failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Panic Logout", ex);
      }
    }

    public void Hangup(CCall pCall)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Hangup() , Agent Hangup Initialized.");
        if (pCall == null)
          throw new InvalidOperationException("Invalid request - Hangup. There's no current call to hang up.");
        if (!pCall.FirstPartyCall.CurrentState.EnableHangup)
          throw new InvalidOperationException("Invalid request - Hangup. Request not allowed in current state of current call.");
        this.mpPortal.WSAgent.hangup(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = pCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Hangup() , Agent Hangup completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Hangup() , Agent Hangup failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Hangup), ex);
      }
    }

    public void HangupConsultation()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.HangupConsultation() , Agent HangupConsultation Initialized.");
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - HangupConsultation. There is no current call.");
        CCallVoice ccallVoice = this.CurrentCall is CCallVoice ? (CCallVoice) this.CurrentCall : throw new InvalidOperationException("Invalid request - HangupConsultation. The current call does not support consultations.");
        if (ccallVoice.thirdPartyCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - HangupConsultation. There is no current consultation call.");
        if (!ccallVoice.thirdPartyCall.CurrentState.EnableHangup)
          throw new InvalidOperationException("Invalid request - HangupConsultation. Request not allowed in current state of consultation call.");
        this.mpPortal.WSAgent.hangup(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = ccallVoice.thirdPartyCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.HangupConsultation() , Agent HangupConsultation completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.HangupConsultation() , Agent HangupConsultation failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (HangupConsultation), ex);
      }
    }

    public void DisposeCall(CCall pCall, CDisposition pDisposition)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Agent DisposeCall Initialized.");
        if (pCall == null)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Invalid request - DisposeCall. You must specify the call to dispose.");
          throw new InvalidOperationException("Invalid request - DisposeCall. You must specify the call to dispose.");
        }
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Current Service Object is started ");
        CService cservice = new CService();
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Current Service Object is created successfully ");
        LogFile logfile1 = this.logfile;
        string[] strArray1 = new string[5]
        {
          " |INFO| CApp.DisposeCall() , Service ID : ",
          pCall.serviceID.ToString(),
          ", Call ID< ",
          null,
          null
        };
        int num = pCall.callID;
        strArray1[3] = num.ToString();
        strArray1[4] = ">";
        string message1 = string.Concat(strArray1);
        logfile1.LogMessageToFile(message1);
        if (pCall.serviceID > 0)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Started creating the current service object .");
          cservice = this.mpAssignedServices.GetByKey((object) pCall.serviceID);
          LogFile logfile2 = this.logfile;
          string[] strArray2 = new string[6]
          {
            " |INFO| Disposition Status : ",
            cservice.RequireDisposition.ToString(),
            ", Disposition Plan : ",
            cservice.DispositionPlan.ToString(),
            ", Disposition Plan Count : ",
            null
          };
          num = cservice.DispositionPlan.Dispositions.Count;
          strArray2[5] = num.ToString();
          string message2 = string.Concat(strArray2);
          logfile2.LogMessageToFile(message2);
        }
        if (cservice.RequireDisposition && cservice.DispositionPlan != null && cservice.DispositionPlan.Dispositions.Count > 0 && pDisposition != null)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Call Back Flag : " + pDisposition.isCallback.ToString());
          pCall.callbackRequested = pDisposition.isCallback;
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Exclusion Flag : " + pDisposition.isExclusion.ToString());
          pCall.exclusionRequested = pDisposition.isExclusion;
          if (pDisposition == null)
            throw new ArgumentNullException(nameof (pDisposition), "You must specify a disposition to dispose the current call.");
          if (!cservice.DispositionPlan.Dispositions.Contains((object) pDisposition.Id) && pDisposition.Id != -2)
            throw new ArgumentException("Invalid Disposition. You must specify a disposition from the disposition plan of the current call's service.");
          if (pDisposition.IsCallback & !pCall.CallbackRequested)
            throw new ArgumentException("Invalid Disposition. You must request a callback before disposing the current call with a callback disposition.");
          if (pDisposition.IsExclusion & !pCall.ExclusionRequested)
            throw new ArgumentException("Invalid Disposition. You must request an exclusion before disposing the current call with an exclusion disposition.");
        }
        else
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Assigning Default setup for Disposition ");
          pDisposition = new CDisposition(64, "[Default]", "", false, false, false);
        }
        UDCallInfoUserDefinedItemIn[] userDefinedItemInArray = new UDCallInfoUserDefinedItemIn[20];
        for (int index = 0; index < userDefinedItemInArray.Length; ++index)
        {
          userDefinedItemInArray[index] = new UDCallInfoUserDefinedItemIn();
          userDefinedItemInArray[index].key = pCall.userDefinedItems[index].key;
          userDefinedItemInArray[index].value = pCall.userDefinedItems[index].value;
        }
        UDDisposition disposition = new UDDisposition()
        {
          callId = pCall.CallID,
          IDisposition = pDisposition.Id,
          saleFlag = pDisposition.IsSale,
          callBackFlag = pCall.CallbackRequested,
          updatedCallInfoUserDefined = new UDCallInfoUserDefinedIn()
        };
        disposition.updatedCallInfoUserDefined.userDefinedItems = userDefinedItemInArray;
        this.mpPortal.WSAgent.callOutcome(this.mpCurrentAgent.AgentArg, disposition);
        this.mpCallManager.RemoveByKey(pCall.CallID);
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Agent DisposeCall completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.DisposeCall() , Agent DisposeCall failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    public void DisposeCall(CCall pCall, CDisposition pDisposition, string version)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Agent DisposeCall Initialized.");
        if (version != "6.6")
          pCall = this.CallManager[0];
        if (pCall == null)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Invalid request - DisposeCall. You must specify the call to dispose.");
          throw new InvalidOperationException("Invalid request - DisposeCall. You must specify the call to dispose.");
        }
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Current Service Object is started ");
        CService cservice = new CService();
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Current Service Object is created successfully ");
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Service ID : " + pCall.serviceID.ToString() + ", Call ID< " + pCall.callID.ToString() + ">");
        if (pCall.serviceID > 0)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Started creating the current service object .");
          cservice = this.mpAssignedServices.GetByKey((object) pCall.serviceID);
          this.logfile.LogMessageToFile(" |INFO| Disposition Status : " + cservice.RequireDisposition.ToString() + ", Disposition Plan : " + cservice.DispositionPlan.ToString() + ", Disposition Plan Count : " + cservice.DispositionPlan.Dispositions.Count.ToString());
        }
        if (cservice.RequireDisposition && cservice.DispositionPlan != null && cservice.DispositionPlan.Dispositions.Count > 0 && pDisposition != null)
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Call Back Flag : " + pDisposition.isCallback.ToString());
          pCall.callbackRequested = pDisposition.isCallback;
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Exclusion Flag : " + pDisposition.isExclusion.ToString());
          pCall.exclusionRequested = pDisposition.isExclusion;
          if (pDisposition == null)
            throw new ArgumentNullException(nameof (pDisposition), "You must specify a disposition to dispose the current call.");
          if (!cservice.DispositionPlan.Dispositions.Contains((object) pDisposition.Id))
            throw new ArgumentException("Invalid Disposition. You must specify a disposition from the disposition plan of the current call's service.");
          if (pDisposition.IsCallback & !pCall.CallbackRequested)
            throw new ArgumentException("Invalid Disposition. You must request a callback before disposing the current call with a callback disposition.");
          if (pDisposition.IsExclusion & !pCall.ExclusionRequested)
            throw new ArgumentException("Invalid Disposition. You must request an exclusion before disposing the current call with an exclusion disposition.");
        }
        else
        {
          this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Assigning Default setup for Disposition ");
          pDisposition = new CDisposition(64, "[Default]", "", false, false, false);
        }
        UDCallInfoUserDefinedItemIn[] userDefinedItemInArray = new UDCallInfoUserDefinedItemIn[20];
        for (int index = 0; index < userDefinedItemInArray.Length; ++index)
        {
          userDefinedItemInArray[index] = new UDCallInfoUserDefinedItemIn();
          userDefinedItemInArray[index].key = pCall.userDefinedItems[index].key;
          userDefinedItemInArray[index].value = pCall.userDefinedItems[index].value;
        }
        UDDisposition disposition = new UDDisposition()
        {
          callId = pCall.CallID,
          IDisposition = pDisposition.Id,
          saleFlag = pDisposition.IsSale,
          callBackFlag = pCall.CallbackRequested,
          updatedCallInfoUserDefined = new UDCallInfoUserDefinedIn()
        };
        disposition.updatedCallInfoUserDefined.userDefinedItems = userDefinedItemInArray;
        this.mpPortal.WSAgent.callOutcome(this.mpCurrentAgent.AgentArg, disposition);
        this.logfile.LogMessageToFile(" |INFO| CApp.DisposeCall() , Agent DisposeCall completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.DisposeCall() , Agent DisposeCall failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    public void ActivateCall(CCall pCall) => this.mpEventManager.ActivateCall(pCall);

    public void TakeCalls()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.TakeCalls() , Agent Taking Calls Initialized.");
        if (this.mpCurrentAgent.agentIndex != 0)
          throw new Exception("Unified IP Agent will shutdown due to the following reason(s) : - Session already exists");
        this.mpCurrentAgent.AgentInfoArg.ipAddress = DNSUtility.GetLocalIP();
        this.mpPortal.RegisterEx(this.mpCurrentAgent.AgentArg, this.mpCurrentAgent.AgentInfoArg, this.mpCurrentAgent.Multiline);
        this.logfile.LogMessageToFile(" |INFO| CApp.TakeCalls() , Agent Taking Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.TakeCalls() , Agent Taking Calls Failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Unified IP Agent will shutdown due to the following reason(s) : - Session already exists");
      }
    }

    public void Dial(string UserId)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Dial() , Agent Dial Calls Initialized.");
        if (UserId == null || UserId.Trim().Length == 0)
          throw new ArgumentException("You must specify a UserId", nameof (UserId));
        this.mpCallManager.PendingManualCall = (CCall) new CCallVoice();
        this.mpPortal.WSAgent.dial(this.mpCurrentAgent.AgentArg, new UDCall()
        {
          makeCallType = 1,
          userID = UserId
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Dial() , Agent Dial Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Dial() , Agent Dial Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Dial), ex);
      }
    }

    public void Dial(string PhoneNumber, int ServiceId, int ExternalRouteId)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Dial(3) , Agent Dial Calls Initialized.");
        if (PhoneNumber == null || PhoneNumber.Trim().Length == 0)
          throw new ArgumentException("You must specify a PhoneNumber", nameof (PhoneNumber));
        CCall ccall1 = (CCall) null;
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
          ccall2 = (CCall) new CCallVoice();
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
          callinfo.callID = this.CurrentCall.callID;
        this.mpPortal.WSAgent.dial(this.mpCurrentAgent.AgentArg, callinfo);
        this.logfile.LogMessageToFile(" |INFO| CApp.Dial(3) , Agent Dial Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Dial(3) , Agent Dial Calls failed. " + ex.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Dial), ex);
      }
    }

    public void Hold()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Hold() , Agent Hold Calls Initialized.");
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Hold. There's no current call to hold.");
        if (!(this.CurrentCall.FirstPartyCall.CurrentState is CStateActive))
          throw new InvalidOperationException("Invalid request - Hold. Request not allowed in current state of current call.");
        this.mpPortal.WSAgent.hold(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = this.CurrentCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Hold() , Agent Hold Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Hold() , Agent Hold Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Hold), ex);
      }
    }

    public void OtherCallOnHold()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.OtherCallOnHold() , Agent Hold Calls Initialized.");
        CCall ccall1 = (CCall) null;
        foreach (CCall ccall2 in (CList) this.mpCallManager)
        {
          if (ccall2.CallID != this.CurrentCall.CallID)
          {
            ccall1 = ccall2;
            break;
          }
        }
        if (ccall1 != null && ccall1.CurrentState.Description == "ACTIVE")
          this.mpPortal.WSAgent.hold(this.mpCurrentAgent.AgentArg, new UDParm()
          {
            callId = ccall1.CallID
          });
        this.logfile.LogMessageToFile(" |INFO| CApp.OtherCallOnHold() , Agent Hold Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.OtherCallOnHold() , Agent Hold Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Hold", ex);
      }
    }

    public void HoldConsultation()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.HoldConsultation() , Agent HoldConsultation Calls Initialized.");
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - HoldConsultation. There is no current call.");
        CCallVoice ccallVoice = this.CurrentCall is CCallVoice ? (CCallVoice) this.CurrentCall : throw new InvalidOperationException("Invalid request - HoldConsultation. The current call does not support consultations.");
        if (ccallVoice.thirdPartyCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - HoldConsultation. There is no current consultation call.");
        if (!(ccallVoice.thirdPartyCall.CurrentState is CStateActive))
          throw new InvalidOperationException("Invalid request - HoldConsultation. Request not allowed in current state of consultation call.");
        this.mpPortal.WSAgent.hold(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = ccallVoice.thirdPartyCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.HoldConsultation() , Agent HoldConsultation Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.HoldConsultation() , Agent HoldConsultation Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (HoldConsultation), ex);
      }
    }

    public void ReleaseHold()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.ReleaseHold() , Agent ReleaseHold Calls Initialized.");
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - ReleaseHold. There's no current call on which to release a hold.");
        if (!(this.CurrentCall.FirstPartyCall.CurrentState is CStateHeld))
          throw new InvalidOperationException("Invalid request - ReleaseHold. Request not allowed in current state of current call.");
        this.mpPortal.WSAgent.retrieveHold(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = this.CurrentCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.ReleaseHold() , Agent ReleaseHold Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.ReleaseHold() , Agent ReleaseHold Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (ReleaseHold), ex);
      }
    }

    public void ReleaseHoldOnConsultation()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.ReleaseHoldOnConsultation() , Agent ReleaseHoldOnConsultation Calls Initialized.");
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. There is no current call.");
        CCallVoice ccallVoice = this.CurrentCall is CCallVoice ? (CCallVoice) this.CurrentCall : throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. The current call does not support consultations.");
        if (ccallVoice.thirdPartyCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. There is no current consultation call.");
        if (!(ccallVoice.thirdPartyCall.CurrentState is CStateHeld))
          throw new InvalidOperationException("Invalid request - ReleaseHoldOnConsultation. Request not allowed in current state of consultation call.");
        this.mpPortal.WSAgent.retrieveHold(this.mpCurrentAgent.AgentArg, new UDParm()
        {
          callId = ccallVoice.thirdPartyCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.ReleaseHoldOnConsultation() , Agent ReleaseHoldOnConsultation Calls completed.");
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.ReleaseHoldOnConsultation() , Agent ReleaseHoldOnConsultation Calls failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (ReleaseHoldOnConsultation), ex);
      }
    }

    public void BecomeUnavailable(CListItem pNotReadyReason, bool Park)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.BecomeUnavailable() , Agent BecomeUnavailable Initialized.", 2);
        if (pNotReadyReason == null)
          throw new ArgumentNullException(nameof (pNotReadyReason), "You must specify a NotReady Reason");
        this.mpPortal.WSAgent.requestUnavailable(this.mpCurrentAgent.AgentArg, new UDReason()
        {
          reasonId = pNotReadyReason.Id,
          toParkState = Park
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.BecomeUnavailable() , Agent BecomeUnavailable completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.BecomeUnavailable() , Agent BecomeUnavailable failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (BecomeUnavailable), ex);
      }
    }

    public void BecomeUnavailablePark(CParkReason pParkReason)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.BecomeUnavailablePark() , Agent Park Initialized.", 2);
        if (pParkReason == null)
          throw new ArgumentNullException(nameof (pParkReason), "You must specify a NotReady Reason");
        this.mpPortal.WSAgent.requestUnavailable(this.mpCurrentAgent.AgentArg, new UDReason()
        {
          reasonId = pParkReason.Id,
          toParkState = true
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.BecomeUnavailablePark() , Agent Park completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.BecomeUnavailablePark() , Agent Park failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (BecomeUnavailablePark), ex);
      }
    }

    public void BecomeAvailable()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Becomeavailable() , Agent Becomeavailable Initialized.", 2);
        if (this.mpCurrentAgent.AgentArg == null)
          throw new ArgumentNullException(nameof (BecomeAvailable), "Agent details are not available");
        this.mpPortal.WSAgent.available(this.mpCurrentAgent.AgentArg);
        this.logfile.LogMessageToFile(" |INFO| CApp.Becomeavailable() , Agent Becomeavailable completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Becomeavailable() , Agent Becomeavailable failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Becomeavailable", ex);
      }
    }

    private void Consult(UDConsultIn consultParams)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(UDConsultIn) , Agent Consult Initialized.", 2);
        CCall currentCall = this.CurrentCall;
        UDCallInfoUserDefinedItemIn[] userDefinedItemInArray = new UDCallInfoUserDefinedItemIn[20];
        for (int index = 0; index < userDefinedItemInArray.Length; ++index)
        {
          userDefinedItemInArray[index] = new UDCallInfoUserDefinedItemIn();
          userDefinedItemInArray[index].key = currentCall.userDefinedItems[index].key;
          userDefinedItemInArray[index].value = currentCall.userDefinedItems[index].value;
        }
        consultParams.callID = currentCall.CallID;
        consultParams.userDefinedData = new UDCallInfoUserDefinedIn();
        consultParams.userDefinedData.userDefinedItems = userDefinedItemInArray;
        this.mpPortal.WSAgent.consult(this.mpCurrentAgent.AgentArg, consultParams);
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(UDConsultIn) , Agent Consult completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Consult(UDConsultIn) , Agent Consult failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Consult), ex);
      }
    }

    public void Consult(CUser user)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(CUser) , Agent Consult Initialized.", 2);
        if (user == null)
          throw new ArgumentException("You must specify a user.", nameof (user));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (!(this.CurrentCall is CCallVoice))
          throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");
        if (!this.CurrentCall.CurrentState.EnableConsult)
          throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");
        CCallVoice currentCall = (CCallVoice) this.CurrentCall;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationEntity = (object) user;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationPhoneNumber = "";
        this.mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) currentCall.ThirdPartyCall;
        this.Consult(new UDConsultIn()
        {
          consultType = 1,
          blindXferFlag = Convert.ToInt32(false),
          userID = user.Id
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(CUser) , Agent Consult completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Consult(CUser) , Agent Consult failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Consult(CUser)", ex);
      }
    }

    public void Consult(CSimpleService service)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(CSimpleService) , Agent Consult Initialized.", 2);
        if (service == null)
          throw new ArgumentException("You must specify a service.", nameof (service));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (!(this.CurrentCall is CCallVoice))
          throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");
        if (!this.CurrentCall.CurrentState.EnableConsult)
          throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");
        CCallVoice currentCall = (CCallVoice) this.CurrentCall;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationEntity = (object) service;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationPhoneNumber = "";
        this.mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) currentCall.ThirdPartyCall;
        this.Consult(new UDConsultIn()
        {
          consultType = 1,
          blindXferFlag = Convert.ToInt32(false),
          serviceID = service.ServiceId
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(CSimpleService) , Agent Consult completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Consult(CSimpleService) , Agent Consult failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Consult(CSimpleService)", ex);
      }
    }

    public void Consult(string phoneNumber, CExternalRoute externalRoute)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(externalRoute) , Agent Consult Initialized.", 2);
        if (phoneNumber == null)
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        if (phoneNumber.Trim() == "")
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Consult. There is no current call.");
        if (!(this.CurrentCall is CCallVoice))
          throw new InvalidOperationException("Invalid request - Consult. The current call does not support consultations.");
        if (!this.CurrentCall.CurrentState.EnableConsult)
          throw new InvalidOperationException("Invalid request - Consult. Request not allowed in current state of current call.");
        CCallVoice currentCall = (CCallVoice) this.CurrentCall;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationEntity = (object) externalRoute;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationPhoneNumber = phoneNumber;
        this.mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) currentCall.ThirdPartyCall;
        UDConsultIn consultParams = new UDConsultIn();
        consultParams.consultType = 2;
        consultParams.blindXferFlag = Convert.ToInt32(false);
        consultParams.phoneNumber = phoneNumber;
        if (externalRoute != null)
          consultParams.externalRouteID = externalRoute.Id;
        this.Consult(consultParams);
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(externalRoute) , Agent Consult completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Consult(externalRoute) , Agent Consult failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception("Consult(externalRoute)", ex);
      }
    }

    public void Consult(string phoneNumber)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(phoneNumber) , Agent Consult Initialized.", 2);
        if (phoneNumber.Trim().Length == 0)
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        this.Consult(phoneNumber, (CExternalRoute) null);
        this.logfile.LogMessageToFile(" |INFO| CApp.Consult(phoneNumber) , Agent Consult completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Consult(phoneNumber) , Agent Consult failed. " + ex.ToString() + ex.StackTrace.ToString());
        throw new Exception("Consult(phoneNumber)", ex);
      }
    }

    public void Transfer(CUser user)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(CUser) , Agent Transfer Initialized.", 2);
        if (user == null)
          throw new ArgumentException("You must specify a user.", nameof (user));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (!this.CurrentCall.CurrentState.EnableTransfer)
          throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");
        CCallVoice currentCall = (CCallVoice) this.CurrentCall;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationEntity = (object) user;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationPhoneNumber = "";
        this.mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) currentCall.ThirdPartyCall;
        UDConsultIn consultParams = new UDConsultIn();
        switch (this.CurrentCall.MediaType)
        {
          case AgentMediaType.amINBOUND_CHAT:
            consultParams.consultType = 3;
            break;
          case AgentMediaType.amINBOUND_AGD:
            consultParams.consultType = 4;
            break;
          default:
            consultParams.consultType = 1;
            break;
        }
        consultParams.blindXferFlag = Convert.ToInt32(true);
        consultParams.userID = user.Id;
        this.Consult(consultParams);
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(CUser) , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer(CUser) , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    public void Transfer(string phoneNumber)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(phoneNumber) , Agent Transfer Initialized.", 2);
        if (phoneNumber.Trim().Length == 0)
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        this.Transfer(phoneNumber, (CExternalRoute) null);
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(phoneNumber) , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer(phoneNumber) , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    public void Transfer(string phoneNumber, CExternalRoute externalRoute)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(externalRoute) , Agent Transfer Initialized.", 2);
        if (phoneNumber == null)
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        if (phoneNumber.Trim() == "")
          throw new ArgumentException("You must specify a phone number.", nameof (phoneNumber));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (!this.CurrentCall.CurrentState.EnableTransfer)
          throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");
        CCallVoice currentCall = (CCallVoice) this.CurrentCall;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationEntity = (object) externalRoute;
        ((C3WayCall3rdParty) currentCall.ThirdPartyCall).consultationPhoneNumber = phoneNumber;
        this.mpThreeWayCallManager.PendingConsultationCall = (C3WayCall3rdParty) currentCall.ThirdPartyCall;
        UDConsultIn consultParams = new UDConsultIn();
        consultParams.consultType = 2;
        consultParams.blindXferFlag = Convert.ToInt32(true);
        consultParams.phoneNumber = phoneNumber;
        if (externalRoute != null)
          consultParams.externalRouteID = externalRoute.Id;
        this.Consult(consultParams);
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(externalRoute) , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer(externalRoute) , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    private void Transfer(UDTransfer xferParams)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(xferParams) , Agent Transfer Initialized.", 2);
        CCall currentCall = this.CurrentCall;
        UDCallInfoUserDefinedItemIn[] userDefinedItemInArray = new UDCallInfoUserDefinedItemIn[20];
        for (int index = 0; index < userDefinedItemInArray.Length; ++index)
        {
          userDefinedItemInArray[index] = new UDCallInfoUserDefinedItemIn();
          userDefinedItemInArray[index].key = currentCall.userDefinedItems[index].key;
          userDefinedItemInArray[index].value = currentCall.userDefinedItems[index].value;
        }
        xferParams.originalCallID = this.CurrentCall.CallID;
        xferParams.callInfoUserDefined = new UDCallInfoUserDefinedIn();
        xferParams.callInfoUserDefined.userDefinedItems = userDefinedItemInArray;
        this.mpPortal.WSAgent.transfer(this.mpCurrentAgent.AgentArg, xferParams);
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(xferParams) , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer(xferParams) , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    public void Transfer(CSimpleService service)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(CSimpleService) , Agent Transfer Initialized.", 2);
        if (service == null)
          throw new ArgumentException("You must specify a service.", nameof (service));
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (!this.CurrentCall.CurrentState.EnableTransfer)
          throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");
        this.Transfer(new UDTransfer()
        {
          serviceID = service.ServiceId,
          transferType = 2
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer(CSimpleService) , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer(CSimpleService) , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    public void Transfer()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer() , Agent Transfer Initialized.", 2);
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current call.");
        CCallVoice ccallVoice = this.CurrentCall is CCallVoice ? (CCallVoice) this.CurrentCall : throw new InvalidOperationException("Invalid request - Transfer. There is no current consultation call.");
        if (ccallVoice.thirdPartyCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Transfer. There is no current consultation call.");
        if (!this.CurrentCall.CurrentState.EnableTransfer)
          throw new InvalidOperationException("Invalid request - Transfer. Request not allowed in current state of current call.");
        this.Transfer(new UDTransfer()
        {
          serviceID = ccallVoice.ServiceID,
          thirdParyCallID = ccallVoice.ThirdPartyCall.CallID,
          conferenceCallID = ccallVoice.ConferenceCall.CallID,
          transferType = 1
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Transfer() , Agent Transfer completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Transfer() , Agent Transfer failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Transfer), ex);
      }
    }

    public void Conference()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.Conference() , Agent Conference Initialized.", 2);
        if (this.CurrentCall == null)
          throw new InvalidOperationException("Invalid request - Conference. There is no current call.");
        if (this.CurrentCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Conference. There is no current call.");
        if (!(this.CurrentCall is CCallVoice))
          throw new InvalidOperationException("Invalid request - Conference. There is no current consultation call.");
        if (((CCallVoice) this.CurrentCall).thirdPartyCall.CallID == 0)
          throw new InvalidOperationException("Invalid request - Conference. There is no current consultation call.");
        if (!this.CurrentCall.CurrentState.EnableConference)
          throw new InvalidOperationException("Invalid request - Conference. Request not allowed in current state of current call.");
        this.mpPortal.WSAgent.conference(this.mpCurrentAgent.AgentArg, new UDConferenceIn()
        {
          callID = this.CurrentCall.CallID,
          consultCallID = ((CCallVoice) this.CurrentCall).ThirdPartyCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.Conference() , Agent Conference completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.Conference() , Agent Conference failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (Conference), ex);
      }
    }

    public void AcceptCall()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.AcceptCall() , Agent AcceptCall Initialized.", 2);
        this.mpPortal.WSAgent.answerCall(this.mpCurrentAgent.AgentArg, new UDAnswerCall()
        {
          result = Convert.ToInt32(false),
          agentIndex = this.mpCurrentAgent.AgentIndex,
          callID = this.mpCallManager.CurrentCall.CallID
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.AcceptCall() , Agent AcceptCall completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.AcceptCall() , Agent AcceptCall failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (AcceptCall), ex);
      }
    }

    public void RejectCall(CCallRejectionReason pRejectionReason)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.RejectCall(CCallRejectionReason) , Agent RejectCall Initialized.", 2);
        UDAnswerCall answer = new UDAnswerCall();
        answer.result = Convert.ToInt32(true);
        answer.agentIndex = this.mpCurrentAgent.AgentIndex;
        answer.callID = this.mpCallManager.CurrentCall.CallID;
        if (pRejectionReason != null)
          answer.rejectReason = pRejectionReason.Id;
        this.mpPortal.WSAgent.answerCall(this.mpCurrentAgent.AgentArg, answer);
        this.logfile.LogMessageToFile(" |INFO| CApp.RejectCall(CCallRejectionReason) , Agent RejectCall completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.RejectCall(CCallRejectionReason) , Agent RejectCall failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (RejectCall), ex);
      }
    }

    public void RejectCall()
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.RejectCall() , Agent RejectCall Initialized.", 2);
        this.RejectCall((CCallRejectionReason) null);
        this.logfile.LogMessageToFile(" |INFO| CApp.RejectCall() , Agent RejectCall completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.RejectCall() , Agent RejectCall failed. " + ex.ToString() + ex.StackTrace.ToString());
        throw new Exception(nameof (RejectCall), ex);
      }
    }

    public void ExcludeContact(UDAgent oUDAgent, UDExclude oUDExclude)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.ExcludeContact() , Agent ExcludeContact Initialized.", 2);
        this.Portal.WSAgent.excludeContact(oUDAgent, oUDExclude);
        this.logfile.LogMessageToFile(" |INFO| CApp.ExcludeContact() , Agent ExcludeContact completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.ExcludeContact() , Agent ExcludeContact failed. " + ex.Message.ToString() + ex.StackTrace.ToString());
        throw new InvalidOperationException(" |ERROR| Exclude contact - ExcludeContact() . Exclusion Failed, " + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    public CAgents GetAgents()
    {
      CAgents agents = new CAgents(this);
      agents.Load(this.CurrentService.serviceId);
      return agents;
    }

    public CSupervisors GetSupervisors()
    {
      CSupervisors supervisors = new CSupervisors(this);
      supervisors.Load(this.CurrentService.serviceId);
      return supervisors;
    }

    public void GetCDDDefinition(int DefID)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.GetCDDDefinition() , Get CDD Definition Process initialized.", 3);
        foreach (CallDataDefFields callDataDefFields in (CallDataDefFields[]) this.mpPortal.WSAgent.getInfo(this.mpCurrentAgent.AgentArg, new UDInfo()
        {
          listType = 113,
          callDataDefId = DefID
        }))
        {
          this.CurrentCall.UserDefinedItems[callDataDefFields.fieldorder - 1].key = callDataDefFields.label;
          this.CurrentCall.UserDefinedItems[callDataDefFields.fieldorder - 1].value = "";
        }
        this.logfile.LogMessageToFile(" |INFO| CApp.GetCDDDefinition() , Get CDD Definition Process completed.", 3);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.GetCDDDefinition() , Get CDD Definition Process failed. " + ex.Message.ToString() + ex.StackTrace.ToString(), 2);
      }
    }

    public CServices GetServices()
    {
      CServices services = new CServices(this);
      switch (this.CurrentService.ServiceType)
      {
        case ServiceType.CHAT:
        case ServiceType.AGD:
        case ServiceType.CTI:
          services.Load(this.CurrentService.ServiceType);
          break;
        default:
          services.Load();
          break;
      }
      return services;
    }

    public CServices GetAODServices()
    {
      CServices aodServices = new CServices(this);
      aodServices.Load(ServiceType.AOD);
      return aodServices;
    }

    public void SendScheduleCallBack(UDAgent oUDAgent, UDCallback oUDCallBack) => this.mpPortal.WSAgent.scheduleCallback(oUDAgent, oUDCallBack);

    public Externals[] GetExternalServices(UDAgent oUDAgent, UDInfo oInfo)
    {
      Externals[] info;
      try
      {
        info = (Externals[]) this.mpPortal.WSAgent.getInfo(oUDAgent, oInfo);
      }
      catch (Exception ex)
      {
        throw new Exception("GetExternalServices()", ex);
      }
      return info;
    }

    public void AddEditSpeedDial(UDAgent oUDAgent, UDExternalRouteIn oUDExternalRouteIn)
    {
      try
      {
        this.mpPortal.WSAgent.externalRoute(oUDAgent, oUDExternalRouteIn);
      }
      catch (Exception ex)
      {
        throw new Exception("AddEditSpeedDial()", ex);
      }
    }

    public void Recording(UDAgent oUDAgent, UDRecorderData oUDRecorderData)
    {
      try
      {
        this.mpPortal.WSAgent.record(oUDAgent, oUDRecorderData);
      }
      catch (Exception ex)
      {
        throw new Exception("StartRecording()", ex);
      }
    }

    public void SendChatMessage(CCallChat pCall, string sMessage)
    {
      if (pCall == null)
        throw new InvalidOperationException("Invalid request - SendChatMessage. You must specify a call.");
      this.mpPortal.WSAgent.chatSendMessage(this.mpCurrentAgent.AgentArg, new UDChatMessage()
      {
        callId = pCall.CallID,
        text = sMessage
      });
    }

    public void SendChatURL(CCallChat pCall, string sURL)
    {
      if (pCall == null)
        throw new InvalidOperationException("Invalid request - SendChatURL. You must specify a call.");
      if (!sURL.StartsWith("http", StringComparison.OrdinalIgnoreCase))
        sURL = "http://" + sURL;
      this.mpPortal.WSAgent.chatSendURL(this.mpCurrentAgent.AgentArg, new UDChatURL()
      {
        callId = pCall.CallID,
        url = sURL
      });
    }

    internal void ConnectToChatServer(CCallChat pCall)
    {
      try
      {
        this.mpPortal.WSAgent.chatConnect(this.mpCurrentAgent.AgentArg, new UDChatConnect()
        {
          callId = pCall.CallID,
          serviceId = pCall.ServiceID,
          chatserverIP = pCall.ChatServerIP,
          chatserverCSLPort = pCall.ChatServerPort,
          entityType = 1,
          firstName = this.mpCurrentAgent.FirstName,
          lastName = this.mpCurrentAgent.LastName
        });
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.StackTrace);
      }
    }

    internal bool EnableKeepAlives
    {
      set
      {
        if (value && this.mpKeepAliveTimer == null)
        {
          this.mpKeepAliveTimer = new Timer(new TimerCallback(this.SendKeepAlive), (object) this, 60000, 60000);
        }
        else
        {
          if (value || this.mpKeepAliveTimer == null)
            return;
          this.mpKeepAliveTimer.Dispose();
          this.mpKeepAliveTimer = (Timer) null;
        }
      }
    }

    private void SendKeepAlive(object state)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.SendKeepAlive() , Agent SendKeepAlive initialized.", 2);
        this.mpPortal.WSAgent.keepAlive(this.CurrentAgent.AgentArg);
        this.logfile.LogMessageToFile(" |INFO| CApp.SendKeepAlive() , Agent SendKeepAlive completed.", 2);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.SendKeepAlive() ,Agent SendKeepAlive failed. " + ex.Message.ToString() + ex.StackTrace.ToString(), 2);
        Console.WriteLine(ex.StackTrace);
      }
    }

    internal void OnStateChange(CStateChangeArgs pArgs)
    {
      if (this.StateChange == null)
        return;
      this.StateChange((object) this, pArgs);
    }

    internal void OnUnfocusedStateChange(CUnfocusedStateChangeArgs pArgs)
    {
      if (this.UnfocusedStateChange == null)
        return;
      this.UnfocusedStateChange((object) this, pArgs);
    }

    internal void OnCallStateChange(CCallStateChangeArgs pArgs)
    {
      if (this.CallStateChange == null)
        return;
      this.CallStateChange((object) this, pArgs);
    }

    internal void OnUnfocusedCallStateChange(CUnfocusedCallStateChangeArgs pArgs)
    {
      if (this.UnfocusedCallStateChange == null)
        return;
      this.UnfocusedCallStateChange((object) this, pArgs);
    }

    internal void OnPasscode(CPasscodeArgs pArgs)
    {
      if (this.Passcode == null)
        return;
      this.Passcode((object) this, pArgs);
    }

    internal void OnLogoutPending()
    {
      if (this.LogoutPending == null)
        return;
      this.LogoutPending((object) this);
    }

    internal void OnScreenpop(CScreenpopArgs pArgs)
    {
      if (this.Screenpop == null)
        return;
      this.Screenpop((object) this, pArgs);
    }

    internal void OnCallActivated(CCallActivatedArgs pArgs)
    {
      if (this.CallActivated == null)
        return;
      this.CallActivated((object) this, pArgs);
    }

    internal void OnPhoneStatus(CPhoneStatusArgs pArgs)
    {
      if (this.PhoneStatus == null)
        return;
      this.PhoneStatus((object) this, pArgs);
    }

    internal void OnError(CErrorArgs pArgs)
    {
      if (this.Error == null)
        return;
      this.Error((object) this, pArgs);
    }

    internal void OnLoggedIn()
    {
      if (this.LoggedIn == null)
        return;
      this.LoggedIn((object) this);
    }

    internal void OnChatEntityAdded(CChatEntityArgs pArgs)
    {
      if (this.ChatEntityAdded == null)
        return;
      this.ChatEntityAdded((object) this, pArgs);
    }

    internal void OnChatEntityRemoved(CChatEntityArgs pArgs)
    {
      if (this.ChatEntityRemoved == null)
        return;
      this.ChatEntityRemoved((object) this, pArgs);
    }

    internal void OnChatURL(CChatURLArgs pArgs)
    {
      if (this.ChatURL == null)
        return;
      this.ChatURL((object) this, pArgs);
    }

    internal void OnChatMessage(CChatMessageArgs pArgs)
    {
      if (this.ChatMessage == null)
        return;
      this.ChatMessage((object) this, pArgs);
    }

    internal bool ServiceExists(int ServiceId)
    {
      try
      {
        this.logfile.LogMessageToFile(" |INFO| CApp.ServiceExists() , Agent ServiceExists initialized.", 3);
        GetIdDesc info = (GetIdDesc) this.mpPortal.WSAgent.getInfo(this.mpCurrentAgent.AgentArg, new UDInfo()
        {
          listType = 122,
          serviceId = ServiceId
        });
        this.logfile.LogMessageToFile(" |INFO| CApp.ServiceExists() , Agent ServiceExists completed.", 3);
        return Convert.ToBoolean(info.id);
      }
      catch (Exception ex)
      {
        this.logfile.LogMessageToFile(" |ERROR| CApp.ServiceExists() , Agent ServiceExists failed. " + ex.Message.ToString() + ex.StackTrace.ToString(), 2);
        return false;
      }
    }
  }
}
