// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.AgentKWUserInfo
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
  public class AgentKWUserInfo
  {
    private string kwIMConnectSIPURLField;
    private string kwLastAccessedTimeField;
    private string kwPhoneNumberField;
    private string kwuserIdField;
    private string skillidsField;
    private string userIdField;
    private string userfnameField;
    private string userlnameField;
    private int workgroupIdField;

    [SoapElement(IsNullable = true)]
    public string kwIMConnectSIPURL
    {
      get => this.kwIMConnectSIPURLField;
      set => this.kwIMConnectSIPURLField = value;
    }

    [SoapElement(IsNullable = true)]
    public string kwLastAccessedTime
    {
      get => this.kwLastAccessedTimeField;
      set => this.kwLastAccessedTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string kwPhoneNumber
    {
      get => this.kwPhoneNumberField;
      set => this.kwPhoneNumberField = value;
    }

    [SoapElement(IsNullable = true)]
    public string kwuserId
    {
      get => this.kwuserIdField;
      set => this.kwuserIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string skillids
    {
      get => this.skillidsField;
      set => this.skillidsField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userfname
    {
      get => this.userfnameField;
      set => this.userfnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userlname
    {
      get => this.userlnameField;
      set => this.userlnameField = value;
    }

    public int workgroupId
    {
      get => this.workgroupIdField;
      set => this.workgroupIdField = value;
    }
  }
}
