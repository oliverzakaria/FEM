// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Server
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
  public class Server
  {
    private string descriptionField;
    private int idField;
    private string ipAddressField;
    private string machineNameField;
    private string nameField;
    private int portNumberField;
    private int secureDataTransmissionEnabledField;
    private ServerType serverTypeField;
    private Site siteField;
    private int value1Field;
    private int value2Field;
    private string value3Field;
    private string value4Field;

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress
    {
      get => this.ipAddressField;
      set => this.ipAddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string machineName
    {
      get => this.machineNameField;
      set => this.machineNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int portNumber
    {
      get => this.portNumberField;
      set => this.portNumberField = value;
    }

    public int secureDataTransmissionEnabled
    {
      get => this.secureDataTransmissionEnabledField;
      set => this.secureDataTransmissionEnabledField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServerType serverType
    {
      get => this.serverTypeField;
      set => this.serverTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public Site site
    {
      get => this.siteField;
      set => this.siteField = value;
    }

    public int value1
    {
      get => this.value1Field;
      set => this.value1Field = value;
    }

    public int value2
    {
      get => this.value2Field;
      set => this.value2Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string value3
    {
      get => this.value3Field;
      set => this.value3Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string value4
    {
      get => this.value4Field;
      set => this.value4Field = value;
    }
  }
}
