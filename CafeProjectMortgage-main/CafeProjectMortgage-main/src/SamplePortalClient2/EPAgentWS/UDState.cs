// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.EPAgentWS.UDState
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
  public class UDState
  {
    private int agentIndexField;
    private AgentType agentTypeField;
    private UDAnswerCall ansCallField;
    private Catalog catField;
    private EmailSubject curremailsubjectField;
    private UDActivateCall currentActivateCallField;
    private AgentXfer currentAgentXferField;
    private Attachemnts currentAttachemntsField;
    private CallBackService currentCallBackServiceField;
    private UDCallClear currentCallClearField;
    private CallDataDef currentCallDataDefField;
    private CallLogger currentCallLoggerField;
    private UDCallReRouted currentCallReRoutedField;
    private UDCallReleasedXferred currentCallReleasedXferredField;
    private int currentCallTypeField;
    private UDCallXferred currentCallXferredField;
    private UDConsult currentConsultField;
    private int currentCtiUpDownField;
    private UDDialing currentDialingField;
    private UDDirectorAck currentDirectorAckField;
    private DirectorXfer currentDirectorXferField;
    private Disposition currentDispositionField;
    private DispositionPlan currentDispositionPlanField;
    private Dispositions currentDispositionsField;
    private Email currentEmailField;
    private UDError currentErrorField;
    private External currentExternalField;
    private UDExternalRoute currentExternalRouteField;
    private Externals currentExternalsField;
    private int currentGatewayUpDownField;
    private GetIdDesc currentGetIdDescField;
    private UDHeld currentHeldField;
    private UDIdle currentIdleField;
    private UDLoggingIn currentLoggingInField;
    private UDLogin currentLoginAgentField;
    private UDLoginConf currentLoginConfField;
    private int currentLogoffPendingReasonField;
    private UDLogout currentLogoutField;
    private MediaRecordings currentMediaRecordingsField;
    private MonitorClass currentMonitorClassField;
    private UDMonitorState currentMonitorStateField;
    private UDNewService currentNewServiceField;
    private UDNotReady currentNotReadyField;
    private UDPasscode currentPasscodeField;
    private string currentPreviewField;
    private UDRecordState currentRecordStateField;
    private RecordingComments currentRecordingCommentsField;
    private UDRemoveService currentRemoveServiceField;
    private Service currentServiceField;
    private ServiceEmailQueues currentServiceEmailQueuesField;
    private ServiceSettings currentServiceSettingsField;
    private ServiceVoiceMail currentServiceVoiceMailField;
    private ServiceXfer currentServiceXferField;
    private int currentStateField;
    private StatusReasons currentStatusReasonsField;
    private UDSwitch currentSwitchUpDownField;
    private int currentSystemWaitSwitchIDField;
    private UDActive currentUDActiveField;
    private UDChatEntity currentUDChatEntityField;
    private UDRealTimePort currentUDRealTimePortField;
    private URL currentURLField;
    private UDUpdateService currentUpdataServiceField;
    private UDUpdateCallDataDef currentUpdateCallDataDefField;
    private UDUpdateDisposition currentUpdateDispositionField;
    private User currentUserField;
    private UserVoiceMail currentUserVoiceMailField;
    private VoiceMail currentVoicemailField;
    private UDWrap currentWrapField;
    private UDWrapTimeout currentWrapTimeoutField;
    private SGDispositionCode dispositionCodeField;
    private UDUpdateDispositionPlan field1Field;
    private CallDataDefFields field2Field;
    private SGRecordingTypes field3Field;
    private UDForwardEmail forwardEmailField;
    private UDForwardEmailSent forwardEmailSentField;
    private KWSkill kwSkillField;
    private AgentKWUserInfo kwUserInfoField;
    private LoggedInUsers loggedInUsersField;
    private LoggedInUsersIM loggedInUsersIMField;
    private SGMonitorClass monclassField;
    private NLPCategory nlpCategoryField;
    private NLPResult nlpResultField;
    private OCSConfig osConfigField;
    private PersonalGreeting personalGreetingField;
    private Agent psAgentField;
    private AgentSetting pwAgentSettingField;
    private UDRecStoreType recStoreTypeField;
    private SGRecording recordingField;
    private SGRecordingStore recstoreField;
    private UDReserved reservedField;
    private SGService servField;
    private ServerSettings serverSettingsField;
    private UserLocale systemLocaleField;
    private Tenant tenField;
    private UDSite udSiteField;
    private UDNotifyCallDataDef updateServiceCallDataDefField;
    private UDNotifyCallDataDefFields updateServiceCallDataDefFieldsField;
    private UDNotifyDispositionPlan updateServiceDispositionPlanField;
    private UDNotifyDispositions updateServiceDispositionsField;
    private UDNotifyServiceSettings updateServiceServiceSettingsField;
    private UDNotifyUrl updateServiceUrlField;
    private UDNotifyService updateSeviceServiceField;
    private SGVMGroup vmgrpField;
    private UDVoiceLock voiceLockField;
    private UDVoiceUnlock voiceUnlockField;
    private SGWorkgroup wrkgrpField;

    public int agentIndex
    {
      get => this.agentIndexField;
      set => this.agentIndexField = value;
    }

    [SoapElement(IsNullable = true)]
    public AgentType agentType
    {
      get => this.agentTypeField;
      set => this.agentTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDAnswerCall ansCall
    {
      get => this.ansCallField;
      set => this.ansCallField = value;
    }

    [SoapElement(IsNullable = true)]
    public Catalog cat
    {
      get => this.catField;
      set => this.catField = value;
    }

    [SoapElement(IsNullable = true)]
    public EmailSubject curremailsubject
    {
      get => this.curremailsubjectField;
      set => this.curremailsubjectField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDActivateCall currentActivateCall
    {
      get => this.currentActivateCallField;
      set => this.currentActivateCallField = value;
    }

    [SoapElement(IsNullable = true)]
    public AgentXfer currentAgentXfer
    {
      get => this.currentAgentXferField;
      set => this.currentAgentXferField = value;
    }

    [SoapElement(IsNullable = true)]
    public Attachemnts currentAttachemnts
    {
      get => this.currentAttachemntsField;
      set => this.currentAttachemntsField = value;
    }

    [SoapElement(IsNullable = true)]
    public CallBackService currentCallBackService
    {
      get => this.currentCallBackServiceField;
      set => this.currentCallBackServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallClear currentCallClear
    {
      get => this.currentCallClearField;
      set => this.currentCallClearField = value;
    }

    [SoapElement(IsNullable = true)]
    public CallDataDef currentCallDataDef
    {
      get => this.currentCallDataDefField;
      set => this.currentCallDataDefField = value;
    }

    [SoapElement(IsNullable = true)]
    public CallLogger currentCallLogger
    {
      get => this.currentCallLoggerField;
      set => this.currentCallLoggerField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallReRouted currentCallReRouted
    {
      get => this.currentCallReRoutedField;
      set => this.currentCallReRoutedField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallReleasedXferred currentCallReleasedXferred
    {
      get => this.currentCallReleasedXferredField;
      set => this.currentCallReleasedXferredField = value;
    }

    public int currentCallType
    {
      get => this.currentCallTypeField;
      set => this.currentCallTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDCallXferred currentCallXferred
    {
      get => this.currentCallXferredField;
      set => this.currentCallXferredField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDConsult currentConsult
    {
      get => this.currentConsultField;
      set => this.currentConsultField = value;
    }

    public int currentCtiUpDown
    {
      get => this.currentCtiUpDownField;
      set => this.currentCtiUpDownField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDDialing currentDialing
    {
      get => this.currentDialingField;
      set => this.currentDialingField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDDirectorAck currentDirectorAck
    {
      get => this.currentDirectorAckField;
      set => this.currentDirectorAckField = value;
    }

    [SoapElement(IsNullable = true)]
    public DirectorXfer currentDirectorXfer
    {
      get => this.currentDirectorXferField;
      set => this.currentDirectorXferField = value;
    }

    [SoapElement(IsNullable = true)]
    public Disposition currentDisposition
    {
      get => this.currentDispositionField;
      set => this.currentDispositionField = value;
    }

    [SoapElement(IsNullable = true)]
    public DispositionPlan currentDispositionPlan
    {
      get => this.currentDispositionPlanField;
      set => this.currentDispositionPlanField = value;
    }

    [SoapElement(IsNullable = true)]
    public Dispositions currentDispositions
    {
      get => this.currentDispositionsField;
      set => this.currentDispositionsField = value;
    }

    [SoapElement(IsNullable = true)]
    public Email currentEmail
    {
      get => this.currentEmailField;
      set => this.currentEmailField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDError currentError
    {
      get => this.currentErrorField;
      set => this.currentErrorField = value;
    }

    [SoapElement(IsNullable = true)]
    public External currentExternal
    {
      get => this.currentExternalField;
      set => this.currentExternalField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDExternalRoute currentExternalRoute
    {
      get => this.currentExternalRouteField;
      set => this.currentExternalRouteField = value;
    }

    [SoapElement(IsNullable = true)]
    public Externals currentExternals
    {
      get => this.currentExternalsField;
      set => this.currentExternalsField = value;
    }

    public int currentGatewayUpDown
    {
      get => this.currentGatewayUpDownField;
      set => this.currentGatewayUpDownField = value;
    }

    [SoapElement(IsNullable = true)]
    public GetIdDesc currentGetIdDesc
    {
      get => this.currentGetIdDescField;
      set => this.currentGetIdDescField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDHeld currentHeld
    {
      get => this.currentHeldField;
      set => this.currentHeldField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDIdle currentIdle
    {
      get => this.currentIdleField;
      set => this.currentIdleField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDLoggingIn currentLoggingIn
    {
      get => this.currentLoggingInField;
      set => this.currentLoggingInField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDLogin currentLoginAgent
    {
      get => this.currentLoginAgentField;
      set => this.currentLoginAgentField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDLoginConf currentLoginConf
    {
      get => this.currentLoginConfField;
      set => this.currentLoginConfField = value;
    }

    public int currentLogoffPendingReason
    {
      get => this.currentLogoffPendingReasonField;
      set => this.currentLogoffPendingReasonField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDLogout currentLogout
    {
      get => this.currentLogoutField;
      set => this.currentLogoutField = value;
    }

    [SoapElement(IsNullable = true)]
    public MediaRecordings currentMediaRecordings
    {
      get => this.currentMediaRecordingsField;
      set => this.currentMediaRecordingsField = value;
    }

    [SoapElement(IsNullable = true)]
    public MonitorClass currentMonitorClass
    {
      get => this.currentMonitorClassField;
      set => this.currentMonitorClassField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDMonitorState currentMonitorState
    {
      get => this.currentMonitorStateField;
      set => this.currentMonitorStateField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNewService currentNewService
    {
      get => this.currentNewServiceField;
      set => this.currentNewServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotReady currentNotReady
    {
      get => this.currentNotReadyField;
      set => this.currentNotReadyField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDPasscode currentPasscode
    {
      get => this.currentPasscodeField;
      set => this.currentPasscodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public string currentPreview
    {
      get => this.currentPreviewField;
      set => this.currentPreviewField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDRecordState currentRecordState
    {
      get => this.currentRecordStateField;
      set => this.currentRecordStateField = value;
    }

    [SoapElement(IsNullable = true)]
    public RecordingComments currentRecordingComments
    {
      get => this.currentRecordingCommentsField;
      set => this.currentRecordingCommentsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDRemoveService currentRemoveService
    {
      get => this.currentRemoveServiceField;
      set => this.currentRemoveServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public Service currentService
    {
      get => this.currentServiceField;
      set => this.currentServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServiceEmailQueues currentServiceEmailQueues
    {
      get => this.currentServiceEmailQueuesField;
      set => this.currentServiceEmailQueuesField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServiceSettings currentServiceSettings
    {
      get => this.currentServiceSettingsField;
      set => this.currentServiceSettingsField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServiceVoiceMail currentServiceVoiceMail
    {
      get => this.currentServiceVoiceMailField;
      set => this.currentServiceVoiceMailField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServiceXfer currentServiceXfer
    {
      get => this.currentServiceXferField;
      set => this.currentServiceXferField = value;
    }

    public int currentState
    {
      get => this.currentStateField;
      set => this.currentStateField = value;
    }

    [SoapElement(IsNullable = true)]
    public StatusReasons currentStatusReasons
    {
      get => this.currentStatusReasonsField;
      set => this.currentStatusReasonsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDSwitch currentSwitchUpDown
    {
      get => this.currentSwitchUpDownField;
      set => this.currentSwitchUpDownField = value;
    }

    public int currentSystemWaitSwitchID
    {
      get => this.currentSystemWaitSwitchIDField;
      set => this.currentSystemWaitSwitchIDField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDActive currentUDActive
    {
      get => this.currentUDActiveField;
      set => this.currentUDActiveField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDChatEntity currentUDChatEntity
    {
      get => this.currentUDChatEntityField;
      set => this.currentUDChatEntityField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDRealTimePort currentUDRealTimePort
    {
      get => this.currentUDRealTimePortField;
      set => this.currentUDRealTimePortField = value;
    }

    [SoapElement(IsNullable = true)]
    public URL currentURL
    {
      get => this.currentURLField;
      set => this.currentURLField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDUpdateService currentUpdataService
    {
      get => this.currentUpdataServiceField;
      set => this.currentUpdataServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDUpdateCallDataDef currentUpdateCallDataDef
    {
      get => this.currentUpdateCallDataDefField;
      set => this.currentUpdateCallDataDefField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDUpdateDisposition currentUpdateDisposition
    {
      get => this.currentUpdateDispositionField;
      set => this.currentUpdateDispositionField = value;
    }

    [SoapElement(IsNullable = true)]
    public User currentUser
    {
      get => this.currentUserField;
      set => this.currentUserField = value;
    }

    [SoapElement(IsNullable = true)]
    public UserVoiceMail currentUserVoiceMail
    {
      get => this.currentUserVoiceMailField;
      set => this.currentUserVoiceMailField = value;
    }

    [SoapElement(IsNullable = true)]
    public VoiceMail currentVoicemail
    {
      get => this.currentVoicemailField;
      set => this.currentVoicemailField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDWrap currentWrap
    {
      get => this.currentWrapField;
      set => this.currentWrapField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDWrapTimeout currentWrapTimeout
    {
      get => this.currentWrapTimeoutField;
      set => this.currentWrapTimeoutField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGDispositionCode dispositionCode
    {
      get => this.dispositionCodeField;
      set => this.dispositionCodeField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDUpdateDispositionPlan field1
    {
      get => this.field1Field;
      set => this.field1Field = value;
    }

    [SoapElement(IsNullable = true)]
    public CallDataDefFields field2
    {
      get => this.field2Field;
      set => this.field2Field = value;
    }

    [SoapElement(IsNullable = true)]
    public SGRecordingTypes field3
    {
      get => this.field3Field;
      set => this.field3Field = value;
    }

    [SoapElement(IsNullable = true)]
    public UDForwardEmail forwardEmail
    {
      get => this.forwardEmailField;
      set => this.forwardEmailField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDForwardEmailSent forwardEmailSent
    {
      get => this.forwardEmailSentField;
      set => this.forwardEmailSentField = value;
    }

    [SoapElement(IsNullable = true)]
    public KWSkill kwSkill
    {
      get => this.kwSkillField;
      set => this.kwSkillField = value;
    }

    [SoapElement(IsNullable = true)]
    public AgentKWUserInfo kwUserInfo
    {
      get => this.kwUserInfoField;
      set => this.kwUserInfoField = value;
    }

    [SoapElement(IsNullable = true)]
    public LoggedInUsers loggedInUsers
    {
      get => this.loggedInUsersField;
      set => this.loggedInUsersField = value;
    }

    [SoapElement(IsNullable = true)]
    public LoggedInUsersIM loggedInUsersIM
    {
      get => this.loggedInUsersIMField;
      set => this.loggedInUsersIMField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGMonitorClass monclass
    {
      get => this.monclassField;
      set => this.monclassField = value;
    }

    [SoapElement(IsNullable = true)]
    public NLPCategory nlpCategory
    {
      get => this.nlpCategoryField;
      set => this.nlpCategoryField = value;
    }

    [SoapElement(IsNullable = true)]
    public NLPResult nlpResult
    {
      get => this.nlpResultField;
      set => this.nlpResultField = value;
    }

    [SoapElement(IsNullable = true)]
    public OCSConfig osConfig
    {
      get => this.osConfigField;
      set => this.osConfigField = value;
    }

    [SoapElement(IsNullable = true)]
    public PersonalGreeting personalGreeting
    {
      get => this.personalGreetingField;
      set => this.personalGreetingField = value;
    }

    [SoapElement(IsNullable = true)]
    public Agent psAgent
    {
      get => this.psAgentField;
      set => this.psAgentField = value;
    }

    [SoapElement(IsNullable = true)]
    public AgentSetting pwAgentSetting
    {
      get => this.pwAgentSettingField;
      set => this.pwAgentSettingField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDRecStoreType recStoreType
    {
      get => this.recStoreTypeField;
      set => this.recStoreTypeField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGRecording recording
    {
      get => this.recordingField;
      set => this.recordingField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGRecordingStore recstore
    {
      get => this.recstoreField;
      set => this.recstoreField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDReserved reserved
    {
      get => this.reservedField;
      set => this.reservedField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGService serv
    {
      get => this.servField;
      set => this.servField = value;
    }

    [SoapElement(IsNullable = true)]
    public ServerSettings serverSettings
    {
      get => this.serverSettingsField;
      set => this.serverSettingsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UserLocale systemLocale
    {
      get => this.systemLocaleField;
      set => this.systemLocaleField = value;
    }

    [SoapElement(IsNullable = true)]
    public Tenant ten
    {
      get => this.tenField;
      set => this.tenField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDSite udSite
    {
      get => this.udSiteField;
      set => this.udSiteField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyCallDataDef updateServiceCallDataDef
    {
      get => this.updateServiceCallDataDefField;
      set => this.updateServiceCallDataDefField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyCallDataDefFields updateServiceCallDataDefFields
    {
      get => this.updateServiceCallDataDefFieldsField;
      set => this.updateServiceCallDataDefFieldsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyDispositionPlan updateServiceDispositionPlan
    {
      get => this.updateServiceDispositionPlanField;
      set => this.updateServiceDispositionPlanField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyDispositions updateServiceDispositions
    {
      get => this.updateServiceDispositionsField;
      set => this.updateServiceDispositionsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyServiceSettings updateServiceServiceSettings
    {
      get => this.updateServiceServiceSettingsField;
      set => this.updateServiceServiceSettingsField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyUrl updateServiceUrl
    {
      get => this.updateServiceUrlField;
      set => this.updateServiceUrlField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDNotifyService updateSeviceService
    {
      get => this.updateSeviceServiceField;
      set => this.updateSeviceServiceField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGVMGroup vmgrp
    {
      get => this.vmgrpField;
      set => this.vmgrpField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDVoiceLock voiceLock
    {
      get => this.voiceLockField;
      set => this.voiceLockField = value;
    }

    [SoapElement(IsNullable = true)]
    public UDVoiceUnlock voiceUnlock
    {
      get => this.voiceUnlockField;
      set => this.voiceUnlockField = value;
    }

    [SoapElement(IsNullable = true)]
    public SGWorkgroup wrkgrp
    {
      get => this.wrkgrpField;
      set => this.wrkgrpField = value;
    }
  }
}
