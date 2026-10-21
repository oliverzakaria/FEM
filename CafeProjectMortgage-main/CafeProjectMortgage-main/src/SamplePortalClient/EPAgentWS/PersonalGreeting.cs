// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.PersonalGreeting
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
  public class PersonalGreeting
  {
    private string fileNameField;
    private string pgDescriptionField;
    private int pgIdField;
    private string pgInstructionsField;
    private string pgNameField;
    private string recordingCommentField;
    private int recordingIdField;
    private string userIdField;

    [SoapElement(IsNullable = true)]
    public string fileName
    {
      get => this.fileNameField;
      set => this.fileNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string pgDescription
    {
      get => this.pgDescriptionField;
      set => this.pgDescriptionField = value;
    }

    public int pgId
    {
      get => this.pgIdField;
      set => this.pgIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string pgInstructions
    {
      get => this.pgInstructionsField;
      set => this.pgInstructionsField = value;
    }

    [SoapElement(IsNullable = true)]
    public string pgName
    {
      get => this.pgNameField;
      set => this.pgNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recordingComment
    {
      get => this.recordingCommentField;
      set => this.recordingCommentField = value;
    }

    public int recordingId
    {
      get => this.recordingIdField;
      set => this.recordingIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }
  }
}
