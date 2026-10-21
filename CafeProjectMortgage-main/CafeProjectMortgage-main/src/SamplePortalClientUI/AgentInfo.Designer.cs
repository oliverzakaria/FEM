using SamplePortalClient;
using SamplePortalClientUI.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SamplePortalClientUI
{
    partial class AgentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
      
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAgentinfo = new System.Windows.Forms.TabPage();
            this.lblRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalSV = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalIM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalWrokflow = new System.Windows.Forms.Label();
            this.Workflow1 = new System.Windows.Forms.Label();
            this.lblTotalCTI = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTotalDID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblTotalEmail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalChat = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalOutbound = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalInbound = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalWrap = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalActive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalRefusals = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblTotalSuccess = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblTotalContact = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.dgvAgentStatus = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Successes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refusals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotReady = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Park = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Occupancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAgentID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridTotal = new System.Windows.Forms.DataGridView();
            this.ServiceTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactsTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuccessesTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefusalsTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoggedInTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdleTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WrapTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotReadyTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OccupancyTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManualTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentStatus)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAgentinfo
            // 
            this.tbAgentinfo.Location = new System.Drawing.Point(0, 16);
            this.tbAgentinfo.Name = "tbAgentinfo";
            this.tbAgentinfo.Size = new System.Drawing.Size(200, 100);
            this.tbAgentinfo.TabIndex = 0;
            // 
            // lblRefresh
            // 
            this.lblRefresh.BackColor = System.Drawing.Color.Silver;
            this.lblRefresh.Enabled = false;
            this.lblRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefresh.ForeColor = System.Drawing.Color.Black;
            this.lblRefresh.Location = new System.Drawing.Point(1058, 73);
            this.lblRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(125, 28);
            this.lblRefresh.TabIndex = 45;
            this.lblRefresh.Text = "Refresh";
            this.lblRefresh.UseVisualStyleBackColor = false;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblTotalSV);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblTotalIM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblTotalWrokflow);
            this.panel1.Controls.Add(this.Workflow1);
            this.panel1.Controls.Add(this.lblTotalCTI);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.lblTotalDID);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lblTotalEmail);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblTotalChat);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblTotalOutbound);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTotalInbound);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(7, 392);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 156);
            this.panel1.TabIndex = 44;
            // 
            // lblTotalSV
            // 
            this.lblTotalSV.AutoSize = true;
            this.lblTotalSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSV.Location = new System.Drawing.Point(128, 128);
            this.lblTotalSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSV.Name = "lblTotalSV";
            this.lblTotalSV.Size = new System.Drawing.Size(13, 15);
            this.lblTotalSV.TabIndex = 42;
            this.lblTotalSV.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 15);
            this.label11.TabIndex = 41;
            this.label11.Text = "Social Voice";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalIM
            // 
            this.lblTotalIM.AutoSize = true;
            this.lblTotalIM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIM.Location = new System.Drawing.Point(358, 102);
            this.lblTotalIM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIM.Name = "lblTotalIM";
            this.lblTotalIM.Size = new System.Drawing.Size(13, 15);
            this.lblTotalIM.TabIndex = 40;
            this.lblTotalIM.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "IM";
            // 
            // lblTotalWrokflow
            // 
            this.lblTotalWrokflow.AutoSize = true;
            this.lblTotalWrokflow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWrokflow.Location = new System.Drawing.Point(358, 53);
            this.lblTotalWrokflow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalWrokflow.Name = "lblTotalWrokflow";
            this.lblTotalWrokflow.Size = new System.Drawing.Size(13, 15);
            this.lblTotalWrokflow.TabIndex = 38;
            this.lblTotalWrokflow.Text = "0";
            // 
            // Workflow1
            // 
            this.Workflow1.AutoSize = true;
            this.Workflow1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Workflow1.Location = new System.Drawing.Point(237, 53);
            this.Workflow1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Workflow1.Name = "Workflow1";
            this.Workflow1.Size = new System.Drawing.Size(58, 15);
            this.Workflow1.TabIndex = 37;
            this.Workflow1.Text = "Workflow";
            this.Workflow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCTI
            // 
            this.lblTotalCTI.AutoSize = true;
            this.lblTotalCTI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCTI.Location = new System.Drawing.Point(128, 102);
            this.lblTotalCTI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCTI.Name = "lblTotalCTI";
            this.lblTotalCTI.Size = new System.Drawing.Size(13, 15);
            this.lblTotalCTI.TabIndex = 36;
            this.lblTotalCTI.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(7, 102);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 15);
            this.label24.TabIndex = 35;
            this.label24.Text = "CTI";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDID
            // 
            this.lblTotalDID.AutoSize = true;
            this.lblTotalDID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDID.Location = new System.Drawing.Point(358, 77);
            this.lblTotalDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDID.Name = "lblTotalDID";
            this.lblTotalDID.Size = new System.Drawing.Size(13, 15);
            this.lblTotalDID.TabIndex = 34;
            this.lblTotalDID.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(237, 77);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 15);
            this.label20.TabIndex = 33;
            this.label20.Text = "DID";
            // 
            // lblTotalEmail
            // 
            this.lblTotalEmail.AutoSize = true;
            this.lblTotalEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEmail.Location = new System.Drawing.Point(358, 32);
            this.lblTotalEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmail.Name = "lblTotalEmail";
            this.lblTotalEmail.Size = new System.Drawing.Size(13, 15);
            this.lblTotalEmail.TabIndex = 26;
            this.lblTotalEmail.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(237, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email";
            // 
            // lblTotalChat
            // 
            this.lblTotalChat.AutoSize = true;
            this.lblTotalChat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalChat.Location = new System.Drawing.Point(128, 77);
            this.lblTotalChat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalChat.Name = "lblTotalChat";
            this.lblTotalChat.Size = new System.Drawing.Size(13, 15);
            this.lblTotalChat.TabIndex = 24;
            this.lblTotalChat.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(7, 77);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Chat";
            // 
            // lblTotalOutbound
            // 
            this.lblTotalOutbound.AutoSize = true;
            this.lblTotalOutbound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOutbound.Location = new System.Drawing.Point(128, 53);
            this.lblTotalOutbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalOutbound.Name = "lblTotalOutbound";
            this.lblTotalOutbound.Size = new System.Drawing.Size(13, 15);
            this.lblTotalOutbound.TabIndex = 22;
            this.lblTotalOutbound.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Outbound";
            // 
            // lblTotalInbound
            // 
            this.lblTotalInbound.AutoSize = true;
            this.lblTotalInbound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInbound.Location = new System.Drawing.Point(128, 32);
            this.lblTotalInbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalInbound.Name = "lblTotalInbound";
            this.lblTotalInbound.Size = new System.Drawing.Size(13, 15);
            this.lblTotalInbound.TabIndex = 20;
            this.lblTotalInbound.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inbound";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cumulative Contact Detail";
            // 
            // lblTotalWrap
            // 
            this.lblTotalWrap.AutoSize = true;
            this.lblTotalWrap.BackColor = System.Drawing.Color.White;
            this.lblTotalWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWrap.ForeColor = System.Drawing.Color.Black;
            this.lblTotalWrap.Location = new System.Drawing.Point(1139, 614);
            this.lblTotalWrap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalWrap.Name = "lblTotalWrap";
            this.lblTotalWrap.Size = new System.Drawing.Size(55, 16);
            this.lblTotalWrap.TabIndex = 43;
            this.lblTotalWrap.Text = "00:00:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1005, 614);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 42;
            this.label8.Text = "Total Wrap";
            // 
            // lblTotalActive
            // 
            this.lblTotalActive.AutoSize = true;
            this.lblTotalActive.BackColor = System.Drawing.Color.White;
            this.lblTotalActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActive.ForeColor = System.Drawing.Color.Black;
            this.lblTotalActive.Location = new System.Drawing.Point(870, 614);
            this.lblTotalActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalActive.Name = "lblTotalActive";
            this.lblTotalActive.Size = new System.Drawing.Size(55, 16);
            this.lblTotalActive.TabIndex = 41;
            this.lblTotalActive.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(737, 614);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Total Active";
            // 
            // lblTotalRefusals
            // 
            this.lblTotalRefusals.AutoSize = true;
            this.lblTotalRefusals.BackColor = System.Drawing.Color.White;
            this.lblTotalRefusals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefusals.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRefusals.Location = new System.Drawing.Point(637, 614);
            this.lblTotalRefusals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRefusals.Name = "lblTotalRefusals";
            this.lblTotalRefusals.Size = new System.Drawing.Size(14, 16);
            this.lblTotalRefusals.TabIndex = 39;
            this.lblTotalRefusals.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.White;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(488, 614);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 16);
            this.label30.TabIndex = 38;
            this.label30.Text = "Total Refusals";
            // 
            // lblTotalSuccess
            // 
            this.lblTotalSuccess.AutoSize = true;
            this.lblTotalSuccess.BackColor = System.Drawing.Color.White;
            this.lblTotalSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuccess.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSuccess.Location = new System.Drawing.Point(412, 614);
            this.lblTotalSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalSuccess.Name = "lblTotalSuccess";
            this.lblTotalSuccess.Size = new System.Drawing.Size(14, 16);
            this.lblTotalSuccess.TabIndex = 37;
            this.lblTotalSuccess.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(236, 614);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(108, 16);
            this.label28.TabIndex = 36;
            this.label28.Text = "Total Successes";
            // 
            // lblTotalContact
            // 
            this.lblTotalContact.AutoSize = true;
            this.lblTotalContact.BackColor = System.Drawing.Color.White;
            this.lblTotalContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContact.ForeColor = System.Drawing.Color.Black;
            this.lblTotalContact.Location = new System.Drawing.Point(165, 614);
            this.lblTotalContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalContact.Name = "lblTotalContact";
            this.lblTotalContact.Size = new System.Drawing.Size(14, 16);
            this.lblTotalContact.TabIndex = 35;
            this.lblTotalContact.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(10, 614);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(93, 16);
            this.label25.TabIndex = 34;
            this.label25.Text = "Total Contacts";
            // 
            // dgvAgentStatus
            // 
            this.dgvAgentStatus.AllowUserToAddRows = false;
            this.dgvAgentStatus.AllowUserToDeleteRows = false;
            this.dgvAgentStatus.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAgentStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgentStatus.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgentStatus.ColumnHeadersHeight = 30;
            this.dgvAgentStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Contacts,
            this.Successes,
            this.Refusals,
            this.LoggedIn,
            this.Active,
            this.Idle,
            this.Wrap,
            this.NotReady,
            this.Park,
            this.Occupancy,
            this.Manual});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgentStatus.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgentStatus.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAgentStatus.EnableHeadersVisualStyles = false;
            this.dgvAgentStatus.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAgentStatus.Location = new System.Drawing.Point(4, 113);
            this.dgvAgentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAgentStatus.Name = "dgvAgentStatus";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgentStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAgentStatus.RowHeadersVisible = false;
            this.dgvAgentStatus.RowHeadersWidth = 62;
            this.dgvAgentStatus.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAgentStatus.RowTemplate.Height = 30;
            this.dgvAgentStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgentStatus.Size = new System.Drawing.Size(1252, 170);
            this.dgvAgentStatus.TabIndex = 22;
            // 
            // Service
            // 
            this.Service.DataPropertyName = "Service";
            this.Service.HeaderText = "Service";
            this.Service.MinimumWidth = 8;
            this.Service.Name = "Service";
            this.Service.Width = 200;
            // 
            // Contacts
            // 
            this.Contacts.DataPropertyName = "Contacts";
            this.Contacts.HeaderText = "Contacts";
            this.Contacts.MinimumWidth = 8;
            this.Contacts.Name = "Contacts";
            this.Contacts.Width = 125;
            // 
            // Successes
            // 
            this.Successes.DataPropertyName = "Successes";
            this.Successes.HeaderText = "Successes";
            this.Successes.MinimumWidth = 8;
            this.Successes.Name = "Successes";
            this.Successes.Width = 125;
            // 
            // Refusals
            // 
            this.Refusals.DataPropertyName = "Refusals";
            this.Refusals.HeaderText = "Refusals";
            this.Refusals.MinimumWidth = 8;
            this.Refusals.Name = "Refusals";
            this.Refusals.Width = 125;
            // 
            // LoggedIn
            // 
            this.LoggedIn.DataPropertyName = "LoggedIn";
            this.LoggedIn.HeaderText = "LoggedIn";
            this.LoggedIn.MinimumWidth = 8;
            this.LoggedIn.Name = "LoggedIn";
            this.LoggedIn.Width = 125;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 8;
            this.Active.Name = "Active";
            this.Active.Width = 150;
            // 
            // Idle
            // 
            this.Idle.DataPropertyName = "Idle";
            this.Idle.HeaderText = "Idle";
            this.Idle.MinimumWidth = 8;
            this.Idle.Name = "Idle";
            this.Idle.Width = 150;
            // 
            // Wrap
            // 
            this.Wrap.DataPropertyName = "Wrap";
            this.Wrap.HeaderText = "Wrap";
            this.Wrap.MinimumWidth = 8;
            this.Wrap.Name = "Wrap";
            this.Wrap.Width = 150;
            // 
            // NotReady
            // 
            this.NotReady.DataPropertyName = "NotReady";
            this.NotReady.HeaderText = "Not Ready";
            this.NotReady.MinimumWidth = 8;
            this.NotReady.Name = "NotReady";
            this.NotReady.Width = 150;
            // 
            // Park
            // 
            this.Park.DataPropertyName = "Park";
            this.Park.HeaderText = "Park";
            this.Park.MinimumWidth = 8;
            this.Park.Name = "Park";
            this.Park.Width = 150;
            // 
            // Occupancy
            // 
            this.Occupancy.DataPropertyName = "Occupancy";
            this.Occupancy.HeaderText = "Occupancy";
            this.Occupancy.MinimumWidth = 8;
            this.Occupancy.Name = "Occupancy";
            this.Occupancy.Width = 110;
            // 
            // Manual
            // 
            this.Manual.DataPropertyName = "Manual";
            this.Manual.HeaderText = "Manual";
            this.Manual.Name = "Manual";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.71554F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.398827F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.88563F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAgentID, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 78);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(147, 25);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(13, 15);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(147, 50);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "0";
            // 
            // lblAgentID
            // 
            this.lblAgentID.AutoSize = true;
            this.lblAgentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentID.Location = new System.Drawing.Point(147, 0);
            this.lblAgentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(13, 15);
            this.lblAgentID.TabIndex = 24;
            this.lblAgentID.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(117, 50);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(117, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = ":";
            // 
            // dataGridTotal
            // 
            this.dataGridTotal.AllowUserToAddRows = false;
            this.dataGridTotal.AllowUserToDeleteRows = false;
            this.dataGridTotal.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(232)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridTotal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridTotal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTotal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridTotal.ColumnHeadersHeight = 30;
            this.dataGridTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTot,
            this.ContactsTot,
            this.SuccessesTot,
            this.RefusalsTot,
            this.LoggedInTot,
            this.ActiveTot,
            this.IdleTot,
            this.WrapTot,
            this.NotReadyTot,
            this.ParkTot,
            this.OccupancyTot,
            this.ManualTot});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridTotal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridTotal.EnableHeadersVisualStyles = false;
            this.dataGridTotal.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridTotal.Location = new System.Drawing.Point(4, 293);
            this.dataGridTotal.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridTotal.Name = "dataGridTotal";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridTotal.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridTotal.RowHeadersVisible = false;
            this.dataGridTotal.RowHeadersWidth = 62;
            this.dataGridTotal.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridTotal.RowTemplate.Height = 30;
            this.dataGridTotal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTotal.Size = new System.Drawing.Size(1252, 91);
            this.dataGridTotal.TabIndex = 46;
            // 
            // ServiceTot
            // 
            this.ServiceTot.DataPropertyName = "ServiceTot";
            this.ServiceTot.HeaderText = "Total";
            this.ServiceTot.MinimumWidth = 8;
            this.ServiceTot.Name = "ServiceTot";
            this.ServiceTot.Width = 200;
            // 
            // ContactsTot
            // 
            this.ContactsTot.DataPropertyName = "ContactsTot";
            this.ContactsTot.HeaderText = "Contacts";
            this.ContactsTot.MinimumWidth = 8;
            this.ContactsTot.Name = "ContactsTot";
            this.ContactsTot.Width = 125;
            // 
            // SuccessesTot
            // 
            this.SuccessesTot.DataPropertyName = "SuccessesTot";
            this.SuccessesTot.HeaderText = "Successes";
            this.SuccessesTot.MinimumWidth = 8;
            this.SuccessesTot.Name = "SuccessesTot";
            this.SuccessesTot.Width = 125;
            // 
            // RefusalsTot
            // 
            this.RefusalsTot.DataPropertyName = "RefusalsTot";
            this.RefusalsTot.HeaderText = "Refusals";
            this.RefusalsTot.MinimumWidth = 8;
            this.RefusalsTot.Name = "RefusalsTot";
            this.RefusalsTot.Width = 125;
            // 
            // LoggedInTot
            // 
            this.LoggedInTot.DataPropertyName = "LoggedInTot";
            this.LoggedInTot.HeaderText = "LoggedIn";
            this.LoggedInTot.MinimumWidth = 8;
            this.LoggedInTot.Name = "LoggedInTot";
            this.LoggedInTot.Width = 125;
            // 
            // ActiveTot
            // 
            this.ActiveTot.DataPropertyName = "ActiveTot";
            this.ActiveTot.HeaderText = "Active";
            this.ActiveTot.MinimumWidth = 8;
            this.ActiveTot.Name = "ActiveTot";
            this.ActiveTot.Width = 150;
            // 
            // IdleTot
            // 
            this.IdleTot.DataPropertyName = "IdleTot";
            this.IdleTot.HeaderText = "Idle";
            this.IdleTot.MinimumWidth = 8;
            this.IdleTot.Name = "IdleTot";
            this.IdleTot.Width = 150;
            // 
            // WrapTot
            // 
            this.WrapTot.DataPropertyName = "WrapTot";
            this.WrapTot.HeaderText = "Wrap";
            this.WrapTot.MinimumWidth = 8;
            this.WrapTot.Name = "WrapTot";
            this.WrapTot.Width = 150;
            // 
            // NotReadyTot
            // 
            this.NotReadyTot.DataPropertyName = "NotReadyTot";
            this.NotReadyTot.HeaderText = "Not Ready";
            this.NotReadyTot.MinimumWidth = 8;
            this.NotReadyTot.Name = "NotReadyTot";
            this.NotReadyTot.Width = 150;
            // 
            // ParkTot
            // 
            this.ParkTot.DataPropertyName = "ParkTot";
            this.ParkTot.HeaderText = "Park";
            this.ParkTot.MinimumWidth = 8;
            this.ParkTot.Name = "ParkTot";
            this.ParkTot.Width = 150;
            // 
            // OccupancyTot
            // 
            this.OccupancyTot.DataPropertyName = "OccupancyTot";
            this.OccupancyTot.HeaderText = "Occupancy";
            this.OccupancyTot.MinimumWidth = 8;
            this.OccupancyTot.Name = "OccupancyTot";
            this.OccupancyTot.Width = 110;
            // 
            // ManualTot
            // 
            this.ManualTot.DataPropertyName = "ManualTot";
            this.ManualTot.HeaderText = "Manual";
            this.ManualTot.Name = "ManualTot";
            // 
            // AgentInfo
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1279, 620);
            this.Controls.Add(this.dataGridTotal);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotalWrap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalRefusals);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.lblTotalSuccess);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.lblTotalContact);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dgvAgentStatus);
            this.Name = "AgentInfo";
            this.Text = "Agent Statistics";
            this.Load += new System.EventHandler(this.AgentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgentStatus)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal ListView contactsListView;
        internal ListView contactsListView_Totals;
        private string _userName;
        private string _currentDate;
        private string _currentTime;
        private int _inbound;
        private int _outbound;
        private int _chats;
        private int _cti;
        private int _email;
        private int _workflow;
        private int _did;
        private int _im;
        private int _social;
        private AgentStat[] _agentStats;
        private AgentStatData _agentStatsData;
        private int _contactsTotals;
        private int _successesTotals;
        private int _refusalsTotals;
        private int _activeTotalSeconds;
        private string _activeTotalString;
        private int _idleTotalSeconds;
        private string _idleTotalString;
        private int _wrapTotalSeconds;
        private string _wrapTotalString;
        private int _manualTotalSeconds;
        private string _manualTotalString;
        private TabControl tbControlMain;
        private TabPage tbAgentinfo;
        internal DataGridView dgvAgentStatus;
        private Panel panel1;
        DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
        private Label label6;
        internal Label lblTotalWrap;
        internal Label label8;
        internal Label lblTotalActive;
        internal Label label4;
        internal Label lblTotalRefusals;
        internal Label label30;
        internal Label lblTotalSuccess;
        internal Label label28;
        internal Label lblTotalContact;
        internal Label label25;
        internal Label lblTotalWrokflow;
        internal Label Workflow1;
        internal Label lblTotalCTI;
        internal Label label24;
        internal Label lblTotalDID;
        internal Label label20;
        internal Label lblTotalEmail;
        internal Label label12;
        internal Label lblTotalChat;
        internal Label label14;
        internal Label lblTotalOutbound;
        internal Label label10;
        internal Label lblTotalInbound;
        internal Label label7;
        internal Button lblRefresh;
        internal Label lblTime;
        internal Label label9;
        internal Label lblDate;
        internal Label label2;
        internal Label lblAgentID;
        internal Label label5;
        internal Label lblTotalSV;
        internal Label label11;
        internal Label lblTotalIM;
        internal Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        internal Label label1;
        internal Label label15;
        internal Label label13;
        private DataGridViewTextBoxColumn Service;
        private DataGridViewTextBoxColumn Contacts;
        private DataGridViewTextBoxColumn Successes;
        private DataGridViewTextBoxColumn Refusals;
        private DataGridViewTextBoxColumn LoggedIn;
        private DataGridViewTextBoxColumn Active;
        private DataGridViewTextBoxColumn Idle;
        private DataGridViewTextBoxColumn Wrap;
        private DataGridViewTextBoxColumn NotReady;
        private DataGridViewTextBoxColumn Park;
        private DataGridViewTextBoxColumn Occupancy;
        private DataGridViewTextBoxColumn Manual;
        internal DataGridView dataGridTotal;
        private DataGridViewTextBoxColumn ServiceTot;
        private DataGridViewTextBoxColumn ContactsTot;
        private DataGridViewTextBoxColumn SuccessesTot;
        private DataGridViewTextBoxColumn RefusalsTot;
        private DataGridViewTextBoxColumn LoggedInTot;
        private DataGridViewTextBoxColumn ActiveTot;
        private DataGridViewTextBoxColumn IdleTot;
        private DataGridViewTextBoxColumn WrapTot;
        private DataGridViewTextBoxColumn NotReadyTot;
        private DataGridViewTextBoxColumn ParkTot;
        private DataGridViewTextBoxColumn OccupancyTot;
        private DataGridViewTextBoxColumn ManualTot;
    }
}