// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDNotifyService
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
  public class UDNotifyService
  {
    private int dispplanidField;
    private int outgoingmaskField;
    private string servicecField;
    private int serviceidField;
    private int servicetypeidField;
    private int timezoneidField;

    public int dispplanid
    {
      get => this.dispplanidField;
      set => this.dispplanidField = value;
    }

    public int outgoingmask
    {
      get => this.outgoingmaskField;
      set => this.outgoingmaskField = value;
    }

    [SoapElement(IsNullable = true)]
    public string servicec
    {
      get => this.servicecField;
      set => this.servicecField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    public int servicetypeid
    {
      get => this.servicetypeidField;
      set => this.servicetypeidField = value;
    }

    public int timezoneid
    {
      get => this.timezoneidField;
      set => this.timezoneidField = value;
    }
  }
}
