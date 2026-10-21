// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDRecordState
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
  public class UDRecordState
  {
    private int agentIndexField;
    private int autoRecordingField;
    private string fileNameField;
    private int mediaTypeField;
    private int recordingIndexField;
    private int recordingRateField;
    private int recordingSeqField;
    private int recordingStateField;
    private int recordingStoreIdField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int autoRecording
    {
      get => this.autoRecordingField;
      set => this.autoRecordingField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fileName
    {
      get => this.fileNameField;
      set => this.fileNameField = value;
    }

    public int mediaType
    {
      get => this.mediaTypeField;
      set => this.mediaTypeField = value;
    }

    public int recordingIndex
    {
      get => this.recordingIndexField;
      set => this.recordingIndexField = value;
    }

    public int recordingRate
    {
      get => this.recordingRateField;
      set => this.recordingRateField = value;
    }

    public int recordingSeq
    {
      get => this.recordingSeqField;
      set => this.recordingSeqField = value;
    }

    public int recordingState
    {
      get => this.recordingStateField;
      set => this.recordingStateField = value;
    }

    public int recordingStoreId
    {
      get => this.recordingStoreIdField;
      set => this.recordingStoreIdField = value;
    }
  }
}
