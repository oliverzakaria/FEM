// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.CallBackService
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
  public class CallBackService
  {
    private int allowcallbacksField;
    private int callbackdaysField;
    private int cbselfcallbackflagField;
    private int cbservicecallbackflagField;
    private int displayCallbackTimeWarningFField;
    private string servicecField;
    private int serviceidField;
    private string useridField;

    public int allowcallbacks
    {
      get => this.allowcallbacksField;
      set => this.allowcallbacksField = value;
    }

    public int callbackdays
    {
      get => this.callbackdaysField;
      set => this.callbackdaysField = value;
    }

    public int cbselfcallbackflag
    {
      get => this.cbselfcallbackflagField;
      set => this.cbselfcallbackflagField = value;
    }

    public int cbservicecallbackflag
    {
      get => this.cbservicecallbackflagField;
      set => this.cbservicecallbackflagField = value;
    }

    public int displayCallbackTimeWarningF
    {
      get => this.displayCallbackTimeWarningFField;
      set => this.displayCallbackTimeWarningFField = value;
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
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }
  }
}
