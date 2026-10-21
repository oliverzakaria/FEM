// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Attachemnts
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
  [SoapType(Namespace = "http://Agent.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class Attachemnts
  {
    private string createddtField;
    private string filenameField;
    private string filesizeField;
    private string filesummaryField;

    [SoapElement(IsNullable = true)]
    public string createddt
    {
      get => this.createddtField;
      set => this.createddtField = value;
    }

    [SoapElement(IsNullable = true)]
    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string filesize
    {
      get => this.filesizeField;
      set => this.filesizeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string filesummary
    {
      get => this.filesummaryField;
      set => this.filesummaryField = value;
    }
  }
}
