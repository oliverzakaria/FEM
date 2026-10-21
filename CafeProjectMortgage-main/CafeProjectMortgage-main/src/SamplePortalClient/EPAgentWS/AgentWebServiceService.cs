// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.AgentWebServiceService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.Properties;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace SamplePortalClient.EPAgentWS
{
  [GeneratedCode("System.Web.Services", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "ConcertoAgentPortalSoapBinding", Namespace = "http://AgentService.UD.concerto.com")]
  [SoapInclude(typeof (Vector))]
  [SoapInclude(typeof (ConcertoFault))]
  [SoapInclude(typeof (TimeZone))]
  [SoapInclude(typeof (UDProperty))]
  public class AgentWebServiceService : SoapHttpClientProtocol
  {
    private SendOrPostCallback registerOperationCompleted;
    private SendOrPostCallback updateOperationCompleted;
    private SendOrPostCallback getStateOperationCompleted;
    private SendOrPostCallback availableOperationCompleted;
    private SendOrPostCallback transferOperationCompleted;
    private SendOrPostCallback monitorOperationCompleted;
    private SendOrPostCallback warningOperationCompleted;
    private SendOrPostCallback authenticateOperationCompleted;
    private SendOrPostCallback getTimeZoneOperationCompleted;
    private SendOrPostCallback getInfoOperationCompleted;
    private SendOrPostCallback retrieveHoldOperationCompleted;
    private SendOrPostCallback updateVMNOperationCompleted;
    private SendOrPostCallback updateNPOperationCompleted;
    private SendOrPostCallback unRegisterOperationCompleted;
    private SendOrPostCallback requestLogoutOperationCompleted;
    private SendOrPostCallback scheduleCallbackOperationCompleted;
    private SendOrPostCallback consultOperationCompleted;
    private SendOrPostCallback conferenceOperationCompleted;
    private SendOrPostCallback dialOperationCompleted;
    private SendOrPostCallback holdOperationCompleted;
    private SendOrPostCallback playDigitsOperationCompleted;
    private SendOrPostCallback answerCallOperationCompleted;
    private SendOrPostCallback externalRouteOperationCompleted;
    private SendOrPostCallback recordOperationCompleted;
    private SendOrPostCallback forwardEmailOperationCompleted;
    private SendOrPostCallback focusOperationCompleted;
    private SendOrPostCallback getAgentStateOperationCompleted;
    private SendOrPostCallback hangupOperationCompleted;
    private SendOrPostCallback recordScreenOperationCompleted;
    private SendOrPostCallback registerExOperationCompleted;
    private SendOrPostCallback excludeContactOperationCompleted;
    private SendOrPostCallback getRemoteInfoOperationCompleted;
    private SendOrPostCallback monitorScreenOperationCompleted;
    private SendOrPostCallback callOutcomeOperationCompleted;
    private SendOrPostCallback beginKWSessionOperationCompleted;
    private SendOrPostCallback chatSendMessageOperationCompleted;
    private SendOrPostCallback chatConnectOperationCompleted;
    private SendOrPostCallback chatSendURLOperationCompleted;
    private SendOrPostCallback emailNotifyOperationCompleted;
    private SendOrPostCallback getExpertsOperationCompleted;
    private SendOrPostCallback chatsvrSendURLOperationCompleted;
    private SendOrPostCallback endKWSessionOperationCompleted;
    private SendOrPostCallback forwardEmailSentOperationCompleted;
    private SendOrPostCallback keepAliveOperationCompleted;
    private SendOrPostCallback recordingManagementOperationCompleted;
    private SendOrPostCallback chatsvrEntityRemovedOperationCompleted;
    private SendOrPostCallback cancelRequestLogoutOperationCompleted;
    private SendOrPostCallback cancelRequestUnavailableOperationCompleted;
    private SendOrPostCallback chatsvrDialRequestOperationCompleted;
    private SendOrPostCallback initiateKWVoiceConsultOperationCompleted;
    private SendOrPostCallback refreshPersonalGreetingsOperationCompleted;
    private SendOrPostCallback chatsvrSendMessageOperationCompleted;
    private SendOrPostCallback initiateKWVoiceDialOperationCompleted;
    private SendOrPostCallback requestAgentStatsOperationCompleted;
    private SendOrPostCallback requestEmailReviewOperationCompleted;
    private SendOrPostCallback requestEmailSelfServiceOperationCompleted;
    private SendOrPostCallback requestUnavailableOperationCompleted;
    private SendOrPostCallback chatsvrEntityAddedOperationCompleted;
    private SendOrPostCallback chatsvrSendListOfChatEntitesOperationCompleted;
    private SendOrPostCallback suspendMultiAppearancesOperationCompleted;
    private SendOrPostCallback resumeMultiAppearancesOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public AgentWebServiceService()
    {
      this.Url = Settings.Default.SamplePortalClient_EPAgentWS_AgentWebServiceService;
      if (this.IsLocalFileSystemWebService(this.Url))
      {
        this.UseDefaultCredentials = true;
        this.useDefaultCredentialsSetExplicitly = false;
      }
      else
        this.useDefaultCredentialsSetExplicitly = true;
    }

    public new string Url
    {
      get => base.Url;
      set
      {
        if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
          base.UseDefaultCredentials = false;
        base.Url = value;
      }
    }

    public new bool UseDefaultCredentials
    {
      get => base.UseDefaultCredentials;
      set
      {
        base.UseDefaultCredentials = value;
        this.useDefaultCredentialsSetExplicitly = true;
      }
    }

    public event registerCompletedEventHandler registerCompleted;

    public event updateCompletedEventHandler updateCompleted;

    public event getStateCompletedEventHandler getStateCompleted;

    public event availableCompletedEventHandler availableCompleted;

    public event transferCompletedEventHandler transferCompleted;

    public event monitorCompletedEventHandler monitorCompleted;

    public event warningCompletedEventHandler warningCompleted;

    public event authenticateCompletedEventHandler authenticateCompleted;

    public event getTimeZoneCompletedEventHandler getTimeZoneCompleted;

    public event getInfoCompletedEventHandler getInfoCompleted;

    public event retrieveHoldCompletedEventHandler retrieveHoldCompleted;

    public event updateVMNCompletedEventHandler updateVMNCompleted;

    public event updateNPCompletedEventHandler updateNPCompleted;

    public event unRegisterCompletedEventHandler unRegisterCompleted;

    public event requestLogoutCompletedEventHandler requestLogoutCompleted;

    public event scheduleCallbackCompletedEventHandler scheduleCallbackCompleted;

    public event consultCompletedEventHandler consultCompleted;

    public event conferenceCompletedEventHandler conferenceCompleted;

    public event dialCompletedEventHandler dialCompleted;

    public event holdCompletedEventHandler holdCompleted;

    public event playDigitsCompletedEventHandler playDigitsCompleted;

    public event answerCallCompletedEventHandler answerCallCompleted;

    public event externalRouteCompletedEventHandler externalRouteCompleted;

    public event recordCompletedEventHandler recordCompleted;

    public event forwardEmailCompletedEventHandler forwardEmailCompleted;

    public event focusCompletedEventHandler focusCompleted;

    public event getAgentStateCompletedEventHandler getAgentStateCompleted;

    public event hangupCompletedEventHandler hangupCompleted;

    public event recordScreenCompletedEventHandler recordScreenCompleted;

    public event registerExCompletedEventHandler registerExCompleted;

    public event excludeContactCompletedEventHandler excludeContactCompleted;

    public event getRemoteInfoCompletedEventHandler getRemoteInfoCompleted;

    public event monitorScreenCompletedEventHandler monitorScreenCompleted;

    public event callOutcomeCompletedEventHandler callOutcomeCompleted;

    public event beginKWSessionCompletedEventHandler beginKWSessionCompleted;

    public event chatSendMessageCompletedEventHandler chatSendMessageCompleted;

    public event chatConnectCompletedEventHandler chatConnectCompleted;

    public event chatSendURLCompletedEventHandler chatSendURLCompleted;

    public event emailNotifyCompletedEventHandler emailNotifyCompleted;

    public event getExpertsCompletedEventHandler getExpertsCompleted;

    public event chatsvrSendURLCompletedEventHandler chatsvrSendURLCompleted;

    public event endKWSessionCompletedEventHandler endKWSessionCompleted;

    public event forwardEmailSentCompletedEventHandler forwardEmailSentCompleted;

    public event keepAliveCompletedEventHandler keepAliveCompleted;

    public event recordingManagementCompletedEventHandler recordingManagementCompleted;

    public event chatsvrEntityRemovedCompletedEventHandler chatsvrEntityRemovedCompleted;

    public event cancelRequestLogoutCompletedEventHandler cancelRequestLogoutCompleted;

    public event cancelRequestUnavailableCompletedEventHandler cancelRequestUnavailableCompleted;

    public event chatsvrDialRequestCompletedEventHandler chatsvrDialRequestCompleted;

    public event initiateKWVoiceConsultCompletedEventHandler initiateKWVoiceConsultCompleted;

    public event refreshPersonalGreetingsCompletedEventHandler refreshPersonalGreetingsCompleted;

    public event chatsvrSendMessageCompletedEventHandler chatsvrSendMessageCompleted;

    public event initiateKWVoiceDialCompletedEventHandler initiateKWVoiceDialCompleted;

    public event requestAgentStatsCompletedEventHandler requestAgentStatsCompleted;

    public event requestEmailReviewCompletedEventHandler requestEmailReviewCompleted;

    public event requestEmailSelfServiceCompletedEventHandler requestEmailSelfServiceCompleted;

    public event requestUnavailableCompletedEventHandler requestUnavailableCompleted;

    public event chatsvrEntityAddedCompletedEventHandler chatsvrEntityAddedCompleted;

    public event chatsvrSendListOfChatEntitesCompletedEventHandler chatsvrSendListOfChatEntitesCompleted;

    public event suspendMultiAppearancesCompletedEventHandler suspendMultiAppearancesCompleted;

    public event resumeMultiAppearancesCompletedEventHandler resumeMultiAppearancesCompleted;

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void register(UDAgent agent, UDAgentInfo adata) => this.Invoke(nameof (register), new object[2]
    {
      (object) agent,
      (object) adata
    });

    public IAsyncResult Beginregister(
      UDAgent agent,
      UDAgentInfo adata,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("register", new object[2]
      {
        (object) agent,
        (object) adata
      }, callback, asyncState);
    }

    public void Endregister(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void registerAsync(UDAgent agent, UDAgentInfo adata) => this.registerAsync(agent, adata, (object) null);

    public void registerAsync(UDAgent agent, UDAgentInfo adata, object userState)
    {
      if (this.registerOperationCompleted == null)
        this.registerOperationCompleted = new SendOrPostCallback(this.OnregisterOperationCompleted);
      this.InvokeAsync("register", new object[2]
      {
        (object) agent,
        (object) adata
      }, this.registerOperationCompleted, userState);
    }

    private void OnregisterOperationCompleted(object arg)
    {
      if (this.registerCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.registerCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void update(UDAgent agent, UDUpdate data) => this.Invoke(nameof (update), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult Beginupdate(
      UDAgent agent,
      UDUpdate data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("update", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void Endupdate(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void updateAsync(UDAgent agent, UDUpdate data) => this.updateAsync(agent, data, (object) null);

    public void updateAsync(UDAgent agent, UDUpdate data, object userState)
    {
      if (this.updateOperationCompleted == null)
        this.updateOperationCompleted = new SendOrPostCallback(this.OnupdateOperationCompleted);
      this.InvokeAsync("update", new object[2]
      {
        (object) agent,
        (object) data
      }, this.updateOperationCompleted, userState);
    }

    private void OnupdateOperationCompleted(object arg)
    {
      if (this.updateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.updateCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getStateReturn")]
    public object getState(UDAgent agent, UDStateInput sdata) => this.Invoke(nameof (getState), new object[2]
    {
      (object) agent,
      (object) sdata
    })[0];

    public IAsyncResult BegingetState(
      UDAgent agent,
      UDStateInput sdata,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getState", new object[2]
      {
        (object) agent,
        (object) sdata
      }, callback, asyncState);
    }

    public object EndgetState(IAsyncResult asyncResult) => this.EndInvoke(asyncResult)[0];

    public void getStateAsync(UDAgent agent, UDStateInput sdata) => this.getStateAsync(agent, sdata, (object) null);

    public void getStateAsync(UDAgent agent, UDStateInput sdata, object userState)
    {
      if (this.getStateOperationCompleted == null)
        this.getStateOperationCompleted = new SendOrPostCallback(this.OngetStateOperationCompleted);
      this.InvokeAsync("getState", new object[2]
      {
        (object) agent,
        (object) sdata
      }, this.getStateOperationCompleted, userState);
    }

    private void OngetStateOperationCompleted(object arg)
    {
      if (this.getStateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getStateCompleted((object) this, new getStateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void available(UDAgent agent) => this.Invoke(nameof (available), new object[1]
    {
      (object) agent
    });

    public IAsyncResult Beginavailable(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("available", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void Endavailable(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void availableAsync(UDAgent agent) => this.availableAsync(agent, (object) null);

    public void availableAsync(UDAgent agent, object userState)
    {
      if (this.availableOperationCompleted == null)
        this.availableOperationCompleted = new SendOrPostCallback(this.OnavailableOperationCompleted);
      this.InvokeAsync("available", new object[1]
      {
        (object) agent
      }, this.availableOperationCompleted, userState);
    }

    private void OnavailableOperationCompleted(object arg)
    {
      if (this.availableCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.availableCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void transfer(UDAgent agent, UDTransfer trans) => this.Invoke(nameof (transfer), new object[2]
    {
      (object) agent,
      (object) trans
    });

    public IAsyncResult Begintransfer(
      UDAgent agent,
      UDTransfer trans,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("transfer", new object[2]
      {
        (object) agent,
        (object) trans
      }, callback, asyncState);
    }

    public void Endtransfer(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void transferAsync(UDAgent agent, UDTransfer trans) => this.transferAsync(agent, trans, (object) null);

    public void transferAsync(UDAgent agent, UDTransfer trans, object userState)
    {
      if (this.transferOperationCompleted == null)
        this.transferOperationCompleted = new SendOrPostCallback(this.OntransferOperationCompleted);
      this.InvokeAsync("transfer", new object[2]
      {
        (object) agent,
        (object) trans
      }, this.transferOperationCompleted, userState);
    }

    private void OntransferOperationCompleted(object arg)
    {
      if (this.transferCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.transferCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void monitor(UDAgent agent, UDMonitor minfo) => this.Invoke(nameof (monitor), new object[2]
    {
      (object) agent,
      (object) minfo
    });

    public IAsyncResult Beginmonitor(
      UDAgent agent,
      UDMonitor minfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("monitor", new object[2]
      {
        (object) agent,
        (object) minfo
      }, callback, asyncState);
    }

    public void Endmonitor(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void monitorAsync(UDAgent agent, UDMonitor minfo) => this.monitorAsync(agent, minfo, (object) null);

    public void monitorAsync(UDAgent agent, UDMonitor minfo, object userState)
    {
      if (this.monitorOperationCompleted == null)
        this.monitorOperationCompleted = new SendOrPostCallback(this.OnmonitorOperationCompleted);
      this.InvokeAsync("monitor", new object[2]
      {
        (object) agent,
        (object) minfo
      }, this.monitorOperationCompleted, userState);
    }

    private void OnmonitorOperationCompleted(object arg)
    {
      if (this.monitorCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.monitorCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void warning(UDAgent agent, UDWarning warn) => this.Invoke(nameof (warning), new object[2]
    {
      (object) agent,
      (object) warn
    });

    public IAsyncResult Beginwarning(
      UDAgent agent,
      UDWarning warn,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("warning", new object[2]
      {
        (object) agent,
        (object) warn
      }, callback, asyncState);
    }

    public void Endwarning(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void warningAsync(UDAgent agent, UDWarning warn) => this.warningAsync(agent, warn, (object) null);

    public void warningAsync(UDAgent agent, UDWarning warn, object userState)
    {
      if (this.warningOperationCompleted == null)
        this.warningOperationCompleted = new SendOrPostCallback(this.OnwarningOperationCompleted);
      this.InvokeAsync("warning", new object[2]
      {
        (object) agent,
        (object) warn
      }, this.warningOperationCompleted, userState);
    }

    private void OnwarningOperationCompleted(object arg)
    {
      if (this.warningCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.warningCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void authenticate(UDAgent agent, UDAgentInfo ainfo) => this.Invoke(nameof (authenticate), new object[2]
    {
      (object) agent,
      (object) ainfo
    });

    public IAsyncResult Beginauthenticate(
      UDAgent agent,
      UDAgentInfo ainfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("authenticate", new object[2]
      {
        (object) agent,
        (object) ainfo
      }, callback, asyncState);
    }

    public void Endauthenticate(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void authenticateAsync(UDAgent agent, UDAgentInfo ainfo) => this.authenticateAsync(agent, ainfo, (object) null);

    public void authenticateAsync(UDAgent agent, UDAgentInfo ainfo, object userState)
    {
      if (this.authenticateOperationCompleted == null)
        this.authenticateOperationCompleted = new SendOrPostCallback(this.OnauthenticateOperationCompleted);
      this.InvokeAsync("authenticate", new object[2]
      {
        (object) agent,
        (object) ainfo
      }, this.authenticateOperationCompleted, userState);
    }

    private void OnauthenticateOperationCompleted(object arg)
    {
      if (this.authenticateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.authenticateCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getTimeZoneReturn")]
    public TimeZone[] getTimeZone() => (TimeZone[]) this.Invoke(nameof (getTimeZone), new object[0])[0];

    public IAsyncResult BegingetTimeZone(AsyncCallback callback, object asyncState) => this.BeginInvoke("getTimeZone", new object[0], callback, asyncState);

    public TimeZone[] EndgetTimeZone(IAsyncResult asyncResult) => (TimeZone[]) this.EndInvoke(asyncResult)[0];

    public void getTimeZoneAsync() => this.getTimeZoneAsync((object) null);

    public void getTimeZoneAsync(object userState)
    {
      if (this.getTimeZoneOperationCompleted == null)
        this.getTimeZoneOperationCompleted = new SendOrPostCallback(this.OngetTimeZoneOperationCompleted);
      this.InvokeAsync("getTimeZone", new object[0], this.getTimeZoneOperationCompleted, userState);
    }

    private void OngetTimeZoneOperationCompleted(object arg)
    {
      if (this.getTimeZoneCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getTimeZoneCompleted((object) this, new getTimeZoneCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getInfoReturn")]
    public object getInfo(UDAgent agent, UDInfo info) => this.Invoke(nameof (getInfo), new object[2]
    {
      (object) agent,
      (object) info
    })[0];

    public IAsyncResult BegingetInfo(
      UDAgent agent,
      UDInfo info,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getInfo", new object[2]
      {
        (object) agent,
        (object) info
      }, callback, asyncState);
    }

    public object EndgetInfo(IAsyncResult asyncResult) => this.EndInvoke(asyncResult)[0];

    public void getInfoAsync(UDAgent agent, UDInfo info) => this.getInfoAsync(agent, info, (object) null);

    public void getInfoAsync(UDAgent agent, UDInfo info, object userState)
    {
      if (this.getInfoOperationCompleted == null)
        this.getInfoOperationCompleted = new SendOrPostCallback(this.OngetInfoOperationCompleted);
      this.InvokeAsync("getInfo", new object[2]
      {
        (object) agent,
        (object) info
      }, this.getInfoOperationCompleted, userState);
    }

    private void OngetInfoOperationCompleted(object arg)
    {
      if (this.getInfoCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getInfoCompleted((object) this, new getInfoCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void retrieveHold(UDAgent agent, UDParm parm) => this.Invoke(nameof (retrieveHold), new object[2]
    {
      (object) agent,
      (object) parm
    });

    public IAsyncResult BeginretrieveHold(
      UDAgent agent,
      UDParm parm,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("retrieveHold", new object[2]
      {
        (object) agent,
        (object) parm
      }, callback, asyncState);
    }

    public void EndretrieveHold(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void retrieveHoldAsync(UDAgent agent, UDParm parm) => this.retrieveHoldAsync(agent, parm, (object) null);

    public void retrieveHoldAsync(UDAgent agent, UDParm parm, object userState)
    {
      if (this.retrieveHoldOperationCompleted == null)
        this.retrieveHoldOperationCompleted = new SendOrPostCallback(this.OnretrieveHoldOperationCompleted);
      this.InvokeAsync("retrieveHold", new object[2]
      {
        (object) agent,
        (object) parm
      }, this.retrieveHoldOperationCompleted, userState);
    }

    private void OnretrieveHoldOperationCompleted(object arg)
    {
      if (this.retrieveHoldCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.retrieveHoldCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void updateVMN(UDAgent agent, UDUpdateRequest data) => this.Invoke(nameof (updateVMN), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult BeginupdateVMN(
      UDAgent agent,
      UDUpdateRequest data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("updateVMN", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void EndupdateVMN(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void updateVMNAsync(UDAgent agent, UDUpdateRequest data) => this.updateVMNAsync(agent, data, (object) null);

    public void updateVMNAsync(UDAgent agent, UDUpdateRequest data, object userState)
    {
      if (this.updateVMNOperationCompleted == null)
        this.updateVMNOperationCompleted = new SendOrPostCallback(this.OnupdateVMNOperationCompleted);
      this.InvokeAsync("updateVMN", new object[2]
      {
        (object) agent,
        (object) data
      }, this.updateVMNOperationCompleted, userState);
    }

    private void OnupdateVMNOperationCompleted(object arg)
    {
      if (this.updateVMNCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.updateVMNCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void updateNP(UDAgent agent, UDUpdateRequest data) => this.Invoke(nameof (updateNP), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult BeginupdateNP(
      UDAgent agent,
      UDUpdateRequest data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("updateNP", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void EndupdateNP(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void updateNPAsync(UDAgent agent, UDUpdateRequest data) => this.updateNPAsync(agent, data, (object) null);

    public void updateNPAsync(UDAgent agent, UDUpdateRequest data, object userState)
    {
      if (this.updateNPOperationCompleted == null)
        this.updateNPOperationCompleted = new SendOrPostCallback(this.OnupdateNPOperationCompleted);
      this.InvokeAsync("updateNP", new object[2]
      {
        (object) agent,
        (object) data
      }, this.updateNPOperationCompleted, userState);
    }

    private void OnupdateNPOperationCompleted(object arg)
    {
      if (this.updateNPCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.updateNPCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void unRegister(UDAgent agent) => this.Invoke(nameof (unRegister), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BeginunRegister(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("unRegister", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndunRegister(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void unRegisterAsync(UDAgent agent) => this.unRegisterAsync(agent, (object) null);

    public void unRegisterAsync(UDAgent agent, object userState)
    {
      if (this.unRegisterOperationCompleted == null)
        this.unRegisterOperationCompleted = new SendOrPostCallback(this.OnunRegisterOperationCompleted);
      this.InvokeAsync("unRegister", new object[1]
      {
        (object) agent
      }, this.unRegisterOperationCompleted, userState);
    }

    private void OnunRegisterOperationCompleted(object arg)
    {
      if (this.unRegisterCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.unRegisterCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void requestLogout(UDAgent agent, UDReason reason) => this.Invoke(nameof (requestLogout), new object[2]
    {
      (object) agent,
      (object) reason
    });

    public IAsyncResult BeginrequestLogout(
      UDAgent agent,
      UDReason reason,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("requestLogout", new object[2]
      {
        (object) agent,
        (object) reason
      }, callback, asyncState);
    }

    public void EndrequestLogout(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void requestLogoutAsync(UDAgent agent, UDReason reason) => this.requestLogoutAsync(agent, reason, (object) null);

    public void requestLogoutAsync(UDAgent agent, UDReason reason, object userState)
    {
      if (this.requestLogoutOperationCompleted == null)
        this.requestLogoutOperationCompleted = new SendOrPostCallback(this.OnrequestLogoutOperationCompleted);
      this.InvokeAsync("requestLogout", new object[2]
      {
        (object) agent,
        (object) reason
      }, this.requestLogoutOperationCompleted, userState);
    }

    private void OnrequestLogoutOperationCompleted(object arg)
    {
      if (this.requestLogoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.requestLogoutCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void scheduleCallback(UDAgent agent, UDCallback data) => this.Invoke(nameof (scheduleCallback), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult BeginscheduleCallback(
      UDAgent agent,
      UDCallback data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("scheduleCallback", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void EndscheduleCallback(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void scheduleCallbackAsync(UDAgent agent, UDCallback data) => this.scheduleCallbackAsync(agent, data, (object) null);

    public void scheduleCallbackAsync(UDAgent agent, UDCallback data, object userState)
    {
      if (this.scheduleCallbackOperationCompleted == null)
        this.scheduleCallbackOperationCompleted = new SendOrPostCallback(this.OnscheduleCallbackOperationCompleted);
      this.InvokeAsync("scheduleCallback", new object[2]
      {
        (object) agent,
        (object) data
      }, this.scheduleCallbackOperationCompleted, userState);
    }

    private void OnscheduleCallbackOperationCompleted(object arg)
    {
      if (this.scheduleCallbackCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.scheduleCallbackCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void consult(UDAgent agent, UDConsultIn cons) => this.Invoke(nameof (consult), new object[2]
    {
      (object) agent,
      (object) cons
    });

    public IAsyncResult Beginconsult(
      UDAgent agent,
      UDConsultIn cons,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("consult", new object[2]
      {
        (object) agent,
        (object) cons
      }, callback, asyncState);
    }

    public void Endconsult(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void consultAsync(UDAgent agent, UDConsultIn cons) => this.consultAsync(agent, cons, (object) null);

    public void consultAsync(UDAgent agent, UDConsultIn cons, object userState)
    {
      if (this.consultOperationCompleted == null)
        this.consultOperationCompleted = new SendOrPostCallback(this.OnconsultOperationCompleted);
      this.InvokeAsync("consult", new object[2]
      {
        (object) agent,
        (object) cons
      }, this.consultOperationCompleted, userState);
    }

    private void OnconsultOperationCompleted(object arg)
    {
      if (this.consultCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.consultCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void conference(UDAgent agent, UDConferenceIn conf) => this.Invoke(nameof (conference), new object[2]
    {
      (object) agent,
      (object) conf
    });

    public IAsyncResult Beginconference(
      UDAgent agent,
      UDConferenceIn conf,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("conference", new object[2]
      {
        (object) agent,
        (object) conf
      }, callback, asyncState);
    }

    public void Endconference(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void conferenceAsync(UDAgent agent, UDConferenceIn conf) => this.conferenceAsync(agent, conf, (object) null);

    public void conferenceAsync(UDAgent agent, UDConferenceIn conf, object userState)
    {
      if (this.conferenceOperationCompleted == null)
        this.conferenceOperationCompleted = new SendOrPostCallback(this.OnconferenceOperationCompleted);
      this.InvokeAsync("conference", new object[2]
      {
        (object) agent,
        (object) conf
      }, this.conferenceOperationCompleted, userState);
    }

    private void OnconferenceOperationCompleted(object arg)
    {
      if (this.conferenceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.conferenceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void dial(UDAgent agent, UDCall callinfo) => this.Invoke(nameof (dial), new object[2]
    {
      (object) agent,
      (object) callinfo
    });

    public IAsyncResult Begindial(
      UDAgent agent,
      UDCall callinfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("dial", new object[2]
      {
        (object) agent,
        (object) callinfo
      }, callback, asyncState);
    }

    public void Enddial(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void dialAsync(UDAgent agent, UDCall callinfo) => this.dialAsync(agent, callinfo, (object) null);

    public void dialAsync(UDAgent agent, UDCall callinfo, object userState)
    {
      if (this.dialOperationCompleted == null)
        this.dialOperationCompleted = new SendOrPostCallback(this.OndialOperationCompleted);
      this.InvokeAsync("dial", new object[2]
      {
        (object) agent,
        (object) callinfo
      }, this.dialOperationCompleted, userState);
    }

    private void OndialOperationCompleted(object arg)
    {
      if (this.dialCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.dialCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void hold(UDAgent agent, UDParm parm) => this.Invoke(nameof (hold), new object[2]
    {
      (object) agent,
      (object) parm
    });

    public IAsyncResult Beginhold(
      UDAgent agent,
      UDParm parm,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("hold", new object[2]
      {
        (object) agent,
        (object) parm
      }, callback, asyncState);
    }

    public void Endhold(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void holdAsync(UDAgent agent, UDParm parm) => this.holdAsync(agent, parm, (object) null);

    public void holdAsync(UDAgent agent, UDParm parm, object userState)
    {
      if (this.holdOperationCompleted == null)
        this.holdOperationCompleted = new SendOrPostCallback(this.OnholdOperationCompleted);
      this.InvokeAsync("hold", new object[2]
      {
        (object) agent,
        (object) parm
      }, this.holdOperationCompleted, userState);
    }

    private void OnholdOperationCompleted(object arg)
    {
      if (this.holdCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.holdCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void playDigits(UDAgent agent, UDDigits digits) => this.Invoke(nameof (playDigits), new object[2]
    {
      (object) agent,
      (object) digits
    });

    public IAsyncResult BeginplayDigits(
      UDAgent agent,
      UDDigits digits,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("playDigits", new object[2]
      {
        (object) agent,
        (object) digits
      }, callback, asyncState);
    }

    public void EndplayDigits(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void playDigitsAsync(UDAgent agent, UDDigits digits) => this.playDigitsAsync(agent, digits, (object) null);

    public void playDigitsAsync(UDAgent agent, UDDigits digits, object userState)
    {
      if (this.playDigitsOperationCompleted == null)
        this.playDigitsOperationCompleted = new SendOrPostCallback(this.OnplayDigitsOperationCompleted);
      this.InvokeAsync("playDigits", new object[2]
      {
        (object) agent,
        (object) digits
      }, this.playDigitsOperationCompleted, userState);
    }

    private void OnplayDigitsOperationCompleted(object arg)
    {
      if (this.playDigitsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.playDigitsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void answerCall(UDAgent agent, UDAnswerCall answer) => this.Invoke(nameof (answerCall), new object[2]
    {
      (object) agent,
      (object) answer
    });

    public IAsyncResult BeginanswerCall(
      UDAgent agent,
      UDAnswerCall answer,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("answerCall", new object[2]
      {
        (object) agent,
        (object) answer
      }, callback, asyncState);
    }

    public void EndanswerCall(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void answerCallAsync(UDAgent agent, UDAnswerCall answer) => this.answerCallAsync(agent, answer, (object) null);

    public void answerCallAsync(UDAgent agent, UDAnswerCall answer, object userState)
    {
      if (this.answerCallOperationCompleted == null)
        this.answerCallOperationCompleted = new SendOrPostCallback(this.OnanswerCallOperationCompleted);
      this.InvokeAsync("answerCall", new object[2]
      {
        (object) agent,
        (object) answer
      }, this.answerCallOperationCompleted, userState);
    }

    private void OnanswerCallOperationCompleted(object arg)
    {
      if (this.answerCallCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.answerCallCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void externalRoute(UDAgent agent, UDExternalRouteIn eroute) => this.Invoke(nameof (externalRoute), new object[2]
    {
      (object) agent,
      (object) eroute
    });

    public IAsyncResult BeginexternalRoute(
      UDAgent agent,
      UDExternalRouteIn eroute,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("externalRoute", new object[2]
      {
        (object) agent,
        (object) eroute
      }, callback, asyncState);
    }

    public void EndexternalRoute(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void externalRouteAsync(UDAgent agent, UDExternalRouteIn eroute) => this.externalRouteAsync(agent, eroute, (object) null);

    public void externalRouteAsync(UDAgent agent, UDExternalRouteIn eroute, object userState)
    {
      if (this.externalRouteOperationCompleted == null)
        this.externalRouteOperationCompleted = new SendOrPostCallback(this.OnexternalRouteOperationCompleted);
      this.InvokeAsync("externalRoute", new object[2]
      {
        (object) agent,
        (object) eroute
      }, this.externalRouteOperationCompleted, userState);
    }

    private void OnexternalRouteOperationCompleted(object arg)
    {
      if (this.externalRouteCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.externalRouteCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void record(UDAgent agent, UDRecorderData data) => this.Invoke(nameof (record), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult Beginrecord(
      UDAgent agent,
      UDRecorderData data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("record", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void Endrecord(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void recordAsync(UDAgent agent, UDRecorderData data) => this.recordAsync(agent, data, (object) null);

    public void recordAsync(UDAgent agent, UDRecorderData data, object userState)
    {
      if (this.recordOperationCompleted == null)
        this.recordOperationCompleted = new SendOrPostCallback(this.OnrecordOperationCompleted);
      this.InvokeAsync("record", new object[2]
      {
        (object) agent,
        (object) data
      }, this.recordOperationCompleted, userState);
    }

    private void OnrecordOperationCompleted(object arg)
    {
      if (this.recordCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.recordCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void forwardEmail(UDAgent agent, UDForwardEmail email) => this.Invoke(nameof (forwardEmail), new object[2]
    {
      (object) agent,
      (object) email
    });

    public IAsyncResult BeginforwardEmail(
      UDAgent agent,
      UDForwardEmail email,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("forwardEmail", new object[2]
      {
        (object) agent,
        (object) email
      }, callback, asyncState);
    }

    public void EndforwardEmail(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void forwardEmailAsync(UDAgent agent, UDForwardEmail email) => this.forwardEmailAsync(agent, email, (object) null);

    public void forwardEmailAsync(UDAgent agent, UDForwardEmail email, object userState)
    {
      if (this.forwardEmailOperationCompleted == null)
        this.forwardEmailOperationCompleted = new SendOrPostCallback(this.OnforwardEmailOperationCompleted);
      this.InvokeAsync("forwardEmail", new object[2]
      {
        (object) agent,
        (object) email
      }, this.forwardEmailOperationCompleted, userState);
    }

    private void OnforwardEmailOperationCompleted(object arg)
    {
      if (this.forwardEmailCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.forwardEmailCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void focus(UDAgent agent, UDFocus finfo) => this.Invoke(nameof (focus), new object[2]
    {
      (object) agent,
      (object) finfo
    });

    public IAsyncResult Beginfocus(
      UDAgent agent,
      UDFocus finfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("focus", new object[2]
      {
        (object) agent,
        (object) finfo
      }, callback, asyncState);
    }

    public void Endfocus(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void focusAsync(UDAgent agent, UDFocus finfo) => this.focusAsync(agent, finfo, (object) null);

    public void focusAsync(UDAgent agent, UDFocus finfo, object userState)
    {
      if (this.focusOperationCompleted == null)
        this.focusOperationCompleted = new SendOrPostCallback(this.OnfocusOperationCompleted);
      this.InvokeAsync("focus", new object[2]
      {
        (object) agent,
        (object) finfo
      }, this.focusOperationCompleted, userState);
    }

    private void OnfocusOperationCompleted(object arg)
    {
      if (this.focusCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.focusCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getAgentStateReturn")]
    public UDState getAgentState(UDAgent agent) => (UDState) this.Invoke(nameof (getAgentState), new object[1]
    {
      (object) agent
    })[0];

    public IAsyncResult BegingetAgentState(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getAgentState", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public UDState EndgetAgentState(IAsyncResult asyncResult) => (UDState) this.EndInvoke(asyncResult)[0];

    public void getAgentStateAsync(UDAgent agent) => this.getAgentStateAsync(agent, (object) null);

    public void getAgentStateAsync(UDAgent agent, object userState)
    {
      if (this.getAgentStateOperationCompleted == null)
        this.getAgentStateOperationCompleted = new SendOrPostCallback(this.OngetAgentStateOperationCompleted);
      this.InvokeAsync("getAgentState", new object[1]
      {
        (object) agent
      }, this.getAgentStateOperationCompleted, userState);
    }

    private void OngetAgentStateOperationCompleted(object arg)
    {
      if (this.getAgentStateCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getAgentStateCompleted((object) this, new getAgentStateCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void hangup(UDAgent agent, UDParm parm) => this.Invoke(nameof (hangup), new object[2]
    {
      (object) agent,
      (object) parm
    });

    public IAsyncResult Beginhangup(
      UDAgent agent,
      UDParm parm,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("hangup", new object[2]
      {
        (object) agent,
        (object) parm
      }, callback, asyncState);
    }

    public void Endhangup(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void hangupAsync(UDAgent agent, UDParm parm) => this.hangupAsync(agent, parm, (object) null);

    public void hangupAsync(UDAgent agent, UDParm parm, object userState)
    {
      if (this.hangupOperationCompleted == null)
        this.hangupOperationCompleted = new SendOrPostCallback(this.OnhangupOperationCompleted);
      this.InvokeAsync("hangup", new object[2]
      {
        (object) agent,
        (object) parm
      }, this.hangupOperationCompleted, userState);
    }

    private void OnhangupOperationCompleted(object arg)
    {
      if (this.hangupCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.hangupCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void recordScreen(UDAgent agent, UDScreenRecorderData data) => this.Invoke(nameof (recordScreen), new object[2]
    {
      (object) agent,
      (object) data
    });

    public IAsyncResult BeginrecordScreen(
      UDAgent agent,
      UDScreenRecorderData data,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("recordScreen", new object[2]
      {
        (object) agent,
        (object) data
      }, callback, asyncState);
    }

    public void EndrecordScreen(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void recordScreenAsync(UDAgent agent, UDScreenRecorderData data) => this.recordScreenAsync(agent, data, (object) null);

    public void recordScreenAsync(UDAgent agent, UDScreenRecorderData data, object userState)
    {
      if (this.recordScreenOperationCompleted == null)
        this.recordScreenOperationCompleted = new SendOrPostCallback(this.OnrecordScreenOperationCompleted);
      this.InvokeAsync("recordScreen", new object[2]
      {
        (object) agent,
        (object) data
      }, this.recordScreenOperationCompleted, userState);
    }

    private void OnrecordScreenOperationCompleted(object arg)
    {
      if (this.recordScreenCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.recordScreenCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void registerEx(UDAgent agent, UDAgentInfo adata, UDProperty[] features) => this.Invoke(nameof (registerEx), new object[3]
    {
      (object) agent,
      (object) adata,
      (object) features
    });

    public IAsyncResult BeginregisterEx(
      UDAgent agent,
      UDAgentInfo adata,
      UDProperty[] features,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("registerEx", new object[3]
      {
        (object) agent,
        (object) adata,
        (object) features
      }, callback, asyncState);
    }

    public void EndregisterEx(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void registerExAsync(UDAgent agent, UDAgentInfo adata, UDProperty[] features) => this.registerExAsync(agent, adata, features, (object) null);

    public void registerExAsync(
      UDAgent agent,
      UDAgentInfo adata,
      UDProperty[] features,
      object userState)
    {
      if (this.registerExOperationCompleted == null)
        this.registerExOperationCompleted = new SendOrPostCallback(this.OnregisterExOperationCompleted);
      this.InvokeAsync("registerEx", new object[3]
      {
        (object) agent,
        (object) adata,
        (object) features
      }, this.registerExOperationCompleted, userState);
    }

    private void OnregisterExOperationCompleted(object arg)
    {
      if (this.registerExCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.registerExCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void excludeContact(UDAgent agent, UDExclude exclude) => this.Invoke(nameof (excludeContact), new object[2]
    {
      (object) agent,
      (object) exclude
    });

    public IAsyncResult BeginexcludeContact(
      UDAgent agent,
      UDExclude exclude,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("excludeContact", new object[2]
      {
        (object) agent,
        (object) exclude
      }, callback, asyncState);
    }

    public void EndexcludeContact(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void excludeContactAsync(UDAgent agent, UDExclude exclude) => this.excludeContactAsync(agent, exclude, (object) null);

    public void excludeContactAsync(UDAgent agent, UDExclude exclude, object userState)
    {
      if (this.excludeContactOperationCompleted == null)
        this.excludeContactOperationCompleted = new SendOrPostCallback(this.OnexcludeContactOperationCompleted);
      this.InvokeAsync("excludeContact", new object[2]
      {
        (object) agent,
        (object) exclude
      }, this.excludeContactOperationCompleted, userState);
    }

    private void OnexcludeContactOperationCompleted(object arg)
    {
      if (this.excludeContactCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.excludeContactCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getRemoteInfoReturn")]
    public object getRemoteInfo(UDAgent agent, UDInfo info, IPNIQNodeDetail ipniqnode) => this.Invoke(nameof (getRemoteInfo), new object[3]
    {
      (object) agent,
      (object) info,
      (object) ipniqnode
    })[0];

    public IAsyncResult BegingetRemoteInfo(
      UDAgent agent,
      UDInfo info,
      IPNIQNodeDetail ipniqnode,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getRemoteInfo", new object[3]
      {
        (object) agent,
        (object) info,
        (object) ipniqnode
      }, callback, asyncState);
    }

    public object EndgetRemoteInfo(IAsyncResult asyncResult) => this.EndInvoke(asyncResult)[0];

    public void getRemoteInfoAsync(UDAgent agent, UDInfo info, IPNIQNodeDetail ipniqnode) => this.getRemoteInfoAsync(agent, info, ipniqnode, (object) null);

    public void getRemoteInfoAsync(
      UDAgent agent,
      UDInfo info,
      IPNIQNodeDetail ipniqnode,
      object userState)
    {
      if (this.getRemoteInfoOperationCompleted == null)
        this.getRemoteInfoOperationCompleted = new SendOrPostCallback(this.OngetRemoteInfoOperationCompleted);
      this.InvokeAsync("getRemoteInfo", new object[3]
      {
        (object) agent,
        (object) info,
        (object) ipniqnode
      }, this.getRemoteInfoOperationCompleted, userState);
    }

    private void OngetRemoteInfoOperationCompleted(object arg)
    {
      if (this.getRemoteInfoCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getRemoteInfoCompleted((object) this, new getRemoteInfoCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void monitorScreen(UDAgent agent, UDScreenMonitor minfo) => this.Invoke(nameof (monitorScreen), new object[2]
    {
      (object) agent,
      (object) minfo
    });

    public IAsyncResult BeginmonitorScreen(
      UDAgent agent,
      UDScreenMonitor minfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("monitorScreen", new object[2]
      {
        (object) agent,
        (object) minfo
      }, callback, asyncState);
    }

    public void EndmonitorScreen(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void monitorScreenAsync(UDAgent agent, UDScreenMonitor minfo) => this.monitorScreenAsync(agent, minfo, (object) null);

    public void monitorScreenAsync(UDAgent agent, UDScreenMonitor minfo, object userState)
    {
      if (this.monitorScreenOperationCompleted == null)
        this.monitorScreenOperationCompleted = new SendOrPostCallback(this.OnmonitorScreenOperationCompleted);
      this.InvokeAsync("monitorScreen", new object[2]
      {
        (object) agent,
        (object) minfo
      }, this.monitorScreenOperationCompleted, userState);
    }

    private void OnmonitorScreenOperationCompleted(object arg)
    {
      if (this.monitorScreenCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.monitorScreenCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void callOutcome(UDAgent agent, UDDisposition disposition) => this.Invoke(nameof (callOutcome), new object[2]
    {
      (object) agent,
      (object) disposition
    });

    public IAsyncResult BegincallOutcome(
      UDAgent agent,
      UDDisposition disposition,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("callOutcome", new object[2]
      {
        (object) agent,
        (object) disposition
      }, callback, asyncState);
    }

    public void EndcallOutcome(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void callOutcomeAsync(UDAgent agent, UDDisposition disposition) => this.callOutcomeAsync(agent, disposition, (object) null);

    public void callOutcomeAsync(UDAgent agent, UDDisposition disposition, object userState)
    {
      if (this.callOutcomeOperationCompleted == null)
        this.callOutcomeOperationCompleted = new SendOrPostCallback(this.OncallOutcomeOperationCompleted);
      this.InvokeAsync("callOutcome", new object[2]
      {
        (object) agent,
        (object) disposition
      }, this.callOutcomeOperationCompleted, userState);
    }

    private void OncallOutcomeOperationCompleted(object arg)
    {
      if (this.callOutcomeCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.callOutcomeCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void beginKWSession(UDAgent agent, UDKWInfo kwInfo) => this.Invoke(nameof (beginKWSession), new object[2]
    {
      (object) agent,
      (object) kwInfo
    });

    public IAsyncResult BeginbeginKWSession(
      UDAgent agent,
      UDKWInfo kwInfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("beginKWSession", new object[2]
      {
        (object) agent,
        (object) kwInfo
      }, callback, asyncState);
    }

    public void EndbeginKWSession(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void beginKWSessionAsync(UDAgent agent, UDKWInfo kwInfo) => this.beginKWSessionAsync(agent, kwInfo, (object) null);

    public void beginKWSessionAsync(UDAgent agent, UDKWInfo kwInfo, object userState)
    {
      if (this.beginKWSessionOperationCompleted == null)
        this.beginKWSessionOperationCompleted = new SendOrPostCallback(this.OnbeginKWSessionOperationCompleted);
      this.InvokeAsync("beginKWSession", new object[2]
      {
        (object) agent,
        (object) kwInfo
      }, this.beginKWSessionOperationCompleted, userState);
    }

    private void OnbeginKWSessionOperationCompleted(object arg)
    {
      if (this.beginKWSessionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.beginKWSessionCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatSendMessage(UDAgent agent, UDChatMessage chatmessage) => this.Invoke(nameof (chatSendMessage), new object[2]
    {
      (object) agent,
      (object) chatmessage
    });

    public IAsyncResult BeginchatSendMessage(
      UDAgent agent,
      UDChatMessage chatmessage,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatSendMessage", new object[2]
      {
        (object) agent,
        (object) chatmessage
      }, callback, asyncState);
    }

    public void EndchatSendMessage(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatSendMessageAsync(UDAgent agent, UDChatMessage chatmessage) => this.chatSendMessageAsync(agent, chatmessage, (object) null);

    public void chatSendMessageAsync(UDAgent agent, UDChatMessage chatmessage, object userState)
    {
      if (this.chatSendMessageOperationCompleted == null)
        this.chatSendMessageOperationCompleted = new SendOrPostCallback(this.OnchatSendMessageOperationCompleted);
      this.InvokeAsync("chatSendMessage", new object[2]
      {
        (object) agent,
        (object) chatmessage
      }, this.chatSendMessageOperationCompleted, userState);
    }

    private void OnchatSendMessageOperationCompleted(object arg)
    {
      if (this.chatSendMessageCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatSendMessageCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatConnect(UDAgent agent, [SoapElement("chatconnect")] UDChatConnect chatconnect1) => this.Invoke(nameof (chatConnect), new object[2]
    {
      (object) agent,
      (object) chatconnect1
    });

    public IAsyncResult BeginchatConnect(
      UDAgent agent,
      UDChatConnect chatconnect1,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatConnect", new object[2]
      {
        (object) agent,
        (object) chatconnect1
      }, callback, asyncState);
    }

    public void EndchatConnect(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatConnectAsync(UDAgent agent, UDChatConnect chatconnect1) => this.chatConnectAsync(agent, chatconnect1, (object) null);

    public void chatConnectAsync(UDAgent agent, UDChatConnect chatconnect1, object userState)
    {
      if (this.chatConnectOperationCompleted == null)
        this.chatConnectOperationCompleted = new SendOrPostCallback(this.OnchatConnectOperationCompleted);
      this.InvokeAsync("chatConnect", new object[2]
      {
        (object) agent,
        (object) chatconnect1
      }, this.chatConnectOperationCompleted, userState);
    }

    private void OnchatConnectOperationCompleted(object arg)
    {
      if (this.chatConnectCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatConnectCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatSendURL(UDAgent agent, UDChatURL chaturl) => this.Invoke(nameof (chatSendURL), new object[2]
    {
      (object) agent,
      (object) chaturl
    });

    public IAsyncResult BeginchatSendURL(
      UDAgent agent,
      UDChatURL chaturl,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatSendURL", new object[2]
      {
        (object) agent,
        (object) chaturl
      }, callback, asyncState);
    }

    public void EndchatSendURL(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatSendURLAsync(UDAgent agent, UDChatURL chaturl) => this.chatSendURLAsync(agent, chaturl, (object) null);

    public void chatSendURLAsync(UDAgent agent, UDChatURL chaturl, object userState)
    {
      if (this.chatSendURLOperationCompleted == null)
        this.chatSendURLOperationCompleted = new SendOrPostCallback(this.OnchatSendURLOperationCompleted);
      this.InvokeAsync("chatSendURL", new object[2]
      {
        (object) agent,
        (object) chaturl
      }, this.chatSendURLOperationCompleted, userState);
    }

    private void OnchatSendURLOperationCompleted(object arg)
    {
      if (this.chatSendURLCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatSendURLCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void emailNotify(UDAgent agent, UDEmailNotify enote) => this.Invoke(nameof (emailNotify), new object[2]
    {
      (object) agent,
      (object) enote
    });

    public IAsyncResult BeginemailNotify(
      UDAgent agent,
      UDEmailNotify enote,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("emailNotify", new object[2]
      {
        (object) agent,
        (object) enote
      }, callback, asyncState);
    }

    public void EndemailNotify(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void emailNotifyAsync(UDAgent agent, UDEmailNotify enote) => this.emailNotifyAsync(agent, enote, (object) null);

    public void emailNotifyAsync(UDAgent agent, UDEmailNotify enote, object userState)
    {
      if (this.emailNotifyOperationCompleted == null)
        this.emailNotifyOperationCompleted = new SendOrPostCallback(this.OnemailNotifyOperationCompleted);
      this.InvokeAsync("emailNotify", new object[2]
      {
        (object) agent,
        (object) enote
      }, this.emailNotifyOperationCompleted, userState);
    }

    private void OnemailNotifyOperationCompleted(object arg)
    {
      if (this.emailNotifyCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.emailNotifyCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("getExpertsReturn")]
    public object getExperts(Expert exp, string queryString) => this.Invoke(nameof (getExperts), new object[2]
    {
      (object) exp,
      (object) queryString
    })[0];

    public IAsyncResult BegingetExperts(
      Expert exp,
      string queryString,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getExperts", new object[2]
      {
        (object) exp,
        (object) queryString
      }, callback, asyncState);
    }

    public object EndgetExperts(IAsyncResult asyncResult) => this.EndInvoke(asyncResult)[0];

    public void getExpertsAsync(Expert exp, string queryString) => this.getExpertsAsync(exp, queryString, (object) null);

    public void getExpertsAsync(Expert exp, string queryString, object userState)
    {
      if (this.getExpertsOperationCompleted == null)
        this.getExpertsOperationCompleted = new SendOrPostCallback(this.OngetExpertsOperationCompleted);
      this.InvokeAsync("getExperts", new object[2]
      {
        (object) exp,
        (object) queryString
      }, this.getExpertsOperationCompleted, userState);
    }

    private void OngetExpertsOperationCompleted(object arg)
    {
      if (this.getExpertsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getExpertsCompleted((object) this, new getExpertsCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrSendURL(UDAgent agent, UDChatEntityPushURL chaturl) => this.Invoke(nameof (chatsvrSendURL), new object[2]
    {
      (object) agent,
      (object) chaturl
    });

    public IAsyncResult BeginchatsvrSendURL(
      UDAgent agent,
      UDChatEntityPushURL chaturl,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrSendURL", new object[2]
      {
        (object) agent,
        (object) chaturl
      }, callback, asyncState);
    }

    public void EndchatsvrSendURL(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrSendURLAsync(UDAgent agent, UDChatEntityPushURL chaturl) => this.chatsvrSendURLAsync(agent, chaturl, (object) null);

    public void chatsvrSendURLAsync(UDAgent agent, UDChatEntityPushURL chaturl, object userState)
    {
      if (this.chatsvrSendURLOperationCompleted == null)
        this.chatsvrSendURLOperationCompleted = new SendOrPostCallback(this.OnchatsvrSendURLOperationCompleted);
      this.InvokeAsync("chatsvrSendURL", new object[2]
      {
        (object) agent,
        (object) chaturl
      }, this.chatsvrSendURLOperationCompleted, userState);
    }

    private void OnchatsvrSendURLOperationCompleted(object arg)
    {
      if (this.chatsvrSendURLCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrSendURLCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void endKWSession(UDAgent agent, UDKWInfo kwInfo) => this.Invoke(nameof (endKWSession), new object[2]
    {
      (object) agent,
      (object) kwInfo
    });

    public IAsyncResult BeginendKWSession(
      UDAgent agent,
      UDKWInfo kwInfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("endKWSession", new object[2]
      {
        (object) agent,
        (object) kwInfo
      }, callback, asyncState);
    }

    public void EndendKWSession(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void endKWSessionAsync(UDAgent agent, UDKWInfo kwInfo) => this.endKWSessionAsync(agent, kwInfo, (object) null);

    public void endKWSessionAsync(UDAgent agent, UDKWInfo kwInfo, object userState)
    {
      if (this.endKWSessionOperationCompleted == null)
        this.endKWSessionOperationCompleted = new SendOrPostCallback(this.OnendKWSessionOperationCompleted);
      this.InvokeAsync("endKWSession", new object[2]
      {
        (object) agent,
        (object) kwInfo
      }, this.endKWSessionOperationCompleted, userState);
    }

    private void OnendKWSessionOperationCompleted(object arg)
    {
      if (this.endKWSessionCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.endKWSessionCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void forwardEmailSent(UDAgent agent, UDForwardEmailSent email) => this.Invoke(nameof (forwardEmailSent), new object[2]
    {
      (object) agent,
      (object) email
    });

    public IAsyncResult BeginforwardEmailSent(
      UDAgent agent,
      UDForwardEmailSent email,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("forwardEmailSent", new object[2]
      {
        (object) agent,
        (object) email
      }, callback, asyncState);
    }

    public void EndforwardEmailSent(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void forwardEmailSentAsync(UDAgent agent, UDForwardEmailSent email) => this.forwardEmailSentAsync(agent, email, (object) null);

    public void forwardEmailSentAsync(UDAgent agent, UDForwardEmailSent email, object userState)
    {
      if (this.forwardEmailSentOperationCompleted == null)
        this.forwardEmailSentOperationCompleted = new SendOrPostCallback(this.OnforwardEmailSentOperationCompleted);
      this.InvokeAsync("forwardEmailSent", new object[2]
      {
        (object) agent,
        (object) email
      }, this.forwardEmailSentOperationCompleted, userState);
    }

    private void OnforwardEmailSentOperationCompleted(object arg)
    {
      if (this.forwardEmailSentCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.forwardEmailSentCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void keepAlive(UDAgent agent) => this.Invoke(nameof (keepAlive), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BeginkeepAlive(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("keepAlive", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndkeepAlive(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void keepAliveAsync(UDAgent agent) => this.keepAliveAsync(agent, (object) null);

    public void keepAliveAsync(UDAgent agent, object userState)
    {
      if (this.keepAliveOperationCompleted == null)
        this.keepAliveOperationCompleted = new SendOrPostCallback(this.OnkeepAliveOperationCompleted);
      this.InvokeAsync("keepAlive", new object[1]
      {
        (object) agent
      }, this.keepAliveOperationCompleted, userState);
    }

    private void OnkeepAliveOperationCompleted(object arg)
    {
      if (this.keepAliveCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.keepAliveCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    [return: SoapElement("recordingManagementReturn")]
    public object recordingManagement(UDAgent agent, UDRecordingManagementParms parms) => this.Invoke(nameof (recordingManagement), new object[2]
    {
      (object) agent,
      (object) parms
    })[0];

    public IAsyncResult BeginrecordingManagement(
      UDAgent agent,
      UDRecordingManagementParms parms,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("recordingManagement", new object[2]
      {
        (object) agent,
        (object) parms
      }, callback, asyncState);
    }

    public object EndrecordingManagement(IAsyncResult asyncResult) => this.EndInvoke(asyncResult)[0];

    public void recordingManagementAsync(UDAgent agent, UDRecordingManagementParms parms) => this.recordingManagementAsync(agent, parms, (object) null);

    public void recordingManagementAsync(
      UDAgent agent,
      UDRecordingManagementParms parms,
      object userState)
    {
      if (this.recordingManagementOperationCompleted == null)
        this.recordingManagementOperationCompleted = new SendOrPostCallback(this.OnrecordingManagementOperationCompleted);
      this.InvokeAsync("recordingManagement", new object[2]
      {
        (object) agent,
        (object) parms
      }, this.recordingManagementOperationCompleted, userState);
    }

    private void OnrecordingManagementOperationCompleted(object arg)
    {
      if (this.recordingManagementCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.recordingManagementCompleted((object) this, new recordingManagementCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrEntityRemoved(UDAgent agent, UDChatEntityList entlist) => this.Invoke(nameof (chatsvrEntityRemoved), new object[2]
    {
      (object) agent,
      (object) entlist
    });

    public IAsyncResult BeginchatsvrEntityRemoved(
      UDAgent agent,
      UDChatEntityList entlist,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrEntityRemoved", new object[2]
      {
        (object) agent,
        (object) entlist
      }, callback, asyncState);
    }

    public void EndchatsvrEntityRemoved(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrEntityRemovedAsync(UDAgent agent, UDChatEntityList entlist) => this.chatsvrEntityRemovedAsync(agent, entlist, (object) null);

    public void chatsvrEntityRemovedAsync(
      UDAgent agent,
      UDChatEntityList entlist,
      object userState)
    {
      if (this.chatsvrEntityRemovedOperationCompleted == null)
        this.chatsvrEntityRemovedOperationCompleted = new SendOrPostCallback(this.OnchatsvrEntityRemovedOperationCompleted);
      this.InvokeAsync("chatsvrEntityRemoved", new object[2]
      {
        (object) agent,
        (object) entlist
      }, this.chatsvrEntityRemovedOperationCompleted, userState);
    }

    private void OnchatsvrEntityRemovedOperationCompleted(object arg)
    {
      if (this.chatsvrEntityRemovedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrEntityRemovedCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void cancelRequestLogout(UDAgent agent) => this.Invoke(nameof (cancelRequestLogout), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BegincancelRequestLogout(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("cancelRequestLogout", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndcancelRequestLogout(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void cancelRequestLogoutAsync(UDAgent agent) => this.cancelRequestLogoutAsync(agent, (object) null);

    public void cancelRequestLogoutAsync(UDAgent agent, object userState)
    {
      if (this.cancelRequestLogoutOperationCompleted == null)
        this.cancelRequestLogoutOperationCompleted = new SendOrPostCallback(this.OncancelRequestLogoutOperationCompleted);
      this.InvokeAsync("cancelRequestLogout", new object[1]
      {
        (object) agent
      }, this.cancelRequestLogoutOperationCompleted, userState);
    }

    private void OncancelRequestLogoutOperationCompleted(object arg)
    {
      if (this.cancelRequestLogoutCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelRequestLogoutCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void cancelRequestUnavailable(UDAgent agent) => this.Invoke(nameof (cancelRequestUnavailable), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BegincancelRequestUnavailable(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("cancelRequestUnavailable", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndcancelRequestUnavailable(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void cancelRequestUnavailableAsync(UDAgent agent) => this.cancelRequestUnavailableAsync(agent, (object) null);

    public void cancelRequestUnavailableAsync(UDAgent agent, object userState)
    {
      if (this.cancelRequestUnavailableOperationCompleted == null)
        this.cancelRequestUnavailableOperationCompleted = new SendOrPostCallback(this.OncancelRequestUnavailableOperationCompleted);
      this.InvokeAsync("cancelRequestUnavailable", new object[1]
      {
        (object) agent
      }, this.cancelRequestUnavailableOperationCompleted, userState);
    }

    private void OncancelRequestUnavailableOperationCompleted(object arg)
    {
      if (this.cancelRequestUnavailableCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.cancelRequestUnavailableCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrDialRequest(UDAgent agent, UDChatDialRequest chatdial) => this.Invoke(nameof (chatsvrDialRequest), new object[2]
    {
      (object) agent,
      (object) chatdial
    });

    public IAsyncResult BeginchatsvrDialRequest(
      UDAgent agent,
      UDChatDialRequest chatdial,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrDialRequest", new object[2]
      {
        (object) agent,
        (object) chatdial
      }, callback, asyncState);
    }

    public void EndchatsvrDialRequest(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrDialRequestAsync(UDAgent agent, UDChatDialRequest chatdial) => this.chatsvrDialRequestAsync(agent, chatdial, (object) null);

    public void chatsvrDialRequestAsync(
      UDAgent agent,
      UDChatDialRequest chatdial,
      object userState)
    {
      if (this.chatsvrDialRequestOperationCompleted == null)
        this.chatsvrDialRequestOperationCompleted = new SendOrPostCallback(this.OnchatsvrDialRequestOperationCompleted);
      this.InvokeAsync("chatsvrDialRequest", new object[2]
      {
        (object) agent,
        (object) chatdial
      }, this.chatsvrDialRequestOperationCompleted, userState);
    }

    private void OnchatsvrDialRequestOperationCompleted(object arg)
    {
      if (this.chatsvrDialRequestCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrDialRequestCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void initiateKWVoiceConsult(UDAgent agent, [SoapElement("consult")] UDKWConsult consult1) => this.Invoke(nameof (initiateKWVoiceConsult), new object[2]
    {
      (object) agent,
      (object) consult1
    });

    public IAsyncResult BegininitiateKWVoiceConsult(
      UDAgent agent,
      UDKWConsult consult1,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("initiateKWVoiceConsult", new object[2]
      {
        (object) agent,
        (object) consult1
      }, callback, asyncState);
    }

    public void EndinitiateKWVoiceConsult(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void initiateKWVoiceConsultAsync(UDAgent agent, UDKWConsult consult1) => this.initiateKWVoiceConsultAsync(agent, consult1, (object) null);

    public void initiateKWVoiceConsultAsync(UDAgent agent, UDKWConsult consult1, object userState)
    {
      if (this.initiateKWVoiceConsultOperationCompleted == null)
        this.initiateKWVoiceConsultOperationCompleted = new SendOrPostCallback(this.OninitiateKWVoiceConsultOperationCompleted);
      this.InvokeAsync("initiateKWVoiceConsult", new object[2]
      {
        (object) agent,
        (object) consult1
      }, this.initiateKWVoiceConsultOperationCompleted, userState);
    }

    private void OninitiateKWVoiceConsultOperationCompleted(object arg)
    {
      if (this.initiateKWVoiceConsultCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.initiateKWVoiceConsultCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void refreshPersonalGreetings(UDAgent agent, UDRecordingManagementParms parms) => this.Invoke(nameof (refreshPersonalGreetings), new object[2]
    {
      (object) agent,
      (object) parms
    });

    public IAsyncResult BeginrefreshPersonalGreetings(
      UDAgent agent,
      UDRecordingManagementParms parms,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("refreshPersonalGreetings", new object[2]
      {
        (object) agent,
        (object) parms
      }, callback, asyncState);
    }

    public void EndrefreshPersonalGreetings(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void refreshPersonalGreetingsAsync(UDAgent agent, UDRecordingManagementParms parms) => this.refreshPersonalGreetingsAsync(agent, parms, (object) null);

    public void refreshPersonalGreetingsAsync(
      UDAgent agent,
      UDRecordingManagementParms parms,
      object userState)
    {
      if (this.refreshPersonalGreetingsOperationCompleted == null)
        this.refreshPersonalGreetingsOperationCompleted = new SendOrPostCallback(this.OnrefreshPersonalGreetingsOperationCompleted);
      this.InvokeAsync("refreshPersonalGreetings", new object[2]
      {
        (object) agent,
        (object) parms
      }, this.refreshPersonalGreetingsOperationCompleted, userState);
    }

    private void OnrefreshPersonalGreetingsOperationCompleted(object arg)
    {
      if (this.refreshPersonalGreetingsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.refreshPersonalGreetingsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrSendMessage(UDAgent agent, UDChatEntitySendText chatmessage) => this.Invoke(nameof (chatsvrSendMessage), new object[2]
    {
      (object) agent,
      (object) chatmessage
    });

    public IAsyncResult BeginchatsvrSendMessage(
      UDAgent agent,
      UDChatEntitySendText chatmessage,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrSendMessage", new object[2]
      {
        (object) agent,
        (object) chatmessage
      }, callback, asyncState);
    }

    public void EndchatsvrSendMessage(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrSendMessageAsync(UDAgent agent, UDChatEntitySendText chatmessage) => this.chatsvrSendMessageAsync(agent, chatmessage, (object) null);

    public void chatsvrSendMessageAsync(
      UDAgent agent,
      UDChatEntitySendText chatmessage,
      object userState)
    {
      if (this.chatsvrSendMessageOperationCompleted == null)
        this.chatsvrSendMessageOperationCompleted = new SendOrPostCallback(this.OnchatsvrSendMessageOperationCompleted);
      this.InvokeAsync("chatsvrSendMessage", new object[2]
      {
        (object) agent,
        (object) chatmessage
      }, this.chatsvrSendMessageOperationCompleted, userState);
    }

    private void OnchatsvrSendMessageOperationCompleted(object arg)
    {
      if (this.chatsvrSendMessageCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrSendMessageCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void initiateKWVoiceDial(UDAgent agent, UDKWDial dialInfo) => this.Invoke(nameof (initiateKWVoiceDial), new object[2]
    {
      (object) agent,
      (object) dialInfo
    });

    public IAsyncResult BegininitiateKWVoiceDial(
      UDAgent agent,
      UDKWDial dialInfo,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("initiateKWVoiceDial", new object[2]
      {
        (object) agent,
        (object) dialInfo
      }, callback, asyncState);
    }

    public void EndinitiateKWVoiceDial(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void initiateKWVoiceDialAsync(UDAgent agent, UDKWDial dialInfo) => this.initiateKWVoiceDialAsync(agent, dialInfo, (object) null);

    public void initiateKWVoiceDialAsync(UDAgent agent, UDKWDial dialInfo, object userState)
    {
      if (this.initiateKWVoiceDialOperationCompleted == null)
        this.initiateKWVoiceDialOperationCompleted = new SendOrPostCallback(this.OninitiateKWVoiceDialOperationCompleted);
      this.InvokeAsync("initiateKWVoiceDial", new object[2]
      {
        (object) agent,
        (object) dialInfo
      }, this.initiateKWVoiceDialOperationCompleted, userState);
    }

    private void OninitiateKWVoiceDialOperationCompleted(object arg)
    {
      if (this.initiateKWVoiceDialCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.initiateKWVoiceDialCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void requestAgentStats(UDAgent agent) => this.Invoke(nameof (requestAgentStats), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BeginrequestAgentStats(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("requestAgentStats", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndrequestAgentStats(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void requestAgentStatsAsync(UDAgent agent) => this.requestAgentStatsAsync(agent, (object) null);

    public void requestAgentStatsAsync(UDAgent agent, object userState)
    {
      if (this.requestAgentStatsOperationCompleted == null)
        this.requestAgentStatsOperationCompleted = new SendOrPostCallback(this.OnrequestAgentStatsOperationCompleted);
      this.InvokeAsync("requestAgentStats", new object[1]
      {
        (object) agent
      }, this.requestAgentStatsOperationCompleted, userState);
    }

    private void OnrequestAgentStatsOperationCompleted(object arg)
    {
      if (this.requestAgentStatsCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.requestAgentStatsCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void requestEmailReview(UDAgent agent, UDEmail edata) => this.Invoke(nameof (requestEmailReview), new object[2]
    {
      (object) agent,
      (object) edata
    });

    public IAsyncResult BeginrequestEmailReview(
      UDAgent agent,
      UDEmail edata,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("requestEmailReview", new object[2]
      {
        (object) agent,
        (object) edata
      }, callback, asyncState);
    }

    public void EndrequestEmailReview(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void requestEmailReviewAsync(UDAgent agent, UDEmail edata) => this.requestEmailReviewAsync(agent, edata, (object) null);

    public void requestEmailReviewAsync(UDAgent agent, UDEmail edata, object userState)
    {
      if (this.requestEmailReviewOperationCompleted == null)
        this.requestEmailReviewOperationCompleted = new SendOrPostCallback(this.OnrequestEmailReviewOperationCompleted);
      this.InvokeAsync("requestEmailReview", new object[2]
      {
        (object) agent,
        (object) edata
      }, this.requestEmailReviewOperationCompleted, userState);
    }

    private void OnrequestEmailReviewOperationCompleted(object arg)
    {
      if (this.requestEmailReviewCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.requestEmailReviewCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void requestEmailSelfService(UDAgent agent, UDEmail edata) => this.Invoke(nameof (requestEmailSelfService), new object[2]
    {
      (object) agent,
      (object) edata
    });

    public IAsyncResult BeginrequestEmailSelfService(
      UDAgent agent,
      UDEmail edata,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("requestEmailSelfService", new object[2]
      {
        (object) agent,
        (object) edata
      }, callback, asyncState);
    }

    public void EndrequestEmailSelfService(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void requestEmailSelfServiceAsync(UDAgent agent, UDEmail edata) => this.requestEmailSelfServiceAsync(agent, edata, (object) null);

    public void requestEmailSelfServiceAsync(UDAgent agent, UDEmail edata, object userState)
    {
      if (this.requestEmailSelfServiceOperationCompleted == null)
        this.requestEmailSelfServiceOperationCompleted = new SendOrPostCallback(this.OnrequestEmailSelfServiceOperationCompleted);
      this.InvokeAsync("requestEmailSelfService", new object[2]
      {
        (object) agent,
        (object) edata
      }, this.requestEmailSelfServiceOperationCompleted, userState);
    }

    private void OnrequestEmailSelfServiceOperationCompleted(object arg)
    {
      if (this.requestEmailSelfServiceCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.requestEmailSelfServiceCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void requestUnavailable(UDAgent agent, UDReason reason) => this.Invoke(nameof (requestUnavailable), new object[2]
    {
      (object) agent,
      (object) reason
    });

    public IAsyncResult BeginrequestUnavailable(
      UDAgent agent,
      UDReason reason,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("requestUnavailable", new object[2]
      {
        (object) agent,
        (object) reason
      }, callback, asyncState);
    }

    public void EndrequestUnavailable(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void requestUnavailableAsync(UDAgent agent, UDReason reason) => this.requestUnavailableAsync(agent, reason, (object) null);

    public void requestUnavailableAsync(UDAgent agent, UDReason reason, object userState)
    {
      if (this.requestUnavailableOperationCompleted == null)
        this.requestUnavailableOperationCompleted = new SendOrPostCallback(this.OnrequestUnavailableOperationCompleted);
      this.InvokeAsync("requestUnavailable", new object[2]
      {
        (object) agent,
        (object) reason
      }, this.requestUnavailableOperationCompleted, userState);
    }

    private void OnrequestUnavailableOperationCompleted(object arg)
    {
      if (this.requestUnavailableCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.requestUnavailableCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrEntityAdded(UDAgent agent, UDChatEntityList entlist) => this.Invoke(nameof (chatsvrEntityAdded), new object[2]
    {
      (object) agent,
      (object) entlist
    });

    public IAsyncResult BeginchatsvrEntityAdded(
      UDAgent agent,
      UDChatEntityList entlist,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrEntityAdded", new object[2]
      {
        (object) agent,
        (object) entlist
      }, callback, asyncState);
    }

    public void EndchatsvrEntityAdded(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrEntityAddedAsync(UDAgent agent, UDChatEntityList entlist) => this.chatsvrEntityAddedAsync(agent, entlist, (object) null);

    public void chatsvrEntityAddedAsync(UDAgent agent, UDChatEntityList entlist, object userState)
    {
      if (this.chatsvrEntityAddedOperationCompleted == null)
        this.chatsvrEntityAddedOperationCompleted = new SendOrPostCallback(this.OnchatsvrEntityAddedOperationCompleted);
      this.InvokeAsync("chatsvrEntityAdded", new object[2]
      {
        (object) agent,
        (object) entlist
      }, this.chatsvrEntityAddedOperationCompleted, userState);
    }

    private void OnchatsvrEntityAddedOperationCompleted(object arg)
    {
      if (this.chatsvrEntityAddedCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrEntityAddedCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void chatsvrSendListOfChatEntites(UDAgent agent, UDChatEntityList entlist) => this.Invoke(nameof (chatsvrSendListOfChatEntites), new object[2]
    {
      (object) agent,
      (object) entlist
    });

    public IAsyncResult BeginchatsvrSendListOfChatEntites(
      UDAgent agent,
      UDChatEntityList entlist,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("chatsvrSendListOfChatEntites", new object[2]
      {
        (object) agent,
        (object) entlist
      }, callback, asyncState);
    }

    public void EndchatsvrSendListOfChatEntites(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void chatsvrSendListOfChatEntitesAsync(UDAgent agent, UDChatEntityList entlist) => this.chatsvrSendListOfChatEntitesAsync(agent, entlist, (object) null);

    public void chatsvrSendListOfChatEntitesAsync(
      UDAgent agent,
      UDChatEntityList entlist,
      object userState)
    {
      if (this.chatsvrSendListOfChatEntitesOperationCompleted == null)
        this.chatsvrSendListOfChatEntitesOperationCompleted = new SendOrPostCallback(this.OnchatsvrSendListOfChatEntitesOperationCompleted);
      this.InvokeAsync("chatsvrSendListOfChatEntites", new object[2]
      {
        (object) agent,
        (object) entlist
      }, this.chatsvrSendListOfChatEntitesOperationCompleted, userState);
    }

    private void OnchatsvrSendListOfChatEntitesOperationCompleted(object arg)
    {
      if (this.chatsvrSendListOfChatEntitesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.chatsvrSendListOfChatEntitesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void suspendMultiAppearances(UDAgent agent) => this.Invoke(nameof (suspendMultiAppearances), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BeginsuspendMultiAppearances(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("suspendMultiAppearances", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndsuspendMultiAppearances(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void suspendMultiAppearancesAsync(UDAgent agent) => this.suspendMultiAppearancesAsync(agent, (object) null);

    public void suspendMultiAppearancesAsync(UDAgent agent, object userState)
    {
      if (this.suspendMultiAppearancesOperationCompleted == null)
        this.suspendMultiAppearancesOperationCompleted = new SendOrPostCallback(this.OnsuspendMultiAppearancesOperationCompleted);
      this.InvokeAsync("suspendMultiAppearances", new object[1]
      {
        (object) agent
      }, this.suspendMultiAppearancesOperationCompleted, userState);
    }

    private void OnsuspendMultiAppearancesOperationCompleted(object arg)
    {
      if (this.suspendMultiAppearancesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.suspendMultiAppearancesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://AgentService.UD.concerto.com", ResponseNamespace = "http://AgentService.UD.concerto.com")]
    public void resumeMultiAppearances(UDAgent agent) => this.Invoke(nameof (resumeMultiAppearances), new object[1]
    {
      (object) agent
    });

    public IAsyncResult BeginresumeMultiAppearances(
      UDAgent agent,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("resumeMultiAppearances", new object[1]
      {
        (object) agent
      }, callback, asyncState);
    }

    public void EndresumeMultiAppearances(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void resumeMultiAppearancesAsync(UDAgent agent) => this.resumeMultiAppearancesAsync(agent, (object) null);

    public void resumeMultiAppearancesAsync(UDAgent agent, object userState)
    {
      if (this.resumeMultiAppearancesOperationCompleted == null)
        this.resumeMultiAppearancesOperationCompleted = new SendOrPostCallback(this.OnresumeMultiAppearancesOperationCompleted);
      this.InvokeAsync("resumeMultiAppearances", new object[1]
      {
        (object) agent
      }, this.resumeMultiAppearancesOperationCompleted, userState);
    }

    private void OnresumeMultiAppearancesOperationCompleted(object arg)
    {
      if (this.resumeMultiAppearancesCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.resumeMultiAppearancesCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    public new void CancelAsync(object userState) => base.CancelAsync(userState);

    private bool IsLocalFileSystemWebService(string url)
    {
      if (url == null || url == string.Empty)
        return false;
      Uri uri = new Uri(url);
      return uri.Port >= 1024 && string.Compare(uri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0;
    }
  }
}
