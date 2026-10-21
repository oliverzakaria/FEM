// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDScreenPop
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
  public class UDScreenPop
  {
    private int agentIndexField;
    private int callIDField;
    private UDCallInfo callInfoField;
    private string originalServiceNameField;
    private int pbxaodserviceidField;
    private bool playAudioAlertField;
    private int preemptiveField;
    private bool requiredRejectReasonField;
    private bool requiredResponseField;
    private string serviceNameField;
    private int statusReasonField;
    private int switchCallIDField;
    private int timeoutForAcceptCallField;
    private int timeoutForAudioAlertField;

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

    public int pbxaodserviceid
    {
      get => this.pbxaodserviceidField;
      set => this.pbxaodserviceidField = value;
    }

    public bool playAudioAlert
    {
      get => this.playAudioAlertField;
      set => this.playAudioAlertField = value;
    }

    public int preemptive
    {
      get => this.preemptiveField;
      set => this.preemptiveField = value;
    }

    public bool requiredRejectReason
    {
      get => this.requiredRejectReasonField;
      set => this.requiredRejectReasonField = value;
    }

    public bool requiredResponse
    {
      get => this.requiredResponseField;
      set => this.requiredResponseField = value;
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

    public int switchCallID
    {
      get => this.switchCallIDField;
      set => this.switchCallIDField = value;
    }

    public int timeoutForAcceptCall
    {
      get => this.timeoutForAcceptCallField;
      set => this.timeoutForAcceptCallField = value;
    }

    public int timeoutForAudioAlert
    {
      get => this.timeoutForAudioAlertField;
      set => this.timeoutForAudioAlertField = value;
    }
  }
}
