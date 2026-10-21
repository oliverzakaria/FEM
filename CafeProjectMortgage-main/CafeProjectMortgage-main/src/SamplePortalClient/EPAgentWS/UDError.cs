// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDError
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
  public class UDError
  {
    private int agentIndexField;
    private int callIDField;
    private int currentLicenseCountField;
    private int eventCodeField;
    private int failCodeField;
    private string failReasonField;
    private int licensedCountField;
    private string localizedFailReasonField;
    private int mboxField;
    private int serviceIdField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    public int currentLicenseCount
    {
      get => this.currentLicenseCountField;
      set => this.currentLicenseCountField = value;
    }

    public int eventCode
    {
      get => this.eventCodeField;
      set => this.eventCodeField = value;
    }

    public int failCode
    {
      get => this.failCodeField;
      set => this.failCodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string failReason
    {
      get => this.failReasonField;
      set => this.failReasonField = value;
    }

    public int licensedCount
    {
      get => this.licensedCountField;
      set => this.licensedCountField = value;
    }

    [SoapElement(IsNullable = true)]
    public string localizedFailReason
    {
      get => this.localizedFailReasonField;
      set => this.localizedFailReasonField = value;
    }

    public int mbox
    {
      get => this.mboxField;
      set => this.mboxField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }
  }
}
