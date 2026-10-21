// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGRecStoreType
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
  [SoapType(Namespace = "http://concerto.com/epro/recmanWS")]
  [Serializable]
  public class SGRecStoreType
  {
    private string descriptionField;
    private string nameField;
    private int recStoreTypeIDField;

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int recStoreTypeID
    {
      get => this.recStoreTypeIDField;
      set => this.recStoreTypeIDField = value;
    }
  }
}
