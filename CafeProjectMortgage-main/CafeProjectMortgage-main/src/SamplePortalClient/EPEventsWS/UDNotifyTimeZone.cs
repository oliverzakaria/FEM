// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDNotifyTimeZone
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
  public class UDNotifyTimeZone
  {
    private int dSTOff_GMTField;
    private int dSTOff_MonthField;
    private int dSTOff_StartDayField;
    private int dSTOn_DayofWeekField;
    private int dSTOn_GMTField;
    private int dSTOn_MonthField;
    private int dSTOn_StartDayField;
    private int dST_ObservedField;
    private int gMT_OffsetField;
    private string identifierField;
    private int timeZoneIDField;

    public int DSTOff_GMT
    {
      get => this.dSTOff_GMTField;
      set => this.dSTOff_GMTField = value;
    }

    public int DSTOff_Month
    {
      get => this.dSTOff_MonthField;
      set => this.dSTOff_MonthField = value;
    }

    public int DSTOff_StartDay
    {
      get => this.dSTOff_StartDayField;
      set => this.dSTOff_StartDayField = value;
    }

    public int DSTOn_DayofWeek
    {
      get => this.dSTOn_DayofWeekField;
      set => this.dSTOn_DayofWeekField = value;
    }

    public int DSTOn_GMT
    {
      get => this.dSTOn_GMTField;
      set => this.dSTOn_GMTField = value;
    }

    public int DSTOn_Month
    {
      get => this.dSTOn_MonthField;
      set => this.dSTOn_MonthField = value;
    }

    public int DSTOn_StartDay
    {
      get => this.dSTOn_StartDayField;
      set => this.dSTOn_StartDayField = value;
    }

    public int DST_Observed
    {
      get => this.dST_ObservedField;
      set => this.dST_ObservedField = value;
    }

    public int GMT_Offset
    {
      get => this.gMT_OffsetField;
      set => this.gMT_OffsetField = value;
    }

    [SoapElement(IsNullable = true)]
    public string identifier
    {
      get => this.identifierField;
      set => this.identifierField = value;
    }

    public int timeZoneID
    {
      get => this.timeZoneIDField;
      set => this.timeZoneIDField = value;
    }
  }
}
