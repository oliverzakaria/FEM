using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SamplePortalClient.UI
{
	/// <summary>
	/// Summary description for FMessage.
	/// </summary>
	public class FMessage : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer tmrFlash;
		private System.ComponentModel.IContainer components;

		private int miDurationSecs=0;
		private String msMessage="";
		private int miElapsedSecs=0;

		public FMessage(String sMessage, int iDurationSecs)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			miDurationSecs = iDurationSecs;
			msMessage = sMessage;
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.tmrFlash = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblMessage.Location = new System.Drawing.Point(8, 8);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(376, 24);
			this.lblMessage.TabIndex = 0;
			this.lblMessage.Text = "Some Message";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tmrFlash
			// 
			this.tmrFlash.Interval = 1000;
			this.tmrFlash.Tick += new System.EventHandler(this.tmrFlash_Tick);
			// 
			// FMessage
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(392, 38);
			this.ControlBox = false;
			this.Controls.Add(this.lblMessage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FMessage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FMessage_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FMessage_Load(object sender, System.EventArgs e)
		{
			lblMessage.Text = msMessage;
			if (miDurationSecs != 0)
				tmrFlash.Enabled = true;
		}

		private void tmrFlash_Tick(object sender, System.EventArgs e)
		{
			miElapsedSecs++;
			if (miDurationSecs > 0 && miElapsedSecs >= miDurationSecs)
			{
				tmrFlash.Enabled = false;
				this.Close();
			}
			else
			{
				lblMessage.Visible = !(lblMessage.Visible); 
			}
		}
	}
}
