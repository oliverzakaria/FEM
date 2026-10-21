// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.User
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
  public class User
  {
    private int agentindexField;
    private int allowAgentToAgentIMField;
    private int allowAgentToSupervisorIMField;
    private int allowAskAnExpertInParkField;
    private int allowInboundIMField;
    private int allowNotReadyFlagField;
    private string aspectSocialInstanceURLField;
    private int auditableAlertForAcceptCallField;
    private int autoAcceptField;
    private int beginIdleTimeoutOnWrapField;
    private int defaultASMServiceIdField;
    private string emailaddressField;
    private int emailprotocolidField;
    private int enableucfField;
    private string ipaddressField;
    private string ldapuseridField;
    private int maxWrapTimeField;
    private int maxchatcallsField;
    private int maxemailcallsField;
    private int maximcallsField;
    private int maxtotalcallsField;
    private int maxworkflowcallsField;
    private int minWrapTimeField;
    private int multiLineField;
    private int notreadyIfRejectField;
    private int onDemandFlagField;
    private int outgoingmaskField;
    private int parkField;
    private int parkdelayField;
    private string passwordField;
    private int pgAllowedField;
    private int requireRejectReasonField;
    private int routeaccessidField;
    private string stationField;
    private string statusField;
    private int taskOfferedTimeoutField;
    private int transitionToParkForAspectSocialField;
    private string userfnameField;
    private string userfullnameField;
    private string useridField;
    private string userlnameField;
    private int usertypemaskField;
    private int warmtransferField;
    private int workgroupidField;
    private int wrapExceedActionField;

    public int agentindex
    {
      get => this.agentindexField;
      set => this.agentindexField = value;
    }

    public int allowAgentToAgentIM
    {
      get => this.allowAgentToAgentIMField;
      set => this.allowAgentToAgentIMField = value;
    }

    public int allowAgentToSupervisorIM
    {
      get => this.allowAgentToSupervisorIMField;
      set => this.allowAgentToSupervisorIMField = value;
    }

    public int allowAskAnExpertInPark
    {
      get => this.allowAskAnExpertInParkField;
      set => this.allowAskAnExpertInParkField = value;
    }

    public int allowInboundIM
    {
      get => this.allowInboundIMField;
      set => this.allowInboundIMField = value;
    }

    public int allowNotReadyFlag
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

    public int auditableAlertForAcceptCall
    {
      get => this.auditableAlertForAcceptCallField;
      set => this.auditableAlertForAcceptCallField = value;
    }

    public int autoAccept
    {
      get => this.autoAcceptField;
      set => this.autoAcceptField = value;
    }

    public int beginIdleTimeoutOnWrap
    {
      get => this.beginIdleTimeoutOnWrapField;
      set => this.beginIdleTimeoutOnWrapField = value;
    }

    public int defaultASMServiceId
    {
      get => this.defaultASMServiceIdField;
      set => this.defaultASMServiceIdField = value;
    }

    [SoapElement(IsNullable = true)]
    public string emailaddress
    {
      get => this.emailaddressField;
      set => this.emailaddressField = value;
    }

    public int emailprotocolid
    {
      get => this.emailprotocolidField;
      set => this.emailprotocolidField = value;
    }

    public int enableucf
    {
      get => this.enableucfField;
      set => this.enableucfField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ipaddress
    {
      get => this.ipaddressField;
      set => this.ipaddressField = value;
    }

    [SoapElement(IsNullable = true)]
    public string ldapuserid
    {
      get => this.ldapuseridField;
      set => this.ldapuseridField = value;
    }

    public int maxWrapTime
    {
      get => this.maxWrapTimeField;
      set => this.maxWrapTimeField = value;
    }

    public int maxchatcalls
    {
      get => this.maxchatcallsField;
      set => this.maxchatcallsField = value;
    }

    public int maxemailcalls
    {
      get => this.maxemailcallsField;
      set => this.maxemailcallsField = value;
    }

    public int maximcalls
    {
      get => this.maximcallsField;
      set => this.maximcallsField = value;
    }

    public int maxtotalcalls
    {
      get => this.maxtotalcallsField;
      set => this.maxtotalcallsField = value;
    }

    public int maxworkflowcalls
    {
      get => this.maxworkflowcallsField;
      set => this.maxworkflowcallsField = value;
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

    public int notreadyIfReject
    {
      get => this.notreadyIfRejectField;
      set => this.notreadyIfRejectField = value;
    }

    public int onDemandFlag
    {
      get => this.onDemandFlagField;
      set => this.onDemandFlagField = value;
    }

    public int outgoingmask
    {
      get => this.outgoingmaskField;
      set => this.outgoingmaskField = value;
    }

    public int park
    {
      get => this.parkField;
      set => this.parkField = value;
    }

    public int parkdelay
    {
      get => this.parkdelayField;
      set => this.parkdelayField = value;
    }

    [SoapElement(IsNullable = true)]
    public string password
    {
      get => this.passwordField;
      set => this.passwordField = value;
    }

    public int pgAllowed
    {
      get => this.pgAllowedField;
      set => this.pgAllowedField = value;
    }

    public int requireRejectReason
    {
      get => this.requireRejectReasonField;
      set => this.requireRejectReasonField = value;
    }

    public int routeaccessid
    {
      get => this.routeaccessidField;
      set => this.routeaccessidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string station
    {
      get => this.stationField;
      set => this.stationField = value;
    }

    [SoapElement(IsNullable = true)]
    public string status
    {
      get => this.statusField;
      set => this.statusField = value;
    }

    public int taskOfferedTimeout
    {
      get => this.taskOfferedTimeoutField;
      set => this.taskOfferedTimeoutField = value;
    }

    public int transitionToParkForAspectSocial
    {
      get => this.transitionToParkForAspectSocialField;
      set => this.transitionToParkForAspectSocialField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userfname
    {
      get => this.userfnameField;
      set => this.userfnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userfullname
    {
      get => this.userfullnameField;
      set => this.userfullnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userlname
    {
      get => this.userlnameField;
      set => this.userlnameField = value;
    }

    public int usertypemask
    {
      get => this.usertypemaskField;
      set => this.usertypemaskField = value;
    }

    public int warmtransfer
    {
      get => this.warmtransferField;
      set => this.warmtransferField = value;
    }

    public int workgroupid
    {
      get => this.workgroupidField;
      set => this.workgroupidField = value;
    }

    public int wrapExceedAction
    {
      get => this.wrapExceedActionField;
      set => this.wrapExceedActionField = value;
    }
  }
}
