// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDNotifyServiceSettings
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
  [SoapType(Namespace = "http://Notify.AgentService.UD.concerto.com")]
  [Serializable]
  public class UDNotifyServiceSettings
  {
    private int allowkbField;
    private int allowphonechangeinpreviewField;
    private string appdescField;
    private int btnblindxferfField;
    private int btncallbackfField;
    private int btnconsultfField;
    private int btndialfField;
    private int btnhangupfField;
    private int btnholdfField;
    private int btnnextcallField;
    private int btnplayfField;
    private int btnrecordfField;
    private int btnthreecusthangupfField;
    private int btnthreewayfField;
    private int btnxferfField;
    private int callbackdaysField;
    private int calldatadefidField;
    private int calldatadialogdurationField;
    private int canaddattachmentsField;
    private int cbselfcallbackflagField;
    private int cbservicecallbackflagField;
    private int chatblindtransferallowedField;
    private int chatdisconnectallowedField;
    private int chatrecordallowedField;
    private int chattransferallowedField;
    private int displaycallbacktimewarningfField;
    private int displayservicerecordingfField;
    private int displayservicesfField;
    private int hidePhoneOnSpeedDialField;
    private int lyricallscriptidField;
    private string lyricallscriptnameField;
    private int mailclientidField;
    private int maxWrapTimeField;
    private int minWrapTimeField;
    private int pbxaodserviceidField;
    private int previewtimeoutinsecsField;
    private int replayAgentRecordingField;
    private int replayAgentVMField;
    private int replayServiceVMField;
    private int reqdispositionfField;
    private int requireservicefField;
    private int reqwrapfField;
    private string scriptclassnameField;
    private string scriptcommandlineField;
    private string scriptscreenpopmethodField;
    private int scriptscreenpopnotifytypeField;
    private int serviceidField;
    private int servicetypeidField;
    private int showcalldatadialogfField;
    private int timedpreviewflagField;
    private string useridField;
    private int warmtransferField;
    private int webCollabAgentLedTypeIdField;
    private int wrapExceedActionField;
    private int wrapwarningdelayField;

    public int allowkb
    {
      get => this.allowkbField;
      set => this.allowkbField = value;
    }

    public int allowphonechangeinpreview
    {
      get => this.allowphonechangeinpreviewField;
      set => this.allowphonechangeinpreviewField = value;
    }

    [SoapElement(IsNullable = true)]
    public string appdesc
    {
      get => this.appdescField;
      set => this.appdescField = value;
    }

    public int btnblindxferf
    {
      get => this.btnblindxferfField;
      set => this.btnblindxferfField = value;
    }

    public int btncallbackf
    {
      get => this.btncallbackfField;
      set => this.btncallbackfField = value;
    }

    public int btnconsultf
    {
      get => this.btnconsultfField;
      set => this.btnconsultfField = value;
    }

    public int btndialf
    {
      get => this.btndialfField;
      set => this.btndialfField = value;
    }

    public int btnhangupf
    {
      get => this.btnhangupfField;
      set => this.btnhangupfField = value;
    }

    public int btnholdf
    {
      get => this.btnholdfField;
      set => this.btnholdfField = value;
    }

    public int btnnextcall
    {
      get => this.btnnextcallField;
      set => this.btnnextcallField = value;
    }

    public int btnplayf
    {
      get => this.btnplayfField;
      set => this.btnplayfField = value;
    }

    public int btnrecordf
    {
      get => this.btnrecordfField;
      set => this.btnrecordfField = value;
    }

    public int btnthreecusthangupf
    {
      get => this.btnthreecusthangupfField;
      set => this.btnthreecusthangupfField = value;
    }

    public int btnthreewayf
    {
      get => this.btnthreewayfField;
      set => this.btnthreewayfField = value;
    }

    public int btnxferf
    {
      get => this.btnxferfField;
      set => this.btnxferfField = value;
    }

    public int callbackdays
    {
      get => this.callbackdaysField;
      set => this.callbackdaysField = value;
    }

    public int calldatadefid
    {
      get => this.calldatadefidField;
      set => this.calldatadefidField = value;
    }

    public int calldatadialogduration
    {
      get => this.calldatadialogdurationField;
      set => this.calldatadialogdurationField = value;
    }

    public int canaddattachments
    {
      get => this.canaddattachmentsField;
      set => this.canaddattachmentsField = value;
    }

    public int cbselfcallbackflag
    {
      get => this.cbselfcallbackflagField;
      set => this.cbselfcallbackflagField = value;
    }

    public int cbservicecallbackflag
    {
      get => this.cbservicecallbackflagField;
      set => this.cbservicecallbackflagField = value;
    }

    public int chatblindtransferallowed
    {
      get => this.chatblindtransferallowedField;
      set => this.chatblindtransferallowedField = value;
    }

    public int chatdisconnectallowed
    {
      get => this.chatdisconnectallowedField;
      set => this.chatdisconnectallowedField = value;
    }

    public int chatrecordallowed
    {
      get => this.chatrecordallowedField;
      set => this.chatrecordallowedField = value;
    }

    public int chattransferallowed
    {
      get => this.chattransferallowedField;
      set => this.chattransferallowedField = value;
    }

    public int displaycallbacktimewarningf
    {
      get => this.displaycallbacktimewarningfField;
      set => this.displaycallbacktimewarningfField = value;
    }

    public int displayservicerecordingf
    {
      get => this.displayservicerecordingfField;
      set => this.displayservicerecordingfField = value;
    }

    public int displayservicesf
    {
      get => this.displayservicesfField;
      set => this.displayservicesfField = value;
    }

    public int hidePhoneOnSpeedDial
    {
      get => this.hidePhoneOnSpeedDialField;
      set => this.hidePhoneOnSpeedDialField = value;
    }

    public int lyricallscriptid
    {
      get => this.lyricallscriptidField;
      set => this.lyricallscriptidField = value;
    }

    [SoapElement(IsNullable = true)]
    public string lyricallscriptname
    {
      get => this.lyricallscriptnameField;
      set => this.lyricallscriptnameField = value;
    }

    public int mailclientid
    {
      get => this.mailclientidField;
      set => this.mailclientidField = value;
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

    public int pbxaodserviceid
    {
      get => this.pbxaodserviceidField;
      set => this.pbxaodserviceidField = value;
    }

    public int previewtimeoutinsecs
    {
      get => this.previewtimeoutinsecsField;
      set => this.previewtimeoutinsecsField = value;
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

    public int reqdispositionf
    {
      get => this.reqdispositionfField;
      set => this.reqdispositionfField = value;
    }

    public int requireservicef
    {
      get => this.requireservicefField;
      set => this.requireservicefField = value;
    }

    public int reqwrapf
    {
      get => this.reqwrapfField;
      set => this.reqwrapfField = value;
    }

    [SoapElement(IsNullable = true)]
    public string scriptclassname
    {
      get => this.scriptclassnameField;
      set => this.scriptclassnameField = value;
    }

    [SoapElement(IsNullable = true)]
    public string scriptcommandline
    {
      get => this.scriptcommandlineField;
      set => this.scriptcommandlineField = value;
    }

    [SoapElement(IsNullable = true)]
    public string scriptscreenpopmethod
    {
      get => this.scriptscreenpopmethodField;
      set => this.scriptscreenpopmethodField = value;
    }

    public int scriptscreenpopnotifytype
    {
      get => this.scriptscreenpopnotifytypeField;
      set => this.scriptscreenpopnotifytypeField = value;
    }

    public int serviceid
    {
      get => this.serviceidField;
      set => this.serviceidField = value;
    }

    public int servicetypeid
    {
      get => this.servicetypeidField;
      set => this.servicetypeidField = value;
    }

    public int showcalldatadialogf
    {
      get => this.showcalldatadialogfField;
      set => this.showcalldatadialogfField = value;
    }

    public int timedpreviewflag
    {
      get => this.timedpreviewflagField;
      set => this.timedpreviewflagField = value;
    }

    [SoapElement(IsNullable = true)]
    public string userid
    {
      get => this.useridField;
      set => this.useridField = value;
    }

    public int warmtransfer
    {
      get => this.warmtransferField;
      set => this.warmtransferField = value;
    }

    public int webCollabAgentLedTypeId
    {
      get => this.webCollabAgentLedTypeIdField;
      set => this.webCollabAgentLedTypeIdField = value;
    }

    public int wrapExceedAction
    {
      get => this.wrapExceedActionField;
      set => this.wrapExceedActionField = value;
    }

    public int wrapwarningdelay
    {
      get => this.wrapwarningdelayField;
      set => this.wrapwarningdelayField = value;
    }
  }
}
