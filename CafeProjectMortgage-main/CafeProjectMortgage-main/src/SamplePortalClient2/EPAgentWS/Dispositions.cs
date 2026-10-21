// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Dispositions
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
  public class Dispositions
  {
    private int callbackfField;
    private string codeField;
    private string descriptionField;
    private int dispidField;
    private int dispplanidField;
    private int exclusionfField;
    private int salesfField;

    public int callbackf
    {
      get => this.callbackfField;
      set => this.callbackfField = value;
    }

    [SoapElement(IsNullable = true)]
    public string code
    {
      get => this.codeField;
      set => this.codeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
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

    public int exclusionf
    {
      get => this.exclusionfField;
      set => this.exclusionfField = value;
    }

    public int salesf
    {
      get => this.salesfField;
      set => this.salesfField = value;
    }
  }
}
