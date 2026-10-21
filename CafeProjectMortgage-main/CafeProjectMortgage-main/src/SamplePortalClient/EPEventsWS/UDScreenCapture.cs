// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDScreenCapture
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Notify.EventService.UD.concerto.com")]
  [Serializable]
  public class UDScreenCapture
  {
    private int agentIndexField;
    private string agentStationField;
    private int callIdField;
    private int funcCodeField;
    private string keyField;
    private string monitorAgentIpField;
    private int seqNumField;
    private int serverIdField;
    private int serviceIdField;
    private int siteIdField;
    private int statusField;
    private int supervisorIndexField;
    private string supervisorStationField;
    private int tenantIdField;
    private string urlField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentStation
    {
      get => this.agentStationField;
      set => this.agentStationField = value;
    }

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
    public string key
    {
      get => this.keyField;
      set => this.keyField = value;
    }

    [SoapElement(IsNullable = true)]
    public string monitorAgentIp
    {
      get => this.monitorAgentIpField;
      set => this.monitorAgentIpField = value;
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

    public int supervisorIndex
    {
      get => this.supervisorIndexField;
      set => this.supervisorIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string supervisorStation
    {
      get => this.supervisorStationField;
      set => this.supervisorStationField = value;
    }

    public int tenantId
    {
      get => this.tenantIdField;
      set => this.tenantIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
