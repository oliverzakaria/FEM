// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Catalog
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
  public class Catalog
  {
    private CopyCountMode appendCopyCountModeField;
    private bool assignLabelToVolumeField;
    private bool autoCutField;
    private BarcodeMode barCodeModeField;
    private string catalog_BaseAlphaField;
    private int catalog_BaseNumField;
    private int catalog_IndexField;
    private string descriptionField;
    private bool generateLabelField;
    private int idField;
    private string labelFileNameField;
    private string labelFilePathField;
    private string labelPosIdField;
    private Server labelServerField;
    private string nameField;
    private int numberOfCopiesField;
    private bool printRecStoreField;
    private string recStorePosIdField;
    private bool writeVolumeHeaderFileField;

    [SoapElement(IsNullable = true)]
    public CopyCountMode appendCopyCountMode
    {
      get => this.appendCopyCountModeField;
      set => this.appendCopyCountModeField = value;
    }

    public bool assignLabelToVolume
    {
      get => this.assignLabelToVolumeField;
      set => this.assignLabelToVolumeField = value;
    }

    public bool autoCut
    {
      get => this.autoCutField;
      set => this.autoCutField = value;
    }

    [SoapElement(IsNullable = true)]
    public BarcodeMode barCodeMode
    {
      get => this.barCodeModeField;
      set => this.barCodeModeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string catalog_BaseAlpha
    {
      get => this.catalog_BaseAlphaField;
      set => this.catalog_BaseAlphaField = value;
    }

    public int catalog_BaseNum
    {
      get => this.catalog_BaseNumField;
      set => this.catalog_BaseNumField = value;
    }

    public int catalog_Index
    {
      get => this.catalog_IndexField;
      set => this.catalog_IndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public bool generateLabel
    {
      get => this.generateLabelField;
      set => this.generateLabelField = value;
    }

    public int id
    {
      get => this.idField;
      set => this.idField = value;
    }

    [SoapElement(IsNullable = true)]
    public string labelFileName
    {
      get => this.labelFileNameField;
      set => this.labelFileNameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string labelFilePath
    {
      get => this.labelFilePathField;
      set => this.labelFilePathField = value;
    }

    [SoapElement(IsNullable = true)]
    public string labelPosId
    {
      get => this.labelPosIdField;
      set => this.labelPosIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public Server labelServer
    {
      get => this.labelServerField;
      set => this.labelServerField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int numberOfCopies
    {
      get => this.numberOfCopiesField;
      set => this.numberOfCopiesField = value;
    }

    public bool printRecStore
    {
      get => this.printRecStoreField;
      set => this.printRecStoreField = value;
    }

    [SoapElement(IsNullable = true)]
    public string recStorePosId
    {
      get => this.recStorePosIdField;
      set => this.recStorePosIdField = value;
    }

    public bool writeVolumeHeaderFile
    {
      get => this.writeVolumeHeaderFileField;
      set => this.writeVolumeHeaderFileField = value;
    }
  }
}
