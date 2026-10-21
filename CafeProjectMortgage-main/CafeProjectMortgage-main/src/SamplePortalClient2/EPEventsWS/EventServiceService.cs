// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.EventServiceService
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

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Web.Services", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [WebServiceBinding(Name = "EventServiceSoapBinding", Namespace = "http://EventService.UD.concerto.com")]
  [SoapInclude(typeof (Vector))]
  [SoapInclude(typeof (EventServiceFault))]
  [SoapInclude(typeof (UDVoiceUnlock))]
  [SoapInclude(typeof (UDRemoveTimeZone))]
  [SoapInclude(typeof (UDUpdateTimeZone))]
  [SoapInclude(typeof (UDNewTimeZone))]
  [SoapInclude(typeof (UDVoiceLock))]
  [SoapInclude(typeof (UDWrapTimeout))]
  [SoapInclude(typeof (UDReserved))]
  [SoapInclude(typeof (UDForwardEmailAck))]
  [SoapInclude(typeof (UDAudioPathConnection))]
  [SoapInclude(typeof (UDNotifyUrl))]
  [SoapInclude(typeof (UDDialRequest))]
  [SoapInclude(typeof (UDCCDown))]
  [SoapInclude(typeof (UDEntitySendText))]
  [SoapInclude(typeof (UDEntityPushUrl))]
  [SoapInclude(typeof (UDEntityList))]
  [SoapInclude(typeof (UDEntity))]
  [SoapInclude(typeof (UDEMailServiceStatisticsColl))]
  [SoapInclude(typeof (UDEMailServiceStatistics))]
  [SoapInclude(typeof (UDAgentStatsCollection))]
  [SoapInclude(typeof (UDScreenCapture))]
  [SoapInclude(typeof (UDDirectorAck))]
  [SoapInclude(typeof (UDBadPassCode))]
  [SoapInclude(typeof (UDPasscode))]
  [SoapInclude(typeof (UDRealTimePort))]
  [SoapInclude(typeof (UDUpdateDispositionPlan))]
  [SoapInclude(typeof (UDSystemWait))]
  [SoapInclude(typeof (UDPreview))]
  [SoapInclude(typeof (UDConference))]
  [SoapInclude(typeof (UDAgentIndex))]
  [SoapInclude(typeof (UDWrap))]
  [SoapInclude(typeof (UDIdle))]
  [SoapInclude(typeof (UDLogout))]
  [SoapInclude(typeof (UDExternalRoute))]
  [SoapInclude(typeof (UDConsult))]
  [SoapInclude(typeof (UDSwitch))]
  [SoapInclude(typeof (UDActive))]
  [SoapInclude(typeof (UDCallReRouted))]
  [SoapInclude(typeof (UDNotReady))]
  [SoapInclude(typeof (UDCallXferred))]
  [SoapInclude(typeof (UDNewService))]
  [SoapInclude(typeof (UDLogin))]
  [SoapInclude(typeof (UDScreenPop))]
  [SoapInclude(typeof (UDCallClear))]
  [SoapInclude(typeof (UDLoginConf))]
  [SoapInclude(typeof (UDRemoveService))]
  [SoapInclude(typeof (UDLoggingIn))]
  [SoapInclude(typeof (UDUpdateDisposition))]
  [SoapInclude(typeof (UDError))]
  [SoapInclude(typeof (UDMonitorState))]
  [SoapInclude(typeof (UDRecordState))]
  [SoapInclude(typeof (UDUpdateService))]
  [SoapInclude(typeof (UDNotifyDispositions))]
  [SoapInclude(typeof (UDActivateCall))]
  [SoapInclude(typeof (UDHeld))]
  [SoapInclude(typeof (UDUpdateCallDataDef))]
  [SoapInclude(typeof (UDNotifyCallDataDefFields))]
  [SoapInclude(typeof (UDCallReleasedXferred))]
  [SoapInclude(typeof (UDDialing))]
  public class EventServiceService : SoapHttpClientProtocol
  {
    private SendOrPostCallback unregisterAlertEventSubscriberOperationCompleted;
    private SendOrPostCallback getNextAgentEventOperationCompleted;
    private SendOrPostCallback getNextAgentEventAckOperationCompleted;
    private SendOrPostCallback registerAllAgentEventSubscriberOperationCompleted;
    private SendOrPostCallback getNextAlertEventOperationCompleted;
    private SendOrPostCallback unregisterAgentEventSubscriberOperationCompleted;
    private SendOrPostCallback registerAgentEventSubscriberOperationCompleted;
    private SendOrPostCallback registerAlertEventSubscriberOperationCompleted;
    private bool useDefaultCredentialsSetExplicitly;

    public EventServiceService()
    {
      this.Url = Settings.Default.SamplePortalClient_EPEventsWS_EventServiceService;
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

    public event unregisterAlertEventSubscriberCompletedEventHandler unregisterAlertEventSubscriberCompleted;

    public event getNextAgentEventCompletedEventHandler getNextAgentEventCompleted;

    public event getNextAgentEventAckCompletedEventHandler getNextAgentEventAckCompleted;

    public event registerAllAgentEventSubscriberCompletedEventHandler registerAllAgentEventSubscriberCompleted;

    public event getNextAlertEventCompletedEventHandler getNextAlertEventCompleted;

    public event unregisterAgentEventSubscriberCompletedEventHandler unregisterAgentEventSubscriberCompleted;

    public event registerAgentEventSubscriberCompletedEventHandler registerAgentEventSubscriberCompleted;

    public event registerAlertEventSubscriberCompletedEventHandler registerAlertEventSubscriberCompleted;

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    public void unregisterAlertEventSubscriber(int registrationId) => this.Invoke(nameof (unregisterAlertEventSubscriber), new object[1]
    {
      (object) registrationId
    });

    public IAsyncResult BeginunregisterAlertEventSubscriber(
      int registrationId,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("unregisterAlertEventSubscriber", new object[1]
      {
        (object) registrationId
      }, callback, asyncState);
    }

    public void EndunregisterAlertEventSubscriber(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void unregisterAlertEventSubscriberAsync(int registrationId) => this.unregisterAlertEventSubscriberAsync(registrationId, (object) null);

    public void unregisterAlertEventSubscriberAsync(int registrationId, object userState)
    {
      if (this.unregisterAlertEventSubscriberOperationCompleted == null)
        this.unregisterAlertEventSubscriberOperationCompleted = new SendOrPostCallback(this.OnunregisterAlertEventSubscriberOperationCompleted);
      this.InvokeAsync("unregisterAlertEventSubscriber", new object[1]
      {
        (object) registrationId
      }, this.unregisterAlertEventSubscriberOperationCompleted, userState);
    }

    private void OnunregisterAlertEventSubscriberOperationCompleted(object arg)
    {
      if (this.unregisterAlertEventSubscriberCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.unregisterAlertEventSubscriberCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("getNextAgentEventReturn")]
    public AgentEvent getNextAgentEvent(int registrationId) => (AgentEvent) this.Invoke(nameof (getNextAgentEvent), new object[1]
    {
      (object) registrationId
    })[0];

    public IAsyncResult BegingetNextAgentEvent(
      int registrationId,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getNextAgentEvent", new object[1]
      {
        (object) registrationId
      }, callback, asyncState);
    }

    public AgentEvent EndgetNextAgentEvent(IAsyncResult asyncResult) => (AgentEvent) this.EndInvoke(asyncResult)[0];

    public void getNextAgentEventAsync(int registrationId) => this.getNextAgentEventAsync(registrationId, (object) null);

    public void getNextAgentEventAsync(int registrationId, object userState)
    {
      if (this.getNextAgentEventOperationCompleted == null)
        this.getNextAgentEventOperationCompleted = new SendOrPostCallback(this.OngetNextAgentEventOperationCompleted);
      this.InvokeAsync("getNextAgentEvent", new object[1]
      {
        (object) registrationId
      }, this.getNextAgentEventOperationCompleted, userState);
    }

    private void OngetNextAgentEventOperationCompleted(object arg)
    {
      if (this.getNextAgentEventCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getNextAgentEventCompleted((object) this, new getNextAgentEventCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("getNextAgentEventAckReturn")]
    public AgentEvent getNextAgentEventAck(int registrationId, long sequenceNumber) => (AgentEvent) this.Invoke(nameof (getNextAgentEventAck), new object[2]
    {
      (object) registrationId,
      (object) sequenceNumber
    })[0];

    public IAsyncResult BegingetNextAgentEventAck(
      int registrationId,
      long sequenceNumber,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getNextAgentEventAck", new object[2]
      {
        (object) registrationId,
        (object) sequenceNumber
      }, callback, asyncState);
    }

    public AgentEvent EndgetNextAgentEventAck(IAsyncResult asyncResult) => (AgentEvent) this.EndInvoke(asyncResult)[0];

    public void getNextAgentEventAckAsync(int registrationId, long sequenceNumber) => this.getNextAgentEventAckAsync(registrationId, sequenceNumber, (object) null);

    public void getNextAgentEventAckAsync(
      int registrationId,
      long sequenceNumber,
      object userState)
    {
      if (this.getNextAgentEventAckOperationCompleted == null)
        this.getNextAgentEventAckOperationCompleted = new SendOrPostCallback(this.OngetNextAgentEventAckOperationCompleted);
      this.InvokeAsync("getNextAgentEventAck", new object[2]
      {
        (object) registrationId,
        (object) sequenceNumber
      }, this.getNextAgentEventAckOperationCompleted, userState);
    }

    private void OngetNextAgentEventAckOperationCompleted(object arg)
    {
      if (this.getNextAgentEventAckCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getNextAgentEventAckCompleted((object) this, new getNextAgentEventAckCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("registerAllAgentEventSubscriberReturn")]
    public int registerAllAgentEventSubscriber() => (int) this.Invoke(nameof (registerAllAgentEventSubscriber), new object[0])[0];

    public IAsyncResult BeginregisterAllAgentEventSubscriber(
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("registerAllAgentEventSubscriber", new object[0], callback, asyncState);
    }

    public int EndregisterAllAgentEventSubscriber(IAsyncResult asyncResult) => (int) this.EndInvoke(asyncResult)[0];

    public void registerAllAgentEventSubscriberAsync() => this.registerAllAgentEventSubscriberAsync((object) null);

    public void registerAllAgentEventSubscriberAsync(object userState)
    {
      if (this.registerAllAgentEventSubscriberOperationCompleted == null)
        this.registerAllAgentEventSubscriberOperationCompleted = new SendOrPostCallback(this.OnregisterAllAgentEventSubscriberOperationCompleted);
      this.InvokeAsync("registerAllAgentEventSubscriber", new object[0], this.registerAllAgentEventSubscriberOperationCompleted, userState);
    }

    private void OnregisterAllAgentEventSubscriberOperationCompleted(object arg)
    {
      if (this.registerAllAgentEventSubscriberCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.registerAllAgentEventSubscriberCompleted((object) this, new registerAllAgentEventSubscriberCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("getNextAlertEventReturn")]
    public AlertEvent getNextAlertEvent(int registrationId) => (AlertEvent) this.Invoke(nameof (getNextAlertEvent), new object[1]
    {
      (object) registrationId
    })[0];

    public IAsyncResult BegingetNextAlertEvent(
      int registrationId,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("getNextAlertEvent", new object[1]
      {
        (object) registrationId
      }, callback, asyncState);
    }

    public AlertEvent EndgetNextAlertEvent(IAsyncResult asyncResult) => (AlertEvent) this.EndInvoke(asyncResult)[0];

    public void getNextAlertEventAsync(int registrationId) => this.getNextAlertEventAsync(registrationId, (object) null);

    public void getNextAlertEventAsync(int registrationId, object userState)
    {
      if (this.getNextAlertEventOperationCompleted == null)
        this.getNextAlertEventOperationCompleted = new SendOrPostCallback(this.OngetNextAlertEventOperationCompleted);
      this.InvokeAsync("getNextAlertEvent", new object[1]
      {
        (object) registrationId
      }, this.getNextAlertEventOperationCompleted, userState);
    }

    private void OngetNextAlertEventOperationCompleted(object arg)
    {
      if (this.getNextAlertEventCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.getNextAlertEventCompleted((object) this, new getNextAlertEventCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    public void unregisterAgentEventSubscriber(int registrationId) => this.Invoke(nameof (unregisterAgentEventSubscriber), new object[1]
    {
      (object) registrationId
    });

    public IAsyncResult BeginunregisterAgentEventSubscriber(
      int registrationId,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("unregisterAgentEventSubscriber", new object[1]
      {
        (object) registrationId
      }, callback, asyncState);
    }

    public void EndunregisterAgentEventSubscriber(IAsyncResult asyncResult) => this.EndInvoke(asyncResult);

    public void unregisterAgentEventSubscriberAsync(int registrationId) => this.unregisterAgentEventSubscriberAsync(registrationId, (object) null);

    public void unregisterAgentEventSubscriberAsync(int registrationId, object userState)
    {
      if (this.unregisterAgentEventSubscriberOperationCompleted == null)
        this.unregisterAgentEventSubscriberOperationCompleted = new SendOrPostCallback(this.OnunregisterAgentEventSubscriberOperationCompleted);
      this.InvokeAsync("unregisterAgentEventSubscriber", new object[1]
      {
        (object) registrationId
      }, this.unregisterAgentEventSubscriberOperationCompleted, userState);
    }

    private void OnunregisterAgentEventSubscriberOperationCompleted(object arg)
    {
      if (this.unregisterAgentEventSubscriberCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.unregisterAgentEventSubscriberCompleted((object) this, new AsyncCompletedEventArgs(completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("registerAgentEventSubscriberReturn")]
    public int registerAgentEventSubscriber(string agentName) => (int) this.Invoke(nameof (registerAgentEventSubscriber), new object[1]
    {
      (object) agentName
    })[0];

    public IAsyncResult BeginregisterAgentEventSubscriber(
      string agentName,
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("registerAgentEventSubscriber", new object[1]
      {
        (object) agentName
      }, callback, asyncState);
    }

    public int EndregisterAgentEventSubscriber(IAsyncResult asyncResult) => (int) this.EndInvoke(asyncResult)[0];

    public void registerAgentEventSubscriberAsync(string agentName) => this.registerAgentEventSubscriberAsync(agentName, (object) null);

    public void registerAgentEventSubscriberAsync(string agentName, object userState)
    {
      if (this.registerAgentEventSubscriberOperationCompleted == null)
        this.registerAgentEventSubscriberOperationCompleted = new SendOrPostCallback(this.OnregisterAgentEventSubscriberOperationCompleted);
      this.InvokeAsync("registerAgentEventSubscriber", new object[1]
      {
        (object) agentName
      }, this.registerAgentEventSubscriberOperationCompleted, userState);
    }

    private void OnregisterAgentEventSubscriberOperationCompleted(object arg)
    {
      if (this.registerAgentEventSubscriberCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.registerAgentEventSubscriberCompleted((object) this, new registerAgentEventSubscriberCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
    }

    [SoapRpcMethod("", RequestNamespace = "http://EventService.UD.concerto.com", ResponseNamespace = "http://EventService.UD.concerto.com")]
    [return: SoapElement("registerAlertEventSubscriberReturn")]
    public int registerAlertEventSubscriber() => (int) this.Invoke(nameof (registerAlertEventSubscriber), new object[0])[0];

    public IAsyncResult BeginregisterAlertEventSubscriber(
      AsyncCallback callback,
      object asyncState)
    {
      return this.BeginInvoke("registerAlertEventSubscriber", new object[0], callback, asyncState);
    }

    public int EndregisterAlertEventSubscriber(IAsyncResult asyncResult) => (int) this.EndInvoke(asyncResult)[0];

    public void registerAlertEventSubscriberAsync() => this.registerAlertEventSubscriberAsync((object) null);

    public void registerAlertEventSubscriberAsync(object userState)
    {
      if (this.registerAlertEventSubscriberOperationCompleted == null)
        this.registerAlertEventSubscriberOperationCompleted = new SendOrPostCallback(this.OnregisterAlertEventSubscriberOperationCompleted);
      this.InvokeAsync("registerAlertEventSubscriber", new object[0], this.registerAlertEventSubscriberOperationCompleted, userState);
    }

    private void OnregisterAlertEventSubscriberOperationCompleted(object arg)
    {
      if (this.registerAlertEventSubscriberCompleted == null)
        return;
      InvokeCompletedEventArgs completedEventArgs = (InvokeCompletedEventArgs) arg;
      this.registerAlertEventSubscriberCompleted((object) this, new registerAlertEventSubscriberCompletedEventArgs(completedEventArgs.Results, completedEventArgs.Error, completedEventArgs.Cancelled, completedEventArgs.UserState));
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
