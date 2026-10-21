// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDUpdateService
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Notify.EventService.UD.concerto.com")]
  [Serializable]
  public class UDUpdateService
  {
    private int agentIndexField;
    private UDNotifyCallDataDefFields[] callDataDefFieldsField;
    private UDNotifyDispositions[] dispositionsField;
    private int serviceIDField;
    private UDNotifyService serviceInfoField;
    private UDNotifyServiceSettings serviceSettingsField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyCallDataDefFields[] callDataDefFields
    {
      get => this.callDataDefFieldsField;
      set => this.callDataDefFieldsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyDispositions[] dispositions
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
