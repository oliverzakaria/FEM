// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDMonitorState
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
  [SoapType(Namespace = "http://Notify.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDMonitorState
  {
    private int agentIndexField;
    private string ipAddressField;
    private int monitoringSeqField;
    private int monitoringStateField;
    private int portNumField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress
    {
      get => this.ipAddressField;
      set => this.ipAddressField = value;
    }

    public int monitoringSeq
    {
      get => this.monitoringSeqField;
      set => this.monitoringSeqField = value;
    }

    public int monitoringState
    {
      get => this.monitoringStateField;
      set => this.monitoringStateField = value;
    }

    public int portNum
    {
      get => this.portNumField;
      set => this.portNumField = value;
    }
  }
}
