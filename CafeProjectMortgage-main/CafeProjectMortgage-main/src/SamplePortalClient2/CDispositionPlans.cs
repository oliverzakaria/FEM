// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CDispositionPlans
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using System;

namespace SamplePortalClient
{
  public class CDispositionPlans : CList
  {
    private CApp mpApp;
    private CDispositions mpDispositions;

    internal CDispositionPlans(CApp pApp)
    {
      this.mpApp = pApp;
      this.mpDispositions = new CDispositions();
    }

    public CDispositionPlan this[int index] => (CDispositionPlan) base[index];

    public CDispositionPlan GetByKey(object key) => (CDispositionPlan) base.GetByKey(key);

    internal void LoadDisposition(int dispositionId)
    {
      Disposition info = (Disposition) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, new UDInfo()
      {
        listType = 111,
        dispostionId = dispositionId
      });
      if (!this.mpDispositions.Contains((object) dispositionId))
        return;
      CDisposition byKey = this.mpDispositions.GetByKey((object) dispositionId);
      byKey.code = info.code;
      byKey.description = info.description;
      byKey.isCallback = Convert.ToBoolean(info.callbackf);
      byKey.isExclusion = Convert.ToBoolean(info.exclusionf);
      byKey.isSale = Convert.ToBoolean(info.salesf);
    }

    internal void LoadDispositionPlan(int serviceId)
    {
      try
      {
        UDInfo info1 = new UDInfo();
        info1.serviceId = serviceId;
        if (this.mpApp.CurrentAgent.AgentArg.agentIndex == 0)
          this.mpApp.CurrentAgent.AgentArg.agentIndex = this.mpApp.CurrentAgent.agentIndex;
        info1.listType = 109;
        DispositionPlan info2 = (DispositionPlan) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, info1);
        CDispositionPlan cdispositionPlan;
        if (this.Contains((object) info2.dispplanid))
        {
          cdispositionPlan = (CDispositionPlan) base.GetByKey((object) info2.dispplanid);
          cdispositionPlan.description = info2.desc;
          cdispositionPlan.Dispositions.Clear();
        }
        else
        {
          cdispositionPlan = new CDispositionPlan(info2.dispplanid, info2.desc);
          this.Add((object) cdispositionPlan.Id, (object) cdispositionPlan);
        }
        info1.listType = 110;
        foreach (Dispositions dispositions in (Dispositions[]) this.mpApp.Portal.WSAgent.getInfo(this.mpApp.CurrentAgent.AgentArg, info1))
        {
          CDisposition cdisposition;
          if (this.mpDispositions.Contains((object) dispositions.dispid))
          {
            cdisposition = this.mpDispositions.GetByKey((object) dispositions.dispid);
            cdisposition.code = dispositions.code;
            cdisposition.description = dispositions.description;
            cdisposition.isCallback = Convert.ToBoolean(dispositions.callbackf);
            cdisposition.isExclusion = Convert.ToBoolean(dispositions.exclusionf);
            cdisposition.isSale = Convert.ToBoolean(dispositions.salesf);
          }
          else
          {
            cdisposition = new CDisposition(dispositions.dispid, dispositions.description, dispositions.code, Convert.ToBoolean(dispositions.salesf), Convert.ToBoolean(dispositions.callbackf), Convert.ToBoolean(dispositions.exclusionf));
            this.mpDispositions.Add((object) cdisposition.Id, cdisposition);
          }
          cdispositionPlan.Dispositions.Add((object) cdisposition.Id, cdisposition);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Disposition Plan load using Service ID is failed - ", ex);
      }
    }

    internal void LoadDispositionPlan(SamplePortalClient.EPEventsWS.UDNewService oNewService)
    {
      try
      {
        CDispositionPlan cdispositionPlan;
        if (this.Contains((object) oNewService.dispositionPlan.dispplanid))
        {
          cdispositionPlan = (CDispositionPlan) base.GetByKey((object) oNewService.dispositionPlan.dispplanid);
          cdispositionPlan.description = oNewService.dispositionPlan.desc;
          cdispositionPlan.Dispositions.Clear();
        }
        else
        {
          cdispositionPlan = new CDispositionPlan(oNewService.dispositionPlan.dispplanid, oNewService.dispositionPlan.desc);
          this.Add((object) cdispositionPlan.Id, (object) cdispositionPlan);
        }
        foreach (SamplePortalClient.EPEventsWS.UDNotifyDispositions disposition in oNewService.dispositions)
        {
          CDisposition cdisposition;
          if (this.mpDispositions.Contains((object) disposition.dispid))
          {
            cdisposition = this.mpDispositions.GetByKey((object) disposition.dispid);
            cdisposition.code = disposition.code;
            cdisposition.description = disposition.description;
            cdisposition.isCallback = Convert.ToBoolean(disposition.callbackf);
            cdisposition.isExclusion = Convert.ToBoolean(disposition.exclusionf);
            cdisposition.isSale = Convert.ToBoolean(disposition.salesf);
          }
          else
          {
            cdisposition = new CDisposition(disposition.dispid, disposition.description, disposition.code, Convert.ToBoolean(disposition.salesf), Convert.ToBoolean(disposition.callbackf), Convert.ToBoolean(disposition.exclusionf));
            this.mpDispositions.Add((object) cdisposition.Id, cdisposition);
          }
          cdispositionPlan.Dispositions.Add((object) cdisposition.Id, cdisposition);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Load Disposition plan with New Service ID failed - ", ex);
      }
    }
  }
}
