// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.AgentEvent
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
  public class AgentEvent
  {
    private string agentIdField;
    private int agentIndexField;
    private string eventDescriptionField;
    private int eventIdField;
    private long eventTimestampField;
    private object payloadField;

    [SoapElement(IsNullable = true)]
    public string agentId
    {
      get => this.agentIdField;
      set => this.agentIdField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string eventDescription
    {
      get => this.eventDescriptionField;
      set => this.eventDescriptionField = value;
    }

    public int eventId
    {
      get => this.eventIdField;
      set => this.eventIdField = value;
    }

    public long eventTimestamp
    {
      get => this.eventTimestampField;
      set => this.eventTimestampField = value;
    }

    [SoapElement(IsNullable = true)]
    public object payload
    {
      get => this.payloadField;
      set => this.payloadField = value;
    }
  }
}
