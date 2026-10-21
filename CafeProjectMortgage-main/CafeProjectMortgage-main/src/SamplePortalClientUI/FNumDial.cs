using Microsoft.VisualBasic.PowerPacks;
using SamplePortalClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static SamplePortalClient.CServices;

namespace SamplePortalClient.UI
{

	
	/// <summary>
	/// Summary description for FDial.
	/// </summary>
	public class FNumDial : System.Windows.Forms.Form
	{
		private CApp mpApp;
		private DialMode meMode;
		
		public Object SelectedItem{get{return mpSelectedItem;}}
		//public String PhoneNumber{get{return txtPhoneNumber.Text;}}
		private Object mpSelectedItem;
        private Panel panel1;
        private PictureBox recDialAsterisk;
        private TextBox txtPhoneNumber;
        private PictureBox recDial3;
        private PictureBox recDial6;
        private PictureBox recDial9;
        private PictureBox recDialPound;
        private PictureBox recDial2;
        private PictureBox recDial5;
        private PictureBox recDial8;
        private PictureBox recDial0;
        private PictureBox recDial1;
        private PictureBox recDial4;
        private PictureBox recDial7;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public FNumDial(CApp pApp)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            mpApp = pApp;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.recDial3 = new System.Windows.Forms.PictureBox();
            this.recDial6 = new System.Windows.Forms.PictureBox();
            this.recDial9 = new System.Windows.Forms.PictureBox();
            this.recDialPound = new System.Windows.Forms.PictureBox();
            this.recDial2 = new System.Windows.Forms.PictureBox();
            this.recDial5 = new System.Windows.Forms.PictureBox();
            this.recDial8 = new System.Windows.Forms.PictureBox();
            this.recDial0 = new System.Windows.Forms.PictureBox();
            this.recDial1 = new System.Windows.Forms.PictureBox();
            this.recDial4 = new System.Windows.Forms.PictureBox();
            this.recDial7 = new System.Windows.Forms.PictureBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.recDialAsterisk = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recDial3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDialPound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDialAsterisk)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.recDial3);
            this.panel1.Controls.Add(this.recDial6);
            this.panel1.Controls.Add(this.recDial9);
            this.panel1.Controls.Add(this.recDialPound);
            this.panel1.Controls.Add(this.recDial2);
            this.panel1.Controls.Add(this.recDial5);
            this.panel1.Controls.Add(this.recDial8);
            this.panel1.Controls.Add(this.recDial0);
            this.panel1.Controls.Add(this.recDial1);
            this.panel1.Controls.Add(this.recDial4);
            this.panel1.Controls.Add(this.recDial7);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.recDialAsterisk);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 208);
            this.panel1.TabIndex = 1;
            // 
            // recDial3
            // 
            this.recDial3.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._3;
            this.recDial3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial3.Location = new System.Drawing.Point(163, 46);
            this.recDial3.Name = "recDial3";
            this.recDial3.Size = new System.Drawing.Size(69, 35);
            this.recDial3.TabIndex = 13;
            this.recDial3.TabStop = false;
            this.recDial3.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial6
            // 
            this.recDial6.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._6;
            this.recDial6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial6.Location = new System.Drawing.Point(163, 85);
            this.recDial6.Name = "recDial6";
            this.recDial6.Size = new System.Drawing.Size(69, 35);
            this.recDial6.TabIndex = 12;
            this.recDial6.TabStop = false;
            this.recDial6.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial9
            // 
            this.recDial9.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._9;
            this.recDial9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial9.Location = new System.Drawing.Point(163, 125);
            this.recDial9.Name = "recDial9";
            this.recDial9.Size = new System.Drawing.Size(69, 34);
            this.recDial9.TabIndex = 11;
            this.recDial9.TabStop = false;
            this.recDial9.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDialPound
            // 
            this.recDialPound.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.kres;
            this.recDialPound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDialPound.Location = new System.Drawing.Point(163, 164);
            this.recDialPound.Name = "recDialPound";
            this.recDialPound.Size = new System.Drawing.Size(69, 35);
            this.recDialPound.TabIndex = 10;
            this.recDialPound.TabStop = false;
            this.recDialPound.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial2
            // 
            this.recDial2.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._2;
            this.recDial2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial2.Location = new System.Drawing.Point(88, 46);
            this.recDial2.Name = "recDial2";
            this.recDial2.Size = new System.Drawing.Size(70, 35);
            this.recDial2.TabIndex = 9;
            this.recDial2.TabStop = false;
            this.recDial2.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial5
            // 
            this.recDial5.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._5;
            this.recDial5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial5.Location = new System.Drawing.Point(88, 85);
            this.recDial5.Name = "recDial5";
            this.recDial5.Size = new System.Drawing.Size(70, 35);
            this.recDial5.TabIndex = 8;
            this.recDial5.TabStop = false;
            this.recDial5.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial8
            // 
            this.recDial8.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._8;
            this.recDial8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial8.Location = new System.Drawing.Point(88, 125);
            this.recDial8.Name = "recDial8";
            this.recDial8.Size = new System.Drawing.Size(70, 34);
            this.recDial8.TabIndex = 7;
            this.recDial8.TabStop = false;
            this.recDial8.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial0
            // 
            this.recDial0.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._0;
            this.recDial0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial0.Location = new System.Drawing.Point(88, 164);
            this.recDial0.Name = "recDial0";
            this.recDial0.Size = new System.Drawing.Size(70, 35);
            this.recDial0.TabIndex = 6;
            this.recDial0.TabStop = false;
            this.recDial0.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial1
            // 
            this.recDial1.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._1;
            this.recDial1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial1.Location = new System.Drawing.Point(14, 46);
            this.recDial1.Name = "recDial1";
            this.recDial1.Size = new System.Drawing.Size(70, 35);
            this.recDial1.TabIndex = 5;
            this.recDial1.TabStop = false;
            this.recDial1.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial4
            // 
            this.recDial4.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._4;
            this.recDial4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial4.Location = new System.Drawing.Point(14, 85);
            this.recDial4.Name = "recDial4";
            this.recDial4.Size = new System.Drawing.Size(70, 35);
            this.recDial4.TabIndex = 4;
            this.recDial4.TabStop = false;
            this.recDial4.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // recDial7
            // 
            this.recDial7.BackgroundImage = global::SamplePortalClientUI.Properties.Resources._7;
            this.recDial7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDial7.Location = new System.Drawing.Point(14, 125);
            this.recDial7.Name = "recDial7";
            this.recDial7.Size = new System.Drawing.Size(70, 34);
            this.recDial7.TabIndex = 2;
            this.recDial7.TabStop = false;
            this.recDial7.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(12, 13);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(220, 28);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // recDialAsterisk
            // 
            this.recDialAsterisk.BackgroundImage = global::SamplePortalClientUI.Properties.Resources.asterik1;
            this.recDialAsterisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recDialAsterisk.Location = new System.Drawing.Point(14, 164);
            this.recDialAsterisk.Name = "recDialAsterisk";
            this.recDialAsterisk.Size = new System.Drawing.Size(70, 35);
            this.recDialAsterisk.TabIndex = 0;
            this.recDialAsterisk.TabStop = false;
            this.recDialAsterisk.Click += new System.EventHandler(this.dial_OnClick);
            // 
            // FNumDial
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(278, 240);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FNumDial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NumPad";
            this.Load += new System.EventHandler(this.FNumDial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recDial3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDialPound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDial7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recDialAsterisk)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion
        private void SendDigitsToCC(string digits)
        {
            this.mpApp.PlayDigits(new DigitData()
            {
                CallId = this.mpApp.CurrentCall.CallID,
                Digits = digits
            });
        }
        private List<KeypadKey> allKeys = new List<KeypadKey>();    
        private void FNumDial_Load(object sender, System.EventArgs e)
		{
            //mpApp.CallActivated += new CallActivatedHandler(this.CApp_CallActivated);

            this.txtPhoneNumber.KeyDown += keyPadTxt_KeyDown;
            this.txtPhoneNumber.TextChanged += keyPadTxt_TextChanged;
            this.txtPhoneNumber.KeyDown += keyPadTxt_KeyDown;
            //this.txtPhoneNumber.PreviewTextInput += new TextCompositionEventHandler(this.keyPadTxt_PreviewTextInput);
            //this.txtPhoneNumber.PreviewKeyDown += new KeyEventHandler(this.keyPadTxt_PreviewKeyDown);
            //         //If first party dial or 3rd party dial, load and show externals; otherwise, hide them.
            //if (meMode == DialMode.dm1stParty || meMode == DialMode.dm3rdParty)
            //	//Load external routes
            //	LoadExternalRoutes();
            //         else
            //             //Hide doesn't seem to work so remove the page from the tab control.
            //             //tabExternalRoutes.Hide();
            //             tabControl1.TabPages.Remove(tabExternalRoutes);


            //         //If current call is a preview, init the PhoneNumber field based on the call's settings.
            //         if (mpApp.CurrentCall != null && mpApp.CurrentCall.CurrentState is CStatePreview)
            //         {
            //             txtPhoneNumber.Text = mpApp.CurrentCall.PhoneNumber;
            //             txtPhoneNumber.Enabled = ((CServiceAOD)mpApp.CurrentService).AllowPreviewNumberChange;
            //         }


            //         //For all dial modes, load and show agents
            //         //If current user is allowed to dial agents, load them; otherwise, hide them.
            //         if ((mpApp.CurrentService.DialMask & (int)DialMaskBits.Agent) == (int)DialMaskBits.Agent)
            //             LoadAgents();
            //         else
            //             //tabAgents.Hide();
            //             tabControl1.TabPages.Remove(tabAgents);


            //         //For all dial modes, load and show supervisors
            //         //If current user is allowed to dial supervisors, load them; otherwise, hide them.
            //         if ((mpApp.CurrentService.DialMask & (int)DialMaskBits.Supervisor) == (int)DialMaskBits.Supervisor)
            //             LoadSupervisors();
            //         else
            //             //tabSupervisors.Hide();
            //             tabControl1.TabPages.Remove(tabSupervisors);


            ////If third party mode or chat xfer mode, load and show services; otherwise, hide them.
            //         if (meMode == DialMode.dm3rdParty || meMode == DialMode.dmChatXfer)
            //             LoadServices();
            //         else
            //             tabControl1.TabPages.Remove(tabServices);


            //         //Select the first tab
            ////tabControl1.SelectedTab = tabExternalRoutes;
            //         tabControl1.SelectedIndex = 0;
        }

        public void CApp_CallActivated(Object pSender, CCallActivatedArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new CallActivatedHandler(this.CApp_CallActivated), new Object[] { pSender, pArgs });
                return;
            }

            this.Close();
        }

        private bool IsActiveCall()
        {
            return this.mpApp.CurrentCall != null && (this.mpApp.CurrentState.Id == AgentStateId.asACTIVE || this.mpApp.CurrentState.Id == AgentStateId.asACTIVE_INTERNAL);
        }
        private void dial_OnClick(object sender, EventArgs e)
        {
            this.txtPhoneNumber.Font = new Font("Arial Rounded MT Bold", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.txtPhoneNumber.ForeColor = Color.Black;
            try
            {
                this.myAddValue(((PictureBox)sender).Name);
            }
            catch
            {
                this.myAddValue(((PictureBox)sender).Name);
            }
            txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
            txtPhoneNumber.SelectionLength = 0; // No text selected
        }

        private void keyPadTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return || e.KeyCode == Keys.Back)
            {
                e.Handled = true;
            }

        }
        private void keyPadTxt_TextChanged(object sender, EventArgs e)
        {
            string text = this.txtPhoneNumber.Text;
            try {
                if (txtPhoneNumber.Text != "") {
                    string digits = this.CleanText(text.Substring(text.Length - 1, 1));
                    string digits1 = this.CleanText(text.Substring(0, text.Length - 1));
                    string str;
                    if (this.IsActiveCall())
                    {
                        this.SendDigitsToCC(digits);
                    }
                    str = digits1 + digits;
                    txtPhoneNumber.Text = str;
                    txtPhoneNumber.SelectionStart = txtPhoneNumber.Text.Length;
                    txtPhoneNumber.SelectionLength = 0; // No text selected
                    if (!this.IsActiveCall())
                        return;
                }
            }
            catch { }
            
        }

        private string CleanText(string newTxt)
        {
            newTxt = this.RemoveUnwantedChars(newTxt);
            newTxt = this.ReplaceAlphabets(newTxt);
            return newTxt;
        }

        private string RemoveUnwantedChars(string newTxt)
        {
            Regex regex = new Regex("[0-9a-zA-Z#*]+");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in newTxt.ToCharArray())
            {
                if (regex.IsMatch(ch.ToString()))
                    stringBuilder.Append(ch.ToString());
            }
            return stringBuilder.ToString();
        }

        private string ReplaceAlphabets(string newTxt)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in newTxt.ToCharArray())
            {
                switch (ch.ToString().ToLower())
                {
                    case "a":
                    case "b":
                    case "c":
                        stringBuilder.Append("2");
                        break;
                    case "d":
                    case "e":
                    case "f":
                        stringBuilder.Append("3");
                        break;
                    case "g":
                    case "h":
                    case "i":
                        stringBuilder.Append("4");
                        break;
                    case "j":
                    case "k":
                    case "l":
                        stringBuilder.Append("5");
                        break;
                    case "m":
                    case "n":
                    case "o":
                        stringBuilder.Append("6");
                        break;
                    case "p":
                    case "q":
                    case "r":
                    case "s":
                        stringBuilder.Append("7");
                        break;
                    case "t":
                    case "u":
                    case "v":
                        stringBuilder.Append("8");
                        break;
                    case "w":
                    case "x":
                    case "y":
                    case "z":
                        stringBuilder.Append("9");
                        break;
                    default:
                        stringBuilder.Append(ch.ToString());
                        break;
                }
            }
            return stringBuilder.ToString();
        }
        private void myAddValue(string value)
        {
            //if (this.IsActiveCall() || this.mpApp.CurrentState.Id == AgentStateId.asDIALING)
            //    this.SendDigitsToCC(value.Substring(value.Length - 1));
            switch (value.Substring(value.Length - 1))
            {
                case "0":
                    this.txtPhoneNumber.Text += "0";
                    break;
                case "1":
                    this.txtPhoneNumber.Text += "1";
                    break;
                case "2":
                    this.txtPhoneNumber.Text += "2";
                    break;
                case "3":
                    this.txtPhoneNumber.Text += "3";
                    break;
                case "4":
                    this.txtPhoneNumber.Text += "4";
                    break;
                case "5":
                    this.txtPhoneNumber.Text += "5";
                    break;
                case "6":
                    this.txtPhoneNumber.Text += "6";
                    break;
                case "7":
                    this.txtPhoneNumber.Text += "7";
                    break;
                case "8":
                    this.txtPhoneNumber.Text += "8";
                    break;
                case "9":
                    this.txtPhoneNumber.Text += "9";
                    break;
                default:
                    if (value.Contains("Asterisk"))
                    {
                        this.txtPhoneNumber.Text += "*";
                        break;
                    }
                    this.txtPhoneNumber.Text += "#";
                    break;
            }
        }
        private void CreateAllKeys()
        {
            try
            {
                this.allKeys.Add(new KeypadKey("1", ""));
                this.allKeys.Add(new KeypadKey("2", "ABC"));
                this.allKeys.Add(new KeypadKey("3", "DEF"));
                this.allKeys.Add(new KeypadKey("4", "GHI"));
                this.allKeys.Add(new KeypadKey("5", "JKL"));
                this.allKeys.Add(new KeypadKey("6", "MNO"));
                this.allKeys.Add(new KeypadKey("7", "PQRS"));
                this.allKeys.Add(new KeypadKey("8", "TUV"));
                this.allKeys.Add(new KeypadKey("9", "WXYZ"));
                this.allKeys.Add(new KeypadKey("*", ""));
                this.allKeys.Add(new KeypadKey("0", ""));
                this.allKeys.Add(new KeypadKey("#", ""));
            }
            catch (Exception ex)
            {
            }
        }
    }
    public class KeypadKey
    {
        public string NumberContent { get; set; }

        public string StringContent { get; set; }

        public string TagValue { get; set; }

        public KeypadKey(string numberContent, string stringContent)
        {
            this.NumberContent = numberContent;
            this.StringContent = stringContent;
            this.TagValue = numberContent;
        }
    }
}
