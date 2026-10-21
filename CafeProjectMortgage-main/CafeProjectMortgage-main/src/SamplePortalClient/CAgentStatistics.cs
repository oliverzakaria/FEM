
using SamplePortalClient.EPEventsWS;
using System;
using System.Reflection;

namespace SamplePortalClient
{
    //internal class CAgentStatistics : IEventHandler
    //{
    //  private CApp mpApp;
    //  private CEventManagerHelper mpEventHelper;

    //  public CAgentStatistics(CApp pApp, CEventManagerHelper pEventHelper)
    //  {
    //    this.mpApp = pApp;
    //    this.mpEventHelper = pEventHelper;
    //  }

    //  public void ProcessEvent(CAgentEvent pEvent)
    //  {
    //    UDAgentStatsCollection payload = (UDAgentStatsCollection) pEvent.Payload;
    //    this.mpApp.CurrentAgent.AgentStatistics = payload;
    //    this.mpApp.CurrentAgent.agentIndex = payload.agentIndex;
    //    this.mpApp.EnableKeepAlives = true;
    //  }
    //}
    internal class AgentStatsEventMessageHandler : IEventHandler
    {
        private CApp _application;
        private CEventManagerHelper _stateManager;
        public AgentStatsEventMessageHandler(CApp application, CEventManagerHelper stateManager)
        {
            this._application = application;
            this._stateManager = stateManager;
        }

        public void ProcessEvent(CAgentEvent agentEventMessage)
        {
            UDAgentStatsCollection payload = (UDAgentStatsCollection)agentEventMessage.Payload;
            AgentStat agentStat1 = new AgentStat()
            {
                AcdCalls = payload.UDAgentStats.acdCalls,
                ActiveSeconds = payload.UDAgentStats.activeSeconds,
                AgdCalls = payload.UDAgentStats.agdCalls,
                AgentIndex = payload.UDAgentStats.agentIndex,
                AodCalls = payload.UDAgentStats.aodCalls,
                ChatCalls = payload.UDAgentStats.chatCalls,
                CtiCalls = payload.UDAgentStats.CTICalls,
                DidCalls = payload.UDAgentStats.didCalls,
                EMailCalls = payload.UDAgentStats.EMailCalls,
                IdleSeconds = payload.UDAgentStats.idleSeconds,
                LoggedInSeconds = payload.UDAgentStats.loggedInSeconds,
                NotReadySeconds = payload.UDAgentStats.notReadySeconds,
                NumberOfCallbacks = payload.UDAgentStats.numberOfCallbacks,
                NumberOfRefusals = payload.UDAgentStats.numberOfRefusals,
                NumberOfSuccesses = payload.UDAgentStats.numberOfSuccesses,
                OtherSeconds = payload.UDAgentStats.otherSeconds,
                Service = payload.UDAgentStats.service,
                ServiceId = payload.UDAgentStats.serviceId,
                Station = payload.UDAgentStats.station,
                StatusSeconds = payload.UDAgentStats.statusSeconds,
                StatusStartTimeMilitary = payload.UDAgentStats.statusStartTimeMilitary,
                UserId = payload.UDAgentStats.userId,
                WrapSeconds = payload.UDAgentStats.wrapSeconds,
                IMCalls = payload.UDAgentStats.IMCalls,
                ManualSeconds = payload.UDAgentStats.manualSeconds,
                ParkSeconds = payload.UDAgentStats.parkSeconds
            };
            AgentStat[] agentStatArray = new AgentStat[payload.lstAgentStatistics.Length];
            int index = 0;
            foreach (UDAgentStats lstAgentStatistic in payload.lstAgentStatistics)
            {
                AgentStat agentStat2 = new AgentStat()
                {
                    AcdCalls = payload.lstAgentStatistics[index].acdCalls,
                    ActiveSeconds = payload.lstAgentStatistics[index].activeSeconds,
                    AgdCalls = payload.lstAgentStatistics[index].agdCalls,
                    AgentIndex = payload.lstAgentStatistics[index].agentIndex,
                    AodCalls = payload.lstAgentStatistics[index].aodCalls,
                    ChatCalls = payload.lstAgentStatistics[index].chatCalls,
                    CtiCalls = payload.lstAgentStatistics[index].CTICalls,
                    DidCalls = payload.lstAgentStatistics[index].didCalls,
                    EMailCalls = payload.lstAgentStatistics[index].EMailCalls,
                    IdleSeconds = payload.lstAgentStatistics[index].idleSeconds,
                    LoggedInSeconds = payload.lstAgentStatistics[index].loggedInSeconds,
                    NotReadySeconds = payload.lstAgentStatistics[index].notReadySeconds,
                    NumberOfCallbacks = payload.lstAgentStatistics[index].numberOfCallbacks,
                    NumberOfRefusals = payload.lstAgentStatistics[index].numberOfRefusals,
                    NumberOfSuccesses = payload.lstAgentStatistics[index].numberOfSuccesses,
                    OtherSeconds = payload.lstAgentStatistics[index].otherSeconds,
                    Service = payload.lstAgentStatistics[index].service,
                    ServiceId = payload.lstAgentStatistics[index].serviceId,
                    Station = payload.lstAgentStatistics[index].station,
                    StatusSeconds = payload.lstAgentStatistics[index].statusSeconds,
                    StatusStartTimeMilitary = payload.lstAgentStatistics[index].statusStartTimeMilitary,
                    UserId = payload.lstAgentStatistics[index].userId,
                    WrapSeconds = payload.lstAgentStatistics[index].wrapSeconds,
                    IMCalls = payload.lstAgentStatistics[index].IMCalls,
                    ManualSeconds = payload.lstAgentStatistics[index].manualSeconds,
                    ParkSeconds = payload.lstAgentStatistics[index].parkSeconds
                };
                agentStatArray[index] = agentStat2;
                ++index;
            }
            AgentStatData iAgentStatData = new AgentStatData()
            {
                AgentIndex = payload.agentIndex,
                AgentStat = agentStat1,
                AgentStats = agentStatArray
            };
            this._application.OnAgentStats(new AgentStatsEventArgs(iAgentStatData));
            //try
            //{
            //    this._application._ClientServiceHost.ClientService.ClientEvents.Callback.EventAgentStats(payload);
            //}
            //catch (Exception ex)
            //{
            //    //AgentStatsEventMessageHandler._log.ErrorFormat("[{0}] {1}", (object)MethodBase.GetCurrentMethod().Name, (object)ex.StackTrace);
            //}
        }
    }
}