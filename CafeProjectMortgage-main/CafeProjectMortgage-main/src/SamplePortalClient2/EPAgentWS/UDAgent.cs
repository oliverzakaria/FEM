// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDAgent
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
  public class UDAgent
  {
    private string lDAPUserIdField;
    private int agentIndexField;
    private string agentLoginNameField;
    private int clientRoleField;
    private int initStateField;
    private int serverTypeField;

    [SoapElement(IsNullable = true)]
    public string LDAPUserId
    {
      get => this.lDAPUserIdField;
      set => this.lDAPUserIdField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentLoginName
    {
      get => this.agentLoginNameField;
      set => this.agentLoginNameField = value;
    }

    public int clientRole
    {
      get => this.clientRoleField;
      set => this.clientRoleField = value;
    }

    public int initState
    {
      get => this.initStateField;
      set => this.initStateField = value;
    }

    public int serverType
    {
      get => this.serverTypeField;
      set => this.serverTypeField = value;
    }
  }
}
