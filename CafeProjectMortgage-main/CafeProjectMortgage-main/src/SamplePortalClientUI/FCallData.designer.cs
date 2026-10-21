using ServiceStack;
using ServiceStack.Text.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Windows.Forms;
using static SamplePortalClient.CServices;

namespace SamplePortalClient.UI
{
    partial class FCallData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCallData));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.homeTabPage = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblservicecaption = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label124 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPrincipal2 = new System.Windows.Forms.TextBox();
            this.lblPrincipal3 = new System.Windows.Forms.TextBox();
            this.lblDPD2 = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.TextBox();
            this.lblDPD1 = new System.Windows.Forms.TextBox();
            this.LblPrincipal1 = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.TextBox();
            this.lblLoan3 = new System.Windows.Forms.TextBox();
            this.lblLoan2 = new System.Windows.Forms.TextBox();
            this.lblLoan1 = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.dialerTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_phone_remainder = new System.Windows.Forms.Panel();
            this.grp_phone_remainder1 = new System.Windows.Forms.GroupBox();
            this.cbPRPRHoldDate0 = new System.Windows.Forms.ComboBox();
            this.label237 = new System.Windows.Forms.Label();
            this.lblLoanP12 = new System.Windows.Forms.TextBox();
            this.lblLoanP11 = new System.Windows.Forms.TextBox();
            this.lblLoanP10 = new System.Windows.Forms.TextBox();
            this.cbContactPersonPR = new System.Windows.Forms.ComboBox();
            this.cbPRPRHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbPRHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbPRPRHoldDate1 = new System.Windows.Forms.ComboBox();
            this.cbPRHoldDate1 = new System.Windows.Forms.ComboBox();
            this.label210 = new System.Windows.Forms.Label();
            this.label211 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.label213 = new System.Windows.Forms.Label();
            this.cbPRaction2 = new System.Windows.Forms.ComboBox();
            this.cbPRaction1 = new System.Windows.Forms.ComboBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label215 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.txtPRAmount3 = new System.Windows.Forms.TextBox();
            this.label217 = new System.Windows.Forms.Label();
            this.label218 = new System.Windows.Forms.Label();
            this.label219 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.label269 = new System.Windows.Forms.Label();
            this.txtPRAmount2 = new System.Windows.Forms.TextBox();
            this.label271 = new System.Windows.Forms.Label();
            this.label272 = new System.Windows.Forms.Label();
            this.label273 = new System.Windows.Forms.Label();
            this.label274 = new System.Windows.Forms.Label();
            this.label275 = new System.Windows.Forms.Label();
            this.cbContactPRPlace = new System.Windows.Forms.ComboBox();
            this.txtRemarkPR = new System.Windows.Forms.TextBox();
            this.label276 = new System.Windows.Forms.Label();
            this.label277 = new System.Windows.Forms.Label();
            this.label278 = new System.Windows.Forms.Label();
            this.label279 = new System.Windows.Forms.Label();
            this.label280 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.label281 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.label301 = new System.Windows.Forms.Label();
            this.label302 = new System.Windows.Forms.Label();
            this.label303 = new System.Windows.Forms.Label();
            this.grp_phone_not_answer = new System.Windows.Forms.Panel();
            this.grp_phone_not_answer1 = new System.Windows.Forms.GroupBox();
            this.label186 = new System.Windows.Forms.Label();
            this.label300 = new System.Windows.Forms.Label();
            this.lblActionCode = new System.Windows.Forms.Label();
            this.cbContactNoAPlace = new System.Windows.Forms.ComboBox();
            this.txtRemarkNoAnswer = new System.Windows.Forms.TextBox();
            this.label245 = new System.Windows.Forms.Label();
            this.label246 = new System.Windows.Forms.Label();
            this.label247 = new System.Windows.Forms.Label();
            this.label248 = new System.Windows.Forms.Label();
            this.label249 = new System.Windows.Forms.Label();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.label250 = new System.Windows.Forms.Label();
            this.label251 = new System.Windows.Forms.Label();
            this.label252 = new System.Windows.Forms.Label();
            this.grp_with_cp = new System.Windows.Forms.Panel();
            this.grp_with_cp1 = new System.Windows.Forms.GroupBox();
            this.lblLoanP9 = new System.Windows.Forms.TextBox();
            this.lblLoanP8 = new System.Windows.Forms.TextBox();
            this.lblLoanP7 = new System.Windows.Forms.TextBox();
            this.cbContactPersonCP = new System.Windows.Forms.ComboBox();
            this.cbCPPRHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbCPHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbCPPRHoldDate1 = new System.Windows.Forms.ComboBox();
            this.cbCPHoldDate1 = new System.Windows.Forms.ComboBox();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.cbCPaction2 = new System.Windows.Forms.ComboBox();
            this.cbCPaction1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.txtCPAmount3 = new System.Windows.Forms.TextBox();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.txtCPAmount2 = new System.Windows.Forms.TextBox();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.label204 = new System.Windows.Forms.Label();
            this.label292 = new System.Windows.Forms.Label();
            this.label293 = new System.Windows.Forms.Label();
            this.cbContactCPPlace = new System.Windows.Forms.ComboBox();
            this.txtRemarkCP = new System.Windows.Forms.TextBox();
            this.label294 = new System.Windows.Forms.Label();
            this.label295 = new System.Windows.Forms.Label();
            this.label296 = new System.Windows.Forms.Label();
            this.label297 = new System.Windows.Forms.Label();
            this.label298 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.label299 = new System.Windows.Forms.Label();
            this.btncancel4 = new System.Windows.Forms.Button();
            this.label205 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.grp_with_borrower = new System.Windows.Forms.Panel();
            this.grp_with_borrower1 = new System.Windows.Forms.GroupBox();
            this.lblLoanP6 = new System.Windows.Forms.TextBox();
            this.lblLoanP5 = new System.Windows.Forms.TextBox();
            this.lblLoanP4 = new System.Windows.Forms.TextBox();
            this.label291 = new System.Windows.Forms.Label();
            this.cbBPRHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbBHoldDate2 = new System.Windows.Forms.ComboBox();
            this.cbBPRHoldDate1 = new System.Windows.Forms.ComboBox();
            this.cbBHoldDate1 = new System.Windows.Forms.ComboBox();
            this.label286 = new System.Windows.Forms.Label();
            this.label287 = new System.Windows.Forms.Label();
            this.label288 = new System.Windows.Forms.Label();
            this.label289 = new System.Windows.Forms.Label();
            this.cbBaction2 = new System.Windows.Forms.ComboBox();
            this.cbBaction1 = new System.Windows.Forms.ComboBox();
            this.btnCallBack = new System.Windows.Forms.Button();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.txtBAmount3 = new System.Windows.Forms.TextBox();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.txtBAmount2 = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.cbContactBPlace = new System.Windows.Forms.ComboBox();
            this.txtRemarkB = new System.Windows.Forms.TextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.btnNextCallB = new System.Windows.Forms.Button();
            this.label182 = new System.Windows.Forms.Label();
            this.btncancel3 = new System.Windows.Forms.Button();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.grp_ptp = new System.Windows.Forms.Panel();
            this.grp_ptp1 = new System.Windows.Forms.GroupBox();
            this.lblLoan10 = new System.Windows.Forms.TextBox();
            this.lblLoan9 = new System.Windows.Forms.TextBox();
            this.lblLoan8 = new System.Windows.Forms.TextBox();
            this.label285 = new System.Windows.Forms.Label();
            this.label284 = new System.Windows.Forms.Label();
            this.label283 = new System.Windows.Forms.Label();
            this.label282 = new System.Windows.Forms.Label();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.cbActionCode2 = new System.Windows.Forms.ComboBox();
            this.cbPTPPRDate2 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.cbPTPHoldDate3 = new System.Windows.Forms.ComboBox();
            this.txtPTPAmount3 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.cbActionCode1 = new System.Windows.Forms.ComboBox();
            this.cbPTPPRDate1 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.cbPTPHoldDate2 = new System.Windows.Forms.ComboBox();
            this.txtPTPAmount2 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.cbPTPHoldDate = new System.Windows.Forms.ComboBox();
            this.cbContactPerson = new System.Windows.Forms.ComboBox();
            this.cbContactPlace = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtPTPAmount1 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.btnUpdatePTP = new System.Windows.Forms.Button();
            this.label82 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.grp_phone_leave_message = new System.Windows.Forms.Panel();
            this.grp_phone_leave_message1 = new System.Windows.Forms.GroupBox();
            this.lblLoanP3 = new System.Windows.Forms.TextBox();
            this.lblLoanP2 = new System.Windows.Forms.TextBox();
            this.lblLoanP1 = new System.Windows.Forms.TextBox();
            this.lblSendback = new System.Windows.Forms.Label();
            this.btnSendback = new System.Windows.Forms.Button();
            this.label268 = new System.Windows.Forms.Label();
            this.lblactioncode2 = new System.Windows.Forms.Label();
            this.cbPLaction2 = new System.Windows.Forms.ComboBox();
            this.label253 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.cbPLaction1 = new System.Windows.Forms.ComboBox();
            this.label255 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.cbContactPersonPl = new System.Windows.Forms.ComboBox();
            this.cbContactPLPlace = new System.Windows.Forms.ComboBox();
            this.txtRemarkleave = new System.Windows.Forms.TextBox();
            this.label257 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label259 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.button39 = new System.Windows.Forms.Button();
            this.label262 = new System.Windows.Forms.Label();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.label263 = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.label265 = new System.Windows.Forms.Label();
            this.grp_action = new System.Windows.Forms.Panel();
            this.grp_action1 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.btnPTP = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.lblInhouseScore = new System.Windows.Forms.TextBox();
            this.lblForeClosure_amt1 = new System.Windows.Forms.TextBox();
            this.lblBilingCycle = new System.Windows.Forms.TextBox();
            this.lblDPD4 = new System.Windows.Forms.TextBox();
            this.lblLastPaymentDate = new System.Windows.Forms.TextBox();
            this.lblLastPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblOpenDate = new System.Windows.Forms.TextBox();
            this.lblBucket7 = new System.Windows.Forms.TextBox();
            this.lblBucket6 = new System.Windows.Forms.TextBox();
            this.lblBucket5 = new System.Windows.Forms.TextBox();
            this.lblBucket4 = new System.Windows.Forms.TextBox();
            this.lblBucket3 = new System.Windows.Forms.TextBox();
            this.lblBucket2 = new System.Windows.Forms.TextBox();
            this.lblBucket1 = new System.Windows.Forms.TextBox();
            this.lblChargesOverdue = new System.Windows.Forms.TextBox();
            this.lblInterestOverdue = new System.Windows.Forms.TextBox();
            this.lblPrincipleOverdue = new System.Windows.Forms.TextBox();
            this.lblAmountOverdue = new System.Windows.Forms.TextBox();
            this.lblOutstanding = new System.Windows.Forms.TextBox();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPother = new System.Windows.Forms.TextBox();
            this.lblPoffice = new System.Windows.Forms.TextBox();
            this.lblPhome = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.TextBox();
            this.lblCustName1 = new System.Windows.Forms.TextBox();
            this.lblLoan4 = new System.Windows.Forms.TextBox();
            this.lblServiceName2 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblCONTACT_PLACE8 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE7 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE6 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE5 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE4 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE3 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE2 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_PLACE1 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED8 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED7 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED6 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED5 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED4 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED3 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED2 = new System.Windows.Forms.TextBox();
            this.lblPERSON_CONTACTED1 = new System.Windows.Forms.TextBox();
            this.lblREMARKS8 = new System.Windows.Forms.TextBox();
            this.lblREMARKS7 = new System.Windows.Forms.TextBox();
            this.lblREMARKS6 = new System.Windows.Forms.TextBox();
            this.lblREMARKS5 = new System.Windows.Forms.TextBox();
            this.lblREMARKS4 = new System.Windows.Forms.TextBox();
            this.lblREMARKS3 = new System.Windows.Forms.TextBox();
            this.lblREMARKS2 = new System.Windows.Forms.TextBox();
            this.lblREMARKS1 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY8 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY7 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY6 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY5 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY4 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY3 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY2 = new System.Windows.Forms.TextBox();
            this.lblCONTACTED_BY1 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE8 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE7 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE6 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE5 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE4 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE3 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE2 = new System.Windows.Forms.TextBox();
            this.lblCONTACT_DATE1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE7 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE6 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE5 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE4 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE3 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE2 = new System.Windows.Forms.TextBox();
            this.lblACTION_CODE1 = new System.Windows.Forms.TextBox();
            this.label175 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblAgent6_c = new System.Windows.Forms.TextBox();
            this.lblAgent5_c = new System.Windows.Forms.TextBox();
            this.lblAgent4_c = new System.Windows.Forms.TextBox();
            this.lblAgent3_c = new System.Windows.Forms.TextBox();
            this.lblAgent2_c = new System.Windows.Forms.TextBox();
            this.lblAgent1_c = new System.Windows.Forms.TextBox();
            this.lblDisp6_Id = new System.Windows.Forms.TextBox();
            this.lblDisp5_Id = new System.Windows.Forms.TextBox();
            this.lblDisp4_Id = new System.Windows.Forms.TextBox();
            this.lblDisp3_Id = new System.Windows.Forms.TextBox();
            this.lblDisp2_Id = new System.Windows.Forms.TextBox();
            this.lblDisp1_Id = new System.Windows.Forms.TextBox();
            this.lblCall6_dt = new System.Windows.Forms.TextBox();
            this.lblCall5_dt = new System.Windows.Forms.TextBox();
            this.lblCall4_dt = new System.Windows.Forms.TextBox();
            this.lblCall3_dt = new System.Windows.Forms.TextBox();
            this.lblCall2_dt = new System.Windows.Forms.TextBox();
            this.lblCall1_dt = new System.Windows.Forms.TextBox();
            this.lblCall6_Phone = new System.Windows.Forms.TextBox();
            this.lblCall5_Phone = new System.Windows.Forms.TextBox();
            this.lblCall4_Phone = new System.Windows.Forms.TextBox();
            this.lblCall3_Phone = new System.Windows.Forms.TextBox();
            this.lblCall2_Phone = new System.Windows.Forms.TextBox();
            this.lblCall1_Phone = new System.Windows.Forms.TextBox();
            this.label103 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblAO_additional2 = new System.Windows.Forms.TextBox();
            this.lblAO_additional1 = new System.Windows.Forms.TextBox();
            this.lblPrincipal_additional2 = new System.Windows.Forms.TextBox();
            this.lblPrincipal_additional1 = new System.Windows.Forms.TextBox();
            this.lblDPD_additional2 = new System.Windows.Forms.TextBox();
            this.lblDPD_additional1 = new System.Windows.Forms.TextBox();
            this.lblLoad_additional2 = new System.Windows.Forms.TextBox();
            this.lblLoad_additional1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrg = new System.Windows.Forms.TextBox();
            this.lblzipcode = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.TextBox();
            this.lblSpecialStage = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.TextBox();
            this.label214 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label230 = new System.Windows.Forms.Label();
            this.label231 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label242 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblLoan6 = new System.Windows.Forms.TextBox();
            this.lblPother2 = new System.Windows.Forms.TextBox();
            this.lblPoffice2 = new System.Windows.Forms.TextBox();
            this.lblPhome2 = new System.Windows.Forms.TextBox();
            this.lblRegion2 = new System.Windows.Forms.TextBox();
            this.lblGender2 = new System.Windows.Forms.TextBox();
            this.lblProduct2 = new System.Windows.Forms.TextBox();
            this.lblDOB2 = new System.Windows.Forms.TextBox();
            this.lblCustomerName3 = new System.Windows.Forms.TextBox();
            this.lblDnis = new System.Windows.Forms.TextBox();
            this.lblServiceName3 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.customerTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtContact2 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.txtContact1 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.btnUpdateAddress = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lblMOBILE_O = new System.Windows.Forms.TextBox();
            this.lblCONTACT2_O = new System.Windows.Forms.TextBox();
            this.lblCONTACT1_O = new System.Windows.Forms.TextBox();
            this.lblCITY_O = new System.Windows.Forms.TextBox();
            this.lblALAMAT_O = new System.Windows.Forms.TextBox();
            this.lblMOBILE_E = new System.Windows.Forms.TextBox();
            this.lblCONTACT2_E = new System.Windows.Forms.TextBox();
            this.lblCONTACT1_E = new System.Windows.Forms.TextBox();
            this.lblCITY_E = new System.Windows.Forms.TextBox();
            this.lblALAMAT_E = new System.Windows.Forms.TextBox();
            this.lblMOBILE_P = new System.Windows.Forms.TextBox();
            this.lblCONTACT2_P = new System.Windows.Forms.TextBox();
            this.lblCITY_P = new System.Windows.Forms.TextBox();
            this.lblCONTACT1_P = new System.Windows.Forms.TextBox();
            this.lblALAMAT_P = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lblLoan7 = new System.Windows.Forms.TextBox();
            this.lblPother3 = new System.Windows.Forms.TextBox();
            this.lblPoffice3 = new System.Windows.Forms.TextBox();
            this.lblPhome3 = new System.Windows.Forms.TextBox();
            this.lblRegion3 = new System.Windows.Forms.TextBox();
            this.lblGender3 = new System.Windows.Forms.TextBox();
            this.lblProduct3 = new System.Windows.Forms.TextBox();
            this.lblDOB3 = new System.Windows.Forms.TextBox();
            this.lblCustomerName4 = new System.Windows.Forms.TextBox();
            this.lblDnis2 = new System.Windows.Forms.TextBox();
            this.lblServiceName4 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtDisposisiDesc = new System.Windows.Forms.TextBox();
            this.grpschedule = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label222 = new System.Windows.Forms.Label();
            this.rbsameAgent = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.callbackTime = new System.Windows.Forms.DateTimePicker();
            this.TZComboBox = new System.Windows.Forms.ComboBox();
            this.cbSnooze = new System.Windows.Forms.ComboBox();
            this.label224 = new System.Windows.Forms.Label();
            this.cbOutbound = new System.Windows.Forms.ComboBox();
            this.label225 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.callbackdate = new System.Windows.Forms.DateTimePicker();
            this.btnDisposisi = new System.Windows.Forms.Button();
            this.label223 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.cbDisposisi1 = new MultiColumnComboBoxDemo.MultiColumnComboBox();
            this.grpExclusion = new System.Windows.Forms.GroupBox();
            this.lblExclusionType = new System.Windows.Forms.Label();
            this.label236 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.label209 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label233 = new System.Windows.Forms.Label();
            this.txtphoneEx = new System.Windows.Forms.TextBox();
            this.cbApplication = new System.Windows.Forms.ComboBox();
            this.cbExclusionType = new System.Windows.Forms.ComboBox();
            this.cbExclusionTimezone = new System.Windows.Forms.ComboBox();
            this.label208 = new System.Windows.Forms.Label();
            this.grpDial = new System.Windows.Forms.GroupBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btn3Way = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnDial = new System.Windows.Forms.Button();
            this.btnHangup = new System.Windows.Forms.Button();
            this.txtdial = new System.Windows.Forms.TextBox();
            this.Detail3 = new System.Windows.Forms.Panel();
            this.Detail2 = new System.Windows.Forms.Panel();
            this.Detail1 = new System.Windows.Forms.Panel();
            this.pnlWrap = new System.Windows.Forms.Panel();
            this.lblWrapAction = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.lbltimeWrap = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtCallback = new System.Windows.Forms.TextBox();
            this.txtDNISH = new System.Windows.Forms.TextBox();
            this.txtphonenumberh = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.pnlAnswerCall = new System.Windows.Forms.Panel();
            this.lblAnswerCallCountDown = new System.Windows.Forms.Label();
            this.btnRejectCall = new System.Windows.Forms.Button();
            this.btnAcceptCall = new System.Windows.Forms.Button();
            this.Header33 = new System.Windows.Forms.Panel();
            this.label244 = new System.Windows.Forms.Label();
            this.lblPlus3 = new System.Windows.Forms.Label();
            this.Header22 = new System.Windows.Forms.Panel();
            this.label241 = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.Header11 = new System.Windows.Forms.Panel();
            this.label290 = new System.Windows.Forms.Label();
            this.lblPlus1 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dialerTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_phone_remainder.SuspendLayout();
            this.grp_phone_remainder1.SuspendLayout();
            this.grp_phone_not_answer.SuspendLayout();
            this.grp_phone_not_answer1.SuspendLayout();
            this.grp_with_cp.SuspendLayout();
            this.grp_with_cp1.SuspendLayout();
            this.grp_with_borrower.SuspendLayout();
            this.grp_with_borrower1.SuspendLayout();
            this.grp_ptp.SuspendLayout();
            this.grp_ptp1.SuspendLayout();
            this.grp_phone_leave_message.SuspendLayout();
            this.grp_phone_leave_message1.SuspendLayout();
            this.grp_action.SuspendLayout();
            this.grp_action1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel15.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel13.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.customerTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel19.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.panel18.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.panel17.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.grpschedule.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.grpExclusion.SuspendLayout();
            this.grpDial.SuspendLayout();
            this.Detail3.SuspendLayout();
            this.Detail2.SuspendLayout();
            this.Detail1.SuspendLayout();
            this.pnlWrap.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.pnlAnswerCall.SuspendLayout();
            this.Header33.SuspendLayout();
            this.Header22.SuspendLayout();
            this.Header11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.mainTabControl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1011, 587);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homeTabPage);
            this.mainTabControl.Controls.Add(this.dialerTabPage);
            this.mainTabControl.Controls.Add(this.infoTabPage);
            this.mainTabControl.Controls.Add(this.customerTabPage);
            this.mainTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(-9, 50);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(20, 10);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1267, 421);
            this.mainTabControl.TabIndex = 0;
            // 
            // homeTabPage
            // 
            this.homeTabPage.BackColor = System.Drawing.Color.White;
            this.homeTabPage.Controls.Add(this.panel4);
            this.homeTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTabPage.Location = new System.Drawing.Point(4, 38);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeTabPage.Size = new System.Drawing.Size(1259, 379);
            this.homeTabPage.TabIndex = 0;
            this.homeTabPage.Text = "Home";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1253, 373);
            this.panel4.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblServiceName);
            this.groupBox3.Controls.Add(this.lblservicecaption);
            this.groupBox3.Controls.Add(this.label107);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.label124);
            this.groupBox3.Controls.Add(this.label117);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1253, 94);
            this.groupBox3.TabIndex = 264;
            this.groupBox3.TabStop = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(219, 22);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(39, 15);
            this.lblServiceName.TabIndex = 265;
            this.lblServiceName.Text = "Loan1";
            // 
            // lblservicecaption
            // 
            this.lblservicecaption.AutoSize = true;
            this.lblservicecaption.BackColor = System.Drawing.Color.SandyBrown;
            this.lblservicecaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicecaption.Location = new System.Drawing.Point(11, 22);
            this.lblservicecaption.Name = "lblservicecaption";
            this.lblservicecaption.Size = new System.Drawing.Size(79, 15);
            this.lblservicecaption.TabIndex = 264;
            this.lblservicecaption.Text = "Service Name";
            // 
            // label107
            // 
            this.label107.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label107.BackColor = System.Drawing.Color.Yellow;
            this.label107.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.Location = new System.Drawing.Point(207, 17);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(1035, 25);
            this.label107.TabIndex = 263;
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(366, 55);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 262;
            this.button8.Text = "Others";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(285, 55);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 261;
            this.button7.Text = "Office";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(204, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 260;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button12
            // 
            this.button12.AllowDrop = true;
            this.button12.AutoEllipsis = true;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(123, 55);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 259;
            this.button12.Text = "Mobile";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.Location = new System.Drawing.Point(8, 55);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(68, 15);
            this.label124.TabIndex = 258;
            this.label124.Text = "Contact No";
            // 
            // label117
            // 
            this.label117.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label117.BackColor = System.Drawing.Color.SandyBrown;
            this.label117.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.Location = new System.Drawing.Point(8, 17);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(462, 25);
            this.label117.TabIndex = 266;
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPrincipal2);
            this.groupBox2.Controls.Add(this.lblPrincipal3);
            this.groupBox2.Controls.Add(this.lblDPD2);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Controls.Add(this.lblDPD1);
            this.groupBox2.Controls.Add(this.LblPrincipal1);
            this.groupBox2.Controls.Add(this.lblAmt);
            this.groupBox2.Controls.Add(this.lblLoan3);
            this.groupBox2.Controls.Add(this.lblLoan2);
            this.groupBox2.Controls.Add(this.lblLoan1);
            this.groupBox2.Controls.Add(this.label118);
            this.groupBox2.Controls.Add(this.label116);
            this.groupBox2.Controls.Add(this.label115);
            this.groupBox2.Controls.Add(this.label58);
            this.groupBox2.Controls.Add(this.label59);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label77);
            this.groupBox2.Controls.Add(this.label100);
            this.groupBox2.Controls.Add(this.label101);
            this.groupBox2.Controls.Add(this.label104);
            this.groupBox2.Controls.Add(this.label105);
            this.groupBox2.Controls.Add(this.label106);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(2, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1339, 261);
            this.groupBox2.TabIndex = 263;
            this.groupBox2.TabStop = false;
            // 
            // lblPrincipal2
            // 
            this.lblPrincipal2.BackColor = System.Drawing.Color.White;
            this.lblPrincipal2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrincipal2.Location = new System.Drawing.Point(529, 86);
            this.lblPrincipal2.Name = "lblPrincipal2";
            this.lblPrincipal2.ReadOnly = true;
            this.lblPrincipal2.Size = new System.Drawing.Size(270, 16);
            this.lblPrincipal2.TabIndex = 297;
            this.lblPrincipal2.Text = "Loan";
            // 
            // lblPrincipal3
            // 
            this.lblPrincipal3.BackColor = System.Drawing.Color.White;
            this.lblPrincipal3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrincipal3.Location = new System.Drawing.Point(932, 86);
            this.lblPrincipal3.Name = "lblPrincipal3";
            this.lblPrincipal3.ReadOnly = true;
            this.lblPrincipal3.Size = new System.Drawing.Size(270, 16);
            this.lblPrincipal3.TabIndex = 296;
            this.lblPrincipal3.Text = "Loan";
            // 
            // lblDPD2
            // 
            this.lblDPD2.BackColor = System.Drawing.Color.White;
            this.lblDPD2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDPD2.Location = new System.Drawing.Point(932, 122);
            this.lblDPD2.Name = "lblDPD2";
            this.lblDPD2.ReadOnly = true;
            this.lblDPD2.Size = new System.Drawing.Size(270, 16);
            this.lblDPD2.TabIndex = 295;
            this.lblDPD2.Text = "Loan";
            // 
            // lblCustName
            // 
            this.lblCustName.BackColor = System.Drawing.Color.White;
            this.lblCustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustName.Location = new System.Drawing.Point(134, 86);
            this.lblCustName.Multiline = true;
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.ReadOnly = true;
            this.lblCustName.Size = new System.Drawing.Size(268, 31);
            this.lblCustName.TabIndex = 294;
            this.lblCustName.Text = "Loan";
            // 
            // lblDPD1
            // 
            this.lblDPD1.BackColor = System.Drawing.Color.White;
            this.lblDPD1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDPD1.Location = new System.Drawing.Point(529, 122);
            this.lblDPD1.Name = "lblDPD1";
            this.lblDPD1.ReadOnly = true;
            this.lblDPD1.Size = new System.Drawing.Size(270, 16);
            this.lblDPD1.TabIndex = 293;
            this.lblDPD1.Text = "Loan";
            // 
            // LblPrincipal1
            // 
            this.LblPrincipal1.BackColor = System.Drawing.Color.White;
            this.LblPrincipal1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LblPrincipal1.Location = new System.Drawing.Point(134, 147);
            this.LblPrincipal1.Name = "LblPrincipal1";
            this.LblPrincipal1.ReadOnly = true;
            this.LblPrincipal1.Size = new System.Drawing.Size(270, 16);
            this.LblPrincipal1.TabIndex = 292;
            this.LblPrincipal1.Text = "Loan";
            // 
            // lblAmt
            // 
            this.lblAmt.BackColor = System.Drawing.Color.White;
            this.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAmt.Location = new System.Drawing.Point(134, 122);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.ReadOnly = true;
            this.lblAmt.Size = new System.Drawing.Size(270, 16);
            this.lblAmt.TabIndex = 291;
            this.lblAmt.Text = "Loan";
            // 
            // lblLoan3
            // 
            this.lblLoan3.BackColor = System.Drawing.Color.White;
            this.lblLoan3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan3.Location = new System.Drawing.Point(932, 60);
            this.lblLoan3.Name = "lblLoan3";
            this.lblLoan3.ReadOnly = true;
            this.lblLoan3.Size = new System.Drawing.Size(270, 16);
            this.lblLoan3.TabIndex = 290;
            this.lblLoan3.Text = "Loan";
            // 
            // lblLoan2
            // 
            this.lblLoan2.BackColor = System.Drawing.Color.White;
            this.lblLoan2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan2.Location = new System.Drawing.Point(529, 61);
            this.lblLoan2.Name = "lblLoan2";
            this.lblLoan2.ReadOnly = true;
            this.lblLoan2.Size = new System.Drawing.Size(270, 16);
            this.lblLoan2.TabIndex = 289;
            this.lblLoan2.Text = "Loan";
            // 
            // lblLoan1
            // 
            this.lblLoan1.BackColor = System.Drawing.Color.White;
            this.lblLoan1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan1.Location = new System.Drawing.Point(134, 61);
            this.lblLoan1.Name = "lblLoan1";
            this.lblLoan1.ReadOnly = true;
            this.lblLoan1.Size = new System.Drawing.Size(270, 16);
            this.lblLoan1.TabIndex = 288;
            this.lblLoan1.Text = "Loan";
            // 
            // label118
            // 
            this.label118.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label118.BackColor = System.Drawing.Color.Red;
            this.label118.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.Location = new System.Drawing.Point(811, 21);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(520, 25);
            this.label118.TabIndex = 285;
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label116.BackColor = System.Drawing.Color.SandyBrown;
            this.label116.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.Location = new System.Drawing.Point(409, 21);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(550, 25);
            this.label116.TabIndex = 284;
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label115.BackColor = System.Drawing.Color.Olive;
            this.label115.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.Location = new System.Drawing.Point(7, 21);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(533, 25);
            this.label115.TabIndex = 283;
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(814, 122);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(30, 15);
            this.label58.TabIndex = 272;
            this.label58.Text = "DPD";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(814, 86);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(101, 15);
            this.label59.TabIndex = 271;
            this.label59.Text = "Principle Overdue";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(420, 122);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(30, 15);
            this.label57.TabIndex = 270;
            this.label57.Text = "DPD";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(420, 86);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(101, 15);
            this.label56.TabIndex = 269;
            this.label56.Text = "Principle Overdue";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(814, 60);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(80, 15);
            this.label77.TabIndex = 268;
            this.label77.Text = "Loan Number";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(420, 61);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(80, 15);
            this.label100.TabIndex = 267;
            this.label100.Text = "Loan Number";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.Location = new System.Drawing.Point(13, 147);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(101, 15);
            this.label101.TabIndex = 266;
            this.label101.Text = "Principle Overdue";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.Location = new System.Drawing.Point(13, 122);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(93, 15);
            this.label104.TabIndex = 265;
            this.label104.Text = "For Closure Amt";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.Location = new System.Drawing.Point(13, 86);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(94, 15);
            this.label105.TabIndex = 264;
            this.label105.Text = "Customer Name";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.Location = new System.Drawing.Point(13, 61);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(80, 15);
            this.label106.TabIndex = 263;
            this.label106.Text = "Loan Number";
            // 
            // dialerTabPage
            // 
            this.dialerTabPage.BackColor = System.Drawing.Color.White;
            this.dialerTabPage.Controls.Add(this.panel1);
            this.dialerTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dialerTabPage.Location = new System.Drawing.Point(4, 38);
            this.dialerTabPage.Name = "dialerTabPage";
            this.dialerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dialerTabPage.Size = new System.Drawing.Size(1259, 379);
            this.dialerTabPage.TabIndex = 1;
            this.dialerTabPage.Text = "Dialer Contact Recording";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.grp_phone_remainder);
            this.panel1.Controls.Add(this.grp_phone_not_answer);
            this.panel1.Controls.Add(this.grp_with_cp);
            this.panel1.Controls.Add(this.grp_with_borrower);
            this.panel1.Controls.Add(this.grp_ptp);
            this.panel1.Controls.Add(this.grp_phone_leave_message);
            this.panel1.Controls.Add(this.grp_action);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1253, 373);
            this.panel1.TabIndex = 1;
            // 
            // grp_phone_remainder
            // 
            this.grp_phone_remainder.Controls.Add(this.grp_phone_remainder1);
            this.grp_phone_remainder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_phone_remainder.Location = new System.Drawing.Point(0, 2424);
            this.grp_phone_remainder.Name = "grp_phone_remainder";
            this.grp_phone_remainder.Size = new System.Drawing.Size(1236, 341);
            this.grp_phone_remainder.TabIndex = 330;
            // 
            // grp_phone_remainder1
            // 
            this.grp_phone_remainder1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_phone_remainder1.Controls.Add(this.cbPRPRHoldDate0);
            this.grp_phone_remainder1.Controls.Add(this.label237);
            this.grp_phone_remainder1.Controls.Add(this.lblLoanP12);
            this.grp_phone_remainder1.Controls.Add(this.lblLoanP11);
            this.grp_phone_remainder1.Controls.Add(this.lblLoanP10);
            this.grp_phone_remainder1.Controls.Add(this.cbContactPersonPR);
            this.grp_phone_remainder1.Controls.Add(this.cbPRPRHoldDate2);
            this.grp_phone_remainder1.Controls.Add(this.cbPRHoldDate2);
            this.grp_phone_remainder1.Controls.Add(this.cbPRPRHoldDate1);
            this.grp_phone_remainder1.Controls.Add(this.cbPRHoldDate1);
            this.grp_phone_remainder1.Controls.Add(this.label210);
            this.grp_phone_remainder1.Controls.Add(this.label211);
            this.grp_phone_remainder1.Controls.Add(this.label212);
            this.grp_phone_remainder1.Controls.Add(this.label213);
            this.grp_phone_remainder1.Controls.Add(this.cbPRaction2);
            this.grp_phone_remainder1.Controls.Add(this.cbPRaction1);
            this.grp_phone_remainder1.Controls.Add(this.button23);
            this.grp_phone_remainder1.Controls.Add(this.label215);
            this.grp_phone_remainder1.Controls.Add(this.label216);
            this.grp_phone_remainder1.Controls.Add(this.txtPRAmount3);
            this.grp_phone_remainder1.Controls.Add(this.label217);
            this.grp_phone_remainder1.Controls.Add(this.label218);
            this.grp_phone_remainder1.Controls.Add(this.label219);
            this.grp_phone_remainder1.Controls.Add(this.label220);
            this.grp_phone_remainder1.Controls.Add(this.label221);
            this.grp_phone_remainder1.Controls.Add(this.label269);
            this.grp_phone_remainder1.Controls.Add(this.txtPRAmount2);
            this.grp_phone_remainder1.Controls.Add(this.label271);
            this.grp_phone_remainder1.Controls.Add(this.label272);
            this.grp_phone_remainder1.Controls.Add(this.label273);
            this.grp_phone_remainder1.Controls.Add(this.label274);
            this.grp_phone_remainder1.Controls.Add(this.label275);
            this.grp_phone_remainder1.Controls.Add(this.cbContactPRPlace);
            this.grp_phone_remainder1.Controls.Add(this.txtRemarkPR);
            this.grp_phone_remainder1.Controls.Add(this.label276);
            this.grp_phone_remainder1.Controls.Add(this.label277);
            this.grp_phone_remainder1.Controls.Add(this.label278);
            this.grp_phone_remainder1.Controls.Add(this.label279);
            this.grp_phone_remainder1.Controls.Add(this.label280);
            this.grp_phone_remainder1.Controls.Add(this.button24);
            this.grp_phone_remainder1.Controls.Add(this.label281);
            this.grp_phone_remainder1.Controls.Add(this.button25);
            this.grp_phone_remainder1.Controls.Add(this.label301);
            this.grp_phone_remainder1.Controls.Add(this.label302);
            this.grp_phone_remainder1.Controls.Add(this.label303);
            this.grp_phone_remainder1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_phone_remainder1.Location = new System.Drawing.Point(5, 3);
            this.grp_phone_remainder1.Name = "grp_phone_remainder1";
            this.grp_phone_remainder1.Size = new System.Drawing.Size(2187, 341);
            this.grp_phone_remainder1.TabIndex = 321;
            this.grp_phone_remainder1.TabStop = false;
            // 
            // cbPRPRHoldDate0
            // 
            this.cbPRPRHoldDate0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRPRHoldDate0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRPRHoldDate0.FormattingEnabled = true;
            this.cbPRPRHoldDate0.Items.AddRange(new object[] {
            "PTP"});
            this.cbPRPRHoldDate0.Location = new System.Drawing.Point(183, 201);
            this.cbPRPRHoldDate0.Name = "cbPRPRHoldDate0";
            this.cbPRPRHoldDate0.Size = new System.Drawing.Size(153, 23);
            this.cbPRPRHoldDate0.TabIndex = 6008;
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label237.Location = new System.Drawing.Point(22, 201);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(77, 15);
            this.label237.TabIndex = 500;
            this.label237.Text = "PR Hold Date";
            // 
            // lblLoanP12
            // 
            this.lblLoanP12.BackColor = System.Drawing.Color.White;
            this.lblLoanP12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP12.Location = new System.Drawing.Point(894, 48);
            this.lblLoanP12.Name = "lblLoanP12";
            this.lblLoanP12.ReadOnly = true;
            this.lblLoanP12.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP12.TabIndex = 499;
            this.lblLoanP12.Text = "Loan";
            // 
            // lblLoanP11
            // 
            this.lblLoanP11.BackColor = System.Drawing.Color.White;
            this.lblLoanP11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP11.Location = new System.Drawing.Point(559, 48);
            this.lblLoanP11.Name = "lblLoanP11";
            this.lblLoanP11.ReadOnly = true;
            this.lblLoanP11.Size = new System.Drawing.Size(173, 15);
            this.lblLoanP11.TabIndex = 498;
            this.lblLoanP11.Text = "Loan";
            // 
            // lblLoanP10
            // 
            this.lblLoanP10.BackColor = System.Drawing.Color.White;
            this.lblLoanP10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP10.Location = new System.Drawing.Point(183, 48);
            this.lblLoanP10.Name = "lblLoanP10";
            this.lblLoanP10.ReadOnly = true;
            this.lblLoanP10.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP10.TabIndex = 497;
            this.lblLoanP10.Text = "Loan";
            // 
            // cbContactPersonPR
            // 
            this.cbContactPersonPR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPersonPR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPersonPR.FormattingEnabled = true;
            this.cbContactPersonPR.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPersonPR.Location = new System.Drawing.Point(183, 169);
            this.cbContactPersonPR.Name = "cbContactPersonPR";
            this.cbContactPersonPR.Size = new System.Drawing.Size(153, 23);
            this.cbContactPersonPR.TabIndex = 6005;
            // 
            // cbPRPRHoldDate2
            // 
            this.cbPRPRHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRPRHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRPRHoldDate2.FormattingEnabled = true;
            this.cbPRPRHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbPRPRHoldDate2.Location = new System.Drawing.Point(898, 200);
            this.cbPRPRHoldDate2.Name = "cbPRPRHoldDate2";
            this.cbPRPRHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbPRPRHoldDate2.TabIndex = 6010;
            // 
            // cbPRHoldDate2
            // 
            this.cbPRHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRHoldDate2.FormattingEnabled = true;
            this.cbPRHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbPRHoldDate2.Location = new System.Drawing.Point(898, 169);
            this.cbPRHoldDate2.Name = "cbPRHoldDate2";
            this.cbPRHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbPRHoldDate2.TabIndex = 6007;
            // 
            // cbPRPRHoldDate1
            // 
            this.cbPRPRHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRPRHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRPRHoldDate1.FormattingEnabled = true;
            this.cbPRPRHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbPRPRHoldDate1.Location = new System.Drawing.Point(560, 200);
            this.cbPRPRHoldDate1.Name = "cbPRPRHoldDate1";
            this.cbPRPRHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbPRPRHoldDate1.TabIndex = 6009;
            // 
            // cbPRHoldDate1
            // 
            this.cbPRHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRHoldDate1.FormattingEnabled = true;
            this.cbPRHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbPRHoldDate1.Location = new System.Drawing.Point(560, 169);
            this.cbPRHoldDate1.Name = "cbPRHoldDate1";
            this.cbPRHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbPRHoldDate1.TabIndex = 6006;
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label210.Location = new System.Drawing.Point(894, 109);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(45, 15);
            this.label210.TabIndex = 431;
            this.label210.Text = "DIALER";
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label211.Location = new System.Drawing.Point(559, 109);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(45, 15);
            this.label211.TabIndex = 430;
            this.label211.Text = "DIALER";
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label212.Location = new System.Drawing.Point(183, 109);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(45, 15);
            this.label212.TabIndex = 429;
            this.label212.Text = "DIALER";
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label213.Location = new System.Drawing.Point(183, 77);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(21, 15);
            this.label213.TabIndex = 428;
            this.label213.Text = "PR";
            // 
            // cbPRaction2
            // 
            this.cbPRaction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRaction2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRaction2.FormattingEnabled = true;
            this.cbPRaction2.Location = new System.Drawing.Point(894, 77);
            this.cbPRaction2.Name = "cbPRaction2";
            this.cbPRaction2.Size = new System.Drawing.Size(153, 23);
            this.cbPRaction2.TabIndex = 6001;
            // 
            // cbPRaction1
            // 
            this.cbPRaction1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPRaction1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRaction1.FormattingEnabled = true;
            this.cbPRaction1.Location = new System.Drawing.Point(559, 77);
            this.cbPRaction1.Name = "cbPRaction1";
            this.cbPRaction1.Size = new System.Drawing.Size(153, 23);
            this.cbPRaction1.TabIndex = 6000;
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(186, 266);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 27);
            this.button23.TabIndex = 6012;
            this.button23.Text = "Callback";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label215.Location = new System.Drawing.Point(22, 266);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(123, 15);
            this.label215.TabIndex = 423;
            this.label215.Text = "Schedule For Callback";
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label216.Location = new System.Drawing.Point(733, 200);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(77, 15);
            this.label216.TabIndex = 422;
            this.label216.Text = "PR Hold Date";
            // 
            // txtPRAmount3
            // 
            this.txtPRAmount3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPRAmount3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRAmount3.Location = new System.Drawing.Point(897, 137);
            this.txtPRAmount3.MaxLength = 20;
            this.txtPRAmount3.Name = "txtPRAmount3";
            this.txtPRAmount3.Size = new System.Drawing.Size(153, 23);
            this.txtPRAmount3.TabIndex = 6004;
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label217.Location = new System.Drawing.Point(733, 169);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(84, 15);
            this.label217.TabIndex = 420;
            this.label217.Text = "PTP Hold Date";
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label218.Location = new System.Drawing.Point(733, 137);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(75, 15);
            this.label218.TabIndex = 419;
            this.label218.Text = "PTP Amount";
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label219.Location = new System.Drawing.Point(733, 109);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(83, 15);
            this.label219.TabIndex = 418;
            this.label219.Text = "Contact Mode";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label220.Location = new System.Drawing.Point(733, 71);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(97, 30);
            this.label220.TabIndex = 417;
            this.label220.Text = "Action Code / \r\nDisposition Code";
            // 
            // label221
            // 
            this.label221.AutoSize = true;
            this.label221.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label221.Location = new System.Drawing.Point(733, 48);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(80, 15);
            this.label221.TabIndex = 416;
            this.label221.Text = "Loan Number";
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label269.Location = new System.Drawing.Point(395, 200);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(77, 15);
            this.label269.TabIndex = 415;
            this.label269.Text = "PR Hold Date";
            // 
            // txtPRAmount2
            // 
            this.txtPRAmount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPRAmount2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRAmount2.Location = new System.Drawing.Point(559, 137);
            this.txtPRAmount2.MaxLength = 20;
            this.txtPRAmount2.Name = "txtPRAmount2";
            this.txtPRAmount2.Size = new System.Drawing.Size(153, 23);
            this.txtPRAmount2.TabIndex = 6003;
            // 
            // label271
            // 
            this.label271.AutoSize = true;
            this.label271.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label271.Location = new System.Drawing.Point(395, 169);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(84, 15);
            this.label271.TabIndex = 413;
            this.label271.Text = "PTP Hold Date";
            // 
            // label272
            // 
            this.label272.AutoSize = true;
            this.label272.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label272.Location = new System.Drawing.Point(395, 137);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(75, 15);
            this.label272.TabIndex = 412;
            this.label272.Text = "PTP Amount";
            // 
            // label273
            // 
            this.label273.AutoSize = true;
            this.label273.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label273.Location = new System.Drawing.Point(395, 109);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(83, 15);
            this.label273.TabIndex = 411;
            this.label273.Text = "Contact Mode";
            // 
            // label274
            // 
            this.label274.AutoSize = true;
            this.label274.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label274.Location = new System.Drawing.Point(395, 71);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(97, 30);
            this.label274.TabIndex = 410;
            this.label274.Text = "Action Code / \r\nDisposition Code";
            // 
            // label275
            // 
            this.label275.AutoSize = true;
            this.label275.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label275.Location = new System.Drawing.Point(395, 48);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(80, 15);
            this.label275.TabIndex = 409;
            this.label275.Text = "Loan Number";
            // 
            // cbContactPRPlace
            // 
            this.cbContactPRPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPRPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPRPlace.FormattingEnabled = true;
            this.cbContactPRPlace.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPRPlace.Location = new System.Drawing.Point(183, 137);
            this.cbContactPRPlace.Name = "cbContactPRPlace";
            this.cbContactPRPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactPRPlace.TabIndex = 6002;
            // 
            // txtRemarkPR
            // 
            this.txtRemarkPR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkPR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkPR.Location = new System.Drawing.Point(186, 232);
            this.txtRemarkPR.MaxLength = 100;
            this.txtRemarkPR.Name = "txtRemarkPR";
            this.txtRemarkPR.Size = new System.Drawing.Size(735, 23);
            this.txtRemarkPR.TabIndex = 6011;
            this.txtRemarkPR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarkPR_KeyPress);
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label276.Location = new System.Drawing.Point(22, 232);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(52, 15);
            this.label276.TabIndex = 406;
            this.label276.Text = "Remarks";
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label277.Location = new System.Drawing.Point(22, 169);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(88, 15);
            this.label277.TabIndex = 405;
            this.label277.Text = "Contact Person";
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label278.Location = new System.Drawing.Point(22, 137);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(80, 15);
            this.label278.TabIndex = 404;
            this.label278.Text = "Contact Place";
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label279.Location = new System.Drawing.Point(22, 109);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(83, 15);
            this.label279.TabIndex = 403;
            this.label279.Text = "Contact Mode";
            // 
            // label280
            // 
            this.label280.AutoSize = true;
            this.label280.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label280.Location = new System.Drawing.Point(22, 71);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(97, 30);
            this.label280.TabIndex = 402;
            this.label280.Text = "Action Code / \r\nDisposition Code";
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(186, 299);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 27);
            this.button24.TabIndex = 6013;
            this.button24.Text = "Next Call";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label281
            // 
            this.label281.AutoSize = true;
            this.label281.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label281.Location = new System.Drawing.Point(22, 48);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(80, 15);
            this.label281.TabIndex = 400;
            this.label281.Text = "Loan Number";
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(264, 299);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 27);
            this.button25.TabIndex = 6014;
            this.button25.Text = "Cancel";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // label301
            // 
            this.label301.AutoSize = true;
            this.label301.BackColor = System.Drawing.Color.SandyBrown;
            this.label301.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label301.Location = new System.Drawing.Point(12, 21);
            this.label301.Name = "label301";
            this.label301.Size = new System.Drawing.Size(39, 15);
            this.label301.TabIndex = 303;
            this.label301.Text = "Result";
            // 
            // label302
            // 
            this.label302.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label302.BackColor = System.Drawing.Color.Yellow;
            this.label302.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label302.Location = new System.Drawing.Point(211, 16);
            this.label302.Name = "label302";
            this.label302.Size = new System.Drawing.Size(2431, 25);
            this.label302.TabIndex = 301;
            this.label302.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label303
            // 
            this.label303.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label303.BackColor = System.Drawing.Color.SandyBrown;
            this.label303.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label303.Location = new System.Drawing.Point(7, 16);
            this.label303.Name = "label303";
            this.label303.Size = new System.Drawing.Size(1769, 25);
            this.label303.TabIndex = 302;
            this.label303.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_phone_not_answer
            // 
            this.grp_phone_not_answer.Controls.Add(this.grp_phone_not_answer1);
            this.grp_phone_not_answer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_phone_not_answer.Location = new System.Drawing.Point(0, 2178);
            this.grp_phone_not_answer.Name = "grp_phone_not_answer";
            this.grp_phone_not_answer.Size = new System.Drawing.Size(1236, 246);
            this.grp_phone_not_answer.TabIndex = 329;
            // 
            // grp_phone_not_answer1
            // 
            this.grp_phone_not_answer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_phone_not_answer1.Controls.Add(this.label186);
            this.grp_phone_not_answer1.Controls.Add(this.label300);
            this.grp_phone_not_answer1.Controls.Add(this.lblActionCode);
            this.grp_phone_not_answer1.Controls.Add(this.cbContactNoAPlace);
            this.grp_phone_not_answer1.Controls.Add(this.txtRemarkNoAnswer);
            this.grp_phone_not_answer1.Controls.Add(this.label245);
            this.grp_phone_not_answer1.Controls.Add(this.label246);
            this.grp_phone_not_answer1.Controls.Add(this.label247);
            this.grp_phone_not_answer1.Controls.Add(this.label248);
            this.grp_phone_not_answer1.Controls.Add(this.label249);
            this.grp_phone_not_answer1.Controls.Add(this.button37);
            this.grp_phone_not_answer1.Controls.Add(this.button38);
            this.grp_phone_not_answer1.Controls.Add(this.label250);
            this.grp_phone_not_answer1.Controls.Add(this.label251);
            this.grp_phone_not_answer1.Controls.Add(this.label252);
            this.grp_phone_not_answer1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_phone_not_answer1.Location = new System.Drawing.Point(5, 3);
            this.grp_phone_not_answer1.Name = "grp_phone_not_answer1";
            this.grp_phone_not_answer1.Size = new System.Drawing.Size(2362, 246);
            this.grp_phone_not_answer1.TabIndex = 307;
            this.grp_phone_not_answer1.TabStop = false;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label186.Location = new System.Drawing.Point(229, 143);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(56, 15);
            this.label186.TabIndex = 358;
            this.label186.Text = "NOBODY";
            // 
            // label300
            // 
            this.label300.AutoSize = true;
            this.label300.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label300.Location = new System.Drawing.Point(229, 82);
            this.label300.Name = "label300";
            this.label300.Size = new System.Drawing.Size(45, 15);
            this.label300.TabIndex = 357;
            this.label300.Text = "DIALER";
            // 
            // lblActionCode
            // 
            this.lblActionCode.AutoSize = true;
            this.lblActionCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActionCode.Location = new System.Drawing.Point(229, 54);
            this.lblActionCode.Name = "lblActionCode";
            this.lblActionCode.Size = new System.Drawing.Size(23, 15);
            this.lblActionCode.TabIndex = 356;
            this.lblActionCode.Text = "PN";
            // 
            // cbContactNoAPlace
            // 
            this.cbContactNoAPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactNoAPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactNoAPlace.FormattingEnabled = true;
            this.cbContactNoAPlace.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactNoAPlace.Location = new System.Drawing.Point(229, 110);
            this.cbContactNoAPlace.Name = "cbContactNoAPlace";
            this.cbContactNoAPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactNoAPlace.TabIndex = 5000;
            // 
            // txtRemarkNoAnswer
            // 
            this.txtRemarkNoAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkNoAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkNoAnswer.Location = new System.Drawing.Point(229, 168);
            this.txtRemarkNoAnswer.MaxLength = 100;
            this.txtRemarkNoAnswer.Name = "txtRemarkNoAnswer";
            this.txtRemarkNoAnswer.Size = new System.Drawing.Size(715, 23);
            this.txtRemarkNoAnswer.TabIndex = 5001;
            this.txtRemarkNoAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarkNoAnswer_KeyPress);
            // 
            // label245
            // 
            this.label245.AutoSize = true;
            this.label245.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label245.Location = new System.Drawing.Point(16, 168);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(52, 15);
            this.label245.TabIndex = 351;
            this.label245.Text = "Remarks";
            // 
            // label246
            // 
            this.label246.AutoSize = true;
            this.label246.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label246.Location = new System.Drawing.Point(16, 138);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(88, 15);
            this.label246.TabIndex = 350;
            this.label246.Text = "Contact Person";
            // 
            // label247
            // 
            this.label247.AutoSize = true;
            this.label247.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label247.Location = new System.Drawing.Point(16, 110);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(80, 15);
            this.label247.TabIndex = 349;
            this.label247.Text = "Contact Place";
            // 
            // label248
            // 
            this.label248.AutoSize = true;
            this.label248.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label248.Location = new System.Drawing.Point(16, 82);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(83, 15);
            this.label248.TabIndex = 348;
            this.label248.Text = "Contact Mode";
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label249.Location = new System.Drawing.Point(16, 54);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(174, 15);
            this.label249.TabIndex = 347;
            this.label249.Text = "Action Code / Disposition Code";
            // 
            // button37
            // 
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button37.Location = new System.Drawing.Point(229, 205);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(92, 27);
            this.button37.TabIndex = 5002;
            this.button37.Text = "Save Activity";
            this.button37.UseVisualStyleBackColor = true;
            this.button37.Click += new System.EventHandler(this.button37_Click);
            // 
            // button38
            // 
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button38.Location = new System.Drawing.Point(331, 205);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(75, 27);
            this.button38.TabIndex = 5003;
            this.button38.Text = "Cancel";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.BackColor = System.Drawing.Color.SandyBrown;
            this.label250.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label250.Location = new System.Drawing.Point(12, 21);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(39, 15);
            this.label250.TabIndex = 303;
            this.label250.Text = "Result";
            // 
            // label251
            // 
            this.label251.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label251.BackColor = System.Drawing.Color.Yellow;
            this.label251.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label251.Location = new System.Drawing.Point(211, 16);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(2606, 25);
            this.label251.TabIndex = 301;
            this.label251.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label252
            // 
            this.label252.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label252.BackColor = System.Drawing.Color.SandyBrown;
            this.label252.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label252.Location = new System.Drawing.Point(7, 16);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(1944, 25);
            this.label252.TabIndex = 302;
            this.label252.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_with_cp
            // 
            this.grp_with_cp.Controls.Add(this.grp_with_cp1);
            this.grp_with_cp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_with_cp.Location = new System.Drawing.Point(0, 1837);
            this.grp_with_cp.Name = "grp_with_cp";
            this.grp_with_cp.Size = new System.Drawing.Size(1236, 341);
            this.grp_with_cp.TabIndex = 328;
            // 
            // grp_with_cp1
            // 
            this.grp_with_cp1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_with_cp1.Controls.Add(this.lblLoanP9);
            this.grp_with_cp1.Controls.Add(this.lblLoanP8);
            this.grp_with_cp1.Controls.Add(this.lblLoanP7);
            this.grp_with_cp1.Controls.Add(this.cbContactPersonCP);
            this.grp_with_cp1.Controls.Add(this.cbCPPRHoldDate2);
            this.grp_with_cp1.Controls.Add(this.cbCPHoldDate2);
            this.grp_with_cp1.Controls.Add(this.cbCPPRHoldDate1);
            this.grp_with_cp1.Controls.Add(this.cbCPHoldDate1);
            this.grp_with_cp1.Controls.Add(this.label189);
            this.grp_with_cp1.Controls.Add(this.label190);
            this.grp_with_cp1.Controls.Add(this.label191);
            this.grp_with_cp1.Controls.Add(this.label192);
            this.grp_with_cp1.Controls.Add(this.cbCPaction2);
            this.grp_with_cp1.Controls.Add(this.cbCPaction1);
            this.grp_with_cp1.Controls.Add(this.button1);
            this.grp_with_cp1.Controls.Add(this.label194);
            this.grp_with_cp1.Controls.Add(this.label195);
            this.grp_with_cp1.Controls.Add(this.txtCPAmount3);
            this.grp_with_cp1.Controls.Add(this.label196);
            this.grp_with_cp1.Controls.Add(this.label197);
            this.grp_with_cp1.Controls.Add(this.label198);
            this.grp_with_cp1.Controls.Add(this.label199);
            this.grp_with_cp1.Controls.Add(this.label200);
            this.grp_with_cp1.Controls.Add(this.label201);
            this.grp_with_cp1.Controls.Add(this.txtCPAmount2);
            this.grp_with_cp1.Controls.Add(this.label202);
            this.grp_with_cp1.Controls.Add(this.label203);
            this.grp_with_cp1.Controls.Add(this.label204);
            this.grp_with_cp1.Controls.Add(this.label292);
            this.grp_with_cp1.Controls.Add(this.label293);
            this.grp_with_cp1.Controls.Add(this.cbContactCPPlace);
            this.grp_with_cp1.Controls.Add(this.txtRemarkCP);
            this.grp_with_cp1.Controls.Add(this.label294);
            this.grp_with_cp1.Controls.Add(this.label295);
            this.grp_with_cp1.Controls.Add(this.label296);
            this.grp_with_cp1.Controls.Add(this.label297);
            this.grp_with_cp1.Controls.Add(this.label298);
            this.grp_with_cp1.Controls.Add(this.button10);
            this.grp_with_cp1.Controls.Add(this.label299);
            this.grp_with_cp1.Controls.Add(this.btncancel4);
            this.grp_with_cp1.Controls.Add(this.label205);
            this.grp_with_cp1.Controls.Add(this.label206);
            this.grp_with_cp1.Controls.Add(this.label207);
            this.grp_with_cp1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_with_cp1.Location = new System.Drawing.Point(3, 5);
            this.grp_with_cp1.Name = "grp_with_cp1";
            this.grp_with_cp1.Size = new System.Drawing.Size(2189, 338);
            this.grp_with_cp1.TabIndex = 304;
            this.grp_with_cp1.TabStop = false;
            // 
            // lblLoanP9
            // 
            this.lblLoanP9.BackColor = System.Drawing.Color.White;
            this.lblLoanP9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP9.Location = new System.Drawing.Point(897, 48);
            this.lblLoanP9.Name = "lblLoanP9";
            this.lblLoanP9.ReadOnly = true;
            this.lblLoanP9.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP9.TabIndex = 496;
            this.lblLoanP9.Text = "Loan";
            // 
            // lblLoanP8
            // 
            this.lblLoanP8.BackColor = System.Drawing.Color.White;
            this.lblLoanP8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP8.Location = new System.Drawing.Point(559, 48);
            this.lblLoanP8.Name = "lblLoanP8";
            this.lblLoanP8.ReadOnly = true;
            this.lblLoanP8.Size = new System.Drawing.Size(173, 15);
            this.lblLoanP8.TabIndex = 495;
            this.lblLoanP8.Text = "Loan";
            // 
            // lblLoanP7
            // 
            this.lblLoanP7.BackColor = System.Drawing.Color.White;
            this.lblLoanP7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP7.Location = new System.Drawing.Point(186, 48);
            this.lblLoanP7.Name = "lblLoanP7";
            this.lblLoanP7.ReadOnly = true;
            this.lblLoanP7.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP7.TabIndex = 494;
            this.lblLoanP7.Text = "Loan";
            // 
            // cbContactPersonCP
            // 
            this.cbContactPersonCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPersonCP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPersonCP.FormattingEnabled = true;
            this.cbContactPersonCP.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPersonCP.Location = new System.Drawing.Point(183, 169);
            this.cbContactPersonCP.Name = "cbContactPersonCP";
            this.cbContactPersonCP.Size = new System.Drawing.Size(153, 23);
            this.cbContactPersonCP.TabIndex = 4005;
            // 
            // cbCPPRHoldDate2
            // 
            this.cbCPPRHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPPRHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPPRHoldDate2.FormattingEnabled = true;
            this.cbCPPRHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbCPPRHoldDate2.Location = new System.Drawing.Point(898, 200);
            this.cbCPPRHoldDate2.Name = "cbCPPRHoldDate2";
            this.cbCPPRHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbCPPRHoldDate2.TabIndex = 4009;
            // 
            // cbCPHoldDate2
            // 
            this.cbCPHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPHoldDate2.FormattingEnabled = true;
            this.cbCPHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbCPHoldDate2.Location = new System.Drawing.Point(898, 169);
            this.cbCPHoldDate2.Name = "cbCPHoldDate2";
            this.cbCPHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbCPHoldDate2.TabIndex = 4007;
            // 
            // cbCPPRHoldDate1
            // 
            this.cbCPPRHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPPRHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPPRHoldDate1.FormattingEnabled = true;
            this.cbCPPRHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbCPPRHoldDate1.Location = new System.Drawing.Point(560, 200);
            this.cbCPPRHoldDate1.Name = "cbCPPRHoldDate1";
            this.cbCPPRHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbCPPRHoldDate1.TabIndex = 4008;
            // 
            // cbCPHoldDate1
            // 
            this.cbCPHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPHoldDate1.FormattingEnabled = true;
            this.cbCPHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbCPHoldDate1.Location = new System.Drawing.Point(560, 169);
            this.cbCPHoldDate1.Name = "cbCPHoldDate1";
            this.cbCPHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbCPHoldDate1.TabIndex = 4006;
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label189.Location = new System.Drawing.Point(894, 109);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(45, 15);
            this.label189.TabIndex = 431;
            this.label189.Text = "DIALER";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label190.Location = new System.Drawing.Point(559, 109);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(45, 15);
            this.label190.TabIndex = 430;
            this.label190.Text = "DIALER";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label191.Location = new System.Drawing.Point(183, 109);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(45, 15);
            this.label191.TabIndex = 429;
            this.label191.Text = "DIALER";
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label192.Location = new System.Drawing.Point(183, 77);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(22, 15);
            this.label192.TabIndex = 428;
            this.label192.Text = "PC";
            // 
            // cbCPaction2
            // 
            this.cbCPaction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPaction2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPaction2.FormattingEnabled = true;
            this.cbCPaction2.Location = new System.Drawing.Point(894, 77);
            this.cbCPaction2.Name = "cbCPaction2";
            this.cbCPaction2.Size = new System.Drawing.Size(153, 23);
            this.cbCPaction2.TabIndex = 4001;
            // 
            // cbCPaction1
            // 
            this.cbCPaction1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCPaction1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCPaction1.FormattingEnabled = true;
            this.cbCPaction1.Location = new System.Drawing.Point(559, 77);
            this.cbCPaction1.Name = "cbCPaction1";
            this.cbCPaction1.Size = new System.Drawing.Size(153, 23);
            this.cbCPaction1.TabIndex = 4000;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4011;
            this.button1.Text = "Callback";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label194.Location = new System.Drawing.Point(22, 266);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(123, 15);
            this.label194.TabIndex = 423;
            this.label194.Text = "Schedule For Callback";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label195.Location = new System.Drawing.Point(733, 200);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(77, 15);
            this.label195.TabIndex = 422;
            this.label195.Text = "PR Hold Date";
            // 
            // txtCPAmount3
            // 
            this.txtCPAmount3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPAmount3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPAmount3.Location = new System.Drawing.Point(897, 137);
            this.txtCPAmount3.MaxLength = 20;
            this.txtCPAmount3.Name = "txtCPAmount3";
            this.txtCPAmount3.Size = new System.Drawing.Size(153, 23);
            this.txtCPAmount3.TabIndex = 4004;
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label196.Location = new System.Drawing.Point(733, 169);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(84, 15);
            this.label196.TabIndex = 420;
            this.label196.Text = "PTP Hold Date";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label197.Location = new System.Drawing.Point(733, 137);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(75, 15);
            this.label197.TabIndex = 419;
            this.label197.Text = "PTP Amount";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label198.Location = new System.Drawing.Point(733, 109);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(83, 15);
            this.label198.TabIndex = 418;
            this.label198.Text = "Contact Mode";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label199.Location = new System.Drawing.Point(733, 71);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(97, 30);
            this.label199.TabIndex = 417;
            this.label199.Text = "Action Code / \r\nDisposition Code";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label200.Location = new System.Drawing.Point(733, 48);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(80, 15);
            this.label200.TabIndex = 416;
            this.label200.Text = "Loan Number";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label201.Location = new System.Drawing.Point(395, 200);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(77, 15);
            this.label201.TabIndex = 415;
            this.label201.Text = "PR Hold Date";
            // 
            // txtCPAmount2
            // 
            this.txtCPAmount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPAmount2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPAmount2.Location = new System.Drawing.Point(559, 137);
            this.txtCPAmount2.MaxLength = 20;
            this.txtCPAmount2.Name = "txtCPAmount2";
            this.txtCPAmount2.Size = new System.Drawing.Size(153, 23);
            this.txtCPAmount2.TabIndex = 4003;
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label202.Location = new System.Drawing.Point(395, 169);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(84, 15);
            this.label202.TabIndex = 413;
            this.label202.Text = "PTP Hold Date";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label203.Location = new System.Drawing.Point(395, 137);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(75, 15);
            this.label203.TabIndex = 412;
            this.label203.Text = "PTP Amount";
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label204.Location = new System.Drawing.Point(395, 109);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(83, 15);
            this.label204.TabIndex = 411;
            this.label204.Text = "Contact Mode";
            // 
            // label292
            // 
            this.label292.AutoSize = true;
            this.label292.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label292.Location = new System.Drawing.Point(395, 71);
            this.label292.Name = "label292";
            this.label292.Size = new System.Drawing.Size(97, 30);
            this.label292.TabIndex = 410;
            this.label292.Text = "Action Code / \r\nDisposition Code";
            // 
            // label293
            // 
            this.label293.AutoSize = true;
            this.label293.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label293.Location = new System.Drawing.Point(395, 48);
            this.label293.Name = "label293";
            this.label293.Size = new System.Drawing.Size(80, 15);
            this.label293.TabIndex = 409;
            this.label293.Text = "Loan Number";
            // 
            // cbContactCPPlace
            // 
            this.cbContactCPPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactCPPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactCPPlace.FormattingEnabled = true;
            this.cbContactCPPlace.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactCPPlace.Location = new System.Drawing.Point(183, 137);
            this.cbContactCPPlace.Name = "cbContactCPPlace";
            this.cbContactCPPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactCPPlace.TabIndex = 4002;
            // 
            // txtRemarkCP
            // 
            this.txtRemarkCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkCP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkCP.Location = new System.Drawing.Point(186, 232);
            this.txtRemarkCP.MaxLength = 100;
            this.txtRemarkCP.Name = "txtRemarkCP";
            this.txtRemarkCP.Size = new System.Drawing.Size(735, 23);
            this.txtRemarkCP.TabIndex = 4010;
            this.txtRemarkCP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarkCP_KeyPress);
            // 
            // label294
            // 
            this.label294.AutoSize = true;
            this.label294.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label294.Location = new System.Drawing.Point(22, 232);
            this.label294.Name = "label294";
            this.label294.Size = new System.Drawing.Size(52, 15);
            this.label294.TabIndex = 406;
            this.label294.Text = "Remarks";
            // 
            // label295
            // 
            this.label295.AutoSize = true;
            this.label295.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label295.Location = new System.Drawing.Point(22, 169);
            this.label295.Name = "label295";
            this.label295.Size = new System.Drawing.Size(88, 15);
            this.label295.TabIndex = 405;
            this.label295.Text = "Contact Person";
            // 
            // label296
            // 
            this.label296.AutoSize = true;
            this.label296.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label296.Location = new System.Drawing.Point(22, 137);
            this.label296.Name = "label296";
            this.label296.Size = new System.Drawing.Size(80, 15);
            this.label296.TabIndex = 404;
            this.label296.Text = "Contact Place";
            // 
            // label297
            // 
            this.label297.AutoSize = true;
            this.label297.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label297.Location = new System.Drawing.Point(22, 109);
            this.label297.Name = "label297";
            this.label297.Size = new System.Drawing.Size(83, 15);
            this.label297.TabIndex = 403;
            this.label297.Text = "Contact Mode";
            // 
            // label298
            // 
            this.label298.AutoSize = true;
            this.label298.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label298.Location = new System.Drawing.Point(22, 71);
            this.label298.Name = "label298";
            this.label298.Size = new System.Drawing.Size(97, 30);
            this.label298.TabIndex = 402;
            this.label298.Text = "Action Code / \r\nDisposition Code";
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(186, 299);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 27);
            this.button10.TabIndex = 4012;
            this.button10.Text = "Next Call";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // label299
            // 
            this.label299.AutoSize = true;
            this.label299.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label299.Location = new System.Drawing.Point(22, 48);
            this.label299.Name = "label299";
            this.label299.Size = new System.Drawing.Size(80, 15);
            this.label299.TabIndex = 400;
            this.label299.Text = "Loan Number";
            // 
            // btncancel4
            // 
            this.btncancel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel4.Location = new System.Drawing.Point(264, 299);
            this.btncancel4.Name = "btncancel4";
            this.btncancel4.Size = new System.Drawing.Size(75, 27);
            this.btncancel4.TabIndex = 4013;
            this.btncancel4.Text = "Cancel";
            this.btncancel4.UseVisualStyleBackColor = true;
            this.btncancel4.Click += new System.EventHandler(this.btncancel4_Click);
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.BackColor = System.Drawing.Color.SandyBrown;
            this.label205.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label205.Location = new System.Drawing.Point(12, 21);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(39, 15);
            this.label205.TabIndex = 303;
            this.label205.Text = "Result";
            // 
            // label206
            // 
            this.label206.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label206.BackColor = System.Drawing.Color.Yellow;
            this.label206.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label206.Location = new System.Drawing.Point(211, 16);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(2433, 25);
            this.label206.TabIndex = 301;
            this.label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label207
            // 
            this.label207.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label207.BackColor = System.Drawing.Color.SandyBrown;
            this.label207.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label207.Location = new System.Drawing.Point(7, 16);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(1771, 25);
            this.label207.TabIndex = 302;
            this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_with_borrower
            // 
            this.grp_with_borrower.Controls.Add(this.grp_with_borrower1);
            this.grp_with_borrower.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_with_borrower.Location = new System.Drawing.Point(0, 1490);
            this.grp_with_borrower.Name = "grp_with_borrower";
            this.grp_with_borrower.Size = new System.Drawing.Size(1236, 347);
            this.grp_with_borrower.TabIndex = 327;
            // 
            // grp_with_borrower1
            // 
            this.grp_with_borrower1.Controls.Add(this.lblLoanP6);
            this.grp_with_borrower1.Controls.Add(this.lblLoanP5);
            this.grp_with_borrower1.Controls.Add(this.lblLoanP4);
            this.grp_with_borrower1.Controls.Add(this.label291);
            this.grp_with_borrower1.Controls.Add(this.cbBPRHoldDate2);
            this.grp_with_borrower1.Controls.Add(this.cbBHoldDate2);
            this.grp_with_borrower1.Controls.Add(this.cbBPRHoldDate1);
            this.grp_with_borrower1.Controls.Add(this.cbBHoldDate1);
            this.grp_with_borrower1.Controls.Add(this.label286);
            this.grp_with_borrower1.Controls.Add(this.label287);
            this.grp_with_borrower1.Controls.Add(this.label288);
            this.grp_with_borrower1.Controls.Add(this.label289);
            this.grp_with_borrower1.Controls.Add(this.cbBaction2);
            this.grp_with_borrower1.Controls.Add(this.cbBaction1);
            this.grp_with_borrower1.Controls.Add(this.btnCallBack);
            this.grp_with_borrower1.Controls.Add(this.label140);
            this.grp_with_borrower1.Controls.Add(this.label141);
            this.grp_with_borrower1.Controls.Add(this.txtBAmount3);
            this.grp_with_borrower1.Controls.Add(this.label142);
            this.grp_with_borrower1.Controls.Add(this.label143);
            this.grp_with_borrower1.Controls.Add(this.label145);
            this.grp_with_borrower1.Controls.Add(this.label147);
            this.grp_with_borrower1.Controls.Add(this.label148);
            this.grp_with_borrower1.Controls.Add(this.label149);
            this.grp_with_borrower1.Controls.Add(this.txtBAmount2);
            this.grp_with_borrower1.Controls.Add(this.label150);
            this.grp_with_borrower1.Controls.Add(this.label164);
            this.grp_with_borrower1.Controls.Add(this.label165);
            this.grp_with_borrower1.Controls.Add(this.label166);
            this.grp_with_borrower1.Controls.Add(this.label168);
            this.grp_with_borrower1.Controls.Add(this.cbContactBPlace);
            this.grp_with_borrower1.Controls.Add(this.txtRemarkB);
            this.grp_with_borrower1.Controls.Add(this.label169);
            this.grp_with_borrower1.Controls.Add(this.label170);
            this.grp_with_borrower1.Controls.Add(this.label179);
            this.grp_with_borrower1.Controls.Add(this.label180);
            this.grp_with_borrower1.Controls.Add(this.label181);
            this.grp_with_borrower1.Controls.Add(this.btnNextCallB);
            this.grp_with_borrower1.Controls.Add(this.label182);
            this.grp_with_borrower1.Controls.Add(this.btncancel3);
            this.grp_with_borrower1.Controls.Add(this.label183);
            this.grp_with_borrower1.Controls.Add(this.label184);
            this.grp_with_borrower1.Controls.Add(this.label185);
            this.grp_with_borrower1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_with_borrower1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_with_borrower1.Location = new System.Drawing.Point(0, 0);
            this.grp_with_borrower1.Name = "grp_with_borrower1";
            this.grp_with_borrower1.Size = new System.Drawing.Size(1236, 347);
            this.grp_with_borrower1.TabIndex = 302;
            this.grp_with_borrower1.TabStop = false;
            // 
            // lblLoanP6
            // 
            this.lblLoanP6.BackColor = System.Drawing.Color.White;
            this.lblLoanP6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP6.Location = new System.Drawing.Point(892, 52);
            this.lblLoanP6.Name = "lblLoanP6";
            this.lblLoanP6.ReadOnly = true;
            this.lblLoanP6.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP6.TabIndex = 493;
            this.lblLoanP6.Text = "Loan";
            // 
            // lblLoanP5
            // 
            this.lblLoanP5.BackColor = System.Drawing.Color.White;
            this.lblLoanP5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP5.Location = new System.Drawing.Point(554, 52);
            this.lblLoanP5.Name = "lblLoanP5";
            this.lblLoanP5.ReadOnly = true;
            this.lblLoanP5.Size = new System.Drawing.Size(173, 15);
            this.lblLoanP5.TabIndex = 492;
            this.lblLoanP5.Text = "Loan";
            // 
            // lblLoanP4
            // 
            this.lblLoanP4.BackColor = System.Drawing.Color.White;
            this.lblLoanP4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP4.Location = new System.Drawing.Point(181, 52);
            this.lblLoanP4.Name = "lblLoanP4";
            this.lblLoanP4.ReadOnly = true;
            this.lblLoanP4.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP4.TabIndex = 491;
            this.lblLoanP4.Text = "Loan";
            // 
            // label291
            // 
            this.label291.AutoSize = true;
            this.label291.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label291.Location = new System.Drawing.Point(178, 173);
            this.label291.Name = "label291";
            this.label291.Size = new System.Drawing.Size(70, 15);
            this.label291.TabIndex = 398;
            this.label291.Text = "BORROWER";
            // 
            // cbBPRHoldDate2
            // 
            this.cbBPRHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBPRHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBPRHoldDate2.FormattingEnabled = true;
            this.cbBPRHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbBPRHoldDate2.Location = new System.Drawing.Point(893, 204);
            this.cbBPRHoldDate2.Name = "cbBPRHoldDate2";
            this.cbBPRHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbBPRHoldDate2.TabIndex = 3008;
            // 
            // cbBHoldDate2
            // 
            this.cbBHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBHoldDate2.FormattingEnabled = true;
            this.cbBHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbBHoldDate2.Location = new System.Drawing.Point(893, 173);
            this.cbBHoldDate2.Name = "cbBHoldDate2";
            this.cbBHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbBHoldDate2.TabIndex = 3006;
            // 
            // cbBPRHoldDate1
            // 
            this.cbBPRHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBPRHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBPRHoldDate1.FormattingEnabled = true;
            this.cbBPRHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbBPRHoldDate1.Location = new System.Drawing.Point(555, 204);
            this.cbBPRHoldDate1.Name = "cbBPRHoldDate1";
            this.cbBPRHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbBPRHoldDate1.TabIndex = 3007;
            // 
            // cbBHoldDate1
            // 
            this.cbBHoldDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBHoldDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBHoldDate1.FormattingEnabled = true;
            this.cbBHoldDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbBHoldDate1.Location = new System.Drawing.Point(555, 173);
            this.cbBHoldDate1.Name = "cbBHoldDate1";
            this.cbBHoldDate1.Size = new System.Drawing.Size(153, 23);
            this.cbBHoldDate1.TabIndex = 3005;
            // 
            // label286
            // 
            this.label286.AutoSize = true;
            this.label286.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label286.Location = new System.Drawing.Point(889, 113);
            this.label286.Name = "label286";
            this.label286.Size = new System.Drawing.Size(45, 15);
            this.label286.TabIndex = 391;
            this.label286.Text = "DIALER";
            // 
            // label287
            // 
            this.label287.AutoSize = true;
            this.label287.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label287.Location = new System.Drawing.Point(554, 113);
            this.label287.Name = "label287";
            this.label287.Size = new System.Drawing.Size(45, 15);
            this.label287.TabIndex = 390;
            this.label287.Text = "DIALER";
            // 
            // label288
            // 
            this.label288.AutoSize = true;
            this.label288.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label288.Location = new System.Drawing.Point(178, 113);
            this.label288.Name = "label288";
            this.label288.Size = new System.Drawing.Size(45, 15);
            this.label288.TabIndex = 389;
            this.label288.Text = "DIALER";
            // 
            // label289
            // 
            this.label289.AutoSize = true;
            this.label289.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label289.Location = new System.Drawing.Point(178, 81);
            this.label289.Name = "label289";
            this.label289.Size = new System.Drawing.Size(22, 15);
            this.label289.TabIndex = 388;
            this.label289.Text = "PC";
            // 
            // cbBaction2
            // 
            this.cbBaction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaction2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaction2.FormattingEnabled = true;
            this.cbBaction2.Location = new System.Drawing.Point(889, 81);
            this.cbBaction2.Name = "cbBaction2";
            this.cbBaction2.Size = new System.Drawing.Size(153, 23);
            this.cbBaction2.TabIndex = 3001;
            // 
            // cbBaction1
            // 
            this.cbBaction1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaction1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaction1.FormattingEnabled = true;
            this.cbBaction1.Location = new System.Drawing.Point(554, 81);
            this.cbBaction1.Name = "cbBaction1";
            this.cbBaction1.Size = new System.Drawing.Size(153, 23);
            this.cbBaction1.TabIndex = 3000;
            // 
            // btnCallBack
            // 
            this.btnCallBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallBack.Location = new System.Drawing.Point(181, 270);
            this.btnCallBack.Name = "btnCallBack";
            this.btnCallBack.Size = new System.Drawing.Size(75, 27);
            this.btnCallBack.TabIndex = 3010;
            this.btnCallBack.Text = "Callback";
            this.btnCallBack.UseVisualStyleBackColor = true;
            this.btnCallBack.Click += new System.EventHandler(this.btnCallBack_Click);
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.Location = new System.Drawing.Point(17, 270);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(123, 15);
            this.label140.TabIndex = 383;
            this.label140.Text = "Schedule For Callback";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.Location = new System.Drawing.Point(728, 204);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(77, 15);
            this.label141.TabIndex = 380;
            this.label141.Text = "PR Hold Date";
            // 
            // txtBAmount3
            // 
            this.txtBAmount3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBAmount3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAmount3.Location = new System.Drawing.Point(892, 141);
            this.txtBAmount3.MaxLength = 20;
            this.txtBAmount3.Name = "txtBAmount3";
            this.txtBAmount3.Size = new System.Drawing.Size(153, 23);
            this.txtBAmount3.TabIndex = 3004;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.Location = new System.Drawing.Point(728, 173);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(84, 15);
            this.label142.TabIndex = 375;
            this.label142.Text = "PTP Hold Date";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.Location = new System.Drawing.Point(728, 141);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(75, 15);
            this.label143.TabIndex = 374;
            this.label143.Text = "PTP Amount";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.Location = new System.Drawing.Point(728, 113);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(83, 15);
            this.label145.TabIndex = 373;
            this.label145.Text = "Contact Mode";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.Location = new System.Drawing.Point(728, 75);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(97, 30);
            this.label147.TabIndex = 372;
            this.label147.Text = "Action Code / \r\nDisposition Code";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.Location = new System.Drawing.Point(728, 52);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(80, 15);
            this.label148.TabIndex = 371;
            this.label148.Text = "Loan Number";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.Location = new System.Drawing.Point(390, 204);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(77, 15);
            this.label149.TabIndex = 368;
            this.label149.Text = "PR Hold Date";
            // 
            // txtBAmount2
            // 
            this.txtBAmount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBAmount2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBAmount2.Location = new System.Drawing.Point(554, 141);
            this.txtBAmount2.MaxLength = 20;
            this.txtBAmount2.Name = "txtBAmount2";
            this.txtBAmount2.Size = new System.Drawing.Size(153, 23);
            this.txtBAmount2.TabIndex = 3003;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.Location = new System.Drawing.Point(390, 173);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(84, 15);
            this.label150.TabIndex = 363;
            this.label150.Text = "PTP Hold Date";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label164.Location = new System.Drawing.Point(390, 141);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(75, 15);
            this.label164.TabIndex = 362;
            this.label164.Text = "PTP Amount";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label165.Location = new System.Drawing.Point(390, 113);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(83, 15);
            this.label165.TabIndex = 361;
            this.label165.Text = "Contact Mode";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label166.Location = new System.Drawing.Point(390, 75);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(97, 30);
            this.label166.TabIndex = 360;
            this.label166.Text = "Action Code / \r\nDisposition Code";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label168.Location = new System.Drawing.Point(390, 52);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(80, 15);
            this.label168.TabIndex = 359;
            this.label168.Text = "Loan Number";
            // 
            // cbContactBPlace
            // 
            this.cbContactBPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactBPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactBPlace.FormattingEnabled = true;
            this.cbContactBPlace.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactBPlace.Location = new System.Drawing.Point(178, 141);
            this.cbContactBPlace.Name = "cbContactBPlace";
            this.cbContactBPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactBPlace.TabIndex = 3002;
            // 
            // txtRemarkB
            // 
            this.txtRemarkB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkB.Location = new System.Drawing.Point(181, 236);
            this.txtRemarkB.MaxLength = 100;
            this.txtRemarkB.Name = "txtRemarkB";
            this.txtRemarkB.Size = new System.Drawing.Size(735, 23);
            this.txtRemarkB.TabIndex = 3009;
            this.txtRemarkB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemarkB_KeyPress);
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label169.Location = new System.Drawing.Point(17, 236);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(52, 15);
            this.label169.TabIndex = 352;
            this.label169.Text = "Remarks";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label170.Location = new System.Drawing.Point(17, 173);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(88, 15);
            this.label170.TabIndex = 351;
            this.label170.Text = "Contact Person";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label179.Location = new System.Drawing.Point(17, 141);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(80, 15);
            this.label179.TabIndex = 350;
            this.label179.Text = "Contact Place";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label180.Location = new System.Drawing.Point(17, 113);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(83, 15);
            this.label180.TabIndex = 349;
            this.label180.Text = "Contact Mode";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label181.Location = new System.Drawing.Point(17, 75);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(97, 30);
            this.label181.TabIndex = 348;
            this.label181.Text = "Action Code / \r\nDisposition Code";
            // 
            // btnNextCallB
            // 
            this.btnNextCallB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCallB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextCallB.Location = new System.Drawing.Point(181, 303);
            this.btnNextCallB.Name = "btnNextCallB";
            this.btnNextCallB.Size = new System.Drawing.Size(75, 27);
            this.btnNextCallB.TabIndex = 3011;
            this.btnNextCallB.Text = "Next Call";
            this.btnNextCallB.UseVisualStyleBackColor = true;
            this.btnNextCallB.Click += new System.EventHandler(this.btnNextCallB_Click);
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label182.Location = new System.Drawing.Point(17, 52);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(80, 15);
            this.label182.TabIndex = 346;
            this.label182.Text = "Loan Number";
            // 
            // btncancel3
            // 
            this.btncancel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel3.Location = new System.Drawing.Point(259, 303);
            this.btncancel3.Name = "btncancel3";
            this.btncancel3.Size = new System.Drawing.Size(75, 27);
            this.btncancel3.TabIndex = 3012;
            this.btncancel3.Text = "Cancel";
            this.btncancel3.UseVisualStyleBackColor = true;
            this.btncancel3.Click += new System.EventHandler(this.button27_Click);
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.BackColor = System.Drawing.Color.SandyBrown;
            this.label183.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label183.Location = new System.Drawing.Point(12, 21);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(39, 15);
            this.label183.TabIndex = 303;
            this.label183.Text = "Result";
            // 
            // label184
            // 
            this.label184.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label184.BackColor = System.Drawing.Color.Yellow;
            this.label184.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label184.Location = new System.Drawing.Point(211, 16);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(1007, 25);
            this.label184.TabIndex = 301;
            this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label185
            // 
            this.label185.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label185.BackColor = System.Drawing.Color.SandyBrown;
            this.label185.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label185.Location = new System.Drawing.Point(7, 16);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(345, 25);
            this.label185.TabIndex = 302;
            this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_ptp
            // 
            this.grp_ptp.Controls.Add(this.grp_ptp1);
            this.grp_ptp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_ptp.Location = new System.Drawing.Point(0, 1154);
            this.grp_ptp.Name = "grp_ptp";
            this.grp_ptp.Size = new System.Drawing.Size(1236, 336);
            this.grp_ptp.TabIndex = 326;
            // 
            // grp_ptp1
            // 
            this.grp_ptp1.Controls.Add(this.lblLoan10);
            this.grp_ptp1.Controls.Add(this.lblLoan9);
            this.grp_ptp1.Controls.Add(this.lblLoan8);
            this.grp_ptp1.Controls.Add(this.label285);
            this.grp_ptp1.Controls.Add(this.label284);
            this.grp_ptp1.Controls.Add(this.label283);
            this.grp_ptp1.Controls.Add(this.label282);
            this.grp_ptp1.Controls.Add(this.btnCancel2);
            this.grp_ptp1.Controls.Add(this.cbActionCode2);
            this.grp_ptp1.Controls.Add(this.cbPTPPRDate2);
            this.grp_ptp1.Controls.Add(this.label54);
            this.grp_ptp1.Controls.Add(this.cbPTPHoldDate3);
            this.grp_ptp1.Controls.Add(this.txtPTPAmount3);
            this.grp_ptp1.Controls.Add(this.label55);
            this.grp_ptp1.Controls.Add(this.label40);
            this.grp_ptp1.Controls.Add(this.label44);
            this.grp_ptp1.Controls.Add(this.label45);
            this.grp_ptp1.Controls.Add(this.label50);
            this.grp_ptp1.Controls.Add(this.cbActionCode1);
            this.grp_ptp1.Controls.Add(this.cbPTPPRDate1);
            this.grp_ptp1.Controls.Add(this.label60);
            this.grp_ptp1.Controls.Add(this.cbPTPHoldDate2);
            this.grp_ptp1.Controls.Add(this.txtPTPAmount2);
            this.grp_ptp1.Controls.Add(this.label61);
            this.grp_ptp1.Controls.Add(this.label62);
            this.grp_ptp1.Controls.Add(this.label63);
            this.grp_ptp1.Controls.Add(this.label64);
            this.grp_ptp1.Controls.Add(this.label51);
            this.grp_ptp1.Controls.Add(this.cbPTPHoldDate);
            this.grp_ptp1.Controls.Add(this.cbContactPerson);
            this.grp_ptp1.Controls.Add(this.cbContactPlace);
            this.grp_ptp1.Controls.Add(this.txtRemark);
            this.grp_ptp1.Controls.Add(this.txtPTPAmount1);
            this.grp_ptp1.Controls.Add(this.label52);
            this.grp_ptp1.Controls.Add(this.label53);
            this.grp_ptp1.Controls.Add(this.label75);
            this.grp_ptp1.Controls.Add(this.label76);
            this.grp_ptp1.Controls.Add(this.label79);
            this.grp_ptp1.Controls.Add(this.label80);
            this.grp_ptp1.Controls.Add(this.label81);
            this.grp_ptp1.Controls.Add(this.btnUpdatePTP);
            this.grp_ptp1.Controls.Add(this.label82);
            this.grp_ptp1.Controls.Add(this.label112);
            this.grp_ptp1.Controls.Add(this.label113);
            this.grp_ptp1.Controls.Add(this.label139);
            this.grp_ptp1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ptp1.Location = new System.Drawing.Point(8, 3);
            this.grp_ptp1.Name = "grp_ptp1";
            this.grp_ptp1.Size = new System.Drawing.Size(1194, 336);
            this.grp_ptp1.TabIndex = 312;
            this.grp_ptp1.TabStop = false;
            // 
            // lblLoan10
            // 
            this.lblLoan10.BackColor = System.Drawing.Color.White;
            this.lblLoan10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan10.Location = new System.Drawing.Point(890, 49);
            this.lblLoan10.Name = "lblLoan10";
            this.lblLoan10.ReadOnly = true;
            this.lblLoan10.Size = new System.Drawing.Size(204, 15);
            this.lblLoan10.TabIndex = 490;
            this.lblLoan10.Text = "Loan";
            // 
            // lblLoan9
            // 
            this.lblLoan9.BackColor = System.Drawing.Color.White;
            this.lblLoan9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan9.Location = new System.Drawing.Point(552, 49);
            this.lblLoan9.Name = "lblLoan9";
            this.lblLoan9.ReadOnly = true;
            this.lblLoan9.Size = new System.Drawing.Size(173, 15);
            this.lblLoan9.TabIndex = 489;
            this.lblLoan9.Text = "Loan";
            // 
            // lblLoan8
            // 
            this.lblLoan8.BackColor = System.Drawing.Color.White;
            this.lblLoan8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoan8.Location = new System.Drawing.Point(179, 49);
            this.lblLoan8.Name = "lblLoan8";
            this.lblLoan8.ReadOnly = true;
            this.lblLoan8.Size = new System.Drawing.Size(204, 15);
            this.lblLoan8.TabIndex = 488;
            this.lblLoan8.Text = "Loan";
            // 
            // label285
            // 
            this.label285.AutoSize = true;
            this.label285.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label285.Location = new System.Drawing.Point(890, 115);
            this.label285.Name = "label285";
            this.label285.Size = new System.Drawing.Size(45, 15);
            this.label285.TabIndex = 350;
            this.label285.Text = "DIALER";
            // 
            // label284
            // 
            this.label284.AutoSize = true;
            this.label284.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label284.Location = new System.Drawing.Point(549, 117);
            this.label284.Name = "label284";
            this.label284.Size = new System.Drawing.Size(45, 15);
            this.label284.TabIndex = 349;
            this.label284.Text = "DIALER";
            // 
            // label283
            // 
            this.label283.AutoSize = true;
            this.label283.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label283.Location = new System.Drawing.Point(179, 112);
            this.label283.Name = "label283";
            this.label283.Size = new System.Drawing.Size(45, 15);
            this.label283.TabIndex = 348;
            this.label283.Text = "DIALER";
            // 
            // label282
            // 
            this.label282.AutoSize = true;
            this.label282.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label282.Location = new System.Drawing.Point(179, 81);
            this.label282.Name = "label282";
            this.label282.Size = new System.Drawing.Size(28, 15);
            this.label282.TabIndex = 347;
            this.label282.Text = "PTP";
            // 
            // btnCancel2
            // 
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(99, 280);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 27);
            this.btnCancel2.TabIndex = 2014;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // cbActionCode2
            // 
            this.cbActionCode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActionCode2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionCode2.FormattingEnabled = true;
            this.cbActionCode2.Location = new System.Drawing.Point(890, 77);
            this.cbActionCode2.Name = "cbActionCode2";
            this.cbActionCode2.Size = new System.Drawing.Size(153, 23);
            this.cbActionCode2.TabIndex = 2001;
            // 
            // cbPTPPRDate2
            // 
            this.cbPTPPRDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTPPRDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTPPRDate2.FormattingEnabled = true;
            this.cbPTPPRDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbPTPPRDate2.Location = new System.Drawing.Point(890, 198);
            this.cbPTPPRDate2.Name = "cbPTPPRDate2";
            this.cbPTPPRDate2.Size = new System.Drawing.Size(153, 23);
            this.cbPTPPRDate2.TabIndex = 2011;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(726, 198);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(77, 15);
            this.label54.TabIndex = 342;
            this.label54.Text = "PR Hold Date";
            // 
            // cbPTPHoldDate3
            // 
            this.cbPTPHoldDate3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTPHoldDate3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTPHoldDate3.FormattingEnabled = true;
            this.cbPTPHoldDate3.Items.AddRange(new object[] {
            "PTP"});
            this.cbPTPHoldDate3.Location = new System.Drawing.Point(890, 168);
            this.cbPTPHoldDate3.Name = "cbPTPHoldDate3";
            this.cbPTPHoldDate3.Size = new System.Drawing.Size(153, 23);
            this.cbPTPHoldDate3.TabIndex = 2008;
            // 
            // txtPTPAmount3
            // 
            this.txtPTPAmount3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPAmount3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTPAmount3.Location = new System.Drawing.Point(890, 140);
            this.txtPTPAmount3.MaxLength = 20;
            this.txtPTPAmount3.Name = "txtPTPAmount3";
            this.txtPTPAmount3.Size = new System.Drawing.Size(153, 23);
            this.txtPTPAmount3.TabIndex = 2005;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(726, 168);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(84, 15);
            this.label55.TabIndex = 337;
            this.label55.Text = "PTP Hold Date";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(726, 140);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(75, 15);
            this.label40.TabIndex = 336;
            this.label40.Text = "PTP Amount";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(726, 115);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(83, 15);
            this.label44.TabIndex = 335;
            this.label44.Text = "Contact Mode";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(726, 72);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(97, 30);
            this.label45.TabIndex = 334;
            this.label45.Text = "Action Code / \r\nDisposition Code";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(726, 49);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(80, 15);
            this.label50.TabIndex = 333;
            this.label50.Text = "Loan Number";
            // 
            // cbActionCode1
            // 
            this.cbActionCode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActionCode1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActionCode1.FormattingEnabled = true;
            this.cbActionCode1.Location = new System.Drawing.Point(552, 77);
            this.cbActionCode1.Name = "cbActionCode1";
            this.cbActionCode1.Size = new System.Drawing.Size(153, 23);
            this.cbActionCode1.TabIndex = 2000;
            // 
            // cbPTPPRDate1
            // 
            this.cbPTPPRDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTPPRDate1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTPPRDate1.FormattingEnabled = true;
            this.cbPTPPRDate1.Items.AddRange(new object[] {
            "PTP"});
            this.cbPTPPRDate1.Location = new System.Drawing.Point(552, 198);
            this.cbPTPPRDate1.Name = "cbPTPPRDate1";
            this.cbPTPPRDate1.Size = new System.Drawing.Size(153, 23);
            this.cbPTPPRDate1.TabIndex = 2010;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(388, 198);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(77, 15);
            this.label60.TabIndex = 330;
            this.label60.Text = "PR Hold Date";
            // 
            // cbPTPHoldDate2
            // 
            this.cbPTPHoldDate2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTPHoldDate2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTPHoldDate2.FormattingEnabled = true;
            this.cbPTPHoldDate2.Items.AddRange(new object[] {
            "PTP"});
            this.cbPTPHoldDate2.Location = new System.Drawing.Point(552, 168);
            this.cbPTPHoldDate2.Name = "cbPTPHoldDate2";
            this.cbPTPHoldDate2.Size = new System.Drawing.Size(153, 23);
            this.cbPTPHoldDate2.TabIndex = 2007;
            // 
            // txtPTPAmount2
            // 
            this.txtPTPAmount2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPAmount2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTPAmount2.Location = new System.Drawing.Point(552, 140);
            this.txtPTPAmount2.MaxLength = 20;
            this.txtPTPAmount2.Name = "txtPTPAmount2";
            this.txtPTPAmount2.Size = new System.Drawing.Size(153, 23);
            this.txtPTPAmount2.TabIndex = 2004;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(388, 168);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(84, 15);
            this.label61.TabIndex = 325;
            this.label61.Text = "PTP Hold Date";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(388, 140);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(75, 15);
            this.label62.TabIndex = 324;
            this.label62.Text = "PTP Amount";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(388, 112);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(83, 15);
            this.label63.TabIndex = 323;
            this.label63.Text = "Contact Mode";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(388, 72);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(97, 30);
            this.label64.TabIndex = 322;
            this.label64.Text = "Action Code / \r\nDisposition Code";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(388, 49);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(80, 15);
            this.label51.TabIndex = 321;
            this.label51.Text = "Loan Number";
            // 
            // cbPTPHoldDate
            // 
            this.cbPTPHoldDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPTPHoldDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPTPHoldDate.FormattingEnabled = true;
            this.cbPTPHoldDate.Items.AddRange(new object[] {
            "PTP"});
            this.cbPTPHoldDate.Location = new System.Drawing.Point(179, 224);
            this.cbPTPHoldDate.Name = "cbPTPHoldDate";
            this.cbPTPHoldDate.Size = new System.Drawing.Size(153, 23);
            this.cbPTPHoldDate.TabIndex = 2012;
            // 
            // cbContactPerson
            // 
            this.cbContactPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPerson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPerson.FormattingEnabled = true;
            this.cbContactPerson.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPerson.Location = new System.Drawing.Point(179, 168);
            this.cbContactPerson.Name = "cbContactPerson";
            this.cbContactPerson.Size = new System.Drawing.Size(153, 23);
            this.cbContactPerson.TabIndex = 2006;
            // 
            // cbContactPlace
            // 
            this.cbContactPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPlace.FormattingEnabled = true;
            this.cbContactPlace.Location = new System.Drawing.Point(179, 140);
            this.cbContactPlace.Name = "cbContactPlace";
            this.cbContactPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactPlace.TabIndex = 2003;
            // 
            // txtRemark
            // 
            this.txtRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemark.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(179, 252);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(950, 23);
            this.txtRemark.TabIndex = 2012;
            this.txtRemark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemark_KeyPress);
            // 
            // txtPTPAmount1
            // 
            this.txtPTPAmount1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPTPAmount1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPTPAmount1.Location = new System.Drawing.Point(179, 196);
            this.txtPTPAmount1.MaxLength = 20;
            this.txtPTPAmount1.Name = "txtPTPAmount1";
            this.txtPTPAmount1.Size = new System.Drawing.Size(153, 23);
            this.txtPTPAmount1.TabIndex = 2009;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(15, 252);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(52, 15);
            this.label52.TabIndex = 312;
            this.label52.Text = "Remarks";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(15, 224);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(84, 15);
            this.label53.TabIndex = 311;
            this.label53.Text = "PTP Hold Date";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(15, 196);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(75, 15);
            this.label75.TabIndex = 310;
            this.label75.Text = "PTP Amount";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(15, 168);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(88, 15);
            this.label76.TabIndex = 309;
            this.label76.Text = "Contact Person";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(15, 140);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(80, 15);
            this.label79.TabIndex = 308;
            this.label79.Text = "Contact Place";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(15, 112);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(83, 15);
            this.label80.TabIndex = 307;
            this.label80.Text = "Contact Mode";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(15, 72);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(97, 30);
            this.label81.TabIndex = 306;
            this.label81.Text = "Action Code / \r\nDisposition Code";
            // 
            // btnUpdatePTP
            // 
            this.btnUpdatePTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePTP.Location = new System.Drawing.Point(18, 280);
            this.btnUpdatePTP.Name = "btnUpdatePTP";
            this.btnUpdatePTP.Size = new System.Drawing.Size(75, 27);
            this.btnUpdatePTP.TabIndex = 2013;
            this.btnUpdatePTP.Text = "Next Call";
            this.btnUpdatePTP.UseVisualStyleBackColor = true;
            this.btnUpdatePTP.Click += new System.EventHandler(this.btnUpdatePTP_Click);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.Location = new System.Drawing.Point(15, 49);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(80, 15);
            this.label82.TabIndex = 304;
            this.label82.Text = "Loan Number";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.Color.SandyBrown;
            this.label112.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(12, 21);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(39, 15);
            this.label112.TabIndex = 303;
            this.label112.Text = "Result";
            // 
            // label113
            // 
            this.label113.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label113.BackColor = System.Drawing.Color.Yellow;
            this.label113.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.Location = new System.Drawing.Point(211, 16);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(965, 25);
            this.label113.TabIndex = 301;
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label139
            // 
            this.label139.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label139.BackColor = System.Drawing.Color.SandyBrown;
            this.label139.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.Location = new System.Drawing.Point(7, 16);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(303, 25);
            this.label139.TabIndex = 302;
            this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_phone_leave_message
            // 
            this.grp_phone_leave_message.Controls.Add(this.grp_phone_leave_message1);
            this.grp_phone_leave_message.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_phone_leave_message.Location = new System.Drawing.Point(0, 841);
            this.grp_phone_leave_message.Name = "grp_phone_leave_message";
            this.grp_phone_leave_message.Size = new System.Drawing.Size(1236, 313);
            this.grp_phone_leave_message.TabIndex = 325;
            // 
            // grp_phone_leave_message1
            // 
            this.grp_phone_leave_message1.Controls.Add(this.lblLoanP3);
            this.grp_phone_leave_message1.Controls.Add(this.lblLoanP2);
            this.grp_phone_leave_message1.Controls.Add(this.lblLoanP1);
            this.grp_phone_leave_message1.Controls.Add(this.lblSendback);
            this.grp_phone_leave_message1.Controls.Add(this.btnSendback);
            this.grp_phone_leave_message1.Controls.Add(this.label268);
            this.grp_phone_leave_message1.Controls.Add(this.lblactioncode2);
            this.grp_phone_leave_message1.Controls.Add(this.cbPLaction2);
            this.grp_phone_leave_message1.Controls.Add(this.label253);
            this.grp_phone_leave_message1.Controls.Add(this.label254);
            this.grp_phone_leave_message1.Controls.Add(this.cbPLaction1);
            this.grp_phone_leave_message1.Controls.Add(this.label255);
            this.grp_phone_leave_message1.Controls.Add(this.label256);
            this.grp_phone_leave_message1.Controls.Add(this.cbContactPersonPl);
            this.grp_phone_leave_message1.Controls.Add(this.cbContactPLPlace);
            this.grp_phone_leave_message1.Controls.Add(this.txtRemarkleave);
            this.grp_phone_leave_message1.Controls.Add(this.label257);
            this.grp_phone_leave_message1.Controls.Add(this.label258);
            this.grp_phone_leave_message1.Controls.Add(this.label259);
            this.grp_phone_leave_message1.Controls.Add(this.label260);
            this.grp_phone_leave_message1.Controls.Add(this.label261);
            this.grp_phone_leave_message1.Controls.Add(this.button39);
            this.grp_phone_leave_message1.Controls.Add(this.label262);
            this.grp_phone_leave_message1.Controls.Add(this.btnCancel1);
            this.grp_phone_leave_message1.Controls.Add(this.label263);
            this.grp_phone_leave_message1.Controls.Add(this.label264);
            this.grp_phone_leave_message1.Controls.Add(this.label265);
            this.grp_phone_leave_message1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_phone_leave_message1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_phone_leave_message1.Location = new System.Drawing.Point(0, 0);
            this.grp_phone_leave_message1.Name = "grp_phone_leave_message1";
            this.grp_phone_leave_message1.Size = new System.Drawing.Size(1236, 313);
            this.grp_phone_leave_message1.TabIndex = 308;
            this.grp_phone_leave_message1.TabStop = false;
            // 
            // lblLoanP3
            // 
            this.lblLoanP3.BackColor = System.Drawing.Color.White;
            this.lblLoanP3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP3.Location = new System.Drawing.Point(854, 52);
            this.lblLoanP3.Name = "lblLoanP3";
            this.lblLoanP3.ReadOnly = true;
            this.lblLoanP3.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP3.TabIndex = 487;
            this.lblLoanP3.Text = "Loan";
            // 
            // lblLoanP2
            // 
            this.lblLoanP2.BackColor = System.Drawing.Color.White;
            this.lblLoanP2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP2.Location = new System.Drawing.Point(507, 52);
            this.lblLoanP2.Name = "lblLoanP2";
            this.lblLoanP2.ReadOnly = true;
            this.lblLoanP2.Size = new System.Drawing.Size(173, 15);
            this.lblLoanP2.TabIndex = 486;
            this.lblLoanP2.Text = "Loan";
            // 
            // lblLoanP1
            // 
            this.lblLoanP1.BackColor = System.Drawing.Color.White;
            this.lblLoanP1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoanP1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanP1.Location = new System.Drawing.Point(178, 52);
            this.lblLoanP1.Name = "lblLoanP1";
            this.lblLoanP1.ReadOnly = true;
            this.lblLoanP1.Size = new System.Drawing.Size(204, 15);
            this.lblLoanP1.TabIndex = 485;
            this.lblLoanP1.Text = "Loan";
            // 
            // lblSendback
            // 
            this.lblSendback.AutoSize = true;
            this.lblSendback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendback.Location = new System.Drawing.Point(14, 236);
            this.lblSendback.Name = "lblSendback";
            this.lblSendback.Size = new System.Drawing.Size(131, 15);
            this.lblSendback.TabIndex = 373;
            this.lblSendback.Text = "Schedulled for Callback";
            // 
            // btnSendback
            // 
            this.btnSendback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendback.Location = new System.Drawing.Point(176, 231);
            this.btnSendback.Name = "btnSendback";
            this.btnSendback.Size = new System.Drawing.Size(166, 27);
            this.btnSendback.TabIndex = 1005;
            this.btnSendback.Text = "Setup Callback";
            this.btnSendback.UseVisualStyleBackColor = true;
            this.btnSendback.Click += new System.EventHandler(this.btnSendback_Click);
            // 
            // label268
            // 
            this.label268.AutoSize = true;
            this.label268.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label268.Location = new System.Drawing.Point(178, 110);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(45, 15);
            this.label268.TabIndex = 369;
            this.label268.Text = "DIALER";
            // 
            // lblactioncode2
            // 
            this.lblactioncode2.AutoSize = true;
            this.lblactioncode2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactioncode2.Location = new System.Drawing.Point(178, 79);
            this.lblactioncode2.Name = "lblactioncode2";
            this.lblactioncode2.Size = new System.Drawing.Size(28, 15);
            this.lblactioncode2.TabIndex = 368;
            this.lblactioncode2.Text = "PTP";
            // 
            // cbPLaction2
            // 
            this.cbPLaction2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPLaction2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPLaction2.FormattingEnabled = true;
            this.cbPLaction2.Items.AddRange(new object[] {
            "PTP"});
            this.cbPLaction2.Location = new System.Drawing.Point(854, 78);
            this.cbPLaction2.Name = "cbPLaction2";
            this.cbPLaction2.Size = new System.Drawing.Size(153, 23);
            this.cbPLaction2.TabIndex = 1001;
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label253.Location = new System.Drawing.Point(723, 74);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(97, 30);
            this.label253.TabIndex = 364;
            this.label253.Text = "Action Code / \r\nDisposition Code";
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label254.Location = new System.Drawing.Point(723, 52);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(80, 15);
            this.label254.TabIndex = 363;
            this.label254.Text = "Loan Number";
            // 
            // cbPLaction1
            // 
            this.cbPLaction1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPLaction1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPLaction1.FormattingEnabled = true;
            this.cbPLaction1.Items.AddRange(new object[] {
            "PTP"});
            this.cbPLaction1.Location = new System.Drawing.Point(507, 78);
            this.cbPLaction1.Name = "cbPLaction1";
            this.cbPLaction1.Size = new System.Drawing.Size(153, 23);
            this.cbPLaction1.TabIndex = 1000;
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label255.Location = new System.Drawing.Point(385, 74);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(97, 30);
            this.label255.TabIndex = 360;
            this.label255.Text = "Action Code / \r\nDisposition Code";
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label256.Location = new System.Drawing.Point(385, 52);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(80, 15);
            this.label256.TabIndex = 359;
            this.label256.Text = "Loan Number";
            // 
            // cbContactPersonPl
            // 
            this.cbContactPersonPl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPersonPl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPersonPl.FormattingEnabled = true;
            this.cbContactPersonPl.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPersonPl.Location = new System.Drawing.Point(176, 168);
            this.cbContactPersonPl.Name = "cbContactPersonPl";
            this.cbContactPersonPl.Size = new System.Drawing.Size(153, 23);
            this.cbContactPersonPl.TabIndex = 1004;
            // 
            // cbContactPLPlace
            // 
            this.cbContactPLPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContactPLPlace.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbContactPLPlace.FormattingEnabled = true;
            this.cbContactPLPlace.Items.AddRange(new object[] {
            "PTP"});
            this.cbContactPLPlace.Location = new System.Drawing.Point(176, 140);
            this.cbContactPLPlace.Name = "cbContactPLPlace";
            this.cbContactPLPlace.Size = new System.Drawing.Size(153, 23);
            this.cbContactPLPlace.TabIndex = 1003;
            // 
            // txtRemarkleave
            // 
            this.txtRemarkleave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarkleave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkleave.Location = new System.Drawing.Point(176, 198);
            this.txtRemarkleave.MaxLength = 100;
            this.txtRemarkleave.Name = "txtRemarkleave";
            this.txtRemarkleave.Size = new System.Drawing.Size(752, 23);
            this.txtRemarkleave.TabIndex = 1004;
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label257.Location = new System.Drawing.Point(12, 198);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(52, 15);
            this.label257.TabIndex = 352;
            this.label257.Text = "Remarks";
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label258.Location = new System.Drawing.Point(12, 168);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(88, 15);
            this.label258.TabIndex = 351;
            this.label258.Text = "Contact Person";
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label259.Location = new System.Drawing.Point(12, 140);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(80, 15);
            this.label259.TabIndex = 350;
            this.label259.Text = "Contact Place";
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label260.Location = new System.Drawing.Point(12, 112);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(83, 15);
            this.label260.TabIndex = 349;
            this.label260.Text = "Contact Mode";
            // 
            // label261
            // 
            this.label261.AutoSize = true;
            this.label261.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label261.Location = new System.Drawing.Point(12, 74);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(97, 30);
            this.label261.TabIndex = 348;
            this.label261.Text = "Action Code / \r\nDisposition Code";
            // 
            // button39
            // 
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button39.Location = new System.Drawing.Point(176, 268);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(92, 27);
            this.button39.TabIndex = 1006;
            this.button39.Text = "Save Activity";
            this.button39.UseVisualStyleBackColor = true;
            this.button39.Click += new System.EventHandler(this.button39_Click);
            // 
            // label262
            // 
            this.label262.AutoSize = true;
            this.label262.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label262.Location = new System.Drawing.Point(12, 52);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(80, 15);
            this.label262.TabIndex = 346;
            this.label262.Text = "Loan Number";
            // 
            // btnCancel1
            // 
            this.btnCancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel1.Location = new System.Drawing.Point(279, 268);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 27);
            this.btnCancel1.TabIndex = 1007;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.button40_Click);
            // 
            // label263
            // 
            this.label263.AutoSize = true;
            this.label263.BackColor = System.Drawing.Color.SandyBrown;
            this.label263.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label263.Location = new System.Drawing.Point(12, 21);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(39, 15);
            this.label263.TabIndex = 303;
            this.label263.Text = "Result";
            // 
            // label264
            // 
            this.label264.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label264.BackColor = System.Drawing.Color.Yellow;
            this.label264.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label264.Location = new System.Drawing.Point(211, 16);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(1480, 25);
            this.label264.TabIndex = 301;
            this.label264.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label265
            // 
            this.label265.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label265.BackColor = System.Drawing.Color.SandyBrown;
            this.label265.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label265.Location = new System.Drawing.Point(7, 16);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(818, 25);
            this.label265.TabIndex = 302;
            this.label265.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.grp_action1);
            this.grp_action.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_action.Location = new System.Drawing.Point(0, 615);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(1236, 226);
            this.grp_action.TabIndex = 324;
            // 
            // grp_action1
            // 
            this.grp_action1.Controls.Add(this.label31);
            this.grp_action1.Controls.Add(this.label125);
            this.grp_action1.Controls.Add(this.label157);
            this.grp_action1.Controls.Add(this.button18);
            this.grp_action1.Controls.Add(this.button17);
            this.grp_action1.Controls.Add(this.button16);
            this.grp_action1.Controls.Add(this.button15);
            this.grp_action1.Controls.Add(this.button14);
            this.grp_action1.Controls.Add(this.button13);
            this.grp_action1.Controls.Add(this.button11);
            this.grp_action1.Controls.Add(this.button9);
            this.grp_action1.Controls.Add(this.button5);
            this.grp_action1.Controls.Add(this.label37);
            this.grp_action1.Controls.Add(this.button4);
            this.grp_action1.Controls.Add(this.label36);
            this.grp_action1.Controls.Add(this.button3);
            this.grp_action1.Controls.Add(this.label35);
            this.grp_action1.Controls.Add(this.button2);
            this.grp_action1.Controls.Add(this.label34);
            this.grp_action1.Controls.Add(this.btnPTP);
            this.grp_action1.Controls.Add(this.label33);
            this.grp_action1.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_action1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_action1.Location = new System.Drawing.Point(0, 0);
            this.grp_action1.Name = "grp_action1";
            this.grp_action1.Size = new System.Drawing.Size(1236, 226);
            this.grp_action1.TabIndex = 311;
            this.grp_action1.TabStop = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.SandyBrown;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 15);
            this.label31.TabIndex = 303;
            this.label31.Text = "Result";
            // 
            // label125
            // 
            this.label125.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label125.BackColor = System.Drawing.Color.Yellow;
            this.label125.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.Location = new System.Drawing.Point(211, 16);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(1480, 25);
            this.label125.TabIndex = 301;
            this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label157
            // 
            this.label157.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label157.BackColor = System.Drawing.Color.SandyBrown;
            this.label157.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.Location = new System.Drawing.Point(7, 16);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(818, 25);
            this.label157.TabIndex = 302;
            this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(674, 144);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(164, 27);
            this.button18.TabIndex = 186;
            this.button18.Text = "Acc tidak layak tagih";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(504, 144);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(164, 27);
            this.button17.TabIndex = 185;
            this.button17.Text = "Customer Decease";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(335, 144);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(164, 27);
            this.button16.TabIndex = 184;
            this.button16.Text = "Sent to FC";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(844, 111);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(164, 27);
            this.button15.TabIndex = 183;
            this.button15.Text = "Phone No Answer";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(674, 111);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(164, 27);
            this.button14.TabIndex = 182;
            this.button14.Text = "Phone Disconnected";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(504, 111);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(164, 27);
            this.button13.TabIndex = 181;
            this.button13.Text = "Phone Busy";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(335, 111);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(164, 27);
            this.button11.TabIndex = 180;
            this.button11.Text = "Phone Leave Message";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(335, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(164, 27);
            this.button9.TabIndex = 179;
            this.button9.Text = "Contact With CP";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(165, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 27);
            this.button5.TabIndex = 178;
            this.button5.Text = "Phone Reminder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 178);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(95, 15);
            this.label37.TabIndex = 177;
            this.label37.Text = "Phone Reminder";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(165, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 27);
            this.button4.TabIndex = 176;
            this.button4.Text = "Case / Complain";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 138);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(97, 30);
            this.label36.TabIndex = 175;
            this.label36.Text = "Exclusion / \r\nEscalation to SPV";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(165, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 27);
            this.button3.TabIndex = 174;
            this.button3.Text = "Phone Other";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(6, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(68, 15);
            this.label35.TabIndex = 173;
            this.label35.Text = "No Contact";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 27);
            this.button2.TabIndex = 172;
            this.button2.Text = "Contact With Borrower";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(6, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(117, 15);
            this.label34.TabIndex = 171;
            this.label34.Text = "Contact without PTP";
            // 
            // btnPTP
            // 
            this.btnPTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPTP.Location = new System.Drawing.Point(165, 51);
            this.btnPTP.Name = "btnPTP";
            this.btnPTP.Size = new System.Drawing.Size(164, 27);
            this.btnPTP.TabIndex = 170;
            this.btnPTP.Text = "PTP";
            this.btnPTP.UseVisualStyleBackColor = true;
            this.btnPTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(6, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(99, 15);
            this.label33.TabIndex = 169;
            this.label33.Text = "Contact with PTP";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.groupBox5);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 272);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1236, 343);
            this.panel11.TabIndex = 323;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtmsg);
            this.groupBox5.Controls.Add(this.lblInhouseScore);
            this.groupBox5.Controls.Add(this.lblForeClosure_amt1);
            this.groupBox5.Controls.Add(this.lblBilingCycle);
            this.groupBox5.Controls.Add(this.lblDPD4);
            this.groupBox5.Controls.Add(this.lblLastPaymentDate);
            this.groupBox5.Controls.Add(this.lblLastPaymentAmount);
            this.groupBox5.Controls.Add(this.lblOpenDate);
            this.groupBox5.Controls.Add(this.lblBucket7);
            this.groupBox5.Controls.Add(this.lblBucket6);
            this.groupBox5.Controls.Add(this.lblBucket5);
            this.groupBox5.Controls.Add(this.lblBucket4);
            this.groupBox5.Controls.Add(this.lblBucket3);
            this.groupBox5.Controls.Add(this.lblBucket2);
            this.groupBox5.Controls.Add(this.lblBucket1);
            this.groupBox5.Controls.Add(this.lblChargesOverdue);
            this.groupBox5.Controls.Add(this.lblInterestOverdue);
            this.groupBox5.Controls.Add(this.lblPrincipleOverdue);
            this.groupBox5.Controls.Add(this.lblAmountOverdue);
            this.groupBox5.Controls.Add(this.lblOutstanding);
            this.groupBox5.Controls.Add(this.label126);
            this.groupBox5.Controls.Add(this.label127);
            this.groupBox5.Controls.Add(this.label156);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1236, 343);
            this.groupBox5.TabIndex = 301;
            this.groupBox5.TabStop = false;
            // 
            // txtmsg
            // 
            this.txtmsg.BackColor = System.Drawing.Color.White;
            this.txtmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtmsg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsg.Location = new System.Drawing.Point(791, 45);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ReadOnly = true;
            this.txtmsg.Size = new System.Drawing.Size(391, 273);
            this.txtmsg.TabIndex = 487;
            this.txtmsg.Text = "Selamat pagi . Hingga saat ini kami belum menerima pembayaran pinjaman anda denga" +
    "n nomor loan . Mohon segera lakukan pembayaran. Terima kasih";
            // 
            // lblInhouseScore
            // 
            this.lblInhouseScore.BackColor = System.Drawing.Color.White;
            this.lblInhouseScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInhouseScore.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInhouseScore.Location = new System.Drawing.Point(154, 183);
            this.lblInhouseScore.Name = "lblInhouseScore";
            this.lblInhouseScore.ReadOnly = true;
            this.lblInhouseScore.Size = new System.Drawing.Size(250, 15);
            this.lblInhouseScore.TabIndex = 486;
            this.lblInhouseScore.Text = "Loan";
            // 
            // lblForeClosure_amt1
            // 
            this.lblForeClosure_amt1.BackColor = System.Drawing.Color.White;
            this.lblForeClosure_amt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblForeClosure_amt1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForeClosure_amt1.Location = new System.Drawing.Point(154, 160);
            this.lblForeClosure_amt1.Name = "lblForeClosure_amt1";
            this.lblForeClosure_amt1.ReadOnly = true;
            this.lblForeClosure_amt1.Size = new System.Drawing.Size(250, 15);
            this.lblForeClosure_amt1.TabIndex = 485;
            this.lblForeClosure_amt1.Text = "Loan";
            // 
            // lblBilingCycle
            // 
            this.lblBilingCycle.BackColor = System.Drawing.Color.White;
            this.lblBilingCycle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBilingCycle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilingCycle.Location = new System.Drawing.Point(154, 137);
            this.lblBilingCycle.Name = "lblBilingCycle";
            this.lblBilingCycle.ReadOnly = true;
            this.lblBilingCycle.Size = new System.Drawing.Size(250, 15);
            this.lblBilingCycle.TabIndex = 484;
            this.lblBilingCycle.Text = "Loan";
            // 
            // lblDPD4
            // 
            this.lblDPD4.BackColor = System.Drawing.Color.White;
            this.lblDPD4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDPD4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPD4.Location = new System.Drawing.Point(154, 114);
            this.lblDPD4.Name = "lblDPD4";
            this.lblDPD4.ReadOnly = true;
            this.lblDPD4.Size = new System.Drawing.Size(250, 15);
            this.lblDPD4.TabIndex = 483;
            this.lblDPD4.Text = "Loan";
            // 
            // lblLastPaymentDate
            // 
            this.lblLastPaymentDate.BackColor = System.Drawing.Color.White;
            this.lblLastPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLastPaymentDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPaymentDate.Location = new System.Drawing.Point(154, 91);
            this.lblLastPaymentDate.Name = "lblLastPaymentDate";
            this.lblLastPaymentDate.ReadOnly = true;
            this.lblLastPaymentDate.Size = new System.Drawing.Size(250, 15);
            this.lblLastPaymentDate.TabIndex = 482;
            this.lblLastPaymentDate.Text = "Loan";
            // 
            // lblLastPaymentAmount
            // 
            this.lblLastPaymentAmount.BackColor = System.Drawing.Color.White;
            this.lblLastPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLastPaymentAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPaymentAmount.Location = new System.Drawing.Point(154, 68);
            this.lblLastPaymentAmount.Name = "lblLastPaymentAmount";
            this.lblLastPaymentAmount.ReadOnly = true;
            this.lblLastPaymentAmount.Size = new System.Drawing.Size(250, 15);
            this.lblLastPaymentAmount.TabIndex = 481;
            this.lblLastPaymentAmount.Text = "Loan";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.BackColor = System.Drawing.Color.White;
            this.lblOpenDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOpenDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenDate.Location = new System.Drawing.Point(154, 45);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.ReadOnly = true;
            this.lblOpenDate.Size = new System.Drawing.Size(250, 15);
            this.lblOpenDate.TabIndex = 480;
            this.lblOpenDate.Text = "Loan";
            // 
            // lblBucket7
            // 
            this.lblBucket7.BackColor = System.Drawing.Color.White;
            this.lblBucket7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket7.Location = new System.Drawing.Point(572, 294);
            this.lblBucket7.Name = "lblBucket7";
            this.lblBucket7.ReadOnly = true;
            this.lblBucket7.Size = new System.Drawing.Size(190, 15);
            this.lblBucket7.TabIndex = 479;
            this.lblBucket7.Text = "Loan";
            // 
            // lblBucket6
            // 
            this.lblBucket6.BackColor = System.Drawing.Color.White;
            this.lblBucket6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket6.Location = new System.Drawing.Point(572, 272);
            this.lblBucket6.Name = "lblBucket6";
            this.lblBucket6.ReadOnly = true;
            this.lblBucket6.Size = new System.Drawing.Size(190, 15);
            this.lblBucket6.TabIndex = 478;
            this.lblBucket6.Text = "Loan";
            // 
            // lblBucket5
            // 
            this.lblBucket5.BackColor = System.Drawing.Color.White;
            this.lblBucket5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket5.Location = new System.Drawing.Point(572, 250);
            this.lblBucket5.Name = "lblBucket5";
            this.lblBucket5.ReadOnly = true;
            this.lblBucket5.Size = new System.Drawing.Size(190, 15);
            this.lblBucket5.TabIndex = 477;
            this.lblBucket5.Text = "Loan";
            // 
            // lblBucket4
            // 
            this.lblBucket4.BackColor = System.Drawing.Color.White;
            this.lblBucket4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket4.Location = new System.Drawing.Point(572, 228);
            this.lblBucket4.Name = "lblBucket4";
            this.lblBucket4.ReadOnly = true;
            this.lblBucket4.Size = new System.Drawing.Size(190, 15);
            this.lblBucket4.TabIndex = 476;
            this.lblBucket4.Text = "Loan";
            // 
            // lblBucket3
            // 
            this.lblBucket3.BackColor = System.Drawing.Color.White;
            this.lblBucket3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket3.Location = new System.Drawing.Point(572, 206);
            this.lblBucket3.Name = "lblBucket3";
            this.lblBucket3.ReadOnly = true;
            this.lblBucket3.Size = new System.Drawing.Size(190, 15);
            this.lblBucket3.TabIndex = 475;
            this.lblBucket3.Text = "Loan";
            // 
            // lblBucket2
            // 
            this.lblBucket2.BackColor = System.Drawing.Color.White;
            this.lblBucket2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket2.Location = new System.Drawing.Point(572, 183);
            this.lblBucket2.Name = "lblBucket2";
            this.lblBucket2.ReadOnly = true;
            this.lblBucket2.Size = new System.Drawing.Size(190, 15);
            this.lblBucket2.TabIndex = 474;
            this.lblBucket2.Text = "Loan";
            // 
            // lblBucket1
            // 
            this.lblBucket1.BackColor = System.Drawing.Color.White;
            this.lblBucket1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBucket1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBucket1.Location = new System.Drawing.Point(572, 160);
            this.lblBucket1.Name = "lblBucket1";
            this.lblBucket1.ReadOnly = true;
            this.lblBucket1.Size = new System.Drawing.Size(190, 15);
            this.lblBucket1.TabIndex = 473;
            this.lblBucket1.Text = "Loan";
            // 
            // lblChargesOverdue
            // 
            this.lblChargesOverdue.BackColor = System.Drawing.Color.White;
            this.lblChargesOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblChargesOverdue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChargesOverdue.Location = new System.Drawing.Point(572, 137);
            this.lblChargesOverdue.Name = "lblChargesOverdue";
            this.lblChargesOverdue.ReadOnly = true;
            this.lblChargesOverdue.Size = new System.Drawing.Size(190, 15);
            this.lblChargesOverdue.TabIndex = 472;
            this.lblChargesOverdue.Text = "Loan";
            // 
            // lblInterestOverdue
            // 
            this.lblInterestOverdue.BackColor = System.Drawing.Color.White;
            this.lblInterestOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblInterestOverdue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestOverdue.Location = new System.Drawing.Point(572, 114);
            this.lblInterestOverdue.Name = "lblInterestOverdue";
            this.lblInterestOverdue.ReadOnly = true;
            this.lblInterestOverdue.Size = new System.Drawing.Size(190, 15);
            this.lblInterestOverdue.TabIndex = 471;
            this.lblInterestOverdue.Text = "Loan";
            // 
            // lblPrincipleOverdue
            // 
            this.lblPrincipleOverdue.BackColor = System.Drawing.Color.White;
            this.lblPrincipleOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrincipleOverdue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipleOverdue.Location = new System.Drawing.Point(572, 91);
            this.lblPrincipleOverdue.Name = "lblPrincipleOverdue";
            this.lblPrincipleOverdue.ReadOnly = true;
            this.lblPrincipleOverdue.Size = new System.Drawing.Size(190, 15);
            this.lblPrincipleOverdue.TabIndex = 470;
            this.lblPrincipleOverdue.Text = "Loan";
            // 
            // lblAmountOverdue
            // 
            this.lblAmountOverdue.BackColor = System.Drawing.Color.White;
            this.lblAmountOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAmountOverdue.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOverdue.Location = new System.Drawing.Point(572, 68);
            this.lblAmountOverdue.Name = "lblAmountOverdue";
            this.lblAmountOverdue.ReadOnly = true;
            this.lblAmountOverdue.Size = new System.Drawing.Size(190, 15);
            this.lblAmountOverdue.TabIndex = 469;
            this.lblAmountOverdue.Text = "Loan";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.BackColor = System.Drawing.Color.White;
            this.lblOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOutstanding.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutstanding.Location = new System.Drawing.Point(572, 45);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.ReadOnly = true;
            this.lblOutstanding.Size = new System.Drawing.Size(190, 15);
            this.lblOutstanding.TabIndex = 468;
            this.lblOutstanding.Text = "Loan";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.BackColor = System.Drawing.Color.SandyBrown;
            this.label126.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(5, 17);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(120, 15);
            this.label126.TabIndex = 338;
            this.label126.Text = "Financial Information";
            // 
            // label127
            // 
            this.label127.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label127.BackColor = System.Drawing.Color.Yellow;
            this.label127.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.Location = new System.Drawing.Point(209, 12);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(1480, 25);
            this.label127.TabIndex = 337;
            this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label156
            // 
            this.label156.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label156.BackColor = System.Drawing.Color.SandyBrown;
            this.label156.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.Location = new System.Drawing.Point(5, 12);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(769, 25);
            this.label156.TabIndex = 339;
            this.label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(440, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 316;
            this.label16.Text = "Bucket 7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(440, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 315;
            this.label17.Text = "Bucket 6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(440, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 15);
            this.label18.TabIndex = 314;
            this.label18.Text = "Bucket 5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(440, 228);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 15);
            this.label19.TabIndex = 313;
            this.label19.Text = "Bucket 4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(440, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 312;
            this.label20.Text = "Bucket 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 311;
            this.label12.Text = "Bucket 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(440, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 310;
            this.label13.Text = "Bucket 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(439, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 15);
            this.label14.TabIndex = 309;
            this.label14.Text = "Charges Overdue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(439, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 15);
            this.label15.TabIndex = 308;
            this.label15.Text = "Interest Overdue";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(439, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 15);
            this.label21.TabIndex = 307;
            this.label21.Text = "Principle Overdue";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(439, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 15);
            this.label22.TabIndex = 306;
            this.label22.Text = "Amount Overdue";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(439, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 15);
            this.label23.TabIndex = 305;
            this.label23.Text = "Outstanding Balance";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 183);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 15);
            this.label24.TabIndex = 304;
            this.label24.Text = "INHOUSE SCORE3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(114, 15);
            this.label25.TabIndex = 303;
            this.label25.Text = "FORECLOSURE AMT";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(12, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 15);
            this.label26.TabIndex = 302;
            this.label26.Text = "Billing Cycle";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(12, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 15);
            this.label27.TabIndex = 301;
            this.label27.Text = "DPD";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(12, 91);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 15);
            this.label28.TabIndex = 300;
            this.label28.Text = "Last Payment Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(12, 68);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(125, 15);
            this.label29.TabIndex = 299;
            this.label29.Text = "Last Payment Amount";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(63, 15);
            this.label30.TabIndex = 298;
            this.label30.Text = "Open Date";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox4);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1236, 272);
            this.panel10.TabIndex = 322;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPother);
            this.groupBox4.Controls.Add(this.lblPoffice);
            this.groupBox4.Controls.Add(this.lblPhome);
            this.groupBox4.Controls.Add(this.lblRegion);
            this.groupBox4.Controls.Add(this.lblGender);
            this.groupBox4.Controls.Add(this.lblProduct);
            this.groupBox4.Controls.Add(this.lblDOB);
            this.groupBox4.Controls.Add(this.lblCustName1);
            this.groupBox4.Controls.Add(this.lblLoan4);
            this.groupBox4.Controls.Add(this.lblServiceName2);
            this.groupBox4.Controls.Add(this.label121);
            this.groupBox4.Controls.Add(this.label122);
            this.groupBox4.Controls.Add(this.label123);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtContactno);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1236, 255);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lblPother
            // 
            this.lblPother.BackColor = System.Drawing.Color.White;
            this.lblPother.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPother.Location = new System.Drawing.Point(919, 167);
            this.lblPother.Multiline = true;
            this.lblPother.Name = "lblPother";
            this.lblPother.ReadOnly = true;
            this.lblPother.Size = new System.Drawing.Size(244, 55);
            this.lblPother.TabIndex = 309;
            this.lblPother.Text = "Loan";
            // 
            // lblPoffice
            // 
            this.lblPoffice.BackColor = System.Drawing.Color.White;
            this.lblPoffice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPoffice.Location = new System.Drawing.Point(919, 112);
            this.lblPoffice.Multiline = true;
            this.lblPoffice.Name = "lblPoffice";
            this.lblPoffice.ReadOnly = true;
            this.lblPoffice.Size = new System.Drawing.Size(244, 55);
            this.lblPoffice.TabIndex = 308;
            this.lblPoffice.Text = "Loan";
            // 
            // lblPhome
            // 
            this.lblPhome.BackColor = System.Drawing.Color.White;
            this.lblPhome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPhome.Location = new System.Drawing.Point(919, 57);
            this.lblPhome.Multiline = true;
            this.lblPhome.Name = "lblPhome";
            this.lblPhome.ReadOnly = true;
            this.lblPhome.Size = new System.Drawing.Size(244, 55);
            this.lblPhome.TabIndex = 307;
            this.lblPhome.Text = "Loan";
            // 
            // lblRegion
            // 
            this.lblRegion.BackColor = System.Drawing.Color.White;
            this.lblRegion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRegion.Location = new System.Drawing.Point(593, 168);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.ReadOnly = true;
            this.lblRegion.Size = new System.Drawing.Size(250, 16);
            this.lblRegion.TabIndex = 306;
            this.lblRegion.Text = "Loan";
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.White;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGender.Location = new System.Drawing.Point(593, 121);
            this.lblGender.Name = "lblGender";
            this.lblGender.ReadOnly = true;
            this.lblGender.Size = new System.Drawing.Size(250, 16);
            this.lblGender.TabIndex = 305;
            this.lblGender.Text = "Loan";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProduct.Location = new System.Drawing.Point(593, 77);
            this.lblProduct.Multiline = true;
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.ReadOnly = true;
            this.lblProduct.Size = new System.Drawing.Size(244, 39);
            this.lblProduct.TabIndex = 304;
            this.lblProduct.Text = "Loan";
            // 
            // lblDOB
            // 
            this.lblDOB.BackColor = System.Drawing.Color.White;
            this.lblDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDOB.Location = new System.Drawing.Point(117, 168);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.ReadOnly = true;
            this.lblDOB.Size = new System.Drawing.Size(350, 16);
            this.lblDOB.TabIndex = 303;
            this.lblDOB.Text = "Loan";
            // 
            // lblCustName1
            // 
            this.lblCustName1.BackColor = System.Drawing.Color.White;
            this.lblCustName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustName1.Location = new System.Drawing.Point(117, 121);
            this.lblCustName1.Multiline = true;
            this.lblCustName1.Name = "lblCustName1";
            this.lblCustName1.ReadOnly = true;
            this.lblCustName1.Size = new System.Drawing.Size(350, 39);
            this.lblCustName1.TabIndex = 302;
            this.lblCustName1.Text = "Loan";
            // 
            // lblLoan4
            // 
            this.lblLoan4.BackColor = System.Drawing.Color.White;
            this.lblLoan4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan4.Location = new System.Drawing.Point(117, 75);
            this.lblLoan4.Name = "lblLoan4";
            this.lblLoan4.ReadOnly = true;
            this.lblLoan4.Size = new System.Drawing.Size(350, 16);
            this.lblLoan4.TabIndex = 301;
            this.lblLoan4.Text = "Loan";
            // 
            // lblServiceName2
            // 
            this.lblServiceName2.AutoSize = true;
            this.lblServiceName2.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName2.Location = new System.Drawing.Point(225, 18);
            this.lblServiceName2.Name = "lblServiceName2";
            this.lblServiceName2.Size = new System.Drawing.Size(39, 15);
            this.lblServiceName2.TabIndex = 290;
            this.lblServiceName2.Text = "Loan1";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.Color.SandyBrown;
            this.label121.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(4, 18);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(79, 15);
            this.label121.TabIndex = 289;
            this.label121.Text = "Service Name";
            // 
            // label122
            // 
            this.label122.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label122.BackColor = System.Drawing.Color.Yellow;
            this.label122.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.Location = new System.Drawing.Point(208, 13);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(1495, 25);
            this.label122.TabIndex = 288;
            this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label123.BackColor = System.Drawing.Color.SandyBrown;
            this.label123.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.Location = new System.Drawing.Point(4, 13);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(769, 25);
            this.label123.TabIndex = 291;
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(359, 46);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 287;
            this.button19.Text = "Others";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(278, 46);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 286;
            this.button20.Text = "Office";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(197, 46);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 285;
            this.button21.Text = "Home";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(116, 46);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 284;
            this.button22.Text = "Mobile";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(849, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 283;
            this.label9.Text = "Other";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(849, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 282;
            this.label10.Text = "Office";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(849, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 281;
            this.label11.Text = "Home";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(475, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 280;
            this.label6.Text = "Region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(475, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 279;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(475, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 278;
            this.label8.Text = "Sub Product Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 277;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 276;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 275;
            this.label3.Text = "Loan Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 274;
            this.label1.Text = "Contact No";
            // 
            // txtContactno
            // 
            this.txtContactno.BackColor = System.Drawing.Color.White;
            this.txtContactno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContactno.Location = new System.Drawing.Point(116, 46);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.ReadOnly = true;
            this.txtContactno.Size = new System.Drawing.Size(350, 16);
            this.txtContactno.TabIndex = 310;
            this.txtContactno.Text = "Loan";
            this.txtContactno.Visible = false;
            // 
            // infoTabPage
            // 
            this.infoTabPage.BackColor = System.Drawing.Color.White;
            this.infoTabPage.Controls.Add(this.panel2);
            this.infoTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTabPage.Location = new System.Drawing.Point(4, 38);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Size = new System.Drawing.Size(1259, 379);
            this.infoTabPage.TabIndex = 2;
            this.infoTabPage.Text = "Additional Information";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1259, 379);
            this.panel2.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel9);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 683);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1242, 284);
            this.panel16.TabIndex = 412;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.AutoScroll = true;
            this.panel9.Controls.Add(this.lblCONTACT_PLACE8);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE7);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE6);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE5);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE4);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE3);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE2);
            this.panel9.Controls.Add(this.lblCONTACT_PLACE1);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED8);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED7);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED6);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED5);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED4);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED3);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED2);
            this.panel9.Controls.Add(this.lblPERSON_CONTACTED1);
            this.panel9.Controls.Add(this.lblREMARKS8);
            this.panel9.Controls.Add(this.lblREMARKS7);
            this.panel9.Controls.Add(this.lblREMARKS6);
            this.panel9.Controls.Add(this.lblREMARKS5);
            this.panel9.Controls.Add(this.lblREMARKS4);
            this.panel9.Controls.Add(this.lblREMARKS3);
            this.panel9.Controls.Add(this.lblREMARKS2);
            this.panel9.Controls.Add(this.lblREMARKS1);
            this.panel9.Controls.Add(this.lblCONTACTED_BY8);
            this.panel9.Controls.Add(this.lblCONTACTED_BY7);
            this.panel9.Controls.Add(this.lblCONTACTED_BY6);
            this.panel9.Controls.Add(this.lblCONTACTED_BY5);
            this.panel9.Controls.Add(this.lblCONTACTED_BY4);
            this.panel9.Controls.Add(this.lblCONTACTED_BY3);
            this.panel9.Controls.Add(this.lblCONTACTED_BY2);
            this.panel9.Controls.Add(this.lblCONTACTED_BY1);
            this.panel9.Controls.Add(this.lblCONTACT_DATE8);
            this.panel9.Controls.Add(this.lblCONTACT_DATE7);
            this.panel9.Controls.Add(this.lblCONTACT_DATE6);
            this.panel9.Controls.Add(this.lblCONTACT_DATE5);
            this.panel9.Controls.Add(this.lblCONTACT_DATE4);
            this.panel9.Controls.Add(this.lblCONTACT_DATE3);
            this.panel9.Controls.Add(this.lblCONTACT_DATE2);
            this.panel9.Controls.Add(this.lblCONTACT_DATE1);
            this.panel9.Controls.Add(this.textBox2);
            this.panel9.Controls.Add(this.lblACTION_CODE7);
            this.panel9.Controls.Add(this.lblACTION_CODE6);
            this.panel9.Controls.Add(this.lblACTION_CODE5);
            this.panel9.Controls.Add(this.lblACTION_CODE4);
            this.panel9.Controls.Add(this.lblACTION_CODE3);
            this.panel9.Controls.Add(this.lblACTION_CODE2);
            this.panel9.Controls.Add(this.lblACTION_CODE1);
            this.panel9.Controls.Add(this.label175);
            this.panel9.Controls.Add(this.label167);
            this.panel9.Controls.Add(this.label152);
            this.panel9.Controls.Add(this.label153);
            this.panel9.Controls.Add(this.label154);
            this.panel9.Controls.Add(this.label155);
            this.panel9.Controls.Add(this.label158);
            this.panel9.Controls.Add(this.label159);
            this.panel9.Controls.Add(this.label160);
            this.panel9.Controls.Add(this.label161);
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1242, 284);
            this.panel9.TabIndex = 407;
            // 
            // lblCONTACT_PLACE8
            // 
            this.lblCONTACT_PLACE8.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE8.Location = new System.Drawing.Point(1240, 227);
            this.lblCONTACT_PLACE8.Name = "lblCONTACT_PLACE8";
            this.lblCONTACT_PLACE8.ReadOnly = true;
            this.lblCONTACT_PLACE8.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE8.TabIndex = 491;
            this.lblCONTACT_PLACE8.Text = "Loan";
            this.lblCONTACT_PLACE8.Visible = false;
            // 
            // lblCONTACT_PLACE7
            // 
            this.lblCONTACT_PLACE7.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE7.Location = new System.Drawing.Point(1240, 204);
            this.lblCONTACT_PLACE7.Name = "lblCONTACT_PLACE7";
            this.lblCONTACT_PLACE7.ReadOnly = true;
            this.lblCONTACT_PLACE7.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE7.TabIndex = 490;
            this.lblCONTACT_PLACE7.Text = "Loan";
            this.lblCONTACT_PLACE7.Visible = false;
            // 
            // lblCONTACT_PLACE6
            // 
            this.lblCONTACT_PLACE6.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE6.Location = new System.Drawing.Point(1240, 181);
            this.lblCONTACT_PLACE6.Name = "lblCONTACT_PLACE6";
            this.lblCONTACT_PLACE6.ReadOnly = true;
            this.lblCONTACT_PLACE6.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE6.TabIndex = 489;
            this.lblCONTACT_PLACE6.Text = "Loan";
            // 
            // lblCONTACT_PLACE5
            // 
            this.lblCONTACT_PLACE5.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE5.Location = new System.Drawing.Point(1240, 158);
            this.lblCONTACT_PLACE5.Name = "lblCONTACT_PLACE5";
            this.lblCONTACT_PLACE5.ReadOnly = true;
            this.lblCONTACT_PLACE5.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE5.TabIndex = 488;
            this.lblCONTACT_PLACE5.Text = "Loan";
            // 
            // lblCONTACT_PLACE4
            // 
            this.lblCONTACT_PLACE4.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE4.Location = new System.Drawing.Point(1240, 135);
            this.lblCONTACT_PLACE4.Name = "lblCONTACT_PLACE4";
            this.lblCONTACT_PLACE4.ReadOnly = true;
            this.lblCONTACT_PLACE4.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE4.TabIndex = 487;
            this.lblCONTACT_PLACE4.Text = "Loan";
            // 
            // lblCONTACT_PLACE3
            // 
            this.lblCONTACT_PLACE3.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE3.Location = new System.Drawing.Point(1240, 112);
            this.lblCONTACT_PLACE3.Name = "lblCONTACT_PLACE3";
            this.lblCONTACT_PLACE3.ReadOnly = true;
            this.lblCONTACT_PLACE3.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE3.TabIndex = 486;
            this.lblCONTACT_PLACE3.Text = "Loan";
            // 
            // lblCONTACT_PLACE2
            // 
            this.lblCONTACT_PLACE2.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE2.Location = new System.Drawing.Point(1240, 89);
            this.lblCONTACT_PLACE2.Name = "lblCONTACT_PLACE2";
            this.lblCONTACT_PLACE2.ReadOnly = true;
            this.lblCONTACT_PLACE2.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE2.TabIndex = 485;
            this.lblCONTACT_PLACE2.Text = "Loan";
            // 
            // lblCONTACT_PLACE1
            // 
            this.lblCONTACT_PLACE1.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_PLACE1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_PLACE1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_PLACE1.Location = new System.Drawing.Point(1240, 66);
            this.lblCONTACT_PLACE1.Name = "lblCONTACT_PLACE1";
            this.lblCONTACT_PLACE1.ReadOnly = true;
            this.lblCONTACT_PLACE1.Size = new System.Drawing.Size(154, 15);
            this.lblCONTACT_PLACE1.TabIndex = 484;
            this.lblCONTACT_PLACE1.Text = "Loan";
            // 
            // lblPERSON_CONTACTED8
            // 
            this.lblPERSON_CONTACTED8.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED8.Location = new System.Drawing.Point(1071, 227);
            this.lblPERSON_CONTACTED8.Name = "lblPERSON_CONTACTED8";
            this.lblPERSON_CONTACTED8.ReadOnly = true;
            this.lblPERSON_CONTACTED8.Size = new System.Drawing.Size(158, 15);
            this.lblPERSON_CONTACTED8.TabIndex = 483;
            this.lblPERSON_CONTACTED8.Text = "Loan";
            this.lblPERSON_CONTACTED8.Visible = false;
            // 
            // lblPERSON_CONTACTED7
            // 
            this.lblPERSON_CONTACTED7.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED7.Location = new System.Drawing.Point(1071, 204);
            this.lblPERSON_CONTACTED7.Name = "lblPERSON_CONTACTED7";
            this.lblPERSON_CONTACTED7.ReadOnly = true;
            this.lblPERSON_CONTACTED7.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED7.TabIndex = 482;
            this.lblPERSON_CONTACTED7.Text = "Loan";
            this.lblPERSON_CONTACTED7.Visible = false;
            // 
            // lblPERSON_CONTACTED6
            // 
            this.lblPERSON_CONTACTED6.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED6.Location = new System.Drawing.Point(1071, 181);
            this.lblPERSON_CONTACTED6.Name = "lblPERSON_CONTACTED6";
            this.lblPERSON_CONTACTED6.ReadOnly = true;
            this.lblPERSON_CONTACTED6.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED6.TabIndex = 481;
            this.lblPERSON_CONTACTED6.Text = "Loan";
            // 
            // lblPERSON_CONTACTED5
            // 
            this.lblPERSON_CONTACTED5.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED5.Location = new System.Drawing.Point(1071, 158);
            this.lblPERSON_CONTACTED5.Name = "lblPERSON_CONTACTED5";
            this.lblPERSON_CONTACTED5.ReadOnly = true;
            this.lblPERSON_CONTACTED5.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED5.TabIndex = 480;
            this.lblPERSON_CONTACTED5.Text = "Loan";
            // 
            // lblPERSON_CONTACTED4
            // 
            this.lblPERSON_CONTACTED4.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED4.Location = new System.Drawing.Point(1071, 135);
            this.lblPERSON_CONTACTED4.Name = "lblPERSON_CONTACTED4";
            this.lblPERSON_CONTACTED4.ReadOnly = true;
            this.lblPERSON_CONTACTED4.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED4.TabIndex = 479;
            this.lblPERSON_CONTACTED4.Text = "Loan";
            // 
            // lblPERSON_CONTACTED3
            // 
            this.lblPERSON_CONTACTED3.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED3.Location = new System.Drawing.Point(1071, 112);
            this.lblPERSON_CONTACTED3.Name = "lblPERSON_CONTACTED3";
            this.lblPERSON_CONTACTED3.ReadOnly = true;
            this.lblPERSON_CONTACTED3.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED3.TabIndex = 478;
            this.lblPERSON_CONTACTED3.Text = "Loan";
            // 
            // lblPERSON_CONTACTED2
            // 
            this.lblPERSON_CONTACTED2.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED2.Location = new System.Drawing.Point(1071, 89);
            this.lblPERSON_CONTACTED2.Name = "lblPERSON_CONTACTED2";
            this.lblPERSON_CONTACTED2.ReadOnly = true;
            this.lblPERSON_CONTACTED2.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED2.TabIndex = 477;
            this.lblPERSON_CONTACTED2.Text = "Loan";
            // 
            // lblPERSON_CONTACTED1
            // 
            this.lblPERSON_CONTACTED1.BackColor = System.Drawing.Color.White;
            this.lblPERSON_CONTACTED1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPERSON_CONTACTED1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPERSON_CONTACTED1.Location = new System.Drawing.Point(1071, 66);
            this.lblPERSON_CONTACTED1.Name = "lblPERSON_CONTACTED1";
            this.lblPERSON_CONTACTED1.ReadOnly = true;
            this.lblPERSON_CONTACTED1.Size = new System.Drawing.Size(159, 15);
            this.lblPERSON_CONTACTED1.TabIndex = 476;
            this.lblPERSON_CONTACTED1.Text = "Loan";
            // 
            // lblREMARKS8
            // 
            this.lblREMARKS8.BackColor = System.Drawing.Color.White;
            this.lblREMARKS8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS8.Location = new System.Drawing.Point(438, 227);
            this.lblREMARKS8.Name = "lblREMARKS8";
            this.lblREMARKS8.ReadOnly = true;
            this.lblREMARKS8.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS8.TabIndex = 475;
            this.lblREMARKS8.Text = "Loan";
            this.lblREMARKS8.Visible = false;
            // 
            // lblREMARKS7
            // 
            this.lblREMARKS7.BackColor = System.Drawing.Color.White;
            this.lblREMARKS7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS7.Location = new System.Drawing.Point(438, 204);
            this.lblREMARKS7.Name = "lblREMARKS7";
            this.lblREMARKS7.ReadOnly = true;
            this.lblREMARKS7.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS7.TabIndex = 474;
            this.lblREMARKS7.Text = "Loan";
            this.lblREMARKS7.Visible = false;
            // 
            // lblREMARKS6
            // 
            this.lblREMARKS6.BackColor = System.Drawing.Color.White;
            this.lblREMARKS6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS6.Location = new System.Drawing.Point(438, 181);
            this.lblREMARKS6.Name = "lblREMARKS6";
            this.lblREMARKS6.ReadOnly = true;
            this.lblREMARKS6.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS6.TabIndex = 473;
            this.lblREMARKS6.Text = "Loan";
            // 
            // lblREMARKS5
            // 
            this.lblREMARKS5.BackColor = System.Drawing.Color.White;
            this.lblREMARKS5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS5.Location = new System.Drawing.Point(438, 158);
            this.lblREMARKS5.Name = "lblREMARKS5";
            this.lblREMARKS5.ReadOnly = true;
            this.lblREMARKS5.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS5.TabIndex = 472;
            this.lblREMARKS5.Text = "Loan";
            // 
            // lblREMARKS4
            // 
            this.lblREMARKS4.BackColor = System.Drawing.Color.White;
            this.lblREMARKS4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS4.Location = new System.Drawing.Point(438, 135);
            this.lblREMARKS4.Name = "lblREMARKS4";
            this.lblREMARKS4.ReadOnly = true;
            this.lblREMARKS4.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS4.TabIndex = 471;
            this.lblREMARKS4.Text = "Loan";
            // 
            // lblREMARKS3
            // 
            this.lblREMARKS3.BackColor = System.Drawing.Color.White;
            this.lblREMARKS3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS3.Location = new System.Drawing.Point(438, 112);
            this.lblREMARKS3.Name = "lblREMARKS3";
            this.lblREMARKS3.ReadOnly = true;
            this.lblREMARKS3.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS3.TabIndex = 470;
            this.lblREMARKS3.Text = "Loan";
            // 
            // lblREMARKS2
            // 
            this.lblREMARKS2.BackColor = System.Drawing.Color.White;
            this.lblREMARKS2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS2.Location = new System.Drawing.Point(438, 89);
            this.lblREMARKS2.Name = "lblREMARKS2";
            this.lblREMARKS2.ReadOnly = true;
            this.lblREMARKS2.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS2.TabIndex = 469;
            this.lblREMARKS2.Text = "Loan";
            // 
            // lblREMARKS1
            // 
            this.lblREMARKS1.BackColor = System.Drawing.Color.White;
            this.lblREMARKS1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblREMARKS1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblREMARKS1.Location = new System.Drawing.Point(438, 66);
            this.lblREMARKS1.Name = "lblREMARKS1";
            this.lblREMARKS1.ReadOnly = true;
            this.lblREMARKS1.Size = new System.Drawing.Size(611, 15);
            this.lblREMARKS1.TabIndex = 468;
            this.lblREMARKS1.Text = "Loan";
            // 
            // lblCONTACTED_BY8
            // 
            this.lblCONTACTED_BY8.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY8.Location = new System.Drawing.Point(310, 227);
            this.lblCONTACTED_BY8.Name = "lblCONTACTED_BY8";
            this.lblCONTACTED_BY8.ReadOnly = true;
            this.lblCONTACTED_BY8.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY8.TabIndex = 467;
            this.lblCONTACTED_BY8.Text = "Loan";
            this.lblCONTACTED_BY8.Visible = false;
            // 
            // lblCONTACTED_BY7
            // 
            this.lblCONTACTED_BY7.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY7.Location = new System.Drawing.Point(310, 204);
            this.lblCONTACTED_BY7.Name = "lblCONTACTED_BY7";
            this.lblCONTACTED_BY7.ReadOnly = true;
            this.lblCONTACTED_BY7.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY7.TabIndex = 466;
            this.lblCONTACTED_BY7.Text = "Loan";
            this.lblCONTACTED_BY7.Visible = false;
            // 
            // lblCONTACTED_BY6
            // 
            this.lblCONTACTED_BY6.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY6.Location = new System.Drawing.Point(310, 181);
            this.lblCONTACTED_BY6.Name = "lblCONTACTED_BY6";
            this.lblCONTACTED_BY6.ReadOnly = true;
            this.lblCONTACTED_BY6.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY6.TabIndex = 465;
            this.lblCONTACTED_BY6.Text = "Loan";
            // 
            // lblCONTACTED_BY5
            // 
            this.lblCONTACTED_BY5.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY5.Location = new System.Drawing.Point(310, 158);
            this.lblCONTACTED_BY5.Name = "lblCONTACTED_BY5";
            this.lblCONTACTED_BY5.ReadOnly = true;
            this.lblCONTACTED_BY5.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY5.TabIndex = 464;
            this.lblCONTACTED_BY5.Text = "Loan";
            // 
            // lblCONTACTED_BY4
            // 
            this.lblCONTACTED_BY4.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY4.Location = new System.Drawing.Point(310, 135);
            this.lblCONTACTED_BY4.Name = "lblCONTACTED_BY4";
            this.lblCONTACTED_BY4.ReadOnly = true;
            this.lblCONTACTED_BY4.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY4.TabIndex = 463;
            this.lblCONTACTED_BY4.Text = "Loan";
            // 
            // lblCONTACTED_BY3
            // 
            this.lblCONTACTED_BY3.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY3.Location = new System.Drawing.Point(310, 112);
            this.lblCONTACTED_BY3.Name = "lblCONTACTED_BY3";
            this.lblCONTACTED_BY3.ReadOnly = true;
            this.lblCONTACTED_BY3.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY3.TabIndex = 462;
            this.lblCONTACTED_BY3.Text = "Loan";
            // 
            // lblCONTACTED_BY2
            // 
            this.lblCONTACTED_BY2.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY2.Location = new System.Drawing.Point(310, 89);
            this.lblCONTACTED_BY2.Name = "lblCONTACTED_BY2";
            this.lblCONTACTED_BY2.ReadOnly = true;
            this.lblCONTACTED_BY2.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY2.TabIndex = 461;
            this.lblCONTACTED_BY2.Text = "Loan";
            // 
            // lblCONTACTED_BY1
            // 
            this.lblCONTACTED_BY1.BackColor = System.Drawing.Color.White;
            this.lblCONTACTED_BY1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACTED_BY1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACTED_BY1.Location = new System.Drawing.Point(310, 66);
            this.lblCONTACTED_BY1.Name = "lblCONTACTED_BY1";
            this.lblCONTACTED_BY1.ReadOnly = true;
            this.lblCONTACTED_BY1.Size = new System.Drawing.Size(123, 15);
            this.lblCONTACTED_BY1.TabIndex = 460;
            this.lblCONTACTED_BY1.Text = "Loan";
            // 
            // lblCONTACT_DATE8
            // 
            this.lblCONTACT_DATE8.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE8.Location = new System.Drawing.Point(19, 228);
            this.lblCONTACT_DATE8.Name = "lblCONTACT_DATE8";
            this.lblCONTACT_DATE8.ReadOnly = true;
            this.lblCONTACT_DATE8.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE8.TabIndex = 459;
            this.lblCONTACT_DATE8.Text = "Loan";
            this.lblCONTACT_DATE8.Visible = false;
            // 
            // lblCONTACT_DATE7
            // 
            this.lblCONTACT_DATE7.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE7.Location = new System.Drawing.Point(19, 204);
            this.lblCONTACT_DATE7.Name = "lblCONTACT_DATE7";
            this.lblCONTACT_DATE7.ReadOnly = true;
            this.lblCONTACT_DATE7.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE7.TabIndex = 458;
            this.lblCONTACT_DATE7.Text = "Loan";
            this.lblCONTACT_DATE7.Visible = false;
            // 
            // lblCONTACT_DATE6
            // 
            this.lblCONTACT_DATE6.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE6.Location = new System.Drawing.Point(19, 186);
            this.lblCONTACT_DATE6.Name = "lblCONTACT_DATE6";
            this.lblCONTACT_DATE6.ReadOnly = true;
            this.lblCONTACT_DATE6.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE6.TabIndex = 457;
            this.lblCONTACT_DATE6.Text = "Loan";
            // 
            // lblCONTACT_DATE5
            // 
            this.lblCONTACT_DATE5.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE5.Location = new System.Drawing.Point(19, 162);
            this.lblCONTACT_DATE5.Name = "lblCONTACT_DATE5";
            this.lblCONTACT_DATE5.ReadOnly = true;
            this.lblCONTACT_DATE5.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE5.TabIndex = 456;
            this.lblCONTACT_DATE5.Text = "Loan";
            // 
            // lblCONTACT_DATE4
            // 
            this.lblCONTACT_DATE4.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE4.Location = new System.Drawing.Point(19, 138);
            this.lblCONTACT_DATE4.Name = "lblCONTACT_DATE4";
            this.lblCONTACT_DATE4.ReadOnly = true;
            this.lblCONTACT_DATE4.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE4.TabIndex = 455;
            this.lblCONTACT_DATE4.Text = "Loan";
            // 
            // lblCONTACT_DATE3
            // 
            this.lblCONTACT_DATE3.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE3.Location = new System.Drawing.Point(19, 114);
            this.lblCONTACT_DATE3.Name = "lblCONTACT_DATE3";
            this.lblCONTACT_DATE3.ReadOnly = true;
            this.lblCONTACT_DATE3.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE3.TabIndex = 454;
            this.lblCONTACT_DATE3.Text = "Loan";
            // 
            // lblCONTACT_DATE2
            // 
            this.lblCONTACT_DATE2.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE2.Location = new System.Drawing.Point(19, 90);
            this.lblCONTACT_DATE2.Name = "lblCONTACT_DATE2";
            this.lblCONTACT_DATE2.ReadOnly = true;
            this.lblCONTACT_DATE2.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE2.TabIndex = 453;
            this.lblCONTACT_DATE2.Text = "Loan";
            // 
            // lblCONTACT_DATE1
            // 
            this.lblCONTACT_DATE1.BackColor = System.Drawing.Color.White;
            this.lblCONTACT_DATE1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT_DATE1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT_DATE1.Location = new System.Drawing.Point(19, 66);
            this.lblCONTACT_DATE1.Name = "lblCONTACT_DATE1";
            this.lblCONTACT_DATE1.ReadOnly = true;
            this.lblCONTACT_DATE1.Size = new System.Drawing.Size(142, 15);
            this.lblCONTACT_DATE1.TabIndex = 452;
            this.lblCONTACT_DATE1.Text = "Loan";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(160, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(153, 15);
            this.textBox2.TabIndex = 451;
            this.textBox2.Text = "Loan";
            this.textBox2.Visible = false;
            // 
            // lblACTION_CODE7
            // 
            this.lblACTION_CODE7.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE7.Location = new System.Drawing.Point(160, 203);
            this.lblACTION_CODE7.Name = "lblACTION_CODE7";
            this.lblACTION_CODE7.ReadOnly = true;
            this.lblACTION_CODE7.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE7.TabIndex = 450;
            this.lblACTION_CODE7.Text = "Loan";
            this.lblACTION_CODE7.Visible = false;
            // 
            // lblACTION_CODE6
            // 
            this.lblACTION_CODE6.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE6.Location = new System.Drawing.Point(160, 185);
            this.lblACTION_CODE6.Name = "lblACTION_CODE6";
            this.lblACTION_CODE6.ReadOnly = true;
            this.lblACTION_CODE6.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE6.TabIndex = 449;
            this.lblACTION_CODE6.Text = "Loan";
            // 
            // lblACTION_CODE5
            // 
            this.lblACTION_CODE5.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE5.Location = new System.Drawing.Point(160, 161);
            this.lblACTION_CODE5.Name = "lblACTION_CODE5";
            this.lblACTION_CODE5.ReadOnly = true;
            this.lblACTION_CODE5.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE5.TabIndex = 448;
            this.lblACTION_CODE5.Text = "Loan";
            // 
            // lblACTION_CODE4
            // 
            this.lblACTION_CODE4.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE4.Location = new System.Drawing.Point(160, 137);
            this.lblACTION_CODE4.Name = "lblACTION_CODE4";
            this.lblACTION_CODE4.ReadOnly = true;
            this.lblACTION_CODE4.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE4.TabIndex = 447;
            this.lblACTION_CODE4.Text = "Loan";
            // 
            // lblACTION_CODE3
            // 
            this.lblACTION_CODE3.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE3.Location = new System.Drawing.Point(160, 113);
            this.lblACTION_CODE3.Name = "lblACTION_CODE3";
            this.lblACTION_CODE3.ReadOnly = true;
            this.lblACTION_CODE3.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE3.TabIndex = 446;
            this.lblACTION_CODE3.Text = "Loan";
            // 
            // lblACTION_CODE2
            // 
            this.lblACTION_CODE2.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE2.Location = new System.Drawing.Point(160, 89);
            this.lblACTION_CODE2.Name = "lblACTION_CODE2";
            this.lblACTION_CODE2.ReadOnly = true;
            this.lblACTION_CODE2.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE2.TabIndex = 445;
            this.lblACTION_CODE2.Text = "Loan";
            // 
            // lblACTION_CODE1
            // 
            this.lblACTION_CODE1.BackColor = System.Drawing.Color.White;
            this.lblACTION_CODE1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblACTION_CODE1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACTION_CODE1.Location = new System.Drawing.Point(160, 65);
            this.lblACTION_CODE1.Name = "lblACTION_CODE1";
            this.lblACTION_CODE1.ReadOnly = true;
            this.lblACTION_CODE1.Size = new System.Drawing.Size(153, 15);
            this.lblACTION_CODE1.TabIndex = 444;
            this.lblACTION_CODE1.Text = "Loan";
            // 
            // label175
            // 
            this.label175.BackColor = System.Drawing.Color.Yellow;
            this.label175.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label175.Location = new System.Drawing.Point(1065, 33);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(153, 23);
            this.label175.TabIndex = 394;
            this.label175.Text = "Person Contacted";
            this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label167
            // 
            this.label167.BackColor = System.Drawing.Color.Yellow;
            this.label167.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label167.Location = new System.Drawing.Point(1240, 33);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(159, 23);
            this.label167.TabIndex = 393;
            this.label167.Text = "Contact Place";
            this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label152
            // 
            this.label152.BackColor = System.Drawing.Color.Yellow;
            this.label152.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.Location = new System.Drawing.Point(432, 33);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(611, 23);
            this.label152.TabIndex = 392;
            this.label152.Text = "Remarks";
            this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label153
            // 
            this.label153.BackColor = System.Drawing.Color.Yellow;
            this.label153.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.Location = new System.Drawing.Point(301, 33);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(131, 23);
            this.label153.TabIndex = 391;
            this.label153.Text = "Contacted By";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label154
            // 
            this.label154.BackColor = System.Drawing.Color.Yellow;
            this.label154.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.Location = new System.Drawing.Point(154, 33);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(153, 23);
            this.label154.TabIndex = 390;
            this.label154.Text = "Disposition Code";
            this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label155
            // 
            this.label155.BackColor = System.Drawing.Color.Yellow;
            this.label155.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.Location = new System.Drawing.Point(13, 33);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(142, 23);
            this.label155.TabIndex = 389;
            this.label155.Text = "Contact Date";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BackColor = System.Drawing.Color.SandyBrown;
            this.label158.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(14, 11);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(71, 15);
            this.label158.TabIndex = 344;
            this.label158.Text = "Last Activity";
            // 
            // label159
            // 
            this.label159.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label159.BackColor = System.Drawing.Color.Yellow;
            this.label159.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.Location = new System.Drawing.Point(215, 6);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(13676, 25);
            this.label159.TabIndex = 343;
            this.label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label160
            // 
            this.label160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label160.BackColor = System.Drawing.Color.SandyBrown;
            this.label160.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label160.Location = new System.Drawing.Point(11, 6);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(2293, 25);
            this.label160.TabIndex = 345;
            this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label161
            // 
            this.label161.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label161.BackColor = System.Drawing.Color.Yellow;
            this.label161.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label161.Location = new System.Drawing.Point(799, 33);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(14140, 25);
            this.label161.TabIndex = 395;
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.groupBox9);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 458);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1242, 225);
            this.panel15.TabIndex = 411;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblAgent6_c);
            this.groupBox9.Controls.Add(this.lblAgent5_c);
            this.groupBox9.Controls.Add(this.lblAgent4_c);
            this.groupBox9.Controls.Add(this.lblAgent3_c);
            this.groupBox9.Controls.Add(this.lblAgent2_c);
            this.groupBox9.Controls.Add(this.lblAgent1_c);
            this.groupBox9.Controls.Add(this.lblDisp6_Id);
            this.groupBox9.Controls.Add(this.lblDisp5_Id);
            this.groupBox9.Controls.Add(this.lblDisp4_Id);
            this.groupBox9.Controls.Add(this.lblDisp3_Id);
            this.groupBox9.Controls.Add(this.lblDisp2_Id);
            this.groupBox9.Controls.Add(this.lblDisp1_Id);
            this.groupBox9.Controls.Add(this.lblCall6_dt);
            this.groupBox9.Controls.Add(this.lblCall5_dt);
            this.groupBox9.Controls.Add(this.lblCall4_dt);
            this.groupBox9.Controls.Add(this.lblCall3_dt);
            this.groupBox9.Controls.Add(this.lblCall2_dt);
            this.groupBox9.Controls.Add(this.lblCall1_dt);
            this.groupBox9.Controls.Add(this.lblCall6_Phone);
            this.groupBox9.Controls.Add(this.lblCall5_Phone);
            this.groupBox9.Controls.Add(this.lblCall4_Phone);
            this.groupBox9.Controls.Add(this.lblCall3_Phone);
            this.groupBox9.Controls.Add(this.lblCall2_Phone);
            this.groupBox9.Controls.Add(this.lblCall1_Phone);
            this.groupBox9.Controls.Add(this.label103);
            this.groupBox9.Controls.Add(this.label108);
            this.groupBox9.Controls.Add(this.label99);
            this.groupBox9.Controls.Add(this.label102);
            this.groupBox9.Controls.Add(this.label68);
            this.groupBox9.Controls.Add(this.label69);
            this.groupBox9.Controls.Add(this.label70);
            this.groupBox9.Controls.Add(this.label38);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1242, 225);
            this.groupBox9.TabIndex = 359;
            this.groupBox9.TabStop = false;
            // 
            // lblAgent6_c
            // 
            this.lblAgent6_c.BackColor = System.Drawing.Color.White;
            this.lblAgent6_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent6_c.Location = new System.Drawing.Point(685, 196);
            this.lblAgent6_c.Name = "lblAgent6_c";
            this.lblAgent6_c.ReadOnly = true;
            this.lblAgent6_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent6_c.TabIndex = 404;
            this.lblAgent6_c.Text = "Loan";
            // 
            // lblAgent5_c
            // 
            this.lblAgent5_c.BackColor = System.Drawing.Color.White;
            this.lblAgent5_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent5_c.Location = new System.Drawing.Point(685, 172);
            this.lblAgent5_c.Name = "lblAgent5_c";
            this.lblAgent5_c.ReadOnly = true;
            this.lblAgent5_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent5_c.TabIndex = 403;
            this.lblAgent5_c.Text = "Loan";
            // 
            // lblAgent4_c
            // 
            this.lblAgent4_c.BackColor = System.Drawing.Color.White;
            this.lblAgent4_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent4_c.Location = new System.Drawing.Point(685, 148);
            this.lblAgent4_c.Name = "lblAgent4_c";
            this.lblAgent4_c.ReadOnly = true;
            this.lblAgent4_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent4_c.TabIndex = 402;
            this.lblAgent4_c.Text = "Loan";
            // 
            // lblAgent3_c
            // 
            this.lblAgent3_c.BackColor = System.Drawing.Color.White;
            this.lblAgent3_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent3_c.Location = new System.Drawing.Point(685, 124);
            this.lblAgent3_c.Name = "lblAgent3_c";
            this.lblAgent3_c.ReadOnly = true;
            this.lblAgent3_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent3_c.TabIndex = 401;
            this.lblAgent3_c.Text = "Loan";
            // 
            // lblAgent2_c
            // 
            this.lblAgent2_c.BackColor = System.Drawing.Color.White;
            this.lblAgent2_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent2_c.Location = new System.Drawing.Point(685, 100);
            this.lblAgent2_c.Name = "lblAgent2_c";
            this.lblAgent2_c.ReadOnly = true;
            this.lblAgent2_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent2_c.TabIndex = 400;
            this.lblAgent2_c.Text = "Loan";
            // 
            // lblAgent1_c
            // 
            this.lblAgent1_c.BackColor = System.Drawing.Color.White;
            this.lblAgent1_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAgent1_c.Location = new System.Drawing.Point(685, 76);
            this.lblAgent1_c.Name = "lblAgent1_c";
            this.lblAgent1_c.ReadOnly = true;
            this.lblAgent1_c.Size = new System.Drawing.Size(486, 16);
            this.lblAgent1_c.TabIndex = 399;
            this.lblAgent1_c.Text = "Loan";
            // 
            // lblDisp6_Id
            // 
            this.lblDisp6_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp6_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp6_Id.Location = new System.Drawing.Point(481, 196);
            this.lblDisp6_Id.Name = "lblDisp6_Id";
            this.lblDisp6_Id.ReadOnly = true;
            this.lblDisp6_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp6_Id.TabIndex = 398;
            this.lblDisp6_Id.Text = "Loan";
            // 
            // lblDisp5_Id
            // 
            this.lblDisp5_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp5_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp5_Id.Location = new System.Drawing.Point(481, 172);
            this.lblDisp5_Id.Name = "lblDisp5_Id";
            this.lblDisp5_Id.ReadOnly = true;
            this.lblDisp5_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp5_Id.TabIndex = 397;
            this.lblDisp5_Id.Text = "Loan";
            // 
            // lblDisp4_Id
            // 
            this.lblDisp4_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp4_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp4_Id.Location = new System.Drawing.Point(481, 148);
            this.lblDisp4_Id.Name = "lblDisp4_Id";
            this.lblDisp4_Id.ReadOnly = true;
            this.lblDisp4_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp4_Id.TabIndex = 396;
            this.lblDisp4_Id.Text = "Loan";
            // 
            // lblDisp3_Id
            // 
            this.lblDisp3_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp3_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp3_Id.Location = new System.Drawing.Point(481, 124);
            this.lblDisp3_Id.Name = "lblDisp3_Id";
            this.lblDisp3_Id.ReadOnly = true;
            this.lblDisp3_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp3_Id.TabIndex = 395;
            this.lblDisp3_Id.Text = "Loan";
            // 
            // lblDisp2_Id
            // 
            this.lblDisp2_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp2_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp2_Id.Location = new System.Drawing.Point(481, 100);
            this.lblDisp2_Id.Name = "lblDisp2_Id";
            this.lblDisp2_Id.ReadOnly = true;
            this.lblDisp2_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp2_Id.TabIndex = 394;
            this.lblDisp2_Id.Text = "Loan";
            // 
            // lblDisp1_Id
            // 
            this.lblDisp1_Id.BackColor = System.Drawing.Color.White;
            this.lblDisp1_Id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisp1_Id.Location = new System.Drawing.Point(481, 76);
            this.lblDisp1_Id.Name = "lblDisp1_Id";
            this.lblDisp1_Id.ReadOnly = true;
            this.lblDisp1_Id.Size = new System.Drawing.Size(198, 16);
            this.lblDisp1_Id.TabIndex = 393;
            this.lblDisp1_Id.Text = "Loan";
            // 
            // lblCall6_dt
            // 
            this.lblCall6_dt.BackColor = System.Drawing.Color.White;
            this.lblCall6_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall6_dt.Location = new System.Drawing.Point(212, 196);
            this.lblCall6_dt.Name = "lblCall6_dt";
            this.lblCall6_dt.ReadOnly = true;
            this.lblCall6_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall6_dt.TabIndex = 392;
            this.lblCall6_dt.Text = "Loan";
            // 
            // lblCall5_dt
            // 
            this.lblCall5_dt.BackColor = System.Drawing.Color.White;
            this.lblCall5_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall5_dt.Location = new System.Drawing.Point(212, 172);
            this.lblCall5_dt.Name = "lblCall5_dt";
            this.lblCall5_dt.ReadOnly = true;
            this.lblCall5_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall5_dt.TabIndex = 391;
            this.lblCall5_dt.Text = "Loan";
            // 
            // lblCall4_dt
            // 
            this.lblCall4_dt.BackColor = System.Drawing.Color.White;
            this.lblCall4_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall4_dt.Location = new System.Drawing.Point(212, 148);
            this.lblCall4_dt.Name = "lblCall4_dt";
            this.lblCall4_dt.ReadOnly = true;
            this.lblCall4_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall4_dt.TabIndex = 390;
            this.lblCall4_dt.Text = "Loan";
            // 
            // lblCall3_dt
            // 
            this.lblCall3_dt.BackColor = System.Drawing.Color.White;
            this.lblCall3_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall3_dt.Location = new System.Drawing.Point(212, 124);
            this.lblCall3_dt.Name = "lblCall3_dt";
            this.lblCall3_dt.ReadOnly = true;
            this.lblCall3_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall3_dt.TabIndex = 389;
            this.lblCall3_dt.Text = "Loan";
            // 
            // lblCall2_dt
            // 
            this.lblCall2_dt.BackColor = System.Drawing.Color.White;
            this.lblCall2_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall2_dt.Location = new System.Drawing.Point(212, 100);
            this.lblCall2_dt.Name = "lblCall2_dt";
            this.lblCall2_dt.ReadOnly = true;
            this.lblCall2_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall2_dt.TabIndex = 388;
            this.lblCall2_dt.Text = "Loan";
            // 
            // lblCall1_dt
            // 
            this.lblCall1_dt.BackColor = System.Drawing.Color.White;
            this.lblCall1_dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall1_dt.Location = new System.Drawing.Point(212, 76);
            this.lblCall1_dt.Name = "lblCall1_dt";
            this.lblCall1_dt.ReadOnly = true;
            this.lblCall1_dt.Size = new System.Drawing.Size(268, 16);
            this.lblCall1_dt.TabIndex = 387;
            this.lblCall1_dt.Text = "Loan";
            // 
            // lblCall6_Phone
            // 
            this.lblCall6_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall6_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall6_Phone.Location = new System.Drawing.Point(17, 196);
            this.lblCall6_Phone.Name = "lblCall6_Phone";
            this.lblCall6_Phone.ReadOnly = true;
            this.lblCall6_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall6_Phone.TabIndex = 386;
            this.lblCall6_Phone.Text = "Loan";
            // 
            // lblCall5_Phone
            // 
            this.lblCall5_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall5_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall5_Phone.Location = new System.Drawing.Point(17, 172);
            this.lblCall5_Phone.Name = "lblCall5_Phone";
            this.lblCall5_Phone.ReadOnly = true;
            this.lblCall5_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall5_Phone.TabIndex = 385;
            this.lblCall5_Phone.Text = "Loan";
            // 
            // lblCall4_Phone
            // 
            this.lblCall4_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall4_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall4_Phone.Location = new System.Drawing.Point(17, 148);
            this.lblCall4_Phone.Name = "lblCall4_Phone";
            this.lblCall4_Phone.ReadOnly = true;
            this.lblCall4_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall4_Phone.TabIndex = 384;
            this.lblCall4_Phone.Text = "Loan";
            // 
            // lblCall3_Phone
            // 
            this.lblCall3_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall3_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall3_Phone.Location = new System.Drawing.Point(17, 124);
            this.lblCall3_Phone.Name = "lblCall3_Phone";
            this.lblCall3_Phone.ReadOnly = true;
            this.lblCall3_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall3_Phone.TabIndex = 383;
            this.lblCall3_Phone.Text = "Loan";
            // 
            // lblCall2_Phone
            // 
            this.lblCall2_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall2_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall2_Phone.Location = new System.Drawing.Point(17, 100);
            this.lblCall2_Phone.Name = "lblCall2_Phone";
            this.lblCall2_Phone.ReadOnly = true;
            this.lblCall2_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall2_Phone.TabIndex = 382;
            this.lblCall2_Phone.Text = "Loan";
            // 
            // lblCall1_Phone
            // 
            this.lblCall1_Phone.BackColor = System.Drawing.Color.White;
            this.lblCall1_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCall1_Phone.Location = new System.Drawing.Point(17, 76);
            this.lblCall1_Phone.Name = "lblCall1_Phone";
            this.lblCall1_Phone.ReadOnly = true;
            this.lblCall1_Phone.Size = new System.Drawing.Size(198, 16);
            this.lblCall1_Phone.TabIndex = 381;
            this.lblCall1_Phone.Text = "Loan";
            // 
            // label103
            // 
            this.label103.BackColor = System.Drawing.Color.Yellow;
            this.label103.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.Location = new System.Drawing.Point(685, 44);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(486, 23);
            this.label103.TabIndex = 350;
            this.label103.Text = "Agent";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label108
            // 
            this.label108.BackColor = System.Drawing.Color.Yellow;
            this.label108.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.Location = new System.Drawing.Point(481, 44);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(198, 23);
            this.label108.TabIndex = 348;
            this.label108.Text = "Display";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label99
            // 
            this.label99.BackColor = System.Drawing.Color.Yellow;
            this.label99.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.Location = new System.Drawing.Point(212, 44);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(268, 23);
            this.label99.TabIndex = 346;
            this.label99.Text = "Date";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.Yellow;
            this.label102.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.Location = new System.Drawing.Point(10, 44);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(198, 23);
            this.label102.TabIndex = 344;
            this.label102.Text = "Phone";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.SandyBrown;
            this.label68.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(6, 20);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(82, 15);
            this.label68.TabIndex = 341;
            this.label68.Text = "Today Activity";
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label69.BackColor = System.Drawing.Color.Yellow;
            this.label69.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(191, 15);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(1065, 25);
            this.label69.TabIndex = 340;
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label70.BackColor = System.Drawing.Color.SandyBrown;
            this.label70.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(6, 15);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(378, 25);
            this.label70.TabIndex = 342;
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.BackColor = System.Drawing.Color.Yellow;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(10, 43);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(1213, 25);
            this.label38.TabIndex = 351;
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.groupBox8);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 354);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1242, 104);
            this.panel14.TabIndex = 410;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblAO_additional2);
            this.groupBox8.Controls.Add(this.lblAO_additional1);
            this.groupBox8.Controls.Add(this.lblPrincipal_additional2);
            this.groupBox8.Controls.Add(this.lblPrincipal_additional1);
            this.groupBox8.Controls.Add(this.lblDPD_additional2);
            this.groupBox8.Controls.Add(this.lblDPD_additional1);
            this.groupBox8.Controls.Add(this.lblLoad_additional2);
            this.groupBox8.Controls.Add(this.lblLoad_additional1);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this.label98);
            this.groupBox8.Controls.Add(this.label97);
            this.groupBox8.Controls.Add(this.label96);
            this.groupBox8.Controls.Add(this.label95);
            this.groupBox8.Controls.Add(this.label65);
            this.groupBox8.Controls.Add(this.label66);
            this.groupBox8.Controls.Add(this.label67);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(0, 0);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1242, 104);
            this.groupBox8.TabIndex = 358;
            this.groupBox8.TabStop = false;
            // 
            // lblAO_additional2
            // 
            this.lblAO_additional2.BackColor = System.Drawing.Color.White;
            this.lblAO_additional2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAO_additional2.Location = new System.Drawing.Point(564, 73);
            this.lblAO_additional2.Name = "lblAO_additional2";
            this.lblAO_additional2.ReadOnly = true;
            this.lblAO_additional2.Size = new System.Drawing.Size(224, 16);
            this.lblAO_additional2.TabIndex = 366;
            this.lblAO_additional2.Text = "Loan";
            // 
            // lblAO_additional1
            // 
            this.lblAO_additional1.BackColor = System.Drawing.Color.White;
            this.lblAO_additional1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAO_additional1.Location = new System.Drawing.Point(564, 51);
            this.lblAO_additional1.Name = "lblAO_additional1";
            this.lblAO_additional1.ReadOnly = true;
            this.lblAO_additional1.Size = new System.Drawing.Size(224, 16);
            this.lblAO_additional1.TabIndex = 365;
            this.lblAO_additional1.Text = "Loan";
            // 
            // lblPrincipal_additional2
            // 
            this.lblPrincipal_additional2.BackColor = System.Drawing.Color.White;
            this.lblPrincipal_additional2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrincipal_additional2.Location = new System.Drawing.Point(788, 73);
            this.lblPrincipal_additional2.Name = "lblPrincipal_additional2";
            this.lblPrincipal_additional2.ReadOnly = true;
            this.lblPrincipal_additional2.Size = new System.Drawing.Size(300, 16);
            this.lblPrincipal_additional2.TabIndex = 364;
            this.lblPrincipal_additional2.Text = "Loan";
            // 
            // lblPrincipal_additional1
            // 
            this.lblPrincipal_additional1.BackColor = System.Drawing.Color.White;
            this.lblPrincipal_additional1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPrincipal_additional1.Location = new System.Drawing.Point(788, 51);
            this.lblPrincipal_additional1.Name = "lblPrincipal_additional1";
            this.lblPrincipal_additional1.ReadOnly = true;
            this.lblPrincipal_additional1.Size = new System.Drawing.Size(300, 16);
            this.lblPrincipal_additional1.TabIndex = 363;
            this.lblPrincipal_additional1.Text = "Loan";
            // 
            // lblDPD_additional2
            // 
            this.lblDPD_additional2.BackColor = System.Drawing.Color.White;
            this.lblDPD_additional2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDPD_additional2.Location = new System.Drawing.Point(412, 73);
            this.lblDPD_additional2.Name = "lblDPD_additional2";
            this.lblDPD_additional2.ReadOnly = true;
            this.lblDPD_additional2.Size = new System.Drawing.Size(153, 16);
            this.lblDPD_additional2.TabIndex = 362;
            this.lblDPD_additional2.Text = "Loan";
            // 
            // lblDPD_additional1
            // 
            this.lblDPD_additional1.BackColor = System.Drawing.Color.White;
            this.lblDPD_additional1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDPD_additional1.Location = new System.Drawing.Point(412, 51);
            this.lblDPD_additional1.Name = "lblDPD_additional1";
            this.lblDPD_additional1.ReadOnly = true;
            this.lblDPD_additional1.Size = new System.Drawing.Size(153, 16);
            this.lblDPD_additional1.TabIndex = 361;
            this.lblDPD_additional1.Text = "Loan";
            // 
            // lblLoad_additional2
            // 
            this.lblLoad_additional2.BackColor = System.Drawing.Color.White;
            this.lblLoad_additional2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoad_additional2.Location = new System.Drawing.Point(210, 75);
            this.lblLoad_additional2.Name = "lblLoad_additional2";
            this.lblLoad_additional2.ReadOnly = true;
            this.lblLoad_additional2.Size = new System.Drawing.Size(199, 16);
            this.lblLoad_additional2.TabIndex = 360;
            this.lblLoad_additional2.Text = "Loan";
            // 
            // lblLoad_additional1
            // 
            this.lblLoad_additional1.BackColor = System.Drawing.Color.White;
            this.lblLoad_additional1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoad_additional1.Location = new System.Drawing.Point(210, 51);
            this.lblLoad_additional1.Name = "lblLoad_additional1";
            this.lblLoad_additional1.ReadOnly = true;
            this.lblLoad_additional1.Size = new System.Drawing.Size(199, 16);
            this.lblLoad_additional1.TabIndex = 359;
            this.lblLoad_additional1.Text = "Loan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 358;
            this.label2.Text = "#2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(176, 51);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 15);
            this.label32.TabIndex = 357;
            this.label32.Text = "#1";
            // 
            // label98
            // 
            this.label98.BackColor = System.Drawing.Color.Yellow;
            this.label98.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.Location = new System.Drawing.Point(788, 16);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(178, 23);
            this.label98.TabIndex = 346;
            this.label98.Text = "Principle Overdue";
            this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label97
            // 
            this.label97.BackColor = System.Drawing.Color.Yellow;
            this.label97.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label97.Location = new System.Drawing.Point(564, 16);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(224, 23);
            this.label97.TabIndex = 345;
            this.label97.Text = "Amount Overdue";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label96
            // 
            this.label96.BackColor = System.Drawing.Color.Yellow;
            this.label96.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.Location = new System.Drawing.Point(412, 16);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(153, 23);
            this.label96.TabIndex = 344;
            this.label96.Text = "DPD";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label95
            // 
            this.label95.BackColor = System.Drawing.Color.Yellow;
            this.label95.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label95.Location = new System.Drawing.Point(197, 16);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(215, 23);
            this.label95.TabIndex = 343;
            this.label95.Text = "Loan Number";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.SandyBrown;
            this.label65.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(6, 20);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(66, 15);
            this.label65.TabIndex = 341;
            this.label65.Text = "Other Loan";
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label66.BackColor = System.Drawing.Color.Yellow;
            this.label66.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(210, 15);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(1041, 25);
            this.label66.TabIndex = 340;
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.BackColor = System.Drawing.Color.SandyBrown;
            this.label67.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(6, 15);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(302, 25);
            this.label67.TabIndex = 342;
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.groupBox1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 228);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1242, 126);
            this.panel13.TabIndex = 409;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOrg);
            this.groupBox1.Controls.Add(this.lblzipcode);
            this.groupBox1.Controls.Add(this.lblPurpose);
            this.groupBox1.Controls.Add(this.lblSpecialStage);
            this.groupBox1.Controls.Add(this.lblCustId);
            this.groupBox1.Controls.Add(this.label214);
            this.groupBox1.Controls.Add(this.label84);
            this.groupBox1.Controls.Add(this.label187);
            this.groupBox1.Controls.Add(this.label230);
            this.groupBox1.Controls.Add(this.label231);
            this.groupBox1.Controls.Add(this.label232);
            this.groupBox1.Controls.Add(this.label238);
            this.groupBox1.Controls.Add(this.label242);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 126);
            this.groupBox1.TabIndex = 362;
            this.groupBox1.TabStop = false;
            // 
            // lblOrg
            // 
            this.lblOrg.BackColor = System.Drawing.Color.White;
            this.lblOrg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblOrg.Location = new System.Drawing.Point(622, 68);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.ReadOnly = true;
            this.lblOrg.Size = new System.Drawing.Size(370, 16);
            this.lblOrg.TabIndex = 317;
            this.lblOrg.Text = "Loan";
            // 
            // lblzipcode
            // 
            this.lblzipcode.BackColor = System.Drawing.Color.White;
            this.lblzipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblzipcode.Location = new System.Drawing.Point(622, 46);
            this.lblzipcode.Name = "lblzipcode";
            this.lblzipcode.ReadOnly = true;
            this.lblzipcode.Size = new System.Drawing.Size(370, 16);
            this.lblzipcode.TabIndex = 316;
            this.lblzipcode.Text = "Loan";
            // 
            // lblPurpose
            // 
            this.lblPurpose.BackColor = System.Drawing.Color.White;
            this.lblPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPurpose.Location = new System.Drawing.Point(132, 90);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.ReadOnly = true;
            this.lblPurpose.Size = new System.Drawing.Size(370, 16);
            this.lblPurpose.TabIndex = 315;
            this.lblPurpose.Text = "Loan";
            // 
            // lblSpecialStage
            // 
            this.lblSpecialStage.BackColor = System.Drawing.Color.White;
            this.lblSpecialStage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSpecialStage.Location = new System.Drawing.Point(132, 68);
            this.lblSpecialStage.Name = "lblSpecialStage";
            this.lblSpecialStage.ReadOnly = true;
            this.lblSpecialStage.Size = new System.Drawing.Size(370, 16);
            this.lblSpecialStage.TabIndex = 314;
            this.lblSpecialStage.Text = "Loan";
            // 
            // lblCustId
            // 
            this.lblCustId.BackColor = System.Drawing.Color.White;
            this.lblCustId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustId.Location = new System.Drawing.Point(132, 46);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.ReadOnly = true;
            this.lblCustId.Size = new System.Drawing.Size(370, 16);
            this.lblCustId.TabIndex = 313;
            this.lblCustId.Text = "Loan";
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label214.Location = new System.Drawing.Point(8, 90);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(83, 15);
            this.label214.TabIndex = 306;
            this.label214.Text = "Purpose / LOB";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(519, 68);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(75, 15);
            this.label84.TabIndex = 303;
            this.label84.Text = "Organization";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label187.Location = new System.Drawing.Point(8, 68);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(107, 15);
            this.label187.TabIndex = 302;
            this.label187.Text = "Special Stage Code";
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.BackColor = System.Drawing.Color.SandyBrown;
            this.label230.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label230.Location = new System.Drawing.Point(4, 18);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(103, 15);
            this.label230.TabIndex = 289;
            this.label230.Text = "Other Information";
            // 
            // label231
            // 
            this.label231.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label231.BackColor = System.Drawing.Color.Yellow;
            this.label231.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label231.Location = new System.Drawing.Point(194, 13);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(1062, 25);
            this.label231.TabIndex = 288;
            this.label231.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label232
            // 
            this.label232.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label232.BackColor = System.Drawing.Color.SandyBrown;
            this.label232.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label232.Location = new System.Drawing.Point(4, 13);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(302, 25);
            this.label232.TabIndex = 291;
            this.label232.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label238.Location = new System.Drawing.Point(519, 46);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(55, 15);
            this.label238.TabIndex = 278;
            this.label238.Text = "Zip Code";
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label242.Location = new System.Drawing.Point(8, 46);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(45, 15);
            this.label242.TabIndex = 274;
            this.label242.Text = "Cust ID";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.groupBox6);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1242, 228);
            this.panel12.TabIndex = 408;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblLoan6);
            this.groupBox6.Controls.Add(this.lblPother2);
            this.groupBox6.Controls.Add(this.lblPoffice2);
            this.groupBox6.Controls.Add(this.lblPhome2);
            this.groupBox6.Controls.Add(this.lblRegion2);
            this.groupBox6.Controls.Add(this.lblGender2);
            this.groupBox6.Controls.Add(this.lblProduct2);
            this.groupBox6.Controls.Add(this.lblDOB2);
            this.groupBox6.Controls.Add(this.lblCustomerName3);
            this.groupBox6.Controls.Add(this.lblDnis);
            this.groupBox6.Controls.Add(this.lblServiceName3);
            this.groupBox6.Controls.Add(this.label72);
            this.groupBox6.Controls.Add(this.label73);
            this.groupBox6.Controls.Add(this.label74);
            this.groupBox6.Controls.Add(this.label128);
            this.groupBox6.Controls.Add(this.label129);
            this.groupBox6.Controls.Add(this.label130);
            this.groupBox6.Controls.Add(this.label131);
            this.groupBox6.Controls.Add(this.label132);
            this.groupBox6.Controls.Add(this.label133);
            this.groupBox6.Controls.Add(this.label134);
            this.groupBox6.Controls.Add(this.label135);
            this.groupBox6.Controls.Add(this.label136);
            this.groupBox6.Controls.Add(this.label137);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1242, 225);
            this.groupBox6.TabIndex = 192;
            this.groupBox6.TabStop = false;
            // 
            // lblLoan6
            // 
            this.lblLoan6.BackColor = System.Drawing.Color.White;
            this.lblLoan6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan6.Location = new System.Drawing.Point(110, 70);
            this.lblLoan6.Name = "lblLoan6";
            this.lblLoan6.ReadOnly = true;
            this.lblLoan6.Size = new System.Drawing.Size(350, 16);
            this.lblLoan6.TabIndex = 319;
            this.lblLoan6.Text = "Loan";
            // 
            // lblPother2
            // 
            this.lblPother2.BackColor = System.Drawing.Color.White;
            this.lblPother2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPother2.Location = new System.Drawing.Point(917, 156);
            this.lblPother2.Multiline = true;
            this.lblPother2.Name = "lblPother2";
            this.lblPother2.ReadOnly = true;
            this.lblPother2.Size = new System.Drawing.Size(244, 55);
            this.lblPother2.TabIndex = 318;
            this.lblPother2.Text = "Loan";
            // 
            // lblPoffice2
            // 
            this.lblPoffice2.BackColor = System.Drawing.Color.White;
            this.lblPoffice2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPoffice2.Location = new System.Drawing.Point(917, 101);
            this.lblPoffice2.Multiline = true;
            this.lblPoffice2.Name = "lblPoffice2";
            this.lblPoffice2.ReadOnly = true;
            this.lblPoffice2.Size = new System.Drawing.Size(244, 55);
            this.lblPoffice2.TabIndex = 317;
            this.lblPoffice2.Text = "Loan";
            // 
            // lblPhome2
            // 
            this.lblPhome2.BackColor = System.Drawing.Color.White;
            this.lblPhome2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPhome2.Location = new System.Drawing.Point(917, 46);
            this.lblPhome2.Multiline = true;
            this.lblPhome2.Name = "lblPhome2";
            this.lblPhome2.ReadOnly = true;
            this.lblPhome2.Size = new System.Drawing.Size(244, 55);
            this.lblPhome2.TabIndex = 316;
            this.lblPhome2.Text = "Loan";
            // 
            // lblRegion2
            // 
            this.lblRegion2.BackColor = System.Drawing.Color.White;
            this.lblRegion2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRegion2.Location = new System.Drawing.Point(582, 164);
            this.lblRegion2.Name = "lblRegion2";
            this.lblRegion2.ReadOnly = true;
            this.lblRegion2.Size = new System.Drawing.Size(250, 16);
            this.lblRegion2.TabIndex = 315;
            this.lblRegion2.Text = "Loan";
            // 
            // lblGender2
            // 
            this.lblGender2.BackColor = System.Drawing.Color.White;
            this.lblGender2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGender2.Location = new System.Drawing.Point(582, 109);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.ReadOnly = true;
            this.lblGender2.Size = new System.Drawing.Size(250, 16);
            this.lblGender2.TabIndex = 314;
            this.lblGender2.Text = "Loan";
            // 
            // lblProduct2
            // 
            this.lblProduct2.BackColor = System.Drawing.Color.White;
            this.lblProduct2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProduct2.Location = new System.Drawing.Point(582, 46);
            this.lblProduct2.Multiline = true;
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.ReadOnly = true;
            this.lblProduct2.Size = new System.Drawing.Size(244, 39);
            this.lblProduct2.TabIndex = 313;
            this.lblProduct2.Text = "Loan";
            // 
            // lblDOB2
            // 
            this.lblDOB2.BackColor = System.Drawing.Color.White;
            this.lblDOB2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDOB2.Location = new System.Drawing.Point(110, 164);
            this.lblDOB2.Name = "lblDOB2";
            this.lblDOB2.ReadOnly = true;
            this.lblDOB2.Size = new System.Drawing.Size(350, 16);
            this.lblDOB2.TabIndex = 312;
            this.lblDOB2.Text = "Loan";
            // 
            // lblCustomerName3
            // 
            this.lblCustomerName3.BackColor = System.Drawing.Color.White;
            this.lblCustomerName3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerName3.Location = new System.Drawing.Point(110, 109);
            this.lblCustomerName3.Multiline = true;
            this.lblCustomerName3.Name = "lblCustomerName3";
            this.lblCustomerName3.ReadOnly = true;
            this.lblCustomerName3.Size = new System.Drawing.Size(350, 39);
            this.lblCustomerName3.TabIndex = 311;
            this.lblCustomerName3.Text = "Loan";
            // 
            // lblDnis
            // 
            this.lblDnis.BackColor = System.Drawing.Color.White;
            this.lblDnis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDnis.Location = new System.Drawing.Point(110, 46);
            this.lblDnis.Name = "lblDnis";
            this.lblDnis.ReadOnly = true;
            this.lblDnis.Size = new System.Drawing.Size(350, 16);
            this.lblDnis.TabIndex = 310;
            this.lblDnis.Text = "Loan";
            // 
            // lblServiceName3
            // 
            this.lblServiceName3.AutoSize = true;
            this.lblServiceName3.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName3.Location = new System.Drawing.Point(225, 18);
            this.lblServiceName3.Name = "lblServiceName3";
            this.lblServiceName3.Size = new System.Drawing.Size(39, 15);
            this.lblServiceName3.TabIndex = 290;
            this.lblServiceName3.Text = "Loan1";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.SandyBrown;
            this.label72.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(4, 18);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(79, 15);
            this.label72.TabIndex = 289;
            this.label72.Text = "Service Name";
            // 
            // label73
            // 
            this.label73.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label73.BackColor = System.Drawing.Color.Yellow;
            this.label73.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(194, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(1057, 25);
            this.label73.TabIndex = 288;
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label74.BackColor = System.Drawing.Color.SandyBrown;
            this.label74.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(4, 13);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(302, 25);
            this.label74.TabIndex = 291;
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.Location = new System.Drawing.Point(837, 156);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(37, 15);
            this.label128.TabIndex = 283;
            this.label128.Text = "Other";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.Location = new System.Drawing.Point(837, 101);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(39, 15);
            this.label129.TabIndex = 282;
            this.label129.Text = "Office";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.Location = new System.Drawing.Point(837, 46);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(40, 15);
            this.label130.TabIndex = 281;
            this.label130.Text = "Home";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.Location = new System.Drawing.Point(463, 164);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(44, 15);
            this.label131.TabIndex = 280;
            this.label131.Text = "Region";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.Location = new System.Drawing.Point(463, 109);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(45, 15);
            this.label132.TabIndex = 279;
            this.label132.Text = "Gender";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.Location = new System.Drawing.Point(463, 46);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(103, 15);
            this.label133.TabIndex = 278;
            this.label133.Text = "Sub Product Code";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.Location = new System.Drawing.Point(8, 164);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(31, 15);
            this.label134.TabIndex = 277;
            this.label134.Text = "DOB";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.Location = new System.Drawing.Point(8, 109);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(94, 15);
            this.label135.TabIndex = 276;
            this.label135.Text = "Customer Name";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.Location = new System.Drawing.Point(8, 70);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(80, 15);
            this.label136.TabIndex = 275;
            this.label136.Text = "Loan Number";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.Location = new System.Drawing.Point(8, 46);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(68, 15);
            this.label137.TabIndex = 274;
            this.label137.Text = "Contact No";
            // 
            // customerTabPage
            // 
            this.customerTabPage.BackColor = System.Drawing.Color.White;
            this.customerTabPage.Controls.Add(this.panel3);
            this.customerTabPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTabPage.Location = new System.Drawing.Point(4, 38);
            this.customerTabPage.Name = "customerTabPage";
            this.customerTabPage.Size = new System.Drawing.Size(1259, 379);
            this.customerTabPage.TabIndex = 3;
            this.customerTabPage.Text = "Customer Address";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel19);
            this.panel3.Controls.Add(this.panel18);
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1259, 379);
            this.panel3.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.groupBox12);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 490);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(1242, 300);
            this.panel19.TabIndex = 365;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtMobile);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Controls.Add(this.txtContact2);
            this.groupBox12.Controls.Add(this.label42);
            this.groupBox12.Controls.Add(this.label146);
            this.groupBox12.Controls.Add(this.txtContact1);
            this.groupBox12.Controls.Add(this.txtCity);
            this.groupBox12.Controls.Add(this.txtAddress3);
            this.groupBox12.Controls.Add(this.txtAddress2);
            this.groupBox12.Controls.Add(this.txtAddress1);
            this.groupBox12.Controls.Add(this.btnUpdateAddress);
            this.groupBox12.Controls.Add(this.label46);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.label78);
            this.groupBox12.Controls.Add(this.label144);
            this.groupBox12.Controls.Add(this.label151);
            this.groupBox12.Controls.Add(this.label162);
            this.groupBox12.Controls.Add(this.label163);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(0, 0);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1242, 300);
            this.groupBox12.TabIndex = 362;
            this.groupBox12.TabStop = false;
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(224, 236);
            this.txtMobile.MaxLength = 18;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(418, 23);
            this.txtMobile.TabIndex = 406;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(25, 236);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(44, 15);
            this.label41.TabIndex = 405;
            this.label41.Text = "Mobile";
            // 
            // txtContact2
            // 
            this.txtContact2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact2.Location = new System.Drawing.Point(224, 210);
            this.txtContact2.MaxLength = 18;
            this.txtContact2.Name = "txtContact2";
            this.txtContact2.Size = new System.Drawing.Size(418, 23);
            this.txtContact2.TabIndex = 404;
            this.txtContact2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact2_KeyPress);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(25, 210);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(77, 15);
            this.label42.TabIndex = 403;
            this.label42.Text = "Contact No 2";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.Location = new System.Drawing.Point(25, 50);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(77, 15);
            this.label146.TabIndex = 402;
            this.label146.Text = "Address Type";
            // 
            // txtContact1
            // 
            this.txtContact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContact1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact1.Location = new System.Drawing.Point(224, 183);
            this.txtContact1.MaxLength = 18;
            this.txtContact1.Name = "txtContact1";
            this.txtContact1.Size = new System.Drawing.Size(418, 23);
            this.txtContact1.TabIndex = 401;
            this.txtContact1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact1_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(224, 155);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(418, 23);
            this.txtCity.TabIndex = 400;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtAddress3
            // 
            this.txtAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress3.Location = new System.Drawing.Point(224, 127);
            this.txtAddress3.MaxLength = 40;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(418, 23);
            this.txtAddress3.TabIndex = 399;
            this.txtAddress3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress3_KeyPress);
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(224, 101);
            this.txtAddress2.MaxLength = 40;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(418, 23);
            this.txtAddress2.TabIndex = 398;
            this.txtAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress2_KeyPress);
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(224, 75);
            this.txtAddress1.MaxLength = 40;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(418, 23);
            this.txtAddress1.TabIndex = 397;
            this.txtAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress1_KeyPress);
            // 
            // btnUpdateAddress
            // 
            this.btnUpdateAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAddress.Location = new System.Drawing.Point(224, 263);
            this.btnUpdateAddress.Name = "btnUpdateAddress";
            this.btnUpdateAddress.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAddress.TabIndex = 396;
            this.btnUpdateAddress.Text = "Update";
            this.btnUpdateAddress.UseVisualStyleBackColor = true;
            this.btnUpdateAddress.Click += new System.EventHandler(this.button23_Click);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(25, 183);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(77, 15);
            this.label46.TabIndex = 393;
            this.label46.Text = "Contact No 1";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(25, 155);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(28, 15);
            this.label47.TabIndex = 392;
            this.label47.Text = "City";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(25, 75);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(71, 15);
            this.label78.TabIndex = 391;
            this.label78.Text = "Full Address";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.Location = new System.Drawing.Point(225, 50);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(37, 15);
            this.label144.TabIndex = 360;
            this.label144.Text = "Other";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.BackColor = System.Drawing.Color.SandyBrown;
            this.label151.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(6, 20);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(101, 15);
            this.label151.TabIndex = 341;
            this.label151.Text = "Add New Address";
            // 
            // label162
            // 
            this.label162.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label162.BackColor = System.Drawing.Color.Yellow;
            this.label162.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label162.Location = new System.Drawing.Point(195, 15);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(1069, 25);
            this.label162.TabIndex = 340;
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label163
            // 
            this.label163.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label163.BackColor = System.Drawing.Color.SandyBrown;
            this.label163.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label163.Location = new System.Drawing.Point(6, 15);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(302, 25);
            this.label163.TabIndex = 342;
            this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.groupBox11);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 253);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(1242, 237);
            this.panel18.TabIndex = 364;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lblMOBILE_O);
            this.groupBox11.Controls.Add(this.lblCONTACT2_O);
            this.groupBox11.Controls.Add(this.lblCONTACT1_O);
            this.groupBox11.Controls.Add(this.lblCITY_O);
            this.groupBox11.Controls.Add(this.lblALAMAT_O);
            this.groupBox11.Controls.Add(this.lblMOBILE_E);
            this.groupBox11.Controls.Add(this.lblCONTACT2_E);
            this.groupBox11.Controls.Add(this.lblCONTACT1_E);
            this.groupBox11.Controls.Add(this.lblCITY_E);
            this.groupBox11.Controls.Add(this.lblALAMAT_E);
            this.groupBox11.Controls.Add(this.lblMOBILE_P);
            this.groupBox11.Controls.Add(this.lblCONTACT2_P);
            this.groupBox11.Controls.Add(this.lblCITY_P);
            this.groupBox11.Controls.Add(this.lblCONTACT1_P);
            this.groupBox11.Controls.Add(this.lblALAMAT_P);
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Controls.Add(this.label49);
            this.groupBox11.Controls.Add(this.label83);
            this.groupBox11.Controls.Add(this.label114);
            this.groupBox11.Controls.Add(this.label138);
            this.groupBox11.Controls.Add(this.label171);
            this.groupBox11.Controls.Add(this.label172);
            this.groupBox11.Controls.Add(this.label173);
            this.groupBox11.Controls.Add(this.label174);
            this.groupBox11.Controls.Add(this.label176);
            this.groupBox11.Controls.Add(this.label177);
            this.groupBox11.Controls.Add(this.label178);
            this.groupBox11.Controls.Add(this.label119);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1242, 237);
            this.groupBox11.TabIndex = 361;
            this.groupBox11.TabStop = false;
            // 
            // lblMOBILE_O
            // 
            this.lblMOBILE_O.BackColor = System.Drawing.Color.White;
            this.lblMOBILE_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMOBILE_O.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOBILE_O.Location = new System.Drawing.Point(842, 206);
            this.lblMOBILE_O.Name = "lblMOBILE_O";
            this.lblMOBILE_O.ReadOnly = true;
            this.lblMOBILE_O.Size = new System.Drawing.Size(340, 15);
            this.lblMOBILE_O.TabIndex = 479;
            this.lblMOBILE_O.Text = "Loan";
            // 
            // lblCONTACT2_O
            // 
            this.lblCONTACT2_O.BackColor = System.Drawing.Color.White;
            this.lblCONTACT2_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT2_O.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT2_O.Location = new System.Drawing.Point(842, 183);
            this.lblCONTACT2_O.Name = "lblCONTACT2_O";
            this.lblCONTACT2_O.ReadOnly = true;
            this.lblCONTACT2_O.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT2_O.TabIndex = 478;
            this.lblCONTACT2_O.Text = "Loan";
            // 
            // lblCONTACT1_O
            // 
            this.lblCONTACT1_O.BackColor = System.Drawing.Color.White;
            this.lblCONTACT1_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT1_O.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT1_O.Location = new System.Drawing.Point(842, 160);
            this.lblCONTACT1_O.Name = "lblCONTACT1_O";
            this.lblCONTACT1_O.ReadOnly = true;
            this.lblCONTACT1_O.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT1_O.TabIndex = 477;
            this.lblCONTACT1_O.Text = "Loan";
            // 
            // lblCITY_O
            // 
            this.lblCITY_O.BackColor = System.Drawing.Color.White;
            this.lblCITY_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCITY_O.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCITY_O.Location = new System.Drawing.Point(842, 137);
            this.lblCITY_O.Name = "lblCITY_O";
            this.lblCITY_O.ReadOnly = true;
            this.lblCITY_O.Size = new System.Drawing.Size(340, 15);
            this.lblCITY_O.TabIndex = 476;
            this.lblCITY_O.Text = "Loan";
            // 
            // lblALAMAT_O
            // 
            this.lblALAMAT_O.BackColor = System.Drawing.Color.White;
            this.lblALAMAT_O.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblALAMAT_O.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALAMAT_O.Location = new System.Drawing.Point(842, 74);
            this.lblALAMAT_O.Multiline = true;
            this.lblALAMAT_O.Name = "lblALAMAT_O";
            this.lblALAMAT_O.ReadOnly = true;
            this.lblALAMAT_O.Size = new System.Drawing.Size(340, 55);
            this.lblALAMAT_O.TabIndex = 475;
            this.lblALAMAT_O.Text = "Loan";
            // 
            // lblMOBILE_E
            // 
            this.lblMOBILE_E.BackColor = System.Drawing.Color.White;
            this.lblMOBILE_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMOBILE_E.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOBILE_E.Location = new System.Drawing.Point(490, 206);
            this.lblMOBILE_E.Name = "lblMOBILE_E";
            this.lblMOBILE_E.ReadOnly = true;
            this.lblMOBILE_E.Size = new System.Drawing.Size(340, 15);
            this.lblMOBILE_E.TabIndex = 474;
            this.lblMOBILE_E.Text = "Loan";
            // 
            // lblCONTACT2_E
            // 
            this.lblCONTACT2_E.BackColor = System.Drawing.Color.White;
            this.lblCONTACT2_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT2_E.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT2_E.Location = new System.Drawing.Point(490, 183);
            this.lblCONTACT2_E.Name = "lblCONTACT2_E";
            this.lblCONTACT2_E.ReadOnly = true;
            this.lblCONTACT2_E.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT2_E.TabIndex = 473;
            this.lblCONTACT2_E.Text = "Loan";
            // 
            // lblCONTACT1_E
            // 
            this.lblCONTACT1_E.BackColor = System.Drawing.Color.White;
            this.lblCONTACT1_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT1_E.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT1_E.Location = new System.Drawing.Point(490, 160);
            this.lblCONTACT1_E.Name = "lblCONTACT1_E";
            this.lblCONTACT1_E.ReadOnly = true;
            this.lblCONTACT1_E.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT1_E.TabIndex = 472;
            this.lblCONTACT1_E.Text = "Loan";
            // 
            // lblCITY_E
            // 
            this.lblCITY_E.BackColor = System.Drawing.Color.White;
            this.lblCITY_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCITY_E.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCITY_E.Location = new System.Drawing.Point(490, 137);
            this.lblCITY_E.Name = "lblCITY_E";
            this.lblCITY_E.ReadOnly = true;
            this.lblCITY_E.Size = new System.Drawing.Size(340, 15);
            this.lblCITY_E.TabIndex = 471;
            this.lblCITY_E.Text = "Loan";
            // 
            // lblALAMAT_E
            // 
            this.lblALAMAT_E.BackColor = System.Drawing.Color.White;
            this.lblALAMAT_E.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblALAMAT_E.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALAMAT_E.Location = new System.Drawing.Point(490, 74);
            this.lblALAMAT_E.Multiline = true;
            this.lblALAMAT_E.Name = "lblALAMAT_E";
            this.lblALAMAT_E.ReadOnly = true;
            this.lblALAMAT_E.Size = new System.Drawing.Size(340, 55);
            this.lblALAMAT_E.TabIndex = 470;
            this.lblALAMAT_E.Text = "Loan";
            // 
            // lblMOBILE_P
            // 
            this.lblMOBILE_P.BackColor = System.Drawing.Color.White;
            this.lblMOBILE_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMOBILE_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOBILE_P.Location = new System.Drawing.Point(134, 205);
            this.lblMOBILE_P.Name = "lblMOBILE_P";
            this.lblMOBILE_P.ReadOnly = true;
            this.lblMOBILE_P.Size = new System.Drawing.Size(340, 15);
            this.lblMOBILE_P.TabIndex = 469;
            this.lblMOBILE_P.Text = "Loan";
            // 
            // lblCONTACT2_P
            // 
            this.lblCONTACT2_P.BackColor = System.Drawing.Color.White;
            this.lblCONTACT2_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT2_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT2_P.Location = new System.Drawing.Point(134, 182);
            this.lblCONTACT2_P.Name = "lblCONTACT2_P";
            this.lblCONTACT2_P.ReadOnly = true;
            this.lblCONTACT2_P.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT2_P.TabIndex = 468;
            this.lblCONTACT2_P.Text = "Loan";
            // 
            // lblCITY_P
            // 
            this.lblCITY_P.BackColor = System.Drawing.Color.White;
            this.lblCITY_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCITY_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCITY_P.Location = new System.Drawing.Point(134, 137);
            this.lblCITY_P.Name = "lblCITY_P";
            this.lblCITY_P.ReadOnly = true;
            this.lblCITY_P.Size = new System.Drawing.Size(340, 15);
            this.lblCITY_P.TabIndex = 467;
            this.lblCITY_P.Text = "Loan";
            // 
            // lblCONTACT1_P
            // 
            this.lblCONTACT1_P.BackColor = System.Drawing.Color.White;
            this.lblCONTACT1_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCONTACT1_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONTACT1_P.Location = new System.Drawing.Point(134, 160);
            this.lblCONTACT1_P.Name = "lblCONTACT1_P";
            this.lblCONTACT1_P.ReadOnly = true;
            this.lblCONTACT1_P.Size = new System.Drawing.Size(340, 15);
            this.lblCONTACT1_P.TabIndex = 466;
            this.lblCONTACT1_P.Text = "Loan";
            // 
            // lblALAMAT_P
            // 
            this.lblALAMAT_P.BackColor = System.Drawing.Color.White;
            this.lblALAMAT_P.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblALAMAT_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblALAMAT_P.Location = new System.Drawing.Point(134, 73);
            this.lblALAMAT_P.Multiline = true;
            this.lblALAMAT_P.Name = "lblALAMAT_P";
            this.lblALAMAT_P.ReadOnly = true;
            this.lblALAMAT_P.Size = new System.Drawing.Size(340, 55);
            this.lblALAMAT_P.TabIndex = 465;
            this.lblALAMAT_P.Text = "Loan";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(25, 205);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(44, 15);
            this.label48.TabIndex = 395;
            this.label48.Text = "Mobile";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(25, 182);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 15);
            this.label49.TabIndex = 394;
            this.label49.Text = "Contact No 2";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(25, 159);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(77, 15);
            this.label83.TabIndex = 393;
            this.label83.Text = "Contact No 1";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.Location = new System.Drawing.Point(25, 136);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(28, 15);
            this.label114.TabIndex = 392;
            this.label114.Text = "City";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.Location = new System.Drawing.Point(25, 73);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(71, 15);
            this.label138.TabIndex = 391;
            this.label138.Text = "Full Address";
            // 
            // label171
            // 
            this.label171.BackColor = System.Drawing.Color.Yellow;
            this.label171.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label171.Location = new System.Drawing.Point(842, 43);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(330, 23);
            this.label171.TabIndex = 348;
            this.label171.Text = "Other";
            this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label172
            // 
            this.label172.BackColor = System.Drawing.Color.Yellow;
            this.label172.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label172.Location = new System.Drawing.Point(490, 43);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(350, 23);
            this.label172.TabIndex = 346;
            this.label172.Text = "Office";
            this.label172.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label173
            // 
            this.label173.BackColor = System.Drawing.Color.Yellow;
            this.label173.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label173.Location = new System.Drawing.Point(28, 43);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(450, 23);
            this.label173.TabIndex = 344;
            this.label173.Text = "Home";
            this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.BackColor = System.Drawing.Color.SandyBrown;
            this.label174.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label174.Location = new System.Drawing.Point(6, 20);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(104, 15);
            this.label174.TabIndex = 341;
            this.label174.Text = "Customer Address";
            // 
            // label176
            // 
            this.label176.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label176.BackColor = System.Drawing.Color.Yellow;
            this.label176.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label176.Location = new System.Drawing.Point(198, 15);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(1053, 25);
            this.label176.TabIndex = 340;
            this.label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label177
            // 
            this.label177.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label177.BackColor = System.Drawing.Color.SandyBrown;
            this.label177.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label177.Location = new System.Drawing.Point(6, 15);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(111, 25);
            this.label177.TabIndex = 342;
            this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label178
            // 
            this.label178.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label178.BackColor = System.Drawing.Color.Yellow;
            this.label178.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label178.Location = new System.Drawing.Point(6, 43);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(768, 25);
            this.label178.TabIndex = 351;
            this.label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label119
            // 
            this.label119.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label119.BackColor = System.Drawing.Color.SandyBrown;
            this.label119.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.Location = new System.Drawing.Point(7, 15);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(302, 25);
            this.label119.TabIndex = 480;
            this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.groupBox10);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1242, 253);
            this.panel17.TabIndex = 363;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lblLoan7);
            this.groupBox10.Controls.Add(this.lblPother3);
            this.groupBox10.Controls.Add(this.lblPoffice3);
            this.groupBox10.Controls.Add(this.lblPhome3);
            this.groupBox10.Controls.Add(this.lblRegion3);
            this.groupBox10.Controls.Add(this.lblGender3);
            this.groupBox10.Controls.Add(this.lblProduct3);
            this.groupBox10.Controls.Add(this.lblDOB3);
            this.groupBox10.Controls.Add(this.lblCustomerName4);
            this.groupBox10.Controls.Add(this.lblDnis2);
            this.groupBox10.Controls.Add(this.lblServiceName4);
            this.groupBox10.Controls.Add(this.label85);
            this.groupBox10.Controls.Add(this.label86);
            this.groupBox10.Controls.Add(this.label87);
            this.groupBox10.Controls.Add(this.label88);
            this.groupBox10.Controls.Add(this.label89);
            this.groupBox10.Controls.Add(this.label90);
            this.groupBox10.Controls.Add(this.label91);
            this.groupBox10.Controls.Add(this.label92);
            this.groupBox10.Controls.Add(this.label93);
            this.groupBox10.Controls.Add(this.label94);
            this.groupBox10.Controls.Add(this.label109);
            this.groupBox10.Controls.Add(this.label110);
            this.groupBox10.Controls.Add(this.label111);
            this.groupBox10.Controls.Add(this.label120);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1242, 250);
            this.groupBox10.TabIndex = 193;
            this.groupBox10.TabStop = false;
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // lblLoan7
            // 
            this.lblLoan7.BackColor = System.Drawing.Color.White;
            this.lblLoan7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLoan7.Location = new System.Drawing.Point(114, 70);
            this.lblLoan7.Name = "lblLoan7";
            this.lblLoan7.ReadOnly = true;
            this.lblLoan7.Size = new System.Drawing.Size(350, 16);
            this.lblLoan7.TabIndex = 329;
            this.lblLoan7.Text = "Loan";
            // 
            // lblPother3
            // 
            this.lblPother3.BackColor = System.Drawing.Color.White;
            this.lblPother3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPother3.Location = new System.Drawing.Point(917, 180);
            this.lblPother3.Multiline = true;
            this.lblPother3.Name = "lblPother3";
            this.lblPother3.ReadOnly = true;
            this.lblPother3.Size = new System.Drawing.Size(244, 55);
            this.lblPother3.TabIndex = 328;
            this.lblPother3.Text = "Loan";
            // 
            // lblPoffice3
            // 
            this.lblPoffice3.BackColor = System.Drawing.Color.White;
            this.lblPoffice3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPoffice3.Location = new System.Drawing.Point(917, 125);
            this.lblPoffice3.Multiline = true;
            this.lblPoffice3.Name = "lblPoffice3";
            this.lblPoffice3.ReadOnly = true;
            this.lblPoffice3.Size = new System.Drawing.Size(244, 55);
            this.lblPoffice3.TabIndex = 327;
            this.lblPoffice3.Text = "Loan";
            // 
            // lblPhome3
            // 
            this.lblPhome3.BackColor = System.Drawing.Color.White;
            this.lblPhome3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPhome3.Location = new System.Drawing.Point(917, 70);
            this.lblPhome3.Multiline = true;
            this.lblPhome3.Name = "lblPhome3";
            this.lblPhome3.ReadOnly = true;
            this.lblPhome3.Size = new System.Drawing.Size(244, 55);
            this.lblPhome3.TabIndex = 326;
            this.lblPhome3.Text = "Loan";
            // 
            // lblRegion3
            // 
            this.lblRegion3.BackColor = System.Drawing.Color.White;
            this.lblRegion3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRegion3.Location = new System.Drawing.Point(584, 180);
            this.lblRegion3.Name = "lblRegion3";
            this.lblRegion3.ReadOnly = true;
            this.lblRegion3.Size = new System.Drawing.Size(250, 16);
            this.lblRegion3.TabIndex = 325;
            this.lblRegion3.Text = "Loan";
            // 
            // lblGender3
            // 
            this.lblGender3.BackColor = System.Drawing.Color.White;
            this.lblGender3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGender3.Location = new System.Drawing.Point(584, 125);
            this.lblGender3.Name = "lblGender3";
            this.lblGender3.ReadOnly = true;
            this.lblGender3.Size = new System.Drawing.Size(250, 16);
            this.lblGender3.TabIndex = 324;
            this.lblGender3.Text = "Loan";
            // 
            // lblProduct3
            // 
            this.lblProduct3.BackColor = System.Drawing.Color.White;
            this.lblProduct3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProduct3.Location = new System.Drawing.Point(584, 70);
            this.lblProduct3.Multiline = true;
            this.lblProduct3.Name = "lblProduct3";
            this.lblProduct3.ReadOnly = true;
            this.lblProduct3.Size = new System.Drawing.Size(244, 39);
            this.lblProduct3.TabIndex = 323;
            this.lblProduct3.Text = "Loan";
            // 
            // lblDOB3
            // 
            this.lblDOB3.BackColor = System.Drawing.Color.White;
            this.lblDOB3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDOB3.Location = new System.Drawing.Point(114, 180);
            this.lblDOB3.Name = "lblDOB3";
            this.lblDOB3.ReadOnly = true;
            this.lblDOB3.Size = new System.Drawing.Size(350, 16);
            this.lblDOB3.TabIndex = 322;
            this.lblDOB3.Text = "Loan";
            // 
            // lblCustomerName4
            // 
            this.lblCustomerName4.BackColor = System.Drawing.Color.White;
            this.lblCustomerName4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCustomerName4.Location = new System.Drawing.Point(114, 125);
            this.lblCustomerName4.Multiline = true;
            this.lblCustomerName4.Name = "lblCustomerName4";
            this.lblCustomerName4.ReadOnly = true;
            this.lblCustomerName4.Size = new System.Drawing.Size(350, 39);
            this.lblCustomerName4.TabIndex = 321;
            this.lblCustomerName4.Text = "Loan";
            // 
            // lblDnis2
            // 
            this.lblDnis2.BackColor = System.Drawing.Color.White;
            this.lblDnis2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDnis2.Location = new System.Drawing.Point(114, 46);
            this.lblDnis2.Name = "lblDnis2";
            this.lblDnis2.ReadOnly = true;
            this.lblDnis2.Size = new System.Drawing.Size(350, 16);
            this.lblDnis2.TabIndex = 320;
            this.lblDnis2.Text = "Loan";
            // 
            // lblServiceName4
            // 
            this.lblServiceName4.AutoSize = true;
            this.lblServiceName4.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName4.Location = new System.Drawing.Point(225, 18);
            this.lblServiceName4.Name = "lblServiceName4";
            this.lblServiceName4.Size = new System.Drawing.Size(39, 15);
            this.lblServiceName4.TabIndex = 290;
            this.lblServiceName4.Text = "Loan1";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.SandyBrown;
            this.label85.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(4, 18);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(79, 15);
            this.label85.TabIndex = 289;
            this.label85.Text = "Service Name";
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.BackColor = System.Drawing.Color.Yellow;
            this.label86.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.Location = new System.Drawing.Point(195, 13);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(1064, 25);
            this.label86.TabIndex = 288;
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label87.BackColor = System.Drawing.Color.SandyBrown;
            this.label87.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.Location = new System.Drawing.Point(4, 13);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(111, 25);
            this.label87.TabIndex = 291;
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.Location = new System.Drawing.Point(837, 180);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(37, 15);
            this.label88.TabIndex = 283;
            this.label88.Text = "Other";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.Location = new System.Drawing.Point(837, 125);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(39, 15);
            this.label89.TabIndex = 282;
            this.label89.Text = "Office";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.Location = new System.Drawing.Point(837, 70);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(40, 15);
            this.label90.TabIndex = 281;
            this.label90.Text = "Home";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.Location = new System.Drawing.Point(468, 180);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(44, 15);
            this.label91.TabIndex = 280;
            this.label91.Text = "Region";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.Location = new System.Drawing.Point(468, 125);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(45, 15);
            this.label92.TabIndex = 279;
            this.label92.Text = "Gender";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.Location = new System.Drawing.Point(468, 70);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(103, 15);
            this.label93.TabIndex = 278;
            this.label93.Text = "Sub Product Code";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.Location = new System.Drawing.Point(9, 180);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(31, 15);
            this.label94.TabIndex = 277;
            this.label94.Text = "DOB";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.Location = new System.Drawing.Point(9, 125);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(94, 15);
            this.label109.TabIndex = 276;
            this.label109.Text = "Customer Name";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.Location = new System.Drawing.Point(9, 70);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(80, 15);
            this.label110.TabIndex = 275;
            this.label110.Text = "Loan Number";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(9, 46);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(68, 15);
            this.label111.TabIndex = 274;
            this.label111.Text = "Contact No";
            // 
            // label120
            // 
            this.label120.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label120.BackColor = System.Drawing.Color.SandyBrown;
            this.label120.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.Location = new System.Drawing.Point(4, 13);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(302, 25);
            this.label120.TabIndex = 481;
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.txtDisposisiDesc);
            this.panel6.Controls.Add(this.grpschedule);
            this.panel6.Controls.Add(this.btnDisposisi);
            this.panel6.Controls.Add(this.label223);
            this.panel6.Controls.Add(this.txtMemo);
            this.panel6.Controls.Add(this.cbDisposisi1);
            this.panel6.Controls.Add(this.grpExclusion);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1011, 153);
            this.panel6.TabIndex = 4;
            // 
            // txtDisposisiDesc
            // 
            this.txtDisposisiDesc.BackColor = System.Drawing.Color.White;
            this.txtDisposisiDesc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisposisiDesc.Location = new System.Drawing.Point(262, 9);
            this.txtDisposisiDesc.Name = "txtDisposisiDesc";
            this.txtDisposisiDesc.Size = new System.Drawing.Size(260, 23);
            this.txtDisposisiDesc.TabIndex = 317;
            this.txtDisposisiDesc.TextChanged += new System.EventHandler(this.txtDisposisiDesc_TextChanged);
            // 
            // grpschedule
            // 
            this.grpschedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpschedule.Controls.Add(this.panel8);
            this.grpschedule.Controls.Add(this.panel7);
            this.grpschedule.Controls.Add(this.callbackTime);
            this.grpschedule.Controls.Add(this.TZComboBox);
            this.grpschedule.Controls.Add(this.cbSnooze);
            this.grpschedule.Controls.Add(this.label224);
            this.grpschedule.Controls.Add(this.cbOutbound);
            this.grpschedule.Controls.Add(this.label225);
            this.grpschedule.Controls.Add(this.label226);
            this.grpschedule.Controls.Add(this.label227);
            this.grpschedule.Controls.Add(this.label228);
            this.grpschedule.Controls.Add(this.callbackdate);
            this.grpschedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpschedule.Location = new System.Drawing.Point(3, 45);
            this.grpschedule.Name = "grpschedule";
            this.grpschedule.Size = new System.Drawing.Size(1033, 195);
            this.grpschedule.TabIndex = 287;
            this.grpschedule.TabStop = false;
            this.grpschedule.Text = "Schedule a Callback";
            this.grpschedule.Enter += new System.EventHandler(this.grpschedule_Enter);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label222);
            this.panel8.Controls.Add(this.rbsameAgent);
            this.panel8.Controls.Add(this.radioButton4);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(578, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(471, 61);
            this.panel8.TabIndex = 324;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label222.Location = new System.Drawing.Point(3, 6);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(72, 15);
            this.label222.TabIndex = 316;
            this.label222.Text = "Send Call To";
            // 
            // rbsameAgent
            // 
            this.rbsameAgent.AutoSize = true;
            this.rbsameAgent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsameAgent.Location = new System.Drawing.Point(299, 6);
            this.rbsameAgent.Name = "rbsameAgent";
            this.rbsameAgent.Size = new System.Drawing.Size(42, 19);
            this.rbsameAgent.TabIndex = 315;
            this.rbsameAgent.TabStop = true;
            this.rbsameAgent.Text = "Me";
            this.rbsameAgent.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(103, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(190, 19);
            this.radioButton4.TabIndex = 314;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Service (To any available agent)";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtPhone2);
            this.panel7.Controls.Add(this.txtPhone1);
            this.panel7.Controls.Add(this.radioButton2);
            this.panel7.Controls.Add(this.radioButton1);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(11, 53);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(565, 63);
            this.panel7.TabIndex = 323;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(175, 30);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(168, 23);
            this.txtPhone2.TabIndex = 317;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Enabled = false;
            this.txtPhone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone1.Location = new System.Drawing.Point(176, 4);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(168, 23);
            this.txtPhone1.TabIndex = 316;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(3, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(166, 19);
            this.radioButton2.TabIndex = 315;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Alternative Phone Number";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 19);
            this.radioButton1.TabIndex = 314;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Primary Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // callbackTime
            // 
            this.callbackTime.CustomFormat = "dd/MM/yyyy";
            this.callbackTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callbackTime.Location = new System.Drawing.Point(420, 25);
            this.callbackTime.Name = "callbackTime";
            this.callbackTime.Size = new System.Drawing.Size(149, 23);
            this.callbackTime.TabIndex = 322;
            this.callbackTime.Value = new System.DateTime(2025, 9, 28, 0, 0, 0, 0);
            // 
            // TZComboBox
            // 
            this.TZComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TZComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TZComboBox.FormattingEnabled = true;
            this.TZComboBox.Location = new System.Drawing.Point(709, 25);
            this.TZComboBox.Name = "TZComboBox";
            this.TZComboBox.Size = new System.Drawing.Size(445, 23);
            this.TZComboBox.TabIndex = 320;
            // 
            // cbSnooze
            // 
            this.cbSnooze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSnooze.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSnooze.FormattingEnabled = true;
            this.cbSnooze.Location = new System.Drawing.Point(430, 125);
            this.cbSnooze.Name = "cbSnooze";
            this.cbSnooze.Size = new System.Drawing.Size(314, 23);
            this.cbSnooze.TabIndex = 317;
            this.cbSnooze.SelectedIndexChanged += new System.EventHandler(this.cbSnooze_SelectedIndexChanged);
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label224.Location = new System.Drawing.Point(371, 130);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(45, 15);
            this.label224.TabIndex = 316;
            this.label224.Text = "Snooze";
            // 
            // cbOutbound
            // 
            this.cbOutbound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutbound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOutbound.FormattingEnabled = true;
            this.cbOutbound.Location = new System.Drawing.Point(93, 125);
            this.cbOutbound.Name = "cbOutbound";
            this.cbOutbound.Size = new System.Drawing.Size(266, 23);
            this.cbOutbound.TabIndex = 315;
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label225.Location = new System.Drawing.Point(13, 130);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(62, 15);
            this.label225.TabIndex = 314;
            this.label225.Text = "Outbound";
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label226.Location = new System.Drawing.Point(575, 28);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(109, 15);
            this.label226.TabIndex = 309;
            this.label226.Text = "Callback TimeZone";
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label227.Location = new System.Drawing.Point(319, 28);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(85, 15);
            this.label227.TabIndex = 307;
            this.label227.Text = "Preferred Time";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label228.Location = new System.Drawing.Point(9, 28);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(79, 15);
            this.label228.TabIndex = 305;
            this.label228.Text = "Callback Date";
            // 
            // callbackdate
            // 
            this.callbackdate.CustomFormat = "dd/MM/yyyy";
            this.callbackdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callbackdate.Location = new System.Drawing.Point(115, 25);
            this.callbackdate.Name = "callbackdate";
            this.callbackdate.Size = new System.Drawing.Size(105, 23);
            this.callbackdate.TabIndex = 0;
            this.callbackdate.Value = new System.DateTime(2025, 9, 28, 0, 0, 0, 0);
            // 
            // btnDisposisi
            // 
            this.btnDisposisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisposisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisposisi.Location = new System.Drawing.Point(528, 9);
            this.btnDisposisi.Name = "btnDisposisi";
            this.btnDisposisi.Size = new System.Drawing.Size(75, 23);
            this.btnDisposisi.TabIndex = 286;
            this.btnDisposisi.Text = "OK";
            this.btnDisposisi.UseVisualStyleBackColor = true;
            this.btnDisposisi.Click += new System.EventHandler(this.button26_Click);
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label223.Location = new System.Drawing.Point(12, 248);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(90, 15);
            this.label223.TabIndex = 319;
            this.label223.Text = "Callback Memo";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemo.Location = new System.Drawing.Point(8, 267);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(1154, 152);
            this.txtMemo.TabIndex = 318;

            // 
            // cbDisposisi1
            // 
            this.cbDisposisi1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDisposisi1.FormattingEnabled = true;
            this.cbDisposisi1.Location = new System.Drawing.Point(8, 9);
            this.cbDisposisi1.Name = "cbDisposisi1";
            this.cbDisposisi1.Size = new System.Drawing.Size(244, 24);
            this.cbDisposisi1.TabIndex = 321;
            this.cbDisposisi1.TabStop = false;
            this.cbDisposisi1.SelectedIndexChanged += new System.EventHandler(this.cbDisposisi1_SelectedIndexChanged);

            // 
            // grpExclusion
            // 
            this.grpExclusion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpExclusion.Controls.Add(this.lblExclusionType);
            this.grpExclusion.Controls.Add(this.label236);
            this.grpExclusion.Controls.Add(this.label235);
            this.grpExclusion.Controls.Add(this.label209);
            this.grpExclusion.Controls.Add(this.startdate);
            this.grpExclusion.Controls.Add(this.enddate);
            this.grpExclusion.Controls.Add(this.label233);
            this.grpExclusion.Controls.Add(this.txtphoneEx);
            this.grpExclusion.Controls.Add(this.cbApplication);
            this.grpExclusion.Controls.Add(this.cbExclusionType);
            this.grpExclusion.Controls.Add(this.cbExclusionTimezone);
            this.grpExclusion.Controls.Add(this.label208);
            this.grpExclusion.Location = new System.Drawing.Point(2, 45);
            this.grpExclusion.Name = "grpExclusion";
            this.grpExclusion.Size = new System.Drawing.Size(1007, 152);
            this.grpExclusion.TabIndex = 320;
            this.grpExclusion.TabStop = false;
            this.grpExclusion.Text = "Exclusion";
            // 
            // lblExclusionType
            // 
            this.lblExclusionType.AutoSize = true;
            this.lblExclusionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExclusionType.Location = new System.Drawing.Point(436, 25);
            this.lblExclusionType.Name = "lblExclusionType";
            this.lblExclusionType.Size = new System.Drawing.Size(88, 15);
            this.lblExclusionType.TabIndex = 333;
            this.lblExclusionType.Text = "Phone Number";
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label236.Location = new System.Drawing.Point(9, 25);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(84, 15);
            this.label236.TabIndex = 332;
            this.label236.Text = "Exclusion Type";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label235.Location = new System.Drawing.Point(9, 51);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(68, 15);
            this.label235.TabIndex = 331;
            this.label235.Text = "Application";
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label209.Location = new System.Drawing.Point(315, 114);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(54, 15);
            this.label209.TabIndex = 330;
            this.label209.Text = "End Date";
            // 
            // startdate
            // 
            this.startdate.CustomFormat = "dd/MM/yyyy";
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Location = new System.Drawing.Point(129, 109);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(149, 23);
            this.startdate.TabIndex = 329;
            this.startdate.Value = new System.DateTime(2025, 9, 28, 0, 0, 0, 0);
            // 
            // enddate
            // 
            this.enddate.CustomFormat = "dd/MM/yyyy";
            this.enddate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddate.Location = new System.Drawing.Point(420, 109);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(149, 23);
            this.enddate.TabIndex = 328;
            this.enddate.Value = new System.DateTime(2025, 9, 28, 0, 0, 0, 0);
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label233.Location = new System.Drawing.Point(9, 112);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(58, 15);
            this.label233.TabIndex = 326;
            this.label233.Text = "Start Date";
            // 
            // txtphoneEx
            // 
            this.txtphoneEx.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneEx.Location = new System.Drawing.Point(568, 22);
            this.txtphoneEx.Name = "txtphoneEx";
            this.txtphoneEx.Size = new System.Drawing.Size(168, 23);
            this.txtphoneEx.TabIndex = 325;
            // 
            // cbApplication
            // 
            this.cbApplication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbApplication.FormattingEnabled = true;
            this.cbApplication.Location = new System.Drawing.Point(131, 51);
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Size = new System.Drawing.Size(266, 23);
            this.cbApplication.TabIndex = 324;
            // 
            // cbExclusionType
            // 
            this.cbExclusionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExclusionType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclusionType.FormattingEnabled = true;
            this.cbExclusionType.Location = new System.Drawing.Point(131, 22);
            this.cbExclusionType.Name = "cbExclusionType";
            this.cbExclusionType.Size = new System.Drawing.Size(266, 23);
            this.cbExclusionType.TabIndex = 323;
            this.cbExclusionType.SelectedIndexChanged += new System.EventHandler(this.cbExclusionType_SelectedIndexChanged);
            // 
            // cbExclusionTimezone
            // 
            this.cbExclusionTimezone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExclusionTimezone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExclusionTimezone.FormattingEnabled = true;
            this.cbExclusionTimezone.Location = new System.Drawing.Point(129, 80);
            this.cbExclusionTimezone.Name = "cbExclusionTimezone";
            this.cbExclusionTimezone.Size = new System.Drawing.Size(445, 23);
            this.cbExclusionTimezone.TabIndex = 322;
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label208.Location = new System.Drawing.Point(9, 80);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(113, 15);
            this.label208.TabIndex = 321;
            this.label208.Text = "Exclusion TimeZone";
            // 
            // grpDial
            // 
            this.grpDial.Controls.Add(this.btnRecord);
            this.grpDial.Controls.Add(this.btn3Way);
            this.grpDial.Controls.Add(this.btnHold);
            this.grpDial.Controls.Add(this.btnDial);
            this.grpDial.Controls.Add(this.btnHangup);
            this.grpDial.Controls.Add(this.txtdial);
            this.grpDial.Location = new System.Drawing.Point(29, 36);
            this.grpDial.Name = "grpDial";
            this.grpDial.Size = new System.Drawing.Size(335, 99);
            this.grpDial.TabIndex = 3;
            this.grpDial.TabStop = false;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.Transparent;
            this.btnRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecord.BackgroundImage")));
            this.btnRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(165, 47);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(35, 35);
            this.btnRecord.TabIndex = 11;
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btn3Way
            // 
            this.btn3Way.BackColor = System.Drawing.Color.Transparent;
            this.btn3Way.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3Way.BackgroundImage")));
            this.btn3Way.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn3Way.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Way.Location = new System.Drawing.Point(124, 47);
            this.btn3Way.Name = "btn3Way";
            this.btn3Way.Size = new System.Drawing.Size(35, 35);
            this.btn3Way.TabIndex = 10;
            this.btn3Way.UseVisualStyleBackColor = false;
            this.btn3Way.Click += new System.EventHandler(this.btn3Way_Click);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.Transparent;
            this.btnHold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHold.BackgroundImage")));
            this.btnHold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Location = new System.Drawing.Point(83, 47);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(35, 35);
            this.btnHold.TabIndex = 9;
            this.btnHold.UseVisualStyleBackColor = false;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnDial
            // 
            this.btnDial.BackColor = System.Drawing.Color.Transparent;
            this.btnDial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDial.BackgroundImage")));
            this.btnDial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDial.Location = new System.Drawing.Point(252, 15);
            this.btnDial.Name = "btnDial";
            this.btnDial.Size = new System.Drawing.Size(35, 35);
            this.btnDial.TabIndex = 8;
            this.btnDial.UseVisualStyleBackColor = false;
            this.btnDial.Click += new System.EventHandler(this.btnDial_Click);
            // 
            // btnHangup
            // 
            this.btnHangup.BackColor = System.Drawing.Color.Transparent;
            this.btnHangup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHangup.BackgroundImage")));
            this.btnHangup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHangup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangup.Location = new System.Drawing.Point(206, 47);
            this.btnHangup.Name = "btnHangup";
            this.btnHangup.Size = new System.Drawing.Size(35, 35);
            this.btnHangup.TabIndex = 7;
            this.btnHangup.UseVisualStyleBackColor = false;
            this.btnHangup.Click += new System.EventHandler(this.btnHangup_Click);
            // 
            // txtdial
            // 
            this.txtdial.Location = new System.Drawing.Point(13, 18);
            this.txtdial.Name = "txtdial";
            this.txtdial.Size = new System.Drawing.Size(226, 20);
            this.txtdial.TabIndex = 0;
            // 
            // Detail3
            // 
            this.Detail3.BackColor = System.Drawing.Color.White;
            this.Detail3.Controls.Add(this.panel6);
            this.Detail3.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail3.Location = new System.Drawing.Point(0, 784);
            this.Detail3.Margin = new System.Windows.Forms.Padding(2);
            this.Detail3.Name = "Detail3";
            this.Detail3.Size = new System.Drawing.Size(1011, 46);
            this.Detail3.TabIndex = 23;
            // 
            // Detail2
            // 
            this.Detail2.BackColor = System.Drawing.Color.White;
            this.Detail2.Controls.Add(this.panel5);
            this.Detail2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail2.Location = new System.Drawing.Point(0, 155);
            this.Detail2.Margin = new System.Windows.Forms.Padding(2);
            this.Detail2.Name = "Detail2";
            this.Detail2.Size = new System.Drawing.Size(1011, 592);
            this.Detail2.TabIndex = 21;
            // 
            // Detail1
            // 
            this.Detail1.BackColor = System.Drawing.Color.White;
            this.Detail1.Controls.Add(this.pnlWrap);
            this.Detail1.Controls.Add(this.pnlPreview);
            this.Detail1.Controls.Add(this.groupBox7);
            this.Detail1.Controls.Add(this.pnlAnswerCall);
            this.Detail1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Detail1.Location = new System.Drawing.Point(0, 37);
            this.Detail1.Margin = new System.Windows.Forms.Padding(2);
            this.Detail1.Name = "Detail1";
            this.Detail1.Size = new System.Drawing.Size(1011, 81);
            this.Detail1.TabIndex = 19;
            // 
            // pnlWrap
            // 
            this.pnlWrap.BackColor = System.Drawing.Color.Brown;
            this.pnlWrap.Controls.Add(this.lblWrapAction);
            this.pnlWrap.Controls.Add(this.label234);
            this.pnlWrap.Controls.Add(this.lbltimeWrap);
            this.pnlWrap.Controls.Add(this.label229);
            this.pnlWrap.Location = new System.Drawing.Point(18, 82);
            this.pnlWrap.Name = "pnlWrap";
            this.pnlWrap.Size = new System.Drawing.Size(1143, 47);
            this.pnlWrap.TabIndex = 59;
            this.pnlWrap.Visible = false;
            // 
            // lblWrapAction
            // 
            this.lblWrapAction.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrapAction.ForeColor = System.Drawing.Color.White;
            this.lblWrapAction.Location = new System.Drawing.Point(501, 16);
            this.lblWrapAction.Name = "lblWrapAction";
            this.lblWrapAction.Size = new System.Drawing.Size(94, 20);
            this.lblWrapAction.TabIndex = 264;
            this.lblWrapAction.Text = "000";
            this.lblWrapAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label234.ForeColor = System.Drawing.Color.White;
            this.label234.Location = new System.Drawing.Point(341, 16);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(80, 17);
            this.label234.TabIndex = 263;
            this.label234.Text = "Wrap Action";
            // 
            // lbltimeWrap
            // 
            this.lbltimeWrap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeWrap.ForeColor = System.Drawing.Color.White;
            this.lbltimeWrap.Location = new System.Drawing.Point(178, 16);
            this.lbltimeWrap.Name = "lbltimeWrap";
            this.lbltimeWrap.Size = new System.Drawing.Size(94, 20);
            this.lbltimeWrap.TabIndex = 262;
            this.lbltimeWrap.Text = "000";
            this.lbltimeWrap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label229
            // 
            this.label229.AutoSize = true;
            this.label229.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label229.ForeColor = System.Drawing.Color.White;
            this.label229.Location = new System.Drawing.Point(18, 16);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(97, 17);
            this.label229.TabIndex = 261;
            this.label229.Text = "Wrap Time Left";
            // 
            // pnlPreview
            // 
            this.pnlPreview.BackColor = System.Drawing.Color.Brown;
            this.pnlPreview.Controls.Add(this.lblPreview);
            this.pnlPreview.Controls.Add(this.label193);
            this.pnlPreview.Location = new System.Drawing.Point(18, 83);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(1143, 47);
            this.pnlPreview.TabIndex = 58;
            this.pnlPreview.Visible = false;
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.White;
            this.lblPreview.Location = new System.Drawing.Point(178, 13);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(94, 20);
            this.lblPreview.TabIndex = 262;
            this.lblPreview.Text = "000";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label193.ForeColor = System.Drawing.Color.White;
            this.label193.Location = new System.Drawing.Point(18, 13);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(109, 17);
            this.label193.TabIndex = 261;
            this.label193.Text = "Preview Time Left";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txtCallback);
            this.groupBox7.Controls.Add(this.txtDNISH);
            this.groupBox7.Controls.Add(this.txtphonenumberh);
            this.groupBox7.Controls.Add(this.txtName);
            this.groupBox7.Controls.Add(this.label188);
            this.groupBox7.Controls.Add(this.label71);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.label39);
            this.groupBox7.Location = new System.Drawing.Point(-6, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1020, 73);
            this.groupBox7.TabIndex = 57;
            this.groupBox7.TabStop = false;
            // 
            // txtCallback
            // 
            this.txtCallback.BackColor = System.Drawing.Color.White;
            this.txtCallback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCallback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCallback.Location = new System.Drawing.Point(640, 42);
            this.txtCallback.Name = "txtCallback";
            this.txtCallback.ReadOnly = true;
            this.txtCallback.Size = new System.Drawing.Size(270, 16);
            this.txtCallback.TabIndex = 301;
            this.txtCallback.Text = "Loan";
            // 
            // txtDNISH
            // 
            this.txtDNISH.BackColor = System.Drawing.Color.White;
            this.txtDNISH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDNISH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDNISH.Location = new System.Drawing.Point(640, 17);
            this.txtDNISH.Name = "txtDNISH";
            this.txtDNISH.ReadOnly = true;
            this.txtDNISH.Size = new System.Drawing.Size(270, 16);
            this.txtDNISH.TabIndex = 300;
            this.txtDNISH.Text = "Loan";
            // 
            // txtphonenumberh
            // 
            this.txtphonenumberh.BackColor = System.Drawing.Color.White;
            this.txtphonenumberh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtphonenumberh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtphonenumberh.Location = new System.Drawing.Point(129, 42);
            this.txtphonenumberh.Name = "txtphonenumberh";
            this.txtphonenumberh.ReadOnly = true;
            this.txtphonenumberh.Size = new System.Drawing.Size(270, 16);
            this.txtphonenumberh.TabIndex = 299;
            this.txtphonenumberh.Text = "Loan";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(129, 17);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(270, 16);
            this.txtName.TabIndex = 298;
            this.txtName.Text = "Loan";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label188.Location = new System.Drawing.Point(512, 42);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(90, 15);
            this.label188.TabIndex = 262;
            this.label188.Text = "Callback Memo";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(512, 17);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(33, 15);
            this.label71.TabIndex = 261;
            this.label71.Text = "DNIS";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(17, 42);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(88, 15);
            this.label43.TabIndex = 260;
            this.label43.Text = "Phone Number";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(17, 17);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(39, 15);
            this.label39.TabIndex = 259;
            this.label39.Text = "Name";
            // 
            // pnlAnswerCall
            // 
            this.pnlAnswerCall.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAnswerCall.Controls.Add(this.lblAnswerCallCountDown);
            this.pnlAnswerCall.Controls.Add(this.btnRejectCall);
            this.pnlAnswerCall.Controls.Add(this.btnAcceptCall);
            this.pnlAnswerCall.Location = new System.Drawing.Point(8, 127);
            this.pnlAnswerCall.Name = "pnlAnswerCall";
            this.pnlAnswerCall.Size = new System.Drawing.Size(388, 45);
            this.pnlAnswerCall.TabIndex = 56;
            this.pnlAnswerCall.Visible = false;
            // 
            // lblAnswerCallCountDown
            // 
            this.lblAnswerCallCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerCallCountDown.Location = new System.Drawing.Point(137, 12);
            this.lblAnswerCallCountDown.Name = "lblAnswerCallCountDown";
            this.lblAnswerCallCountDown.Size = new System.Drawing.Size(94, 20);
            this.lblAnswerCallCountDown.TabIndex = 5;
            this.lblAnswerCallCountDown.Text = "000";
            this.lblAnswerCallCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRejectCall
            // 
            this.btnRejectCall.Location = new System.Drawing.Point(243, 3);
            this.btnRejectCall.Name = "btnRejectCall";
            this.btnRejectCall.Size = new System.Drawing.Size(134, 36);
            this.btnRejectCall.TabIndex = 4;
            this.btnRejectCall.Text = "Reject";
            this.btnRejectCall.UseVisualStyleBackColor = true;
            // 
            // btnAcceptCall
            // 
            this.btnAcceptCall.Location = new System.Drawing.Point(8, 3);
            this.btnAcceptCall.Name = "btnAcceptCall";
            this.btnAcceptCall.Size = new System.Drawing.Size(130, 36);
            this.btnAcceptCall.TabIndex = 3;
            this.btnAcceptCall.Text = "Accept";
            this.btnAcceptCall.UseVisualStyleBackColor = true;
            // 
            // Header33
            // 
            this.Header33.AutoSize = true;
            this.Header33.BackColor = System.Drawing.Color.Transparent;
            this.Header33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header33.BackgroundImage")));
            this.Header33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header33.Controls.Add(this.label244);
            this.Header33.Controls.Add(this.lblPlus3);
            this.Header33.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header33.Location = new System.Drawing.Point(0, 747);
            this.Header33.Margin = new System.Windows.Forms.Padding(2);
            this.Header33.Name = "Header33";
            this.Header33.Size = new System.Drawing.Size(1011, 37);
            this.Header33.TabIndex = 22;
            // 
            // label244
            // 
            this.label244.AutoSize = true;
            this.label244.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label244.Location = new System.Drawing.Point(35, 11);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(123, 17);
            this.label244.TabIndex = 8;
            this.label244.Text = "Scheduler Callback";
            // 
            // lblPlus3
            // 
            this.lblPlus3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlus3.AutoSize = true;
            this.lblPlus3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus3.Location = new System.Drawing.Point(0, 0);
            this.lblPlus3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus3.Name = "lblPlus3";
            this.lblPlus3.Size = new System.Drawing.Size(28, 30);
            this.lblPlus3.TabIndex = 0;
            this.lblPlus3.Text = "+";
            this.lblPlus3.Click += new System.EventHandler(this.lblPlus3_Click);
            // 
            // Header22
            // 
            this.Header22.AutoSize = true;
            this.Header22.BackColor = System.Drawing.Color.Transparent;
            this.Header22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header22.BackgroundImage")));
            this.Header22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header22.Controls.Add(this.label241);
            this.Header22.Controls.Add(this.lblPlus2);
            this.Header22.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header22.Location = new System.Drawing.Point(0, 118);
            this.Header22.Margin = new System.Windows.Forms.Padding(2);
            this.Header22.Name = "Header22";
            this.Header22.Size = new System.Drawing.Size(1011, 37);
            this.Header22.TabIndex = 20;
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label241.Location = new System.Drawing.Point(35, 11);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(60, 17);
            this.label241.TabIndex = 8;
            this.label241.Text = "CallData";
            // 
            // lblPlus2
            // 
            this.lblPlus2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus2.Location = new System.Drawing.Point(0, 0);
            this.lblPlus2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(28, 30);
            this.lblPlus2.TabIndex = 0;
            this.lblPlus2.Text = "+";
            this.lblPlus2.Click += new System.EventHandler(this.lblPlus2_Click);
            // 
            // Header11
            // 
            this.Header11.AutoSize = true;
            this.Header11.BackColor = System.Drawing.Color.Transparent;
            this.Header11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Header11.BackgroundImage")));
            this.Header11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Header11.Controls.Add(this.label290);
            this.Header11.Controls.Add(this.lblPlus1);
            this.Header11.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header11.Location = new System.Drawing.Point(0, 0);
            this.Header11.Margin = new System.Windows.Forms.Padding(2);
            this.Header11.Name = "Header11";
            this.Header11.Size = new System.Drawing.Size(1011, 37);
            this.Header11.TabIndex = 18;
            // 
            // label290
            // 
            this.label290.AutoSize = true;
            this.label290.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label290.Location = new System.Drawing.Point(35, 11);
            this.label290.Name = "label290";
            this.label290.Size = new System.Drawing.Size(109, 17);
            this.label290.TabIndex = 8;
            this.label290.Text = "Call Information";
            // 
            // lblPlus1
            // 
            this.lblPlus1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus1.Location = new System.Drawing.Point(0, 0);
            this.lblPlus1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(28, 30);
            this.lblPlus1.TabIndex = 0;
            this.lblPlus1.Text = "+";
            this.lblPlus1.Click += new System.EventHandler(this.lblPlus1_Click);
            // 
            // FCallData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1028, 650);
            this.Controls.Add(this.Detail3);
            this.Controls.Add(this.Header33);
            this.Controls.Add(this.Detail2);
            this.Controls.Add(this.Header22);
            this.Controls.Add(this.Detail1);
            this.Controls.Add(this.Header11);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FCallData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FCallData_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dialerTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grp_phone_remainder.ResumeLayout(false);
            this.grp_phone_remainder1.ResumeLayout(false);
            this.grp_phone_remainder1.PerformLayout();
            this.grp_phone_not_answer.ResumeLayout(false);
            this.grp_phone_not_answer1.ResumeLayout(false);
            this.grp_phone_not_answer1.PerformLayout();
            this.grp_with_cp.ResumeLayout(false);
            this.grp_with_cp1.ResumeLayout(false);
            this.grp_with_cp1.PerformLayout();
            this.grp_with_borrower.ResumeLayout(false);
            this.grp_with_borrower1.ResumeLayout(false);
            this.grp_with_borrower1.PerformLayout();
            this.grp_ptp.ResumeLayout(false);
            this.grp_ptp1.ResumeLayout(false);
            this.grp_ptp1.PerformLayout();
            this.grp_phone_leave_message.ResumeLayout(false);
            this.grp_phone_leave_message1.ResumeLayout(false);
            this.grp_phone_leave_message1.PerformLayout();
            this.grp_action.ResumeLayout(false);
            this.grp_action1.ResumeLayout(false);
            this.grp_action1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.infoTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.customerTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.grpschedule.ResumeLayout(false);
            this.grpschedule.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.grpExclusion.ResumeLayout(false);
            this.grpExclusion.PerformLayout();
            this.grpDial.ResumeLayout(false);
            this.grpDial.PerformLayout();
            this.Detail3.ResumeLayout(false);
            this.Detail2.ResumeLayout(false);
            this.Detail1.ResumeLayout(false);
            this.pnlWrap.ResumeLayout(false);
            this.pnlWrap.PerformLayout();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pnlAnswerCall.ResumeLayout(false);
            this.Header33.ResumeLayout(false);
            this.Header33.PerformLayout();
            this.Header22.ResumeLayout(false);
            this.Header22.PerformLayout();
            this.Header11.ResumeLayout(false);
            this.Header11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        FList CallRejectionForm;
        private System.Threading.Timer mpUnloadTimer;
        private CService mpService;
     
        private System.Threading.Timer mpAnswerCallTimer;
        private Panel panel5;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.TabPage dialerTabPage;
        private System.Windows.Forms.TabPage customerTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblservicecaption;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblServiceName2;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lblServiceName4;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox txtContact1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Button btnUpdateAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtContact2;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox grp_with_borrower1;
        private System.Windows.Forms.Button btnCallBack;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.TextBox txtBAmount3;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.TextBox txtBAmount2;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.ComboBox cbContactBPlace;
        private System.Windows.Forms.TextBox txtRemarkB;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Button btnNextCallB;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Button btncancel3;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.GroupBox grp_with_cp1;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.GroupBox grp_phone_not_answer1;
        private System.Windows.Forms.ComboBox cbContactNoAPlace;
        private System.Windows.Forms.TextBox txtRemarkNoAnswer;
        private System.Windows.Forms.Label label245;
        private System.Windows.Forms.Label label246;
        private System.Windows.Forms.Label label247;
        private System.Windows.Forms.Label label248;
        private System.Windows.Forms.Label label249;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Label label250;
        private System.Windows.Forms.Label label251;
        private System.Windows.Forms.Label label252;
        private System.Windows.Forms.GroupBox grp_phone_leave_message1;
        private System.Windows.Forms.ComboBox cbPLaction2;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.ComboBox cbPLaction1;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.ComboBox cbContactPersonPl;
        private System.Windows.Forms.ComboBox cbContactPLPlace;
        private System.Windows.Forms.TextBox txtRemarkleave;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.GroupBox grp_action1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnPTP;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox grp_ptp1;
        private System.Windows.Forms.Label label283;
        private System.Windows.Forms.Label label282;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.ComboBox cbActionCode2;
        private System.Windows.Forms.ComboBox cbPTPPRDate2;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cbPTPHoldDate3;
        private System.Windows.Forms.TextBox txtPTPAmount3;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cbActionCode1;
        private System.Windows.Forms.ComboBox cbPTPPRDate1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox cbPTPHoldDate2;
        private System.Windows.Forms.TextBox txtPTPAmount2;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cbContactPerson;
        private System.Windows.Forms.ComboBox cbContactPlace;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtPTPAmount1;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Button btnUpdatePTP;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.ComboBox cbPTPHoldDate;
        private System.Windows.Forms.Label label285;
        private System.Windows.Forms.Label label284;
        private ComboBox cbBPRHoldDate2;
        private ComboBox cbBHoldDate2;
        private ComboBox cbBPRHoldDate1;
        private ComboBox cbBHoldDate1;
        private Label label286;
        private Label label287;
        private Label label288;
        private Label label289;
        private ComboBox cbBaction2;
        private ComboBox cbBaction1;
        private Label label291;
        private ComboBox cbCPPRHoldDate2;
        private ComboBox cbCPHoldDate2;
        private ComboBox cbCPPRHoldDate1;
        private ComboBox cbCPHoldDate1;
        private Label label189;
        private Label label190;
        private Label label191;
        private Label label192;
        private ComboBox cbCPaction2;
        private ComboBox cbCPaction1;
        private Button button1;
        private Label label194;
        private Label label195;
        private TextBox txtCPAmount3;
        private Label label196;
        private Label label197;
        private Label label198;
        private Label label199;
        private Label label200;
        private Label label201;
        private TextBox txtCPAmount2;
        private Label label202;
        private Label label203;
        private Label label204;
        private Label label292;
        private Label label293;
        private ComboBox cbContactCPPlace;
        private TextBox txtRemarkCP;
        private Label label294;
        private Label label295;
        private Label label296;
        private Label label297;
        private Label label298;
        private Button button10;
        private Label label299;
        private Button btncancel4;
        private ComboBox cbContactPersonCP;
        private Label label186;
        private Label label300;
        private Label lblActionCode;
        private Label label268;
        private Label lblactioncode2;
        private Button btnSendback;
        private Label lblSendback;
        private GroupBox grp_phone_remainder1;
        private ComboBox cbContactPersonPR;
        private ComboBox cbPRPRHoldDate2;
        private ComboBox cbPRHoldDate2;
        private ComboBox cbPRPRHoldDate1;
        private ComboBox cbPRHoldDate1;
        private Label label210;
        private Label label211;
        private Label label212;
        private Label label213;
        private ComboBox cbPRaction2;
        private ComboBox cbPRaction1;
        private Button button23;
        private Label label215;
        private Label label216;
        private TextBox txtPRAmount3;
        private Label label217;
        private Label label218;
        private Label label219;
        private Label label220;
        private Label label221;
        private Label label269;
        private TextBox txtPRAmount2;
        private Label label271;
        private Label label272;
        private Label label273;
        private Label label274;
        private Label label275;
        private ComboBox cbContactPRPlace;
        private TextBox txtRemarkPR;
        private Label label276;
        private Label label277;
        private Label label278;
        private Label label279;
        private Label label280;
        private Button button24;
        private Label label281;
        private Button button25;
        private Label label301;
        private Label label302;
        private Label label303;
        private Panel panel6;
        private GroupBox grpschedule;
        private Panel panel8;
        private Label label222;
        private RadioButton rbsameAgent;
        private RadioButton radioButton4;
        private Panel panel7;
        private TextBox txtPhone2;
        private TextBox txtPhone1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker callbackTime;
        private ComboBox TZComboBox;
        private Label label223;
        private TextBox txtMemo;
        private ComboBox cbSnooze;
        private Label label224;
        private ComboBox cbOutbound;
        private Label label225;
        private Label label226;
        private Label label227;
        private Label label228;
        private DateTimePicker callbackdate;
        private Button btnDisposisi;
        private TextBox txtDisposisiDesc;
        private GroupBox grpDial;
        private Button btnRecord;
        private Button btn3Way;
        private Button btnHold;
        private Button btnDial;
        private Button btnHangup;
        private TextBox txtdial;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label214;
        private Label label84;
        private Label label187;
        private Label label230;
        private Label label231;
        private Label label232;
        private Label label238;
        private Label label242;
        private Panel panel9;
        private Label label175;
        private Label label167;
        private Label label152;
        private Label label153;
        private Label label154;
        private Label label155;
        private Label label158;
        private Label label159;
        private Label label160;
        private Label label161;
        private GroupBox groupBox9;
        private Label label103;
        private Label label108;
        private Label label99;
        private Label label102;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label38;
        private GroupBox groupBox8;
        private Label label2;
        private Label label32;
        private Label label98;
        private Label label97;
        private Label label96;
        private Label label95;
        private Label label65;
        private Label label66;
        private Label label67;
        private GroupBox groupBox6;
        private Label lblServiceName3;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label128;
        private Label label129;
        private Label label130;
        private Label label131;
        private Label label132;
        private Label label133;
        private Label label134;
        private Label label135;
        private Label label136;
        private Label label137;
        private TextBox lblLoan1;
        private TextBox lblLoan3;
        private TextBox lblLoan2;
        private TextBox lblDPD1;
        private TextBox LblPrincipal1;
        private TextBox lblAmt;
        private TextBox lblPrincipal3;
        private TextBox lblDPD2;
        private TextBox lblCustName;
        private TextBox lblPrincipal2;
        private TextBox lblCustName1;
        private TextBox lblLoan4;
        private TextBox lblPother;
        private TextBox lblPoffice;
        private TextBox lblPhome;
        private TextBox lblRegion;
        private TextBox lblGender;
        private TextBox lblProduct;
        private TextBox lblDOB;
        private TextBox lblLoan6;
        private TextBox lblPother2;
        private TextBox lblPoffice2;
        private TextBox lblPhome2;
        private TextBox lblRegion2;
        private TextBox lblGender2;
        private TextBox lblProduct2;
        private TextBox lblDOB2;
        private TextBox lblCustomerName3;
        private TextBox lblDnis;
        private TextBox lblLoan7;
        private TextBox lblPother3;
        private TextBox lblPoffice3;
        private TextBox lblPhome3;
        private TextBox lblRegion3;
        private TextBox lblGender3;
        private TextBox lblProduct3;
        private TextBox lblDOB3;
        private TextBox lblCustomerName4;
        private TextBox lblDnis2;
        private TextBox lblPurpose;
        private TextBox lblSpecialStage;
        private TextBox lblCustId;
        private TextBox lblOrg;
        private TextBox lblzipcode;
        private TextBox lblPrincipal_additional2;
        private TextBox lblPrincipal_additional1;
        private TextBox lblDPD_additional2;
        private TextBox lblDPD_additional1;
        private TextBox lblLoad_additional2;
        private TextBox lblLoad_additional1;
        private TextBox lblAO_additional2;
        private TextBox lblAO_additional1;
        private TextBox lblACTION_CODE6;
        private TextBox lblACTION_CODE5;
        private TextBox lblACTION_CODE4;
        private TextBox lblACTION_CODE3;
        private TextBox lblACTION_CODE2;
        private TextBox lblACTION_CODE1;
        private TextBox lblAgent6_c;
        private TextBox lblAgent5_c;
        private TextBox lblAgent4_c;
        private TextBox lblAgent3_c;
        private TextBox lblAgent2_c;
        private TextBox lblDisp6_Id;
        private TextBox lblDisp5_Id;
        private TextBox lblDisp4_Id;
        private TextBox lblDisp3_Id;
        private TextBox lblDisp2_Id;
        private TextBox lblDisp1_Id;
        private TextBox lblCall6_dt;
        private TextBox lblCall5_dt;
        private TextBox lblCall4_dt;
        private TextBox lblCall3_dt;
        private TextBox lblCall2_dt;
        private TextBox lblCall1_dt;
        private TextBox lblCall6_Phone;
        private TextBox lblCall5_Phone;
        private TextBox lblCall4_Phone;
        private TextBox lblCall3_Phone;
        private TextBox lblCall2_Phone;
        private TextBox lblCall1_Phone;
        private TextBox lblAgent1_c;
        private TextBox textBox2;
        private TextBox lblACTION_CODE7;
        private TextBox lblCONTACTED_BY8;
        private TextBox lblCONTACTED_BY7;
        private TextBox lblCONTACTED_BY6;
        private TextBox lblCONTACTED_BY5;
        private TextBox lblCONTACTED_BY4;
        private TextBox lblCONTACTED_BY3;
        private TextBox lblCONTACTED_BY2;
        private TextBox lblCONTACTED_BY1;
        private TextBox lblCONTACT_DATE8;
        private TextBox lblCONTACT_DATE7;
        private TextBox lblCONTACT_DATE6;
        private TextBox lblCONTACT_DATE5;
        private TextBox lblCONTACT_DATE4;
        private TextBox lblCONTACT_DATE3;
        private TextBox lblCONTACT_DATE2;
        private TextBox lblCONTACT_DATE1;
        private TextBox lblCONTACT_PLACE8;
        private TextBox lblCONTACT_PLACE7;
        private TextBox lblCONTACT_PLACE6;
        private TextBox lblCONTACT_PLACE5;
        private TextBox lblCONTACT_PLACE4;
        private TextBox lblCONTACT_PLACE3;
        private TextBox lblCONTACT_PLACE2;
        private TextBox lblCONTACT_PLACE1;
        private TextBox lblPERSON_CONTACTED8;
        private TextBox lblPERSON_CONTACTED7;
        private TextBox lblPERSON_CONTACTED6;
        private TextBox lblPERSON_CONTACTED5;
        private TextBox lblPERSON_CONTACTED4;
        private TextBox lblPERSON_CONTACTED3;
        private TextBox lblPERSON_CONTACTED2;
        private TextBox lblPERSON_CONTACTED1;
        private TextBox lblREMARKS8;
        private TextBox lblREMARKS7;
        private TextBox lblREMARKS6;
        private TextBox lblREMARKS5;
        private TextBox lblREMARKS4;
        private TextBox lblREMARKS3;
        private TextBox lblREMARKS2;
        private TextBox lblREMARKS1;
        private TextBox lblMOBILE_P;
        private TextBox lblCONTACT2_P;
        private TextBox lblCITY_P;
        private TextBox lblCONTACT1_P;
        private TextBox lblALAMAT_P;
        private TextBox lblMOBILE_E;
        private TextBox lblCONTACT2_E;
        private TextBox lblCONTACT1_E;
        private TextBox lblCITY_E;
        private TextBox lblALAMAT_E;
        private TextBox lblMOBILE_O;
        private TextBox lblCONTACT2_O;
        private TextBox lblCONTACT1_O;
        private TextBox lblCITY_O;
        private TextBox lblALAMAT_O;
        private TextBox lblBucket3;
        private TextBox lblBucket2;
        private TextBox lblBucket1;
        private TextBox lblChargesOverdue;
        private TextBox lblInterestOverdue;
        private TextBox lblPrincipleOverdue;
        private TextBox lblAmountOverdue;
        private TextBox lblOutstanding;
        private Label label23;
        private TextBox lblInhouseScore;
        private TextBox lblForeClosure_amt1;
        private TextBox lblBilingCycle;
        private TextBox lblDPD4;
        private TextBox lblLastPaymentDate;
        private TextBox lblLastPaymentAmount;
        private TextBox lblOpenDate;
        private TextBox lblBucket7;
        private TextBox lblBucket6;
        private TextBox lblBucket5;
        private TextBox lblBucket4;
        private TextBox txtContactno;
        private GroupBox grpExclusion;
        private DateTimePicker startdate;
        private DateTimePicker enddate;
        private Label label233;
        private TextBox txtphoneEx;
        private ComboBox cbApplication;
        private ComboBox cbExclusionType;
        private ComboBox cbExclusionTimezone;
        private Label label208;
        private Label lblExclusionType;
        private Label label236;
        private Label label235;
        private Label label209;
        private TextBox lblLoanP3;
        private TextBox lblLoanP2;
        private TextBox lblLoanP1;
        private TextBox lblLoan10;
        private TextBox lblLoan9;
        private TextBox lblLoan8;
        private TextBox lblLoanP6;
        private TextBox lblLoanP5;
        private TextBox lblLoanP4;
        private TextBox lblLoanP9;
        private TextBox lblLoanP8;
        private TextBox lblLoanP7;
        private TextBox lblLoanP12;
        private TextBox lblLoanP11;
        private TextBox lblLoanP10;
        private ComboBox cbPRPRHoldDate0;
        private Label label237;
        private MultiColumnComboBoxDemo.MultiColumnComboBox cbDisposisi1;
        private Panel Detail3;
        private Panel Header33;
        private Label label244;
        private Label lblPlus3;
        private Panel Detail2;
        private Panel Header22;
        private Label label241;
        private Label lblPlus2;
        private Panel Detail1;
        private Panel Header11;
        private Label label290;
        private Label lblPlus1;
        private Panel pnlWrap;
        private Label lblWrapAction;
        private Label label234;
        private Label lbltimeWrap;
        private Label label229;
        private Panel pnlPreview;
        private Label lblPreview;
        private Label label193;
        private GroupBox groupBox7;
        private TextBox txtCallback;
        private TextBox txtDNISH;
        private TextBox txtphonenumberh;
        private TextBox txtName;
        private Label label188;
        private Label label71;
        private Label label43;
        private Label label39;
        private Panel pnlAnswerCall;
        private Label lblAnswerCallCountDown;
        private Button btnRejectCall;
        private Button btnAcceptCall;
        private TextBox txtmsg;
        private Panel grp_action;
        private Panel panel11;
        private Panel panel10;
        private Panel grp_phone_leave_message;
        private Panel grp_ptp;
        private Panel grp_with_borrower;
        private Panel grp_with_cp;
        private Panel grp_phone_not_answer;
        private Panel grp_phone_remainder;
        private Panel panel13;
        private Panel panel12;
        private Panel panel15;
        private Panel panel14;
        private Panel panel16;
        private Panel panel19;
        private Panel panel18;
        private Panel panel17;
        private Label label119;
        private Label label120;
        private PictureBox pictureBox1;
    }
}

