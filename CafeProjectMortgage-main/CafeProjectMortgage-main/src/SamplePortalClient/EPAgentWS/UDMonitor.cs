// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDMonitor
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
  public class UDMonitor
  {
    private string agentIDField;
    private int agentIndexField;
    private string agentStationIDField;
    private int monitoringIDField;
    private string monitoringStationIDField;
    private int requestTypeField;

    [SoapElement(IsNullable = true)]
    public string agentID
    {
      get => this.agentIDField;
      set => this.agentIDField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentStationID
    {
      get => this.agentStationIDField;
      set => this.agentStationIDField = value;
    }

    public int monitoringID
    {
      get => this.monitoringIDField;
      set => this.monitoringIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string monitoringStationID
    {
      get => this.monitoringStationIDField;
      set => this.monitoringStationIDField = value;
    }

    public int requestType
    {
      get => this.requestTypeField;
      set => this.requestTypeField = value;
    }
  }
}
