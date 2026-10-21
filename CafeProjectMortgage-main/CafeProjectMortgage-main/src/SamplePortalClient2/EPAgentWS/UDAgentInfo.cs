// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDAgentInfo
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
  [SoapType(Namespace = "http://Client.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDAgentInfo
  {
    private string aTMAddressField;
    private int agentIndexField;
    private string agentLoginNameField;
    private string agentMboxField;
    private int agentRouteAccessIDField;
    private int agentTypeField;
    private int agentVCIField;
    private int agentVPIField;
    private int agentWorkgroupIDField;
    private int codecField;
    private string errorMessageField;
    private string firstNameField;
    private string ipAddressField;
    private string lastNameField;
    private string loginTypeField;
    private int ntSwitchIDField;
    private string passcodeField;
    private string passwordField;
    private int payloadLengthField;
    private int referenceIDField;
    private int rtpPortField;
    private int serverTypeField;
    private string stationIdField;

    [SoapElement(IsNullable = true)]
    public string ATMAddress
    {
      get => this.aTMAddressField;
      set => this.aTMAddressField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentLoginName
    {
      get => this.agentLoginNameField;
      set => this.agentLoginNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentMbox
    {
      get => this.agentMboxField;
      set => this.agentMboxField = value;
    }

    public int agentRouteAccessID
    {
      get => this.agentRouteAccessIDField;
      set => this.agentRouteAccessIDField = value;
    }

    public int agentType
    {
      get => this.agentTypeField;
      set => this.agentTypeField = value;
    }

    public int agentVCI
    {
      get => this.agentVCIField;
      set => this.agentVCIField = value;
    }

    public int agentVPI
    {
      get => this.agentVPIField;
      set => this.agentVPIField = value;
    }

    public int agentWorkgroupID
    {
      get => this.agentWorkgroupIDField;
      set => this.agentWorkgroupIDField = value;
    }

    public int codec
    {
      get => this.codecField;
      set => this.codecField = value;
    }

    [SoapElement(IsNullable = true)]
    public string errorMessage
    {
      get => this.errorMessageField;
      set => this.errorMessageField = value;
    }

    [SoapElement(IsNullable = true)]
    public string firstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress
    {
      get => this.ipAddressField;
      set => this.ipAddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string lastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string loginType
    {
      get => this.loginTypeField;
      set => this.loginTypeField = value;
    }

    public int ntSwitchID
    {
      get => this.ntSwitchIDField;
      set => this.ntSwitchIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string passcode
    {
      get => this.passcodeField;
      set => this.passcodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public int payloadLength
    {
      get => this.payloadLengthField;
      set => this.payloadLengthField = value;
    }

    public int referenceID
    {
      get => this.referenceIDField;
      set => this.referenceIDField = value;
    }

    public int rtpPort
    {
      get => this.rtpPortField;
      set => this.rtpPortField = value;
    }

    public int serverType
    {
      get => this.serverTypeField;
      set => this.serverTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string stationId
    {
      get => this.stationIdField;
      set => this.stationIdField = value;
    }
  }
}
