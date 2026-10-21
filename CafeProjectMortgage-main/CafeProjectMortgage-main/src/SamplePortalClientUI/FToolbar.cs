using com.aspect.unifiedip.tools;
using SamplePortalClient;
using SamplePortalClient.EPAgentWS;
using SamplePortalClient.EPAgentWSP;
using SamplePortalClient.EPEventsWS;
using SamplePortalClientUI;
using SamplePortalClientUI.Properties;
using ServiceStack;
using ServiceStack.Script;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web.Routing;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Windows.Threading;
using Tulpep.NotificationWindow;
using Utilities;
using static SamplePortalClient.CApp;
using static SamplePortalClient.CServices;
using static SamplePortalClient.UI.FLogin;
using static ServiceStack.Script.Lisp;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SamplePortalClient.UI
{
	/// <summary>
	/// Summary description for FToolbar.
	/// </summary>
	public class FToolbar : System.Windows.Forms.Form
    {
		private System.Windows.Forms.Button btnNextCall;
		private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnAvailable;
        private SamplePortalClient.CApp mpApp;
		private System.Threading.Timer mpMessageTimer;
        private System.Windows.Forms.Button btnUnavailable;
        private System.Windows.Forms.Label lblPhoneStatus;
        private System.Windows.Forms.Panel pnlState;
        private ToolTip lblPhoneStatusToolTip;
        private System.ComponentModel.IContainer components;
        private System.Threading.Timer mpUnloadTimer;
        private System.Threading.Timer mpPendingErrorTimer;
        private System.Windows.Forms.Label label1;
        private Hashtable moCallWindows;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuAction;
        private ToolStripMenuItem mnIdle;
        private ToolStripMenuItem mReady2;
        private ToolStripMenuItem mnReady;
        private ToolStripMenuItem mLogout;
        private ToolStripMenuItem mCancel;
        private System.Windows.Forms.Label textBlockNotReadyParkTimer;
        private DispatcherTimer IdleTimer1;
        private DispatcherTimer notReadyParkTimer = (DispatcherTimer)null;
        private DateTime notReadyParkElapsedTime = DateTime.UtcNow;
        private ToolStripMenuItem mCancelLogout;
        public bool keepParkTimerRunning = false;
        private System.Threading.Timer PreviewTimeDialer;
        public bool isPendingLogout = false;
        private int miAgentStateTickCount;
        private bool bIsPreviewDial = false;
        private DateTime stateInitialTime;
        private GradientPanel.GradientPanel grpLine3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblANIS;
        private System.Windows.Forms.Label lblDNIS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label textBoxStateTime;
        private System.Windows.Forms.Label textBoxCallTime;
        private System.Windows.Forms.Label lblstatusLine1;
        private System.Windows.Forms.Label label2;
        private GradientPanel.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private GradientPanel.GradientPanel grpLine1Awal;
        private System.Windows.Forms.Label label26;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel grpPhone;
        private System.Windows.Forms.Button btnHangup;
        private System.Windows.Forms.TextBox txtdial;
        private System.Windows.Forms.Button btnDial;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btn3Way;
        private System.Windows.Forms.Panel pnlTollbar;
        private System.Windows.Forms.Panel pnlLogin;
        private Spinner spinner1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlstation;
        private ComboBox cbDomain;
        private System.Windows.Forms.TextBox txtPortalData;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPortal;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogin;
        private CCall mpCall;
        private System.Windows.Forms.Button button4;
        private CCall mpCallPrev;
        private System.Windows.Forms.Label lblMessage;
        private PictureBox picInfo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnDialNum;

        //private FCallData mCallDataForm;
        bool UserClosing = false;
        public FToolbar()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.SizeChanged += MySizeChanged;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            this.txtPortal.Leave += new System.EventHandler(this.txtPortal_Leave);
            UserClosing = false;
            //mpApp = pApp;
            //mCancel.Visible = false;    
            //moCallWindows = new Hashtable();
        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FToolbar));
            this.btnNextCall = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnUnavailable = new System.Windows.Forms.Button();
            this.lblPhoneStatus = new System.Windows.Forms.Label();
            this.pnlState = new System.Windows.Forms.Panel();
            this.lblPhoneStatusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnHangup = new System.Windows.Forms.Button();
            this.btnDialNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTollbar = new System.Windows.Forms.Panel();
            this.grpPhone = new System.Windows.Forms.Panel();
            this.txtdial = new System.Windows.Forms.TextBox();
            this.btnDial = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btn3Way = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBlockNotReadyParkTimer = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnIdle = new System.Windows.Forms.ToolStripMenuItem();
            this.mReady2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReady = new System.Windows.Forms.ToolStripMenuItem();
            this.mLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mCancelLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel1 = new GradientPanel.GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grpLine3 = new GradientPanel.GradientPanel();
            this.grpLine1Awal = new GradientPanel.GradientPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblANIS = new System.Windows.Forms.Label();
            this.lblDNIS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStateTime = new System.Windows.Forms.Label();
            this.textBoxCallTime = new System.Windows.Forms.Label();
            this.lblstatusLine1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.spinner1 = new Spinner();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlstation = new System.Windows.Forms.Panel();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.txtPortalData = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.pnlState.SuspendLayout();
            this.pnlTollbar.SuspendLayout();
            this.grpPhone.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.grpLine3.SuspendLayout();
            this.grpLine1Awal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlstation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextCall
            // 
            this.btnNextCall.Location = new System.Drawing.Point(96, 185);
            this.btnNextCall.Name = "btnNextCall";
            this.btnNextCall.Size = new System.Drawing.Size(74, 32);
            this.btnNextCall.TabIndex = 7;
            this.btnNextCall.Text = "Next Call";
            this.btnNextCall.Visible = false;
            this.btnNextCall.Click += new System.EventHandler(this.btnNextCall_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(96, 186);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 32);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReady
            // 
            this.btnReady.AccessibleName = "";
            this.btnReady.Location = new System.Drawing.Point(96, 179);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(104, 32);
            this.btnReady.TabIndex = 11;
            this.btnReady.Text = "Ready";
            this.btnReady.Visible = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(96, 182);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(92, 33);
            this.btnAvailable.TabIndex = 14;
            this.btnAvailable.Text = "Available";
            this.btnAvailable.Visible = false;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnUnavailable
            // 
            this.btnUnavailable.Location = new System.Drawing.Point(96, 182);
            this.btnUnavailable.Name = "btnUnavailable";
            this.btnUnavailable.Size = new System.Drawing.Size(92, 33);
            this.btnUnavailable.TabIndex = 15;
            this.btnUnavailable.Text = "Unavailable";
            this.btnUnavailable.Visible = false;
            this.btnUnavailable.Click += new System.EventHandler(this.btnUnavailable_Click);
            // 
            // lblPhoneStatus
            // 
            this.lblPhoneStatus.BackColor = System.Drawing.Color.Red;
            this.lblPhoneStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhoneStatus.Location = new System.Drawing.Point(2, 1);
            this.lblPhoneStatus.Name = "lblPhoneStatus";
            this.lblPhoneStatus.Size = new System.Drawing.Size(12, 20);
            this.lblPhoneStatus.TabIndex = 16;
            // 
            // pnlState
            // 
            this.pnlState.BackColor = System.Drawing.Color.Transparent;
            this.pnlState.Controls.Add(this.lblPhoneStatus);
            this.pnlState.Location = new System.Drawing.Point(332, 313);
            this.pnlState.Name = "pnlState";
            this.pnlState.Size = new System.Drawing.Size(180, 20);
            this.pnlState.TabIndex = 17;
            this.pnlState.Visible = false;
            // 
            // btnHangup
            // 
            this.btnHangup.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.release_btn_notext_small_reversed;
            this.btnHangup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHangup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangup.Location = new System.Drawing.Point(227, 66);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(36, 34);
            this.btnHangup.TabIndex = 20;
            this.lblPhoneStatusToolTip.SetToolTip(this.btnHangup, "Release");
            this.btnHangup.Click += new System.EventHandler(this.btnHangup_Click);
            // 
            // btnDialNum
            // 
            this.btnDialNum.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.numpad;
            this.btnDialNum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDialNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDialNum.Location = new System.Drawing.Point(269, 66);
            this.btnDialNum.Name = "btnDialNum";
            this.btnDialNum.Size = new System.Drawing.Size(36, 34);
            this.btnDialNum.TabIndex = 26;
            this.lblPhoneStatusToolTip.SetToolTip(this.btnDialNum, "Numpad");
            this.btnDialNum.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // pnlTollbar
            // 
            this.pnlTollbar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTollbar.Controls.Add(this.grpPhone);
            this.pnlTollbar.Controls.Add(this.panel1);
            this.pnlTollbar.Controls.Add(this.gradientPanel1);
            this.pnlTollbar.Controls.Add(this.grpLine3);
            this.pnlTollbar.Controls.Add(this.label1);
            this.pnlTollbar.Controls.Add(this.btnUnavailable);
            this.pnlTollbar.Controls.Add(this.btnAvailable);
            this.pnlTollbar.Controls.Add(this.btnReady);
            this.pnlTollbar.Controls.Add(this.btnLogout);
            this.pnlTollbar.Controls.Add(this.btnNextCall);
            this.pnlTollbar.Controls.Add(this.pictureBox3);
            this.pnlTollbar.Location = new System.Drawing.Point(2, 1);
            this.pnlTollbar.Name = "pnlTollbar";
            this.pnlTollbar.Size = new System.Drawing.Size(1538, 126);
            this.pnlTollbar.TabIndex = 48;
            // 
            // grpPhone
            // 
            this.grpPhone.BackColor = System.Drawing.Color.Transparent;
            this.grpPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpPhone.BackgroundImage")));
            this.grpPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpPhone.Controls.Add(this.btnDialNum);
            this.grpPhone.Controls.Add(this.btnHangup);
            this.grpPhone.Controls.Add(this.txtdial);
            this.grpPhone.Controls.Add(this.btnDial);
            this.grpPhone.Controls.Add(this.btnHold);
            this.grpPhone.Controls.Add(this.btnRecord);
            this.grpPhone.Controls.Add(this.btn3Way);
            this.grpPhone.Location = new System.Drawing.Point(1094, 1);
            this.grpPhone.Name = "grpPhone";
            this.grpPhone.Size = new System.Drawing.Size(386, 126);
            this.grpPhone.TabIndex = 47;
            // 
            // txtdial
            // 
            this.txtdial.Location = new System.Drawing.Point(48, 37);
            this.txtdial.Name = "txtdial";
            this.txtdial.Size = new System.Drawing.Size(258, 22);
            this.txtdial.TabIndex = 25;
            // 
            // btnDial
            // 
            this.btnDial.BackColor = System.Drawing.Color.Transparent;
            this.btnDial.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.dial_btn_notext_small_reversed;
            this.btnDial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDial.Location = new System.Drawing.Point(314, 33);
            this.btnDial.Name = "btnDial";
            this.btnDial.Size = new System.Drawing.Size(36, 35);
            this.btnDial.TabIndex = 21;
            this.btnDial.UseVisualStyleBackColor = false;
            this.btnDial.Click += new System.EventHandler(this.btnDial_Click);
            // 
            // btnHold
            // 
            this.btnHold.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.im_btn;
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Location = new System.Drawing.Point(98, 66);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(36, 34);
            this.btnHold.TabIndex = 22;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.record_btn_notext_small_reversed;
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(184, 66);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(36, 34);
            this.btnRecord.TabIndex = 24;
            this.btnRecord.UseVisualStyleBackColor = false;
            // 
            // btn3Way
            // 
            this.btn3Way.BackColor = System.Drawing.Color.Transparent;
            this.btn3Way.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.transfer_btn_notext_small_reversed;
            this.btn3Way.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3Way.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Way.Location = new System.Drawing.Point(140, 66);
            this.btn3Way.Name = "btn3Way";
            this.btn3Way.Size = new System.Drawing.Size(36, 34);
            this.btn3Way.TabIndex = 23;
            this.btn3Way.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn3Way.UseVisualStyleBackColor = false;
            this.btn3Way.Click += new System.EventHandler(this.btn3Way_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.header_left;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBlockNotReadyParkTimer);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 126);
            this.panel1.TabIndex = 46;
            // 
            // textBlockNotReadyParkTimer
            // 
            this.textBlockNotReadyParkTimer.BackColor = System.Drawing.Color.Transparent;
            this.textBlockNotReadyParkTimer.Location = new System.Drawing.Point(8, 100);
            this.textBlockNotReadyParkTimer.Name = "textBlockNotReadyParkTimer";
            this.textBlockNotReadyParkTimer.Size = new System.Drawing.Size(134, 23);
            this.textBlockNotReadyParkTimer.TabIndex = 26;
            this.textBlockNotReadyParkTimer.Text = "00:00:00";
            this.textBlockNotReadyParkTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.agent_stat;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(172, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 33);
            this.button4.TabIndex = 50;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(8, 3);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(134, 24);
            this.lblState.TabIndex = 45;
            this.lblState.Text = "Logging In";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.menu;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAction});
            this.menuStrip1.Location = new System.Drawing.Point(18, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(120, 99);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAction
            // 
            this.MenuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnIdle,
            this.mReady2,
            this.mnReady,
            this.mLogout,
            this.mCancel,
            this.mCancelLogout});
            this.MenuAction.Image = global::SamplePortalClientUI.Properties.Resources.bluephonedown;
            this.MenuAction.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAction.Margin = new System.Windows.Forms.Padding(10, 15, 0, 0);
            this.MenuAction.Name = "MenuAction";
            this.MenuAction.Size = new System.Drawing.Size(76, 84);
            // 
            // mnIdle
            // 
            this.mnIdle.Name = "mnIdle";
            this.mnIdle.Size = new System.Drawing.Size(210, 26);
            this.mnIdle.Text = "Idle";
            this.mnIdle.Click += new System.EventHandler(this.mnIdle_Click);
            // 
            // mReady2
            // 
            this.mReady2.Name = "mReady2";
            this.mReady2.Size = new System.Drawing.Size(210, 26);
            this.mReady2.Text = "Idle";
            this.mReady2.Click += new System.EventHandler(this.mReady2_Click);
            // 
            // mnReady
            // 
            this.mnReady.Enabled = false;
            this.mnReady.Name = "mnReady";
            this.mnReady.Size = new System.Drawing.Size(210, 26);
            this.mnReady.Text = "Not Ready";
            // 
            // mLogout
            // 
            this.mLogout.Name = "mLogout";
            this.mLogout.Size = new System.Drawing.Size(210, 26);
            this.mLogout.Text = "Logout";
            // 
            // mCancel
            // 
            this.mCancel.Name = "mCancel";
            this.mCancel.Size = new System.Drawing.Size(210, 26);
            this.mCancel.Text = "Cancel Not Ready";
            this.mCancel.Click += new System.EventHandler(this.mCancel_Click);
            // 
            // mCancelLogout
            // 
            this.mCancelLogout.Name = "mCancelLogout";
            this.mCancelLogout.Size = new System.Drawing.Size(210, 26);
            this.mCancelLogout.Text = "Cancel Logout";
            this.mCancelLogout.Click += new System.EventHandler(this.mCancelLogout_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gradientPanel1.BackgroundImage")));
            this.gradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gradientPanel1.BorderColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.gradientPanel1.BorderRadius = 15;
            this.gradientPanel1.BorderSize = 5;
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label12);
            this.gradientPanel1.Controls.Add(this.label13);
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Controls.Add(this.label15);
            this.gradientPanel1.Controls.Add(this.label16);
            this.gradientPanel1.Location = new System.Drawing.Point(708, 7);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(368, 112);
            this.gradientPanel1.TabIndex = 31;
            this.gradientPanel1.UnderlinedStyle = false;
            this.gradientPanel1.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(178, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(178, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 14);
            this.label4.TabIndex = 41;
            this.label4.Text = ":";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 32);
            this.label9.TabIndex = 38;
            this.label9.Text = "ANI\\Number\r\nName";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "DNIS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(194, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 14);
            this.label13.TabIndex = 36;
            this.label13.Text = "00:00:00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(108, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 14);
            this.label14.TabIndex = 35;
            this.label14.Text = "00:00:00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(194, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "-";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(108, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 21);
            this.label16.TabIndex = 33;
            this.label16.Text = "Line 1";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpLine3
            // 
            this.grpLine3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grpLine3.BackgroundImage")));
            this.grpLine3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpLine3.BorderColor = System.Drawing.Color.White;
            this.grpLine3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.grpLine3.BorderRadius = 15;
            this.grpLine3.BorderSize = 5;
            this.grpLine3.Controls.Add(this.grpLine1Awal);
            this.grpLine3.Controls.Add(this.label11);
            this.grpLine3.Controls.Add(this.label10);
            this.grpLine3.Controls.Add(this.lblANIS);
            this.grpLine3.Controls.Add(this.lblDNIS);
            this.grpLine3.Controls.Add(this.label7);
            this.grpLine3.Controls.Add(this.label6);
            this.grpLine3.Controls.Add(this.textBoxStateTime);
            this.grpLine3.Controls.Add(this.textBoxCallTime);
            this.grpLine3.Controls.Add(this.lblstatusLine1);
            this.grpLine3.Controls.Add(this.label2);
            this.grpLine3.Location = new System.Drawing.Point(328, 7);
            this.grpLine3.Name = "grpLine3";
            this.grpLine3.Size = new System.Drawing.Size(366, 112);
            this.grpLine3.TabIndex = 30;
            this.grpLine3.UnderlinedStyle = false;
            this.grpLine3.Visible = false;
            // 
            // grpLine1Awal
            // 
            this.grpLine1Awal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grpLine1Awal.BorderColor = System.Drawing.Color.Silver;
            this.grpLine1Awal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.grpLine1Awal.BorderRadius = 10;
            this.grpLine1Awal.BorderSize = 2;
            this.grpLine1Awal.Controls.Add(this.label26);
            this.grpLine1Awal.Controls.Add(this.pictureBox1);
            this.grpLine1Awal.Location = new System.Drawing.Point(4, 65);
            this.grpLine1Awal.Name = "grpLine1Awal";
            this.grpLine1Awal.Size = new System.Drawing.Size(112, 43);
            this.grpLine1Awal.TabIndex = 32;
            this.grpLine1Awal.UnderlinedStyle = false;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(44, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 21);
            this.label26.TabIndex = 33;
            this.label26.Text = "Line 1";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SamplePortalClientUI.Properties.Resources.voice;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(178, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 21);
            this.label11.TabIndex = 42;
            this.label11.Text = ":";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(178, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 14);
            this.label10.TabIndex = 41;
            this.label10.Text = ":";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblANIS
            // 
            this.lblANIS.BackColor = System.Drawing.Color.Transparent;
            this.lblANIS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblANIS.Location = new System.Drawing.Point(110, 66);
            this.lblANIS.Name = "lblANIS";
            this.lblANIS.Size = new System.Drawing.Size(240, 29);
            this.lblANIS.TabIndex = 40;
            this.lblANIS.Text = "-";
            this.lblANIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDNIS
            // 
            this.lblDNIS.BackColor = System.Drawing.Color.Transparent;
            this.lblDNIS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIS.Location = new System.Drawing.Point(110, 46);
            this.lblDNIS.Name = "lblDNIS";
            this.lblDNIS.Size = new System.Drawing.Size(240, 21);
            this.lblDNIS.TabIndex = 39;
            this.lblDNIS.Text = "-";
            this.lblDNIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 38;
            this.label7.Text = "ANI\\Number\r\nName";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "DNIS";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxStateTime
            // 
            this.textBoxStateTime.BackColor = System.Drawing.Color.Transparent;
            this.textBoxStateTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStateTime.Location = new System.Drawing.Point(194, 31);
            this.textBoxStateTime.Name = "textBoxStateTime";
            this.textBoxStateTime.Size = new System.Drawing.Size(76, 14);
            this.textBoxStateTime.TabIndex = 36;
            this.textBoxStateTime.Text = "00:00:00";
            this.textBoxStateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCallTime
            // 
            this.textBoxCallTime.BackColor = System.Drawing.Color.Transparent;
            this.textBoxCallTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCallTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textBoxCallTime.Location = new System.Drawing.Point(108, 31);
            this.textBoxCallTime.Name = "textBoxCallTime";
            this.textBoxCallTime.Size = new System.Drawing.Size(62, 14);
            this.textBoxCallTime.TabIndex = 35;
            this.textBoxCallTime.Text = "00:00:00";
            this.textBoxCallTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblstatusLine1
            // 
            this.lblstatusLine1.BackColor = System.Drawing.Color.Transparent;
            this.lblstatusLine1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatusLine1.Location = new System.Drawing.Point(194, 9);
            this.lblstatusLine1.Name = "lblstatusLine1";
            this.lblstatusLine1.Size = new System.Drawing.Size(84, 21);
            this.lblstatusLine1.TabIndex = 34;
            this.lblstatusLine1.Text = "-";
            this.lblstatusLine1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Line 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.header_middle;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(290, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1276, 126);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(190, 73);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(106, 26);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_ClickAsync);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.header_middle;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.label24);
            this.pnlLogin.Controls.Add(this.spinner1);
            this.pnlLogin.Controls.Add(this.button1);
            this.pnlLogin.Controls.Add(this.pnlstation);
            this.pnlLogin.Controls.Add(this.label21);
            this.pnlLogin.Controls.Add(this.label22);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUserID);
            this.pnlLogin.Controls.Add(this.label23);
            this.pnlLogin.Controls.Add(this.button2);
            this.pnlLogin.Controls.Add(this.button3);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(-40, 182);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1596, 126);
            this.pnlLogin.TabIndex = 49;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Location = new System.Drawing.Point(42, 105);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(384, 22);
            this.label24.TabIndex = 33;
            this.label24.Text = "Version : 1.0.0.10";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spinner1
            // 
            this.spinner1.BackColor = System.Drawing.Color.Transparent;
            this.spinner1.Location = new System.Drawing.Point(206, 3);
            this.spinner1.Name = "spinner1";
            this.spinner1.NodeBorderColor = System.Drawing.Color.White;
            this.spinner1.NodeBorderSize = 2;
            this.spinner1.NodeCount = 8;
            this.spinner1.NodeFillColor = System.Drawing.Color.Black;
            this.spinner1.NodeRadius = 4;
            this.spinner1.NodeResizeRatio = 1F;
            this.spinner1.Size = new System.Drawing.Size(136, 125);
            this.spinner1.SpinnerRadius = 70;
            this.spinner1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.arrowf;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(384, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 32;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pnlstation
            // 
            this.pnlstation.BackColor = System.Drawing.Color.Transparent;
            this.pnlstation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlstation.Controls.Add(this.cbDomain);
            this.pnlstation.Controls.Add(this.txtPortalData);
            this.pnlstation.Controls.Add(this.label17);
            this.pnlstation.Controls.Add(this.label18);
            this.pnlstation.Controls.Add(this.txtPortal);
            this.pnlstation.Controls.Add(this.txtStation);
            this.pnlstation.Controls.Add(this.label19);
            this.pnlstation.Controls.Add(this.label20);
            this.pnlstation.Location = new System.Drawing.Point(434, 3);
            this.pnlstation.Name = "pnlstation";
            this.pnlstation.Size = new System.Drawing.Size(516, 119);
            this.pnlstation.TabIndex = 31;
            // 
            // cbDomain
            // 
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(116, 58);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(258, 24);
            this.cbDomain.TabIndex = 23;
            // 
            // txtPortalData
            // 
            this.txtPortalData.Location = new System.Drawing.Point(116, 85);
            this.txtPortalData.Name = "txtPortalData";
            this.txtPortalData.Size = new System.Drawing.Size(360, 22);
            this.txtPortalData.TabIndex = 20;
            this.txtPortalData.Text = "core2019.aspect.co.id:8443";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 22);
            this.label17.TabIndex = 21;
            this.label17.Text = "Portal Data";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(18, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 22);
            this.label18.TabIndex = 19;
            this.label18.Text = "Domain";
            // 
            // txtPortal
            // 
            this.txtPortal.Location = new System.Drawing.Point(116, 31);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(360, 22);
            this.txtPortal.TabIndex = 18;
            this.txtPortal.Text = "core2019.aspect.co.id:8443";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(116, 5);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(176, 22);
            this.txtStation.TabIndex = 16;
            this.txtStation.Text = "1030";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 23);
            this.label19.TabIndex = 15;
            this.label19.Text = "Station:";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 22);
            this.label20.TabIndex = 17;
            this.label20.Text = "Portal Aspect";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(60, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 22);
            this.label21.TabIndex = 26;
            this.label21.Text = "User ID:";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(60, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 22);
            this.label22.TabIndex = 28;
            this.label22.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(190, 43);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(174, 22);
            this.txtPassword.TabIndex = 29;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(190, 14);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(174, 22);
            this.txtUserID.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(-36, -18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 26);
            this.label23.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-36, -18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 26);
            this.button2.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-36, -18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 26);
            this.button3.TabIndex = 25;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(68, 130);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1502, 28);
            this.lblMessage.TabIndex = 50;
            this.lblMessage.Text = "00:00:00";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessage.Visible = false;
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picInfo.Image = ((System.Drawing.Image)(resources.GetObject("picInfo.Image")));
            this.picInfo.Location = new System.Drawing.Point(18, 125);
            this.picInfo.Margin = new System.Windows.Forms.Padding(0);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(46, 41);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 51;
            this.picInfo.TabStop = false;
            this.picInfo.Visible = false;
            // 
            // FToolbar
            // 
            this.AcceptButton = this.btnLogin;
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 512);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlTollbar);
            this.Controls.Add(this.pnlState);
            this.Controls.Add(this.picInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 1);
            this.Name = "FToolbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Agent Portal Client ";
            this.Load += new System.EventHandler(this.FToolbar_Load);
            this.pnlState.ResumeLayout(false);
            this.pnlTollbar.ResumeLayout(false);
            this.pnlTollbar.PerformLayout();
            this.grpPhone.ResumeLayout(false);
            this.grpPhone.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.grpLine3.ResumeLayout(false);
            this.grpLine1Awal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlstation.ResumeLayout(false);
            this.pnlstation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion
        private void mpApp_GoUnavailableRequestStatus(
      object pSender,
      PortalRequestStatusEventArgs pArgs)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((Delegate)new PortalRequestStatusEventHandler(this.mpApp_GoUnavailableRequestStatus), pSender, (object)pArgs);
                    return;
                }
            }
            catch (Exception ex)
            {
            }

            if (pArgs.RequestPending)
            {
                if (this.isEnteringNotReadyState)
                {
                    this.DisplayMessageForm("End the current call to go not ready");
                    //this.changeStateUC.listItemCancelUnavailable.Header = (object)(string)System.Windows.Application.Current.Resources[(object)"MB-CancelNotReady"];
                }
                else
                {
                    this.DisplayMessageForm("End the current call to go parked");
                    //this.DisplayMessage((string)System.Windows.Application.Current.Resources[(object)"MM-EndCallToGoParkedeStr"], WindowShadeErrorInfoType.INFORMATION, false, false, false);
                    //    this.changeStateUC.listItemCancelUnavailable.Header = (object)(string)System.Windows.Application.Current.Resources[(object)"MB-CancelParked"];
                }
                //this.changeStateUC.listItemCancelUnavailable.Visibility = Visibility.Visible;
            }
            //else
            //{
            //    this.changeStateUC.listItemCancelUnavailable.Visibility = Visibility.Collapsed;
            //    this.CloseErrorMsgPopup();
            //}
        }
        private bool isEnteringNotReadyState = false;
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
                this.bDisplayWrapWarning = false;
                //this.miAgentStateTickCount = 0;
                //this.stateInitialTime = DateTime.Now;
                //if (newState.Description == "PREVIEW")
                //    this.bIsPreviewDial = false;
                this.lblState.Text = newState.Description;
                lblstatusLine1.Text = newState.Description;

                //grpLine3.BackColor = newState.BackColor;
                //grpLine3.ForeColor = newState.ForeColor;
                panelLayout(pArgs.NewState.Id);
                if (pArgs.NewState.Id != AgentStateId.asIDLE && pArgs.NewState.Id != AgentStateId.asAUTHENTICATED && pArgs.NewState.Id != AgentStateId.asINACTIVE && pArgs.NewState.Id != AgentStateId.asPARKED && pArgs.NewState.Id != AgentStateId.asNOT_READY && pArgs.NewState.Id != AgentStateId.asHELD && pArgs.NewState.Id != AgentStateId.asACTIVE && pArgs.NewState.Id != AgentStateId.asRINGING && pArgs.NewState.Id != AgentStateId.asCONFERENCE && pArgs.NewState.Id != AgentStateId.asCHATTING && pArgs.NewState.Id != AgentStateId.asCONSULTING && pArgs.NewState.Id != AgentStateId.asDIALING_CONSULTATION && pArgs.NewState.Id != AgentStateId.asDIALING && pArgs.NewState.Id != AgentStateId.asWAITING)
                {
                   
                    if (pArgs.NewState.Id == AgentStateId.asWRAP)
                    {
                        //this.btnSurvey.Enabled = false;
                        //this.btnSurvey.BackgroundImage = (Image)Resources.transfer_or_left_right_arrows;
                        //this.lblUserName.BackColor = Color.Yellow;
                        //this.lblUserName.ForeColor = Color.Black;
                    }
                    else if (pArgs.NewState.Id == AgentStateId.asLOGGED_OUT || pArgs.NewState.Id == AgentStateId.asLOGGING_IN || pArgs.NewState.Id != AgentStateId.asPREVIEW);
                }
                //this.btnHangup.Enabled = newState.EnableHangup && this.mpApp.CurrentService.AllowHangup;
                //this.btnDial.Enabled = newState.EnableDial;
                //this.btnHold.Enabled = newState.EnableHold && this.mpApp.CurrentService.AllowHold;
                //this.btn3Way.Enabled = newState.Enable3Way;
                //this.btnNextCall.Enabled = newState.EnableNextCall;
                btnHangup.Enabled = newState.EnableHangup && this.mpApp.CurrentService.AllowHangup;
                btnDialNum.Enabled = newState.EnableHangup && this.mpApp.CurrentService.AllowHangup;
                btnDial.Enabled = newState.EnableDial;
                btnHold.Enabled = newState.EnableHold && this.mpApp.CurrentService.AllowHold;
                btn3Way.Enabled = newState.Enable3Way;
                btnRecord.Enabled = newState.EnableRecord;

                //if (newState.EnableDial || newState.EnableHold)
                //{
                //    grpPhone.Visible =true;
                //    grpPhone.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width-(grpPhone.Width +20), grpPhone.Location.Y);
                //}
                //else
                //    grpPhone.Visible = false;
                switch (pArgs.NewState.Id)
                {
                    case AgentStateId.asACTIVE:
                        this.btnHold.Text = "Hold";
                        break;
                    case AgentStateId.asHELD:
                        this.btnHold.Text = "Pick up";
                        break;
                    //case AgentStateId.asLOGGED_OUT:
                    //    if (this.isSessionExists &&  this.isCallinProgress)
                    //    {
                    //        //this.hasRequestedPanicLogout = false;
                    //        //if (!this.reLoginCompleted)
                    //        //    this.reLoginCompleted = true;
                    //        this.mpProcessCallInProgressTimer = new System.Threading.Timer(new TimerCallback(this.ProcessCallInProgress_Login), pArgs.NewState, 100, -1);
                    //    }
                    //    else
                    //        this.Close();
                    //    break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        private void ProcessCallInProgress_Login()
        {
            if (this.InvokeRequired) 
            {
                this.Invoke(new CloseFormDelegate(ProcessCallInProgress_Login));
            }
            else
            {
                try
                {
                    bool statuslogin = false;
                    //if (this.isPortalDown || this.isSessionExists || this.isCallinProgress)
                    //{
                    //    if (this.isSessionExists || this.isCallinProgress)
                    //    {
                            try
                            {
                                //string domain = GetControlText(cbDomain);
                                string portal = this.txtPortal.Text;
                                var hosts = new List<string>();
                                int position;
                                string appendedport;
                                if ((position = portal.IndexOf("8180")) > 0)
                                {
                                    appendedport = "8180";
                                }
                                else
                                {
                                    appendedport = "8443";
                                }
                                string arg = (portal.Contains("443") ? Uri.UriSchemeHttps : Uri.UriSchemeHttp);
                                var count = TextTool.CountStringOccurrences(portal, "|");
                                for (int a = 0; a < count + 1; a = a + 1)
                                {
                                    string retportal = portal.Contains("|") ? portal.Split('|')[a].Trim() : portal.Trim();
                                    hosts.Add("@" + retportal);
                                }
                                var portal1 = PortalLoadBalancer.LoadBalance(hosts, 35);
                                mpApp.setEvent(portal1 + ":" + appendedport);
                                currentportal = portal1;
                                mpApp.Login(this.txtUserID.Text, this.txtPassword.Text, this.txtStation.Text, portal1 + ":" + appendedport, domain, true);

                                currentagent = this.txtUserID.Text;

                                ini.Write("aspect", "station", txtStation.Text);
                                ini.Write("aspect", "portal", txtPortal.Text);
                                ini.Write("aspect", "urldata", txtPortalData.Text);
                                ini.Write("user", "userid", txtUserID.Text);
                                ini.Write("aspect", "domain", domain);
                                statuslogin = true;

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Login Failed");
                            }
                            finally
                            {
                                if (statuslogin)
                                {
                                    loadCAppReLogin();
                                    this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                                    //if (this.isCallinProgress || this.isPortalDown || this.isSessionExists)
                                    //{
                                    //    if (this.isSessionExists)
                                    //    {
                                    //        mnIdle_Click(this, EventArgs.Empty);
                                    //    }
                                    //    if (this.isSessionExists)
                                    //        this.isSessionExists = false;

                                    //}
                                }
                            }
                    //    }


                    //}
                }
                catch (Exception ex)
                {
                    ///text
                    ///
                    MessageBox.Show("call in progress " + ex.Message);
                }
            }
        }
        private void loadCAppReLogin()
        {
            CApp_StateChange(this, new CStateChangeArgs(mpApp.CurrentState));
        }

        private void FToolbar_Load(object sender, System.EventArgs e)
        {
            button4.Enabled=false;
            pnlTollbar.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.Location = new System.Drawing.Point(0, 0);
            pnlstation.Visible = false;
            //grpPhone.Visible = false;
            this.Width = 400;
            ini = new IniReader(System.Windows.Forms.Application.StartupPath + "\\inisetting.ini");
            txtStation.Text = ini.ReadString("aspect", "station", "");
            txtUserID.Text = ini.ReadString("user", "userid", "");
            txtPortal.Text = ini.ReadString("aspect", "portal", "");
            txtPortalData.Text = ini.ReadString("aspect", "urldata", "");
            strDomain = ini.ReadString("aspect", "domain", "");
            pnlLogin.Enabled = false;
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            spinner1.Show();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
                backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                                                 backgroundWorker1_RunWorkerCompleted);
            }
            backgroundWorker1.RunWorkerAsync(100);
          
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker helperBW = sender as BackgroundWorker;
            int arg = (int)e.Argument;
            e.Result = BackgroundProcessLogicMethod(helperBW, arg);
           
        }
        private int BackgroundProcessLogicMethod(BackgroundWorker bw, int a)
        {
            int result = 0;
            try
            {
                mpApp = new CApp();// Your long-running code
            }
            catch (Exception ex)
            {
                // If an error occurs, pass it to the RunWorkerCompleted event
                result = 1;
            }
            return result;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlLogin.Enabled = true;
            loadDomain();
            spinner1.Hide();
            backgroundWorker1.Dispose();

            if (e.Error != null)
            {
                MessageBox.Show("An error occurred: " + e.Error.Message);
            }
            // Handle the task completion or result here
        }
        

       #region Login
        private System.ComponentModel.BackgroundWorker backgroundWorker1, backgroundWorker2;
        private delegate string ControlToStringMethodInvoker(Control ctl);
        private delegate void ControlStringMethodInvoker(Control ctl, string str);

        private IniReader ini;
        public static string currentportal = "";
        public static string currentagent;
        private string strDomain = "";
        bool toggle = false;
        public string GetControlText(Control ctl)
        {
            string text;

            if (ctl.InvokeRequired)
            {
                // Delegate.
                text = (string)ctl.Invoke(new ControlToStringMethodInvoker(GetControlText),
                                          ctl);
            }
            else
            {
                // Access the control directly.
                text =((ComboBox) ctl).SelectedValue.ToString();
            }

            return text;
        }
        string domain = "";
        private async void btnLogin_ClickAsync(object sender, System.EventArgs e)
        {

            // 1. Show the loading spinner and disable UI
            spinner1.Show();
            btnLogin.Enabled = false;
            bool statuslogin = false;
            try
            {
                await Task.Run(() =>
                {
                    domain = GetControlText(cbDomain);
                    string portal = this.txtPortal.Text;
                    var hosts = new List<string>();
                    int position;
                    string appendedport;
                    if ((position = portal.IndexOf("8180")) > 0)
                    {
                        appendedport = "8180";
                    }
                    else
                    {
                        appendedport = "8443";
                    }
                    string arg = (portal.Contains("443") ? Uri.UriSchemeHttps : Uri.UriSchemeHttp);
                    var count = TextTool.CountStringOccurrences(portal, "|");
                    for (int a = 0; a < count + 1; a = a + 1)
                    {
                        string retportal = portal.Contains("|") ? portal.Split('|')[a].Trim() : portal.Trim();
                        hosts.Add("@" + retportal);
                    }
                    var portal1 = PortalLoadBalancer.LoadBalance(hosts, 35);
                    mpApp.setEvent(portal1 + ":" + appendedport);
                    currentportal = portal1;
                    mpApp.Login(this.txtUserID.Text, this.txtPassword.Text, this.txtStation.Text, portal1 + ":" + appendedport, domain, true);

                    currentagent = this.txtUserID.Text;

                    ini.Write("aspect", "station", txtStation.Text);
                    ini.Write("aspect", "portal", txtPortal.Text);
                    ini.Write("aspect", "urldata", txtPortalData.Text);
                    ini.Write("user", "userid", txtUserID.Text);
                    ini.Write("aspect", "domain", domain);
                    statuslogin = true;
                   
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
            finally
            {
                if (statuslogin)
                {
                    loadCApp();
                    pnlTollbar.Visible = true;
                    pnlLogin.Visible = false;
                    this.Width = Screen.PrimaryScreen.WorkingArea.Width;
                }

                spinner1.Hide();
                btnLogin.Enabled = true;
             
            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (toggle)
            {
                toggle = false;
                this.Width = 400;
                pnlstation.Visible = false;
            }
            else
            {
                toggle = true;
                pnlstation.Visible = true;
                this.Width = 840;
            }
        }
        private void loadDomain()
        {
            var dict = new Dictionary<string, string>();
            try
            {
                btnLogin.Enabled = true;
                string portal = this.txtPortal.Text;
                var hosts = new List<string>();
                int position;
                string appendedport;
                if ((position = portal.IndexOf("8180")) > 0)
                {
                    appendedport = "8180";
                }
                else
                {
                    appendedport = "8443";
                }
                string arg = (portal.Contains("443") ? Uri.UriSchemeHttps : Uri.UriSchemeHttp);
                var count = TextTool.CountStringOccurrences(portal, "|");
                for (int a = 0; a < count + 1; a = a + 1)
                {
                    string retportal = portal.Contains("|") ? portal.Split('|')[a].Trim() : portal.Trim();
                    hosts.Add("@" + retportal);
                }
                var portal1 = PortalLoadBalancer.LoadBalance(hosts, 35);

                string[] listDomain = mpApp.LoadDomain(portal1 + ":" + appendedport, true);

                for (int i = 0; i < listDomain.Length; i++)
                {
                    dict.Add(listDomain[i], listDomain[i]);
                }
                if (listDomain.Length == 0)
                {
                    dict.Add("0", "Default");
                    btnLogin.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                dict.Add("0", "Default");
                btnLogin.Enabled = false;
            }
            cbDomain.DataSource = new BindingSource(dict, null);
            cbDomain.DisplayMember = "Value";
            cbDomain.ValueMember = "Key";
            cbDomain.SelectedValue = strDomain;
        }

        #endregion
        
        private void loadCApp()
        {
            mpApp.SessionTimedOut += new SessionTimedOutEventHandler(this.CApp_Session);
            mpApp.StateChange += new StateChangeHandler(this.CApp_StateChange);
            mpApp.Screenpop += new ScreenpopHandler(this.CApp_Screenpop);
            mpApp.Passcode += new PasscodeHandler(this.CApp_Passcode);
            mpApp.UnfocusedStateChange += new UnfocusedStateChangeHandler(this.CApp_CUnfocusStateChange);
            mpApp.LogoutPending += new LogoutPendingHandler(this.CApp_LogoutPending);
            mpApp.GoUnavailableRequestStatus += new PortalRequestStatusEventHandler(this.mpApp_GoUnavailableRequestStatus);
            mpApp.CallStateChange += new CallStateChangeHandler(this.CApp_CallStateChange);
            mpApp.WrapTimeout += new WrapTimeoutEventHandler(this.mpApp_WrapTimeout);
            mpApp.PhoneStatus += new PhoneStatusHandler(this.CApp_PhoneStatus);
            mpApp.Error += new ErrorHandler(this.CApp_Error);
            mpApp.LoggedIn += new LoggedInHandler(this.CApp_LoggedIn);
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(btnHold, "Hold");
            ToolTip1.SetToolTip(btnRecord, "Record");
            ToolTip1.SetToolTip(btn3Way, "Transfer");
            ToolTip1.SetToolTip(btnHangup, "Release");
            ToolTip1.SetToolTip(btnDialNum, "NumPad");
            grpLine1Awal.Visible = true;
            grpLine3.Visible = false;
            pnlState.Visible = false;
            lblMessage.Visible = false;
            mReady2.Visible = false;
            mCancelLogout.Visible = false;

            lblState.Parent = panel1;
            lblState.BackColor = Color.Transparent;
            lblState.ForeColor = Color.Black;
            lblState.BringToFront();

            this.Text = "Agent Portal Client - " + mpApp.CurrentAgent.LoginName;

            CApp_StateChange(this, new CStateChangeArgs(mpApp.CurrentState));

            this.IdleTimer1 = new DispatcherTimer();
            this.IdleTimer1.Tick += new EventHandler(this.IdleTimer1_Tick);
            this.IdleTimer1.Interval = new TimeSpan(0, 0, 1);

            mCancel.Visible = false;
            mnReady.Enabled = false;
            mReady2.Visible = false;
            mCancelLogout.Visible = false;
            createMenu();
            buttonDial(false);
            grpPhone.Enabled = true;
            textBlockNotReadyParkTimer.Visible = false;
            this.notReadyParkTimer = new DispatcherTimer();
            this.notReadyParkTimer.Interval = new TimeSpan(0, 0, 1);
            this.notReadyParkTimer.Tick += new EventHandler(this.NotReadyParkTimeClick);

            int seconds = 1;

            this.StatusDurationTimer = new DispatcherTimer();
            this.StatusDurationTimer.Interval = new TimeSpan(0, 0, seconds);
            this.StatusDurationTimer.Tick += new EventHandler(this.DisplayTimeEvent);
            StatusDurationTimer.IsEnabled = false;

            this.StatusDurationTimer1 = new DispatcherTimer();
            this.StatusDurationTimer1.Interval = new TimeSpan(0, 0, seconds);
            this.StatusDurationTimer1.Tick += new EventHandler(this.DisplayTimeEvent1);
            //this.StatusDurationTimer1.IsEnabled = this.StatusDurationTimer.Dispatcher.Thread.IsAlive;

            this.grpLine3.Click += new EventHandler(showdetail);
            this.label11.Click += new EventHandler(showdetail);
            this.label10.Click += new EventHandler(showdetail);
            this.lblANIS.Click += new EventHandler(showdetail);
            this.lblDNIS.Click += new EventHandler(showdetail);
            this.label7.Click += new EventHandler(showdetail);
            this.label6.Click += new EventHandler(showdetail);
            this.textBoxStateTime.Click += new EventHandler(showdetail);
            this.textBoxCallTime.Click += new EventHandler(showdetail);
            this.lblstatusLine1.Click += new EventHandler(showdetail);
            this.label2.Click += new EventHandler(showdetail);
        }
        private void MySizeChanged(object sender, EventArgs e)
        {
            try
            {

                int screenHeight = 180;// Screen.PrimaryScreen.WorkingArea.Height;
                int maxWidth = 0;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    maxWidth = Screen.PrimaryScreen.WorkingArea.Width;
                    this.WindowState = FormWindowState.Normal;
                }
                else if (this.WindowState == FormWindowState.Normal)
                {
                    maxWidth = this.Width;
                }
                if (WindowState != FormWindowState.Minimized)
                {
                    this.Size = new Size(maxWidth, screenHeight);
                    pnlTollbar.Width = maxWidth;
                    pictureBox3.Width = maxWidth;
                    this.pictureBox3.Invalidate();
                    grpPhone.Location = new Point(maxWidth - (grpPhone.Width + 20), grpPhone.Location.Y);
                }
                
            }
            catch(Exception ex) {
                
            }
           
        }
        private void ShowItemPhone(string data)
        {
            txtdial.Text = data;
            lblDNIS.Text = data;
        }
        //private void ShowItemMessage(string data,bool time)
        //{
        //    DisplayMessageForm(data);
        //    //DisplayMessage(data, time);
        //}
        private void ShowItem(UpdateTitle data)
        {
            textBoxCallTime.Text = data.Calltime;
            textBoxStateTime.Text = data.Statetime;
            //lblDNIS.Text = data.Dnis;
            //lblANIS.Text = data.Ani;
        }
        private void buttonDial(bool dial)
        {
            if (!dial)
            {
                btnDialNum.BackgroundImage = SamplePortalClientUI.Properties.Resources.numpad_disable;
                btnHangup.BackgroundImage = SamplePortalClientUI.Properties.Resources.release_btn_notext_small_reversed_disable;
                btnRecord.BackgroundImage = SamplePortalClientUI.Properties.Resources.record_btn_notext_small_reversed_disable;
                btn3Way.BackgroundImage = SamplePortalClientUI.Properties.Resources.transfer_btn_notext_small_reversed_disable;
                btnHold.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold_btn_notext_small_reversed_disable;
                grpPhone.Enabled = true;
            }
            else
            {
                btnDialNum.BackgroundImage = SamplePortalClientUI.Properties.Resources.numpad;
                btnHangup.BackgroundImage = SamplePortalClientUI.Properties.Resources.release_btn_notext_small_reversed;
                btnRecord.BackgroundImage = SamplePortalClientUI.Properties.Resources.record_btn_notext_small_reversed;
                btn3Way.BackgroundImage = SamplePortalClientUI.Properties.Resources.transfer_btn_notext_small_reversed;
                if (mpApp.CurrentCall.CurrentState is CStateHeld)
                    this.btnHold.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.play;
                else
                    btnHold.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold_btn_notext_small_reversed;
                
                grpPhone.Enabled = true;
            }
        }

       // public FToolbar(
       //    string Startdate, string Calltime, string DNIS, string ANIS
       //)
       // {
       //     textBoxCallTime.Text = Calltime;
       //     textBoxStateTime.Text = Startdate;
       //     lblDNIS.Text = DNIS;
       //     lblANIS.Text = ANIS;

       // }
        private void IdleTimer1_Tick(object sender, EventArgs e)
        {
            //plii.cbSize = (uint)Marshal.SizeOf<MainToolbarWindow.tagLASTINPUTINFO>(plii);
            //plii.dwTime = 0;
            //double totalSeconds = (DateTime.Now - this.lasteventtime).TotalSeconds;
            //if (!MainToolbarWindow.GetLastInputInfo(ref plii))
            //    return;
            //int num = Environment.TickCount - plii.dwTime;
            //if (this.CApp._ClientServiceHost.ClientService.IdleTimeout == 0 || num <= this.CApp._ClientServiceHost.ClientService.IdleTimeout * 60000 || totalSeconds <= (double)(this.CApp._ClientServiceHost.ClientService.IdleTimeout * 60))
            //    return;
            //this.IdleTimeouthappened = true;
            //this.loginManager.logout(LogoutReasons.PanicLogoutReason);
            //string resource = (string)System.Windows.Application.Current.Resources[(object)"MB-RequestTimeoutExitStr"];
            //MainToolbarWindow.Log.DebugFormat("[{0}] LogoutInfo: {1}", (object)MethodBase.GetCurrentMethod().Name, (object)resource.ToString());
            //if (UADMessageBox.ShowBox(resource, (string)System.Windows.Application.Current.Resources[(object)"MB-ExitingUnifiedAgentDesktopStr"], UADMessageBoxButton.Ok, UADMessageBoxImage.Warning, UADMessageBoxReturnValue.Ok) != UADMessageBoxReturnValue.Ok)
            //    ;
            //foreach (Process process in Process.GetProcessesByName("UADPresentationLayer"))
            //{
            //    try
            //    {
            //        process.Kill();
            //        process.WaitForExit();
            //    }
            //    catch (InvalidOperationException ex)
            //    {
            //        MainToolbarWindow.Log.LogException((Exception)ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            //    }
            //}
        }
        //public void CDDLoad(CCall pCall, CApp pApp)
        //{
        //    try
        //    {
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Call Data Form is loading . . .");
        //        this.mpCall = pCall;
        //        this.mpApp = pApp;
        //        this.mpService = this.mpApp.CurrentService;
        //        this.tbControlMain.TabPages.Clear();
        //        this.tbControlMain.TabPages.Add(this.tbCallData);
        //        this.ClearCDD();
        //        GlobalVariable.SeqNum = DateTime.Now.ToString("yyyyMMddHHmmss") + this.mpCall.CallID.ToString();
        //        GlobalVariable.UniqueID = string.Empty;
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Geting Callback Flag : " + this.mpCall.CallBackFlag.ToString());
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Geting Callback Memo : " + this.mpCall.CallBacMemo);
        //        string str = "";
        //        if (this.mpCall.CallBacMemo != null)
        //            str = this.mpCall.CallBacMemo;
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Assigning Valuse to callback started...");
        //        int emSize = Settings.Default.FontSize;
        //        int emSize = Settings.Default.FontSize;
        //        if (emSize == 0)
        //            emSize = 9;
        //        Font font1 = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Regular);
        //        Font font2 = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Regular);
        //        this.txtCallbackMemo.Font = font1;
        //        this.lblCallbackMemo.Font = font2;
        //        this.txtCallbackMemo.Text = str;
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Assigning Valuse to callback Completed...");
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Interface Paramaters");
        //        this.txtServiceName.Text = this.mpApp.AssignedServices.GetByKey((object)this.mpCall.ServiceID).ServiceName;
        //        this.toolTip1.SetToolTip((Control)this.txtServiceName, this.txtServiceName.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Service Name : " + this.txtServiceName.Text);
        //        this.txtDNIS.Text = string.IsNullOrEmpty(this.mpCall.Dnis) ? this.mpCall.PhoneNumber : this.mpCall.Dnis;
        //        this.toolTip1.SetToolTip((Control)this.txtDNIS, this.txtDNIS.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - DNIS : " + this.txtDNIS.Text);
        //        this.txtPhoneNumber.Text = this.mpCall.CallType == AgentCallType.acACD ? "" : this.mpCall.PhoneNumber;
        //        this.toolTip1.SetToolTip((Control)this.txtPhoneNumber, this.txtPhoneNumber.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Contact Number : " + this.txtPhoneNumber.Text);
        //        this.txtANI.Text = this.mpCall.Ani;
        //        this.toolTip1.SetToolTip((Control)this.txtANI, this.txtANI.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - ANI : " + this.txtANI.Text);
        //        this.txtFirstName.Text = this.mpCall.FirstName == null ? "" : this.mpCall.FirstName.Trim();
        //        this.toolTip1.SetToolTip((Control)this.txtFirstName, this.txtFirstName.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - First Name : " + this.txtFirstName.Text);
        //        this.txtLastName.Text = this.mpCall.LastName == null ? "" : this.mpCall.LastName.Trim();
        //        this.toolTip1.SetToolTip((Control)this.txtLastName, this.txtLastName.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Last Name : " + this.txtLastName.Text);
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - *Call ID : " + this.mpCall.CallID.ToString());
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Call Data Parameter Value completed.");
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Checking the Talisma Port started.");
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Call Data Parameter Value completed.");
        //        if (this.mpCall.CallType == AgentCallType.acMANUAL)
        //            this.mpApp.GetCDDDefinition(this.mpApp.CurrentService.CallDataDefId);
        //        this.PopulateCallDataDisplay(this.mpCall.UserDefinedItems);
        //        if (this.mpCall.ResponseRequired)
        //        {
        //            CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.CApp_StateChangeCDD() - Invoke StateChangeHandler Invoke Process starting . . .");
        //            new AnswerReject(this.mpApp, this.mpCall).Show();
        //            if (this.mpCall.PlayAudioAlert)
        //            {
        //                CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Playing Beep ");
        //                Console.WriteLine("Playing beep...");
        //                Console.Beep(415, 200);
        //            }
        //            CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.FCallData_Load() - Call Timer Invoked ");
        //        }
        //        if (this.mpUnloadTimerCDD != null)
        //        {
        //            this.mpUnloadTimerCDD.Dispose();
        //            this.mpUnloadTimerCDD = (System.Threading.Timer)null;
        //        }
        //        if (pCall.CallBackFlag == 1)
        //        {
        //            this.txtCallbackMemo.Visible = true;
        //            this.lblCallbackMemo.Visible = true;
        //        }
        //        else
        //        {
        //            this.txtCallbackMemo.Visible = false;
        //            this.lblCallbackMemo.Visible = false;
        //        }
        //        this.tbControlMain.Visible = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        CAFE_Toolbar.logFile.LogMessageToFile(" |ERROR| FCallData.FCallData_Load() - " + ex.StackTrace.ToString());
        //    }
        //    this.Visible = true;
        //}
        private void DisplayMessageForm(String sMsg)
        {
            try
            {
                DisplayMessage(sMsg,true);
               
               
                
                //PopupNotifier popup = new PopupNotifier(this);
                ////popup.TitleText = "Notification Title";
                //popup.ContentText = sMsg;
                //// Optional: Set an icon for the notification
                //popup.Image = SamplePortalClientUI.Properties.Resources.info;
                //popup.Popup(this);



            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }
        private void panelLayout(AgentStateId stage)
        {
            Color previewColor = ColorTranslator.FromHtml("#b70887");
            Color dialingColor = ColorTranslator.FromHtml("#0c5ba2");
            Color holdColor = ColorTranslator.FromHtml("#a43326");
            Color activeColor = ColorTranslator.FromHtml("#319f19");
            Color wrapColor = ColorTranslator.FromHtml("#a6871c");
            Color defaultColor = Color.Gray;
            grpLine1Awal.Visible = true;
            grpLine3.Visible = false;
            switch (stage)
            {
                
                case AgentStateId.asLOGGED_OUT:
                    grpLine3.BorderColor = defaultColor;
                    this.grpLine3.BackColor = defaultColor;
                    grpLine1Awal.Visible = false;
                    break;
                case AgentStateId.asACTIVE:
                    grpLine3.BorderColor = activeColor;
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.active;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;

                case AgentStateId.asHELD:
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold;
                    grpLine3.BorderColor = holdColor;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;

                case AgentStateId.asCHATTING:

                    break;
                case AgentStateId.asDIALING:
                    grpLine3.BorderColor = dialingColor;
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.dialing;
                    lblstatusLine1.Text = "Dialing";
                    lblState.Text ="Dialing";
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;
                case AgentStateId.asIDLE:
                    grpLine3.BorderColor = defaultColor;
                    this.grpLine3.BackColor = defaultColor;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;
                case AgentStateId.asNOT_READY:
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.hold;
                    grpLine3.BorderColor = holdColor;
                    grpLine3.Visible = false;
                    grpLine1Awal.Visible = true;
                    break;
                case AgentStateId.asPREVIEW:
                    grpLine3.BorderColor = previewColor;
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.preview;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;
                //case AgentStateId.asDISPOSED:
                //    grpLine3.BorderColor = defaultColor;
                //    this.grpLine3.BackColor = defaultColor;
                //    grpLine3.Visible = true;
                //    break;
                case AgentStateId.asINACTIVE:
                    grpLine3.BorderColor = defaultColor;
                    this.grpLine3.BackColor = defaultColor;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;
                case AgentStateId.asACTIVE_IM_INTERNAL:
                    grpLine3.BorderColor = defaultColor;
                    this.grpLine3.BackColor = defaultColor;
                    grpLine3.Visible = false;
                    grpLine1Awal.Visible = true;
                    break;
                case AgentStateId.asWRAP:
                    grpLine3.BorderColor = wrapColor;
                    this.grpLine3.BackgroundImage = SamplePortalClientUI.Properties.Resources.wrap;
                    grpLine3.Visible = true;
                    grpLine1Awal.Visible = false;
                    break;
                default:
                    grpLine3.Visible = false;
                    grpLine1Awal.Visible = true;
                    break;
            }

        }
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FCallData obj = (FCallData)System.Windows.Forms.Application.OpenForms["FCallData"];
            //if (obj != null)
            //    obj.Close();
            //if (UserClosing)
            //{
            //    if (MessageBox.Show("Agent Desktop will now shutdown due to the following reason(s): - An unexpected system error has occurred", "Exiting Agent Desktop", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK)
            //    {

            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        mpApp.Logout_Id(-1);
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}
        }

        public void CApp_Session(Object pSender, SessionTimedOutEventArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new SessionTimedOutEventHandler(this.CApp_Session), new Object[] { pSender, pArgs });
                return;
            }
            else
                MessageBox.Show("Seesion Timeout");
          
        }
        private System.Threading.Timer mpProcessCloseTimer;
        private void ProcessClose()
        {

            if (this.InvokeRequired) // Check if the call is from a different thread
            {
                // If so, invoke this method on the UI thread
                this.Invoke(new CloseFormDelegate(ProcessClose));
            }
            else
            {
                try
                {
                    //if (this.mpProcessCloseTimer != null)
                    //{
                    //    this.mpProcessCloseTimer.Dispose();
                    //    this.mpProcessCloseTimer = (System.Threading.Timer)null;
                    //}

                    if (UserClosing)
                    {

                        if (MessageBox.Show("Agent Desktop will now shutdown due to the following reason(s): - An unexpected system error has occurred",
                            "Exiting Agent Desktop", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000) == DialogResult.OK)
                        {
                        }
                    }
                }
                catch (Exception ex)
                {
                }
                finally {
                    this.CloseFormSafe();
                }
            }
        }
        public delegate void CloseFormDelegate();
        public void CloseFormSafe()
        {
            if (this.InvokeRequired) // Check if the call is from a different thread
            {
                // If so, invoke this method on the UI thread
                this.Invoke(new CloseFormDelegate(CloseFormSafe));
            }
            else
            {
                // If already on the UI thread, close the form directly
                this.Close();
            }
        }

        public void CApp_StateChange(Object pSender, CStateChangeArgs pArgs)
		{	
			//Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
			//If this is not the main thread then invoke this method on the main thread and return.
			if (this.InvokeRequired)
			{
				this.Invoke(new StateChangeHandler(this.CApp_StateChange), new Object[]{pSender, pArgs});
				return;
			}

            try
            {
                //This is the main thread. Update the UI.
                CState pNewState = pArgs.NewState;

                lblstatusLine1.Text = pNewState.Description;
                lblState.Text = pNewState.Description;
                //lblState.BackColor = pNewState.BackColor;
                //lblState.ForeColor = pNewState.ForeColor;
                //grpLine3.BackColor = pNewState.BackColor;
                //grpLine3.ForeColor = pNewState.ForeColor;


                lblstatusLine1.Text = pNewState.Description;
                btnHangup.Enabled = pNewState.EnableHangup;
                btnDialNum.Enabled = pNewState.EnableHangup;
                btnDial.Enabled = pNewState.EnableDial;
                btnHold.Enabled = pNewState.EnableHold;
                btn3Way.Enabled = pNewState.Enable3Way;
                btnRecord.Enabled = pNewState.EnableRecord;
                this.miAgentStateTickCount = 0;
                this.stateInitialTime = DateTime.Now;
                panelLayout(pArgs.NewState.Id);
                //grpPhone.Visible = pNewState.EnableDial;
                //if (pNewState.EnableDial || pNewState.EnableHold)
                //{
                grpPhone.Visible = true;
                grpPhone.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - (grpPhone.Width + 20), grpPhone.Location.Y);
                //}
                //else
                //    grpPhone.Visible = false;
                if (pNewState.Description.ToUpper() == "PREVIEW")
                    this.bIsPreviewDial = false;
                switch (pArgs.NewState.Id)
                {
                    case AgentStateId.asAUTHENTICATED:
                        if (this.isCallinProgress || this.isPortalDown || this.isSessionExists)
                        {
                            this.isPortalDown = false;
                            mnIdle_Click(this, EventArgs.Empty);
                            this.isCallinProgress = false;
                            this.isSessionExists=false;
                        }
                        break;
                    case AgentStateId.asLOGGED_OUT:
                        if (!this.isCallinProgress && (!this.isSessionExists || !this.hasRequestedPanicLogout))
                        {
                            lblState.Text = "Disposed";
                            grpLine3.Visible = false;
                            MenuAction.Image = SamplePortalClientUI.Properties.Resources.notsignedin;
                            mnIdle.Enabled = false;
                            if (isNormalLogout)
                                UserClosing = false;
                            else
                                UserClosing = true;
                            //FCallData obj = (FCallData)System.Windows.Forms.Application.OpenForms["FCallData"];
                            //if (obj != null)
                            //    obj.Close();
                            this.ProcessClose();


                        }
                      
                        else if (this.isSessionExists && this.hasRequestedPanicLogout || !this.reLoginCompleted || this.isCallinProgress)
                        {
                            this.hasRequestedPanicLogout = false;
                            if (!this.reLoginCompleted)
                                this.reLoginCompleted = true;
                            //ProcessCallInProgress_LoginAsync();
                            lblState.Text = "Logging In";
                            ProcessCallInProgress_Login();
                        }
                        break;

                    case AgentStateId.asACTIVE:
                        this.StatusDurationTimer.IsEnabled = this.StatusDurationTimer.Dispatcher.Thread.IsAlive;
                        //btnHold.Text = "Hold";
                        if (this.mpApp.CurrentCall.CallType == AgentCallType.acMANUAL)
                        {
                            //if (this.mpHideCDDTimer == null)
                            //    this.mpHideCDDTimer = new System.Threading.Timer(new TimerCallback(this.HideCDD_Fire), (object)null, 10000, 10000);
                            if (ProcessChecker.ActiveLine == 0)
                            {
                                ProcessChecker.Line1Busy = true;
                                ProcessChecker.ActiveLine = 1;
                            }
                            this.mpCall = mpApp.CurrentCall;
                            //this.CDDLoad(this.mpApp.CurrentCall, this.mpApp);
                            buttonDial(true);
                        }
                        break;

                    case AgentStateId.asHELD:
                        // btnHold.Text = "Pick up";
                        this.btnHold.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.play;
                        break;

                    case AgentStateId.asCHATTING:
                        LoadChatWindow();
                        break;
                    case AgentStateId.asDIALING:
                        this.StopNotReadyParkTimer();
                        this.keepParkTimerRunning = false;
                        break;
                    //case AgentStateId.asINACTIVE:
                    //    if (mpApp.CurrentCall.CallType == AgentCallType.acCHAT)
                    //        UnloadChatWindow();
                    //    break;
                    case AgentStateId.asIDLE:
                        button4.Enabled = true;
                        mCancel.Visible = false;
                        mnIdle.Visible = true;
                        mnIdle.Enabled = false;
                        mnReady.Enabled = true;
                        MenuAction.Image = SamplePortalClientUI.Properties.Resources.bluephoneup;
                        this.StopNotReadyParkTimer();
                        this.keepParkTimerRunning = false;
                        //FCallData obj1 = (FCallData)System.Windows.Forms.Application.OpenForms["FCallData"];
                        //if (obj1 != null)
                        //    obj1.Close();
                     
                        break;
                    case AgentStateId.asNOT_READY:
                        mCancel.Visible = false;
                        mReady2.Visible = true;
                        mnIdle.Visible = false;
                        MenuAction.Image = SamplePortalClientUI.Properties.Resources.redalertphonedown;
                        this.notReadyParkElapsedTime = DateTime.UtcNow;
                        this.StartNotReadyParkTimer();
                        this.textBlockNotReadyParkTimer.Visible = true;
                        keepParkTimerRunning = true;

                        //if (this.LastNotReadyParkReason != null && this.LastNotReadyParkReason != "")
                        //    this.txtReason.Visibility = Visibility.Visible;
                        break;
                    case AgentStateId.asPREVIEW:
                        this.StatusDurationTimer.IsEnabled = this.StatusDurationTimer.Dispatcher.Thread.IsAlive;
                        break;
                    //case AgentStateId.asDISPOSED:
                    //    //CallDataControl.Log.DebugFormat("State : " + pNewState.Id.ToString() + "  entered ");
                    //    //this._mediaMgr.TurnOffWarningIndicator(this.callLineNumber);
                    //    if (pNewState.Id == AgentStateId.asDISPOSED )
                    //    {
                    //        //(this.mpCall as EmailContact).Deleted = true;
                    //       // this._chatEmailUserControl.DeleteEmailMessage((this.mpCall as EmailContact).MessageId);
                    //    }
                    //    //this.RaiseCallDataControlDisposed();
                    //    break;
                    default:
                        break;
                }
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
            finally
            {
                previousState = pArgs.NewState.Id;
            }
		
		}
     
        public void PreviewDial_Fire(object state)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((Delegate)new TimerCallback(this.PreviewDial_Fire), state);
                    //DisplayMessage("Preview Dial is Invoked ", true);
                    DisplayMessageForm("Preview Dial is Invoked ");
                }
                else
                {
                    if (this.PreviewTimeDialer != null)
                    {
                        this.PreviewTimeDialer.Dispose();
                        this.PreviewTimeDialer = (System.Threading.Timer)null;
                    }
                    //DisplayMessage("Preview Dial is Invoked ", true);
                    DisplayMessageForm("Preview Dial is Invoked ");
                    if (this.mpApp.AssignedServices.GetByKey((object)this.mpCall.ServiceID).Timedpreviewflag != 1)
                        return;
                    this.DialPreview();
                }
            }
            catch (Exception ex)
            {
                //DisplayMessage(" |ERROR| FCallData.PreviewDial_Fire() - Preview Dial is Invoke Failed " + ex.Message,true);
                DisplayMessageForm(" |ERROR| FCallData.PreviewDial_Fire() - Preview Dial is Invoke Failed " + ex.Message);
            }
        }
        private bool bDisplayWrapWarning = false;
        public void DisplayTimeEvent1(object sender, EventArgs e)
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
                        if (this.inWrapSecs == mpApp.CurrentService.WrapAlarmSecs)
                        {
                            if (!this.bDisplayWrapWarning)
                            {
                                DisplayMessageForm(" Wrap warning, please open screen pop to see more information");
                            }
                            this.bDisplayWrapWarning = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //CallDataControl.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            }
        }
        private void mpApp_WrapTimeout(object pSender, WrapTimeoutEventArgs pArgs)
        {
            if (Dispatcher.CurrentDispatcher.Thread != Thread.CurrentThread)
            {
                Dispatcher dispatcher = Dispatcher.FromThread(Thread.CurrentThread);

                dispatcher.Invoke(DispatcherPriority.Normal, (Delegate)new WrapTimeoutEventHandler(this.mpApp_WrapTimeout), pSender, (object)pArgs);
            }

            else
            {
                if (pArgs.WrapTimeout.CallId == this.mpCall.CallID)
                {
                    //this.tbwin.LastNotReadyParkReason = string.Empty;
                    //this.tbwin.StopNotReadyParkTimer();
                    //this.tbwin.keepParkTimerRunning = false;
                    bDisplayWrapWarning = false;
                    inWrapSecs = -1;
                    DisplayMessageForm("Your allowed time in WRAP has exceeded");
                }
            }
        }
        private void DialPreview()
        {
            //DisplayMessage("Disposition process starting . . .",true);
            DisplayMessageForm("Disposition process starting . . .");
            int num1 = 0;
            int ExternalRouteId = 0;
            try
            {
                if (this.mpApp.CurrentCall.CurrentState is CStateActive || this.mpApp.CurrentCall.CurrentState is CStateDialing)
                {
                    //DisplayMessage(" Current status is Active or Dialing. So unable to dial", true);
                    DisplayMessageForm(" Current status is Active or Dialing. So unable to dial");
                }
                else
                {
                    //CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.DialPreview(), Service id used by user , Service ID is [ " + num1.ToString() + " ]");
                    //CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.DialPreview(), Dialing is starting . . .");
                    //CAFE_Toolbar.logFile.LogMessageToFile(" |INFO| FCallData.DialPreview(), Dialing Parameters are Contact Number [ " + this.mpCall.PhoneNumber + " ], Service ID [ " + this.mpCall.ServiceID.ToString() + " ], External Rout ID [ " + ExternalRouteId.ToString() + ", Call ID  : " + this.mpApp.CurrentCall.CallID.ToString() + "]");
                    this.mpApp.Dial(this.mpCall.PhoneNumber, this.mpCall.ServiceID, ExternalRouteId);
                    //DisplayMessage("Dialing is completed.",true);
                    DisplayMessageForm("Dialing is completed.");
                }
            }
            catch (Exception ex)
            {
                DisplayMessageForm("Dailing to External Route Process Failed. " + ex.Message);
                //DisplayMessage("Dailing to External Route Process Failed. " + ex.Message,true);
                int num2 = (int)MessageBox.Show(ex.Message);
            }
            DisplayMessageForm("Dailing to External Route Process Completed.");
            //DisplayMessage("Dailing to External Route Process Completed.",true);
        }
        bool isNormalLogout=false;
        private void menu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                if (clickedItem.Name.Contains("LOGOUT"))
                {
                    try
                    {
                        if (!isPendingLogout)
                        {
                            string[] item = clickedItem.Name.Split('#');
                            int id = int.Parse(item[1]);
                            CLogoutReason list = mpApp.LogoutReasons.GetByKey(id);
                            mpApp.Logout(list);
                            isNormalLogout=true;
                        }
                    }
                    catch(Exception pError)  { relogin(pError.Message); }
                }
                else if (clickedItem.Name.Contains("NOTREADY"))
                {
                    try
                    {
                        string[] item = clickedItem.Name.Split('#');
                        int id = int.Parse(item[1]);
                        CNotReadyReason list = mpApp.NotReadyReasons.GetByKey(id);
                        mpApp.BecomeUnavailable(list, false);
                        isEnteringNotReadyState = true;
                        mCancel.Visible=true;
                    }
                    catch (Exception pError)
                    {
                        relogin(pError.Message);
                    }
                }
            }
        }
        private void mCancel_Click(object sender, EventArgs e)
        {

            try
            {
                mpApp.BecomeUnavailableCancel();
                mCancel.Visible = false;
                mReady2.Visible=false;
                mnIdle.Visible = true; 
                mnIdle.Enabled=false;
                isEnteringNotReadyState=false;
            }
            catch { }
        }

        private void createMenu()
        {
            //logout
            for (int i = 0; i < mpApp.LogoutReasons.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem() { Name = "LOGOUT#"+mpApp.LogoutReasons[i].Id.ToString(), Text = mpApp.LogoutReasons[i].Description, Tag = mpApp.LogoutReasons[i].Description };
                newItem.Click += new EventHandler(this.menu_Click); ;
                mLogout.DropDownItems.Add(newItem);
            }
            for (int i = 0; i < mpApp.NotReadyReasons.Count; i++)
            {
                ToolStripMenuItem newItem = new ToolStripMenuItem() { Name = "NOTREADY#" + mpApp.NotReadyReasons[i].Id.ToString(), Text = mpApp.NotReadyReasons[i].Description, Tag = mpApp.NotReadyReasons[i].Description };
                newItem.Click += new EventHandler(this.menu_Click); ;
                mnReady.DropDownItems.Add(newItem);
            }
            
        }
        private void LoadChatWindow()
        {
            FChat pChatWindow;

            try
            {
                //Show the chat dialog associated with the current chat call
                if (moCallWindows.ContainsKey(mpApp.CurrentCall.CallID))
                    pChatWindow = (FChat)moCallWindows[mpApp.CurrentCall.CallID];
                else
                {
                    pChatWindow = new FChat(mpApp, (CCallChat)mpApp.CurrentCall);
                    moCallWindows.Add(mpApp.CurrentCall.CallID, pChatWindow);
                }

                pChatWindow.Show(this);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        private void UnloadChatWindow()
        {
            FChat pChatWindow;
            
            try
            {
                //Show the chat dialog associated with the current chat call
                if (moCallWindows.ContainsKey(mpApp.CurrentCall.CallID))
                {
                    pChatWindow = (FChat)moCallWindows[mpApp.CurrentCall.CallID];
            
                    moCallWindows.Remove(mpApp.CurrentCall.CallID);

                    pChatWindow.Close();
                }
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        public void CApp_LoggedIn(Object pSender)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new LoggedInHandler(this.CApp_LoggedIn), new Object[] { pSender });
                return;
            }

            //Clear any message remaining on the toolbar
            ClearMessage();
        }

  //      private void mpUnloadTimer_Fire(Object state)
		//{
  //          if (this.InvokeRequired)
  //          {
  //              this.Invoke(new System.Threading.TimerCallback(this.mpUnloadTimer_Fire), new Object[] { state });
  //              return;
  //          }

  //          //If there are no messages being shown, close the form. Otherwise, wait.
  //          if (mpMessageTimer == null)
  //          {
  //              mpUnloadTimer.Dispose();
  //              mpUnloadTimer = null;
  //              this.Close();
  //          }
		//}
        
        //Toolbar's hangup and hold commands should reflect state of FirstParty call
        public void CApp_CallStateChange(Object pSender, CCallStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new CallStateChangeHandler(this.CApp_CallStateChange), new Object[] { pSender, pArgs });
                return;
            }
            this.stateTimeElapsed = DateTime.UtcNow;
            ResetRestartTimer(pArgs.NewState.Id);
            //This is the main thread. Update the UI.
            if (pArgs.Call is C3WayCall1stParty)
            {
                btnHold.Enabled = pArgs.Call.CurrentState.EnableHold;
                btnHangup.Enabled = pArgs.Call.CurrentState.EnableHangup;
                btnDialNum.Enabled = pArgs.Call.CurrentState.EnableHangup;
                //btnHold.Text = (pArgs.Call.CurrentState is CStateHeld ? "Pick Up" : "Hold");

                if (btnHangup.Enabled)
                {
                    buttonDial(true);
                }
            }
        }
        public int seconds = 0;
        private int inWrapSecs = 0;
        private int WrapAction = 0;
        private DateTime stateTimeElapsed;
        private DateTime totalTimeElapsed;
        private bool isStatusDurationTimerStopped = false;
        private string calltime;
        private string statetime;
        public DispatcherTimer StatusDurationTimer = (DispatcherTimer)null;
        public DispatcherTimer StatusDurationTimer1 = (DispatcherTimer)null;
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
                //case AgentStateId.asDISPOSED:
                //    string xx = "";
                //    break;
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
        public void CApp_Screenpop(Object pSender, CScreenpopArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ScreenpopHandler(this.CApp_Screenpop), new object[] { pSender, pArgs });
                return;
            }
            this.stateTimeElapsed = DateTime.UtcNow;
            this.totalTimeElapsed = DateTime.UtcNow;
            this.isStatusDurationTimerStopped = false;
            this.StatusDurationTimer.IsEnabled = true;
            txtdial.Enabled = false;
            FCallData obj = (FCallData)System.Windows.Forms.Application.OpenForms["FCallData"];
            if (obj != null)
                obj.Close();
            bool posisiY = true;
            if(this.Location.Y >100) 
                posisiY=false;
            FCallData oCallDataForm = new FCallData(pArgs.Call, mpApp, this.Location.Y + this.Height + 2, this.Width, posisiY);
            //oCallDataForm.ItemChanged += new FCallData.ItemChangedHandler(ShowItem);
            oCallDataForm.ItemChangedphone += new FCallData.ItemChangedHandlerPhone(ShowItemPhone);
            //oCallDataForm.ItemChangedMesage += new FCallData.ItemChangedHandlerMessage(ShowItemMessage);
            mpCall = pArgs.Call;
            mpCallPrev = pArgs.Call;
            lblDNIS.Text = mpCall.Dnis.ToString();
            lblANIS.Text = mpCall.UserDefinedItems[0].value;
            txtdial.Text = mpCall.PhoneNumber.ToString();
            oCallDataForm.Show();
        }
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
        public void DisplayTimeEvent(object sender, EventArgs e)
        {
            try
            {
                //if (mpApp.isRunningFromCMDLine)
                //    this.seconds += 5;
                //else
                ++seconds;
                DateTime utcNow = DateTime.UtcNow;
                TimeSpan duration1 = utcNow - this.totalTimeElapsed;
                TimeSpan duration2 = utcNow - this.stateTimeElapsed;
                if (!this.isStatusDurationTimerStopped)
                {
                    this.calltime = this.IncrementTime(duration1);
                    this.statetime = this.IncrementTime(duration2);
                }
                textBoxCallTime.Text = calltime;
                textBoxStateTime.Text = statetime;
            }
            catch (Exception ex)
            {
                //CallDataControl.Log.LogException(ex, MethodBase.GetCurrentMethod().Name, (string)null, false);
            }
        }
        public void CApp_PhoneStatus(Object pSender, CPhoneStatusArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new PhoneStatusHandler(this.CApp_PhoneStatus), new object[] { pSender, pArgs });
                return;
            }

            if (pArgs.Connected)
            {
                lblPhoneStatus.BackColor = Color.LimeGreen;
                this.lblPhoneStatusToolTip.SetToolTip(this.lblPhoneStatus, "Phone Connected");
            }
            else
            {
                lblPhoneStatus.BackColor = Color.Red;
                lblPhoneStatusToolTip.SetToolTip(this.lblPhoneStatus, "Phone Disconnected");
            }
        }
        private AgentStateId previousState = AgentStateId.asLOGGED_OUT;
        public void CApp_Error(Object pSender, CErrorArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ErrorHandler(this.CApp_Error), new object[] { pSender, pArgs });
                return;
            }
            if (pArgs.Code == ErrorId.errCallInProgress)
            {
                //if (previousState == AgentStateId.asAUTHENTICATED)
                //{
                    this.isCallinProgress = true;
                    isSessionExists = true;
                    try
                    {
 //                       MessageBox.Show("CApp_Error", "Header", MessageBoxButtons.OK, MessageBoxIcon.None,
 //MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                        //this.mpApp.Logout_Id(0);
                        ProcessCallInProgress();
                    }
                    catch (Exception e) { }
                //}
            }
            else
            //Display error
            DisplayMessageForm(" " + pArgs.Description.Replace("<error>", "").Trim());
            //DisplayMessage(" " + pArgs.Description.Replace("<error>", "").Trim() , true);
        }

		public void CApp_Passcode(Object pSender, CPasscodeArgs pArgs)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new PasscodeHandler(this.CApp_Passcode), new Object[]{pSender, pArgs}) ;
				return;
			}
			
			if (pArgs.Valid)
                DisplayMessageForm("Enter passcode " + pArgs.Passcode);
            //DisplayMessage("Enter passcode " + pArgs.Passcode, false);
			else
                DisplayMessageForm("Invalid passcode. Enter passcode " + pArgs.Passcode);
            //DisplayMessage("Invalid passcode. Enter passcode " + pArgs.Passcode, false);
		}

		public void CApp_LogoutPending(Object pSender)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new LogoutPendingHandler(this.CApp_LogoutPending), new Object[]{pSender}) ;
				return;
			}
            mCancelLogout.Visible = true;
            isPendingLogout = true;
            //DisplayMessage("End the current call to log out",true);
            DisplayMessageForm("End the current call to log out");

            //FMessage oMsgForm = new FMessage("Terminate the current call to log out", -1);
            //oMsgForm.Show();
        }

		private void DisplayMessage(String sMsg, Boolean bTimeout)
		{

            try
            {
                if (lblMessage.InvokeRequired)
                {
                    lblMessage.Invoke((System.Windows.Forms.MethodInvoker)delegate
                    {
                        lblMessage.Text = sMsg;
                    });
                }
                else
                {
                    lblMessage.Text = sMsg;
                }
			    lblMessage.Visible = true;
                picInfo.Visible = true;

                if (bTimeout)
				{
                    //Reset the timer if already exists
                    if (mpMessageTimer != null)
                        mpMessageTimer.Change(6000,System.Threading.Timeout.Infinite);
                    
                    //Otherwise, set the timer for display of error
                    else
                    {
                        System.Threading.TimerCallback timerDelegate = new System.Threading.TimerCallback(mpMessageTimer_Fire);
					    mpMessageTimer = new System.Threading.Timer(timerDelegate,this,6000,System.Threading.Timeout.Infinite);
				    }
                }
                else if(!bTimeout && mpMessageTimer != null)
                {
                    mpMessageTimer.Dispose();
                    mpMessageTimer = null;
                }

			}
			catch(Exception pError)
			{
				Console.WriteLine(pError.StackTrace);
			}
		}
      
        private void mpMessageTimer_Fire(Object state)
		{
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Threading.TimerCallback(this.mpMessageTimer_Fire), new Object[] { state });
                return;
            }

            ClearMessage();
	    }
        
        private void ClearMessage()
        {
            if (mpMessageTimer != null)
			{
				mpMessageTimer.Dispose();
				mpMessageTimer = null;
			}
            picInfo.Visible = false;
            lblMessage.Visible = false;
		}

		private void btnLogout_Click(object sender, System.EventArgs e)
		{
			try
			{
				FList LogoutForm = new FList(mpApp, mpApp.LogoutReasons);
				LogoutForm.Text = "Choose a Logout Reason";
				if (LogoutForm.ShowDialog() == DialogResult.OK)
					mpApp.Logout((CLogoutReason)LogoutForm.SelectedItem);

			}
			catch(Exception pError)
			{
				MessageBox.Show(pError.Message);
			}
		}

		private void btnReady_Click(object sender, System.EventArgs e)
		{
			try
			{
				mpApp.TakeCalls();
				btnReady.Visible = false;
				pnlState.Visible = true;
			}
			catch(Exception pError)
			{
                if (pError.Message.Contains("Session already exists"))
                {
                    //if (UADMessageBox.ShowBox((string)System.Windows.Application.Current.Resources[(object)"MB-AgentAlreadyLoggedIn1"], (string)System.Windows.Application.Current.Resources[(object)"MB-AgentAlreadyLoggedIn2"], UADMessageBoxButton.YesNo, UADMessageBoxImage.Information) == UADMessageBoxReturnValue.Yes)
                    //{
                    //    this.isSessionExists = true;
                    //    MainToolbarWindow.Log.DebugFormat("Error: Session Exist... " + this.isSessionExists.ToString());
                    //    this.mpProcessCallInProgressTimer = new System.Threading.Timer(new TimerCallback(this.ProcessCallInProgress), (object)null, 100, -1);
                    //}
                    //else
                    //{
                    //    this.userInitiatedClose = true;
                    //    this.Close();
                    //}
                }
                MessageBox.Show(pError.Message);
			}
		}

		private void btnHangup_Click(object sender, System.EventArgs e)
		{
			try
			{
                txtdial.Enabled = true;
                mpApp.Hangup(mpApp.CurrentCall);
                buttonDial(false);

            }
			catch(Exception pError)
			    {
                relogin(pError.Message);
            }
		}

		private void btnNextCall_Click(object sender, System.EventArgs e)
		{
			//If current call requires a disposition, prompt user for one
			CDisposition pDisp = null;

			if (mpApp.CurrentService.RequireDisposition)
			{
				//TODO: If not allowed to schedule a callback, remove callback dispositions from selection list
				//TODO: If not allowed to set an exclusion, remove exclusion dispositions from selection list

				FList oDispositionsForm = new FList(mpApp, mpApp.CurrentService.DispositionPlan.Dispositions);
				oDispositionsForm.Text = "Select a disposition";
				oDispositionsForm.ShowDialog();

				if (oDispositionsForm.DialogResult != DialogResult.OK)
					return;

				pDisp = (CDisposition)oDispositionsForm.SelectedItem;

				//TODO: If selected disposition is a callback then have user request a callback
				//TODO: If selected disposition is an exclusion then have user request an exclusion
			}
			
			try
			{
                mpApp.DisposeCall(mpApp.CurrentCall, pDisp);
			}
			catch(Exception pError)
			{
				MessageBox.Show(pError.Message);
			}
		}
     

        private void btnDial_Click(object sender, System.EventArgs e)
		{
            int iServiceId = 0;
            int iExternalRouteId = 0;
            txtdial.Enabled = true;

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
                        lblDNIS.Text = pFormDial.PhoneNumber;
                    }
                    catch (Exception pError)
                    {
                        relogin(pError.Message);
                    }
                }
                //Otherwise(dialing a user)...
                else if (pFormDial.SelectedItem is CUser)
                {
                    try
                    {
                        mpApp.Dial(((CUser)pFormDial.SelectedItem).Id);
                        lblDNIS.Text = ((CUser)pFormDial.SelectedItem).Id;
                    }
                    catch (Exception pError)
                    {
                        relogin(pError.Message);
                    }
                }
            }
            else {

                try
                {
                    mpApp.Dial(txtdial.Text,mpCall.ServiceID, iExternalRouteId);
                    lblDNIS.Text = txtdial.Text;
                }
                catch (Exception pError)
                {
                    relogin(pError.Message);
               
                }
            }
        }

		private void btnHold_Click(object sender, System.EventArgs e)
		{
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            try
            {
                if (mpApp.CurrentCall.CurrentState is CStateHeld)
                {
                    mpApp.ReleaseHold();
                    ToolTip1.SetToolTip(btnHold, "Hold");
                }
                else
                {
                    mpApp.Hold();

                    ToolTip1.SetToolTip(btnHold, "Retrieve");
                   

                }
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
		}

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.BecomeAvailable();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }

        }

        private void btnUnavailable_Click(object sender, EventArgs e)
        {
            try
            {
                FList NotReadyForm = new FList(mpApp, mpApp.NotReadyReasons,null,true,mpApp.CurrentAgent.AllowPark,"Park");
                NotReadyForm.Text = "Choose a NotReady Reason";
                if (NotReadyForm.ShowDialog() == DialogResult.OK)
                    mpApp.BecomeUnavailable((CNotReadyReason)NotReadyForm.SelectedItem, NotReadyForm.OptionIsChecked);

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

        private void button1_Click(object sender, EventArgs e)
        {
            mpApp.StateChange += new StateChangeHandler(this.CApp_StateChange);

            //string cc = mpApp.AssignedServices.GetByKey(C..ServiceID).ServiceName;
        }
        private System.Threading.Timer mpProcessCallInProgressTimer;
        private bool isCallinProgress = false;
        private bool isPortalDown = false;
        private bool isSessionExists = false;
        private bool hasRequestedPanicLogout = false;
        public bool reLoginCompleted = false;
        private void mnIdle_Click(object sender, EventArgs e)
        {
            try
            {
                this.mpApp.InitialAgentState = InitialAgentStateId.iasIDLE;
                mpApp.TakeCalls();
            }
            catch (Exception pError)
            {
                if (pError.Message.Contains("Session already exists"))
                {
                    if (MessageBox.Show("Agent is already logged into this portal, Do you want to panic logout that agent?", "Agent Already Logged In", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    { 
                        this.isSessionExists = true;
                       ProcessCallInProgress();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }
        }
         private void ProcessCallInProgress()
        {

            if (this.InvokeRequired) // Check if the call is from a different thread
            {
                // If so, invoke this method on the UI thread
                this.Invoke(new CloseFormDelegate(ProcessCallInProgress));
            }
            else
            {
                try
                {
                    //if (this.mpProcessCallInProgressTimer != null)
                    //{
                    //    this.mpProcessCallInProgressTimer.Dispose();
                    //    this.mpProcessCallInProgressTimer = (System.Threading.Timer)null;
                    //}
                    string txtMessage = "Attention: The system has detected that your user ID may already be logged in to an existing session and may have an active call in progress. You may continue to login and any active calls will be immediately terminated or you may wait to login until the current call is complete (do not click the OK button until you have completed the current call). Do you wish to continue to login and terminate any active calls?";
                    if (this.isCallinProgress && isSessionExists)
                    {
                        //MessageBox.Show("ProcessCallInProgress-isCallinProgress && isSessionExists", "", MessageBoxButtons.OK,
                        //     MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                        this.mpApp.Logout_Id(0);
                    }
                    else if (MessageBox.Show(txtMessage, "Portal/CenterCord error message", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (this.isCallinProgress)
                        {
                            //MessageBox.Show("ProcessCallInProgress-isCallinProgress", "",MessageBoxButtons.OK,
                            //    MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                            this.mpApp.Logout_Id(0);
                        }
                        else if (this.isPortalDown || this.isSessionExists)
                        {
                            //MessageBox.Show("ProcessCallInProgress-isSessionExists", "", MessageBoxButtons.OK,
                            //   MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
                            this.hasRequestedPanicLogout = true;
                            this.mpApp.Logout_Id(-1);
                           
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        private void mReady2_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.BecomeAvailable();
                mReady2.Visible = false;
               
            }
            catch (Exception pError)
            {
                relogin(pError.Message);
            }
        }
        private void relogin(string pError) {
            if (pError.Contains("Could not acquire agent object"))
            {
                if (MessageBox.Show("Could not acquire agent object, Do you want to re-Login?", "Re-Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    mReady2.Visible = false;
                    mCancelLogout.Visible = false;
                    this.isSessionExists = true;
                    lblState.Text = "Logging In";
                    ProcessCallInProgress_Login();
                }
                else
                {
                    this.Close();
                }
            }
            else
                MessageBox.Show(pError);
        }
        private void mCancelLogout_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.CancelLogOut();
                mCancelLogout.Visible = false;
                isPendingLogout=false;
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);

            }   
        }
        private void NotReadyParkTimeClick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.UtcNow - this.notReadyParkElapsedTime;
            int num = timeSpan.Hours;
            string str1 = num.ToString() ?? "";
            if (str1.Length == 1)
                str1 = "0" + str1;
            num = timeSpan.Minutes;
            string str2 = num.ToString() ?? "";
            if (str2.Length == 1)
                str2 = "0" + str2;
            num = timeSpan.Seconds;
            string str3 = num.ToString() ?? "";
            if (str3.Length == 1)
                str3 = "0" + str3;
            this.textBlockNotReadyParkTimer.Text = str1 + ":" + str2 + ":" + str3;
            int parkAlarmSecs = this.mpApp.CurrentAgent.ParkAlarmSecs;
            //if (timeSpan.TotalSeconds >= (double)parkAlarmSecs && this.mpApp.CurrentState.Id == AgentStateId.asPARKED && parkAlarmSecs > 0)
            //{
            //this.isParkWarning = true;
            //this.changeStateUC.ChangeAgentStateIcon(this.mpApp.CurrentState);
            //this.mpApp.warning(2);
            //}
            //if (!Aspect.UnifiedIP.UAD.PresentationLayer.App.isRunningFromCMDLine && !Aspect.UnifiedIP.UAD.PresentationLayer.App.isRunningFromCMDLineRemoteApp || int.Parse(Aspect.UnifiedIP.UAD.PresentationLayer.App.sCmdLineArgNotReadyTime) <= 0 || timeSpan.Seconds < int.Parse(Aspect.UnifiedIP.UAD.PresentationLayer.App.sCmdLineArgNotReadyTime))
            //    return;
            //this.goAvailable();
        }
        public void StopNotReadyParkTimer()
        {
            if (!this.notReadyParkTimer.IsEnabled)
                return;
            this.notReadyParkTimer.Stop();
            //this.isParkWarning = false;
            this.ShowHideParkTimer(false);
        }
        private void ShowHideParkTimer(bool value)
        {
            this.textBlockNotReadyParkTimer.Visible = value;
            //if (this.LastNotReadyParkReason != null && this.LastNotReadyParkReason != "" && value)
            //    this.txtReason.Visibility = Visibility.Visible;
            //else
            //    this.txtReason.Visibility = Visibility.Collapsed;
        }
        private void StartNotReadyParkTimer()
        {
            if (this.notReadyParkTimer.IsEnabled)
                return;
            this.notReadyParkTimer.Start();
            Thread.Sleep(1000);
            this.textBlockNotReadyParkTimer.Visible = true;
            //if (this.LastNotReadyParkReason == null || !(this.LastNotReadyParkReason != ""))
            //    return;
            //this.txtReason.Visibility = Visibility.Visible;
        }
       
        private void showdetail(object sender, EventArgs e)
        {
            
            if (mpCallPrev != null)
            {
                FCallData obj = (FCallData)System.Windows.Forms.Application.OpenForms["FCallData"];
                 if (obj == null)
                {

                    this.stateTimeElapsed = DateTime.UtcNow;
                    this.totalTimeElapsed = DateTime.UtcNow;
                    this.isStatusDurationTimerStopped = false;
                    this.StatusDurationTimer.IsEnabled = true;
                    bool posisiY = true;
                    if (this.Location.Y > 100)
                        posisiY = false;
                    FCallData oCallDataForm = new FCallData(mpCallPrev, mpApp, this.Location.Y + this.Height + 2,this.Width, posisiY);
                    //oCallDataForm.ItemChanged += new FCallData.ItemChangedHandler(ShowItem);
                    oCallDataForm.ItemChangedphone += new FCallData.ItemChangedHandlerPhone(ShowItemPhone);
                    //oCallDataForm.ItemChangedMesage += new FCallData.ItemChangedHandlerMessage(ShowItemMessage);

                    //CState pNewState = mpApp.CurrentState;
                    //if (pNewState.Id != AgentStateId.asACTIVE)
                    //{
                    //    lblDNIS.Text = mpCall.Dnis.ToString();
                    //    lblANIS.Text = mpCall.UserDefinedItems[0].value;
                    //    txtdial.Text = mpCall.PhoneNumber.ToString();
                    //}
                    oCallDataForm.Show();
                }
            }

        }
        
        private void txtPortal_Leave(object sender, EventArgs e)
        {
            spinner1.Show();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
                backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
                                                 backgroundWorker1_RunWorkerCompleted);
            }
            backgroundWorker1.RunWorkerAsync(100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                FNumDial obj = (FNumDial)System.Windows.Forms.Application.OpenForms["FNumDial"];
                if (obj != null)
                    obj.Close();
                FNumDial fNumDial = new FNumDial(mpApp);
                fNumDial.Show();

            }
            catch (Exception pError) { relogin(pError.Message); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                AgentInfo oCallDataForm = new AgentInfo(mpApp);
                oCallDataForm.Show();

            }
            catch (Exception pError) { relogin(pError.Message); }
          
        }
    }
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.None,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            System.Windows.Forms.Label textLabel = new System.Windows.Forms.Label() { Left = 50, Top = 20, Text = text };
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox() { Left = 50, Top = 50, Width = 400 };
            System.Windows.Forms.Button confirmation = new System.Windows.Forms.Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }

}
