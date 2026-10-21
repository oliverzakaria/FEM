// Decompiled with JetBrains decompiler
// Type: SamplePortalClient.CAgent
// Assembly: SamplePortalClient, Version=1.0.9337.19967, Culture=neutral, PublicKeyToken=null
// MVID: 1D923F2E-5C60-41E8-9709-AD761823608D
// Assembly location: C:\data\SamplePortalClient.dll

using SamplePortalClient.EPAgentWS;
using SamplePortalClient.EPEventsWS;

namespace SamplePortalClient
{
  public class CAgent : CServiceManual
  {
    internal UDAgentStatsCollection awsStatistics = (UDAgentStatsCollection) null;
    internal int site = 0;
    internal string awsVersion = (string) null;
    internal string tenant = (string) null;
    internal bool allowPark;
    internal int parkAlarmSecs;
    internal int routeAccessId;
    internal string firstName;
    internal string lastName;
    private UDAgentInfo mpAgentInfoArg;
    private UDAgent mpAgentArg;

    public int InitState
    {
      get => this.mpAgentArg.initState;
      set => this.mpAgentArg.initState = value;
    }

    public string LDAPUserId => this.ldapUserId;

    internal string ldapUserId
    {
      get => this.mpAgentArg.LDAPUserId;
      set => this.mpAgentArg.LDAPUserId = value;
    }

    public int ClientRole => this.clientRole;

    internal int clientRole
    {
      get => this.mpAgentArg.clientRole;
      set => this.mpAgentArg.clientRole = value;
    }

    public int ServerType => this.serverType;

    internal int serverType
    {
      get => this.mpAgentArg.serverType;
      set
      {
        this.mpAgentArg.serverType = value;
        this.mpAgentInfoArg.serverType = value;
      }
    }

    public string LoginName => this.loginName;

    internal string loginName
    {
      get => this.mpAgentArg.agentLoginName;
      set
      {
        this.mpAgentArg.agentLoginName = value;
        this.mpAgentInfoArg.agentLoginName = value;
      }
    }

    public string Password => this.password;

    internal string password
    {
      get => this.mpAgentInfoArg.password;
      set => this.mpAgentInfoArg.password = value;
    }

    public string Station => this.station;

    internal string station
    {
      get => this.mpAgentInfoArg.stationId;
      set => this.mpAgentInfoArg.stationId = value;
    }

    public int AgentType => this.agentType;

    internal int agentType
    {
      get => this.mpAgentInfoArg.agentType;
      set => this.mpAgentInfoArg.agentType = value;
    }

    public int WorkgroupId => this.workgroupId;

    internal int workgroupId
    {
      get => this.mpAgentInfoArg.agentWorkgroupID;
      set => this.mpAgentInfoArg.agentWorkgroupID = value;
    }

    public int ReferenceId => this.referenceId;

    internal int referenceId
    {
      get => this.mpAgentInfoArg.referenceID;
      set => this.mpAgentInfoArg.referenceID = value;
    }

    public int AgentIndex => this.agentIndex;

    internal int agentIndex
    {
      get => this.mpAgentInfoArg.agentIndex;
      set
      {
        this.mpAgentInfoArg.agentIndex = value;
        this.mpAgentArg.agentIndex = value;
      }
    }

    public int GatewayId => this.gatewayId;

    internal int gatewayId
    {
      get => this.mpAgentInfoArg.ntSwitchID;
      set => this.mpAgentInfoArg.ntSwitchID = value;
    }

    public bool Multiline { get; set; }

    public UDAgentStatsCollection AgentStatistics
    {
      get => this.awsStatistics;
      set => this.awsStatistics = value;
    }

    public int Site => this.site;

    public string AWSVersion => this.awsVersion;

    public string Tenant => this.tenant;

    public bool AllowPark => this.allowPark;

    public int ParkAlarmSecs => this.parkAlarmSecs;

    public int RouteAccessId => this.routeAccessId;

    public string FirstName => this.firstName;

    public string LastName => this.lastName;

    public string AgentId => this.mpAgentArg.agentLoginName;

    public UDAgent AgentArg => this.mpAgentArg;

    public UDAgentInfo AgentInfoArg => this.mpAgentInfoArg;

    internal CAgent()
    {
      this.mpAgentArg = new UDAgent();
      this.mpAgentInfoArg = new UDAgentInfo();
    }
  }
}
