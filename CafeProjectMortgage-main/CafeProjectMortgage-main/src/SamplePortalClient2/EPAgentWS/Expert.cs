// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Expert
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
  [SoapType(Namespace = "http://AspectUnifiedIPExpertQueryServiceCommon.07.2004.schemas.datacontract.org")]
  [Serializable]
  public class Expert
  {
    private string[] documentLinkField;
    private string firstNameField;
    private string lastNameField;
    private string[] phoneNumbersField;
    private double? relevanceField;
    private bool relevanceFieldSpecified;
    private string sipUriField;
    private string sourceField;
    private string userIdField;
    private string workgroupIdField;

    [SoapElement(IsNullable = true)]
    public string[] DocumentLink
    {
      get => this.documentLinkField;
      set => this.documentLinkField = value;
    }

    [SoapElement(IsNullable = true)]
    public string FirstName
    {
      get => this.firstNameField;
      set => this.firstNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string LastName
    {
      get => this.lastNameField;
      set => this.lastNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string[] PhoneNumbers
    {
      get => this.phoneNumbersField;
      set => this.phoneNumbersField = value;
    }

    [SoapElement(IsNullable = true)]
    public double? Relevance
    {
      get => this.relevanceField;
      set => this.relevanceField = value;
    }

    [SoapIgnore]
    public bool RelevanceSpecified
    {
      get => this.relevanceFieldSpecified;
      set => this.relevanceFieldSpecified = value;
    }

    [SoapElement(IsNullable = true)]
    public string SipUri
    {
      get => this.sipUriField;
      set => this.sipUriField = value;
    }

    [SoapElement(IsNullable = true)]
    public string Source
    {
      get => this.sourceField;
      set => this.sourceField = value;
    }

    [SoapElement(IsNullable = true)]
    public string UserId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string WorkgroupId
    {
      get => this.workgroupIdField;
      set => this.workgroupIdField = value;
    }
  }
}
