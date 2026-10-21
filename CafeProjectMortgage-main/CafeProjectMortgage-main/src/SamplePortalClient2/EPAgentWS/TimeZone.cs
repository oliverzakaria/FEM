// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.TimeZone
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
  [SoapType(Namespace = "http://System.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class TimeZone
  {
    private int? dstObservedField;
    private int? endDayField;
    private int? endDayofWeekField;
    private int? endMonthField;
    private int? endTimeField;
    private int? gmtoffsetField;
    private int? idField;
    private string identifierField;
    private string nanptimezoneidField;
    private int? startDayField;
    private int? startDayofWeekField;
    private int? startMonthField;
    private int? startTimeField;
    private int? systemDefaultField;
    private string timezonedescField;

    [SoapElement(IsNullable = true)]
    public int? dstObserved
    {
      get => this.dstObservedField;
      set => this.dstObservedField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? endDay
    {
      get => this.endDayField;
      set => this.endDayField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? endDayofWeek
    {
      get => this.endDayofWeekField;
      set => this.endDayofWeekField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? endMonth
    {
      get => this.endMonthField;
      set => this.endMonthField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? endTime
    {
      get => this.endTimeField;
      set => this.endTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? gmtoffset
    {
      get => this.gmtoffsetField;
      set => this.gmtoffsetField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [SoapElement(IsNullable = true)]
    public string identifier
    {
      get => this.identifierField;
      set => this.identifierField = value;
    }

    [SoapElement(IsNullable = true)]
    public string nanptimezoneid
    {
      get => this.nanptimezoneidField;
      set => this.nanptimezoneidField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? startDay
    {
      get => this.startDayField;
      set => this.startDayField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? startDayofWeek
    {
      get => this.startDayofWeekField;
      set => this.startDayofWeekField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? startMonth
    {
      get => this.startMonthField;
      set => this.startMonthField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? startTime
    {
      get => this.startTimeField;
      set => this.startTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? systemDefault
    {
      get => this.systemDefaultField;
      set => this.systemDefaultField = value;
    }

    [SoapElement(IsNullable = true)]
    public string timezonedesc
    {
      get => this.timezonedescField;
      set => this.timezonedescField = value;
    }
  }
}
