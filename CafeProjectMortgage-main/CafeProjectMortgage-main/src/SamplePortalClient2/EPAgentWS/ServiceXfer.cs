// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.ServiceXfer
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
  public class ServiceXfer
  {
    private string emailAddressField;
    private string servicecField;
    private int serviceidField;
    private int servicetypeidField;
    private string useridField;
    private int xferlisttypeField;

    [SoapElement(IsNullable = true)]
    public string emailAddress
    {
      get => this.emailAddressField;
      set => this.emailAddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string servicec
    {
      get => this.servicecField;
      set => this.servicecField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    public int servicetypeid
    {
      get => this.servicetypeidField;
      set => this.servicetypeidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }

    public int xferlisttype
    {
      get => this.xferlisttypeField;
      set => this.xferlisttypeField = value;
    }
  }
}
