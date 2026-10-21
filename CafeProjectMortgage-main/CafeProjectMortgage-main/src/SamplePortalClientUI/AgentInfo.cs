using SamplePortalClient;
using SamplePortalClient.EPEventsWS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using static System.Windows.Forms.AxHost;

namespace SamplePortalClientUI
{
    public partial class AgentInfo : Form
    {
        public string UserName
        {
            get => this._userName;
            set
            {
                this._userName = value;
                this.OnPropertyChanged(nameof(UserName));
            }
        }

        public string CurrentDate
        {
            get => this._currentDate;
            set
            {
                this._currentDate = value;
                this.OnPropertyChanged(nameof(CurrentDate));
            }
        }

        public string CurrentTime
        {
            get => this._currentTime;
            set
            {
                this._currentTime = value;
                this.OnPropertyChanged(nameof(CurrentTime));
            }
        }

        public int ContactsTotals
        {
            get => this._contactsTotals;
            set
            {
                this._contactsTotals = value;
                this.OnPropertyChanged(nameof(ContactsTotals));
            }
        }

        public int SuccessesTotals
        {
            get => this._successesTotals;
            set
            {
                this._successesTotals = value;
                this.OnPropertyChanged(nameof(SuccessesTotals));
            }
        }

        public int RefusalsTotals
        {
            get => this._refusalsTotals;
            set
            {
                this._refusalsTotals = value;
                this.OnPropertyChanged(nameof(RefusalsTotals));
            }
        }

        public string ActiveTotalString
        {
            get => this._activeTotalString;
            set
            {
                this._activeTotalString = value;
                this.OnPropertyChanged(nameof(ActiveTotalString));
            }
        }

        public string IdleTotalString
        {
            get => this._idleTotalString;
            set
            {
                this._idleTotalString = value;
                this.OnPropertyChanged(nameof(IdleTotalString));
            }
        }

        public string WrapTotalString
        {
            get => this._wrapTotalString;
            set
            {
                this._wrapTotalString = value;
                this.OnPropertyChanged(nameof(WrapTotalString));
            }
        }

        public string ManualTotalString
        {
            get => this._manualTotalString;
            set
            {
                this._manualTotalString = value;
                this.OnPropertyChanged(nameof(ManualTotalString));
            }
        }

        public int Inbound
        {
            get => this._inbound;
            set
            {
                this._inbound = value;
                this.OnPropertyChanged(nameof(Inbound));
            }
        }

        public int Outbound
        {
            get => this._outbound;
            set
            {
                this._outbound = value;
                this.OnPropertyChanged(nameof(Outbound));
            }
        }

        public int Chats
        {
            get => this._chats;
            set
            {
                this._chats = value;
                this.OnPropertyChanged(nameof(Chats));
            }
        }

        public int Cti
        {
            get => this._cti;
            set
            {
                this._cti = value;
                this.OnPropertyChanged(nameof(Cti));
            }
        }

        public int Email
        {
            get => this._email;
            set
            {
                this._email = value;
                this.OnPropertyChanged(nameof(Email));
            }
        }

        public int Workflow
        {
            get => this._workflow;
            set
            {
                this._workflow = value;
                this.OnPropertyChanged(nameof(Workflow));
            }
        }

        public int Did
        {
            get => this._did;
            set
            {
                this._did = value;
                this.OnPropertyChanged(nameof(Did));
            }
        }

        public int Im
        {
            get => this._im;
            set
            {
                this._im = value;
                this.OnPropertyChanged(nameof(Im));
            }
        }

