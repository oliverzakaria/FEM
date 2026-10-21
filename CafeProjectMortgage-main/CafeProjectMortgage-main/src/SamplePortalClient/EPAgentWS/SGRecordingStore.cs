// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.SGRecordingStore
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
  public class SGRecordingStore
  {
    private string nTShareNameField;
    private int capacityField;
    private string descriptionField;
    private int minDiskField;
    private string nameField;
    private int portField;
    private int recordingStoreIDField;
    private SGRecStoreType recordingStoreTypeField;
    private int sequenceField;
    private Server serverField;
    private int spaceResumeField;
    private SGStorageMachine storageMachineField;
    private SGSwitch theSwitchField;

    [SoapElement(IsNullable = true)]
    public string NTShareName
    {
      get => this.nTShareNameField;
      set => this.nTShareNameField = value;
    }

    public int capacity
    {
      get => this.capacityField;
      set => this.capacityField = value;
    }

    [SoapElement(IsNullable = true)]
    public string description
    {
      get => this.descriptionField;
      set => this.descriptionField = value;
    }

    public int minDisk
    {
      get => this.minDiskField;
      set => this.minDiskField = value;
    }

    [SoapElement(IsNullable = true)]
    public string name
    {
      get => this.nameField;
      set => this.nameField = value;
    }

    public int port
    {
      get => this.portField;
      set => this.portField = value;
    }

    public int recordingStoreID
    {
      get => this.recordingStoreIDField;
      set => this.recordingStoreIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGRecStoreType recordingStoreType
    {
      get => this.recordingStoreTypeField;
      set => this.recordingStoreTypeField = value;
    }

    public int sequence
    {
      get => this.sequenceField;
      set => this.sequenceField = value;
    }

    [SoapElement(IsNullable = true)]
    public Server server
    {
      get => this.serverField;
      set => this.serverField = value;
    }

    public int spaceResume
    {
      get => this.spaceResumeField;
      set => this.spaceResumeField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGStorageMachine storageMachine
    {
      get => this.storageMachineField;
      set => this.storageMachineField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGSwitch theSwitch
    {
      get => this.theSwitchField;
      set => this.theSwitchField = value;
    }
  }
}
