// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPEventsWS.UDAgentStats
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
  public class UDAgentStats
  {
    private int cTICallsField;
    private int eMailCallsField;
    private int iMCallsField;
    private int acdCallsField;
    private int activeSecondsField;
    private int agdCallsField;
    private int agentIndexField;
    private int aodCallsField;
    private int chatCallsField;
    private int didCallsField;
    private int idleSecondsField;
    private int loggedInSecondsField;
    private int manualCallsField;
    private int manualSecondsField;
    private int notReadySecondsField;
    private int numberOfCallbacksField;
    private int numberOfRefusalsField;
    private int numberOfSuccessesField;
    private int otherSecondsField;
    private int parkSecondsField;
    private string serviceField;
    private int serviceIdField;
    private string stationField;
    private int statusSecondsField;
    private int statusStartTimeMilitaryField;
    private string userIdField;
    private int wrapSecondsField;

    public int CTICalls
    {
      get => this.cTICallsField;
      set => this.cTICallsField = value;
    }

    public int EMailCalls
    {
      get => this.eMailCallsField;
      set => this.eMailCallsField = value;
    }

    public int IMCalls
    {
      get => this.iMCallsField;
      set => this.iMCallsField = value;
    }

    public int acdCalls
    {
      get => this.acdCallsField;
      set => this.acdCallsField = value;
    }

    public int activeSeconds
    {
      get => this.activeSecondsField;
      set => this.activeSecondsField = value;
    }

    public int agdCalls
    {
      get => this.agdCallsField;
      set => this.agdCallsField = value;
    }

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    public int aodCalls
    {
      get => this.aodCallsField;
      set => this.aodCallsField = value;
    }

    public int chatCalls
    {
      get => this.chatCallsField;
      set => this.chatCallsField = value;
    }

    public int didCalls
    {
      get => this.didCallsField;
      set => this.didCallsField = value;
    }

    public int idleSeconds
    {
      get => this.idleSecondsField;
      set => this.idleSecondsField = value;
    }

    public int loggedInSeconds
    {
      get => this.loggedInSecondsField;
      set => this.loggedInSecondsField = value;
    }

    public int manualCalls
    {
      get => this.manualCallsField;
      set => this.manualCallsField = value;
    }

    public int manualSeconds
    {
      get => this.manualSecondsField;
      set => this.manualSecondsField = value;
    }

    public int notReadySeconds
    {
      get => this.notReadySecondsField;
      set => this.notReadySecondsField = value;
    }

    public int numberOfCallbacks
    {
      get => this.numberOfCallbacksField;
      set => this.numberOfCallbacksField = value;
    }

    public int numberOfRefusals
    {
      get => this.numberOfRefusalsField;
      set => this.numberOfRefusalsField = value;
    }

    public int numberOfSuccesses
    {
      get => this.numberOfSuccessesField;
      set => this.numberOfSuccessesField = value;
    }

    public int otherSeconds
    {
      get => this.otherSecondsField;
      set => this.otherSecondsField = value;
    }

    public int parkSeconds
    {
      get => this.parkSecondsField;
      set => this.parkSecondsField = value;
    }

    [SoapElement(IsNullable = true)]
    public string service
    {
      get => this.serviceField;
      set => this.serviceField = value;
    }

    public int serviceId
    {
      get => this.serviceIdField;
      set => this.serviceIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string station
    {
      get => this.stationField;
      set => this.stationField = value;
    }

    public int statusSeconds
    {
      get => this.statusSecondsField;
      set => this.statusSecondsField = value;
    }

    public int statusStartTimeMilitary
    {
      get => this.statusStartTimeMilitaryField;
      set => this.statusStartTimeMilitaryField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    public int wrapSeconds
    {
      get => this.wrapSecondsField;
      set => this.wrapSecondsField = value;
    }
  }
}
