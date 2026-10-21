// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallInfoOther
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
  public class UDCallInfoOther
  {
    private int callCategoryField;
    private int callIDField;
    private int callTypeField;
    private int eventCodeField;
    private int originalServiceIDField;
    private int serviceIDField;
    private int timeZoneIDField;

    public int callCategory
    {
      get => this.callCategoryField;
      set => this.callCategoryField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    public int callType
    {
      get => this.callTypeField;
      set => this.callTypeField = value;
    }

    public int eventCode
    {
      get => this.eventCodeField;
      set => this.eventCodeField = value;
    }

    public int originalServiceID
    {
      get => this.originalServiceIDField;
      set => this.originalServiceIDField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }

    public int timeZoneID
    {
      get => this.timeZoneIDField;
      set => this.timeZoneIDField = value;
    }
  }
}
