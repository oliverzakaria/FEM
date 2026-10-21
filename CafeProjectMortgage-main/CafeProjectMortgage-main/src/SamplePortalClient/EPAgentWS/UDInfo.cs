// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDInfo
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
  public class UDInfo
  {
    private int attachementIdField;
    private int callDataDefIdField;
    private int[] categoryArrayField;
    private int classIdField;
    private string descriptionField;
    private int dispostionIdField;
    private string fromDateField;
    private int idField;
    private int indicatorField;
    private string ipAddress1Field;
    private string ipAddress2Field;
    private int listTypeField;
    private string localeUserField;
    private int mailIdField;
    private int mailQIdField;
    private int messageIdField;
    private int minMsgIdField;
    private int recordCountField;
    private string recordingCommentField;
    private int rowCountField;
    private string searchFieldField;
    private string searchTextField;
    private string searchTypeField;
    private int seqNumField;
    private int serviceIdField;
    private int serviceTypeField;
    private int statusIdField;
    private int statusReasonsTypeField;
    private int statusTypeField;
    private string toDateField;
    private int urlIdField;
    private int userTypeField;
    private int userTypeMaskField;

    public int attachementId
    {
      get => this.attachementIdField;
      set => this.attachementIdField = value;
    }

    public int callDataDefId
    {
      get => this.callDataDefIdField;
      set => this.callDataDefIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int[] categoryArray
    {
      get => this.categoryArrayField;
      set => this.categoryArrayField = value;
    }

    public int classId
    {
      get => this.classIdField;
      set => this.classIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public int dispostionId
    {
      get => this.dispostionIdField;
      set => this.dispostionIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fromDate
    {
      get => this.fromDateField;
      set => this.fromDateField = value;
    }

    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }

    public int indicator
    {
      get => this.indicatorField;
      set => this.indicatorField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress1
    {
      get => this.ipAddress1Field;
      set => this.ipAddress1Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress2
    {
      get => this.ipAddress2Field;
      set => this.ipAddress2Field = value;
    }

    public int listType
    {
      get => this.listTypeField;
      set => this.listTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string localeUser
    {
      get => this.localeUserField;
      set => this.localeUserField = value;
    }

    public int mailId
    {
      get => this.mailIdField;
      set => this.mailIdField = value;
    }

    public int mailQId
    {
      get => this.mailQIdField;
      set => this.mailQIdField = value;
    }

    public int messageId
    {
      get => this.messageIdField;
      set => this.messageIdField = value;
    }

    public int minMsgId
    {
      get => this.minMsgIdField;
      set => this.minMsgIdField = value;
    }

    public int recordCount
    {
      get => this.recordCountField;
      set => this.recordCountField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recordingComment
    {
      get => this.recordingCommentField;
      set => this.recordingCommentField = value;
    }

    public int rowCount
    {
      get => this.rowCountField;
      set => this.rowCountField = value;
    }

    [SoapElement(IsNullable = true)]
    public string searchField
    {
      get => this.searchFieldField;
      set => this.searchFieldField = value;
    }

    [SoapElement(IsNullable = true)]
    public string searchText
    {
      get => this.searchTextField;
      set => this.searchTextField = value;
    }

    [SoapElement(IsNullable = true)]
    public string searchType
    {
      get => this.searchTypeField;
      set => this.searchTypeField = value;
    }

    public int seqNum
    {
      get => this.seqNumField;
      set => this.seqNumField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    public int serviceType
    {
      get => this.serviceTypeField;
      set => this.serviceTypeField = value;
    }

    public int statusId
    {
      get => this.statusIdField;
      set => this.statusIdField = value;
    }

    public int statusReasonsType
    {
      get => this.statusReasonsTypeField;
      set => this.statusReasonsTypeField = value;
    }

    public int statusType
    {
      get => this.statusTypeField;
      set => this.statusTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string toDate
    {
      get => this.toDateField;
      set => this.toDateField = value;
    }

    public int urlId
    {
      get => this.urlIdField;
      set => this.urlIdField = value;
    }

    public int userType
    {
      get => this.userTypeField;
      set => this.userTypeField = value;
    }

    public int userTypeMask
    {
      get => this.userTypeMaskField;
      set => this.userTypeMaskField = value;
    }
  }
}
