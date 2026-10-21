// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDPreview
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
  public class UDPreview
  {
    private int callIDField;
    private UDCallInfo callInfoField;
    private string originalServiceNameField;
    private int preemptiveField;
    private string serviceNameField;
    private int statusReasonField;

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfo callInfo
    {
      get => this.callInfoField;
      set => this.callInfoField = value;
    }

    [SoapElement(IsNullable = true)]
    public string originalServiceName
    {
      get => this.originalServiceNameField;
      set => this.originalServiceNameField = value;
    }

    public int preemptive
    {
      get => this.preemptiveField;
      set => this.preemptiveField = value;
    }

    [SoapElement(IsNullable = true)]
    public string serviceName
    {
      get => this.serviceNameField;
      set => this.serviceNameField = value;
    }

    public int statusReason
    {
      get => this.statusReasonField;
      set => this.statusReasonField = value;
    }
  }
}
