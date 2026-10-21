namespace SamplePortalClient.UI
{
    partial class F3Way
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txt3rdParty = new System.Windows.Forms.TextBox();
            this.lbl3rdParty = new System.Windows.Forms.Label();
            this.btnConsult = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnConference = new System.Windows.Forms.Button();
            this.lblStatus1stParty = new System.Windows.Forms.Label();
            this.btnHangup1stParty = new System.Windows.Forms.Button();
            this.btnHold1stParty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHold3rdParty = new System.Windows.Forms.Button();
            this.btnHangup3rdParty = new System.Windows.Forms.Button();
            this.lblStatus3rdParty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(266, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(29, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txt3rdParty
            // 
            this.txt3rdParty.Enabled = false;
            this.txt3rdParty.Location = new System.Drawing.Point(79, 21);
            this.txt3rdParty.Name = "txt3rdParty";
            this.txt3rdParty.Size = new System.Drawing.Size(181, 20);
            this.txt3rdParty.TabIndex = 1;
            // 
            // lbl3rdParty
            // 
            this.lbl3rdParty.AutoSize = true;
            this.lbl3rdParty.Location = new System.Drawing.Point(24, 24);
            this.lbl3rdParty.Name = "lbl3rdParty";
            this.lbl3rdParty.Size = new System.Drawing.Size(49, 13);
            this.lbl3rdParty.TabIndex = 2;
            this.lbl3rdParty.Text = "3rd Party";
            // 
            // btnConsult
            // 
            this.btnConsult.Location = new System.Drawing.Point(326, 17);
            this.btnConsult.Name = "btnConsult";
            this.btnConsult.Size = new System.Drawing.Size(72, 25);
            this.btnConsult.TabIndex = 3;
            this.btnConsult.Text = "Consult";
            this.btnConsult.UseVisualStyleBackColor = true;
            this.btnConsult.Click += new System.EventHandler(this.btnConsult_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(326, 48);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(72, 25);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnConference
            // 
            this.btnConference.Location = new System.Drawing.Point(326, 79);
            this.btnConference.Name = "btnConference";
            this.btnConference.Size = new System.Drawing.Size(72, 25);
            this.btnConference.TabIndex = 5;
            this.btnConference.Text = "Conference";
            this.btnConference.UseVisualStyleBackColor = true;
            this.btnConference.Click += new System.EventHandler(this.btnConference_Click);
            // 
            // lblStatus1stParty
            // 
            this.lblStatus1stParty.BackColor = System.Drawing.Color.LimeGreen;
            this.lblStatus1stParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus1stParty.Location = new System.Drawing.Point(26, 79);
            this.lblStatus1stParty.Name = "lblStatus1stParty";
            this.lblStatus1stParty.Size = new System.Drawing.Size(101, 87);
            this.lblStatus1stParty.TabIndex = 7;
            this.lblStatus1stParty.Text = "Active";
            this.lblStatus1stParty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHangup1stParty
            // 
            this.btnHangup1stParty.Location = new System.Drawing.Point(40, 98);
            this.btnHangup1stParty.Name = "btnHangup1stParty";
            this.btnHangup1stParty.Size = new System.Drawing.Size(72, 25);
            this.btnHangup1stParty.TabIndex = 8;
            this.btnHangup1stParty.Text = "Hangup";
            this.btnHangup1stParty.UseVisualStyleBackColor = true;
            this.btnHangup1stParty.Click += new System.EventHandler(this.btnHangup1stParty_Click);
            // 
            // btnHold1stParty
            // 
            this.btnHold1stParty.Location = new System.Drawing.Point(40, 129);
            this.btnHold1stParty.Name = "btnHold1stParty";
            this.btnHold1stParty.Size = new System.Drawing.Size(72, 25);
            this.btnHold1stParty.TabIndex = 9;
            this.btnHold1stParty.Text = "Hold";
            this.btnHold1stParty.UseVisualStyleBackColor = true;
            this.btnHold1stParty.Click += new System.EventHandler(this.btnHold1stParty_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "1st Party";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "3rd Party";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHold3rdParty
            // 
            this.btnHold3rdParty.Location = new System.Drawing.Point(211, 129);
            this.btnHold3rdParty.Name = "btnHold3rdParty";
            this.btnHold3rdParty.Size = new System.Drawing.Size(72, 25);
            this.btnHold3rdParty.TabIndex = 13;
            this.btnHold3rdParty.Text = "Hold";
            this.btnHold3rdParty.UseVisualStyleBackColor = true;
            this.btnHold3rdParty.Click += new System.EventHandler(this.btnHold3rdParty_Click);
            // 
            // btnHangup3rdParty
            // 
            this.btnHangup3rdParty.Location = new System.Drawing.Point(211, 98);
            this.btnHangup3rdParty.Name = "btnHangup3rdParty";
            this.btnHangup3rdParty.Size = new System.Drawing.Size(72, 25);
            this.btnHangup3rdParty.TabIndex = 12;
            this.btnHangup3rdParty.Text = "Hangup";
            this.btnHangup3rdParty.UseVisualStyleBackColor = true;
            this.btnHangup3rdParty.Click += new System.EventHandler(this.btnHangup3rdParty_Click);
            // 
            // lblStatus3rdParty
            // 
            this.lblStatus3rdParty.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblStatus3rdParty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus3rdParty.Location = new System.Drawing.Point(197, 79);
            this.lblStatus3rdParty.Name = "lblStatus3rdParty";
            this.lblStatus3rdParty.Size = new System.Drawing.Size(101, 87);
            this.lblStatus3rdParty.TabIndex = 11;
            this.lblStatus3rdParty.Text = "Inactive";
            this.lblStatus3rdParty.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // F3Way
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHold3rdParty);
            this.Controls.Add(this.btnHangup3rdParty);
            this.Controls.Add(this.lblStatus3rdParty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHold1stParty);
            this.Controls.Add(this.btnHangup1stParty);
            this.Controls.Add(this.lblStatus1stParty);
            this.Controls.Add(this.btnConference);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnConsult);
            this.Controls.Add(this.lbl3rdParty);
            this.Controls.Add(this.txt3rdParty);
            this.Controls.Add(this.btnBrowse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F3Way";
            this.Text = "3-Way";
            this.Load += new System.EventHandler(this.F3Way_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txt3rdParty;
        private System.Windows.Forms.Label lbl3rdParty;
        private System.Windows.Forms.Button btnConsult;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnConference;
        private System.Windows.Forms.Label lblStatus1stParty;
        private System.Windows.Forms.Button btnHangup1stParty;
        private System.Windows.Forms.Button btnHold1stParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHold3rdParty;
        private System.Windows.Forms.Button btnHangup3rdParty;
        private System.Windows.Forms.Label lblStatus3rdParty;
    }
}