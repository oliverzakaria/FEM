using com.aspect.unifiedip.tools;
using GradientPanel;
using SamplePortalClient;
using SamplePortalClient.EPAgentWSP;
using SamplePortalClientUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;


namespace SamplePortalClient.UI
{
    /// <summary>
    /// Summary description for Login.
    /// </summary>
    public class FLogin : System.Windows.Forms.Form
    {
        private CApp mpApp;
        public static string currentportal = "";
        public static string currentagent;
        private DispatcherTimer notReadyParkTimer = (DispatcherTimer)null;
        private DateTime notReadyParkElapsedTime = DateTime.UtcNow;
        private Label textBlockNotReadyParkTimer;
        private Button button3;
        private Button button2;
        private IniReader ini;
        private Label label1;
        private Label label2;
        private TextBox txtUserID;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel pnlstation;
        private Spinner spinner1;
        private ComboBox cbDomain;
        private TextBox txtPortalData;
        private Label label6;
        private Label label5;
        private TextBox txtPortal;
        private TextBox txtStation;
        private Label label3;
        private Label label4;
        private Button button1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FLogin()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBlockNotReadyParkTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlstation = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.txtPortal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPortalData = new System.Windows.Forms.TextBox();
            this.cbDomain = new System.Windows.Forms.ComboBox();
            this.spinner1 = new Spinner();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlstation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // textBlockNotReadyParkTimer
            // 
            this.textBlockNotReadyParkTimer.Location = new System.Drawing.Point(0, 0);
            this.textBlockNotReadyParkTimer.Name = "textBlockNotReadyParkTimer";
            this.textBlockNotReadyParkTimer.Size = new System.Drawing.Size(100, 23);
            this.textBlockNotReadyParkTimer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(139, 26);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(146, 20);
            this.txtUserID.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(146, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(139, 92);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 23);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlstation
            // 
            this.pnlstation.BackColor = System.Drawing.Color.Transparent;
            this.pnlstation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlstation.Controls.Add(this.spinner1);
            this.pnlstation.Controls.Add(this.cbDomain);
            this.pnlstation.Controls.Add(this.txtPortalData);
            this.pnlstation.Controls.Add(this.label6);
            this.pnlstation.Controls.Add(this.label5);
            this.pnlstation.Controls.Add(this.txtPortal);
            this.pnlstation.Controls.Add(this.txtStation);
            this.pnlstation.Controls.Add(this.label3);
            this.pnlstation.Controls.Add(this.label4);
            this.pnlstation.Location = new System.Drawing.Point(363, 18);
            this.pnlstation.Name = "pnlstation";
            this.pnlstation.Size = new System.Drawing.Size(431, 132);
            this.pnlstation.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Portal Aspect";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Station:";
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(97, 15);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(146, 20);
            this.txtStation.TabIndex = 16;
            this.txtStation.Text = "1030";
            // 
            // txtPortal
            // 
            this.txtPortal.Location = new System.Drawing.Point(97, 43);
            this.txtPortal.Name = "txtPortal";
            this.txtPortal.Size = new System.Drawing.Size(300, 20);
            this.txtPortal.TabIndex = 18;
            this.txtPortal.Text = "core2019.aspect.co.id:8443";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Domain";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Portal Data";
            // 
            // txtPortalData
            // 
            this.txtPortalData.Location = new System.Drawing.Point(97, 94);
            this.txtPortalData.Name = "txtPortalData";
            this.txtPortalData.Size = new System.Drawing.Size(300, 20);
            this.txtPortalData.TabIndex = 20;
            this.txtPortalData.Text = "core2019.aspect.co.id:8443";
            // 
            // cbDomain
            // 
            this.cbDomain.FormattingEnabled = true;
            this.cbDomain.Location = new System.Drawing.Point(97, 67);
            this.cbDomain.Name = "cbDomain";
            this.cbDomain.Size = new System.Drawing.Size(214, 21);
            this.cbDomain.TabIndex = 23;
            // 
            // spinner1
            // 
            this.spinner1.BackColor = System.Drawing.Color.Transparent;
            this.spinner1.Location = new System.Drawing.Point(338, 0);
            this.spinner1.Name = "spinner1";
            this.spinner1.NodeBorderColor = System.Drawing.Color.White;
            this.spinner1.NodeBorderSize = 2;
            this.spinner1.NodeCount = 8;
            this.spinner1.NodeFillColor = System.Drawing.Color.Black;
            this.spinner1.NodeRadius = 4;
            this.spinner1.NodeResizeRatio = 1F;
            this.spinner1.Size = new System.Drawing.Size(114, 108);
            this.spinner1.SpinnerRadius = 100;
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
            this.button1.Location = new System.Drawing.Point(311, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 22;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.header_middle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlstation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserID);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlstation.ResumeLayout(false);
            this.pnlstation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        public static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );
        private string strDomain = "";
        private void Login_Load(object sender, System.EventArgs e)
        {
            pnlstation.Visible = false;
            this.Width = 400;
            ini = new IniReader(System.Windows.Forms.Application.StartupPath + "\\inisetting.ini");
            txtStation.Text= ini.ReadString("aspect", "station", "");
            txtUserID.Text = ini.ReadString("user", "userid", "");
            txtPortal.Text = ini.ReadString("aspect", "portal", "");
            txtPortalData.Text = ini.ReadString("aspect", "urldata", "");
            strDomain = ini.ReadString("aspect", "domain", "");
            if (txtPortal.Text != "") { 
            }
            Cursor = Cursors.WaitCursor;
            while (mpApp == null)
            {
                mpApp = new CApp();
                Thread.Sleep(100);
            }
            Cursor = Cursors.Default;

            if (mpApp == null)
            {
                mpApp = Singleton.Instance.CApp;
            }
            loadDomain();
        }
        private void loadDomain() {
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
            var dict = new Dictionary<string, string>();
            for (int i = 0; i < listDomain.Length; i++)
            {
                dict.Add(listDomain[i], listDomain[i]);
            }
            if (listDomain.Length == 0) {
                dict.Add("0", "Default");
            }
            cbDomain.DataSource = new BindingSource(dict, null);
            cbDomain.DisplayMember = "Value";
            cbDomain.ValueMember = "Key";
            cbDomain.SelectedValue = strDomain;
        }
        public static class TextTool
        {
            /// <summary>
            /// Count occurrences of strings.
            /// </summary>
            public static int CountStringOccurrences(string text, string pattern)
            {
                // Loop through all instances of the string 'text'.
                int count = 0;
                int i = 0;
                while ((i = text.IndexOf(pattern, i)) != -1)
                {
                    i += pattern.Length;
                    count++;
                }
                return count;
            }
        }
       
        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                

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
                //mpApp.Login(this.txtUserID.Text, this.txtPassword.Text, this.txtStation.Text, "asasas" + ":" + appendedport);
                var portal1 = PortalLoadBalancer.LoadBalance(hosts, 35);
                currentportal = portal1;
                //MessageBox.Show(portal1);
                mpApp.Login(this.txtUserID.Text, this.txtPassword.Text, this.txtStation.Text, portal1 + ":" + appendedport, cbDomain.SelectedValue.ToString(), true);
                //MessageBox.Show("After login");
                currentagent = this.txtUserID.Text;

