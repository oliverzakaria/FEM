// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.Agent
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
  [SoapType(Namespace = "http://User.Beans.Client.ProvisioningService.UD.concerto.com")]
  [Serializable]
  public class Agent
  {
    private int? cBReloadOptionIdField;
    private int? cBSelfCallbackFlagField;
    private int? allowAgentToAgentIMField;
    private int? allowAgentToSupervisorIMField;
    private int? allowAskAnExpertInParkField;
    private int? allowInboundIMField;
    private int? allowIntraIMField;
    private int? allowNotReadyFlagField;
    private string aspectSocialInstanceURLField;
    private int? auditableAlertForAcceptCallField;
    private int? autoAcceptField;
    private int? beginIdleTimeoutOnWrapField;
    private int? btn3CustHangupFField;
    private int? btn3wayFField;
    private int? btnBlindxferFField;
    private int? btnConsultFField;
    private int? btnDialFField;
    private int? btnHangUpFField;
    private int? btnHoldFField;
    private int? btnNextCallField;
    private int? btnPlayFField;
    private int? btnRecordFField;
    private int? btnXferFField;
    private int? callDataDefIdField;
    private int? callDataDialogDurationField;
    private int? canChgDefBrowserSplitField;
    private int? defaultASMServiceIdField;
    private int? displayCallbackTimeWarningFField;
    private int? displayServiceRecordingFField;
    private int? displayServicesFField;
    private int? enableucfField;
    private int? hidePhoneOnSpeedDialField;
    private int? maxChatCallsField;
    private int? maxEmailCallsField;
    private int? maxIMCallsField;
    private int? maxTotalCallsField;
    private int? maxWorkflowCallsField;
    private int? maxWrapTimeField;
    private int? minWrapTimeField;
    private int? multiLineField;
    private int? multiLineNoAnsTimeOutField;
    private int? multiLineRRDestTypeVoiceField;
    private int? multiLineRRDestVoiceField;
    private int? notreadyIfRejectField;
    private int? onDemandFlagField;
    private int? outgoingMaskField;
    private int? parkField;
    private int? parkDelayField;
    private int? personalGreetingsFField;
    private int? replayAgentRecordingField;
    private int? replayAgentVMField;
    private int? replayServiceVMField;
    private int? reqDispositionFField;
    private int? reqWrapFField;
    private int? requireRejectReasonField;
    private int? requireServiceFField;
    private int? routeAccessIdField;
    private int? serializeCallDataFField;
    private int? showCallDataDialogFField;
    private int? taskOfferedTimeoutField;
    private int? transitionToParkForAspectSocialField;
    private int? useWorkgroupSettingField;
    private string userIdField;
    private int? warmTransferField;
    private int? workgroupIdField;
    private int? wrapExceedActionField;
    private int? wrapWarningDelayField;

    [SoapElement(IsNullable = true)]
    public int? CBReloadOptionId
    {
      get => this.cBReloadOptionIdField;
      set => this.cBReloadOptionIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? CBSelfCallbackFlag
    {
      get => this.cBSelfCallbackFlagField;
      set => this.cBSelfCallbackFlagField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowAgentToAgentIM
    {
      get => this.allowAgentToAgentIMField;
      set => this.allowAgentToAgentIMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowAgentToSupervisorIM
    {
      get => this.allowAgentToSupervisorIMField;
      set => this.allowAgentToSupervisorIMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowAskAnExpertInPark
    {
      get => this.allowAskAnExpertInParkField;
      set => this.allowAskAnExpertInParkField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowInboundIM
    {
      get => this.allowInboundIMField;
      set => this.allowInboundIMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowIntraIM
    {
      get => this.allowIntraIMField;
      set => this.allowIntraIMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? allowNotReadyFlag
    {
      get => this.allowNotReadyFlagField;
      set => this.allowNotReadyFlagField = value;
    }

    [SoapElement(IsNullable = true)]
    public string aspectSocialInstanceURL
    {
      get => this.aspectSocialInstanceURLField;
      set => this.aspectSocialInstanceURLField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? auditableAlertForAcceptCall
    {
      get => this.auditableAlertForAcceptCallField;
      set => this.auditableAlertForAcceptCallField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? autoAccept
    {
      get => this.autoAcceptField;
      set => this.autoAcceptField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? beginIdleTimeoutOnWrap
    {
      get => this.beginIdleTimeoutOnWrapField;
      set => this.beginIdleTimeoutOnWrapField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btn3CustHangupF
    {
      get => this.btn3CustHangupFField;
      set => this.btn3CustHangupFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btn3wayF
    {
      get => this.btn3wayFField;
      set => this.btn3wayFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnBlindxferF
    {
      get => this.btnBlindxferFField;
      set => this.btnBlindxferFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnConsultF
    {
      get => this.btnConsultFField;
      set => this.btnConsultFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnDialF
    {
      get => this.btnDialFField;
      set => this.btnDialFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnHangUpF
    {
      get => this.btnHangUpFField;
      set => this.btnHangUpFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnHoldF
    {
      get => this.btnHoldFField;
      set => this.btnHoldFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnNextCall
    {
      get => this.btnNextCallField;
      set => this.btnNextCallField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnPlayF
    {
      get => this.btnPlayFField;
      set => this.btnPlayFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnRecordF
    {
      get => this.btnRecordFField;
      set => this.btnRecordFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? btnXferF
    {
      get => this.btnXferFField;
      set => this.btnXferFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? callDataDefId
    {
      get => this.callDataDefIdField;
      set => this.callDataDefIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? callDataDialogDuration
    {
      get => this.callDataDialogDurationField;
      set => this.callDataDialogDurationField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? canChgDefBrowserSplit
    {
      get => this.canChgDefBrowserSplitField;
      set => this.canChgDefBrowserSplitField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? defaultASMServiceId
    {
      get => this.defaultASMServiceIdField;
      set => this.defaultASMServiceIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? displayCallbackTimeWarningF
    {
      get => this.displayCallbackTimeWarningFField;
      set => this.displayCallbackTimeWarningFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? displayServiceRecordingF
    {
      get => this.displayServiceRecordingFField;
      set => this.displayServiceRecordingFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? displayServicesF
    {
      get => this.displayServicesFField;
      set => this.displayServicesFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? enableucf
    {
      get => this.enableucfField;
      set => this.enableucfField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? hidePhoneOnSpeedDial
    {
      get => this.hidePhoneOnSpeedDialField;
      set => this.hidePhoneOnSpeedDialField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxChatCalls
    {
      get => this.maxChatCallsField;
      set => this.maxChatCallsField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxEmailCalls
    {
      get => this.maxEmailCallsField;
      set => this.maxEmailCallsField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxIMCalls
    {
      get => this.maxIMCallsField;
      set => this.maxIMCallsField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxTotalCalls
    {
      get => this.maxTotalCallsField;
      set => this.maxTotalCallsField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxWorkflowCalls
    {
      get => this.maxWorkflowCallsField;
      set => this.maxWorkflowCallsField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? maxWrapTime
    {
      get => this.maxWrapTimeField;
      set => this.maxWrapTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? minWrapTime
    {
      get => this.minWrapTimeField;
      set => this.minWrapTimeField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? multiLine
    {
      get => this.multiLineField;
      set => this.multiLineField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? multiLineNoAnsTimeOut
    {
      get => this.multiLineNoAnsTimeOutField;
      set => this.multiLineNoAnsTimeOutField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? multiLineRRDestTypeVoice
    {
      get => this.multiLineRRDestTypeVoiceField;
      set => this.multiLineRRDestTypeVoiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? multiLineRRDestVoice
    {
      get => this.multiLineRRDestVoiceField;
      set => this.multiLineRRDestVoiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? notreadyIfReject
    {
      get => this.notreadyIfRejectField;
      set => this.notreadyIfRejectField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? onDemandFlag
    {
      get => this.onDemandFlagField;
      set => this.onDemandFlagField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? outgoingMask
    {
      get => this.outgoingMaskField;
      set => this.outgoingMaskField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? park
    {
      get => this.parkField;
      set => this.parkField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? parkDelay
    {
      get => this.parkDelayField;
      set => this.parkDelayField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? personalGreetingsF
    {
      get => this.personalGreetingsFField;
      set => this.personalGreetingsFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? replayAgentRecording
    {
      get => this.replayAgentRecordingField;
      set => this.replayAgentRecordingField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? replayAgentVM
    {
      get => this.replayAgentVMField;
      set => this.replayAgentVMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? replayServiceVM
    {
      get => this.replayServiceVMField;
      set => this.replayServiceVMField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? reqDispositionF
    {
      get => this.reqDispositionFField;
      set => this.reqDispositionFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? reqWrapF
    {
      get => this.reqWrapFField;
      set => this.reqWrapFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? requireRejectReason
    {
      get => this.requireRejectReasonField;
      set => this.requireRejectReasonField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? requireServiceF
    {
      get => this.requireServiceFField;
      set => this.requireServiceFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? routeAccessId
    {
      get => this.routeAccessIdField;
      set => this.routeAccessIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? serializeCallDataF
    {
      get => this.serializeCallDataFField;
      set => this.serializeCallDataFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? showCallDataDialogF
    {
      get => this.showCallDataDialogFField;
      set => this.showCallDataDialogFField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? taskOfferedTimeout
    {
      get => this.taskOfferedTimeoutField;
      set => this.taskOfferedTimeoutField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? transitionToParkForAspectSocial
    {
      get => this.transitionToParkForAspectSocialField;
      set => this.transitionToParkForAspectSocialField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? useWorkgroupSetting
    {
      get => this.useWorkgroupSettingField;
      set => this.useWorkgroupSettingField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userId
    {
      get => this.userIdField;
      set => this.userIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? warmTransfer
    {
      get => this.warmTransferField;
      set => this.warmTransferField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? workgroupId
    {
      get => this.workgroupIdField;
      set => this.workgroupIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? wrapExceedAction
    {
      get => this.wrapExceedActionField;
      set => this.wrapExceedActionField = value;
    }

    [SoapElement(IsNullable = true)]
    public int? wrapWarningDelay
    {
      get => this.wrapWarningDelayField;
      set => this.wrapWarningDelayField = value;
    }
  }
}
