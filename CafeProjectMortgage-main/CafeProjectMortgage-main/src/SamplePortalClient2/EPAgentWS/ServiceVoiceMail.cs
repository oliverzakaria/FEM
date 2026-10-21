// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.ServiceVoiceMail
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
  public class ServiceVoiceMail
  {
    private string aniField;
    private int bitspersampleField;
    private string fullfilenameField;
    private string messagedtField;
    private int messageidField;
    private int samplingrateField;
    private int serviceidField;
    private int statusidField;
    private string useridField;

    [SoapElement(IsNullable = true)]
    public string ani
    {
      get => this.aniField;
      set => this.aniField = value;
    }

    public int bitspersample
    {
      get => this.bitspersampleField;
      set => this.bitspersampleField = value;
    }

    [SoapElement(IsNullable = true)]
    public string fullfilename
    {
      get => this.fullfilenameField;
      set => this.fullfilenameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string messagedt
    {
      get => this.messagedtField;
      set => this.messagedtField = value;
    }

    public int messageid
    {
      get => this.messageidField;
      set => this.messageidField = value;
    }

    public int samplingrate
    {
      get => this.samplingrateField;
      set => this.samplingrateField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    public int statusid
    {
      get => this.statusidField;
      set => this.statusidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }
  }
}
