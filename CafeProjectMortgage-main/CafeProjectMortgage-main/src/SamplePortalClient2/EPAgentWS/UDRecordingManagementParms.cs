// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDRecordingManagementParms
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
  public class UDRecordingManagementParms
  {
    private string agentField;
    private int autoInitField;
    private int beginMediaSeqField;
    private int bitsPerSampleField;
    private int broadcastField;
    private int callIDField;
    private string calledPartyField;
    private string callingPartyField;
    private string callingPartyNameField;
    private int catalogIDField;
    private string commentField;
    private string customerNameField;
    private string dateRangeFromField;
    private string dateRangeToField;
    private int dateRangeTypeField;
    private int dispositionCodeField;
    private string dnisField;
    private int durationField;
    private int encodingField;
    private int fileFormatField;
    private string fileNameField;
    private int fileSizeField;
    private int fileSizeIdField;
    private int fileTypeField;
    private int greetingIdField;
    private long handleField;
    private int hasVideoField;
    private int isMergedFileField;
    private string key1Field;
    private string key2Field;
    private string key3Field;
    private int locationField;
    private string mailBoxField;
    private long mediaRecordingsHandleField;
    private int mediaSeqField;
    private int mediaTypeField;
    private int modeField;
    private int monitorClassField;
    private int numberOfRecordingsField;
    private int pageNumField;
    private int recFormatIDField;
    private int recStoreIDField;
    private string recorderField;
    private int recorderIDField;
    private int recordingIDField;
    private int recordingIdField;
    private int recordingManagementTypeField;
    private int rowCountField;
    private int samplingRateField;
    private int samplingSizeField;
    private int scoredField;
    private int screenAvailField;
    private int serviceField;
    private int siteField;
    private int sortFilterField;
    private int storageMachineTypeField;
    private int tenantIDField;
    private int timezoneIdField;
    private int totalBytesField;
    private string urlField;
    private string user1Field;
    private string user10Field;
    private string user11Field;
    private string user12Field;
    private string user13Field;
    private string user14Field;
    private string user15Field;
    private string user16Field;
    private string user17Field;
    private string user18Field;
    private string user19Field;
    private string user2Field;
    private string user20Field;
    private string user3Field;
    private string user4Field;
    private string user5Field;
    private string user6Field;
    private string user7Field;
    private string user8Field;
    private string user9Field;
    private string userIDField;
    private int userTypeField;
    private int vmGroupField;
    private int workgroupField;

    [SoapElement(IsNullable = true)]
    public string agent
    {
      get => this.agentField;
      set => this.agentField = value;
    }

    public int autoInit
    {
      get => this.autoInitField;
      set => this.autoInitField = value;
    }

    public int beginMediaSeq
    {
      get => this.beginMediaSeqField;
      set => this.beginMediaSeqField = value;
    }

    public int bitsPerSample
    {
      get => this.bitsPerSampleField;
      set => this.bitsPerSampleField = value;
    }

    public int broadcast
    {
      get => this.broadcastField;
      set => this.broadcastField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string calledParty
    {
      get => this.calledPartyField;
      set => this.calledPartyField = value;
    }

    [SoapElement(IsNullable = true)]
    public string callingParty
    {
      get => this.callingPartyField;
      set => this.callingPartyField = value;
    }

    [SoapElement(IsNullable = true)]
    public string callingPartyName
    {
      get => this.callingPartyNameField;
      set => this.callingPartyNameField = value;
    }

    public int catalogID
    {
      get => this.catalogIDField;
      set => this.catalogIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    [SoapElement(IsNullable = true)]
    public string customerName
    {
      get => this.customerNameField;
      set => this.customerNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dateRangeFrom
    {
      get => this.dateRangeFromField;
      set => this.dateRangeFromField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dateRangeTo
    {
      get => this.dateRangeToField;
      set => this.dateRangeToField = value;
    }

    public int dateRangeType
    {
      get => this.dateRangeTypeField;
      set => this.dateRangeTypeField = value;
    }

    public int dispositionCode
    {
      get => this.dispositionCodeField;
      set => this.dispositionCodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dnis
    {
      get => this.dnisField;
      set => this.dnisField = value;
    }

    public int duration
    {
      get => this.durationField;
      set => this.durationField = value;
    }

    public int encoding
    {
      get => this.encodingField;
      set => this.encodingField = value;
    }

    public int fileFormat
    {
      get => this.fileFormatField;
      set => this.fileFormatField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fileName
    {
      get => this.fileNameField;
      set => this.fileNameField = value;
    }

    public int fileSize
    {
      get => this.fileSizeField;
      set => this.fileSizeField = value;
    }

    public int fileSizeId
    {
      get => this.fileSizeIdField;
      set => this.fileSizeIdField = value;
    }

    public int fileType
    {
      get => this.fileTypeField;
      set => this.fileTypeField = value;
    }

    public int greetingId
    {
      get => this.greetingIdField;
      set => this.greetingIdField = value;
    }

    public long handle
    {
      get => this.handleField;
      set => this.handleField = value;
    }

    public int hasVideo
    {
      get => this.hasVideoField;
      set => this.hasVideoField = value;
    }

    public int isMergedFile
    {
      get => this.isMergedFileField;
      set => this.isMergedFileField = value;
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

    public int location
    {
      get => this.locationField;
      set => this.locationField = value;
    }

    [SoapElement(IsNullable = true)]
    public string mailBox
    {
      get => this.mailBoxField;
      set => this.mailBoxField = value;
    }

    public long mediaRecordingsHandle
    {
      get => this.mediaRecordingsHandleField;
      set => this.mediaRecordingsHandleField = value;
    }

    public int mediaSeq
    {
      get => this.mediaSeqField;
      set => this.mediaSeqField = value;
    }

    public int mediaType
    {
      get => this.mediaTypeField;
      set => this.mediaTypeField = value;
    }

    public int mode
    {
      get => this.modeField;
      set => this.modeField = value;
    }

    public int monitorClass
    {
      get => this.monitorClassField;
      set => this.monitorClassField = value;
    }

    public int numberOfRecordings
    {
      get => this.numberOfRecordingsField;
      set => this.numberOfRecordingsField = value;
    }

    public int pageNum
    {
      get => this.pageNumField;
      set => this.pageNumField = value;
    }

    public int recFormatID
    {
      get => this.recFormatIDField;
      set => this.recFormatIDField = value;
    }

    public int recStoreID
    {
      get => this.recStoreIDField;
      set => this.recStoreIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recorder
    {
      get => this.recorderField;
      set => this.recorderField = value;
    }

    public int recorderID
    {
      get => this.recorderIDField;
      set => this.recorderIDField = value;
    }

    public int recordingID
    {
      get => this.recordingIDField;
      set => this.recordingIDField = value;
    }

    public int recordingId
    {
      get => this.recordingIdField;
      set => this.recordingIdField = value;
    }

    public int recordingManagementType
    {
      get => this.recordingManagementTypeField;
      set => this.recordingManagementTypeField = value;
    }

    public int rowCount
    {
      get => this.rowCountField;
      set => this.rowCountField = value;
    }

    public int samplingRate
    {
      get => this.samplingRateField;
      set => this.samplingRateField = value;
    }

    public int samplingSize
    {
      get => this.samplingSizeField;
      set => this.samplingSizeField = value;
    }

    public int scored
    {
      get => this.scoredField;
      set => this.scoredField = value;
    }

    public int screenAvail
    {
      get => this.screenAvailField;
      set => this.screenAvailField = value;
    }

    public int service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    public int site
    {
      get => this.siteField;
      set => this.siteField = value;
    }

    public int sortFilter
    {
      get => this.sortFilterField;
      set => this.sortFilterField = value;
    }

    public int storageMachineType
    {
      get => this.storageMachineTypeField;
      set => this.storageMachineTypeField = value;
    }

    public int tenantID
    {
      get => this.tenantIDField;
      set => this.tenantIDField = value;
    }

    public int timezoneId
    {
      get => this.timezoneIdField;
      set => this.timezoneIdField = value;
    }

    public int totalBytes
    {
      get => this.totalBytesField;
      set => this.totalBytesField = value;
    }

    [SoapElement(IsNullable = true)]
    public string url
    {
      get => this.urlField;
      set => this.urlField = value;
    }

    [SoapElement(IsNullable = true)]
    public string user1
    {
      get => this.user1Field;
      set => this.user1Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user10
    {
      get => this.user10Field;
      set => this.user10Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user11
    {
      get => this.user11Field;
      set => this.user11Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user12
    {
      get => this.user12Field;
      set => this.user12Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user13
    {
      get => this.user13Field;
      set => this.user13Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user14
    {
      get => this.user14Field;
      set => this.user14Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user15
    {
      get => this.user15Field;
      set => this.user15Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user16
    {
      get => this.user16Field;
      set => this.user16Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user17
    {
      get => this.user17Field;
      set => this.user17Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user18
    {
      get => this.user18Field;
      set => this.user18Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user19
    {
      get => this.user19Field;
      set => this.user19Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user2
    {
      get => this.user2Field;
      set => this.user2Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user20
    {
      get => this.user20Field;
      set => this.user20Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user3
    {
      get => this.user3Field;
      set => this.user3Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user4
    {
      get => this.user4Field;
      set => this.user4Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user5
    {
      get => this.user5Field;
      set => this.user5Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user6
    {
      get => this.user6Field;
      set => this.user6Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user7
    {
      get => this.user7Field;
      set => this.user7Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user8
    {
      get => this.user8Field;
      set => this.user8Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string user9
    {
      get => this.user9Field;
      set => this.user9Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string userID
    {
      get => this.userIDField;
      set => this.userIDField = value;
    }

    public int userType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }

    public int vmGroup
    {
      get => this.vmGroupField;
      set => this.vmGroupField = value;
    }

    public int workgroup
    {
      get => this.workgroupField;
      set => this.workgroupField = value;
    }
  }
}
