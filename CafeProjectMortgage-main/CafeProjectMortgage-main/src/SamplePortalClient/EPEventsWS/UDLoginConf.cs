// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDLoginConf
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace SamplePortalClient.EPEventsWS
{
  [GeneratedCode("System.Xml", "4.8.4084.0")]
  [DebuggerStepThrough]
  [DesignerCategory("code")]
  [SoapType(Namespace = "http://Notify.EventService.UD.concerto.com")]
  [Serializable]
  public class UDLoginConf
  {
    private int agentIndexField;
    private string agentLoginNameField;
    private int agentTypeField;
    private int ntSwitchIdField;
    private int referenceIDField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string agentLoginName
    {
      get => this.agentLoginNameField;
      set => this.agentLoginNameField = value;
    }

    public int agentType
    {
      get => this.agentTypeField;
      set => this.agentTypeField = value;
    }

    public int ntSwitchId
    {
      get => this.ntSwitchIdField;
      set => this.ntSwitchIdField = value;
    }

    public int referenceID
    {
      get => this.referenceIDField;
      set => this.referenceIDField = value;
    }
  }
}
