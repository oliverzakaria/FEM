// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.ServerSettings
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
  [SoapType(Namespace = "http://Lookup.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class ServerSettings
  {
    private int? debugLevelField;
    private int? logFileSizeField;
    private string machineNameField;
    private int? numLogFilesField;
    private int? portNumberField;
    private int? secureDataTransmissionEnabledField;
    private int? serverIdField;
    private string serverNameField;
    private int? serverTypeField;
    private int? siteIdField;

    [SoapElement(IsNullable = true)]
    public int? debugLevel
    {
      get => this.debugLevelField;
      set => this.debugLevelField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? logFileSize
    {
      get => this.logFileSizeField;
      set => this.logFileSizeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string machineName
    {
      get => this.machineNameField;
      set => this.machineNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? numLogFiles
    {
      get => this.numLogFilesField;
      set => this.numLogFilesField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? portNumber
    {
      get => this.portNumberField;
      set => this.portNumberField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? secureDataTransmissionEnabled
    {
      get => this.secureDataTransmissionEnabledField;
      set => this.secureDataTransmissionEnabledField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? serverId
    {
      get => this.serverIdField;
      set => this.serverIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string serverName
    {
      get => this.serverNameField;
      set => this.serverNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? serverType
    {
      get => this.serverTypeField;
      set => this.serverTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? siteId
    {
      get => this.siteIdField;
      set => this.siteIdField = value;
    }
  }
}
