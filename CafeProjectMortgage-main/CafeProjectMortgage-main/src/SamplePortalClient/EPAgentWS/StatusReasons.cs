// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.StatusReasons
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
  public class StatusReasons
  {
    private int agentstatusidField;
    private string descriptionField;
    private int reasonidField;

    public int agentstatusid
    {
      get => this.agentstatusidField;
      set => this.agentstatusidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public int reasonid
    {
      get => this.reasonidField;
      set => this.reasonidField = value;
    }
  }
}
