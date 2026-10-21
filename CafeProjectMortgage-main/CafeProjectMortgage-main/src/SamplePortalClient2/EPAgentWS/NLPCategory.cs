// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.NLPCategory
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
  [SoapType(Namespace = "http://KBase.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class NLPCategory
  {
    private string uRLField;
    private string answerField;
    private int answerIDField;
    private string questionField;
    private int questionIDField;
    private int rankField;
    private string summaryField;

    [SoapElement(IsNullable = true)]
    public string URL
    {
      get => this.uRLField;
      set => this.uRLField = value;
    }

    [SoapElement(IsNullable = true)]
    public string answer
    {
      get => this.answerField;
      set => this.answerField = value;
    }

    public int answerID
    {
      get => this.answerIDField;
      set => this.answerIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string question
    {
      get => this.questionField;
      set => this.questionField = value;
    }

    public int questionID
    {
      get => this.questionIDField;
      set => this.questionIDField = value;
    }

    public int rank
    {
      get => this.rankField;
      set => this.rankField = value;
    }

    [SoapElement(IsNullable = true)]
    public string summary
    {
      get => this.summaryField;
      set => this.summaryField = value;
    }
  }
}