                ini.Write("aspect", "station", txtStation.Text);
                ini.Write("aspect", "portal", txtPortal.Text);
                ini.Write("aspect", "urldata", txtPortalData.Text);
                ini.Write("user", "userid", txtUserID.Text);
                ini.Write("aspect", "domain", cbDomain.SelectedValue.ToString());

                //ini.Write("webservice", "url", "");

                spinner1.Hide();    
                this.Hide();
                if (mpApp.CurrentState is CStateAuthenticated)
                {
                    FToolbar pToolbarForm = new FToolbar();
                    pToolbarForm.ShowDialog();
                }

                if (Singleton.Instance.IsAuthenticated)
                {
                    FToolbar pToolbarForm = new FToolbar();
                    pToolbarForm.ShowDialog();
                } 
                this.Close();
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
                MessageBox.Show(pError.Message, "Login Failed");
            }
        }
        
        //[STAThread]
        //public static void Main()
        //{
        //    Console.WriteLine("Initializing App...");
           
        //    //CApp pApp = Singleton.Instance.CApp;

        //   // Console.WriteLine("CurrentState is " + pApp.CurrentState.GetType());

        //    FLogin pLoginForm = new FLogin();
        //    pLoginForm.ShowDialog();

        //}

        private void expandCollapsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
        bool toggle=false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (toggle) {
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

    }
}
