// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.IPNIQNodeDetail
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
  [SoapType(Namespace = "http://Tables.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class IPNIQNodeDetail
  {
    private string uCCUIPTargetSystemIDField;
    private string uIPTargetNameField;
    private string backupProvisioningServerIPField;
    private int backupProvisioningServerPortField;
    private string nameField;
    private int numberField;
    private string primaryProvisioningServerIPField;
    private int primaryProvisioningServerPortField;
    private int secureDataTransmissionField;
    private int siteIdField;
    private int tenantIdField;

    [SoapElement(IsNullable = true)]
    public string UCCUIPTargetSystemID
    {
      get => this.uCCUIPTargetSystemIDField;
      set => this.uCCUIPTargetSystemIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string UIPTargetName
    {
      get => this.uIPTargetNameField;
      set => this.uIPTargetNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string backupProvisioningServerIP
    {
      get => this.backupProvisioningServerIPField;
      set => this.backupProvisioningServerIPField = value;
    }

    public int backupProvisioningServerPort
    {
      get => this.backupProvisioningServerPortField;
      set => this.backupProvisioningServerPortField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int number
    {
      get => this.numberField;
      set => this.numberField = value;
    }

    [SoapElement(IsNullable = true)]
    public string primaryProvisioningServerIP
    {
      get => this.primaryProvisioningServerIPField;
      set => this.primaryProvisioningServerIPField = value;
    }

    public int primaryProvisioningServerPort
    {
      get => this.primaryProvisioningServerPortField;
      set => this.primaryProvisioningServerPortField = value;
    }

    public int secureDataTransmission
    {
      get => this.secureDataTransmissionField;
      set => this.secureDataTransmissionField = value;
    }

    public int siteId
    {
      get => this.siteIdField;
      set => this.siteIdField = value;
    }

    public int tenantId
    {
      get => this.tenantIdField;
      set => this.tenantIdField = value;
    }
  }
}
