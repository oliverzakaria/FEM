// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDKWInfo
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
  public class UDKWInfo
  {
    private string kWUserIdField;
    private int kWWorkGroupIdField;
    private string sessionIdField;
    private int sessionTypeField;
    private string sipURIField;

    [SoapElement(IsNullable = true)]
    public string KWUserId
    {
      get => this.kWUserIdField;
      set => this.kWUserIdField = value;
    }

    public int KWWorkGroupId
    {
      get => this.kWWorkGroupIdField;
      set => this.kWWorkGroupIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string sessionId
    {
      get => this.sessionIdField;
      set => this.sessionIdField = value;
    }

    public int sessionType
    {
      get => this.sessionTypeField;
      set => this.sessionTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string sipURI
    {
      get => this.sipURIField;
      set => this.sipURIField = value;
    }
  }
}
