// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallInfo
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
  public class UDCallInfo
  {
    private UDCallInfoAod aodDataField;
    private UDCallInfoCallback callbackDataField;
    private UDCallInfoEmail emailDataField;
    private UDCallInfoOther otherDataField;
    private UDCallInfoScreen screenDataField;
    private UDCallInfoUserDefined userDefinedDataField;

    [SoapElement(IsNullable = true)]
    public UDCallInfoAod aodData
    {
      get => this.aodDataField;
      set => this.aodDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoCallback callbackData
    {
      get => this.callbackDataField;
      set => this.callbackDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoEmail emailData
    {
      get => this.emailDataField;
      set => this.emailDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoOther otherData
    {
      get => this.otherDataField;
      set => this.otherDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoScreen screenData
    {
      get => this.screenDataField;
      set => this.screenDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefined userDefinedData
    {
      get => this.userDefinedDataField;
      set => this.userDefinedDataField = value;
    }
  }
}
