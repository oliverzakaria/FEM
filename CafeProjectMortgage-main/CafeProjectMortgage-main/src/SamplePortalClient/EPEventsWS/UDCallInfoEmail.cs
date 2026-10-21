// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallInfoEmail
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
  public class UDCallInfoEmail
  {
    private string forwardToMBoxField;
    private string fromAddressField;
    private int mailQueIdField;
    private int messageIdField;
    private string senderCCField;
    private string senderDateTimeField;
    private string senderNameField;
    private string senderToField;

    [SoapElement(IsNullable = true)]
    public string forwardToMBox
    {
      get => this.forwardToMBoxField;
      set => this.forwardToMBoxField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fromAddress
    {
      get => this.fromAddressField;
      set => this.fromAddressField = value;
    }

    public int mailQueId
    {
      get => this.mailQueIdField;
      set => this.mailQueIdField = value;
    }

    public int messageId
    {
      get => this.messageIdField;
      set => this.messageIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string senderCC
    {
      get => this.senderCCField;
      set => this.senderCCField = value;
    }

    [SoapElement(IsNullable = true)]
    public string senderDateTime
    {
      get => this.senderDateTimeField;
      set => this.senderDateTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string senderName
    {
      get => this.senderNameField;
      set => this.senderNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string senderTo
    {
      get => this.senderToField;
      set => this.senderToField = value;
    }
  }
}
