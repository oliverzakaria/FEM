// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDExclude
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
  public class UDExclude
  {
    private int iAppIdField;
    private int iTypeField;
    private int agentIndexField;
    private string endDateField;
    private string startDateField;
    private int timeZoneIDField;
    private string valueField;

    public int IAppId
    {
      get => this.iAppIdField;
      set => this.iAppIdField = value;
    }

    public int IType
    {
      get => this.iTypeField;
      set => this.iTypeField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string endDate
    {
      get => this.endDateField;
      set => this.endDateField = value;
    }

    [SoapElement(IsNullable = true)]
    public string startDate
    {
      get => this.startDateField;
      set => this.startDateField = value;
    }

    public int timeZoneID
    {
      get => this.timeZoneIDField;
      set => this.timeZoneIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public string value
    {
      get => this.valueField;
      set => this.valueField = value;
    }
  }
}
