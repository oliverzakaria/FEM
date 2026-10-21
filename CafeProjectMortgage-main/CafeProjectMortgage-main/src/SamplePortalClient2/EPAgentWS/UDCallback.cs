// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDCallback
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
  public class UDCallback
  {
    private int aodServiceIDField;
    private int callIDField;
    private string callbackNameField;
    private string dateTimeField;
    private int dialModeField;
    private string memoField;
    private string phoneNumberField;
    private int returnToSameAgentField;
    private int snoozeTimeInMinsField;
    private int timeZoneIDField;

    public int aodServiceID
    {
      get => this.aodServiceIDField;
      set => this.aodServiceIDField = value;
    }

    public int callID
    {
      get => this.callIDField;
      set => this.callIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string callbackName
    {
      get => this.callbackNameField;
      set => this.callbackNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string dateTime
    {
      get => this.dateTimeField;
      set => this.dateTimeField = value;
    }

    public int dialMode
    {
      get => this.dialModeField;
      set => this.dialModeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string memo
    {
      get => this.memoField;
      set => this.memoField = value;
    }

    [SoapElement(IsNullable = true)]
    public string phoneNumber
    {
      get => this.phoneNumberField;
      set => this.phoneNumberField = value;
    }

    public int returnToSameAgent
    {
      get => this.returnToSameAgentField;
      set => this.returnToSameAgentField = value;
    }

    public int snoozeTimeInMins
    {
      get => this.snoozeTimeInMinsField;
      set => this.snoozeTimeInMinsField = value;
    }

    public int timeZoneID
    {
      get => this.timeZoneIDField;
      set => this.timeZoneIDField = value;
    }
  }
}
