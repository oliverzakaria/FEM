using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePortalClientUI
{
    internal class RowAgentStats
    {
        public string Service { get; set; }

        public int Contacts { get; set; }

        public int Successes { get; set; }

        public int Refusals { get; set; }

        public string LoggedIn { get; set; }

        public string Active { get; set; }

        public string Idle { get; set; }

        public string Wrap { get; set; }

        public string NotReady { get; set; }

        public string Park { get; set; }

        public string Occupancy { get; set; }

        public string Manual { get; set; }
    }
    internal class RowAgentStatsTotal
    {
        public string ServiceTot { get; set; }

        public string ContactsTot { get; set; }

        public string SuccessesTot { get; set; }

        public string RefusalsTot { get; set; }

        public string LoggedInTot { get; set; }

        public string ActiveTot { get; set; }

        public string IdleTot { get; set; }

        public string WrapTot { get; set; }

        public string NotReadyTot { get; set; }

        public string ParkTot { get; set; }

        public string OccupancyTot { get; set; }

        public string ManualTot { get; set; }
    }
    public class AgentStatisticRecord
    {
        public string serviceId;
        public int numberOfSuccesses;
        public int numberOfRefusals;
        public int contacts;
        public string loggedInSeconds;
        public string activeSeconds;
        public string idleSeconds;
        public string wrapSeconds;
        public string notReadySeconds;
        public string occupancy;
        public string manualSeconds;
        public string parkSeconds;

        public string ServiceId
        {
            get => this.serviceId;
            set => this.serviceId = value;
        }

        public int NumberOfSuccesses
        {
            get => this.numberOfSuccesses;
            set => this.numberOfSuccesses = value;
        }

        public int NumberOfRefusals
        {
            get => this.numberOfRefusals;
            set => this.numberOfRefusals = value;
        }

        public int Contacts
        {
            get => this.contacts;
            set => this.contacts = value;
        }

        public string LoggedInSeconds
        {
            get => this.loggedInSeconds;
            set => this.loggedInSeconds = value;
        }

        public string ActiveSeconds
        {
            get => this.activeSeconds;
            set => this.activeSeconds = value;
        }

        public string IdleSeconds
        {
            get => this.idleSeconds;
            set => this.idleSeconds = value;
        }

        public string WrapSeconds
        {
            get => this.wrapSeconds;
            set => this.wrapSeconds = value;
        }

        public string NotReadySeconds
        {
            get => this.notReadySeconds;
            set => this.notReadySeconds = value;
        }

        public string Occupancy
        {
            get => this.occupancy;
            set => this.occupancy = value;
        }

        public string ManualSeconds
        {
            get => this.manualSeconds;
            set => this.manualSeconds = value;
        }

        public string ParkSeconds
        {
            get => this.parkSeconds;
            set => this.parkSeconds = value;
        }

        public AgentStatisticRecord()
        {
            this.serviceId = string.Empty;
            this.numberOfSuccesses = 0;
            this.numberOfRefusals = 0;
            this.contacts = 0;
            this.loggedInSeconds = string.Empty;
            this.activeSeconds = string.Empty;
            this.idleSeconds = string.Empty;
            this.wrapSeconds = string.Empty;
            this.notReadySeconds = string.Empty;
            this.occupancy = string.Empty;
            this.manualSeconds = string.Empty;
            this.parkSeconds = string.Empty;
        }

        public void SetAgentStatisticRecord(
          string sid,
          int nos,
          int nor,
          int cts,
          string liSec,
          string aSec,
          string idlSec,
          string wrapSec,
          string nRSec,
          string occ,
          string manualSec,
          string parkSec)
        {
            this.serviceId = sid;
            this.numberOfSuccesses = nos;
            this.numberOfRefusals = nor;
            this.contacts = cts;
            this.loggedInSeconds = liSec;
            this.activeSeconds = aSec;
            this.idleSeconds = idlSec;
            this.wrapSeconds = wrapSec;
            this.notReadySeconds = nRSec;
            this.occupancy = occ;
            this.manualSeconds = manualSec;
            this.parkSeconds = parkSec;
        }
    }
}