        public int Social
        {
            get => this._social;
            set
            {
                this._social = value;
                this.OnPropertyChanged(nameof(Social));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            try
            {
                if (this.PropertyChanged != null)
                    this.PropertyChanged((object)this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private SamplePortalClient.CApp mpApp;
        public AgentInfo()
        {

        }
        public AgentInfo(CApp Capp)
        {

            InitializeComponent();
            mpApp = Capp;
           



        }
        internal void AgentInfoLoad()
        {
            this.ResetAgentStatisticTotals();
            this.ResetAgentStatisticCumulativeTotals();
            lblRefresh_Click(this, EventArgs.Empty);
            this.lblAgentID.Text = this.mpApp.CurrentAgent.AgentId;

            this.lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            this.lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.mpApp.AgentStats += new AgentStatsEventHandler(this.OnAgentStatisticsChanged);
            //this.AgentStatis();
        }
        public void ResetAgentStatisticTotals()
        {
            this.ContactsTotals = 0;
            this.SuccessesTotals = 0;
            this.RefusalsTotals = 0;
            this._activeTotalSeconds = 0;
            this.ActiveTotalString = string.Empty;
            this._idleTotalSeconds = 0;
            this.IdleTotalString = string.Empty;
            this._wrapTotalSeconds = 0;
            this.WrapTotalString = string.Empty;
            this._manualTotalSeconds = 0;
            this.ManualTotalString = string.Empty;
        }

        private void ResetAgentStatisticCumulativeTotals()
        {
            this.Inbound = 0;
            this.Email = 0;
            this.Cti = 0;
            this.Outbound = 0;
            this.Workflow = 0;
            this.Chats = 0;
            this.Did = 0;
            this.Im = 0;
            this.Social = 0;
        }

        public void OnAgentStatisticsChanged(object sender, AgentStatsEventArgs agentStatsEventArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Delegate)new AgentStatsEventHandler(this.OnAgentStatisticsChanged), sender, (object)agentStatsEventArgs);
            }
            else
            {
                try
                {

                    this.ResetAgentStatisticTotals();
                    this.ResetAgentStatisticCumulativeTotals();
                    this._agentStatsData = agentStatsEventArgs.AgentStatData;
                    this._agentStats = this._agentStatsData.AgentStats;
                    if (dgvAgentStatus.RowCount > 0)
                        return;
                    string empty = string.Empty;
                    ArrayList arrayList = new ArrayList();
                    ObservableCollection<AgentStatisticRecord> observableCollection = new ObservableCollection<AgentStatisticRecord>();
                    AgentStatisticRecord agentStatisticRecord1 = new AgentStatisticRecord();
                    List<RowAgentStats> rowAgentStatsList = new List<RowAgentStats>();
                    this.dgvAgentStatus.AutoGenerateColumns = false;
                    for (int index = 0; index < this._agentStats.Length; ++index)
                    {
                        if (this._agentStats[index].ServiceId == 0)
                        {
                            this.Inbound += this._agentStats[index].AcdCalls;
                            this.Email += this._agentStats[index].EMailCalls;
                            this.Cti += this._agentStats[index].CtiCalls;
                            this.Outbound += this._agentStats[index].AodCalls;
                            this.Workflow += this._agentStats[index].AgdCalls;
                            this.Chats += this._agentStats[index].ChatCalls;
                            this.Did += this._agentStats[index].DidCalls;
                            this.Im += this._agentStats[index].IMCalls;
                            //this.Social = this._mainToolbarWindow.SocialVoice;
                        }

                        if (this._agentStats[index].ServiceId != 0)
                        {
                            AgentStatisticRecord agentStatisticRecord2 = new AgentStatisticRecord();
                            int num = this._agentStats[index].NumberOfSuccesses + this._agentStats[index].NumberOfRefusals + this._agentStats[index].NumberOfCallbacks;
                            string occupancy = this.CalculateOccupancy(this._agentStats[index].ServiceId, (double)this._agentStats[index].LoggedInSeconds, (double)this._agentStats[index].NotReadySeconds, (double)this._agentStats[index].IdleSeconds, 0.0, (double)this._agentStats[index].ActiveSeconds);
                            agentStatisticRecord2.SetAgentStatisticRecord(this._agentStats[index].Service, this._agentStats[index].NumberOfSuccesses, this._agentStats[index].NumberOfRefusals, num, this.ConvertSecondsToTime(this._agentStats[index].LoggedInSeconds), this.ConvertSecondsToTime(this._agentStats[index].ActiveSeconds), this.ConvertSecondsToTime(this._agentStats[index].IdleSeconds), this.ConvertSecondsToTime(this._agentStats[index].WrapSeconds), this.ConvertSecondsToTime(this._agentStats[index].NotReadySeconds), occupancy, this.ConvertSecondsToTime(this._agentStats[index].ManualSeconds), this.ConvertSecondsToTime(this._agentStats[index].ParkSeconds));
                            this.UpdateAgentStatisticTotals(this._agentStats[index].NumberOfSuccesses, this._agentStats[index].NumberOfRefusals, num, this.ConvertSecondsToTime(this._agentStats[index].LoggedInSeconds), this._agentStats[index].ActiveSeconds, this._agentStats[index].IdleSeconds, this._agentStats[index].WrapSeconds, this.ConvertSecondsToTime(this._agentStats[index].NotReadySeconds), occupancy, this._agentStats[index].ManualSeconds, this.ConvertSecondsToTime(this._agentStats[index].ParkSeconds));
                            arrayList.Add((object)agentStatisticRecord2);
                            RowAgentStats rowAgentStats1 = new RowAgentStats();
                            rowAgentStats1.Service = agentStatisticRecord2.ServiceId;
                            rowAgentStats1.Contacts = agentStatisticRecord2.Contacts;
                            rowAgentStats1.Refusals = agentStatisticRecord2.NumberOfRefusals;
                            rowAgentStats1.Successes = agentStatisticRecord2.NumberOfSuccesses;
                            rowAgentStats1.LoggedIn = agentStatisticRecord2.LoggedInSeconds;
                            rowAgentStats1.Active = agentStatisticRecord2.ActiveSeconds;
                            rowAgentStats1.Idle = agentStatisticRecord2.IdleSeconds;
                            rowAgentStats1.Wrap = agentStatisticRecord2.WrapSeconds;
                            rowAgentStats1.NotReady = agentStatisticRecord2.NotReadySeconds;
                            rowAgentStats1.Park = agentStatisticRecord2.ParkSeconds;
                            rowAgentStats1.Occupancy = agentStatisticRecord2.Occupancy;
                            rowAgentStats1.Manual = agentStatisticRecord2.ManualSeconds;

                            // num11 += udAgentStats.
                            rowAgentStatsList.Add(rowAgentStats1);
                        }
                    }
                    this.dgvAgentStatus.DataSource = (object)rowAgentStatsList;
                    //dgvAgentStatus.DataSource = (IEnumerable)rowAgentStatsList;
                    //this.contactsListView.ItemsSource = (IEnumerable)arrayList;
                    agentStatisticRecord1.NumberOfSuccesses = this.SuccessesTotals;
                    agentStatisticRecord1.NumberOfRefusals = this.RefusalsTotals;
                    agentStatisticRecord1.Contacts = this.ContactsTotals;
                    agentStatisticRecord1.ActiveSeconds = this.ActiveTotalString;
                    agentStatisticRecord1.IdleSeconds = "N/A";
                    agentStatisticRecord1.WrapSeconds = this.WrapTotalString;
                    agentStatisticRecord1.ManualSeconds = this.ManualTotalString;
                    agentStatisticRecord1.LoggedInSeconds = "N/A";
                    agentStatisticRecord1.NotReadySeconds = "N/A";
                    agentStatisticRecord1.Occupancy = "N/A";
                    observableCollection.Add(agentStatisticRecord1);
                    RowAgentStatsTotal total=new RowAgentStatsTotal();
                    total.ServiceTot = "Total";
                    total.ContactsTot = ContactsTotals.ToString();
                    total.SuccessesTot = SuccessesTotals.ToString();
                    total.RefusalsTot = RefusalsTotals.ToString();
                    total.LoggedInTot = "N/A";
                    total.ActiveTot = ActiveTotalString.ToString();
                    total.IdleTot = "N/A";
                    total.WrapTot = WrapTotalString.ToString();
                    total.NotReadyTot =  "N/A";
                    total.ParkTot = "N/A";
                    total.OccupancyTot = "N/A";
                    total.ManualTot = ManualTotalString.ToString();
                    List<RowAgentStatsTotal> totalList = new List<RowAgentStatsTotal>();
                    totalList.Add(total);
                    dataGridTotal.DataSource = (object)totalList;
                    //if (dataGridTotal.Rows.Count > 0)
                    //{
                    //    dataGridTotal.DataSource = null;
                    //    dataGridTotal.Rows.Clear();
                    //}
                    //dataGridTotal.Rows.Add("Total",
                    //    ContactsTotals.ToString(),
                    //    SuccessesTotals.ToString(),
                    //    RefusalsTotals.ToString(),
                    //    "N/A",
                    //    ActiveTotalString,
                    //    "N/A",
                    //    WrapTotalString,
                    //    "N/A",
                    //    "N/A",
                    //     "N/A",
                    //    ManualTotalString);

                    this.lblTotalInbound.Text = Inbound.ToString();
                    this.lblTotalOutbound.Text = Outbound.ToString();
                    this.lblTotalCTI.Text = Cti.ToString();
                    this.lblTotalDID.Text = Did.ToString();
                    this.lblTotalChat.Text = Chats.ToString();
                    this.lblTotalEmail.Text = Email.ToString();
                    this.lblTotalWrokflow.Text = Workflow.ToString();
                    this.lblTotalIM.Text = Im.ToString();
                    

                }
                catch (Exception ex)
                {
                    ///AgentStatistics._log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
                }
                // AgentStatistics._log.DebugFormat("[{0}] EXITED", (object)MethodBase.GetCurrentMethod().Name);
            }
        }
        private void UpdateUI(List<RowAgentStats> Data)
        {

        }
        public void UpdateAgentStatisticTotals(
      int numberOfSuccessesTotals,
      int numberOfRefusalsTotals,
      int contactTotals,
      string totalTimeLoggedIn,
      int totalTimeActive,
      int totalTimeIdle,
      int totalTimeWrap,
      string totalTimeNotReady,
      string totalOccupancy,
      int totalTimeManual,
      string totalTimePark)
        {
            this.SuccessesTotals += numberOfSuccessesTotals;
            this.RefusalsTotals += numberOfRefusalsTotals;
            this.ContactsTotals += contactTotals;
            this._activeTotalSeconds += totalTimeActive;
            this.ActiveTotalString = this.ConvertSecondsToTime(this._activeTotalSeconds);
            this._idleTotalSeconds += totalTimeIdle;
            this.IdleTotalString = this.ConvertSecondsToTime(this._idleTotalSeconds);
            this._wrapTotalSeconds += totalTimeWrap;
            this.WrapTotalString = this.ConvertSecondsToTime(this._wrapTotalSeconds);
            this._manualTotalSeconds += totalTimeManual;
            this.ManualTotalString = this.ConvertSecondsToTime(this._manualTotalSeconds);
        }
        public string CalculateOccupancy(
      int serviceId,
      double loggedInSecs,
      double notReadySecs,
      double idleSecs,
      double otherSecs,
      double activeSecs)
        {
            double num = 0.0;
            try
            {
                num = Math.Abs((activeSecs > 0.0 ? (serviceId != 0 && serviceId != -1 ? (loggedInSecs - notReadySecs - otherSecs > 0.0 ? 1.0 - idleSecs / (loggedInSecs - notReadySecs - otherSecs) : 0.0) : (loggedInSecs - notReadySecs > 0.0 ? 1.0 - idleSecs / (loggedInSecs - notReadySecs) : 0.0)) : 0.0) * 100.0);
            }
            catch (Exception ex)
            {
            }
            return num.ToString("N2");
        }

        private string ConvertSecondsToTime(int seconds)
        {
            string time = (string)null;
            try
            {
                TimeSpan timeSpan = new TimeSpan(10000000L * (long)seconds);
                time = timeSpan.Hours.ToString("00") + ":" + timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
            }
            catch (Exception ex)
            {
            }
            return time;
        }

        private void AgentInfo_Load(object sender, EventArgs e)
        {
            AgentInfoLoad();
        }
        private void AgentStatis()
        {
            try
            {
                this.mpApp.InvokeAgentStatistics();
                Thread.Sleep(1000);
                UDAgentStatsCollection agentStatsCollection = new UDAgentStatsCollection();
                UDAgentStats[] lstAgentStatistics = this.mpApp.CurrentAgent.AgentStatistics.lstAgentStatistics;
                if (lstAgentStatistics == null)
                    return;
                this.LoadServices(lstAgentStatistics);
            }
            catch (Exception ex)
            {
            }
        }
        private void LoadServices(UDAgentStats[] udStat)
        {
            List<RowAgentStats> rowAgentStatsList = new List<RowAgentStats>();
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;
            int num11 = 0;
            int num12 = 0;
            TimeSpan timeSpan;
            foreach (UDAgentStats udAgentStats in udStat)
            {
                if (udAgentStats.serviceId != 0)
                {
                    RowAgentStats rowAgentStats1 = new RowAgentStats();
                    rowAgentStats1.Service = udAgentStats.service;
                    rowAgentStats1.Contacts = udAgentStats.numberOfSuccesses + udAgentStats.numberOfRefusals + udAgentStats.numberOfCallbacks;
                    rowAgentStats1.Refusals = udAgentStats.numberOfRefusals;
                    rowAgentStats1.Successes = udAgentStats.numberOfSuccesses;
                    RowAgentStats rowAgentStats2 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.loggedInSeconds);
                    string str1 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats2.LoggedIn = str1;
                    RowAgentStats rowAgentStats3 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.activeSeconds);
                    string str2 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats3.Active = str2;
                    RowAgentStats rowAgentStats4 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.idleSeconds);
                    string str3 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats4.Idle = str3;
                    RowAgentStats rowAgentStats5 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.wrapSeconds);
                    string str4 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats5.Wrap = str4;
                    RowAgentStats rowAgentStats6 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.notReadySeconds);
                    string str5 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats6.NotReady = str5;

