// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDEMailServiceStatistics
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
  public class UDEMailServiceStatistics
  {
    private int numberOfEmailsInPendingProcessQField;
    private int numberOfEmailsInReviewQField;
    private int queuIdField;
    private string queueNameField;
    private int serviceIDField;

    public int numberOfEmailsInPendingProcessQ
    {
      get => this.numberOfEmailsInPendingProcessQField;
      set => this.numberOfEmailsInPendingProcessQField = value;
    }

    public int numberOfEmailsInReviewQ
    {
      get => this.numberOfEmailsInReviewQField;
      set => this.numberOfEmailsInReviewQField = value;
    }

    public int queuId
    {
      get => this.queuIdField;
      set => this.queuIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string queueName
    {
      get => this.queueNameField;
      set => this.queueNameField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }
  }
}
