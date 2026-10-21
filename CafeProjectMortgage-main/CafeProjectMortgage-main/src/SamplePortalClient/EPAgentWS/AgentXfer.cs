// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.AgentXfer
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
  [SoapType(Namespace = "http://Agent.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class AgentXfer
  {
    private int agentindexField;
    private string emailAddressField;
    private int serviceidField;
    private string userfnameField;
    private string useridField;
    private string userlnameField;

    public int agentindex
    {
      get => this.agentindexField;
      set => this.agentindexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string emailAddress
    {
      get => this.emailAddressField;
      set => this.emailAddressField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userfname
    {
      get => this.userfnameField;
      set => this.userfnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userlname
    {
      get => this.userlnameField;
      set => this.userlnameField = value;
    }
  }
}
