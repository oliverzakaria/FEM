// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDDirectorAck
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
  public class UDDirectorAck
  {
    private string ackDataField;
    private int directorIdField;

    [SoapElement(IsNullable = true)]
    public string ackData
    {
      get => this.ackDataField;
      set => this.ackDataField = value;
    }

    public int directorId
    {
      get => this.directorIdField;
      set => this.directorIdField = value;
    }
  }
}
