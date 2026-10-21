// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDConsultIn
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
  public class UDConsultIn
  {
    private int blindXferFlagField;
    private int callIDField;
    private int consultTypeField;
    private int externalRouteIDField;
    private string phoneNumberField;
    private int serviceIDField;
    private UDCallInfoUserDefinedIn userDefinedDataField;
    private string userIDField;

    public int blindXferFlag
    {
      get => this.blindXferFlagField;
      set => this.blindXferFlagField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    public int consultType
    {
      get => this.consultTypeField;
      set => this.consultTypeField = value;
    }

    public int externalRouteID
    {
      get => this.externalRouteIDField;
      set => this.externalRouteIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phoneNumber
    {
      get => this.phoneNumberField;
      set => this.phoneNumberField = value;
    }

    public int serviceID
    {
      get => this.serviceIDField;
      set => this.serviceIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallInfoUserDefinedIn userDefinedData
    {
      get => this.userDefinedDataField;
      set => this.userDefinedDataField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userID
    {
      get => this.userIDField;
      set => this.userIDField = value;
    }
  }
}
