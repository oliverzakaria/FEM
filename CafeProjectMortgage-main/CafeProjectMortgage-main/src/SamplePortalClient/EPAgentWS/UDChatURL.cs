// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDChatURL
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
  public class UDChatURL
  {
    private int callIdField;
    private int chatserverCSLPortField;
    private string chatserverIPField;
    private string urlField;

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    public int chatserverCSLPort
    {
      get => this.chatserverCSLPortField;
      set => this.chatserverCSLPortField = value;
    }

    [SoapElement(IsNullable = true)]
    public string chatserverIP
    {
      get => this.chatserverIPField;
      set => this.chatserverIPField = value;
    }

    [SoapElement(IsNullable = true)]
    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }
  }
}
