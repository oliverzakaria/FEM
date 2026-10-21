// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDChatEntitySendText
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
  public class UDChatEntitySendText
  {
    private int callIdField;
    private int entityField;
    private string entityNameField;
    private string textField;
    private int textLengthField;

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    public int entity
    {
      get => this.entityField;
      set => this.entityField = value;
    }

    [SoapElement(IsNullable = true)]
    public string entityName
    {
      get => this.entityNameField;
      set => this.entityNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string text
    {
      get => this.textField;
      set => this.textField = value;
    }

    public int textLength
    {
      get => this.textLengthField;
      set => this.textLengthField = value;
    }
  }
}
