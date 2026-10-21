// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDForwardEmailAck
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
  public class UDForwardEmailAck
  {
    private int agentIndexField;
    private int callIdField;
    private int messageIdField;
    private int queueIdField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    public int messageId
    {
      get => this.messageIdField;
      set => this.messageIdField = value;
    }

    public int queueId
    {
      get => this.queueIdField;
      set => this.queueIdField = value;
    }
  }
}
