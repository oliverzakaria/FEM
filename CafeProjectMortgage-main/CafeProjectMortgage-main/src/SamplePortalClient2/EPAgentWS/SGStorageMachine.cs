// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGStorageMachine
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
  public class SGStorageMachine
  {
    private string iPAddressField;
    private string nTNameField;
    private string descriptionField;
    private string nameField;
    private int onNetworkField;
    private Server serverField;
    private SGSite siteField;
    private int storageMachineIDField;
    private SGStorageMachineType storageMachineTypeField;
    private Tenant tenantField;

    [SoapElement(IsNullable = true)]
    public string IPAddress
    {
      get => this.iPAddressField;
      set => this.iPAddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string NTName
    {
      get => this.nTNameField;
      set => this.nTNameField = value;
    }

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

    public int onNetwork
    {
      get => this.onNetworkField;
      set => this.onNetworkField = value;
    }

    [SoapElement(IsNullable = true)]
    public Server server
    {
      get => this.serverField;
      set => this.serverField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGSite site
    {
      get => this.siteField;
      set => this.siteField = value;
    }

    public int storageMachineID
    {
      get => this.storageMachineIDField;
      set => this.storageMachineIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGStorageMachineType storageMachineType
    {
      get => this.storageMachineTypeField;
      set => this.storageMachineTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public Tenant tenant
    {
      get => this.tenantField;
      set => this.tenantField = value;
    }
  }
}
