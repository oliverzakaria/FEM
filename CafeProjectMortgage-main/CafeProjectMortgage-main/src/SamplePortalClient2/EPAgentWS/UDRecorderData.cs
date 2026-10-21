// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDRecorderData
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
  public class UDRecorderData
  {
    private int vCIField;
    private int vPIField;
    private string agentIdField;
    private string agentStationField;
    private int audio_fField;
    private int bitsPerSampleField;
    private int callIDField;
    private string custNameField;
    private int dualRec_fField;
    private int durationField;
    private string fileNameField;
    private int fileTypeIdField;
    private string key1Field;
    private string key2Field;
    private string key3Field;
    private string lastUpdateDtField;
    private int monitorClassIdField;
    private string phone1Field;
    private int recStoreIdField;
    private int recordFormatIdField;
    private int recordRateField;
    private string recorderIdField;
    private string recorderStationField;
    private int recordingIndexField;
    private int recordingTypeIdField;
    private int requestTypeField;
    private int samplingRateField;
    private int seqNumberField;
    private int serviceIdField;
    private int startPositionField;
    private string statusField;
    private int video_fField;

    public int VCI
    {
      get => this.vCIField;
      set => this.vCIField = value;
    }

    public int VPI
    {
      get => this.vPIField;
      set => this.vPIField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentId
    {
      get => this.agentIdField;
      set => this.agentIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentStation
    {
      get => this.agentStationField;
      set => this.agentStationField = value;
    }

    public int audio_f
    {
      get => this.audio_fField;
      set => this.audio_fField = value;
    }

    public int bitsPerSample
    {
      get => this.bitsPerSampleField;
      set => this.bitsPerSampleField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string custName
    {
      get => this.custNameField;
      set => this.custNameField = value;
    }

    public int dualRec_f
    {
      get => this.dualRec_fField;
      set => this.dualRec_fField = value;
    }

    public int duration
    {
      get => this.durationField;
      set => this.durationField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fileName
    {
      get => this.fileNameField;
      set => this.fileNameField = value;
    }

    public int fileTypeId
    {
      get => this.fileTypeIdField;
      set => this.fileTypeIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string key1
    {
      get => this.key1Field;
      set => this.key1Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string key2
    {
      get => this.key2Field;
      set => this.key2Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string key3
    {
      get => this.key3Field;
      set => this.key3Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string lastUpdateDt
    {
      get => this.lastUpdateDtField;
      set => this.lastUpdateDtField = value;
    }

    public int monitorClassId
    {
      get => this.monitorClassIdField;
      set => this.monitorClassIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phone1
    {
      get => this.phone1Field;
      set => this.phone1Field = value;
    }

    public int recStoreId
    {
      get => this.recStoreIdField;
      set => this.recStoreIdField = value;
    }

    public int recordFormatId
    {
      get => this.recordFormatIdField;
      set => this.recordFormatIdField = value;
    }

    public int recordRate
    {
      get => this.recordRateField;
      set => this.recordRateField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recorderId
    {
      get => this.recorderIdField;
      set => this.recorderIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recorderStation
    {
      get => this.recorderStationField;
      set => this.recorderStationField = value;
    }

    public int recordingIndex
    {
      get => this.recordingIndexField;
      set => this.recordingIndexField = value;
    }

    public int recordingTypeId
    {
      get => this.recordingTypeIdField;
      set => this.recordingTypeIdField = value;
    }

    public int requestType
    {
      get => this.requestTypeField;
      set => this.requestTypeField = value;
    }

    public int samplingRate
    {
      get => this.samplingRateField;
      set => this.samplingRateField = value;
    }

    public int seqNumber
    {
      get => this.seqNumberField;
      set => this.seqNumberField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    public int startPosition
    {
      get => this.startPositionField;
      set => this.startPositionField = value;
    }

    [SoapElement(IsNullable = true)]
    public string status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    public int video_f
    {
      get => this.video_fField;
      set => this.video_fField = value;
    }
  }
}
