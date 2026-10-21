// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGRecording
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
  [SoapType(Namespace = "http://recmanWS.epro.concerto.com")]
  [Serializable]
  public class SGRecording
  {
    private string aNIField;
    private int mBoxField;
    private string nTMachineNameField;
    private string nTShareNameField;
    private int accessedField;
    private string agentField;
    private int bitsPerSampleField;
    private int broadcastField;
    private int callIdField;
    private string calledPartyField;
    private string callingPartyField;
    private string catalogIDField;
    private string commentField;
    private string customerNameField;
    private DateTime? deleteDtField;
    private int dispositionCodeField;
    private string dispositionNameField;
    private string dnisField;
    private int durationField;
    private string fileNameField;
    private int fileSizeField;
    private int fileTypeField;
    private int forwardRouteActionField;
    private int fromMBoxIdField;
    private Site fromSiteField;
    private int groupIdField;
    private int hasVideoField;
    private int isMergedFileField;
    private string key1Field;
    private string key2Field;
    private string key3Field;
    private DateTime? lastAccessedDtField;
    private int mediaSeqField;
    private int mediaTypeField;
    private string msgFromField;
    private string notesField;
    private int numberOfRecordingsField;
    private string phoneNumberField;
    private int priorityField;
    private int recFormatIDField;
    private int recStoreIDField;
    private int recStoreIdField;
    private int recStoreTypeField;
    private string recStoreTypeNameField;
    private int recordRateField;
    private string recorderField;
    private int recorderIDField;
    private string recordingClassDescField;
    private int recordingClassIDField;
    private string recordingDateField;
    private int recordingIdField;
    private int recordingLengthField;
    private int samplingRateField;
    private string screenFileNameField;
    private int serviceField;
    private string serviceNameField;
    private int siteField;
    private int statusIdField;
    private int storageMacineIdField;
    private string subjectField;
    private int tamperedWithField;
    private int tenantIDField;
    private int totalBytesField;
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

    [SoapElement(IsNullable = true)]
    public string ANI
    {
      get => this.aNIField;
      set => this.aNIField = value;
    }

    public int MBox
    {
      get => this.mBoxField;
      set => this.mBoxField = value;
    }

    [SoapElement(IsNullable = true)]
    public string NTMachineName
    {
      get => this.nTMachineNameField;
      set => this.nTMachineNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string NTShareName
    {
      get => this.nTShareNameField;
      set => this.nTShareNameField = value;
    }

    public int accessed
    {
      get => this.accessedField;
      set => this.accessedField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agent
    {
      get => this.agentField;
      set => this.agentField = value;
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

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
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
    public string catalogID
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
    public DateTime? deleteDt
    {
      get => this.deleteDtField;
      set => this.deleteDtField = value;
    }

    public int dispositionCode
    {
      get => this.dispositionCodeField;
      set => this.dispositionCodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dispositionName
    {
      get => this.dispositionNameField;
      set => this.dispositionNameField = value;
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

    public int fileType
    {
      get => this.fileTypeField;
      set => this.fileTypeField = value;
    }

    public int forwardRouteAction
    {
      get => this.forwardRouteActionField;
      set => this.forwardRouteActionField = value;
    }

    public int fromMBoxId
    {
      get => this.fromMBoxIdField;
      set => this.fromMBoxIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public Site fromSite
    {
      get => this.fromSiteField;
      set => this.fromSiteField = value;
    }

    public int groupId
    {
      get => this.groupIdField;
      set => this.groupIdField = value;
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

    [SoapElement(IsNullable = true)]
    public DateTime? lastAccessedDt
    {
      get => this.lastAccessedDtField;
      set => this.lastAccessedDtField = value;
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

    [SoapElement(IsNullable = true)]
    public string msgFrom
    {
      get => this.msgFromField;
      set => this.msgFromField = value;
    }

    [SoapElement(IsNullable = true)]
    public string notes
    {
      get => this.notesField;
      set => this.notesField = value;
    }

    public int numberOfRecordings
    {
      get => this.numberOfRecordingsField;
      set => this.numberOfRecordingsField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phoneNumber
    {
      get => this.phoneNumberField;
      set => this.phoneNumberField = value;
    }

    public int priority
    {
      get => this.priorityField;
      set => this.priorityField = value;
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

    public int recStoreId
    {
      get => this.recStoreIdField;
      set => this.recStoreIdField = value;
    }

    public int recStoreType
    {
      get => this.recStoreTypeField;
      set => this.recStoreTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recStoreTypeName
    {
      get => this.recStoreTypeNameField;
      set => this.recStoreTypeNameField = value;
    }

    public int recordRate
    {
      get => this.recordRateField;
      set => this.recordRateField = value;
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

    [SoapElement(IsNullable = true)]
    public string recordingClassDesc
    {
      get => this.recordingClassDescField;
      set => this.recordingClassDescField = value;
    }

    public int recordingClassID
    {
      get => this.recordingClassIDField;
      set => this.recordingClassIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recordingDate
    {
      get => this.recordingDateField;
      set => this.recordingDateField = value;
    }

    public int recordingId
    {
      get => this.recordingIdField;
      set => this.recordingIdField = value;
    }

    public int recordingLength
    {
      get => this.recordingLengthField;
      set => this.recordingLengthField = value;
    }

    public int samplingRate
    {
      get => this.samplingRateField;
      set => this.samplingRateField = value;
    }

    [SoapElement(IsNullable = true)]
    public string screenFileName
    {
      get => this.screenFileNameField;
      set => this.screenFileNameField = value;
    }

    public int service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    [SoapElement(IsNullable = true)]
    public string serviceName
    {
      get => this.serviceNameField;
      set => this.serviceNameField = value;
    }

    public int site
    {
      get => this.siteField;
      set => this.siteField = value;
    }

    public int statusId
    {
      get => this.statusIdField;
      set => this.statusIdField = value;
    }

    public int storageMacineId
    {
      get => this.storageMacineIdField;
      set => this.storageMacineIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string subject
    {
      get => this.subjectField;
      set => this.subjectField = value;
    }

    public int tamperedWith
    {
      get => this.tamperedWithField;
      set => this.tamperedWithField = value;
    }

    public int tenantID
    {
      get => this.tenantIDField;
      set => this.tenantIDField = value;
    }

    public int totalBytes
    {
      get => this.totalBytesField;
      set => this.totalBytesField = value;
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
  }
}
