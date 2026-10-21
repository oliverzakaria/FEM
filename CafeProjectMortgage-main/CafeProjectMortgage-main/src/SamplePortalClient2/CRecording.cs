// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CRecording
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CRecording
  {
    private CApp mpApp;
    private CAgent mpAgent;
    private UDRecorderData param = new UDRecorderData();
    private AgentWebServiceService oAgentWS = new AgentWebServiceService();
    private static LogFile logFile = new LogFile();
    private string sRecordStationID;
    private string sAgentStationID;
    private int iCallID;
    private string sRecorderID;
    private string sAgentId;
    private string sRecordStatus = string.Empty;
    private string sCustomerName = string.Empty;
    private string sPhoneNumber;
    private int iServiceID = -1;
    private int iRecordSeqNo = 0;

    public CRecording(CAgent pAgent, CApp pApp)
    {
      this.mpApp = pApp;
      this.mpAgent = pAgent;
      if (this.mpApp.CurrentCall == null)
        return;
      this.iCallID = this.mpApp.CurrentCall.callID;
      this.sAgentStationID = this.mpApp.CurrentAgent.Station;
      this.sRecordStationID = this.mpApp.CurrentAgent.Station;
      this.sAgentId = this.mpAgent.AgentId;
      this.sRecorderID = this.mpAgent.AgentId;
      this.sPhoneNumber = this.mpApp.CurrentCall.phoneNumber;
      this.iServiceID = this.mpApp.CurrentCall.serviceID;
    }

    public void StartRecord()
    {
      try
      {
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.StartRecord(), Recording is initiated. ");
        this.param.requestType = 100;
        this.param.callID = this.iCallID;
        this.param.recorderStation = this.sRecordStationID;
        this.param.agentStation = this.sAgentStationID;
        this.param.recorderId = this.sRecorderID;
        this.param.agentId = this.sAgentId;
        this.param.status = "Record";
        this.param.audio_f = 1;
        this.param.custName = this.sCustomerName;
        this.param.phone1 = this.sPhoneNumber;
        this.param.serviceId = this.iServiceID;
        this.oAgentWS.record(this.mpAgent.AgentArg, this.param);
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.StartRecord(), Recording is completed. ");
      }
      catch (Exception ex)
      {
        CRecording.logFile.LogMessageToFile(" |ERROR| CRecording.StartRecord(), Recording is failed.  " + ex.StackTrace.ToString());
      }
    }

    public void PauseRecording()
    {
      try
      {
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.PauseRecord(), PauseRecording is initiated. ");
        this.param.status = "Pause";
        this.param.requestType = 207;
        this.param.callID = this.iCallID;
        this.param.seqNumber = this.iRecordSeqNo;
        this.oAgentWS.record(this.mpAgent.AgentArg, this.param);
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.PauseRecord(), PauseRecording is completed. ");
      }
      catch (Exception ex)
      {
        CRecording.logFile.LogMessageToFile(" |ERROR| CRecording.PauseRecord(), PauseRecording is failed. " + ex.StackTrace.ToString());
      }
    }

    public void ResumeRecording()
    {
      try
      {
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.ResumeRecording(), Resume Recording is initiated. ");
        this.param.status = "Resume record";
        this.param.requestType = 208;
        this.param.callID = this.iCallID;
        this.param.seqNumber = this.iRecordSeqNo;
        this.oAgentWS.record(this.mpAgent.AgentArg, this.param);
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.ResumeRecording(), Resume Recording is completed. ");
      }
      catch (Exception ex)
      {
        CRecording.logFile.LogMessageToFile(" |ERROR| CRecording.ResumeRecording(), Resume Recording is failed. " + ex.StackTrace.ToString());
      }
    }

    public void StopRecording()
    {
      try
      {
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.StopRecording(), Stop Recording is initiated. ");
        this.param.status = "Stop";
        this.param.requestType = 200;
        this.param.callID = this.iCallID;
        this.param.seqNumber = this.iRecordSeqNo;
        this.oAgentWS.record(this.mpAgent.AgentArg, this.param);
        CRecording.logFile.LogMessageToFile(" |INFO| CRecording.StopRecording(), Stop Recording is completed. ");
      }
      catch (Exception ex)
      {
        CRecording.logFile.LogMessageToFile(" |ERROR| CRecording.StopRecording(), Stop Recording is failed. " + ex.StackTrace.ToString());
      }
    }
  }
}
