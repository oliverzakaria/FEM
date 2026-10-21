// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDNewService
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
  public class UDNewService
  {
    private int agentIndexField;
    private UDNotifyCallDataDef callDataDefField;
    private int[] callDataDefFieldsField;
    private UDNotifyDispositionPlan dispositionPlanField;
    private int[] dispositionsField;
    private int serviceIDField;
    private UDNotifyService serviceInfoField;
    private UDNotifyServiceSettings serviceSettingsField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyCallDataDef callDataDef
    {
      get => this.callDataDefField;
      set => this.callDataDefField = value;
    }

    [SoapElement(IsNullable = true)]
    public int[] callDataDefFields
    {
      get => this.callDataDefFieldsField;
      set => this.callDataDefFieldsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyDispositionPlan dispositionPlan
    {
      get => this.dispositionPlanField;
      set => this.dispositionPlanField = value;
    }

    [SoapElement(IsNullable = true)]
    public int[] dispositions
    {
      get => this.dispositionsField;
      set => this.dispositionsField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyService serviceInfo
    {
      get => this.serviceInfoField;
      set => this.serviceInfoField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyServiceSettings serviceSettings
    {
      get => this.serviceSettingsField;
      set => this.serviceSettingsField = value;
    }
  }
}
