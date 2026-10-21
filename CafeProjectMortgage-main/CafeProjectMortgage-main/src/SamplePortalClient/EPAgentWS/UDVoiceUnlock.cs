// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDVoiceUnlock
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
  [SoapType(Namespace = "http://Notify.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDVoiceUnlock
  {
    private int agentIndexField;
    private int callIDField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }
  }
}
