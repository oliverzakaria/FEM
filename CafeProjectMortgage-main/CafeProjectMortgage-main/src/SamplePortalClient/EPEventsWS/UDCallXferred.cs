// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDCallXferred
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Notify.EventService.UD.concerto.com")]
  [Serializable]
  public class UDCallXferred
  {
    private int agentIndexField;
    private int consultCallIDField;
    private int newCallIDField;
    private int originalAgentIndexField;
    private int originalCallIDField;
    private int statusReasonField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int consultCallID
    {
      get => this.consultCallIDField;
      set => this.consultCallIDField = value;
    }

    public int newCallID
    {
      get => this.newCallIDField;
      set => this.newCallIDField = value;
    }

    public int originalAgentIndex
    {
      get => this.originalAgentIndexField;
      set => this.originalAgentIndexField = value;
    }

    public int originalCallID
    {
      get => this.originalCallIDField;
      set => this.originalCallIDField = value;
    }

    public int statusReason
    {
      get => this.statusReasonField;
      set => this.statusReasonField = value;
    }
  }
}
