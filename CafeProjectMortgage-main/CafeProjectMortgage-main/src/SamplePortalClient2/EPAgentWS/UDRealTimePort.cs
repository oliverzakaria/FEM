// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDRealTimePort
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
  public class UDRealTimePort
  {
    private int agentIndexField;
    private int alawMuLawField;
    private int codecIdField;
    private int echoCancelField;
    private string ipAddressField;
    private int ipPrecedenceField;
    private int jitterBufMinDelayField;
    private int payloadBytesField;
    private int rfu1Field;
    private int rfu2Field;
    private int rfu3Field;
    private int rfu4Field;
    private int rfu5Field;
    private int rtpPortField;
    private int rtpRedundancyField;
    private int silenceCompressionField;
    private int typeOfServiceField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int alawMuLaw
    {
      get => this.alawMuLawField;
      set => this.alawMuLawField = value;
    }

    public int codecId
    {
      get => this.codecIdField;
      set => this.codecIdField = value;
    }

    public int echoCancel
    {
      get => this.echoCancelField;
      set => this.echoCancelField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress
    {
      get => this.ipAddressField;
      set => this.ipAddressField = value;
    }

    public int ipPrecedence
    {
      get => this.ipPrecedenceField;
      set => this.ipPrecedenceField = value;
    }

    public int jitterBufMinDelay
    {
      get => this.jitterBufMinDelayField;
      set => this.jitterBufMinDelayField = value;
    }

    public int payloadBytes
    {
      get => this.payloadBytesField;
      set => this.payloadBytesField = value;
    }

    public int rfu1
    {
      get => this.rfu1Field;
      set => this.rfu1Field = value;
    }

    public int rfu2
    {
      get => this.rfu2Field;
      set => this.rfu2Field = value;
    }

    public int rfu3
    {
      get => this.rfu3Field;
      set => this.rfu3Field = value;
    }

    public int rfu4
    {
      get => this.rfu4Field;
      set => this.rfu4Field = value;
    }

    public int rfu5
    {
      get => this.rfu5Field;
      set => this.rfu5Field = value;
    }

    public int rtpPort
    {
      get => this.rtpPortField;
      set => this.rtpPortField = value;
    }

    public int rtpRedundancy
    {
      get => this.rtpRedundancyField;
      set => this.rtpRedundancyField = value;
    }

    public int silenceCompression
    {
      get => this.silenceCompressionField;
      set => this.silenceCompressionField = value;
    }

    public int typeOfService
    {
      get => this.typeOfServiceField;
      set => this.typeOfServiceField = value;
    }
  }
}
