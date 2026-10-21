// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGMonitorClass
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
  public class SGMonitorClass
  {
    private int agentField;
    private string descriptionField;
    private int monitorClassIDField;
    private int qaField;
    private int supervisorField;

    public int agent
    {
      get => this.agentField;
      set => this.agentField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public int monitorClassID
    {
      get => this.monitorClassIDField;
      set => this.monitorClassIDField = value;
    }

    public int qa
    {
      get => this.qaField;
      set => this.qaField = value;
    }

    public int supervisor
    {
      get => this.supervisorField;
      set => this.supervisorField = value;
    }
  }
}
