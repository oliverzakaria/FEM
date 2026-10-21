using Cafe.Mortgage.Api.ServiceModel;
using MultiColumnComboBoxDemo;
using SamplePortalClient.EPAgentWS;
using SamplePortalClient.EPAgentWSP;
using SamplePortalClient.EPEventsWS;
using SamplePortalClientUI;
using SamplePortalClientUI.Extensions;
using ServiceStack;
using ServiceStack.Jobs;
using ServiceStack.Text;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Threading;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Threading;
using static SamplePortalClient.CApp;
using static SamplePortalClient.CServices;
using static System.Net.Mime.MediaTypeNames;
//using static SamplePortalClient.UI.ServiceModel;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace SamplePortalClient.UI
{
    public partial class FCallData : Form
    {
        private CCall mpCall;
        private CApp mpApp;
        public DispatcherTimer StatusDurationTimer = (DispatcherTimer)null;
        private int showCallDataSecs;
        private int ServiceShowCallDataSecs;
        private int miAnswerCallTickCount;
        private int previewSeconds = 0;
        private string _baseApiUrl="";
        private IniReader ini = new IniReader(System.Windows.Forms.Application.StartupPath + "\\inisetting.ini");
        public FCallData()
        {
            InitializeComponent();
            //grp_action.Visible = true;
            //load_group(false);
            //PopulateContactPlace();
            //PopulateContactPerson();
            //PopulatePTPHoldDate();
            //PopulateContactAction();
            //PopulatePTPHoldDate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_ptp.Visible = true;
            grp_ptp.Location = new Point(grp_action.Location.X, grp_action.Location.Y);

            PopulateContactPlace();
            PopulateContactPerson();
            PopulatePTPHoldDate(cbPTPHoldDate, "PTP");
            PopulatePTPHoldDate(cbPTPHoldDate2, "PTP");
            PopulatePTPHoldDate(cbPTPHoldDate3, "PTP");
            PopulatePTPHoldDate(cbPTPPRDate1, "PR");
            PopulatePTPHoldDate(cbPTPPRDate2, "PR");
            PopulateContactActionPTP(cbActionCode1);
            PopulateContactActionPTP(cbActionCode2);
            txtPTPAmount1.Focus();
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_ptp.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
              button5.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_with_borrower.Visible = true;
            grp_with_borrower.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactBPlace);
            PopulatePTPHoldDate(cbBHoldDate1, "PTP");
            PopulatePTPHoldDate(cbBHoldDate2, "PTP");

            PopulatePTPHoldDate(cbBPRHoldDate1, "PR");
            PopulatePTPHoldDate(cbBPRHoldDate2, "PR");
            PopulateContactActionpc(cbBaction1);
            PopulateContactActionpc(cbBaction2);
            txtRemarkB.Focus();
        }
        private void button27_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_with_borrower.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
              button5.Focus();
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_with_cp.Visible = true;
            grp_with_cp.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactCPPlace);
            PopulatePTPHoldDate(cbCPHoldDate1, "PTP");
            PopulatePTPHoldDate(cbCPHoldDate2, "PTP");
            PopulateContactPersonCP(cbContactPersonCP, "CP");
            PopulatePTPHoldDate(cbCPPRHoldDate1, "PR");
            PopulatePTPHoldDate(cbCPPRHoldDate2, "PR");
            PopulateContactActionpc(cbCPaction1);
            PopulateContactActionpc(cbCPaction2);
            txtRemarkCP.Focus();
        }
        private void button30_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            action_phone = "PHONEOTHER";
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "PO");
            PopulateContactActionCustomer(cbPLaction1, "PO");
            PopulateContactActionCustomer(cbPLaction2, "PO");
            lblactioncode2.Text = "PO";
            lblSendback.Visible = true;
            btnSendback.Visible = true;
            button39.Location = new Point(176, 269);
            btnCancel1.Location = new Point(279, 269);
            txtRemarkleave.Focus();
        }
     

        private void button5_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_remainder.Visible = true;
            grp_phone_remainder.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactPRPlace);
            PopulatePTPHoldDate(cbPRHoldDate1, "PTP");
            PopulatePTPHoldDate(cbPRHoldDate2, "PTP");
            PopulateContactPersonCP(cbContactPersonPR, "PRCP");
            PopulatePTPHoldDate(cbPRPRHoldDate1, "PR");
            PopulatePTPHoldDate(cbPRPRHoldDate2, "PR");
            PopulateContactActionCustomer(cbPRaction1, "PR");
            PopulateContactActionCustomer(cbPRaction2, "PR");
            PopulatePTPHoldDate(cbPRPRHoldDate0, "PR");
            txtRemarkPR.Focus();    
        }

        private void button36_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_remainder.Visible = false;
        }



        private void button38_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_not_answer.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
              button5.Focus();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "PL");
            PopulateContactActionOther(cbPLaction1);
            PopulateContactActionOther(cbPLaction2);
            action_phone = "PHONELEAVEMESSAGE";
            lblactioncode2.Text = "PL";
            lblSendback.Visible = false;
            btnSendback.Visible = false;
            button39.Location = new Point(176, 231);
            btnCancel1.Location = new Point(279, 231);
            txtRemarkleave.Focus();
            txtRemarkleave.Text = "";
        }
        private void button40_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 1; 
            mainTabControl.Focus();
            load_group(false);
            grp_action.Visible = true;
            grp_phone_leave_message.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
            button5.Focus();
        }
        private string tipe_phone = "";
        private string action_phone = "";
        private void button13_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_not_answer.Visible = true;
            grp_phone_not_answer.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactNoAPlace);
            tipe_phone = "PB";
            action_phone = "PHONEBUSY";
            lblActionCode.Text = "PB";
            txtRemarkNoAnswer.Focus();
        }


        private void button14_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_not_answer.Visible = true;
            grp_phone_not_answer.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactNoAPlace);
            tipe_phone = "PD";
            action_phone = "PHONEDISCONNECTED";
            lblActionCode.Text = "PD";
            txtRemarkNoAnswer.Focus();
        }
        private void button15_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_not_answer.Visible = true;
            grp_phone_not_answer.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            PopulateContactPlaceAll(cbContactNoAPlace);
            tipe_phone = "PN";
            action_phone = "PHONENOANSWER";
            txtRemarkNoAnswer.Focus();
        }
        private void load_group(bool values)
        {
            grp_ptp.Visible = values;
            grp_with_borrower.Visible = values;
            grp_with_cp.Visible = values;
            grp_phone_remainder.Visible = values;
            grp_phone_not_answer.Visible = values;
            grp_phone_leave_message.Visible = values;

        }
        private void btncancel4_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_with_cp.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
              button5.Focus();
        }
        private Dictionary<TabPage, Color> TabColors = new Dictionary<TabPage, Color>();
        private void SetTabHeader(TabPage page, Color color)
        {
            TabColors[page] = color;
            mainTabControl.Invalidate();
        }
        //private void mainTabControl_Onchange(object sender, EventArgs e){
        //    if (mainTabControl.SelectedIndex == 0) {
        //        SetTabHeader(Color.Blue);
        //    }
        //}
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //e.DrawBackground();
            // Get the tab control and the graphics object
            TabControl tabControl = sender as TabControl;
            Graphics g = e.Graphics;

            // Create brushes for the active and inactive tabs
            Brush activeBrush = new SolidBrush(Color.Silver); // Change to your desired color
            Brush inactiveBrush = new SolidBrush(Color.Gray);    // Color for unselected tabs
            Brush textBrush = new SolidBrush(Color.Black);
            // Get the current tab page
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);

            // Fill the background based on whether the tab is selected
            if (e.Index == tabControl.SelectedIndex)
            {
                // The currently selected tab
                g.FillRectangle(activeBrush, tabRect);
                
            }
            else
            {
                // Inactive tabs
                g.FillRectangle(inactiveBrush, tabRect);
                textBrush = new SolidBrush(Color.White);
            }

            // Draw the tab page's text
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(tabPage.Text, tabControl.Font, textBrush, tabRect, sf);

            // Clean up resources
            activeBrush.Dispose();
            inactiveBrush.Dispose();
            textBrush.Dispose();
        }
        
        string LOANNO = "";
        string OTH_LOANNO1 = "";
        string OTH_LOANNO2 = "";
        string TABLENAME = "";
        string ServiceName = "";
        string C_MOBILE_P = "";
        string C_CONTACT2_P = "";
        string C_CONTACT1_E = "";
        string MOBILE_O = "";
        private string sheader3 = "";
        private string _wrapActionDataVal = "";
        private string _wrapTimeDataVal = "";
        private string _previewTimeDataVal = "";
        private ServiceApplication[] _serviceApplications;
        private string getvalueDisplay(String inputan)
        {
            string desc = "";
            if (inputan == "81")
            {
                desc = "PTP";
            }
            else if (inputan == "82")
            {
                desc = "PC";
            }
            else if (inputan == "83")
            {
                desc = "PN";
            }
            else if (inputan == "84")
            {
                desc = "REF_FC";
            }
            else if (inputan == "85")
            {
                desc = "PO";
            }
            else if (inputan == "86")
            {
                desc = "PL";
            }
            else if (inputan == "87")
            {
                desc = "PB";
            }
            else if (inputan == "88")
            {
                desc = "PD";
            }
            else if (inputan == "89")
            {
                desc = "PE";
            }
            else if (inputan != null)
            {
                desc = "PDA";
            }


            return desc;
        }
        bool header1 = true;
        bool header2 = true;
        bool header3 = true;
        private void lblPlus1_Click(object sender, EventArgs e)
        {
            if (header1)
            {
                header1 = false;
                lblPlus1.Text = "-";
                Detail1.Visible = false;
                Header22.Location = new Point(Header11.Location.X, Header11.Location.Y + Header11.Height + 5);
                Detail2.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height);
                Header33.Location = new Point(Header11.Location.X, Detail2.Location.Y + Detail2.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header33.Location.Y + Header33.Height);
            }
            else
            {
                header1 = true;
                lblPlus1.Text = "+";
                Detail1.Visible = true;
                Header22.Location = new Point(Header11.Location.X, Detail1.Location.Y + Detail1.Height + 5);
                Detail2.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height);
                Header33.Location = new Point(Header11.Location.X, Detail2.Location.Y + Detail2.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header33.Location.Y + Header33.Height);
            }

        }

        private void lblPlus2_Click(object sender, EventArgs e)
        {
            if (header2)
            {
                header2 = false;
                lblPlus2.Text = "-";
                Detail2.Visible = false;
                Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
            }
            else
            {
                header2 = true;
                lblPlus2.Text = "+";
                Detail2.Visible = true;
                Header33.Location = new Point(Header11.Location.X, Detail3.Height + Header22.Location.Y + Header22.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Detail3.Height + Header22.Location.Y + Header22.Height + Header33.Height);
            }
        }

        private void lblPlus3_Click(object sender, EventArgs e)
        {
            if (header3)
            {
                header3 = false;
                lblPlus3.Text = "-";
                Detail3.Visible = false;
            }
            else
            {
                header3 = true;
                lblPlus3.Text = "+";
                Detail3.Visible = true;
            }
        }
        int LocationX = 0,LocationY=0;
        private void MySizeChanged(object sender, EventArgs e)
        {
            try
            {
                if (WindowState != FormWindowState.Minimized)
                {
                    LocationX = this.Location.X;
                    LocationY = this.Location.Y;
                }
            }
            catch (Exception ex)
            {

            }

        }
        private string ApiKey() {

            //var password = ConfigurationManager.AppSettings["ApiKey"];
            //var passwordEncript = Cafe.Mortgage.Api.ServiceInterface.Extensions.DecryptPwd(password);

            var password = ConfigurationManager.AppSettings["ApiKey"];
            var passwordEncrypt = password;//.DecryptPwd();

            return passwordEncrypt;
        }
        private void loaddataws(bool screen) {
            try
            {
                _baseApiUrl = ini.ReadString("aspect", "urldata", "");
                var dictR = new Dictionary<int, string>();
                EPAgentWS.CallBackService[] callbackServiceList = mpApp.getCallbackServiceList();
                //CService pCurrentService = mpApp.AssignedServices.GetByKey(mpCall.ServiceID);
                //ItemChangedphone(mpCall.PhoneNumber);
                ServiceType byKey = mpApp.AssignedServices.GetByKey(mpCall.ServiceID).ServiceType;
                bool flag = true;
                for (int i = 0; i < callbackServiceList.Length; i++)
                {
                    dictR.Add(callbackServiceList[i].serviceid, callbackServiceList[i].servicec);
                }
                if (byKey == ServiceType.AOD)
                {
                    flag = false;
                }

                cbOutbound.DataSource = new BindingSource(dictR, null);
                cbOutbound.DisplayMember = "Value";
                cbOutbound.ValueMember = "Key";
                cbOutbound.Enabled = flag;

                cbOutbound.SelectedValue = mpCall.ServiceID;

                var Dnis = mpCall.Dnis;
                var AccountNo = mpCall.UserDefinedItems[0].value;

                txtName.Text = AccountNo;
                txtphonenumberh.Text = mpCall.PhoneNumber;
                txtDNISH.Text = Dnis;
                txtCallback.Text = mpCall.CallBacMemo;

                //var client = new JsonServiceClient(_baseApiUrl);
                var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
                var response = client.Post<Cafe.Mortgage.Api.ServiceModel.GetAccountResponse>("/api/GetAccount",
                    new Cafe.Mortgage.Api.ServiceModel.GetAccount { ServiceId = mpCall.ServiceID, AccountNo = AccountNo, TableName = ((SamplePortalClient.CCallAOD)mpCall).TableName });
                buttonDial(false);
                int seconds = 1;
                this.StatusDurationTimer = new DispatcherTimer();
                this.StatusDurationTimer.Interval = new TimeSpan(0, 0, seconds);
                this.StatusDurationTimer.Tick += new EventHandler(this.DisplayTimeEvent);


                this.StatusDurationTimer.IsEnabled = this.StatusDurationTimer.Dispatcher.Thread.IsAlive;

                if (response != null)
                {
                    if (!response.Success)
                    {
                        MessageBox.Show(response.ErrorMessage);
                        return;
                    }
                    Dictionary<string, string> resValueDict = response.Metadata
                        .ToDictionary(n => n.FieldName, v => v.FieldValue);

                    #region Fields
                    var CUSTID = resValueDict["CUSTID"];
                    var CUSTNAME = resValueDict["CUSTNAME"];
                    var FORECLOSURE_AMT = resValueDict["FORECLOSURE_AMT"];
                    var INHOUSE_SCORE3 = resValueDict["INHOUSE_SCORE3"];

                    var DPD = resValueDict["DPD"];// mpCall.UserDefinedItems[6].value;
                    var OTH_DPD1 = resValueDict["OTH_DPD1"];
                    var OTH_PRINCIPLE1 = resValueDict["PRINCIPLE_OVERDUE"];//.ToMoneyFormat(2);

                    var OTH_DPD2 = resValueDict["OTH_DPD2"];
                    var OTH_PRINCIPLE2 = resValueDict["OTH_PRINCIPLE1"].ToMoneyFormat(2);

                    C_CONTACT2_P = resValueDict["C_CONTACT2_P"];
                    C_MOBILE_P = resValueDict["MOBILE_P"];
                    C_CONTACT1_E = resValueDict["C_CONTACT1_E"];
                    MOBILE_O = resValueDict["MOBILE_O"];
                    var OTH_PRINCIPLE3 = resValueDict["OTH_PRINCIPLE2"].ToMoneyFormat(2);
                    var OTH_DPD3 = "";

                    var DOB = resValueDict["DOB"];
                    var PRODUCT = resValueDict["PRODUCT_CODE"]; //CURRENT_ORG
                    var SEX = resValueDict["SEX"];
                    var ZIPCODE = resValueDict["ZIPCODE"];
                    var CONTACT1_P = $"{resValueDict["CONTACT1_P"].Trim()} / {resValueDict["CONTACT2_P"].Trim()} / {resValueDict["MOBILE_P"].Trim()}";
                    var CONTACT1_E = $"{resValueDict["CONTACT1_E"].Trim()} / {resValueDict["CONTACT2_E"].Trim()} / {resValueDict["MOBILE_E"].Trim()}";
                    var CONTACT1_O = $"{resValueDict["CONTACT1_O"].Trim()} / {resValueDict["CONTACT2_O"].Trim()} / {resValueDict["MOBILE_O"].Trim()}";

                    var LAST_PAYMENT_AMT = resValueDict["LAST_PAYMENT_AMT"].ToMoneyFormat(2);
                    var LAST_PAYMENT_DATE = resValueDict["LAST_PAYMENT_DATE"];
                    var OPENED_DATE = resValueDict["OPENED_DATE"];
                    var COLL_CYCLE = resValueDict["COLL_CYCLE"];
                    var AMT_OVERDUE = resValueDict["AMT_OVERDUE"].ToMoneyFormat(2);
                    var PRINCIPLE_OVERDUE = resValueDict["PRINCIPLE_OVERDUE"].ToMoneyFormat(2);
                    var INTEREST_OVERDUE = resValueDict["INTEREST_OVERDUE"].ToMoneyFormat(2);
                    var TOTCHARGES_OVERDUE = resValueDict["TOTCHARGES_OVERDUE"].ToMoneyFormat(2);
                    var PRINCIPLE_OUTSTD = resValueDict["PRINCIPLE_OUTSTD"].ToMoneyFormat(2);

                    var BUCKET1 = resValueDict["BUCKET1"].ToMoneyFormat(2);
                    var BUCKET2 = resValueDict["BUCKET2"].ToMoneyFormat(2);
                    var BUCKET3 = resValueDict["BUCKET3"].ToMoneyFormat(2);
                    var BUCKET4 = resValueDict["BUCKET4"].ToMoneyFormat(2);
                    var BUCKET5 = resValueDict["BUCKET5"].ToMoneyFormat(2);
                    var BUCKET6 = resValueDict["BUCKET6"].ToMoneyFormat(2);
                    var BUCKET7 = resValueDict["BUCKET7"].ToMoneyFormat(2);

                    var Call1_Phone = resValueDict["Call1_Phone"];
                    var Call2_Phone = resValueDict["Call2_Phone"];
                    var Call3_Phone = resValueDict["Call3_Phone"];
                    var Call4_Phone = resValueDict["Call4_Phone"];
                    var Call5_Phone = resValueDict["Call5_Phone"];
                    var Call6_Phone = resValueDict["Call6_Phone"];

                    var Call1_dt = ((resValueDict["Call1_dt"] == null || resValueDict["Call1_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call1_dt"]);
                    var Call2_dt = ((resValueDict["Call2_dt"] == null || resValueDict["Call2_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call2_dt"]);
                    var Call3_dt = ((resValueDict["Call3_dt"] == null || resValueDict["Call3_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call3_dt"]);
                    var Call4_dt = ((resValueDict["Call4_dt"] == null || resValueDict["Call4_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call4_dt"]);
                    var Call5_dt = ((resValueDict["Call5_dt"] == null || resValueDict["Call5_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call5_dt"]);
                    var Call6_dt = ((resValueDict["Call6_dt"] == null || resValueDict["Call6_dt"] == "") ? "1900-01-01 00:00:00" : resValueDict["Call6_dt"]);

                    var Disp1_Id = resValueDict["Disp1_Desc"];//getvalueDisplay(resValueDict["Disp1_Id"]);
                    var Disp2_Id = resValueDict["Disp2_Desc"];//getvalueDisplay(resValueDict["Disp2_Id"]);
                    var Disp3_Id = resValueDict["Disp3_Desc"];//getvalueDisplay(resValueDict["Disp3_Id"]);
                    var Disp4_Id = resValueDict["Disp4_Desc"];//getvalueDisplay(resValueDict["Disp4_Id"]);
                    var Disp5_Id = resValueDict["Disp5_Desc"];//getvalueDisplay(resValueDict["Disp5_Id"]);
                    var Disp6_Id = resValueDict["Disp6_Desc"];//getvalueDisplay(resValueDict["Disp6_Id"]);

                    var Agent1_c = resValueDict["Agent1_c"];
                    var Agent2_c = resValueDict["Agent2_c"];
                    var Agent3_c = resValueDict["Agent3_c"];
                    var Agent4_c = resValueDict["Agent4_c"];
                    var Agent5_c = resValueDict["Agent5_c"];
                    var Agent6_c = resValueDict["Agent6_c"];

                    var OTH_BALANCE1 = resValueDict["OTH_BALANCE1"].ToMoneyFormat(2);
                    var OTH_BALANCE2 = resValueDict["OTH_BALANCE2"].ToMoneyFormat(2);

                    var CONTACT_DATE1 = resValueDict["CONTACT_DATE1"];
                    var CONTACT_PLACE1 = resValueDict["CONTACT_PLACE1"];
                    var PERSON_CONTACTED1 = resValueDict["PERSON_CONTACTED1"];
                    var ACTION_CODE1 = resValueDict["ACTION_CODE1"];
                    var CONTACTED_BY1 = resValueDict["CONTACTED_BY1"];
                    var REMARKS1 = resValueDict["REMARKS1"];
                    var CONTACT_DATE2 = resValueDict["CONTACT_DATE2"];
                    var CONTACT_PLACE2 = resValueDict["CONTACT_PLACE2"];
                    var PERSON_CONTACTED2 = resValueDict["PERSON_CONTACTED2"];
                    var ACTION_CODE2 = resValueDict["ACTION_CODE2"];
                    var CONTACTED_BY2 = resValueDict["CONTACTED_BY2"];
                    var REMARKS2 = resValueDict["REMARKS2"];
                    var CONTACT_DATE3 = resValueDict["CONTACT_DATE3"];
                    var CONTACT_PLACE3 = resValueDict["CONTACT_PLACE3"];
                    var PERSON_CONTACTED3 = resValueDict["PERSON_CONTACTED3"];
                    var ACTION_CODE3 = resValueDict["ACTION_CODE3"];
                    var CONTACTED_BY3 = resValueDict["CONTACTED_BY3"];
                    var REMARKS3 = resValueDict["REMARKS3"];
                    var CONTACT_DATE4 = resValueDict["CONTACT_DATE4"];
                    var CONTACT_PLACE4 = resValueDict["CONTACT_PLACE4"];
                    var PERSON_CONTACTED4 = resValueDict["PERSON_CONTACTED4"];
                    var ACTION_CODE4 = resValueDict["ACTION_CODE4"];
                    var CONTACTED_BY4 = resValueDict["CONTACTED_BY4"];
                    var REMARKS4 = resValueDict["REMARKS4"];
                    var CONTACT_DATE5 = resValueDict["CONTACT_DATE5"];
                    var CONTACT_PLACE5 = resValueDict["CONTACT_PLACE5"];
                    var PERSON_CONTACTED5 = resValueDict["PERSON_CONTACTED5"];
                    var ACTION_CODE5 = resValueDict["ACTION_CODE5"];
                    var CONTACTED_BY5 = resValueDict["CONTACTED_BY5"];
                    var REMARKS5 = resValueDict["REMARKS5"];
                    var CONTACT_DATE6 = resValueDict["CONTACT_DATE6"];
                    var CONTACT_PLACE6 = resValueDict["CONTACT_PLACE6"];
                    var PERSON_CONTACTED6 = resValueDict["PERSON_CONTACTED6"];
                    var ACTION_CODE6 = resValueDict["ACTION_CODE6"];
                    var CONTACTED_BY6 = resValueDict["CONTACTED_BY6"];
                    var REMARKS6 = resValueDict["REMARKS6"];
                    var CONTACT_DATE7 = resValueDict["CONTACT_DATE7"];
                    var CONTACT_PLACE7 = resValueDict["CONTACT_PLACE7"];
                    var PERSON_CONTACTED7 = resValueDict["PERSON_CONTACTED7"];
                    var ACTION_CODE7 = resValueDict["ACTION_CODE7"];
                    var CONTACTED_BY7 = resValueDict["CONTACTED_BY7"];
                    var REMARKS7 = resValueDict["REMARKS7"];
                    var CONTACT_DATE8 = resValueDict["CONTACT_DATE8"];
                    var CONTACT_PLACE8 = resValueDict["CONTACT_PLACE8"];
                    var PERSON_CONTACTED8 = resValueDict["PERSON_CONTACTED8"];
                    var ACTION_CODE8 = resValueDict["ACTION_CODE8"];
                    var CONTACTED_BY8 = resValueDict["CONTACTED_BY8"];

                    var REMARKS8 = resValueDict["REMARKS8"];
                    var SPECIAL_STAGE = resValueDict["SPECIAL_STAGE"];
                    var PURPOSE = resValueDict["PURPOSE"];

                    var CURRENT_ORG = resValueDict["CURRENT_ORG"];


                    var ALAMAT_P = resValueDict["ALAMAT_P"];
                    var ADD_CONTACT1_P = resValueDict["CONTACT1_P"];
                    var CONTACT2_P = resValueDict["CONTACT2_P"];
                    var MOBILE_P = resValueDict["MOBILE_P"];
                    var CITY_P = resValueDict["CITY_P"];
                    var ALAMAT_E = resValueDict["ALAMAT_E"];
                    var ADD_CONTACT1_E = resValueDict["CONTACT1_E"];
                    var CONTACT2_E = resValueDict["CONTACT2_E"];
                    var MOBILE_E = resValueDict["MOBILE_E"];
                    var CITY_E = resValueDict["CITY_E"];
                    var ALAMAT_O = resValueDict["ALAMAT_O"];
                    var ADD_CONTACT1_O = resValueDict["CONTACT1_O"];
                    var CONTACT2_O = resValueDict["CONTACT2_O"];
                    var ADD_MOBILE_O = resValueDict["MOBILE_O"];
                    var CITY_O = resValueDict["CITY_O"];
                    #endregion Fields

                    TABLENAME = response.TableName;

                    LOANNO = resValueDict["LOANNO"];
                    OTH_LOANNO1 = resValueDict["OTH_LOANNO1"];
                    OTH_LOANNO2 = resValueDict["OTH_LOANNO2"];


                    const int FREQ_GSHARP = 415;
                    const int DURATION_EIGHTH = 200;
                    lblDnis.Text = mpCall.PhoneNumber;
                    lblDnis2.Text = mpCall.PhoneNumber;

                    #region Home
                    lblServiceName.Text = ServiceName;
                    lblServiceName2.Text = ServiceName;
                    lblServiceName3.Text = ServiceName;
                    lblServiceName4.Text = ServiceName;
                    lblLoan1.Text = LOANNO;
                    lblLoan2.Text = OTH_LOANNO1;
                    lblLoan3.Text = OTH_LOANNO2;
                    lblLoanP1.Text = LOANNO;
                    lblLoanP2.Text = OTH_LOANNO1;
                    lblLoanP3.Text = OTH_LOANNO2;
                    lblLoan8.Text = LOANNO;
                    lblLoan9.Text = OTH_LOANNO1;
                    lblLoan10.Text = OTH_LOANNO2;
                    lblLoanP4.Text = LOANNO;
                    lblLoanP5.Text = OTH_LOANNO1;
                    lblLoanP6.Text = OTH_LOANNO2;
                    lblLoanP7.Text = LOANNO;
                    lblLoanP8.Text = OTH_LOANNO1;
                    lblLoanP9.Text = OTH_LOANNO2;

                    lblLoanP10.Text = LOANNO;
                    lblLoanP11.Text = OTH_LOANNO1;
                    lblLoanP12.Text = OTH_LOANNO2;

                    lblCustName.Text = CUSTNAME;
                    lblAmt.Text = FORECLOSURE_AMT;

                    LblPrincipal1.Text = OTH_PRINCIPLE1;
                    lblPrincipal2.Text = OTH_PRINCIPLE2;
                    lblPrincipal3.Text = OTH_PRINCIPLE3;

                    lblDPD2.Text = OTH_DPD3;
                    lblDPD1.Text = DPD;
                    lblDPD2.Text = OTH_DPD2;
                    #endregion
                    #region Contact1
                    lblLoan4.Text = LOANNO;
                    lblCustName1.Text = CUSTNAME;
                    lblProduct.Text = PRODUCT;
                    lblGender.Text = SEX;
                    lblRegion.Text = ZIPCODE;
                    lblPhome.Text = CONTACT1_P;
                    lblPoffice.Text = CONTACT1_E;
                    lblPother.Text = CONTACT1_O;
                    lblDOB.Text = DOB;

                    lblOpenDate.Text = OPENED_DATE;
                    lblLastPaymentAmount.Text = LAST_PAYMENT_AMT;
                    lblLastPaymentDate.Text = LAST_PAYMENT_DATE;
                    lblDPD4.Text = DPD;
                    lblBilingCycle.Text = COLL_CYCLE;
                    lblForeClosure_amt1.Text = FORECLOSURE_AMT;
                    lblInhouseScore.Text = INHOUSE_SCORE3;

                    lblOutstanding.Text = PRINCIPLE_OUTSTD;
                    lblAmountOverdue.Text = AMT_OVERDUE;
                    lblPrincipleOverdue.Text = PRINCIPLE_OVERDUE;
                    lblInterestOverdue.Text = INTEREST_OVERDUE;
                    lblChargesOverdue.Text = TOTCHARGES_OVERDUE;
                    lblBucket1.Text = BUCKET1;
                    lblBucket2.Text = BUCKET2;
                    lblBucket3.Text = BUCKET3;
                    lblBucket4.Text = BUCKET4;
                    lblBucket5.Text = BUCKET5;
                    lblBucket6.Text = BUCKET6;
                    lblBucket7.Text = BUCKET7;
                    var strPrefix = "";
                    if (SEX == "F")
                        strPrefix = "Ibu";
                    else
                        strPrefix = "Bapak";

                    txtmsg.Text = "Selamat pagi " + strPrefix + " " + CUSTNAME + ". Hingga saat ini kami belum menerima pembayaran pinjaman anda dengan nomor loan " + LOANNO.Trim() + ". Mohon segera lakukan pembayaran. Terima kasih";
                    #endregion
                    #region Additional
                    lblLoan6.Text = LOANNO;
                    lblCustomerName3.Text = CUSTNAME;
                    lblProduct2.Text = PRODUCT;
                    lblGender2.Text = SEX;
                    lblRegion2.Text = ZIPCODE;
                    lblPhome2.Text = CONTACT1_P;
                    lblPoffice2.Text = CONTACT1_E;
                    lblPother2.Text = CONTACT1_O;
                    lblDOB2.Text = DOB;

                    lblLoad_additional1.Text = OTH_LOANNO1;
                    lblLoad_additional2.Text = OTH_LOANNO2;
                    lblDPD_additional1.Text = OTH_DPD1;
                    lblDPD_additional2.Text = OTH_DPD2;
                    lblAO_additional1.Text = OTH_BALANCE1;
                    lblAO_additional2.Text = OTH_BALANCE2;
                    lblPrincipal_additional1.Text = OTH_PRINCIPLE2;
                    lblPrincipal_additional2.Text = OTH_PRINCIPLE3;

                    lblCall1_Phone.Text = Call1_Phone;
                    lblCall2_Phone.Text = Call2_Phone;
                    lblCall3_Phone.Text = Call3_Phone;
                    lblCall4_Phone.Text = Call4_Phone;
                    lblCall5_Phone.Text = Call5_Phone;
                    lblCall6_Phone.Text = Call6_Phone;

                    lblCall1_dt.Text = Call1_dt;
                    lblCall2_dt.Text = Call2_dt;
                    lblCall3_dt.Text = Call3_dt;
                    lblCall4_dt.Text = Call4_dt;
                    lblCall5_dt.Text = Call5_dt;
                    lblCall6_dt.Text = Call6_dt;

                    lblDisp1_Id.Text = Disp1_Id;
                    lblDisp2_Id.Text = Disp2_Id;
                    lblDisp3_Id.Text = Disp3_Id;
                    lblDisp4_Id.Text = Disp4_Id;
                    lblDisp5_Id.Text = Disp5_Id;
                    lblDisp6_Id.Text = Disp6_Id;

                    lblAgent1_c.Text = Agent1_c;
                    lblAgent2_c.Text = Agent2_c;
                    lblAgent3_c.Text = Agent3_c;
                    lblAgent4_c.Text = Agent4_c;
                    lblAgent5_c.Text = Agent5_c;
                    lblAgent6_c.Text = Agent6_c;

                    lblCONTACT_DATE1.Text = CONTACT_DATE1;
                    lblCONTACT_DATE2.Text = CONTACT_DATE2;
                    lblCONTACT_DATE3.Text = CONTACT_DATE3;
                    lblCONTACT_DATE4.Text = CONTACT_DATE4;
                    lblCONTACT_DATE5.Text = CONTACT_DATE5;
                    lblCONTACT_DATE6.Text = CONTACT_DATE6;
                    lblCONTACT_DATE7.Text = CONTACT_DATE7;
                    lblCONTACT_DATE8.Text = CONTACT_DATE8;

                    lblCONTACT_PLACE1.Text = CONTACT_PLACE1;
                    lblCONTACT_PLACE2.Text = CONTACT_PLACE2;
                    lblCONTACT_PLACE3.Text = CONTACT_PLACE3;
                    lblCONTACT_PLACE4.Text = CONTACT_PLACE4;
                    lblCONTACT_PLACE5.Text = CONTACT_PLACE5;
                    lblCONTACT_PLACE6.Text = CONTACT_PLACE6;
                    lblCONTACT_PLACE7.Text = CONTACT_PLACE7;
                    lblCONTACT_PLACE8.Text = CONTACT_PLACE8;

                    lblPERSON_CONTACTED1.Text = PERSON_CONTACTED1;
                    lblPERSON_CONTACTED2.Text = PERSON_CONTACTED2;
                    lblPERSON_CONTACTED3.Text = PERSON_CONTACTED3;
                    lblPERSON_CONTACTED4.Text = PERSON_CONTACTED4;
                    lblPERSON_CONTACTED5.Text = PERSON_CONTACTED5;
                    lblPERSON_CONTACTED6.Text = PERSON_CONTACTED6;
                    lblPERSON_CONTACTED7.Text = PERSON_CONTACTED7;
                    lblPERSON_CONTACTED8.Text = PERSON_CONTACTED8;

                    lblACTION_CODE1.Text = ACTION_CODE1;
                    lblACTION_CODE2.Text = ACTION_CODE2;
                    lblACTION_CODE3.Text = ACTION_CODE3;
                    lblACTION_CODE4.Text = ACTION_CODE4;
                    lblACTION_CODE5.Text = ACTION_CODE5;
                    lblACTION_CODE6.Text = ACTION_CODE6;
                    lblACTION_CODE7.Text = ACTION_CODE7;
                    textBox2.Text = ACTION_CODE8;

                    lblCONTACTED_BY1.Text = CONTACTED_BY1;
                    lblCONTACTED_BY2.Text = CONTACTED_BY2;
                    lblCONTACTED_BY3.Text = CONTACTED_BY3;
                    lblCONTACTED_BY4.Text = CONTACTED_BY4;
                    lblCONTACTED_BY5.Text = CONTACTED_BY5;
                    lblCONTACTED_BY6.Text = CONTACTED_BY6;
                    lblCONTACTED_BY7.Text = CONTACTED_BY7;
                    lblCONTACTED_BY8.Text = CONTACTED_BY8;

                    lblREMARKS1.Text = REMARKS1;
                    lblREMARKS2.Text = REMARKS2;
                    lblREMARKS3.Text = REMARKS3;
                    lblREMARKS4.Text = REMARKS4;
                    lblREMARKS5.Text = REMARKS5;
                    lblREMARKS6.Text = REMARKS6;
                    lblREMARKS7.Text = REMARKS7;
                    lblREMARKS8.Text = REMARKS8;

                    lblCustId.Text = CUSTID;
                    lblSpecialStage.Text = SPECIAL_STAGE;
                    lblPurpose.Text = PURPOSE;
                    lblzipcode.Text = ZIPCODE;
                    lblOrg.Text = CURRENT_ORG;
                    #endregion
                    #region Address
                    lblLoan7.Text = LOANNO;
                    lblCustomerName4.Text = CUSTNAME;
                    lblProduct3.Text = PRODUCT;
                    lblGender3.Text = SEX;
                    lblRegion3.Text = ZIPCODE;
                    lblPhome3.Text = CONTACT1_P;
                    lblPoffice3.Text = CONTACT1_E;
                    lblPother3.Text = CONTACT1_O;
                    lblDOB3.Text = DOB;

                    lblALAMAT_P.Text = ALAMAT_P;
                    lblCONTACT1_P.Text = ADD_CONTACT1_P;
                    lblCONTACT2_P.Text = CONTACT2_P;
                    lblMOBILE_P.Text = MOBILE_P;
                    lblCITY_P.Text = CITY_P;
                    lblALAMAT_E.Text = ALAMAT_E;
                    lblCONTACT1_E.Text = ADD_CONTACT1_E;
                    lblCONTACT2_E.Text = CONTACT2_E;
                    lblMOBILE_E.Text = MOBILE_E;
                    lblCITY_E.Text = CITY_E;
                    lblALAMAT_O.Text = ALAMAT_O;
                    lblCONTACT1_O.Text = ADD_CONTACT1_O;
                    lblCONTACT2_O.Text = CONTACT2_O;
                    lblMOBILE_O.Text = ADD_MOBILE_O;
                    lblCITY_O.Text = CITY_O;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
            
        private void unRegiter()
        {
            try
            {
                StatusDurationTimer.Stop();
                //if (this.StatusDurationTimer != null)
                //{
                //    this.StatusDurationTimer.Tick -= new EventHandler(this.DisplayTimeEvent);
                //    this.StatusDurationTimer = (DispatcherTimer)null;
                //}
               
                //this.mpApp.WrapTimeout -= new WrapTimeoutEventHandler(this.mpApp_WrapTimeout);
            }
            catch { }
        }
        private void FCallData_Load(object sender, System.EventArgs e)
        {
          
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            callbackdate.MinDate = DateTime.Today;
            this.SizeChanged += MySizeChanged;
         
            this.Text = "LOAN";
            this.calltime = "";
            this.statetime = "";
            if (ParentY)
                this.Location = new Point(this.Location.X, posisi);
            //if (this.Width < WidthY)
            //{
            this.Width = WidthY;// - (System.Windows.Forms.SystemInformation.VerticalScrollBarWidth+2);
                
            //}
           
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - (posisi + 10);
            LocationX = this.Location.X;
            LocationY = this.Location.Y;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            mpApp.UnfocusedStateChange += new UnfocusedStateChangeHandler(this.CApp_CUnfocusStateChange);
            mpApp.StateChange += new StateChangeHandler(this.CApp_StateChange);
            mpApp.CallStateChange += new CallStateChangeHandler(this.CApp_CallStateChange);
            mpApp.WrapTimeout += new WrapTimeoutEventHandler(this.mpApp_WrapTimeout);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            grpschedule.Visible = false;
            grpExclusion.Visible = false;
            panel6.Height = 110;
            ServiceName = mpApp.AssignedServices.GetByKey(mpCall.ServiceID).ServiceName;
            this.stateTimeElapsed = DateTime.UtcNow;
            this.totalTimeElapsed = DateTime.UtcNow;
           
            //IsiExclusion();
            //LoadApplicationsComboBox(mpCall.ServiceID);
        }
        //private void mpApp_AssignedServiceUpdated(object pSender, AssignedServicesUpdateEventArgs pArgs)
        //{
        //    try
        //    {
        //        if (this.InvokeRequired)
        //        {
        //            this.Invoke((Delegate)new AssignedServicesUpdateEventHandler(this.mpApp_AssignedServiceUpdated), pSender, (object)pArgs);
        //            return;
        //        }


        //        else
        //        {
        //            try
        //            {
                        
        //            }
        //            catch (Exception ex)
        //            {
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        //void mpApp_AssignedServiceUpdated(AssignedServicesUpdateEventArgs pArgs)
        //{
        //    try
        //    {
        //        if (this.CurrentService.ServiceId != pArgs.Service.ServiceId)
        //            return;
        //        this.CurrentService = pArgs.Service;
        //        this.UpdateDispositionPlan(this.CurrentService.DispositionPlan);
        //        this.EnableDisableDispositionControls();
        //        this.UpdateWrapWarningPanel();
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //}
        public void LoadApplicationsComboBox(int serviceId)
        {
            try
            {
                if (this.cbApplication.Items.Count > 1)
                    return;
                this._serviceApplications = mpApp.GetApplications(serviceId);
                if (this._serviceApplications == null || this._serviceApplications.Length == 0)
                    return;
                //if (CApplication.uadhtmlprops.ForceApplicationSelectionInExclusion)
                //{
                //    this.cbApplication.Items.Clear();
                //    ComboBoxItem newItem = new ComboBoxItem();
                //    newItem.Content = (object)(string)Application.Current.Resources[(object)"DE-PleaseSelectStr"];
                //    newItem.Tag = (object)"0";
                //    this.cbApplication.Items.Add((object)newItem);
                //    this.cbApplication.SelectedIndex = 0;
                //}
                if (this._serviceApplications != null)
                {
                     this.cbApplication.Items.Add((object)("0", "Please Select"));
                    this.cbApplication.SelectedIndex = 0;
                    cbApplication.DataSource = new BindingSource(_serviceApplications, null);
                    cbApplication.DisplayMember = "Value";
                    cbApplication.ValueMember = "Key";

                }
            }
            catch (Exception ex)
            {
                //DispositionExclusionPageUC._log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            }
           // DispositionExclusionPageUC._log.DebugFormat("[{0}] EXITED", (object)MethodBase.GetCurrentMethod().Name);
        }
        private void IsiExclusion() {

            var dict = new Dictionary<string, string>();
            dict.Add("1", "Social Security Number");
            dict.Add("2", "Account Number");
            dict.Add("3", "Phone Number");
            dict.Add("4", "MS Device");
            cbExclusionType.DataSource = new BindingSource(dict, null);
            cbExclusionType.DisplayMember = "Value";
            cbExclusionType.ValueMember = "Key";
            cbExclusionType.SelectedValue = "1";

        }
        private void cbExclusionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var _iType = int.Parse(cbExclusionType.SelectedValue.ToString());
                switch (_iType)
                {
                    case 1:
                        this.lblExclusionType.Text = "Social Security Number";
                        break;
                    case 2:
                        this.lblExclusionType.Text = "Account Number";
                        break;
                    case 3:
                        this.lblExclusionType.Text = "Phone Number";
                        this.txtphoneEx.Text = mpCall.PhoneNumber;
                        break;
                    case 4:
                        this.lblExclusionType.Text = "MS Device";
                        break;
                    default:
                        this.lblExclusionType.Text = "Social Security Number"; 
                        return;
                }
            }
            catch (Exception ex)
            {
                //DispositionExclusionPageUC._log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            }
            //DispositionExclusionPageUC._log.DebugFormat("[{0}] EXITED", (object)MethodBase.GetCurrentMethod().Name);
        }
        private void buttonDial(bool dial)
        {
            if (!dial)
            {
                btnHangup.BackgroundImage = SamplePortalClientUI.Properties.Resources.release_btn_notext_small_reversed_disable;
                btnRecord.BackgroundImage = SamplePortalClientUI.Properties.Resources.record_btn_notext_small_reversed_disable;
                btn3Way.BackgroundImage = SamplePortalClientUI.Properties.Resources.transfer_btn_notext_small_reversed_disable;
                btnHold.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold_btn_notext_small_reversed_disable;

            }
            else
            {
                btnHangup.BackgroundImage = SamplePortalClientUI.Properties.Resources.release_btn_notext_small_reversed;
                btnRecord.BackgroundImage = SamplePortalClientUI.Properties.Resources.record_btn_notext_small_reversed;
                btn3Way.BackgroundImage = SamplePortalClientUI.Properties.Resources.transfer_btn_notext_small_reversed;
                btnHold.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold_btn_notext_small_reversed;
            }
        
            
        }
        public string MoneyFormat(string str, int declen)
        {
            double dbl = 0.0;
            try
            {
                dbl = double.Parse(str);
            }
            catch
            {
            }

            return MoneyFormat(dbl, declen);
        }
        public string MoneyFormat(double dbl, int declen)
        {
            NumberFormatInfo customFormat = new NumberFormatInfo
            {
                NumberDecimalSeparator = ",",
                NumberGroupSeparator = ".", // No thousands separator
                NumberDecimalDigits = declen
            };

            string s = dbl.ToString("N", CultureInfo.InvariantCulture);
            int index = s.IndexOf('.');
            int decimalPlaces = index == -1 ? 0 : s.Length - index - 1;
            return "IDR " + dbl.ToString($"N{decimalPlaces}", customFormat);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = homeTabPage;
        }

        #region address
        public int seconds = 0;
        private int inWrapSecs = 0;
        private int WrapAction = 0;
        private DateTime stateTimeElapsed;
        private DateTime totalTimeElapsed;
        private bool isStatusDurationTimerStopped = false;
        private string calltime;
        private string statetime;
        
        public string IncrementTime(TimeSpan duration)
        {
            int num = duration.Hours;
            string str1 = num.ToString() ?? "";
            if (str1.Length == 1)
                str1 = "0" + str1;
            num = duration.Minutes;
            string str2 = num.ToString() ?? "";
            if (str2.Length == 1)
                str2 = "0" + str2;
            num = duration.Seconds;
            string str3 = num.ToString() ?? "";
            if (str3.Length == 1)
                str3 = "0" + str3;
            return str1 + ":" + str2 + ":" + str3;
        }
      
        private void mpApp_WrapTimeout(object pSender, WrapTimeoutEventArgs pArgs)
        {
            //if (this.InvokeRequired)
            //{
            //    this.Invoke(new WrapTimeoutEventHandler(this.CApp_SmpApp_WrapTimeouttateChange), new Object[] { pSender, pArgs });
            //    return;
            //}
            if (Dispatcher.CurrentDispatcher.Thread != Thread.CurrentThread)
            {
                Dispatcher dispatcher = Dispatcher.FromThread(Thread.CurrentThread);

                dispatcher.Invoke(DispatcherPriority.Normal, (Delegate)new WrapTimeoutEventHandler(this.mpApp_WrapTimeout), pSender, (object)pArgs);
            }

            else
            {
                //CallDataControl.Log.DebugFormat("[{0}] ENTERED", (object)MethodBase.GetCurrentMethod().Name);
                if (pArgs.WrapTimeout.CallId == this.mpCall.CallID)
                {
                    //this.tbwin.LastNotReadyParkReason = string.Empty;
                    //this.tbwin.StopNotReadyParkTimer();
                    //this.tbwin.keepParkTimerRunning = false;
                    bDisplayWrapWarning = false;
                    inWrapSecs = -1;
                    WrapTimeDataVal = this.IncrementTime(TimeSpan.FromSeconds(0.0));
                    WrapActionDataVal = this.sheader3;
                    //ItemChangedMesage("Your allowed time in WRAP has exceeded", false);
                    if (pArgs.WrapTimeout.AgentDispExpected == 1)
                    {
                        if (MessageBox.Show("Your allowed time in WRAP has exceeded", "Wrap Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                            mpApp.DisposeCall(mpCall);
                    
                    }
                }
                //CallDataControl.Log.DebugFormat("[{0}] EXITED", (object)MethodBase.GetCurrentMethod().Name);
            }
        }

        //public delegate void ItemChangedHandler(UpdateTitle sender);
        //public ItemChangedHandler ItemChanged;

        public delegate void ItemChangedHandlerPhone(string phone);
        public ItemChangedHandlerPhone ItemChangedphone;

        public delegate void ItemChangedHandlerMessage(string message, bool time);
        public ItemChangedHandlerMessage ItemChangedMesage;


        private bool IsOkButtonEnabled = false;
        private bool bDisplayWrapWarning = false;
        public void DisplayTimeEvent(object sender, EventArgs e)
        {
            try
            {
               
                if (this.mpCall.CurrentState.Id == AgentStateId.asWRAP)
                {
                    if (this.inWrapSecs > -1)
                    {
                        //if (App.isRunningFromCMDLine)
                        //    this.inWrapSecs += 5;
                        //else
                        ++this.inWrapSecs;
                    }
                    if (mpApp.CurrentService.RequireDisposition || mpApp.CurrentService.RequireWrap == WrapType.wtREQUIRED || mpApp.CurrentService.RequireWrap == WrapType.wtOPTIONAL)// && mpCall.o.OptionalWrapRequested)
                    {
                        if (this.mpCall.CurrentState.Id == AgentStateId.asWRAP && (this.inWrapSecs >= mpApp.CurrentService.WrapMinSecs || this.inWrapSecs == -1))
                        {
                            btnDisposisi.Enabled = true;
                        }
                        else
                            btnDisposisi.Enabled = false;
                        if (this.inWrapSecs == mpApp.CurrentService.WrapAlarmSecs)
                        {
                            if (!this.bDisplayWrapWarning)
                            {
                                //ItemChangedMesage(" Wrap warning, please open screen pop to see more information", true);
                                try
                                {
                                    mpApp.warning(1);
                                }
                                catch (Exception ex)
                                {
                                    //CallDataControl.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
                                }
                            }
                            this.bDisplayWrapWarning = true;
                            pnlWrap.Visible = true;
                            if (this.WrapAction == 2 || this.WrapAction == 3 || this.WrapAction == 4)
                            {
                                try
                                {
                                    // this._mediaMgr.TurnOnWarningIndicator(this.callLineNumber, CalllineButtonModel.WarningTypes.WARNING_WRAP_EXCEED_PENDING);
                                }
                                catch (Exception ex)
                                {
                                    //CallDataControl.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
                                }
                            }
                        }
                    }
                }
                this.WrapAction = mpApp.CurrentService.WrapExceedAction;
                if (this.WrapAction == 1)
                    this.sheader3 = " WARN";
                else if (this.WrapAction == 2)
                    this.sheader3 = !this.mpApp.CurrentAgent.AllowPark ? " NOT READY" : " PARK";
                else if (this.WrapAction == 3)
                    this.sheader3 = " IDLE";
                else if (this.WrapAction == 4)
                    this.sheader3 = " NOT READY";

                if (this.bDisplayWrapWarning)
                {
                    Detail1.Height = 140;
                    this.WrapActionDataVal = !(this.sheader3.Trim() == "") ? this.sheader3 : "N/A";
                    int num = mpApp.CurrentService.WrapMaxSecs - this.inWrapSecs;
                    if (num > -1)
                        this.WrapTimeDataVal = this.IncrementTime(TimeSpan.FromSeconds((double)num));
                    //else if (this.mpCall.ChildCall == null)
                    //{
                    //    int maxWrapTime = mpApp.CurrentService.WrapMaxSecs;
                    //    this.inWrapSecs = 0;
                    //    this.WrapTimeDataVal = this.IncrementTime(TimeSpan.FromSeconds((double)maxWrapTime));
                    //}
                    else
                        this.WrapTimeDataVal = "N/A";

                    lbltimeWrap.Text= this.WrapTimeDataVal;
                }
                lblWrapAction.Text = this.WrapActionDataVal;
                //UpdateTitle data=new UpdateTitle();
                //data.Statetime= this.statetime;
                //data.Calltime= this.calltime;
                //data.Dnis=mpCall.Dnis;
                //data.Ani = mpCall.UserDefinedItems[0].value;
                //if (ItemChanged != null)
                //    ItemChanged(data);

                //if (mpCall.CurrentState.Id == AgentStateId.asDISPOSED) {
                //    string xx = "";
                //}
                CService byKey = (CService)mpApp.AssignedServices.GetByKey((object)this.mpCall.ServiceID);
                if (byKey.Timedpreviewflag==1 && this.mpCall.CurrentState.Id == AgentStateId.asPREVIEW)// && this.tbwin.MMediaManager.NumberOfCallLineButtonScreenPopRel == 1)
                {
                    Detail1.Height = 140;
                    pnlPreview.Visible = true;
                    ++this.previewSeconds;
                    int num = byKey.PreviewTimoutSecs - this.previewSeconds;
                    this.lblPreview.Text = num <= -1 ? "N/A" : this.IncrementTime(TimeSpan.FromSeconds((double)num));
                    if (this.previewSeconds == byKey.PreviewTimoutSecs || byKey.PreviewTimoutSecs <= 0)
                    {
                        this.mpApp.Dial(this.mpCall.PhoneNumber, this.mpCall.ServiceID, 0);
                        ItemChangedphone(mpCall.PhoneNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                //CallDataControl.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            }
        }
        internal void ResetRestartTimer(AgentStateId pState)
        {
            if (this.mpCall == null)
                return;

            switch (pState)
            {
                
                case AgentStateId.asACTIVE:
                    break;
                case AgentStateId.asHELD:
                    break;
                case AgentStateId.asACTIVE_INTERNAL:
                    break;
                case AgentStateId.asIDLE:
                case AgentStateId.asNOT_READY:
                    break;
                case AgentStateId.asPREVIEW:
                    break;
                case AgentStateId.asACTIVE_IM_INTERNAL:
                      if (this.StatusDurationTimer != null && this.StatusDurationTimer.IsEnabled)
                        {
                            this.StatusDurationTimer.IsEnabled = false;
                            this.isStatusDurationTimerStopped = true;
                        }
                        else if (this.isStatusDurationTimerStopped)
                        {
                            this.stateTimeElapsed = DateTime.UtcNow;
                            this.isStatusDurationTimerStopped = false;
                            this.StatusDurationTimer.IsEnabled = true;
                        }
                        break;
                   
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = true;
                //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";
                if (txtAddress1.Text == "")
                {
                    MessageBox.Show("New Address 1 must be filled out");
                    status = false;
                }
                else if (txtAddress2.Text == "")
                {
                    MessageBox.Show("New Address 2 must be filled out");
                    status = false;
                }
                else if (txtAddress3.Text == "")
                {
                    MessageBox.Show("New Address 3 must be filled out");
                    status = false;
                }
                else if (txtCity.Text == "")
                {
                    MessageBox.Show("New City must be filled out");
                    status = false;
                }
                else if (txtContact1.Text == "")
                {
                    MessageBox.Show("New Phone 1 must be filled out");
                    status = false;
                }
                else if (txtContact2.Text == "")
                {
                    MessageBox.Show("New Phone 2 must be filled out");
                    status = false;
                }
                else if (txtMobile.Text == "")
                {
                    MessageBox.Show("New Mobile must be filled out");
                    status = false;
                }

                if (status)
                {
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
                    req.Action = "ADDRESS";
                    req.TableName = TABLENAME;
                    req.AccountNo = LOANNO;
                    req.AccountNo1 = OTH_LOANNO1;
                    req.AccountNo2 = OTH_LOANNO2;
                    Cafe.Mortgage.Api.ServiceModel.AddressMetadata Address = new Cafe.Mortgage.Api.ServiceModel.AddressMetadata();

                    Address.NEW_ADDRESS_L1 = txtAddress1.Text;
                    Address.NEW_ADDRESS_L2 = txtAddress2.Text;
                    Address.NEW_ADDRESS_L3 = txtAddress3.Text;
                    Address.NEW_CITY = txtCity.Text;
                    Address.NEW_PHONE1 = txtContact1.Text;
                    Address.NEW_PHONE2 = txtContact2.Text;
                    Address.NEW_MOBILE = txtMobile.Text;
                    data.Address = Address;
                    req.Data = data;
                    //var client = new JsonServiceClient(_baseApiUrl);
                    var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
                {
                    { "X-Api-Key", ApiKey() }
                });
                    var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
                    if (response != null)
                    {
                        if (response.Success)
                        {
                            MessageBox.Show("DONE");
                            txtAddress1.Text = "";
                            txtAddress2.Text = "";
                            txtAddress3.Text = "";
                            txtCity.Text = "";
                            txtContact1.Text = "";
                            txtContact2.Text = "";
                            txtMobile.Text = "";
                            mainTabControl.SelectedTab = homeTabPage;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region PTP
        private void PopulateContactPlace()
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactPlace" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead($"Data\\ContactPlace.json"));

            //var dict = new Dictionary<string, string>();
            //dict.Add("MOBILE", "MOBILE PHONE");
            //dict.Add("OFFICE", "OFFICE");
            //dict.Add("RESI", "RESIDENCE / HOME");
            //dict.Add("OTHERS", "OTHERS");

            cbContactPlace.DataSource = new BindingSource(dict, null);
            cbContactPlace.DisplayMember = "Value";
            cbContactPlace.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopulateContactPlaceAll(ComboBox cb)
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactPlaceAll" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead($"Data\\ContactPlaceAll.json"));

            //var dict = new Dictionary<string, string>();
            //dict.Add("MOBILE", "MOBILE PHONE");
            //dict.Add("OFFICE", "OFFICE");
            //dict.Add("RESI", "RESIDENCE / HOME");
            //dict.Add("OTHERS", "OTHERS");

            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactPerson()
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactPerson" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead($"Data\\ContactPerson.json"));

            //var dict = new Dictionary<string, string>();
            //dict.Add("BORRWR", "BORROWER");
            //dict.Add("CP", "CONTACT PERSON");
            //dict.Add("SPS", "SPOUSE");
            //dict.Add("FATHER", "FATHER");
            //dict.Add("MOTHER", "MOTHER");
            //dict.Add("SIBLINGS", "KAKAK/ ADIK(SIBLING)");
            //dict.Add("SDR", "SAUDARA & ANAK");
            //dict.Add("SCR_ACTN", "SECRT/ACCNTG");

            cbContactPerson.DataSource = new BindingSource(dict, null);
            cbContactPerson.DisplayMember = "Value";
            cbContactPerson.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactPersonCP(ComboBox cb, string tipe)
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactPersonCP", ParamType = tipe.ToUpper() });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead($"Data\\ContactPersonCP{tipe.ToUpper()}.json"));

            //var dict = new Dictionary<string, string>();
            //if (tipe == "CP")
            //{
            //    dict.Add("CP", "CONTACT PERSON");
            //    dict.Add("SPS", "SPOUSE");
            //    dict.Add("FATHER", "FATHER");
            //    dict.Add("MOTHER", "MOTHER");
            //    dict.Add("SIBLINGS", "KAKAK/ ADIK(SIBLING)");
            //    dict.Add("SDR", "SAUDARA & ANAK");
            //    dict.Add("SCR_ACTN", "SECRT/ACCNTG");
            //}
            //else if (tipe == "PL")
            //{
            //    dict.Add("CP", "CONTACT PERSON");
            //    dict.Add("SPS", "SPOUSE");
            //    dict.Add("FATHER", "FATHER");
            //    dict.Add("MOTHER", "MOTHER");
            //    dict.Add("SIBLINGS", "KAKAK/ ADIK (SIBLING)");
            //    dict.Add("SDR", "SAUDARA & ANAK");
            //    dict.Add("SUPLMNT", "SUPPLEMENT");
            //    dict.Add("SCR_ACTN", "SECRT/ACCNTG");
            //    dict.Add("ATASAN", "ATASAN");
            //    dict.Add("FLD_COLL", "FIELD COLLECTOR");
            //    dict.Add("PEMBANTU", "PEMBANTU CH");
            //    dict.Add("TMN_KRJ", "TEMAN KERJA");
            //}
            //else if (tipe == "PO")
            //{
            //    dict.Add("ATASAN", "ATASAN");
            //    dict.Add("FLD_COLL", "FIELD COLLECTOR");
            //    dict.Add("PEMBANTU", "PEMBANTU CH");
            //    dict.Add("TMN_KRJ", "TEMAN KERJA");
            //    dict.Add("OTHER", "OTHER");
            //}
            //else if (tipe == "FC")
            //{
            //    dict.Add("BORRWR", "BORROWER");
            //    dict.Add("CP", "CONTACT PERSON");
            //    dict.Add("SPS", "SPOUSE");
            //    dict.Add("FATHER", "FATHER");
            //    dict.Add("MOTHER", "MOTHER");
            //    dict.Add("SIBLINGS", "KAKAK/ ADIK(SIBLING)");
            //    dict.Add("SDR", "SAUDARA & ANAK");
            //    dict.Add("SCR_ACTN", "SECRT/ACCNTG");
            //}
            //else if (tipe == "PE")
            //{
            //    dict.Add("BORRWR", "BORROWER");
            //    dict.Add("CP", "CONTACT PERSON");
            //    dict.Add("SPS", "SPOUSE");
            //    dict.Add("FATHER", "FATHER");
            //    dict.Add("MOTHER", "MOTHER");
            //    dict.Add("SIBLINGS", "KAKAK/ ADIK(SIBLING)");
            //    dict.Add("SDR", "SAUDARA & ANAK");
            //    dict.Add("SUPLMNT", "SUPPLEMENT");
            //    dict.Add("SCR_ACTN", "SECRT/ACCNTG");
            //    dict.Add("ATASAN", "ATASAN");
            //    dict.Add("FLD_COLL", "FIELD COLLECTOR");
            //    dict.Add("PEMBANTU", "PEMBANTU CH");
            //    dict.Add("TMN_KRJ", "TEMAN KERJA");
            //}
            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactActionPTP(ComboBox cb)
        {
            try { 
            //var dict = new Dictionary<string, string>();
            //dict.Add("PTP", "PTP");
            //dict.Add("PC", "PC");
            //dict.Add("PR", "PR");

            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactActionPTP" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead("Data\\ContactActionPTP.json"));
            
            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactActionpc(ComboBox cb)
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactActionCP" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead("Data\\ContactActionOther.json"));

            //var dict = new Dictionary<string, string>();
            //dict.Add("PC", "PC");
            //dict.Add("PTP", "PTP");
            //dict.Add("PR", "PR");

            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactActionOther(ComboBox cb)
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactActionOther" });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead("Data\\ContactActionOther.json"));

            //var dict = new Dictionary<string, string>();
            //dict.Add("PC", "PC");
            //dict.Add("PTP", "PTP");
            //dict.Add("PR", "PR");

            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulateContactActionCustomer(ComboBox cb, string tipe)
        {
            try { 
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Post(new GetParam { ParamName = "ContactActionCustomer", ParamType = tipe.ToUpper() });

            Dictionary<string, string> dict = response.Metadata;

            //Dictionary<string, string> dict = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
            //    System.IO.File.OpenRead($"Data\\ContactActionCustomer{tipe.ToUpper()}.json"));

            //var dict = new Dictionary<string, string>();
            //if (tipe == "PO") {
            //    dict.Add("PO", "PO");
            //    dict.Add("PE", "PE");
            //    dict.Add("PL", "PL");
            //    dict.Add("REF_FC", "REF FC");
            //}
            //else if (tipe == "PE")
            //{
            //    dict.Add("PE", "PE");
            //    dict.Add("PO", "PO");
            //    dict.Add("PL", "PL");
            //    dict.Add("REF_FC", "REF FC");
            //}
            //else if (tipe == "PE")
            //{
            //    dict.Add("PE", "PE");
            //    dict.Add("PO", "PO");
            //    dict.Add("PL", "PL");
            //    dict.Add("REF_FC", "REF FC");
            //}
            //else if (tipe == "REF")
            //{
            //    dict.Add("REF_FC", "REF FC");
            //    dict.Add("PE", "PE");
            //    dict.Add("PO", "PO");
            //    dict.Add("PL", "PL");
            //}
            //else if (tipe == "PR")
            //{
            //    dict.Add("PC", "PC");
            //    dict.Add("PTP", "PTP");
            //    dict.Add("PR", "PR");
            //}
            cb.DataSource = new BindingSource(dict, null);
            cb.DisplayMember = "Value";
            cb.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PopulatePTPHoldDate(ComboBox cb, string tipe)
        {
            DateTime now = DateTime.Now;
            DateTime tomorrow1 = now.AddDays(1);
            DateTime tomorrow2 = now.AddDays(2);
            DateTime tomorrow3 = now.AddDays(3);
            DateTime tomorrow4 = now.AddDays(4);
            DateTime tomorrow5 = now.AddDays(5);
            DateTime tomorrow6 = now.AddDays(6);
            DateTime tomorrow7 = now.AddDays(7);
            string Date1 = tomorrow1.ToString("dd/MM/yyyy");
            string Date2 = tomorrow2.ToString("dd/MM/yyyy");
            string Date3 = tomorrow3.ToString("dd/MM/yyyy");
            string Date4 = tomorrow4.ToString("dd/MM/yyyy");
            string Date5 = tomorrow5.ToString("dd/MM/yyyy");
            string Date6 = tomorrow6.ToString("dd/MM/yyyy");
            string Date7 = tomorrow7.ToString("dd/MM/yyyy");
            var dict = new Dictionary<string, string>();
            dict.Add(Date1, Date1);
            dict.Add(Date2, Date2);
            dict.Add(Date3, Date3);

            var dictR = new Dictionary<string, string>();
            dictR.Add(Date1, Date1);
            dictR.Add(Date2, Date2);
            dictR.Add(Date3, Date3);
            dictR.Add(Date4, Date4);
            dictR.Add(Date5, Date5);
            dictR.Add(Date6, Date6);
            dictR.Add(Date7, Date7);
            if (tipe == "PTP")
            {
                cb.DataSource = new BindingSource(dict, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
                txtRemark.Text = "@PTP_" + Date1 + "_";
            }
            else if (tipe == "PR")
            {
                cb.DataSource = new BindingSource(dictR, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }
        }
        private CDisposition getdeposito(string dispcode) {
            CDispositions dispositions = mpApp.CurrentService.DispositionPlan.Dispositions;
            CDisposition disposition = (CDisposition)null;
            for (int index = 0; index < dispositions.Count; ++index)
            {
                CDisposition dispositionx = dispositions[index];
                if (dispositionx.Code.ToUpper() == dispcode.ToUpper())
                {
                    disposition= dispositionx;
                    break;
                }
            }
            return disposition;
        }
        private void disposition() {
            try
            {
                if (cbDisposisi1.Items.Count <= 0)
                {
                    CDispositions dispositions = mpApp.CurrentService.DispositionPlan.Dispositions;
                    CDisposition disposition = (CDisposition)null;
                    if (dispositions != null)
                    {
                        DataTable dataTable = new DataTable("Employees");

                        dataTable.Columns.Add("Id", typeof(String));
                        dataTable.Columns.Add("Description", typeof(String));
                        dataTable.Columns.Add("Code", typeof(String));
                        dataTable.Columns.Add("Type", typeof(String));


                        dataTable.Rows.Add(new String[] { "", "Select a Disposition", "", "" });
                        for (int index = 0; index < dispositions.Count; ++index)
                        {
                            //dispositions.GetByKey[dispositions.];
                            disposition = dispositions[index];
                            if (disposition.IsCallback)
                                dataTable.Rows.Add(new String[] { disposition.Id.ToString(), disposition.Description, "Callback", disposition.Code });
                            else if (disposition.IsExclusion)
                                dataTable.Rows.Add(new String[] { disposition.Id.ToString(), disposition.Description, "Exclusion", disposition.Code });
                            else if (disposition.IsSale)
                                dataTable.Rows.Add(new String[] { disposition.Id.ToString(), disposition.Description, "Sale", disposition.Code });
                            else
                                dataTable.Rows.Add(new String[] { disposition.Id.ToString(), disposition.Description, "Refusal", disposition.Code });


                        }

                        cbDisposisi1.DataSource = dataTable;
                        cbDisposisi1.DisplayMember = "Description";
                        cbDisposisi1.ValueMember = "Id";
                        cbDisposisi1.SelectedIndex = 0;

                    }
                }
            }
            catch { }
        }
        private void btnUpdatePTP_Click(object sender, EventArgs e)
        {
            try { 
            bool status = true;
            Decimal PTPAmount2 = 0;
            Decimal PTPAMOUNT2 = 0;
            bool isPTPAmount2 = Decimal.TryParse(txtPTPAmount2.Text, out PTPAmount2);
            if (isPTPAmount2)
                PTPAMOUNT2 = Decimal.Parse(txtPTPAmount2.Text.ToString());

            Decimal PTPAmount3 = 0;
            Decimal PTPAMOUNT3 = 0;
            bool isPTPAmount3 = Decimal.TryParse(txtPTPAmount3.Text, out PTPAmount3);
            if (isPTPAmount3)
                PTPAMOUNT3 = Decimal.Parse(txtPTPAmount3.Text.ToString());

            var PTPDATE2 = cbPTPHoldDate2.SelectedValue.ToString();
            var PTPDATE3 = cbPTPHoldDate3.SelectedValue.ToString();
            Decimal PTPAmount1;
            bool isPTPAmount1 = Decimal.TryParse(txtPTPAmount1.Text, out PTPAmount1);

            if (!isPTPAmount1)
            {
                MessageBox.Show("PTP Amount should be a numeric!");
                status = false;
                //return;
            }
            else if (PTPAmount1 < 15000 || (txtPTPAmount1.Text == ""))
            {
                MessageBox.Show("Please enter values for PTP Amount and try again");
                status = false;
                //return;
            }
            else if (txtRemark.Text == "")
            {
                MessageBox.Show("Please enter values for Remarks and try again.");
                status = false;
                //return;
            }
            //else if (uipIsAgentStateWRAP() == 1)
            //{

            //}
            if (cbActionCode1.SelectedValue.ToString() == "PTP")
            {
                if (txtPTPAmount2.Text == "")
                {
                    MessageBox.Show("PTP Amount Card #2 Must Be Filled");
                    status = false;
                    //return;
                }
                else
                {
                    //Decimal PTPAmount2;
                    //bool isPTPAmount2 = Decimal.TryParse(txtPTPAmount2.Text, out PTPAmount2);

                    if (!isPTPAmount2)
                    {
                        MessageBox.Show("PTP Amount should be a numeric!");
                        status = false;
                        //return;
                    }
                }
            }
            else
            {
                PTPDATE2 = "";
                PTPAMOUNT2 = 0;
            }
            if (cbActionCode2.SelectedValue.ToString() == "PTP")
            {
                if (txtPTPAmount3.Text == "")
                {
                    MessageBox.Show("PTP Amount Card #3 Must Be Filled");
                    status = false;
                    // return;
                }
                else
                {

                    if (!isPTPAmount3)
                    {
                        MessageBox.Show("PTP Amount should be a numeric!");
                        status = false;
                        //return;
                    }
                }
            }
            else
            {
                PTPDATE3 = "";
                PTPAMOUNT3 = 0;
            }



            if (cbActionCode1.SelectedValue.ToString() == "PR")
            {
                PTPDATE2 = cbPTPPRDate1.SelectedValue.ToString();
            }

            if (cbActionCode2.SelectedValue.ToString() == "PR")
            {
                PTPDATE3 = cbPTPPRDate2.SelectedValue.ToString();
            }

            //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";
            if (status)
            {
                Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
                Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
                req.Action = "PTP";
                req.TableName = TABLENAME;
                req.AccountNo = LOANNO;
                req.AccountNo1 = OTH_LOANNO1;
                req.AccountNo2 = OTH_LOANNO2;
                req.IsPrev = screen;
                Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
                otherMetadata.INPUT_CONTACT_PLACE1 = cbContactPlace.SelectedValue.ToString();
                otherMetadata.IN_PERSON_CONTACT1 = cbContactPerson.SelectedValue.ToString();
                otherMetadata.INPUT_REMARKS1 = txtRemark.Text;
                otherMetadata.PTPAMOUNT = Decimal.Parse(txtPTPAmount1.Text);
                otherMetadata.PTPDATE = cbPTPHoldDate.SelectedValue.ToString();
                otherMetadata.PTPAMOUNT2 = PTPAMOUNT2;// Decimal.Parse(txtPTPAmount2.Text);
                otherMetadata.PTPDATE2 = PTPDATE2;// cbPTPHoldDate2.SelectedValue.ToString();
                otherMetadata.PTPAMOUNT3 = PTPAMOUNT3;// Decimal.Parse(txtPTPAmount3.Text);
                otherMetadata.PTPDATE3 = PTPDATE3;// cbPTPHoldDate3.SelectedValue.ToString();
                otherMetadata.ACTION2 = cbActionCode1.SelectedValue.ToString();
                otherMetadata.ACTION3 = cbActionCode2.SelectedValue.ToString();

                data.Other = otherMetadata;
                req.Data = data;
                //var client = new JsonServiceClient(_baseApiUrl);
                var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
                {
                    { "X-Api-Key", ApiKey() }
                });
                var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
                if (response != null)
                {
                    if (response.Success)
                    {
                        if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            txtRemark.Text = "";
                            txtPTPAmount1.Text = "";
                            txtPTPAmount2.Text = "";
                            txtPTPAmount3.Text = "";
                            calloutcome("PTP");
                        }
                    }
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion
        bool calloutcome(string dispcode)
        {
            try
            {
                if (mpCall.CurrentState.Id == AgentStateId.asPREVIEW || mpCall.CurrentState.Id == AgentStateId.asWRAP)
                {

                    CDispositions dispositions = mpApp.CurrentService.DispositionPlan.Dispositions;
                    CDisposition disposition = (CDisposition)null;
                    for (int index = 0; index < dispositions.Count; ++index)
                    {
                        //dispositions.GetByKey[dispositions.];
                        disposition = dispositions[index];
                        if (disposition.Code == dispcode)
                            break;
                    }
                    //mpApp.DisposeCall(mpCall, disposition);
                    mpApp.DisposeCall(mpCall, disposition);
                    //this._mpApp.DisposeCall(this._mpCall.CallLine.ParentCall, disposition);
                }
                //this._mpApp.DisposeCall(this._mpCall.CallLine.ParentCall, disposition);
                return true;
            }
            catch (Exception ex)
            {
                //LyriScriptService.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, "LyrScriptWindow.CallOutCome() : Error Ecountered while Disposing :" + ex.Message, false);
                return false;
            }
        }
        private void SendDigitsToCC(string digits)
        {
            //KeypadUC.Log.DebugFormat("[{0}] ENTER, Digits: {1}", (object)MethodBase.GetCurrentMethod().Name, (object)digits);
            this.mpApp.PlayDigits(new DigitData()
            {
                CallId = this.mpApp.CurrentCall.CallID,
                Digits = digits
            });
        }
        bool calloutcomeD(CDisposition disposition)
        {
            try
            {

                if (mpCall.CurrentState.Id == AgentStateId.asPREVIEW || mpCall.CurrentState.Id == AgentStateId.asWRAP)
                {
                    mpApp.DisposeCall(mpCall, disposition);
                }
                //this._mpApp.DisposeCall(this._mpCall.CallLine.ParentCall, disposition);
                return true;
            }
            catch (Exception ex)
            {
                //LyriScriptService.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, "LyrScriptWindow.CallOutCome() : Error Ecountered while Disposing :" + ex.Message, false);
                return false;
            }
        }

        #region aspect
        int posisi = 0, WidthY=0;
        bool ParentY = true;
        public FCallData(CCall pCall, CApp pApp, int posisiY, int ParentWidth, bool ParentY)
        {
          
            Rectangle ScreenArea = Screen.GetWorkingArea(this);
            posisi = posisiY;
            WidthY = ParentWidth;
            this.ParentY = ParentY;
            InitializeComponent();
            txtDisposisiDesc.CharacterCasing = CharacterCasing.Upper;
            this.mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            mainTabControl.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            KeyPreview = true;
            callbackdate.Format = DateTimePickerFormat.Custom;
            callbackTime.Format = DateTimePickerFormat.Time;
            callbackTime.ShowUpDown = true;
            grp_action.Visible = true;
            load_group(false);
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            PopulateSnoozeComboBox();
            txtDisposisiDesc.KeyDown += new KeyEventHandler(txtDisposisiDesc_KeyDown);
            //PopulateContactPlace();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            mpCall = pCall;
            mpApp = pApp;
            mpService = this.mpApp.CurrentService;
         
            try
            {
                if (mpService != null)
                    disposition();
                //UserTimeZones userTimeZones = new UserTimeZones(mpApp);
                var dict = new Dictionary<int, string>();
                SamplePortalClient.EPAgentWSP.TimeZone[] timeZones = mpApp.getTimeZones();
                for (int i = 0; i < timeZones.Length; i++)
                {
                    UserTimeZone userTimeZone = new UserTimeZone(timeZones[i].id.Value, timeZones[i].gmtoffset.Value, timeZones[i].timezonedesc, timeZones[i].identifier);
                    //Log.DebugFormat("[{0}] TimeZone[{1}]: {2}", MethodBase.GetCurrentMethod().Name, i, userTimeZone.ToString());
                    //Add(userTimeZone.TimeZoneID, userTimeZone);
                    dict.Add(userTimeZone.TimeZoneID, userTimeZone.TimeZoneDesc);
                }

                TZComboBox.DataSource = new BindingSource(dict, null);
                TZComboBox.DisplayMember = "Value";
                TZComboBox.ValueMember = "Key";
                TZComboBox.SelectedValue = 7;
                cbExclusionTimezone.DataSource = new BindingSource(dict, null);
                cbExclusionTimezone.DisplayMember = "Value";
                cbExclusionTimezone.ValueMember = "Key";
                cbExclusionTimezone.SelectedValue = 7;
                loaddataws(screen);
                try
                {
                    if (mpApp.AssignedServices.GetByKey((object)this.mpApp.CurrentCall.ServiceID).Lyricallscriptname.ToString().ToUpper() == "D_LOAN_V72")
                    {
                        button22.Visible = false;
                        button21.Visible = false;
                        button20.Visible = false;
                        button19.Visible = false;
                        txtContactno.Text = mpCall.PhoneNumber;
                        txtContactno.Visible = true;
                        screen = false;
                    }
                    else
                    {
                        button22.Visible = true;
                        button21.Visible = true;
                        button20.Visible = true;
                        button19.Visible = true;
                        txtContactno.Visible = false;
                        //lblForeClosure_amt1.Text = lblForeClosure_amt1.Text.ToMoneyFormat(2);
                        lblInhouseScore.Text = lblInhouseScore.Text.ToMoneyFormat(2);
                        LblPrincipal1.Text = LblPrincipal1.Text.ToMoneyFormat(2);
                        screen = true;
                    }
                }

                catch (Exception ex) { }
            }
            catch (Exception ex) { }


           
            
        }
        private void PopulateSnoozeComboBox()
        {
            var dict = new Dictionary<string, string>();
            dict.Add("", "No Snooze");
            dict.Add("5", "5 Minutes");
            dict.Add("10", "10 Minutes");
            dict.Add("15", "15 Minutes");
            dict.Add("30", "30 Minutes");
            dict.Add("60", "1 Hour");
            dict.Add("120", "2 Hours");
            dict.Add("180", "3 Hours");
            dict.Add("300", "5 Hours");
            dict.Add("1440", "1 Day");
            dict.Add("2880", "2 Days");
            dict.Add("4320", "3 Days");
            dict.Add("10080", "1 Week");
            dict.Add("20160", "2 Weeks");
            cbSnooze.DataSource = new BindingSource(dict, null);
            cbSnooze.DisplayMember = "Value";
            cbSnooze.ValueMember = "Key";
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        bool screen = false;
        public void CApp_StateChange(Object pSender, CStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new StateChangeHandler(this.CApp_StateChange), new Object[] { pSender, pArgs });
                return;
            }
            try
            {

                CState pNewState = pArgs.NewState;
                this.WrapAction = mpApp.CurrentService.WrapExceedAction;
                if (this.WrapAction == 1)
                    this.sheader3 = " WARN";
                else if (this.WrapAction == 2)
                    this.sheader3 = !this.mpApp.CurrentAgent.AllowPark ? " NOT READY" : " PARK";
                else if (this.WrapAction == 3)
                    this.sheader3 = " IDLE";
                else if (this.WrapAction == 4)
                    this.sheader3 = " NOT READY";

                btnHangup.Enabled = pNewState.EnableHangup;
                btnDial.Enabled = pNewState.EnableDial;
                btnHold.Enabled = pNewState.EnableHold;
                btn3Way.Enabled = pNewState.Enable3Way;
                btnRecord.Enabled = pNewState.EnableRecord;
                this.stateTimeElapsed = DateTime.UtcNow;
                pnlPreview.Visible = false;
                Detail1.Height = 85;
                ResetRestartTimer(pArgs.NewState.Id);
                btnDisposisi.Enabled = true;

                switch (pArgs.NewState.Id)
                {
                  
                    case AgentStateId.asACTIVE:
                        buttonDial(true);
                        btnDisposisi.Enabled = false;
                        break;
                    case AgentStateId.asHELD:
                        btnHold.BackgroundImage = SamplePortalClientUI.Properties.Resources.play;
                        btnDisposisi.Enabled = false;
                        break;
                    case AgentStateId.asACTIVE_INTERNAL:
                        if (mpCall.ResponseRequired && mpAnswerCallTimer != null)
                        {
                            ResetAnswerCallPanel();

                            //Hide panel
                            //pnlAnswerCall.Visible = false;

                            //Start Unload Timer which fires only once in the next 4 seconds
                            //System.Threading.TimerCallback timerDelegate = new System.Threading.TimerCallback(mpUnloadTimer_Fire);
                            //mpUnloadTimer = new System.Threading.Timer(timerDelegate, this, 4000, System.Threading.Timeout.Infinite);
                        }
                        break;

                    //If went to Idle or NotReady (eg, because Call offering was rejected or timed out), close the form
                    case AgentStateId.asLOGGED_OUT:
                        this.Close();
                        break;
                    case AgentStateId.asIDLE:
                        btnDisposisi.Enabled = false;
                        this.Dispose();
                        this.Close();
                        break;
                    case AgentStateId.asNOT_READY:
                        this.Dispose();
                        this.Close();
                        break;

                }
                if (pArgs.NewState.Id == AgentStateId.asPREVIEW || pArgs.NewState.Id == AgentStateId.asACTIVE)
                {
                    try
                    {
                        disposition();
                      
                        try
                        {
                            if (mpApp.AssignedServices.GetByKey((object)this.mpApp.CurrentCall.ServiceID).Lyricallscriptname.ToString().ToUpper() == "D_LOAN_V72")
                            {
                                button22.Visible = false;
                                button21.Visible = false;
                                button20.Visible = false;
                                button19.Visible = false;
                                txtContactno.Text = mpCall.PhoneNumber;
                                txtContactno.Visible = true;
                                
                                screen = false;
                            }
                            else
                            {
                                button22.Visible = true;
                                button21.Visible = true;
                                button20.Visible = true;
                                button19.Visible = true;
                                txtContactno.Visible = false;
                                //lblForeClosure_amt1.Text= lblForeClosure_amt1.Text.ToMoneyFormat(2);
                                lblInhouseScore.Text = lblInhouseScore.Text.ToMoneyFormat(2);
                                 LblPrincipal1.Text = LblPrincipal1.Text.ToMoneyFormat(2);
                                screen = true;
                            }
                        }

                        catch (Exception ex) { }
                    }
                    catch (Exception ex) { }

                }

            }
            catch (Exception ex) { }
        }
        private void btnHold_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (mpApp.CurrentCall.CurrentState is CStateHeld)
                    mpApp.ReleaseHold();
                else
                    mpApp.Hold();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }
        private void btnHangup_Click(object sender, System.EventArgs e)
        {
            try
            {
                mpApp.Hangup(mpApp.CurrentCall);
                buttonDial(false);

            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }
        private void btn3Way_Click(object sender, EventArgs e)
        {
            F3Way pForm3Way = new F3Way(mpApp);
            pForm3Way.ShowDialog();
        }
        public void CApp_CUnfocusStateChange(object pSender, CUnfocusedStateChangeArgs pArgs)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((Delegate)new UnfocusedStateChangeHandler(this.CApp_CUnfocusStateChange), pSender, (object)pArgs);
                    return;
                }
            }
            catch (Exception ex)
            {
            }
            try
            {
                CState newState = pArgs.NewState;
                this.inWrapSecs = -1;
                this.bDisplayWrapWarning = false;
            
                this.WrapActionDataVal = "";
                this.WrapTimeDataVal = "";
                this.ResetRestartTimer(pArgs.NewState.Id);

                if (pArgs.NewState.Id != AgentStateId.asIDLE && pArgs.NewState.Id != AgentStateId.asAUTHENTICATED && pArgs.NewState.Id != AgentStateId.asINACTIVE && pArgs.NewState.Id != AgentStateId.asPARKED && pArgs.NewState.Id != AgentStateId.asNOT_READY && pArgs.NewState.Id != AgentStateId.asHELD && pArgs.NewState.Id != AgentStateId.asACTIVE && pArgs.NewState.Id != AgentStateId.asRINGING && pArgs.NewState.Id != AgentStateId.asCONFERENCE && pArgs.NewState.Id != AgentStateId.asCHATTING && pArgs.NewState.Id != AgentStateId.asCONSULTING && pArgs.NewState.Id != AgentStateId.asDIALING_CONSULTATION && pArgs.NewState.Id != AgentStateId.asDIALING && pArgs.NewState.Id != AgentStateId.asWAITING)
                {
                    if (pArgs.NewState.Id == AgentStateId.asWRAP)
                    {
                        //this.btnSurvey.Enabled = false;
                        //this.btnSurvey.BackgroundImage = (Image)Resources.transfer_or_left_right_arrows;
                        //this.lblUserName.BackColor = Color.Yellow;
                        //this.lblUserName.ForeColor = Color.Black;
                    }
                    else if (pArgs.NewState.Id == AgentStateId.asLOGGED_OUT || pArgs.NewState.Id == AgentStateId.asLOGGING_IN || pArgs.NewState.Id != AgentStateId.asPREVIEW) ;
                }
                //this.btnHangup.Enabled = newState.EnableHangup && this.mpApp.CurrentService.AllowHangup;
                //this.btnDial.Enabled = newState.EnableDial;
                //this.btnHold.Enabled = newState.EnableHold && this.mpApp.CurrentService.AllowHold;
                //this.btn3Way.Enabled = newState.Enable3Way;
                //this.btnNextCall.Enabled = newState.EnableNextCall;
                btnHangup.Enabled = newState.EnableHangup && this.mpApp.CurrentService.AllowHangup;
                btnDial.Enabled = newState.EnableDial;
                btnHold.Enabled = newState.EnableHold && this.mpApp.CurrentService.AllowHold;
                btn3Way.Enabled = newState.Enable3Way;
                btnRecord.Enabled = newState.EnableRecord;

                switch (pArgs.NewState.Id)
                {
                    case AgentStateId.asACTIVE:
                        this.btnHold.Text = "Hold";
                        break;
                    case AgentStateId.asHELD:
                        this.btnHold.Text = "Pick up";
                        break;
                    case AgentStateId.asLOGGED_OUT:
                        if (this.mpUnloadTimer == null)
                        {
                            this.mpUnloadTimer = new System.Threading.Timer(new TimerCallback(this.mpUnloadTimer_Fire), (object)this, 100, 1000);
                            break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public void CApp_CallStateChange(Object pSender, CCallStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new CallStateChangeHandler(this.CApp_CallStateChange), new Object[] { pSender, pArgs });
                return;
            }

            //This is the main thread. Update the UI.
            if (pArgs.Call is C3WayCall1stParty)
            {
                btnHold.Enabled = pArgs.Call.CurrentState.EnableHold;
                btnHangup.Enabled = pArgs.Call.CurrentState.EnableHangup;
                //btnHold.Text = (pArgs.Call.CurrentState is CStateHeld ? "Pick Up" : "Hold");
                if (btnHangup.Enabled)
                {
                    buttonDial(true);
                }
            }
        }
        public void mpUnloadTimer_Fire(Object state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Threading.TimerCallback(mpUnloadTimer_Fire), new Object[] { state });
                return;
            }

            mpUnloadTimer.Dispose();
            mpUnloadTimer = null;
            this.Close();
        }
       
        public void mpAnswerCallTimer_Fire(Object state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Threading.TimerCallback(mpAnswerCallTimer_Fire), new Object[] { state });
                return;
            }

            miAnswerCallTickCount--;

            //if (miAnswerCallTickCount < 0)
            //    ResetAnswerCallPanel();
            //else
            //    lblAnswerCallCountDown.Text = miAnswerCallTickCount.ToString("000");
        }

        private void ResetAnswerCallPanel()
        {
            if (mpAnswerCallTimer != null)
                mpAnswerCallTimer.Dispose();
            mpAnswerCallTimer = null;

            //btnAcceptCall.Enabled = false;
            //btnRejectCall.Enabled = false;

            //Unload rejections reasons dialog, if loaded
            if (CallRejectionForm != null)
                CallRejectionForm.Close();
            CallRejectionForm = null;
        }
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            try
            {
                unRegiter();

                if (mpUnloadTimer != null)
                    mpUnloadTimer.Dispose();
                mpUnloadTimer = null;

                if (mpAnswerCallTimer != null)
                    mpAnswerCallTimer.Dispose();
                mpAnswerCallTimer = null;

                //Unload rejections reasons dialog, if loaded
                if (CallRejectionForm != null)
                    CallRejectionForm.Close();
                CallRejectionForm = null;

            }
            catch (Exception pError)
            {
                //Console.WriteLine(pError.StackTrace);
            }
        }
        private void FCallData_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                StatusDurationTimer.Stop();
               
                if (mpUnloadTimer != null)
                    mpUnloadTimer.Dispose();
                mpUnloadTimer = null;

                if (mpAnswerCallTimer != null)
                    mpAnswerCallTimer.Dispose();
                mpAnswerCallTimer = null;

                //Unload rejections reasons dialog, if loaded
                if (CallRejectionForm != null)
                    CallRejectionForm.Close();
                CallRejectionForm = null;

            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }

        }


        #endregion

        private void button18_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            action_phone = "ACCTIDAKLAYAKTAGIH";
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "ACCPE");
            PopulateContactActionCustomer(cbPLaction1, "PE");
            PopulateContactActionCustomer(cbPLaction2, "PE");
            lblactioncode2.Text = "PE";
            lblSendback.Visible = false;
            btnSendback.Visible = false;
            button39.Location = new Point(176, 231);
            btnCancel1.Location = new Point(279, 231);
            txtRemarkleave.Focus();
            txtRemarkleave.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            action_phone = "CUSTOMERDECEASE";
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "CDPE");
            PopulateContactActionCustomer(cbPLaction1, "PE");
            PopulateContactActionCustomer(cbPLaction2, "PE");
            lblactioncode2.Text = "PE";
            lblSendback.Visible = false;
            btnSendback.Visible = false;
            button39.Location = new Point(176, 231);
            btnCancel1.Location = new Point(279, 231);
            txtRemarkleave.Focus();
            txtRemarkleave.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            action_phone = "SENTTOFC";
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "FC");
            PopulateContactActionCustomer(cbPLaction1, "REF");
            PopulateContactActionCustomer(cbPLaction2, "REF");
            lblactioncode2.Text = "REF FC";
            lblSendback.Visible = false;
            btnSendback.Visible = false;
            button39.Location = new Point(176, 231);
            txtRemarkleave.Focus();
            btnCancel1.Location = new Point(279, 231);
            txtRemarkleave.Text = "@FC_";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
            grp_phone_leave_message.Location = new Point(grp_action.Location.X, grp_action.Location.Y);
            action_phone = "CASECOMPLAIN";
            PopulateContactPlaceAll(cbContactPLPlace);
            PopulateContactPersonCP(cbContactPersonPl, "CCPE");
            PopulateContactActionCustomer(cbPLaction1, "PE");
            PopulateContactActionCustomer(cbPLaction2, "PE");
            lblactioncode2.Text = "PE";
            lblSendback.Visible = false;
            btnSendback.Visible = false;
            button39.Location = new Point(176, 231);
            btnCancel1.Location = new Point(279, 231);
            txtRemarkleave.Focus();
            txtRemarkleave.Text = "";
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            saveCP("save");
            //    ;
            //{
            //    Pcalldata.IsExpanded = false;
            //    pscheduler.IsExpanded = true;
            //    CDisposition dispositions = getdeposito("PC");
            //    cbDisposisi.SelectedValue = dispositions.Id;
            //}
        }

        private bool saveCallBack(string action)
        {
            bool status = true;
            try
            {
                Decimal PTPAmount2 = 0;
                Decimal PTPAMOUNT2 = 0;
                bool isPTPAmount2 = Decimal.TryParse(txtBAmount2.Text, out PTPAmount2);
                if (isPTPAmount2)
                    PTPAMOUNT2 = Decimal.Parse(txtBAmount2.Text.ToString());

                Decimal PTPAmount3 = 0;
                Decimal PTPAMOUNT3 = 0;
                bool isPTPAmount3 = Decimal.TryParse(txtBAmount3.Text, out PTPAmount3);
                if (isPTPAmount3)
                    PTPAMOUNT3 = Decimal.Parse(txtBAmount3.Text.ToString());

                var PTPDATE2 = cbBHoldDate1.SelectedValue.ToString();
                var PTPDATE3 = cbBHoldDate2.SelectedValue.ToString();

                if (txtRemarkB.Text == "")
                {
                    MessageBox.Show("Please enter values for Remarks and try again.");
                    status = false;
                }
                if (cbBaction1.SelectedValue.ToString() == "PTP")
                {
                    if (txtBAmount2.Text == "")
                    {
                        MessageBox.Show("PTP Amount Card #2 Must Be Filled");
                        status = false;
                    }
                    else
                    {
                        if (!isPTPAmount2)
                        {
                            MessageBox.Show("PTP Amount should be a numeric!");
                            status = false;
                        }
                    }
                }
                else
                {
                    PTPDATE2 = "";
                    PTPAMOUNT2 = 0;
                }
                if (cbBaction2.SelectedValue.ToString() == "PTP")
                {
                    if (txtBAmount3.Text == "")
                    {
                        MessageBox.Show("PTP Amount Card #3 Must Be Filled");
                        status = false;
                    }
                    else
                    {

                        if (!isPTPAmount3)
                        {
                            MessageBox.Show("PTP Amount should be a numeric!");
                            status = false;
                        }
                    }
                }
                else
                {
                    PTPDATE3 = "";
                    PTPAMOUNT3 = 0;
                }
                if (cbBaction1.SelectedValue.ToString() == "PR")
                {
                    PTPDATE2 = cbBPRHoldDate1.SelectedValue.ToString();
                }

                if (cbBaction2.SelectedValue.ToString() == "PR")
                {
                    PTPDATE3 = cbBPRHoldDate2.SelectedValue.ToString();
                }

                //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";
                if (status)
                {
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
                    req.Action = "BORROWER";
                    req.TableName = TABLENAME;
                    req.AccountNo = LOANNO;
                    req.AccountNo1 = OTH_LOANNO1;
                    req.AccountNo2 = OTH_LOANNO2;
                    req.IsPrev = screen;
                    Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
                    otherMetadata.INPUT_CONTACT_PLACE1 = cbContactBPlace.SelectedValue.ToString();
                    otherMetadata.IN_PERSON_CONTACT1 = "BORRWR";
                    otherMetadata.INPUT_REMARKS1 = txtRemarkB.Text;
                    //otherMetadata.PTPAMOUNT = Decimal.Parse(txtPTPAmount1.Text);
                    //otherMetadata.PTPDATE = cbBHoldDate1.SelectedValue.ToString();
                    otherMetadata.PTPAMOUNT2 = PTPAMOUNT2;// Decimal.Parse(txtPTPAmount2.Text);
                    otherMetadata.PTPDATE2 = PTPDATE2;// cbPTPHoldDate2.SelectedValue.ToString();
                    otherMetadata.PTPAMOUNT3 = PTPAMOUNT3;// Decimal.Parse(txtPTPAmount3.Text);
                    otherMetadata.PTPDATE3 = PTPDATE3;// cbPTPHoldDate3.SelectedValue.ToString();
                    otherMetadata.ACTION2 = cbBaction1.SelectedValue.ToString();
                    otherMetadata.ACTION3 = cbBaction2.SelectedValue.ToString();

                    data.Other = otherMetadata;
                    req.Data = data;
                    //var client = new JsonServiceClient(_baseApiUrl);
                    var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
                    var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
                    if (response != null)
                    {
                        if (response.Success)
                        {

                            if (action == "save")
                            {
                                if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    calloutcome("PC");
                                    txtRemarkB.Text = "";
                                    txtBAmount2.Text = "";
                                    txtBAmount3.Text = "";
                                    status = true;
                                }
                            }

                        }
                        else
                            status = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return status;

        }
        private bool saveCP(string action) {
            bool status = true;
            try
            {
              
                Decimal PTPAmount2 = 0;
                Decimal PTPAMOUNT2 = 0;
                bool isPTPAmount2 = Decimal.TryParse(txtCPAmount2.Text, out PTPAmount2);
                if (isPTPAmount2)
                    PTPAMOUNT2 = Decimal.Parse(txtCPAmount2.Text.ToString());

                Decimal PTPAmount3 = 0;
                Decimal PTPAMOUNT3 = 0;
                bool isPTPAmount3 = Decimal.TryParse(txtCPAmount3.Text, out PTPAmount3);
                if (isPTPAmount3)
                    PTPAMOUNT3 = Decimal.Parse(txtCPAmount3.Text.ToString());

                var PTPDATE2 = cbCPHoldDate1.SelectedValue.ToString();
                var PTPDATE3 = cbCPHoldDate2.SelectedValue.ToString();

                if (txtRemarkCP.Text == "")
                {
                    MessageBox.Show("Please enter values for Remarks and try again.");
                    status = false;
                }
                if (cbCPaction1.SelectedValue.ToString() == "PTP")
                {
                    if (txtCPAmount2.Text == "")
                    {
                        MessageBox.Show("PTP Amount Card #2 Must Be Filled");
                        status = false;
                    }
                    else
                    {
                        if (!isPTPAmount2)
                        {
                            MessageBox.Show("PTP Amount should be a numeric!");
                            status = false;
                        }
                    }
                }
                else
                {
                    PTPDATE2 = "";
                    PTPAMOUNT2 = 0;
                }
                if (cbCPaction2.SelectedValue.ToString() == "PTP")
                {
                    if (txtCPAmount3.Text == "")
                    {
                        MessageBox.Show("PTP Amount Card #3 Must Be Filled");
                        status = false;
                    }
                    else
                    {

                        if (!isPTPAmount3)
                        {
                            MessageBox.Show("PTP Amount should be a numeric!");
                            status = false;
                        }
                    }
                }
                else
                {
                    PTPDATE3 = "";
                    PTPAMOUNT3 = 0;
                }
                if (cbCPaction1.SelectedValue.ToString() == "PR")
                {
                    PTPDATE2 = cbCPPRHoldDate1.SelectedValue.ToString();
                }

                if (cbCPaction2.SelectedValue.ToString() == "PR")
                {
                    PTPDATE3 = cbCPPRHoldDate2.SelectedValue.ToString();
                }

                //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";
                if (status)
                {
                  
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
                    Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
                    req.Action = "CP";
                    req.TableName = TABLENAME;
                    req.AccountNo = LOANNO;
                    req.AccountNo1 = OTH_LOANNO1;
                    req.AccountNo2 = OTH_LOANNO2;
                    req.IsPrev = screen;
                    Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
                    otherMetadata.INPUT_CONTACT_PLACE1 = cbContactCPPlace.SelectedValue.ToString();
                    otherMetadata.IN_PERSON_CONTACT1 = cbContactPersonCP.SelectedValue.ToString();
                    otherMetadata.INPUT_REMARKS1 = txtRemarkCP.Text;
                    //otherMetadata.PTPAMOUNT = Decimal.Parse(txtPTPAmount1.Text);
                    otherMetadata.PTPDATE = cbCPHoldDate1.SelectedValue.ToString();
                    otherMetadata.PTPAMOUNT2 = PTPAMOUNT2;// Decimal.Parse(txtPTPAmount2.Text);
                    otherMetadata.PTPDATE2 = PTPDATE2;// cbPTPHoldDate2.SelectedValue.ToString();
                    otherMetadata.PTPAMOUNT3 = PTPAMOUNT3;// Decimal.Parse(txtPTPAmount3.Text);
                    otherMetadata.PTPDATE3 = PTPDATE3;// cbPTPHoldDate3.SelectedValue.ToString();
                    otherMetadata.ACTION2 = cbCPaction1.SelectedValue.ToString();
                    otherMetadata.ACTION3 = cbCPaction2.SelectedValue.ToString();

                    data.Other = otherMetadata;
                    req.Data = data;
                    //var client = new JsonServiceClient(_baseApiUrl);
                    var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
                    {
                        { "X-Api-Key", ApiKey() }
                    });
                    var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
                    if (response != null)
                    {
                        if (response.Success)
                        {
                           
                            if (action == "save")
                            {
                                if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    txtCPAmount2.Text = "";
                                    txtCPAmount3.Text = "";
                                    txtRemarkCP.Text = "";
                                    calloutcome("PC");
                                }
                            }

                            status = true; ;
                        }
                        else
                            status = false;
                    }
                }
               
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
                status = false;
            }
            return status;
        }
        private void btnNextCallB_Click(object sender, EventArgs e)
        {
            saveCallBack("save");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try { 
            if (txtRemarkNoAnswer.Text == "")
            {
                MessageBox.Show("Please enter values for Remarks and try again.");
                return;
            }
            //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";

            Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
            Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
            req.Action = action_phone;
            req.TableName = TABLENAME;
            req.AccountNo = LOANNO;
            req.AccountNo1 = OTH_LOANNO1;
            req.AccountNo2 = OTH_LOANNO2;
            Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
            otherMetadata.INPUT_CONTACT_PLACE1 = cbContactNoAPlace.SelectedValue.ToString();
            //otherMetadata.IN_PERSON_CONTACT1 = cbContactPersonCP.SelectedValue.ToString();
            otherMetadata.INPUT_REMARKS1 = txtRemarkNoAnswer.Text;
            //otherMetadata.PTPAMOUNT = Decimal.Parse(txtPTPAmount1.Text);
            //otherMetadata.PTPDATE = cbBHoldDate1.SelectedValue.ToString();
            //otherMetadata.PTPAMOUNT2 = PTPAMOUNT2;// Decimal.Parse(txtPTPAmount2.Text);
            //otherMetadata.PTPDATE2 = PTPDATE2;// cbPTPHoldDate2.SelectedValue.ToString();
            //otherMetadata.PTPAMOUNT3 = PTPAMOUNT3;// Decimal.Parse(txtPTPAmount3.Text);
            //otherMetadata.PTPDATE3 = PTPDATE3;// cbPTPHoldDate3.SelectedValue.ToString();
            otherMetadata.ACTION2 = tipe_phone;
            otherMetadata.ACTION3 = tipe_phone;
             data.Other = otherMetadata;
            req.Data = data;
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
            if (response != null)
            {
                if (response.Success)
                {
                    MessageBox.Show("DONE");
                    calloutcome(tipe_phone);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            save_phone_leave("save");
        }
        private bool save_phone_leave(string action) {
            try { 
            if (txtRemarkleave.Text == "")
            {
                MessageBox.Show("Please enter values for Remarks and try again.");
                return false; 
            }
            //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";

            Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
            Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
            req.Action = action_phone;
            req.TableName = TABLENAME;
            req.AccountNo = LOANNO;
            req.AccountNo1 = OTH_LOANNO1;
            req.AccountNo2 = OTH_LOANNO2;
            Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
            otherMetadata.INPUT_CONTACT_PLACE1 = cbContactPLPlace.SelectedValue.ToString();
            otherMetadata.IN_PERSON_CONTACT1 = cbContactPersonPl.SelectedValue.ToString();
            otherMetadata.INPUT_REMARKS1 = txtRemarkleave.Text;
           
            otherMetadata.ACTION2 = cbPLaction1.SelectedValue.ToString();
            otherMetadata.ACTION3 = cbPLaction2.SelectedValue.ToString();
            data.Other = otherMetadata;
            req.Data = data;
            //var client = new JsonServiceClient(_baseApiUrl);
            var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
            {
                { "X-Api-Key", ApiKey() }
            });
            var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
            if (response != null)
            {
                if (response.Success)
                {
                    MessageBox.Show("DONE");
                    if (action == "save")
                    {
                        calloutcome(lblactioncode2.Text);
                        txtRemarkleave.Text = "";
                    }
                        
                    return true;
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            save_phone_remainder("save");
        }
        private bool save_phone_remainder(string action) {
            bool status = true;
            
            try{
                Decimal PTPAmount2 = 0;
            Decimal PTPAMOUNT2 = 0;
            bool isPTPAmount2 = Decimal.TryParse(txtPRAmount2.Text, out PTPAmount2);
            if (isPTPAmount2)
                PTPAMOUNT2 = Decimal.Parse(txtPRAmount2.Text.ToString());

            Decimal PTPAmount3 = 0;
            Decimal PTPAMOUNT3 = 0;
            bool isPTPAmount3 = Decimal.TryParse(txtPRAmount3.Text, out PTPAmount3);
            if (isPTPAmount3)
                PTPAMOUNT3 = Decimal.Parse(txtPRAmount3.Text.ToString());

            var PTPDATE2 = cbPRHoldDate1.SelectedValue.ToString();
            var PTPDATE3 = cbPRHoldDate2.SelectedValue.ToString();

            if (txtRemarkPR.Text == "")
            {
                MessageBox.Show("Please enter values for Remarks and try again.");
                status= false;
            }
            if (cbPRaction1.SelectedValue.ToString() == "PTP")
            {
                if (txtPRAmount2.Text == "")
                {
                    MessageBox.Show("PTP Amount Card #2 Must Be Filled");
                    status = false;
                }
                else
                {
                    if (!isPTPAmount2)
                    {
                        MessageBox.Show("PTP Amount should be a numeric!");
                        status = false;
                    }
                }
            }
            else
            {
                PTPDATE2 = "";
                PTPAMOUNT2 = 0;
            }
            if (cbPRaction2.SelectedValue.ToString() == "PTP")
            {
                if (txtPRAmount3.Text == "")
                {
                    MessageBox.Show("PTP Amount Card #3 Must Be Filled");
                    status = false;
                }
                else
                {

                    if (!isPTPAmount3)
                    {
                        MessageBox.Show("PTP Amount should be a numeric!");
                        status = false;
                    }
                }
            }
            else
            {
                PTPDATE3 = "";
                PTPAMOUNT3 = 0;
            }
            if (cbPRaction1.SelectedValue.ToString() == "PR")
            {
                PTPDATE2 = cbPRPRHoldDate1.SelectedValue.ToString();
            }

            if (cbPRaction2.SelectedValue.ToString() == "PR")
            {
                PTPDATE3 = cbPRPRHoldDate2.SelectedValue.ToString();
            }

            //string baseUrl = ConfigurationManager.AppSettings.Get("BaseApiUrl") ?? "http://localhost:5500";
            if (status)
            {
                Cafe.Mortgage.Api.ServiceModel.UpdateAccount req = new Cafe.Mortgage.Api.ServiceModel.UpdateAccount();
                Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata data = new Cafe.Mortgage.Api.ServiceModel.UpdateAccountMetadata();
                req.Action = "PHONEREMINDER";
                req.TableName = TABLENAME;
                req.AccountNo = LOANNO;
                req.AccountNo1 = OTH_LOANNO1;
                req.AccountNo2 = OTH_LOANNO2;
                req.IsPrev = screen;
                Cafe.Mortgage.Api.ServiceModel.OtherMetadata otherMetadata = new Cafe.Mortgage.Api.ServiceModel.OtherMetadata();
                otherMetadata.INPUT_CONTACT_PLACE1 = cbContactPRPlace.SelectedValue.ToString();
                otherMetadata.IN_PERSON_CONTACT1 = cbContactPersonPR.SelectedValue.ToString();
                otherMetadata.INPUT_REMARKS1 = txtRemarkPR.Text;
                //otherMetadata.PTPAMOUNT = Decimal.Parse(txtPTPAmount1.Text);
                otherMetadata.PTPDATE = cbPRPRHoldDate0.SelectedValue.ToString();
                otherMetadata.PTPAMOUNT2 = PTPAMOUNT2;// Decimal.Parse(txtPTPAmount2.Text);
                otherMetadata.PTPDATE2 = PTPDATE2;// cbPTPHoldDate2.SelectedValue.ToString();
                otherMetadata.PTPAMOUNT3 = PTPAMOUNT3;// Decimal.Parse(txtPTPAmount3.Text);
                otherMetadata.PTPDATE3 = PTPDATE3;// cbPTPHoldDate3.SelectedValue.ToString();
                otherMetadata.ACTION2 = cbPRaction1.SelectedValue.ToString();
                otherMetadata.ACTION3 = cbPRaction2.SelectedValue.ToString();

                data.Other = otherMetadata;
                req.Data = data;
                //var client = new JsonServiceClient(_baseApiUrl);
                var client = ServiceClient.CreateClient(_baseApiUrl, new Dictionary<string, string>
                {
                    { "X-Api-Key", ApiKey() }
                });
                var response = client.Put<Cafe.Mortgage.Api.ServiceModel.UpdateAccountResponse>(req);
                if (response != null)
                {
                    if (response.Success)
                    {
                       
                        if (action == "save")
                        {
                            if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                calloutcome("PR");
                                txtRemarkPR.Text = "";
                                txtPRAmount2.Text = "";
                                txtPRAmount3.Text = "";
                               
                            }
                        }
                            
                        status= true;
                    }
                    else
                        status = false; 
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return status;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (saveCP(""))
            {
                if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Detail2.Visible = false;
                    Detail3.Visible = true;
                    Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                    Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
                    CDisposition dispositions = getdeposito("PCCB");
                    cbDisposisi1.SelectedValue = dispositions.Id;
                    header2 = false;
                    lblPlus2.Text = "-";
                    header3 = true;
                    lblPlus3.Text = "+";
                }
            }
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                //txtPhone1.Enabled = true;
                txtPhone2.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                //txtPhone1.Enabled = false;
                txtPhone2.Enabled = true;
            }
        }
       
        private void txtDisposisiDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRowView item = (DataRowView)cbDisposisi1.SelectedItem;
                if (item != null)
                {
                    if (item[0].ToString() != "")
                    {
                        CDisposition dispositions = mpApp.CurrentService.DispositionPlan.Dispositions.GetByKey(int.Parse(item[0].ToString()));

                        if (mpApp.CurrentService.RequireDisposition)
                        {
                            if (dispositions != null)
                            {
                                if (dispositions.IsCallback)
                                {
                                    string phoneNumber = "";
                                    string cdate = "";
                                    int sameAgent = 0;
                                    int timeInMins = 0;
                                    int timeZone = 0;
                                    if (radioButton1.Checked)
                                        phoneNumber = txtPhone1.Text;
                                    if (radioButton2.Checked)
                                        phoneNumber = txtPhone2.Text;
                                    if (rbsameAgent.Checked)
                                        sameAgent = 1;

                                    try
                                    {
                                        timeInMins = int.Parse(cbSnooze.SelectedValue.ToString());
                                    }
                                    catch (Exception ex)
                                    {
                                        timeInMins = 0;
                                    }
                                    try
                                    {
                                        timeZone = int.Parse(TZComboBox.SelectedValue.ToString());
                                    }
                                    catch (Exception ex)
                                    {
                                        timeZone = 0;
                                    }
                                    DateTime result1;
                                    if (cbSnooze.SelectedIndex != 0)
                                    {
                                        DateTime dateTime = DateTime.Now;
                                        dateTime = dateTime.AddMinutes(timeInMins);
                                        cdate = dateTime.ToString("yyyy-MM-dd hh:dd:ss");
                                    }
                                    else
                                    {
                                        result1 = DateTime.ParseExact(callbackdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                        //result1 = DateTime.Parse(callbackdate.Text);
                                        //if (DateTime.TryParse(callbackdate.Text, (IFormatProvider)CultureInfo.CurrentCulture, DateTimeStyles.None, out result))
                                        cdate = result1.ToString("yyyy-MM-dd") + " " + callbackTime.Text;
                                    }

                                    UDCallback uDCallback = new UDCallback
                                    {
                                        aodServiceID = mpCall.ServiceID,
                                        callbackName = "",
                                        callID = mpCall.CallID,
                                        dateTime = cdate,
                                        dialMode = 0,
                                        memo = txtMemo.Text,
                                        phoneNumber = phoneNumber,
                                        returnToSameAgent = sameAgent,
                                        snoozeTimeInMins = timeInMins,
                                        timeZoneID = timeZone
                                    };
                                    if (mpApp.ScheduleCallback(uDCallback))
                                    {
                                    }
                                    mpCall.CallbackRequested = true;
                                }
                                else if (dispositions.IsExclusion)
                                {
                                    AddExclusion();
                                    mpCall.ExclusionRequested = true;
                                }
                            }
                            calloutcomeD(dispositions);
                            // MessageBox.Show("DONE");
                        }
                    }
                    //else
                    //{
                    //    ItemChangedMesage(" An error was encountered. No disposition is currently selected. Please select a disposition from the Disposition drop down box.", true);
                    //}
                }
            }
        }
        private void button26_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cbDisposisi1.SelectedItem;
            if (item != null)
            {
                if (item[0].ToString() != "")
                {
                    CDisposition dispositions = mpApp.CurrentService.DispositionPlan.Dispositions.GetByKey(int.Parse(item[0].ToString()));

                    if (mpApp.CurrentService.RequireDisposition)
                    {
                        if (dispositions != null)
                        {
                            if (dispositions.IsCallback)
                            {
                                string phoneNumber = "";
                                string cdate = "";
                                int sameAgent = 0;
                                int timeInMins = 0;
                                int timeZone = 0;
                                if (radioButton1.Checked)
                                    phoneNumber = txtPhone1.Text;
                                if (radioButton2.Checked)
                                    phoneNumber = txtPhone2.Text;
                                if (rbsameAgent.Checked)
                                    sameAgent = 1;

                                try
                                {
                                    timeInMins = int.Parse(cbSnooze.SelectedValue.ToString());
                                }
                                catch (Exception ex)
                                {
                                    timeInMins = 0;
                                }
                                try
                                {
                                    timeZone = int.Parse(TZComboBox.SelectedValue.ToString());
                                }
                                catch (Exception ex)
                                {
                                    timeZone = 0;
                                }
                                DateTime result1;
                                if (cbSnooze.SelectedIndex != 0)
                                {
                                    DateTime dateTime = DateTime.Now;
                                    dateTime = dateTime.AddMinutes(timeInMins);
                                    cdate = dateTime.ToString("yyyy-MM-dd hh:dd:ss");
                                }
                                else
                                {
                                    result1 = DateTime.ParseExact(callbackdate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                    //result1 = DateTime.Parse(callbackdate.Text);
                                    //if (DateTime.TryParse(callbackdate.Text, (IFormatProvider)CultureInfo.CurrentCulture, DateTimeStyles.None, out result))
                                    cdate = result1.ToString("yyyy-MM-dd") + " " + callbackTime.Text;
                                }
                               
                                UDCallback uDCallback = new UDCallback
                                {
                                    aodServiceID = mpCall.ServiceID,
                                    callbackName = "",
                                    callID = mpCall.CallID,
                                    dateTime = cdate,
                                    dialMode = 0,
                                    memo = txtMemo.Text,
                                    phoneNumber = phoneNumber,
                                    returnToSameAgent = sameAgent,
                                    snoozeTimeInMins = timeInMins,
                                    timeZoneID = timeZone
                                };
                                if (mpApp.ScheduleCallback(uDCallback))
                                {
                                }
                                mpCall.CallbackRequested = true;
                            }
                            else if (dispositions.IsExclusion)
                            {
                                AddExclusion();
                                mpCall.ExclusionRequested = true;
                            }
                        }
                        calloutcomeD(dispositions);
                       // MessageBox.Show("DONE");
                    }
                }
                //else
                //{
                //    ItemChangedMesage(" An error was encountered. No disposition is currently selected. Please select a disposition from the Disposition drop down box.", true);
                //}
            }
        }
        private void cbSnooze_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSnooze.SelectedIndex != 0)
            {
                callbackdate.Enabled = false;
                callbackTime.Enabled = false;
                TZComboBox.Enabled = false;
            }
            else {
                callbackdate.Enabled = true;
                callbackTime.Enabled = true;
                TZComboBox.Enabled = true;
            }
        }

        private void btnSendback_Click(object sender, EventArgs e)
        {
            if(save_phone_leave(""))
            {/////TODO/////
             //Pcalldata.IsExpanded = false;
             //pscheduler.IsExpanded = true;
                Detail2.Visible = false;
                Detail3.Visible = true;
                Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
                CDisposition dispositions = getdeposito("POCB");
                cbDisposisi1.SelectedValue = dispositions.Id;
            }
        }

        private void btnCallBack_Click(object sender, EventArgs e)
        {
            if (saveCallBack(""))
            {
                if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Detail2.Visible = false;
                    Detail3.Visible = true;
                    Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                    Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
                    CDisposition dispositions = getdeposito("PCCB");
                    cbDisposisi1.SelectedValue = dispositions.Id;
                    header2 = false;
                    lblPlus2.Text = "-";
                    header3 = true;
                    lblPlus3.Text = "+";
                }
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            if (save_phone_remainder("")) {
                if (MessageBox.Show("Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Detail2.Visible = false;
                    Detail3.Visible = true;
                    Header33.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + 5);
                    Detail3.Location = new Point(Header11.Location.X, Header22.Location.Y + Header22.Height + Header33.Height);
                    CDisposition dispositions = getdeposito("PRCB");
                    cbDisposisi1.SelectedValue = dispositions.Id;
                    header2 = false;
                    lblPlus2.Text = "-";
                    header3 = true;
                    lblPlus3.Text = "+";
                }
            }
        }
        private void AddExclusion()
        {
            try
            {
                int timeZone = 0;
               
                try
                {
                    timeZone = int.Parse(TZComboBox.SelectedValue.ToString());
                }
                catch (Exception ex)
                {
                    timeZone = 0;
                }
                string id = cbApplication.GetItemText(this.cbApplication.SelectedItem);
                //if (cbApplication.SelectedItem is ComboBox. cbi)
                //{
                //    string itemContent = cbi.Content.ToString();
                //    // You might also have a 'Tag' property for an ID
                //    object itemId = cbi.Tag;
                //}
                UDAgent udAgent = new UDAgent();
                UDExclude udExclude = new UDExclude();
                UDAgent agentArg = new UDAgent();
                agentArg = mpApp.CurrentAgent.AgentArg;
                agentArg.agentIndex = this.mpApp.CurrentAgent.AgentIndex;
                agentArg.agentLoginName = this.mpApp.CurrentAgent.LoginName;
                agentArg.clientRole = this.mpApp.CurrentAgent.ClientRole;
                agentArg.LDAPUserId = this.mpApp.CurrentAgent.LDAPUserId;
                agentArg.serverType = this.mpApp.CurrentAgent.ServerType;
                agentArg.initState = 5;
                udExclude.agentIndex = this.mpApp.CurrentAgent.AgentIndex;
                udExclude.IAppId = ((ServiceApplication)this.cbApplication.SelectedItem).Id;
                udExclude.timeZoneID = timeZone;
                udExclude.IType = (int)Convert.ToInt16(this.cbExclusionType.SelectedValue);
                udExclude.value = this.txtphoneEx.Text;
                udExclude.startDate = this.startdate.Value.ToString("yyyy-MM-dd 00:00:00");
                udExclude.endDate = this.enddate.Value.ToString("yyyy-MM-dd 23:59:59");
                udExclude.timeZoneID = 25;
                this.mpApp.ExcludeContact(agentArg, udExclude);
            }
            catch (Exception ex)
            {
                //Disposition.logFile.LogMessageToFile(" |ERROR| FExclusion.AddExclusion() - Add to Exclusion List Failed. " + ex.StackTrace.ToString());
            }
        }

        private void advancedFlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnDial_Click(object sender, System.EventArgs e)
        {
            int iServiceId = 0;
            int iExternalRouteId = 0;
            if (txtdial.Text == "")
            {
                FDial pFormDial = new FDial(mpApp, DialMode.dm1stParty);
                pFormDial.Text = "Specify the entity to dial";
                pFormDial.ShowDialog();

                if (pFormDial.DialogResult != DialogResult.OK)
                    return;

                //If dialing an external...
                if (pFormDial.SelectedItem is CExternalRoute || pFormDial.PhoneNumber.Trim() != "")
                {
                   

                    if (pFormDial.SelectedItem != null)
                        iExternalRouteId = ((CExternalRoute)pFormDial.SelectedItem).Id;

                    if (mpApp.CurrentCall == null)
                    {
                        //If a service is required and have one to choose from, prompt for one
                        if ((mpApp.CurrentAgent.ShowServiceListForManualDial || mpApp.CurrentAgent.RequireServiceForManualDial) && mpApp.AssignedServices.Count > 1)
                        {
                            ArrayList oExcludeItems = null;

                            //If a service is required then exclude the default service from the selection list
                            if (mpApp.CurrentAgent.RequireServiceForManualDial)
                            {
                                oExcludeItems = new ArrayList();
                                oExcludeItems.Add(mpApp.AssignedServices.GetByKey(0));
                            }

                            FList pFormServices = new FList(mpApp, mpApp.AssignedServices, oExcludeItems);
                            pFormServices.Text = "Select a service";
                            pFormServices.ShowDialog();

                            if (pFormServices.DialogResult != DialogResult.OK)
                                return;

                            iServiceId = ((CService)pFormServices.SelectedItem).ServiceId;
                        }
                    }
                    else
                    {
                        iServiceId = mpApp.CurrentCall.ServiceID;
                    }

                    try
                    {
                        mpApp.Dial(pFormDial.PhoneNumber, iServiceId, iExternalRouteId);
                        ItemChangedphone(pFormDial.PhoneNumber);
                    }
                    catch (Exception pError)
                    {
                        MessageBox.Show(pError.Message);
                    }
                }
                //Otherwise(dialing a user)...
                else if (pFormDial.SelectedItem is CUser)
                {
                    try
                    {
                        mpApp.Dial(((CUser)pFormDial.SelectedItem).Id);
                        ItemChangedphone(((CUser)pFormDial.SelectedItem).Id);
                    }
                    catch (Exception pError)
                    {
                        MessageBox.Show(pError.Message);
                    }
                }
                if (pFormDial.PhoneNumber.Trim() != "")
                    txtdial.Text = pFormDial.PhoneNumber.Trim();
            }
            else
            {
                try
                {
                    mpApp.Dial(txtdial.Text, mpApp.CurrentCall.ServiceID, iExternalRouteId);
                    ItemChangedphone(txtdial.Text);
                }
                catch (Exception pError)
                {
                    MessageBox.Show(pError.Message);
                }
            }
            //ItemChangedphone(txtdial.Text);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void grpschedule_Enter(object sender, EventArgs e)
        {

        }

        private void pcall_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            callOther(C_MOBILE_P);
        }
        private int callOther(string notelp) {
            int iExternalRouteId = 0;
            if (notelp.Trim().Length == 0)
                return mpCall.CurrentState.Id != AgentStateId.asWRAP && mpCall.CurrentState.Id != AgentStateId.asPREVIEW ? -3 : -1;
            if (mpCall.CurrentState.Id != AgentStateId.asWRAP && mpCall.CurrentState.Id != AgentStateId.asPREVIEW)
                return -2;
            try
            {
                mpApp.Dial(notelp.Trim(), mpApp.CurrentCall.ServiceID, iExternalRouteId);
                ItemChangedphone(notelp.Trim());
                return 0;
            }
            catch (Exception ex)
            {
                //LyriScriptLegacyService.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
                return -4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            callOther(C_CONTACT2_P);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            callOther(C_CONTACT1_E);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            callOther(MOBILE_O);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_remainder.Visible = false;
            mainTabControl.SelectedTab = dialerTabPage;
              button5.Focus();
        }

        private void btnAcceptCall_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.AcceptCall();
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        private void btnRejectCall_Click(object sender, EventArgs e)
        {
            try
            {
                if (mpCall.RejectionReasonRequired)
                {
                    //Prompt user to specify reason
                    if (CallRejectionForm != null)
                        CallRejectionForm.Close();

                    CallRejectionForm = new FList(mpApp, mpApp.CallRejectionReasons);
                    CallRejectionForm.Text = "Choose a Call-Rejection Reason";

                    if (CallRejectionForm.ShowDialog() == DialogResult.OK)
                        mpApp.RejectCall((CCallRejectionReason)CallRejectionForm.SelectedItem);
                }
                else
                    mpApp.RejectCall();
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }
        public string WrapActionDataVal
        {
            get => this._wrapActionDataVal;
            set
            {
                this._wrapActionDataVal = value;
            }
        }

        public string WrapTimeDataVal
        {
            get => this._wrapTimeDataVal;
            set
            {
                this._wrapTimeDataVal = value;
            }
        }

        public string PreviewTimeDataVal
        {
            get => this._previewTimeDataVal;
            set
            {
                this._previewTimeDataVal = value;
            }
        }
        public class MyItem
        {
            private int _id;
            private string _item;

            public MyItem(int id, string item)
            {
                this._id = id;
                this._item = item;
            }

            public int ID
            {
                get => this._id;
                set => this._id = value;
            }

            public string Item
            {
                get => this._item;
                set => this._item = value;
            }

            public override string ToString() => this._item;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            callOther(C_MOBILE_P);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            callOther(C_CONTACT2_P);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            callOther(C_CONTACT1_E);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            callOther(MOBILE_O);
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }
        string forbidden = @"~'""""*<>^;:";

        private void txtRemark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRemarkB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRemarkCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRemarkNoAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRemarkPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAddress3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtContact2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (forbidden.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbDisposisi1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                panel6.Height = 46;
                DataRowView item = (DataRowView)cbDisposisi1.SelectedItem;
                if (item != null)
                {
                    if (item[0].ToString() != "")
                    {
                        
                        CDisposition dispositions = mpApp.CurrentService.DispositionPlan.Dispositions.GetByKey(int.Parse(item[0].ToString()));
                        if (dispositions.IsCallback)
                        {/////TODO/////
                            //pscheduler.Location = Location = new Point(pscheduler.Location.X, 500);
                            //this.AutoScrollPosition = new Point(0, txtMemo.Location.Y);
                            grpschedule.Visible = true;
                            grpExclusion.Visible = false;
                            panel6.Height = 500;
                            DateTime dateTime = DateTime.Now;
                            callbackdate.Value = dateTime;
                            radioButton1.Checked = true;
                            radioButton4.Checked = true;
                            callbackTime.Value = dateTime;
                            txtPhone1.Text = mpCall.PhoneNumber;
                            label223.Location = Location = new Point(grpschedule.Location.X, 242);
                            txtMemo.Location = Location = new Point(grpschedule.Location.X, 262);
                            this.Location=new Point(LocationX,LocationY);
                            txtMemo.Focus();
                            txtPhone1.Enabled=false;
                        }
                        else if (dispositions.IsExclusion)
                        {/////TODO/////
                            //pscheduler.Location = Location = new Point(pscheduler.Location.X, 500);
                            grpExclusion.Location = Location = new Point(grpschedule.Location.X, grpschedule.Location.Y);
                            grpExclusion.Visible = true;
                            grpschedule.Visible = false;
                            cbExclusionTimezone.SelectedValue = 7;
                            cbApplication.SelectedIndex = 0;
                            cbExclusionType.SelectedIndex = 0;
                            panel6.Height = 432;
                            label223.Location = Location = new Point(grpschedule.Location.X, 155);
                            txtMemo.Location = Location = new Point(grpschedule.Location.X, 180);
                            this.Location = new Point(LocationX, LocationY);
                            this.AutoScrollPosition = new Point(0, this.Height - 10);
                        }
                        else
                        {
                            grpschedule.Visible = false;
                            grpExclusion.Visible = false;
                        }
                        txtDisposisiDesc.Text = item[3].ToString();
                        btnDisposisi.Enabled = true;
                    }
                    else
                    {
                        btnDisposisi.Enabled = false;
                    }
                }
                else
                {
                    txtDisposisiDesc.Text = "";
                }
               
            }
            catch (Exception ex)
            {
            }
            Detail3.Height= panel6.Height +5;
           
        }

        private void txtDisposisiDesc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDisposisiDesc.Text != "")
                {
                    CDisposition dispositions = getdeposito(txtDisposisiDesc.Text);
                    if (dispositions != null)
                    {
                        cbDisposisi1.SelectedValue = dispositions.Id;
                    }
                }
               
            }
            catch { }
            
        }

  




        //private void cbDisposisi_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        CDisposition dispositions = mpApp.CurrentService.DispositionPlan.Dispositions.GetByKey(cbDisposisi.SelectedValue);

        //        if (txtDisposisiDesc.Text == "")
        //        {
        //            btnDisposisi.Enabled = false;
        //        }
        //        else
        //        {
        //            btnDisposisi.Enabled = true;
        //        }
        //        if (dispositions.IsCallback)
        //        {
        //            pscheduler.Location = Location = new Point(pscheduler.Location.X, 500);
        //            grpschedule.Visible = true;
        //            grpExclusion.Visible = false;
        //            panel6.Height = 432;
        //            DateTime dateTime = DateTime.Now;
        //            callbackdate.Value = dateTime;
        //            radioButton1.Checked = true;
        //            radioButton4.Checked = true;
        //            callbackTime.Value = dateTime;
        //            txtPhone1.Text = mpCall.PhoneNumber;
        //            label223.Location = Location = new Point(grpschedule.Location.X, 242);
        //            txtMemo.Location = Location = new Point(grpschedule.Location.X, 262);
        //        }
        //        else if (dispositions.IsExclusion)
        //        {
        //            pscheduler.Location = Location = new Point(pscheduler.Location.X, 500);
        //            grpExclusion.Location = Location = new Point(grpschedule.Location.X, grpschedule.Location.Y);
        //            grpExclusion.Visible = true;
        //            grpschedule.Visible = false;
        //            cbExclusionTimezone.SelectedValue = 7;
        //            cbApplication.SelectedIndex = 0;
        //            cbExclusionType.SelectedIndex = 0;
        //            panel6.Height = 432;
        //            label223.Location = Location = new Point(grpschedule.Location.X, 155);
        //            txtMemo.Location = Location = new Point(grpschedule.Location.X, 180);
        //        }
        //        else
        //        {
        //            btnDisposisi.Enabled = false;
        //            grpschedule.Visible = false;
        //            grpExclusion.Visible = false;
        //            panel6.Height = 100;
        //        }
        //        txtDisposisiDesc.Text = dispositions.Code;
        //    }
        //    catch (Exception ex)
        //    {

        //        //grpschedule.Visible = false;
        //        //grpExclusion.Visible = false;
        //        panel6.Height = 100;
        //        //label223.Location = Location = new Point(grpschedule.Location.X, 206);
        //        //txtMemo.Location = Location = new Point(grpschedule.Location.X, 227);
        //    }
        //}
    }

}
