// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDNotifyCallDataDef
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
  [SoapType(Namespace = "http://Notify.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDNotifyCallDataDef
  {
    private int calldatadefidField;
    private string nameField;
    private int tabledefidField;

    public int calldatadefid
    {
      get => this.calldatadefidField;
      set => this.calldatadefidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int tabledefid
    {
      get => this.tabledefidField;
      set => this.tabledefidField = value;
    }
  }
}
