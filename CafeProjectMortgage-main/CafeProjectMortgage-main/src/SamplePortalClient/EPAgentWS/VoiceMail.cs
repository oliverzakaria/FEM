// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.VoiceMail
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
  public class VoiceMail
  {
    private int bitspersampleField;
    private int messagesizeField;
    private int samplingrateField;
    private int serviceidField;
    private int vmmsgsField;

    public int bitspersample
    {
      get => this.bitspersampleField;
      set => this.bitspersampleField = value;
    }

    public int messagesize
    {
      get => this.messagesizeField;
      set => this.messagesizeField = value;
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

    public int vmmsgs
    {
      get => this.vmmsgsField;
      set => this.vmmsgsField = value;
    }
  }
}
