// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDKWDial
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
  public class UDKWDial
  {
    private string kWUserIdField;
    private int kWWorkGroupIdField;
    private int callIdField;
    private int externalRouteIdField;
    private string phoneNumberField;
    private int serviceIdField;
    private string sipURIField;

    [SoapElement(IsNullable = true)]
    public string KWUserId
    {
      get => this.kWUserIdField;
      set => this.kWUserIdField = value;
    }

    public int KWWorkGroupId
    {
      get => this.kWWorkGroupIdField;
      set => this.kWWorkGroupIdField = value;
    }

    public int callId
    {
      get => this.callIdField;
      set => this.callIdField = value;
    }

    public int externalRouteId
    {
      get => this.externalRouteIdField;
      set => this.externalRouteIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phoneNumber
    {
      get => this.phoneNumberField;
      set => this.phoneNumberField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string sipURI
    {
      get => this.sipURIField;
      set => this.sipURIField = value;
    }
  }
}
