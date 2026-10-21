// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDUpdateRequest
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
  public class UDUpdateRequest
  {
    private int funcCodeField;
    private int parm1Field;
    private int parm10Field;
    private int parm2Field;
    private int parm3Field;
    private int parm4Field;
    private int parm5Field;
    private int parm6Field;
    private int parm7Field;
    private int parm8Field;
    private int parm9Field;
    private string sparm1Field;
    private string sparm2Field;
    private string sparm3Field;
    private string sparm4Field;

    public int funcCode
    {
      get => this.funcCodeField;
      set => this.funcCodeField = value;
    }

    public int parm1
    {
      get => this.parm1Field;
      set => this.parm1Field = value;
    }

    public int parm10
    {
      get => this.parm10Field;
      set => this.parm10Field = value;
    }

    public int parm2
    {
      get => this.parm2Field;
      set => this.parm2Field = value;
    }

    public int parm3
    {
      get => this.parm3Field;
      set => this.parm3Field = value;
    }

    public int parm4
    {
      get => this.parm4Field;
      set => this.parm4Field = value;
    }

    public int parm5
    {
      get => this.parm5Field;
      set => this.parm5Field = value;
    }

    public int parm6
    {
      get => this.parm6Field;
      set => this.parm6Field = value;
    }

    public int parm7
    {
      get => this.parm7Field;
      set => this.parm7Field = value;
    }

    public int parm8
    {
      get => this.parm8Field;
      set => this.parm8Field = value;
    }

    public int parm9
    {
      get => this.parm9Field;
      set => this.parm9Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string sparm1
    {
      get => this.sparm1Field;
      set => this.sparm1Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string sparm2
    {
      get => this.sparm2Field;
      set => this.sparm2Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string sparm3
    {
      get => this.sparm3Field;
      set => this.sparm3Field = value;
    }

    [SoapElement(IsNullable = true)]
    public string sparm4
    {
      get => this.sparm4Field;
      set => this.sparm4Field = value;
    }
  }
}
