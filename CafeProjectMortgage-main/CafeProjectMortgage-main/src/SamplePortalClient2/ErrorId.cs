// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.ErrorId
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

namespace SamplePortalClient
{
  public enum ErrorId
  {
    errCTINotReadyFailure = 4,
    errGeneralFailure = 10, // 0x0000000A
    errCallerIsInInvalidState = 11, // 0x0000000B
    errXferToServiceFailed = 12, // 0x0000000C
    errExternalRouteUnknown = 13, // 0x0000000D
    errSpeedDialOperationFailed = 14, // 0x0000000E
    errMonitoringFailure = 15, // 0x0000000F
    errCTILoginFailure = 16, // 0x00000010
    errGatewayLoginFailure = 17, // 0x00000011
    errCTIServerDown = 18, // 0x00000012
    errNoActiveService = 19, // 0x00000013
    errInvalidAgentState = 20, // 0x00000014
    errTransferFailure = 28, // 0x0000001C
    errMonitorStartFailure = 29, // 0x0000001D
    errMonitorStopFailure = 30, // 0x0000001E
    errHoldFailure = 31, // 0x0000001F
    errRetrieveHoldFailure = 32, // 0x00000020
    errMakeCallFailure = 33, // 0x00000021
    errHangupFailure = 34, // 0x00000022
    errConsultationFailure = 38, // 0x00000026
    errCallDisconnected = 40, // 0x00000028
    errConsultationXferFailure = 45, // 0x0000002D
    errConsultationHangupFailure = 46, // 0x0000002E
    errConferenceFailure = 69, // 0x00000045
    errCallInProgress = 100, // 0x00000064
    errAgentNotAvailable = 110, // 0x0000006E
    errInvalidRouteAccess = 120, // 0x00000078
    errRouteBusy = 130, // 0x00000082
    errNumberNotInNumberingPlan = 131, // 0x00000083
    errTimeZoneFailure = 132, // 0x00000084
    errCustomerHungupWaitingForXfer = 140, // 0x0000008C
    errESwitchServiceFailure = 150, // 0x00000096
    errTrunkLicenseExceeded = 174, // 0x000000AE
    errAgentLicenseExceeded = 175, // 0x000000AF
  }
}
