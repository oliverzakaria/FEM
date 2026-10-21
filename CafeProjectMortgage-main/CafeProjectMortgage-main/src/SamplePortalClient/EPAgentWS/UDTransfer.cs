// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDTransfer
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
  public class UDTransfer
  {
    private UDCallInfoUserDefinedIn callInfoUserDefinedField;
    private int conferenceCallIDField;
    private int originalCallIDField;
    private int serviceIDField;
    private int thirdParyCallIDField;
    private int transferTypeField;

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefinedIn callInfoUserDefined
    {
      get => this.callInfoUserDefinedField;
      set => this.callInfoUserDefinedField = value;
    }

    public int conferenceCallID
    {
      get => this.conferenceCallIDField;
      set => this.conferenceCallIDField = value;
    }

    public int originalCallID
    {
      get => this.originalCallIDField;
      set => this.originalCallIDField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }

    public int thirdParyCallID
    {
      get => this.thirdParyCallIDField;
      set => this.thirdParyCallIDField = value;
    }

    public int transferType
    {
      get => this.transferTypeField;
      set => this.transferTypeField = value;
    }
  }
}
