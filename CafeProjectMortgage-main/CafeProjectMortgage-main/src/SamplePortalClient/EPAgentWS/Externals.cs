// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Externals
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
  public class Externals
  {
    private string externalroutedescField;
    private int externalrouteidField;
    private int externalroutetypeField;
    private string phonenumField;
    private int routeaccessidField;
    private int serviceidField;
    private string useridField;

    [SoapElement(IsNullable = true)]
    public string externalroutedesc
    {
      get => this.externalroutedescField;
      set => this.externalroutedescField = value;
    }

    public int externalrouteid
    {
      get => this.externalrouteidField;
      set => this.externalrouteidField = value;
    }

    public int externalroutetype
    {
      get => this.externalroutetypeField;
      set => this.externalroutetypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phonenum
    {
      get => this.phonenumField;
      set => this.phonenumField = value;
    }

    public int routeaccessid
    {
      get => this.routeaccessidField;
      set => this.routeaccessidField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }
  }
}
