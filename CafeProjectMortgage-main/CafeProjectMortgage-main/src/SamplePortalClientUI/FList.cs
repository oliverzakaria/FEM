using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SamplePortalClient;

namespace SamplePortalClient.UI
{
	/// <summary>
	/// Summary description for FList.
	/// </summary>
	public class FList : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lstItems;
		private System.Windows.Forms.Button btnOK;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button btnCancel;
		private CApp mpApp;
		private CList mpList;
        private CheckBox chkOption;
		private ArrayList mpExcludeItems;

		public Object SelectedItem{get{return lstItems.SelectedItem;}}
        public bool OptionIsChecked{ get { return chkOption.Checked; } }
		
		public FList(CApp pApp, CList pList)
		:this(pApp, pList, null)
		{
		}

		public FList(CApp pApp, CList pList, ArrayList pExcludeItems)
		:this(pApp, pList, pExcludeItems, false, false, "")
        {
        }

        public FList(CApp pApp, CList pList, ArrayList pExcludeItems, bool bShowOption, bool bEnableOption, String sOptionText)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            mpApp = pApp;
            mpList = pList;
            mpExcludeItems = pExcludeItems;

            chkOption.Visible = bShowOption;
            chkOption.Enabled = bEnableOption;
            chkOption.Text = sOptionText;
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.Location = new System.Drawing.Point(13, 28);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(214, 134);
            this.lstItems.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(160, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 21);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(84, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 21);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            // 
            // chkOption
            // 
            this.chkOption.AutoSize = true;
            this.chkOption.Location = new System.Drawing.Point(13, 169);
            this.chkOption.Name = "chkOption";
            this.chkOption.Size = new System.Drawing.Size(15, 14);
            this.chkOption.TabIndex = 3;
            this.chkOption.UseVisualStyleBackColor = true;
            // 
            // FList
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(288, 252);
            this.ControlBox = false;
            this.Controls.Add(this.chkOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lstItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FList";
            this.Text = "FList";
            this.Load += new System.EventHandler(this.FList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void FList_Load(object sender, System.EventArgs e)
		{
            mpApp.CallActivated += new CallActivatedHandler(this.CApp_CallActivated);
            
            lstItems.BeginUpdate();

			if (mpExcludeItems != null && mpExcludeItems.Count > 0)
			{
				for (int i = 0; i < mpList.Count; i++)
					if (!mpExcludeItems.Contains(mpList[i]))
						lstItems.Items.Add(mpList[i]);
			}
			else
			{
				for (int i = 0; i < mpList.Count; i++)
					lstItems.Items.Add(mpList[i]);
			}	

			lstItems.EndUpdate();

            this.TopMost = true;
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

		private void btnOK_Click(object sender, System.EventArgs e)
		{
			if (this.SelectedItem == null)
			{
				MessageBox.Show("You must select an item from the list");
				return;
			}
		
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
