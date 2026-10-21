// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UserLocale
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
  [SoapType(Namespace = "http://User.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class UserLocale
  {
    private string languageField;
    private int? localeIdField;
    private int? subLocaleIdField;
    private string user_IdField;

    [SoapElement(IsNullable = true)]
    public string language
    {
      get => this.languageField;
      set => this.languageField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? localeId
    {
      get => this.localeIdField;
      set => this.localeIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? subLocaleId
    {
      get => this.subLocaleIdField;
      set => this.subLocaleIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string user_Id
    {
      get => this.user_IdField;
      set => this.user_IdField = value;
    }
  }
}
