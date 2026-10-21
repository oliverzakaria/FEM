// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.MediaRecordings
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
  [SoapType(Namespace = "http://Agent.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class MediaRecordings
  {
    private bool accessfField;
    private int bitspersampleField;
    private string commentField;
    private string custnameField;
    private string filenameField;
    private string fromdateField;
    private string key1Field;
    private string key2Field;
    private string key3Field;
    private int mediaseqField;
    private int mediatypeidField;
    private int minmsgidField;
    private string monitorclassdescField;
    private int monitorclassidField;
    private string phoneField;
    private int recordcountField;
    private int recordingbytesField;
    private int recordingsecsField;
    private int recordrateField;
    private int recseqField;
    private int rowcountField;
    private int samplingrateField;
    private string servicecField;
    private int serviceidField;
    private string startdtField;
    private string todateField;
    private string useridField;
    private int usertypemaskField;

    public bool accessf
    {
      get => this.accessfField;
      set => this.accessfField = value;
    }

    public int bitspersample
    {
      get => this.bitspersampleField;
      set => this.bitspersampleField = value;
    }

    [SoapElement(IsNullable = true)]
    public string comment
    {
      get => this.commentField;
      set => this.commentField = value;
    }

    [SoapElement(IsNullable = true)]
    public string custname
    {
      get => this.custnameField;
      set => this.custnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string filename
    {
      get => this.filenameField;
      set => this.filenameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fromdate
    {
      get => this.fromdateField;
      set => this.fromdateField = value;
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

    public int mediaseq
    {
      get => this.mediaseqField;
      set => this.mediaseqField = value;
    }

    public int mediatypeid
    {
      get => this.mediatypeidField;
      set => this.mediatypeidField = value;
    }

    public int minmsgid
    {
      get => this.minmsgidField;
      set => this.minmsgidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string monitorclassdesc
    {
      get => this.monitorclassdescField;
      set => this.monitorclassdescField = value;
    }

    public int monitorclassid
    {
      get => this.monitorclassidField;
      set => this.monitorclassidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phone
    {
      get => this.phoneField;
      set => this.phoneField = value;
    }

    public int recordcount
    {
      get => this.recordcountField;
      set => this.recordcountField = value;
    }

    public int recordingbytes
    {
      get => this.recordingbytesField;
      set => this.recordingbytesField = value;
    }

    public int recordingsecs
    {
      get => this.recordingsecsField;
      set => this.recordingsecsField = value;
    }

    public int recordrate
    {
      get => this.recordrateField;
      set => this.recordrateField = value;
    }

    public int recseq
    {
      get => this.recseqField;
      set => this.recseqField = value;
    }

    public int rowcount
    {
      get => this.rowcountField;
      set => this.rowcountField = value;
    }

    public int samplingrate
    {
      get => this.samplingrateField;
      set => this.samplingrateField = value;
    }

    [SoapElement(IsNullable = true)]
    public string servicec
    {
      get => this.servicecField;
      set => this.servicecField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string startdt
    {
      get => this.startdtField;
      set => this.startdtField = value;
    }

    [SoapElement(IsNullable = true)]
    public string todate
    {
      get => this.todateField;
      set => this.todateField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }

    public int usertypemask
    {
      get => this.usertypemaskField;
      set => this.usertypemaskField = value;
    }
  }
}
