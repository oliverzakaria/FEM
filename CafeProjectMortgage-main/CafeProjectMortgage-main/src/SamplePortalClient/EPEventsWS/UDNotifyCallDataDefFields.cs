// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDNotifyCallDataDefFields
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
  public class UDNotifyCallDataDefFields
  {
    private int calldatadefidField;
    private int fieldorderField;
    private string fieldtypeField;
    private string labelField;
    private int mediatypeidField;
    private string reservedwordField;

    public int calldatadefid
    {
      get => this.calldatadefidField;
      set => this.calldatadefidField = value;
    }

    public int fieldorder
    {
      get => this.fieldorderField;
      set => this.fieldorderField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fieldtype
    {
      get => this.fieldtypeField;
      set => this.fieldtypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string label
    {
      get => this.labelField;
      set => this.labelField = value;
    }

    public int mediatypeid
    {
      get => this.mediatypeidField;
      set => this.mediatypeidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string reservedword
    {
      get => this.reservedwordField;
      set => this.reservedwordField = value;
    }
  }
}
