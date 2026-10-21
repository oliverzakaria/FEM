// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDForwardEmail
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
  public class UDForwardEmail
  {
    private string agentIdField;
    private int callIdField;
    private string externalEmailField;
    private int forwardServiceIdField;
    private int forwardTypeField;
    private string fromAddressField;
    private int messageIdField;
    private int queueIdField;
    private int serviceIdField;
    private UDCallInfoUserDefinedIn userDefinedDataField;

    [SoapElement(IsNullable = true)]
    public string agentId
    {
      get => this.agentIdField;
      set => this.agentIdField = value;
    }

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string externalEmail
    {
      get => this.externalEmailField;
      set => this.externalEmailField = value;
    }

    public int forwardServiceId
    {
      get => this.forwardServiceIdField;
      set => this.forwardServiceIdField = value;
    }

    public int forwardType
    {
      get => this.forwardTypeField;
      set => this.forwardTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fromAddress
    {
      get => this.fromAddressField;
      set => this.fromAddressField = value;
    }

    public int messageId
    {
      get => this.messageIdField;
      set => this.messageIdField = value;
    }

    public int queueId
    {
      get => this.queueIdField;
      set => this.queueIdField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefinedIn userDefinedData
    {
      get => this.userDefinedDataField;
      set => this.userDefinedDataField = value;
    }
  }
}
