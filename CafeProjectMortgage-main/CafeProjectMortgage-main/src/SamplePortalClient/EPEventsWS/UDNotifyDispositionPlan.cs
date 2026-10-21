// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDNotifyDispositionPlan
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
  public class UDNotifyDispositionPlan
  {
    private string descField;
    private int dispidField;
    private int dispplanidField;

    [SoapElement(IsNullable = true)]
    public string desc
    {
      get => this.descField;
      set => this.descField = value;
    }

    public int dispid
    {
      get => this.dispidField;
      set => this.dispidField = value;
    }

    public int dispplanid
    {
      get => this.dispplanidField;
      set => this.dispplanidField = value;
    }
  }
}
