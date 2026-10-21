// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDLogin
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
  public class UDLogin
  {
    private int agentIndexField;
    private bool enableUCFField;
    private int ntSwitchIdField;
    private int statusReasonField;
    private int systemFeatureField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public bool enableUCF
    {
      get => this.enableUCFField;
      set => this.enableUCFField = value;
    }

    public int ntSwitchId
    {
      get => this.ntSwitchIdField;
      set => this.ntSwitchIdField = value;
    }

    public int statusReason
    {
      get => this.statusReasonField;
      set => this.statusReasonField = value;
    }

    public int systemFeature
    {
      get => this.systemFeatureField;
      set => this.systemFeatureField = value;
    }
  }
}
