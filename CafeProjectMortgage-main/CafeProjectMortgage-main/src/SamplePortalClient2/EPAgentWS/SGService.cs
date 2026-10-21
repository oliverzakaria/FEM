// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGService
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
  [SoapType(Namespace = "http://recmanWS.epro.concerto.com")]
  [Serializable]
  public class SGService
  {
    private string serviceDescriptionField;
    private int serviceIDField;

    [SoapElement(IsNullable = true)]
    public string serviceDescription
    {
      get => this.serviceDescriptionField;
      set => this.serviceDescriptionField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }
  }
}
