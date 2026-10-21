// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.LoggedInUsersIM
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
  public class LoggedInUsersIM
  {
    private string emailAddressField;
    private string firstNameField;
    private string homePhoneNumberField;
    private string imURLField;
    private string lastNameField;
    private string mobilePhoneNumberField;
    private string officePhoneNumberField;
    private string userIdField;
    private int userTypeField;

    [SoapElement(IsNullable = true)]
    public string emailAddress
    {
      get => this.emailAddressField;
      set => this.emailAddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string firstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string homePhoneNumber
    {
      get => this.homePhoneNumberField;
      set => this.homePhoneNumberField = value;
    }

    [SoapElement(IsNullable = true)]
    public string imURL
    {
      get => this.imURLField;
      set => this.imURLField = value;
    }

    [SoapElement(IsNullable = true)]
    public string lastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string mobilePhoneNumber
    {
      get => this.mobilePhoneNumberField;
      set => this.mobilePhoneNumberField = value;
    }

    [SoapElement(IsNullable = true)]
    public string officePhoneNumber
    {
      get => this.officePhoneNumberField;
      set => this.officePhoneNumberField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    public int userType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }
  }
}
