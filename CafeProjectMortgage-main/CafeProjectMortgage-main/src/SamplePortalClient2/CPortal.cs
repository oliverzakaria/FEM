// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CPortal
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using SamplePortalClient.EPEventsWS;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace SamplePortalClient
{
  internal class CPortal
  {
    private System.Threading.Timer mpEventPollingTimer;
    private int miAgentIndex;
    private long mlLastEvent;
    public EventServiceService WSEvents;
    public AgentWebServiceService WSAgent;
    private LogFile logFile = new LogFile();

    public event EventArrivalHandler EventArrival;

    public CPortal()
    {
      this.logFile.LogMessageToFile("|INFO| CPortal.Constructor fired.", 1);
      this.WSEvents = new EventServiceService();
      this.WSAgent = new AgentWebServiceService();
      this.WSAgent.CookieContainer = new CookieContainer();
    }

    public void Register(UDAgent pAgent, UDAgentInfo pAgentInfo)
    {
      try
      {
        this.logFile.LogMessageToFile("|INFO| CPortal.Register() - Registration of User Started.", 1);
        Console.WriteLine("Registration of User Started.");
        this.miAgentIndex = this.WSEvents.registerAgentEventSubscriber(pAgent.agentLoginName);
        this.mpEventPollingTimer = new System.Threading.Timer(new TimerCallback(this.GetNextEvent), (object) this, 100, 100);
        this.WSAgent.register(pAgent, pAgentInfo);
        this.logFile.LogMessageToFile("|INFO| CPortal.Register() - Registration of User completed.", 1);
      }
      catch (Exception ex)
      {
        this.logFile.LogMessageToFile("|ERROR| CPortal.Register() - Registration of User failed." + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    public void RegisterEx(UDAgent pAgent, UDAgentInfo pAgentInfo, bool multiline)
    {
      try
      {
        this.logFile.LogMessageToFile("|INFO| CPortal.RegisterEx() - Registration of User Started.", 1);
        this.miAgentIndex = this.WSEvents.registerAgentEventSubscriber(pAgent.agentLoginName);
        this.mpEventPollingTimer = new System.Threading.Timer(new TimerCallback(this.GetNextEvent), (object) this, 100, 100);
        UDProperty[] features = new UDProperty[1];
        if (multiline)
        {
          features[0] = new UDProperty();
          features[0].name = "MultiLine";
          features[0].value = "true";
          this.logFile.LogMessageToFile("Call Service API registerEx() with Multiline is TRUE");
        }
        else
        {
          features[0] = new UDProperty();
          features[0].name = "MultiLine";
          features[0].value = "false";
          this.logFile.LogMessageToFile("Call Service API registerEx() with Multiline is FALSE");
        }
        this.WSAgent.registerEx(pAgent, pAgentInfo, features);
        this.logFile.LogMessageToFile("|INFO| CPortal.RegisterEx() - Registration of User completed.", 1);
      }
      catch (Exception ex)
      {
        AgentPortalException agentPortalException = new AgentPortalException();
        this.logFile.LogMessageToFile("|ERROR| CPortal.RegisterEx() - Registration of User failed." + ex.Message.ToString() + ex.StackTrace.ToString() + agentPortalException.concertoFaultCode.ToString() + agentPortalException.concertoFaultString.ToString());
      }
    }

    public void Unregister(UDAgent pAgent)
    {
      try
      {
        this.logFile.LogMessageToFile("|INFO| CPortal.Unregister() - Unregister with Agent Web Service.", 1);
        this.WSAgent.unRegister(pAgent);
        if (this.mpEventPollingTimer != null)
        {
          this.mpEventPollingTimer.Dispose();
          this.mpEventPollingTimer = (System.Threading.Timer) null;
        }
        if (this.miAgentIndex > 0)
          this.WSEvents.unregisterAgentEventSubscriber(this.miAgentIndex);
        this.logFile.LogMessageToFile("|INFO| CPortal.Unregister() - Unregister with Events Web Service.", 1);
      }
      catch (Exception ex)
      {
        this.logFile.LogMessageToFile("|ERROR| CPortal.Unregister() - Unregister with Events Web Service failed." + ex.Message.ToString() + ex.StackTrace.ToString());
      }
    }

    private void GetNextEvent(object state)
    {
      this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Get NextEvent started", 3);
      AgentEvent pNextEvent = (AgentEvent) null;
      try
      {
        if (this.mpEventPollingTimer == null)
          return;
        this.mpEventPollingTimer.Change(-1, -1);
        pNextEvent = this.WSEvents.getNextAgentEventAck(this.miAgentIndex, this.mlLastEvent);
        if (pNextEvent != null)
        {
          this.mlLastEvent = pNextEvent.eventTimestamp;
          this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - AWS Event: id<" + pNextEvent.eventId.ToString() + ">, payload<" + pNextEvent.payload.GetType()?.ToString() + ">", 3);
          this.OnEventArrival(new CEventArrivalArgs(pNextEvent));
        }
      }
      catch (Exception ex)
      {
        this.logFile.LogMessageToFile("|ERROR| CPortal.GetNextEvent() - Get NextEvent failed." + ex.Message.ToString() + ex.StackTrace.ToString());
        this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Showing message box to Exit the application");
        if (MessageBox.Show("Connection to the server lost.Please click OK to close the CAFE and try relogin again.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
        {
          this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Agent Clicked OK. Application Exit Process started.");
          Application.Exit();
          this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Agent Clicked OK. Application Exit Process Completed.");
        }
        else
          this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Agent Clicked Cancel. Process continues....");
      }
      finally
      {
        if (this.mpEventPollingTimer != null)
        {
          if (pNextEvent != null)
            this.mpEventPollingTimer.Change(0, -1);
          else
            this.mpEventPollingTimer.Change(100, -1);
        }
        this.logFile.LogMessageToFile("|INFO| CPortal.GetNextEvent() - Get NextEvent completed.", 3);
      }
    }

    protected virtual void OnEventArrival(CEventArrivalArgs pArgs)
    {
      this.logFile.LogMessageToFile("|INFO| CPortal.OnEventArrival() - On Event Arrival Event triggered.", 3);
      if (this.EventArrival == null)
        return;
      this.EventArrival((object) this, pArgs);
    }
  }
}
