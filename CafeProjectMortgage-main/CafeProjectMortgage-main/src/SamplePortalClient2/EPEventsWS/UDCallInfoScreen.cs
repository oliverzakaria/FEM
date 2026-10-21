// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallInfoScreen
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
  public class UDCallInfoScreen
  {
    private string aniField;
    private string callerIDField;
    private string dnisField;
    private string firstNameField;
    private string lastNameField;
    private string phoneNumberField;

    [SoapElement(IsNullable = true)]
    public string ani
    {
      get => this.aniField;
      set => this.aniField = value;
    }

    [SoapElement(IsNullable = true)]
    public string callerID
    {
      get => this.callerIDField;
      set => this.callerIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dnis
    {
      get => this.dnisField;
      set => this.dnisField = value;
    }

    [SoapElement(IsNullable = true)]
    public string firstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string lastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phoneNumber
    {
      get => this.phoneNumberField;
      set => this.phoneNumberField = value;
    }
  }
}
