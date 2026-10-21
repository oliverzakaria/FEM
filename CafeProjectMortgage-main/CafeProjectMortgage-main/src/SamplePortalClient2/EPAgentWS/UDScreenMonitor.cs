// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDScreenMonitor
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPAgentWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Client.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDScreenMonitor
  {
    private int callIdField;
    private int funcCodeField;
    private string monitorAgentIpField;
    private string recordingKeyField;
    private int seqNumField;
    private int serverIdField;
    private int serviceIdField;
    private int siteIdField;
    private int statusField;
    private int tenantIdField;
    private int videoBytesField;
    private int videoSecsField;
    private string videoStartDtField;

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    public int funcCode
    {
      get => this.funcCodeField;
      set => this.funcCodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string monitorAgentIp
    {
      get => this.monitorAgentIpField;
      set => this.monitorAgentIpField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recordingKey
    {
      get => this.recordingKeyField;
      set => this.recordingKeyField = value;
    }

    public int seqNum
    {
      get => this.seqNumField;
      set => this.seqNumField = value;
    }

    public int serverId
    {
      get => this.serverIdField;
      set => this.serverIdField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    public int siteId
    {
      get => this.siteIdField;
      set => this.siteIdField = value;
    }

    public int status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    public int tenantId
    {
      get => this.tenantIdField;
      set => this.tenantIdField = value;
    }

    public int videoBytes
    {
      get => this.videoBytesField;
      set => this.videoBytesField = value;
    }

    public int videoSecs
    {
      get => this.videoSecsField;
      set => this.videoSecsField = value;
    }

    [SoapElement(IsNullable = true)]
    public string videoStartDt
    {
      get => this.videoStartDtField;
      set => this.videoStartDtField = value;
    }
  }
}
