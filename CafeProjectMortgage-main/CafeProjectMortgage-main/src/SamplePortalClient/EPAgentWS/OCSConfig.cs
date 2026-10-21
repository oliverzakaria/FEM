// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.OCSConfig
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
  public class OCSConfig
  {
    private int imtimeoutField;
    private string ipAddressField;
    private int numbertodisplayField;
    private int portField;
    private string protocolField;
    private int retryintervalField;
    private int serverIdField;

    public int imtimeout
    {
      get => this.imtimeoutField;
      set => this.imtimeoutField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipAddress
    {
      get => this.ipAddressField;
      set => this.ipAddressField = value;
    }

    public int numbertodisplay
    {
      get => this.numbertodisplayField;
      set => this.numbertodisplayField = value;
    }

    public int port
    {
      get => this.portField;
      set => this.portField = value;
    }

    [SoapElement(IsNullable = true)]
    public string protocol
    {
      get => this.protocolField;
      set => this.protocolField = value;
    }

    public int retryinterval
    {
      get => this.retryintervalField;
      set => this.retryintervalField = value;
    }

    public int serverId
    {
      get => this.serverIdField;
      set => this.serverIdField = value;
    }
  }
}
