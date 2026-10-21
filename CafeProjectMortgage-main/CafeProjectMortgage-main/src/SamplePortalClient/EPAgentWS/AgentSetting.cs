// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.AgentSetting
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
  public class AgentSetting
  {
    private int cBReloadOptionIdField;
    private int cBSelfCallbackFlagField;
    private string aspectSocialInstanceURLField;
    private int btn3CustHangupFField;
    private int btn3wayFField;
    private int btnBlindxferFField;
    private int btnConsultFField;
    private int btnDialFField;
    private int btnHangUpFField;
    private int btnHoldFField;
    private int btnNextCallField;
    private int btnPlayFField;
    private int btnRecordFField;
    private int btnXferFField;
    private int callDataDefIdField;
    private int callDataDialogDurationField;
    private int canChgDefBrowserSplitField;
    private int defaultASMServiceIdField;
    private int displayCallbackTimeWarningFField;
    private int displayServiceRecordingFField;
    private int displayServicesFField;
    private int hidePhoneOnSpeedDialField;
    private int maxChatCallsField;
    private int maxEmailCallsField;
    private int maxIMCallsField;
    private int maxTotalCallsField;
    private int maxWorkflowCallsField;
    private int maxWrapTimeField;
    private int minWrapTimeField;
    private int multiLineField;
    private int outgoingMaskField;
    private int parkField;
    private int parkDelayField;
    private int replayAgentRecordingField;
    private int replayAgentVMField;
    private int replayServiceVMField;
    private int reqDispositionFField;
    private int reqWrapFField;
    private int requireServiceFField;
    private int serializeCallDataFField;
    private int showCallDataDialogFField;
    private int transitionToParkForAspectSocialField;
    private string userIdField;
    private int warmTransferField;
    private int workgroupIdField;
    private int wrapExceedActionField;
    private int wrapWarningDelayField;

    public int CBReloadOptionId
    {
      get => this.cBReloadOptionIdField;
      set => this.cBReloadOptionIdField = value;
    }

    public int CBSelfCallbackFlag
    {
      get => this.cBSelfCallbackFlagField;
      set => this.cBSelfCallbackFlagField = value;
    }

    [SoapElement(IsNullable = true)]
    public string aspectSocialInstanceURL
    {
      get => this.aspectSocialInstanceURLField;
      set => this.aspectSocialInstanceURLField = value;
    }

    public int btn3CustHangupF
    {
      get => this.btn3CustHangupFField;
      set => this.btn3CustHangupFField = value;
    }

    public int btn3wayF
    {
      get => this.btn3wayFField;
      set => this.btn3wayFField = value;
    }

    public int btnBlindxferF
    {
      get => this.btnBlindxferFField;
      set => this.btnBlindxferFField = value;
    }

    public int btnConsultF
    {
      get => this.btnConsultFField;
      set => this.btnConsultFField = value;
    }

    public int btnDialF
    {
      get => this.btnDialFField;
      set => this.btnDialFField = value;
    }

    public int btnHangUpF
    {
      get => this.btnHangUpFField;
      set => this.btnHangUpFField = value;
    }

    public int btnHoldF
    {
      get => this.btnHoldFField;
      set => this.btnHoldFField = value;
    }

    public int btnNextCall
    {
      get => this.btnNextCallField;
      set => this.btnNextCallField = value;
    }

    public int btnPlayF
    {
      get => this.btnPlayFField;
      set => this.btnPlayFField = value;
    }

    public int btnRecordF
    {
      get => this.btnRecordFField;
      set => this.btnRecordFField = value;
    }

    public int btnXferF
    {
      get => this.btnXferFField;
      set => this.btnXferFField = value;
    }

    public int callDataDefId
    {
      get => this.callDataDefIdField;
      set => this.callDataDefIdField = value;
    }

    public int callDataDialogDuration
    {
      get => this.callDataDialogDurationField;
      set => this.callDataDialogDurationField = value;
    }

    public int canChgDefBrowserSplit
    {
      get => this.canChgDefBrowserSplitField;
      set => this.canChgDefBrowserSplitField = value;
    }

    public int defaultASMServiceId
    {
      get => this.defaultASMServiceIdField;
      set => this.defaultASMServiceIdField = value;
    }

    public int displayCallbackTimeWarningF
    {
      get => this.displayCallbackTimeWarningFField;
      set => this.displayCallbackTimeWarningFField = value;
    }

    public int displayServiceRecordingF
    {
      get => this.displayServiceRecordingFField;
      set => this.displayServiceRecordingFField = value;
    }

    public int displayServicesF
    {
      get => this.displayServicesFField;
      set => this.displayServicesFField = value;
    }

    public int hidePhoneOnSpeedDial
    {
      get => this.hidePhoneOnSpeedDialField;
      set => this.hidePhoneOnSpeedDialField = value;
    }

    public int maxChatCalls
    {
      get => this.maxChatCallsField;
      set => this.maxChatCallsField = value;
    }

    public int maxEmailCalls
    {
      get => this.maxEmailCallsField;
      set => this.maxEmailCallsField = value;
    }

    public int maxIMCalls
    {
      get => this.maxIMCallsField;
      set => this.maxIMCallsField = value;
    }

    public int maxTotalCalls
    {
      get => this.maxTotalCallsField;
      set => this.maxTotalCallsField = value;
    }

    public int maxWorkflowCalls
    {
      get => this.maxWorkflowCallsField;
      set => this.maxWorkflowCallsField = value;
    }

    public int maxWrapTime
    {
      get => this.maxWrapTimeField;
      set => this.maxWrapTimeField = value;
    }

    public int minWrapTime
    {
      get => this.minWrapTimeField;
      set => this.minWrapTimeField = value;
    }

    public int multiLine
    {
      get => this.multiLineField;
      set => this.multiLineField = value;
    }

    public int outgoingMask
    {
      get => this.outgoingMaskField;
      set => this.outgoingMaskField = value;
    }

    public int park
    {
      get => this.parkField;
      set => this.parkField = value;
    }

    public int parkDelay
    {
      get => this.parkDelayField;
      set => this.parkDelayField = value;
    }

    public int replayAgentRecording
    {
      get => this.replayAgentRecordingField;
      set => this.replayAgentRecordingField = value;
    }

    public int replayAgentVM
    {
      get => this.replayAgentVMField;
      set => this.replayAgentVMField = value;
    }

    public int replayServiceVM
    {
      get => this.replayServiceVMField;
      set => this.replayServiceVMField = value;
    }

    public int reqDispositionF
    {
      get => this.reqDispositionFField;
      set => this.reqDispositionFField = value;
    }

    public int reqWrapF
    {
      get => this.reqWrapFField;
      set => this.reqWrapFField = value;
    }

    public int requireServiceF
    {
      get => this.requireServiceFField;
      set => this.requireServiceFField = value;
    }

    public int serializeCallDataF
    {
      get => this.serializeCallDataFField;
      set => this.serializeCallDataFField = value;
    }

    public int showCallDataDialogF
    {
      get => this.showCallDataDialogFField;
      set => this.showCallDataDialogFField = value;
    }

    public int transitionToParkForAspectSocial
    {
      get => this.transitionToParkForAspectSocialField;
      set => this.transitionToParkForAspectSocialField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    public int warmTransfer
    {
      get => this.warmTransferField;
      set => this.warmTransferField = value;
    }

    public int workgroupId
    {
      get => this.workgroupIdField;
      set => this.workgroupIdField = value;
    }

    public int wrapExceedAction
    {
      get => this.wrapExceedActionField;
      set => this.wrapExceedActionField = value;
    }

    public int wrapWarningDelay
    {
      get => this.wrapWarningDelayField;
      set => this.wrapWarningDelayField = value;
    }
  }
}