                    RowAgentStats rowAgentStats7 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.parkSeconds);
                    string str6 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats7.Park = str6;

                    rowAgentStats1.Occupancy = udAgentStats.loggedInSeconds == 0 ? "0.00" : ((Decimal)(udAgentStats.loggedInSeconds - udAgentStats.idleSeconds) / (Decimal)udAgentStats.loggedInSeconds * 100M).ToString("0.##");

                    RowAgentStats rowAgentStats8 = rowAgentStats1;
                    timeSpan = TimeSpan.FromSeconds((double)udAgentStats.manualSeconds);
                    string str18 = timeSpan.ToString("hh\\:mm\\:ss");
                    rowAgentStats8.Manual = str18;

                    num7 += rowAgentStats1.Contacts;
                    num8 += rowAgentStats1.Successes;
                    num9 += rowAgentStats1.Refusals;
                    num1 += udAgentStats.acdCalls;
                    num2 += udAgentStats.aodCalls;
                    num5 += udAgentStats.CTICalls;
                    num6 += udAgentStats.didCalls;
                    num4 += udAgentStats.chatCalls;
                    num3 += udAgentStats.EMailCalls;
                    num11 += udAgentStats.activeSeconds;
                    num12 += udAgentStats.wrapSeconds;
                    num10 += udAgentStats.agdCalls;
                    // num11 += udAgentStats.
                    rowAgentStatsList.Add(rowAgentStats1);
                }
            }
            this.lblTotalContact.Text = num7.ToString();
            this.lblTotalSuccess.Text = num8.ToString();
            this.lblTotalRefusals.Text = num9.ToString();
            this.lblTotalInbound.Text = num1.ToString();
            this.lblTotalOutbound.Text = num2.ToString();
            this.lblTotalCTI.Text = num5.ToString();
            this.lblTotalDID.Text = num6.ToString();
            this.lblTotalChat.Text = num4.ToString();
            this.lblTotalEmail.Text = num3.ToString();
            this.lblTotalWrokflow.Text = num10.ToString();
            Label lblTotalActive = this.lblTotalActive;
            timeSpan = TimeSpan.FromSeconds((double)num11);
            string str7 = timeSpan.ToString("hh\\:mm\\:ss");
            lblTotalActive.Text = str7;
            Label lblTotalWrap = this.lblTotalWrap;
            timeSpan = TimeSpan.FromSeconds((double)num12);
            string str8 = timeSpan.ToString("hh\\:mm\\:ss");
            lblTotalWrap.Text = str8;
            this.dgvAgentStatus.DataSource = (object)rowAgentStatsList;
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                //if (dataGridTotal.Rows.Count > 0)
                //    dataGridTotal.Rows.Clear();
                //if (dgvAgentStatus.Rows.Count > 0)
                //{
                //    dgvAgentStatus.DataSource = null;
                //    dgvAgentStatus.Rows.Clear();
                //}
                this.ResetAgentStatisticTotals();
                this.ResetAgentStatisticCumulativeTotals();
                this.mpApp.InvokeAgentStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
