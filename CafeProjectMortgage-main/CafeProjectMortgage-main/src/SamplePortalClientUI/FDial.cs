using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SamplePortalClient;
using static SamplePortalClient.CServices;

namespace SamplePortalClient.UI
{
	public enum DialMode
	{
		dm1stParty = 1,
		dm3rdParty = 2,
		dmChatXfer = 3
	}
	
	/// <summary>
	/// Summary description for FDial.
	/// </summary>
	public class FDial : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabExternalRoutes;
		private System.Windows.Forms.TabPage tabAgents;
		private System.Windows.Forms.TabPage tabSupervisors;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ListView lvwExternalRoutes;
		private System.Windows.Forms.TextBox txtPhoneNumber;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TabPage tabServices;
		private System.Windows.Forms.ListView lvwAgents;
		private System.Windows.Forms.ListView lvwSupervisors;
		private System.Windows.Forms.ListView lvwServices;
		private CApp mpApp;
		private DialMode meMode;
		
		public Object SelectedItem{get{return mpSelectedItem;}}
		public String PhoneNumber{get{return txtPhoneNumber.Text;}}
		private Object mpSelectedItem;
		private System.Windows.Forms.ColumnHeader colDescription;
		private System.Windows.Forms.ColumnHeader colPhone;
		private System.Windows.Forms.ColumnHeader colType;
		private System.Windows.Forms.ColumnHeader colAgentFName;
		private System.Windows.Forms.ColumnHeader colAgentLName;
		private System.Windows.Forms.ColumnHeader colAgentId;
		private System.Windows.Forms.ColumnHeader colSupId;
		private System.Windows.Forms.ColumnHeader colSupFName;
		private System.Windows.Forms.ColumnHeader colSupLName;
		private System.Windows.Forms.ColumnHeader colSvcId;
		private System.Windows.Forms.ColumnHeader colSvcName;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FDial(CApp pApp, DialMode eMode)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			mpApp = pApp;
			meMode = eMode;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExternalRoutes = new System.Windows.Forms.TabPage();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lvwExternalRoutes = new System.Windows.Forms.ListView();
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAgents = new System.Windows.Forms.TabPage();
            this.lvwAgents = new System.Windows.Forms.ListView();
            this.colAgentId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAgentFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAgentLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabSupervisors = new System.Windows.Forms.TabPage();
            this.lvwSupervisors = new System.Windows.Forms.ListView();
            this.colSupId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupFName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSupLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabServices = new System.Windows.Forms.TabPage();
            this.lvwServices = new System.Windows.Forms.ListView();
            this.colSvcId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSvcName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabExternalRoutes.SuspendLayout();
            this.tabAgents.SuspendLayout();
            this.tabSupervisors.SuspendLayout();
            this.tabServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExternalRoutes);
            this.tabControl1.Controls.Add(this.tabAgents);
            this.tabControl1.Controls.Add(this.tabSupervisors);
            this.tabControl1.Controls.Add(this.tabServices);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExternalRoutes
            // 
            this.tabExternalRoutes.Controls.Add(this.txtPhoneNumber);
            this.tabExternalRoutes.Controls.Add(this.lvwExternalRoutes);
            this.tabExternalRoutes.Location = new System.Drawing.Point(4, 29);
            this.tabExternalRoutes.Name = "tabExternalRoutes";
            this.tabExternalRoutes.Size = new System.Drawing.Size(714, 261);
            this.tabExternalRoutes.TabIndex = 0;
            this.tabExternalRoutes.Text = "External Routes";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(14, 215);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(410, 26);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lvwExternalRoutes
            // 
            this.lvwExternalRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescription,
            this.colPhone,
            this.colType});
            this.lvwExternalRoutes.FullRowSelect = true;
            this.lvwExternalRoutes.HideSelection = false;
            this.lvwExternalRoutes.Location = new System.Drawing.Point(14, 20);
            this.lvwExternalRoutes.MultiSelect = false;
            this.lvwExternalRoutes.Name = "lvwExternalRoutes";
            this.lvwExternalRoutes.Size = new System.Drawing.Size(672, 183);
            this.lvwExternalRoutes.TabIndex = 0;
            this.lvwExternalRoutes.UseCompatibleStateImageBehavior = false;
            this.lvwExternalRoutes.View = System.Windows.Forms.View.Details;
            this.lvwExternalRoutes.SelectedIndexChanged += new System.EventHandler(this.lvwExternalRoutes_SelectedIndexChanged);
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 120;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone Number";
            this.colPhone.Width = 110;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 73;
            // 
            // tabAgents
            // 
            this.tabAgents.Controls.Add(this.lvwAgents);
            this.tabAgents.Location = new System.Drawing.Point(4, 29);
            this.tabAgents.Name = "tabAgents";
            this.tabAgents.Size = new System.Drawing.Size(714, 261);
            this.tabAgents.TabIndex = 1;
            this.tabAgents.Text = "Agents";
            // 
            // lvwAgents
            // 
            this.lvwAgents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAgentId,
            this.colAgentFName,
            this.colAgentLName});
            this.lvwAgents.FullRowSelect = true;
            this.lvwAgents.HideSelection = false;
            this.lvwAgents.Location = new System.Drawing.Point(14, 20);
            this.lvwAgents.MultiSelect = false;
            this.lvwAgents.Name = "lvwAgents";
            this.lvwAgents.Size = new System.Drawing.Size(669, 212);
            this.lvwAgents.TabIndex = 1;
            this.lvwAgents.UseCompatibleStateImageBehavior = false;
            this.lvwAgents.View = System.Windows.Forms.View.Details;
            this.lvwAgents.SelectedIndexChanged += new System.EventHandler(this.lvwAgents_SelectedIndexChanged);
            // 
            // colAgentId
            // 
            this.colAgentId.Text = "User Id";
            this.colAgentId.Width = 80;
            // 
            // colAgentFName
            // 
            this.colAgentFName.Text = "First Name";
            this.colAgentFName.Width = 100;
            // 
            // colAgentLName
            // 
            this.colAgentLName.Text = "Last Name";
            this.colAgentLName.Width = 123;
            // 
            // tabSupervisors
            // 
            this.tabSupervisors.Controls.Add(this.lvwSupervisors);
            this.tabSupervisors.Location = new System.Drawing.Point(4, 29);
            this.tabSupervisors.Name = "tabSupervisors";
            this.tabSupervisors.Size = new System.Drawing.Size(714, 261);
            this.tabSupervisors.TabIndex = 2;
            this.tabSupervisors.Text = "Supervisors";
            // 
            // lvwSupervisors
            // 
            this.lvwSupervisors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSupId,
            this.colSupFName,
            this.colSupLName});
            this.lvwSupervisors.FullRowSelect = true;
            this.lvwSupervisors.HideSelection = false;
            this.lvwSupervisors.Location = new System.Drawing.Point(14, 20);
            this.lvwSupervisors.MultiSelect = false;
            this.lvwSupervisors.Name = "lvwSupervisors";
            this.lvwSupervisors.Size = new System.Drawing.Size(668, 212);
            this.lvwSupervisors.TabIndex = 2;
            this.lvwSupervisors.UseCompatibleStateImageBehavior = false;
            this.lvwSupervisors.View = System.Windows.Forms.View.Details;
            this.lvwSupervisors.SelectedIndexChanged += new System.EventHandler(this.lvwSupervisors_SelectedIndexChanged);
            // 
            // colSupId
            // 
            this.colSupId.Text = "User Id";
            this.colSupId.Width = 80;
            // 
            // colSupFName
            // 
            this.colSupFName.Text = "First Name";
            this.colSupFName.Width = 100;
            // 
            // colSupLName
            // 
            this.colSupLName.Text = "Last Name";
            this.colSupLName.Width = 123;
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.lvwServices);
            this.tabServices.Location = new System.Drawing.Point(4, 29);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(714, 261);
            this.tabServices.TabIndex = 3;
            this.tabServices.Text = "Services";
            // 
            // lvwServices
            // 
            this.lvwServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSvcId,
            this.colSvcName});
            this.lvwServices.FullRowSelect = true;
            this.lvwServices.HideSelection = false;
            this.lvwServices.Location = new System.Drawing.Point(14, 20);
            this.lvwServices.MultiSelect = false;
            this.lvwServices.Name = "lvwServices";
            this.lvwServices.Size = new System.Drawing.Size(666, 212);
            this.lvwServices.TabIndex = 3;
            this.lvwServices.UseCompatibleStateImageBehavior = false;
            this.lvwServices.View = System.Windows.Forms.View.Details;
            this.lvwServices.SelectedIndexChanged += new System.EventHandler(this.lvwServices_SelectedIndexChanged);
            // 
            // colSvcId
            // 
            this.colSvcId.Text = "Id";
            this.colSvcId.Width = 100;
            // 
            // colSvcName
            // 
            this.colSvcName.Text = "Name";
            this.colSvcName.Width = 203;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(221, 310);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(105, 31);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(341, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FDial
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(903, 438);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FDial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FDial";
            this.Load += new System.EventHandler(this.FDial_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabExternalRoutes.ResumeLayout(false);
            this.tabExternalRoutes.PerformLayout();
            this.tabAgents.ResumeLayout(false);
            this.tabSupervisors.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void FDial_Load(object sender, System.EventArgs e)
		{
            mpApp.CallActivated += new CallActivatedHandler(this.CApp_CallActivated);

            //If first party dial or 3rd party dial, load and show externals; otherwise, hide them.
			if (meMode == DialMode.dm1stParty || meMode == DialMode.dm3rdParty)
				//Load external routes
				LoadExternalRoutes();
            else
                //Hide doesn't seem to work so remove the page from the tab control.
                //tabExternalRoutes.Hide();
                tabControl1.TabPages.Remove(tabExternalRoutes);


            //If current call is a preview, init the PhoneNumber field based on the call's settings.
            if (mpApp.CurrentCall != null && mpApp.CurrentCall.CurrentState is CStatePreview)
            {
                txtPhoneNumber.Text = mpApp.CurrentCall.PhoneNumber;
                txtPhoneNumber.Enabled = ((CServiceAOD)mpApp.CurrentService).AllowPreviewNumberChange;
            }


            //For all dial modes, load and show agents
            //If current user is allowed to dial agents, load them; otherwise, hide them.
            if ((mpApp.CurrentService.DialMask & (int)DialMaskBits.Agent) == (int)DialMaskBits.Agent)
                LoadAgents();
            else
                //tabAgents.Hide();
                tabControl1.TabPages.Remove(tabAgents);


            //For all dial modes, load and show supervisors
            //If current user is allowed to dial supervisors, load them; otherwise, hide them.
            if ((mpApp.CurrentService.DialMask & (int)DialMaskBits.Supervisor) == (int)DialMaskBits.Supervisor)
                LoadSupervisors();
            else
                //tabSupervisors.Hide();
                tabControl1.TabPages.Remove(tabSupervisors);


			//If third party mode or chat xfer mode, load and show services; otherwise, hide them.
            if (meMode == DialMode.dm3rdParty || meMode == DialMode.dmChatXfer)
                LoadServices();
            else
                tabControl1.TabPages.Remove(tabServices);

            
            //Select the first tab
			//tabControl1.SelectedTab = tabExternalRoutes;
            tabControl1.SelectedIndex = 0;
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

		private void LoadAgents()
		{
			lvwAgents.BeginUpdate();

			lvwAgents.Items.Clear();

			CAgents pAgents = mpApp.GetAgents();
			foreach (CUser pAgent in pAgents)
			{
				ListViewItem oItem = new ListViewItem(pAgent.Id);
				oItem.SubItems.AddRange(new String[]{pAgent.FirstName, pAgent.LastName});
				oItem.Tag = pAgent;
				lvwAgents.Items.Add(oItem);
			}

			lvwAgents.EndUpdate();
		}

	
		private void LoadSupervisors()
		{
			lvwSupervisors.BeginUpdate();

			lvwSupervisors.Items.Clear();

			CSupervisors pSups = mpApp.GetSupervisors();
			foreach (CUser pSup in pSups)
			{
				ListViewItem oItem = new ListViewItem(pSup.Id);
				oItem.SubItems.AddRange(new String[]{pSup.FirstName, pSup.LastName});
				oItem.Tag = pSup;
				lvwSupervisors.Items.Add(oItem);
			}

			lvwSupervisors.EndUpdate();
		}

		private void LoadExternalRoutes()
		{
			lvwExternalRoutes.BeginUpdate();

			lvwExternalRoutes.Items.Clear();

			foreach (CExternalRoute pExternal in mpApp.ExternalRoutes)
			{
				ListViewItem oItem = new ListViewItem(pExternal.Description);
				oItem.SubItems.AddRange(new String[]{pExternal.PhoneNumber, pExternal.Type.ToString()});
				oItem.Tag = pExternal;
				lvwExternalRoutes.Items.Add(oItem);
			}

			lvwExternalRoutes.EndUpdate();
		}

        private void LoadServices()
        {
            lvwServices.BeginUpdate();

            lvwServices.Items.Clear();

            CServices pSvcs = mpApp.GetServices();
            foreach (CSimpleService pSvc in pSvcs)
            {
                ListViewItem oItem = new ListViewItem(pSvc.ServiceName);
                oItem.SubItems.AddRange(new String[] {pSvc.ServiceId.ToString(), pSvc.ServiceName, pSvc.ServiceType.ToString()});
                oItem.Tag = pSvc;
                lvwServices.Items.Add(oItem);
            }

            lvwServices.EndUpdate();
        }

		private void lvwExternalRoutes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Save selection from this list. Clear the others'.
			if (lvwExternalRoutes.SelectedItems.Count > 0)
			{
				mpSelectedItem = lvwExternalRoutes.SelectedItems[0].Tag;
				txtPhoneNumber.Text = ((CExternalRoute)mpSelectedItem).PhoneNumber; 
				lvwAgents.SelectedItems.Clear();
				lvwSupervisors.SelectedItems.Clear();
				lvwServices.SelectedItems.Clear();
			}
		}

		private void lvwAgents_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Save selection from this list. Clear the others'.
			if (lvwAgents.SelectedItems.Count > 0)
			{
				mpSelectedItem = lvwAgents.SelectedItems[0].Tag;
				lvwExternalRoutes.SelectedItems.Clear();
				lvwSupervisors.SelectedItems.Clear();
				lvwServices.SelectedItems.Clear();
				txtPhoneNumber.Text = "";
			}
		}

		private void lvwSupervisors_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Save selection from this list. Clear the others'.
			if (lvwSupervisors.SelectedItems.Count > 0)
			{
				mpSelectedItem = lvwSupervisors.SelectedItems[0].Tag;
				lvwExternalRoutes.SelectedItems.Clear();
				lvwAgents.SelectedItems.Clear();
				lvwServices.SelectedItems.Clear();
				txtPhoneNumber.Text = "";
			}
		}

		private void lvwServices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Save selection from this list. Clear the others'.
			if (lvwServices.SelectedItems.Count > 0)
			{
				mpSelectedItem = lvwServices.SelectedItems[0].Tag;
				lvwExternalRoutes.SelectedItems.Clear();
				lvwAgents.SelectedItems.Clear();
				lvwSupervisors.SelectedItems.Clear();
				txtPhoneNumber.Text = "";
			}
		}

		private void btnOK_Click(object sender, System.EventArgs e)
		{	
			//If no item selected and no number specified, show error and ignore request
			if (this.SelectedItem == null && txtPhoneNumber.Text.Trim() == "")
			{
				MessageBox.Show("You must select an item from one of the lists or specify a phone number");
				return;
			}
			//If a phone number was specified then check that it is numeric
			else if (txtPhoneNumber.Text.Trim() != "")
			{
				Char[] digits = txtPhoneNumber.Text.Trim().ToCharArray();
				for (int i = 0; i < digits.Length; i++)
				{
					if ( !Char.IsNumber(digits[i]) )
					{
						MessageBox.Show("You must specify a valid (numeric) phone number");
						return;
					}
				}
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
		}

		private void txtPhoneNumber_TextChanged(object sender, System.EventArgs e)
		{
			if (txtPhoneNumber.Text != "")
			{
				if (!(mpSelectedItem is CExternalRoute))
				{
					mpSelectedItem = null;
					lvwAgents.SelectedItems.Clear();
					lvwSupervisors.SelectedItems.Clear();
					lvwServices.SelectedItems.Clear();
				}
			}
		}
	}
}
