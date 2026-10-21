// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CAssignedServices
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CAssignedServices : CList
  {
    private CApp mpApp;

    internal CAssignedServices(CApp pApp) => this.mpApp = pApp;

    public CService this[int index] => (CService) base[index];

    public CService GetByKey(object key) => (CService) base.GetByKey(key);

    internal void Load(int key)
    {
      try
      {
        if (this.Contains((object) key))
          this.RemoveByKey((object) key);
        Console.WriteLine(string.Format("Loading service info for ServiceId <{0}>...\t[{1}]", (object) key, (object) this.GetType()));
        Service info = (Service) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 106,
          serviceId = key
        });
        CService oService;
        switch (info.servicetypeid)
        {
          case 4:
            oService = (CService) new CServiceAOD();
            break;
          case 5:
            oService = (CService) new CServiceChat();
            break;
          default:
            oService = new CService();
            break;
        }
        oService.serviceId = info.serviceid;
        oService.serviceType = (ServiceType) info.servicetypeid;
        oService.serviceName = info.servicec;
        oService.dialMask = info.outgoingmask;
        Console.WriteLine("Disposition Plan of ServiceId <{0}>: {1} \t[{2}]", (object) key, (object) info.dispplanid, (object) this.GetType());
        if (info.dispplanid != 0 && !this.mpApp.DispositionPlans.Contains((object) info.dispplanid))
        {
          Console.WriteLine("Loading Disposition Plan <{0}>...\t[{1}]", (object) info.dispplanid, (object) this.GetType());
          this.mpApp.DispositionPlans.LoadDispositionPlan(info.serviceid);
        }
        if ((uint) info.dispplanid > 0U)
          oService.dispositionPlan = this.mpApp.DispositionPlans.GetByKey((object) info.dispplanid);
        this.Load(oService);
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    internal void Load(CService oService)
    {
      try
      {
        if (this.Contains((object) oService.serviceId))
          this.RemoveByKey((object) oService.serviceId);
        ServiceSettings info1 = (ServiceSettings) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
        {
          listType = 107,
          serviceId = oService.serviceId,
          serviceType = (int) oService.serviceType
        });
        oService.allowHangup = Convert.ToBoolean(info1.btnhangupf);
        oService.allowDial = Convert.ToBoolean(info1.btndialf);
        oService.allow3Way = Convert.ToBoolean(info1.btnxferf);
        oService.allowConsult = Convert.ToBoolean(info1.btnconsultf);
        oService.allowConsultHangup = Convert.ToBoolean(info1.btnthreecusthangupf);
        oService.allowHold = oService.ServiceType != ServiceType.AGD && Convert.ToBoolean(info1.btnholdf);
        oService.allowBlindXfer = oService.ServiceType == ServiceType.AGD || Convert.ToBoolean(info1.btnblindxferf);
        oService.allowWarmXfer = Convert.ToBoolean(info1.warmtransfer);
        oService.allowConference = Convert.ToBoolean(info1.btnthreewayf);
        oService.allowRecord = Convert.ToBoolean(info1.btnrecordf);
        oService.allowPlay = Convert.ToBoolean(info1.btnplayf);
        oService.showCallData = Convert.ToBoolean(info1.showcalldatadialogf);
        oService.showCallDataSecs = info1.calldatadialogduration;
        oService.callDataDefId = info1.calldatadefid;
        oService.requireWrap = (WrapType) info1.reqwrapf;
        oService.wrapAlarmSecs = info1.wrapwarningdelay;
        oService.wrapMaxSecs = info1.maxWrapTime;
        oService.wrapMinSecs = info1.minWrapTime;
        oService.previewTimeoutSecs = info1.previewtimeoutinsecs;
        oService.timedpreviewflag = info1.timedpreviewflag;
        oService.warmtransfer = info1.warmtransfer;
        oService.serviceid = info1.serviceid;
        oService.cbservicecallbackflag = info1.cbservicecallbackflag;
        oService.cbselfcallbackflag = info1.cbselfcallbackflag;
        oService.allowphonechangeinpreview = info1.allowphonechangeinpreview;
        oService.requireDisposition = Convert.ToBoolean(info1.reqdispositionf);
        oService.noDispMaxWrapSecs = 0;
        oService.allowNextCall = Convert.ToBoolean(info1.btnnextcall);
        oService.application = info1.appdesc;
        oService.callbackDays = info1.callbackdays;
        switch (oService)
        {
          case CServiceAOD _:
            ((CServiceAOD) oService).allowPreviewNumberChange = Convert.ToBoolean(info1.allowphonechangeinpreview);
            ((CServiceAOD) oService).timedPreview = Convert.ToBoolean(info1.timedpreviewflag);
            ((CServiceAOD) oService).timedPreviewSecs = info1.previewtimeoutinsecs;
            break;
          case CServiceManual _:
            ((CServiceManual) oService).allowSelfCallbacks = Convert.ToBoolean(info1.cbselfcallbackflag);
            AgentSetting info2 = (AgentSetting) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
            {
              listType = 162
            });
            ((CServiceManual) oService).showServiceListForManualDial = Convert.ToBoolean(info2.displayServicesF);
            ((CServiceManual) oService).requireServiceForManualDial = Convert.ToBoolean(info2.requireServiceF);
            break;
          case CServiceChat _:
            ((CServiceChat) oService).allowChatDisconnect = Convert.ToBoolean(info1.chatdisconnectallowed);
            break;
        }
        this.Add((object) oService.serviceId, (object) oService);
      }
      catch (Exception ex)
      {
        throw new Exception("Service Library updation failed - ", ex);
      }
    }

    internal void Load(SamplePortalClient.EPEventsWS.UDNewService oNewService)
    {
      try
      {
        if (this.Contains((object) oNewService.serviceID))
          this.RemoveByKey((object) oNewService.serviceID);
        Console.WriteLine("Loading service info for ServiceId <{0}>...\t[{1}]", (object) oNewService.serviceID, (object) this.GetType());
        CService cservice;
        switch (oNewService.serviceInfo.servicetypeid)
        {
          case 4:
            cservice = (CService) new CServiceAOD();
            break;
          case 5:
            cservice = (CService) new CServiceChat();
            break;
          default:
            cservice = new CService();
            break;
        }
        cservice.serviceId = oNewService.serviceID;
        cservice.serviceType = (ServiceType) oNewService.serviceInfo.servicetypeid;
        cservice.serviceName = oNewService.serviceInfo.servicec;
        cservice.dialMask = oNewService.serviceInfo.outgoingmask;
        Console.WriteLine("Disposition Plan of ServiceId <{0}>: {1} \t[{2}]", (object) oNewService.serviceID, (object) oNewService.dispositionPlan.dispplanid, (object) this.GetType());
        if (oNewService.serviceInfo.dispplanid != 0 && !this.mpApp.DispositionPlans.Contains((object) oNewService.serviceInfo.dispplanid))
        {
          Console.WriteLine("Loading Disposition Plan <{0}>...\t[{1}]", (object) oNewService.serviceInfo.dispplanid, (object) this.GetType());
          this.mpApp.DispositionPlans.LoadDispositionPlan(oNewService);
        }
        cservice.dispositionPlan = this.mpApp.DispositionPlans.GetByKey((object) oNewService.serviceInfo.dispplanid);
        cservice.allowHangup = Convert.ToBoolean(oNewService.serviceSettings.btnhangupf);
        cservice.allowDial = Convert.ToBoolean(oNewService.serviceSettings.btndialf);
        cservice.allow3Way = Convert.ToBoolean(oNewService.serviceSettings.btnxferf);
        cservice.allowConsult = Convert.ToBoolean(oNewService.serviceSettings.btnconsultf);
        cservice.allowConsultHangup = Convert.ToBoolean(oNewService.serviceSettings.btnthreecusthangupf);
        cservice.allowHold = cservice.ServiceType != ServiceType.AGD && Convert.ToBoolean(oNewService.serviceSettings.btnholdf);
        cservice.allowBlindXfer = cservice.ServiceType == ServiceType.AGD || Convert.ToBoolean(oNewService.serviceSettings.btnblindxferf);
        cservice.allowWarmXfer = Convert.ToBoolean(oNewService.serviceSettings.warmtransfer);
        cservice.allowConference = Convert.ToBoolean(oNewService.serviceSettings.btnthreewayf);
        cservice.allowRecord = Convert.ToBoolean(oNewService.serviceSettings.btnrecordf);
        cservice.allowPlay = Convert.ToBoolean(oNewService.serviceSettings.btnplayf);
        cservice.showCallData = Convert.ToBoolean(oNewService.serviceSettings.showcalldatadialogf);
        cservice.showCallDataSecs = oNewService.serviceSettings.calldatadialogduration;
        cservice.callDataDefId = oNewService.serviceSettings.calldatadefid;
        cservice.requireWrap = (WrapType) oNewService.serviceSettings.reqwrapf;
        cservice.wrapAlarmSecs = oNewService.serviceSettings.wrapwarningdelay;
        cservice.wrapMaxSecs = 0;
        cservice.wrapMinSecs = 1;
        cservice.wrapMaxSecs = oNewService.serviceSettings.maxWrapTime;
        cservice.wrapMinSecs = oNewService.serviceSettings.minWrapTime;
        cservice.requireDisposition = Convert.ToBoolean(oNewService.serviceSettings.reqdispositionf);
        cservice.noDispMaxWrapSecs = 0;
        cservice.allowNextCall = Convert.ToBoolean(oNewService.serviceSettings.btnnextcall);
        cservice.application = oNewService.serviceSettings.appdesc;
        cservice.previewTimeoutSecs = oNewService.serviceSettings.previewtimeoutinsecs;
        cservice.timedpreviewflag = oNewService.serviceSettings.timedpreviewflag;
        cservice.warmtransfer = oNewService.serviceSettings.warmtransfer;
        cservice.serviceid = oNewService.serviceSettings.serviceid;
        cservice.cbservicecallbackflag = oNewService.serviceSettings.cbservicecallbackflag;
        cservice.cbselfcallbackflag = oNewService.serviceSettings.cbselfcallbackflag;
        cservice.allowphonechangeinpreview = oNewService.serviceSettings.allowphonechangeinpreview;
        cservice.callbackDays = oNewService.serviceSettings.callbackdays;
        switch (cservice)
        {
          case CServiceAOD _:
            ((CServiceAOD) cservice).allowPreviewNumberChange = Convert.ToBoolean(oNewService.serviceSettings.allowphonechangeinpreview);
            ((CServiceAOD) cservice).timedPreview = Convert.ToBoolean(oNewService.serviceSettings.timedpreviewflag);
            ((CServiceAOD) cservice).timedPreviewSecs = oNewService.serviceSettings.previewtimeoutinsecs;
            break;
          case CServiceChat _:
            ((CServiceChat) cservice).allowChatDisconnect = Convert.ToBoolean(oNewService.serviceSettings.chatdisconnectallowed);
            break;
        }
        this.Add((object) cservice.serviceId, (object) cservice);
      }
      catch (Exception ex)
      {
        throw new Exception("Service Library for New Service failed - ", ex);
      }
    }
  }
}
