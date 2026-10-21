using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Security.Principal;
using ServiceStack;
using System.Collections.Generic;
using System.Globalization;

namespace SamplePortalClient.UI
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class FCallData1 : System.Windows.Forms.Form
	{
        private void InitializeComponent()
        {
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
            this.label120 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.lblDPD2 = new System.Windows.Forms.Label();
            this.lblPrincipal3 = new System.Windows.Forms.Label();
            this.lblLoan3 = new System.Windows.Forms.Label();
            this.lblDPD1 = new System.Windows.Forms.Label();
            this.lblPrincipal2 = new System.Windows.Forms.Label();
            this.LblPrincipal1 = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblLoan2 = new System.Windows.Forms.Label();
            this.lblLoan1 = new System.Windows.Forms.Label();
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
            this.grp_phone_disconected = new System.Windows.Forms.GroupBox();
            this.comboBox47 = new System.Windows.Forms.ComboBox();
            this.comboBox48 = new System.Windows.Forms.ComboBox();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.label274 = new System.Windows.Forms.Label();
            this.label275 = new System.Windows.Forms.Label();
            this.label276 = new System.Windows.Forms.Label();
            this.label277 = new System.Windows.Forms.Label();
            this.label278 = new System.Windows.Forms.Label();
            this.button43 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.label279 = new System.Windows.Forms.Label();
            this.label280 = new System.Windows.Forms.Label();
            this.label281 = new System.Windows.Forms.Label();
            this.grp_action = new System.Windows.Forms.GroupBox();
            this.grp_phone_busy = new System.Windows.Forms.GroupBox();
            this.comboBox45 = new System.Windows.Forms.ComboBox();
            this.comboBox46 = new System.Windows.Forms.ComboBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.label266 = new System.Windows.Forms.Label();
            this.label267 = new System.Windows.Forms.Label();
            this.label268 = new System.Windows.Forms.Label();
            this.label269 = new System.Windows.Forms.Label();
            this.label270 = new System.Windows.Forms.Label();
            this.button41 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.label271 = new System.Windows.Forms.Label();
            this.label272 = new System.Windows.Forms.Label();
            this.label273 = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.lblBucket7 = new System.Windows.Forms.Label();
            this.lblBucket6 = new System.Windows.Forms.Label();
            this.lblBucket5 = new System.Windows.Forms.Label();
            this.lblBucket4 = new System.Windows.Forms.Label();
            this.lblBucket3 = new System.Windows.Forms.Label();
            this.lblBucket2 = new System.Windows.Forms.Label();
            this.lblBucket1 = new System.Windows.Forms.Label();
            this.lblChargesOverdue = new System.Windows.Forms.Label();
            this.lblInterestOverdue = new System.Windows.Forms.Label();
            this.lblPrincipleOverdue = new System.Windows.Forms.Label();
            this.lblAmountOverdue = new System.Windows.Forms.Label();
            this.lblOutstanding = new System.Windows.Forms.Label();
            this.lblInhouseScore = new System.Windows.Forms.Label();
            this.lblForeClosure_amt1 = new System.Windows.Forms.Label();
            this.lblBilingCycle = new System.Windows.Forms.Label();
            this.lblDPD4 = new System.Windows.Forms.Label();
            this.lblLastPaymentDate = new System.Windows.Forms.Label();
            this.lblLastPaymentAmount = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.txtmsg = new System.Windows.Forms.TextBox();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPother = new System.Windows.Forms.Label();
            this.lblPoffice = new System.Windows.Forms.Label();
            this.lblPhome = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCustName1 = new System.Windows.Forms.Label();
            this.lblLoan4 = new System.Windows.Forms.Label();
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
            this.grp_phone_remainder = new System.Windows.Forms.GroupBox();
            this.comboBox30 = new System.Windows.Forms.ComboBox();
            this.label222 = new System.Windows.Forms.Label();
            this.button34 = new System.Windows.Forms.Button();
            this.label223 = new System.Windows.Forms.Label();
            this.comboBox31 = new System.Windows.Forms.ComboBox();
            this.comboBox32 = new System.Windows.Forms.ComboBox();
            this.label224 = new System.Windows.Forms.Label();
            this.comboBox33 = new System.Windows.Forms.ComboBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label225 = new System.Windows.Forms.Label();
            this.label226 = new System.Windows.Forms.Label();
            this.label227 = new System.Windows.Forms.Label();
            this.label228 = new System.Windows.Forms.Label();
            this.label229 = new System.Windows.Forms.Label();
            this.comboBox34 = new System.Windows.Forms.ComboBox();
            this.comboBox35 = new System.Windows.Forms.ComboBox();
            this.label230 = new System.Windows.Forms.Label();
            this.comboBox36 = new System.Windows.Forms.ComboBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label231 = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.label233 = new System.Windows.Forms.Label();
            this.label234 = new System.Windows.Forms.Label();
            this.label235 = new System.Windows.Forms.Label();
            this.comboBox37 = new System.Windows.Forms.ComboBox();
            this.comboBox38 = new System.Windows.Forms.ComboBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.label236 = new System.Windows.Forms.Label();
            this.label237 = new System.Windows.Forms.Label();
            this.label238 = new System.Windows.Forms.Label();
            this.label239 = new System.Windows.Forms.Label();
            this.label240 = new System.Windows.Forms.Label();
            this.button35 = new System.Windows.Forms.Button();
            this.label241 = new System.Windows.Forms.Label();
            this.button36 = new System.Windows.Forms.Button();
            this.label242 = new System.Windows.Forms.Label();
            this.label243 = new System.Windows.Forms.Label();
            this.label244 = new System.Windows.Forms.Label();
            this.grp_phone_not_answer = new System.Windows.Forms.GroupBox();
            this.comboBox39 = new System.Windows.Forms.ComboBox();
            this.comboBox40 = new System.Windows.Forms.ComboBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
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
            this.grp_phone_leave_message = new System.Windows.Forms.GroupBox();
            this.comboBox41 = new System.Windows.Forms.ComboBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.label253 = new System.Windows.Forms.Label();
            this.label254 = new System.Windows.Forms.Label();
            this.comboBox42 = new System.Windows.Forms.ComboBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.label255 = new System.Windows.Forms.Label();
            this.label256 = new System.Windows.Forms.Label();
            this.comboBox43 = new System.Windows.Forms.ComboBox();
            this.comboBox44 = new System.Windows.Forms.ComboBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.label257 = new System.Windows.Forms.Label();
            this.label258 = new System.Windows.Forms.Label();
            this.label259 = new System.Windows.Forms.Label();
            this.label260 = new System.Windows.Forms.Label();
            this.label261 = new System.Windows.Forms.Label();
            this.button39 = new System.Windows.Forms.Button();
            this.label262 = new System.Windows.Forms.Label();
            this.button40 = new System.Windows.Forms.Button();
            this.label263 = new System.Windows.Forms.Label();
            this.label264 = new System.Windows.Forms.Label();
            this.label265 = new System.Windows.Forms.Label();
            this.grp_with_borrower = new System.Windows.Forms.GroupBox();
            this.button25 = new System.Windows.Forms.Button();
            this.label140 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label141 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label149 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label150 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.button26 = new System.Windows.Forms.Button();
            this.label182 = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.grp_ptp = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.button24 = new System.Windows.Forms.Button();
            this.label82 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.grp_with_cp = new System.Windows.Forms.GroupBox();
            this.button28 = new System.Windows.Forms.Button();
            this.label186 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.label187 = new System.Windows.Forms.Label();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.label193 = new System.Windows.Forms.Label();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label199 = new System.Windows.Forms.Label();
            this.label200 = new System.Windows.Forms.Label();
            this.label201 = new System.Windows.Forms.Label();
            this.label202 = new System.Windows.Forms.Label();
            this.label203 = new System.Windows.Forms.Label();
            this.button29 = new System.Windows.Forms.Button();
            this.label204 = new System.Windows.Forms.Label();
            this.button30 = new System.Windows.Forms.Button();
            this.label205 = new System.Windows.Forms.Label();
            this.label206 = new System.Windows.Forms.Label();
            this.label207 = new System.Windows.Forms.Label();
            this.grp_other_phone = new System.Windows.Forms.GroupBox();
            this.button31 = new System.Windows.Forms.Button();
            this.label208 = new System.Windows.Forms.Label();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.label209 = new System.Windows.Forms.Label();
            this.label210 = new System.Windows.Forms.Label();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label211 = new System.Windows.Forms.Label();
            this.label212 = new System.Windows.Forms.Label();
            this.comboBox28 = new System.Windows.Forms.ComboBox();
            this.comboBox29 = new System.Windows.Forms.ComboBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label213 = new System.Windows.Forms.Label();
            this.label214 = new System.Windows.Forms.Label();
            this.label215 = new System.Windows.Forms.Label();
            this.label216 = new System.Windows.Forms.Label();
            this.label217 = new System.Windows.Forms.Label();
            this.button32 = new System.Windows.Forms.Button();
            this.label218 = new System.Windows.Forms.Label();
            this.button33 = new System.Windows.Forms.Button();
            this.label219 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.label221 = new System.Windows.Forms.Label();
            this.infoTabPage = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblREMARKS8 = new System.Windows.Forms.Label();
            this.lblREMARKS7 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY8 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY7 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED8 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED7 = new System.Windows.Forms.Label();
            this.lblACTION_CODE8 = new System.Windows.Forms.Label();
            this.lblACTION_CODE7 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE8 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE7 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE8 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE7 = new System.Windows.Forms.Label();
            this.lblREMARKS6 = new System.Windows.Forms.Label();
            this.lblREMARKS5 = new System.Windows.Forms.Label();
            this.lblREMARKS4 = new System.Windows.Forms.Label();
            this.lblREMARKS3 = new System.Windows.Forms.Label();
            this.lblREMARKS2 = new System.Windows.Forms.Label();
            this.lblREMARKS1 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY6 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY5 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY4 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY3 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY2 = new System.Windows.Forms.Label();
            this.lblCONTACTED_BY1 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED6 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED5 = new System.Windows.Forms.Label();
            this.lblACTION_CODE6 = new System.Windows.Forms.Label();
            this.lblACTION_CODE5 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE6 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE5 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE6 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE5 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED4 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED3 = new System.Windows.Forms.Label();
            this.lblACTION_CODE4 = new System.Windows.Forms.Label();
            this.lblACTION_CODE3 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE4 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE3 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE4 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE3 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED2 = new System.Windows.Forms.Label();
            this.lblPERSON_CONTACTED1 = new System.Windows.Forms.Label();
            this.lblACTION_CODE2 = new System.Windows.Forms.Label();
            this.lblACTION_CODE1 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE2 = new System.Windows.Forms.Label();
            this.lblCONTACT_PLACE1 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE2 = new System.Windows.Forms.Label();
            this.lblCONTACT_DATE1 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblDisp6_Id = new System.Windows.Forms.Label();
            this.lblDisp5_Id = new System.Windows.Forms.Label();
            this.lblAgent6_c = new System.Windows.Forms.Label();
            this.lblAgent5_c = new System.Windows.Forms.Label();
            this.lblCall6_dt = new System.Windows.Forms.Label();
            this.lblCall5_dt = new System.Windows.Forms.Label();
            this.lblCall6_Phone = new System.Windows.Forms.Label();
            this.lblCall5_Phone = new System.Windows.Forms.Label();
            this.lblDisp4_Id = new System.Windows.Forms.Label();
            this.lblDisp3_Id = new System.Windows.Forms.Label();
            this.lblAgent4_c = new System.Windows.Forms.Label();
            this.lblAgent3_c = new System.Windows.Forms.Label();
            this.lblCall4_dt = new System.Windows.Forms.Label();
            this.lblCall3_dt = new System.Windows.Forms.Label();
            this.lblCall4_Phone = new System.Windows.Forms.Label();
            this.lblCall3_Phone = new System.Windows.Forms.Label();
            this.lblDisp2_Id = new System.Windows.Forms.Label();
            this.lblDisp1_Id = new System.Windows.Forms.Label();
            this.lblAgent2_c = new System.Windows.Forms.Label();
            this.lblAgent1_c = new System.Windows.Forms.Label();
            this.lblCall2_dt = new System.Windows.Forms.Label();
            this.lblCall1_dt = new System.Windows.Forms.Label();
            this.lblCall2_Phone = new System.Windows.Forms.Label();
            this.lblCall1_Phone = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblAO_additional2 = new System.Windows.Forms.Label();
            this.lblAO_additional1 = new System.Windows.Forms.Label();
            this.lblPrincipal_additional2 = new System.Windows.Forms.Label();
            this.lblPrincipal_additional1 = new System.Windows.Forms.Label();
            this.lblDPD_additional2 = new System.Windows.Forms.Label();
            this.lblDPD_additional1 = new System.Windows.Forms.Label();
            this.lblLoad_additional2 = new System.Windows.Forms.Label();
            this.lblLoad_additional1 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblaccno = new System.Windows.Forms.Label();
            this.lblPother2 = new System.Windows.Forms.Label();
            this.lblPoffice2 = new System.Windows.Forms.Label();
            this.lblPhome2 = new System.Windows.Forms.Label();
            this.lblRegion2 = new System.Windows.Forms.Label();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.lblProduct2 = new System.Windows.Forms.Label();
            this.lblDOB2 = new System.Windows.Forms.Label();
            this.lblCustomerName3 = new System.Windows.Forms.Label();
            this.lblLoan6 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
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
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.lblMOBILE_O = new System.Windows.Forms.Label();
            this.lblMOBILE_E = new System.Windows.Forms.Label();
            this.lblMOBILE_P = new System.Windows.Forms.Label();
            this.lblCONTACT2_O = new System.Windows.Forms.Label();
            this.lblCONTACT1_O = new System.Windows.Forms.Label();
            this.lblCONTACT2_E = new System.Windows.Forms.Label();
            this.lblCONTACT1_E = new System.Windows.Forms.Label();
            this.lblCONTACT2_P = new System.Windows.Forms.Label();
            this.lblCONTACT1_P = new System.Windows.Forms.Label();
            this.lblCITY_O = new System.Windows.Forms.Label();
            this.lblALAMAT_O = new System.Windows.Forms.Label();
            this.lblCITY_E = new System.Windows.Forms.Label();
            this.lblALAMAT_E = new System.Windows.Forms.Label();
            this.lblCITY_P = new System.Windows.Forms.Label();
            this.lblALAMAT_P = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.lblPother3 = new System.Windows.Forms.Label();
            this.lblPoffice3 = new System.Windows.Forms.Label();
            this.lblPhome3 = new System.Windows.Forms.Label();
            this.lblRegion3 = new System.Windows.Forms.Label();
            this.lblGender3 = new System.Windows.Forms.Label();
            this.lblProduct3 = new System.Windows.Forms.Label();
            this.lblDOB3 = new System.Windows.Forms.Label();
            this.lblCustomerName4 = new System.Windows.Forms.Label();
            this.lblLoan7 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
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
            this.mainTabControl.SuspendLayout();
            this.homeTabPage.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dialerTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grp_phone_disconected.SuspendLayout();
            this.grp_action.SuspendLayout();
            this.grp_phone_busy.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grp_phone_remainder.SuspendLayout();
            this.grp_phone_not_answer.SuspendLayout();
            this.grp_phone_leave_message.SuspendLayout();
            this.grp_with_borrower.SuspendLayout();
            this.grp_ptp.SuspendLayout();
            this.grp_with_cp.SuspendLayout();
            this.grp_other_phone.SuspendLayout();
            this.infoTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.customerTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.homeTabPage);
            this.mainTabControl.Controls.Add(this.dialerTabPage);
            this.mainTabControl.Controls.Add(this.infoTabPage);
            this.mainTabControl.Controls.Add(this.customerTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.Padding = new System.Drawing.Point(20, 10);
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1234, 561);
            this.mainTabControl.TabIndex = 0;
            // 
            // homeTabPage
            // 
            this.homeTabPage.BackColor = System.Drawing.Color.White;
            this.homeTabPage.Controls.Add(this.panel4);
            this.homeTabPage.Location = new System.Drawing.Point(4, 39);
            this.homeTabPage.Name = "homeTabPage";
            this.homeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.homeTabPage.Size = new System.Drawing.Size(1226, 518);
            this.homeTabPage.TabIndex = 0;
            this.homeTabPage.Text = "Home";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1220, 512);
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
            this.groupBox3.Location = new System.Drawing.Point(9, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1206, 94);
            this.groupBox3.TabIndex = 264;
            this.groupBox3.TabStop = false;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(219, 21);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(51, 18);
            this.lblServiceName.TabIndex = 265;
            this.lblServiceName.Text = "Loan1";
            // 
            // lblservicecaption
            // 
            this.lblservicecaption.AutoSize = true;
            this.lblservicecaption.BackColor = System.Drawing.Color.SandyBrown;
            this.lblservicecaption.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblservicecaption.Location = new System.Drawing.Point(11, 21);
            this.lblservicecaption.Name = "lblservicecaption";
            this.lblservicecaption.Size = new System.Drawing.Size(107, 18);
            this.lblservicecaption.TabIndex = 264;
            this.lblservicecaption.Text = "Service Name";
            // 
            // label107
            // 
            this.label107.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label107.BackColor = System.Drawing.Color.Yellow;
            this.label107.Location = new System.Drawing.Point(207, 17);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(988, 25);
            this.label107.TabIndex = 263;
            this.label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(366, 56);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 262;
            this.button8.Text = "Others";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(285, 56);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 261;
            this.button7.Text = "Office";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(204, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 260;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.AllowDrop = true;
            this.button12.AutoEllipsis = true;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.Location = new System.Drawing.Point(123, 56);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 259;
            this.button12.Text = "Mobile";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(8, 56);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(73, 16);
            this.label124.TabIndex = 258;
            this.label124.Text = "Contact No";
            // 
            // label117
            // 
            this.label117.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label117.BackColor = System.Drawing.Color.SandyBrown;
            this.label117.Location = new System.Drawing.Point(8, 17);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(415, 25);
            this.label117.TabIndex = 266;
            this.label117.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label120);
            this.groupBox2.Controls.Add(this.label119);
            this.groupBox2.Controls.Add(this.label118);
            this.groupBox2.Controls.Add(this.label116);
            this.groupBox2.Controls.Add(this.label115);
            this.groupBox2.Controls.Add(this.lblDPD2);
            this.groupBox2.Controls.Add(this.lblPrincipal3);
            this.groupBox2.Controls.Add(this.lblLoan3);
            this.groupBox2.Controls.Add(this.lblDPD1);
            this.groupBox2.Controls.Add(this.lblPrincipal2);
            this.groupBox2.Controls.Add(this.LblPrincipal1);
            this.groupBox2.Controls.Add(this.lblAmt);
            this.groupBox2.Controls.Add(this.lblCustName);
            this.groupBox2.Controls.Add(this.lblLoan2);
            this.groupBox2.Controls.Add(this.lblLoan1);
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
            this.groupBox2.Location = new System.Drawing.Point(9, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1206, 261);
            this.groupBox2.TabIndex = 263;
            this.groupBox2.TabStop = false;
            // 
            // label120
            // 
            this.label120.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label120.BackColor = System.Drawing.Color.Silver;
            this.label120.Location = new System.Drawing.Point(812, 21);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(6, 219);
            this.label120.TabIndex = 287;
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label119
            // 
            this.label119.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label119.BackColor = System.Drawing.Color.Silver;
            this.label119.Location = new System.Drawing.Point(407, 21);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(6, 219);
            this.label119.TabIndex = 286;
            this.label119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label118
            // 
            this.label118.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label118.BackColor = System.Drawing.Color.Red;
            this.label118.Location = new System.Drawing.Point(818, 21);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(370, 25);
            this.label118.TabIndex = 285;
            this.label118.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label116
            // 
            this.label116.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label116.BackColor = System.Drawing.Color.SandyBrown;
            this.label116.Location = new System.Drawing.Point(413, 21);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(400, 25);
            this.label116.TabIndex = 284;
            this.label116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label115
            // 
            this.label115.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label115.BackColor = System.Drawing.Color.Olive;
            this.label115.Location = new System.Drawing.Point(7, 21);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(400, 25);
            this.label115.TabIndex = 283;
            this.label115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDPD2
            // 
            this.lblDPD2.AutoSize = true;
            this.lblDPD2.Location = new System.Drawing.Point(946, 122);
            this.lblDPD2.Name = "lblDPD2";
            this.lblDPD2.Size = new System.Drawing.Size(36, 16);
            this.lblDPD2.TabIndex = 282;
            this.lblDPD2.Text = "DPD";
            // 
            // lblPrincipal3
            // 
            this.lblPrincipal3.AutoSize = true;
            this.lblPrincipal3.Location = new System.Drawing.Point(946, 86);
            this.lblPrincipal3.Name = "lblPrincipal3";
            this.lblPrincipal3.Size = new System.Drawing.Size(114, 16);
            this.lblPrincipal3.TabIndex = 281;
            this.lblPrincipal3.Text = "Principle Overdue";
            // 
            // lblLoan3
            // 
            this.lblLoan3.AutoSize = true;
            this.lblLoan3.Location = new System.Drawing.Point(946, 61);
            this.lblLoan3.Name = "lblLoan3";
            this.lblLoan3.Size = new System.Drawing.Size(44, 16);
            this.lblLoan3.TabIndex = 280;
            this.lblLoan3.Text = "Loan2";
            // 
            // lblDPD1
            // 
            this.lblDPD1.AutoSize = true;
            this.lblDPD1.Location = new System.Drawing.Point(537, 122);
            this.lblDPD1.Name = "lblDPD1";
            this.lblDPD1.Size = new System.Drawing.Size(36, 16);
            this.lblDPD1.TabIndex = 279;
            this.lblDPD1.Text = "DPD";
            // 
            // lblPrincipal2
            // 
            this.lblPrincipal2.AutoSize = true;
            this.lblPrincipal2.Location = new System.Drawing.Point(537, 86);
            this.lblPrincipal2.Name = "lblPrincipal2";
            this.lblPrincipal2.Size = new System.Drawing.Size(114, 16);
            this.lblPrincipal2.TabIndex = 278;
            this.lblPrincipal2.Text = "Principle Overdue";
            // 
            // LblPrincipal1
            // 
            this.LblPrincipal1.AutoSize = true;
            this.LblPrincipal1.Location = new System.Drawing.Point(134, 147);
            this.LblPrincipal1.Name = "LblPrincipal1";
            this.LblPrincipal1.Size = new System.Drawing.Size(114, 16);
            this.LblPrincipal1.TabIndex = 277;
            this.LblPrincipal1.Text = "Principle Overdue";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(134, 122);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(102, 16);
            this.lblAmt.TabIndex = 276;
            this.lblAmt.Text = "For Closure Amt";
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(134, 86);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(268, 31);
            this.lblCustName.TabIndex = 275;
            this.lblCustName.Text = "Customer Name";
            // 
            // lblLoan2
            // 
            this.lblLoan2.AutoSize = true;
            this.lblLoan2.Location = new System.Drawing.Point(537, 61);
            this.lblLoan2.Name = "lblLoan2";
            this.lblLoan2.Size = new System.Drawing.Size(44, 16);
            this.lblLoan2.TabIndex = 274;
            this.lblLoan2.Text = "Loan2";
            // 
            // lblLoan1
            // 
            this.lblLoan1.AutoSize = true;
            this.lblLoan1.Location = new System.Drawing.Point(134, 61);
            this.lblLoan1.Name = "lblLoan1";
            this.lblLoan1.Size = new System.Drawing.Size(44, 16);
            this.lblLoan1.TabIndex = 273;
            this.lblLoan1.Text = "Loan1";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(828, 122);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(36, 16);
            this.label58.TabIndex = 272;
            this.label58.Text = "DPD";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(828, 86);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(114, 16);
            this.label59.TabIndex = 271;
            this.label59.Text = "Principle Overdue";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(428, 122);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(36, 16);
            this.label57.TabIndex = 270;
            this.label57.Text = "DPD";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(428, 86);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(114, 16);
            this.label56.TabIndex = 269;
            this.label56.Text = "Principle Overdue";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(828, 61);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(88, 16);
            this.label77.TabIndex = 268;
            this.label77.Text = "Loan Number";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(428, 61);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(88, 16);
            this.label100.TabIndex = 267;
            this.label100.Text = "Loan Number";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(13, 147);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(114, 16);
            this.label101.TabIndex = 266;
            this.label101.Text = "Principle Overdue";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(13, 122);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(102, 16);
            this.label104.TabIndex = 265;
            this.label104.Text = "For Closure Amt";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(13, 86);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(104, 16);
            this.label105.TabIndex = 264;
            this.label105.Text = "Customer Name";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(13, 61);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(88, 16);
            this.label106.TabIndex = 263;
            this.label106.Text = "Loan Number";
            // 
            // dialerTabPage
            // 
            this.dialerTabPage.BackColor = System.Drawing.Color.White;
            this.dialerTabPage.Controls.Add(this.panel1);
            this.dialerTabPage.Location = new System.Drawing.Point(4, 39);
            this.dialerTabPage.Name = "dialerTabPage";
            this.dialerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dialerTabPage.Size = new System.Drawing.Size(1226, 518);
            this.dialerTabPage.TabIndex = 1;
            this.dialerTabPage.Text = "Dealer Contact Recording";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.grp_phone_disconected);
            this.panel1.Controls.Add(this.grp_action);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.grp_phone_remainder);
            this.panel1.Controls.Add(this.grp_phone_not_answer);
            this.panel1.Controls.Add(this.grp_phone_leave_message);
            this.panel1.Controls.Add(this.grp_with_borrower);
            this.panel1.Controls.Add(this.grp_ptp);
            this.panel1.Controls.Add(this.grp_with_cp);
            this.panel1.Controls.Add(this.grp_other_phone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 512);
            this.panel1.TabIndex = 1;
            // 
            // grp_phone_disconected
            // 
            this.grp_phone_disconected.Controls.Add(this.comboBox47);
            this.grp_phone_disconected.Controls.Add(this.comboBox48);
            this.grp_phone_disconected.Controls.Add(this.textBox67);
            this.grp_phone_disconected.Controls.Add(this.textBox68);
            this.grp_phone_disconected.Controls.Add(this.textBox69);
            this.grp_phone_disconected.Controls.Add(this.label274);
            this.grp_phone_disconected.Controls.Add(this.label275);
            this.grp_phone_disconected.Controls.Add(this.label276);
            this.grp_phone_disconected.Controls.Add(this.label277);
            this.grp_phone_disconected.Controls.Add(this.label278);
            this.grp_phone_disconected.Controls.Add(this.button43);
            this.grp_phone_disconected.Controls.Add(this.button44);
            this.grp_phone_disconected.Controls.Add(this.label279);
            this.grp_phone_disconected.Controls.Add(this.label280);
            this.grp_phone_disconected.Controls.Add(this.label281);
            this.grp_phone_disconected.Location = new System.Drawing.Point(-5, 478);
            this.grp_phone_disconected.Name = "grp_phone_disconected";
            this.grp_phone_disconected.Size = new System.Drawing.Size(1204, 298);
            this.grp_phone_disconected.TabIndex = 316;
            this.grp_phone_disconected.TabStop = false;
            // 
            // comboBox47
            // 
            this.comboBox47.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox47.FormattingEnabled = true;
            this.comboBox47.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox47.Location = new System.Drawing.Point(176, 133);
            this.comboBox47.Name = "comboBox47";
            this.comboBox47.Size = new System.Drawing.Size(153, 24);
            this.comboBox47.TabIndex = 356;
            // 
            // comboBox48
            // 
            this.comboBox48.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox48.FormattingEnabled = true;
            this.comboBox48.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox48.Location = new System.Drawing.Point(176, 105);
            this.comboBox48.Name = "comboBox48";
            this.comboBox48.Size = new System.Drawing.Size(153, 24);
            this.comboBox48.TabIndex = 355;
            // 
            // textBox67
            // 
            this.textBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox67.Location = new System.Drawing.Point(176, 163);
            this.textBox67.Name = "textBox67";
            this.textBox67.Size = new System.Drawing.Size(153, 22);
            this.textBox67.TabIndex = 354;
            // 
            // textBox68
            // 
            this.textBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox68.Location = new System.Drawing.Point(176, 77);
            this.textBox68.Name = "textBox68";
            this.textBox68.Size = new System.Drawing.Size(153, 22);
            this.textBox68.TabIndex = 353;
            // 
            // textBox69
            // 
            this.textBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox69.Location = new System.Drawing.Point(176, 49);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(153, 22);
            this.textBox69.TabIndex = 352;
            // 
            // label274
            // 
            this.label274.AutoSize = true;
            this.label274.Location = new System.Drawing.Point(12, 163);
            this.label274.Name = "label274";
            this.label274.Size = new System.Drawing.Size(62, 16);
            this.label274.TabIndex = 351;
            this.label274.Text = "Remarks";
            // 
            // label275
            // 
            this.label275.AutoSize = true;
            this.label275.Location = new System.Drawing.Point(12, 133);
            this.label275.Name = "label275";
            this.label275.Size = new System.Drawing.Size(98, 16);
            this.label275.TabIndex = 350;
            this.label275.Text = "Contact Person";
            // 
            // label276
            // 
            this.label276.AutoSize = true;
            this.label276.Location = new System.Drawing.Point(12, 105);
            this.label276.Name = "label276";
            this.label276.Size = new System.Drawing.Size(90, 16);
            this.label276.TabIndex = 349;
            this.label276.Text = "Contact Place";
            // 
            // label277
            // 
            this.label277.AutoSize = true;
            this.label277.Location = new System.Drawing.Point(12, 77);
            this.label277.Name = "label277";
            this.label277.Size = new System.Drawing.Size(90, 16);
            this.label277.TabIndex = 348;
            this.label277.Text = "Contact Mode";
            // 
            // label278
            // 
            this.label278.AutoSize = true;
            this.label278.Location = new System.Drawing.Point(12, 49);
            this.label278.Name = "label278";
            this.label278.Size = new System.Drawing.Size(193, 16);
            this.label278.TabIndex = 347;
            this.label278.Text = "Action Code / Disposition Code";
            // 
            // button43
            // 
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Location = new System.Drawing.Point(176, 197);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(92, 23);
            this.button43.TabIndex = 346;
            this.button43.Text = "Save Activity";
            this.button43.UseVisualStyleBackColor = true;
            // 
            // button44
            // 
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Location = new System.Drawing.Point(276, 197);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(75, 23);
            this.button44.TabIndex = 345;
            this.button44.Text = "Cancel";
            this.button44.UseVisualStyleBackColor = true;
            this.button44.Click += new System.EventHandler(this.button44_Click_1);
            // 
            // label279
            // 
            this.label279.AutoSize = true;
            this.label279.BackColor = System.Drawing.Color.SandyBrown;
            this.label279.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label279.Location = new System.Drawing.Point(12, 21);
            this.label279.Name = "label279";
            this.label279.Size = new System.Drawing.Size(54, 18);
            this.label279.TabIndex = 303;
            this.label279.Text = "Result";
            // 
            // label280
            // 
            this.label280.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label280.BackColor = System.Drawing.Color.Yellow;
            this.label280.Location = new System.Drawing.Point(211, 16);
            this.label280.Name = "label280";
            this.label280.Size = new System.Drawing.Size(975, 25);
            this.label280.TabIndex = 301;
            this.label280.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label281
            // 
            this.label281.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label281.BackColor = System.Drawing.Color.SandyBrown;
            this.label281.Location = new System.Drawing.Point(7, 16);
            this.label281.Name = "label281";
            this.label281.Size = new System.Drawing.Size(313, 25);
            this.label281.TabIndex = 302;
            this.label281.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_action
            // 
            this.grp_action.Controls.Add(this.grp_phone_busy);
            this.grp_action.Controls.Add(this.label31);
            this.grp_action.Controls.Add(this.label125);
            this.grp_action.Controls.Add(this.label157);
            this.grp_action.Controls.Add(this.button18);
            this.grp_action.Controls.Add(this.button17);
            this.grp_action.Controls.Add(this.button16);
            this.grp_action.Controls.Add(this.button15);
            this.grp_action.Controls.Add(this.button14);
            this.grp_action.Controls.Add(this.button13);
            this.grp_action.Controls.Add(this.button11);
            this.grp_action.Controls.Add(this.button9);
            this.grp_action.Controls.Add(this.button5);
            this.grp_action.Controls.Add(this.label37);
            this.grp_action.Controls.Add(this.button4);
            this.grp_action.Controls.Add(this.label36);
            this.grp_action.Controls.Add(this.button3);
            this.grp_action.Controls.Add(this.label35);
            this.grp_action.Controls.Add(this.button2);
            this.grp_action.Controls.Add(this.label34);
            this.grp_action.Controls.Add(this.button1);
            this.grp_action.Controls.Add(this.label33);
            this.grp_action.Location = new System.Drawing.Point(1, 478);
            this.grp_action.Name = "grp_action";
            this.grp_action.Size = new System.Drawing.Size(1190, 226);
            this.grp_action.TabIndex = 311;
            this.grp_action.TabStop = false;
            // 
            // grp_phone_busy
            // 
            this.grp_phone_busy.Controls.Add(this.comboBox45);
            this.grp_phone_busy.Controls.Add(this.comboBox46);
            this.grp_phone_busy.Controls.Add(this.textBox64);
            this.grp_phone_busy.Controls.Add(this.textBox65);
            this.grp_phone_busy.Controls.Add(this.textBox66);
            this.grp_phone_busy.Controls.Add(this.label266);
            this.grp_phone_busy.Controls.Add(this.label267);
            this.grp_phone_busy.Controls.Add(this.label268);
            this.grp_phone_busy.Controls.Add(this.label269);
            this.grp_phone_busy.Controls.Add(this.label270);
            this.grp_phone_busy.Controls.Add(this.button41);
            this.grp_phone_busy.Controls.Add(this.button42);
            this.grp_phone_busy.Controls.Add(this.label271);
            this.grp_phone_busy.Controls.Add(this.label272);
            this.grp_phone_busy.Controls.Add(this.label273);
            this.grp_phone_busy.Location = new System.Drawing.Point(0, 2);
            this.grp_phone_busy.Name = "grp_phone_busy";
            this.grp_phone_busy.Size = new System.Drawing.Size(1202, 292);
            this.grp_phone_busy.TabIndex = 309;
            this.grp_phone_busy.TabStop = false;
            // 
            // comboBox45
            // 
            this.comboBox45.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox45.FormattingEnabled = true;
            this.comboBox45.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox45.Location = new System.Drawing.Point(176, 133);
            this.comboBox45.Name = "comboBox45";
            this.comboBox45.Size = new System.Drawing.Size(153, 24);
            this.comboBox45.TabIndex = 356;
            // 
            // comboBox46
            // 
            this.comboBox46.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox46.FormattingEnabled = true;
            this.comboBox46.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox46.Location = new System.Drawing.Point(176, 105);
            this.comboBox46.Name = "comboBox46";
            this.comboBox46.Size = new System.Drawing.Size(153, 24);
            this.comboBox46.TabIndex = 355;
            // 
            // textBox64
            // 
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox64.Location = new System.Drawing.Point(176, 163);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(153, 22);
            this.textBox64.TabIndex = 354;
            // 
            // textBox65
            // 
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox65.Location = new System.Drawing.Point(176, 77);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(153, 22);
            this.textBox65.TabIndex = 353;
            // 
            // textBox66
            // 
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox66.Location = new System.Drawing.Point(176, 49);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(153, 22);
            this.textBox66.TabIndex = 352;
            // 
            // label266
            // 
            this.label266.AutoSize = true;
            this.label266.Location = new System.Drawing.Point(12, 163);
            this.label266.Name = "label266";
            this.label266.Size = new System.Drawing.Size(62, 16);
            this.label266.TabIndex = 351;
            this.label266.Text = "Remarks";
            // 
            // label267
            // 
            this.label267.AutoSize = true;
            this.label267.Location = new System.Drawing.Point(12, 133);
            this.label267.Name = "label267";
            this.label267.Size = new System.Drawing.Size(98, 16);
            this.label267.TabIndex = 350;
            this.label267.Text = "Contact Person";
            // 
            // label268
            // 
            this.label268.AutoSize = true;
            this.label268.Location = new System.Drawing.Point(12, 105);
            this.label268.Name = "label268";
            this.label268.Size = new System.Drawing.Size(90, 16);
            this.label268.TabIndex = 349;
            this.label268.Text = "Contact Place";
            // 
            // label269
            // 
            this.label269.AutoSize = true;
            this.label269.Location = new System.Drawing.Point(12, 77);
            this.label269.Name = "label269";
            this.label269.Size = new System.Drawing.Size(90, 16);
            this.label269.TabIndex = 348;
            this.label269.Text = "Contact Mode";
            // 
            // label270
            // 
            this.label270.AutoSize = true;
            this.label270.Location = new System.Drawing.Point(12, 49);
            this.label270.Name = "label270";
            this.label270.Size = new System.Drawing.Size(193, 16);
            this.label270.TabIndex = 347;
            this.label270.Text = "Action Code / Disposition Code";
            // 
            // button41
            // 
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Location = new System.Drawing.Point(176, 201);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(92, 23);
            this.button41.TabIndex = 346;
            this.button41.Text = "Save Activity";
            this.button41.UseVisualStyleBackColor = true;
            // 
            // button42
            // 
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Location = new System.Drawing.Point(279, 201);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(75, 23);
            this.button42.TabIndex = 345;
            this.button42.Text = "Cancel";
            this.button42.UseVisualStyleBackColor = true;
            this.button42.Click += new System.EventHandler(this.button42_Click);
            // 
            // label271
            // 
            this.label271.AutoSize = true;
            this.label271.BackColor = System.Drawing.Color.SandyBrown;
            this.label271.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label271.Location = new System.Drawing.Point(12, 21);
            this.label271.Name = "label271";
            this.label271.Size = new System.Drawing.Size(54, 18);
            this.label271.TabIndex = 303;
            this.label271.Text = "Result";
            // 
            // label272
            // 
            this.label272.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label272.BackColor = System.Drawing.Color.Yellow;
            this.label272.Location = new System.Drawing.Point(211, 16);
            this.label272.Name = "label272";
            this.label272.Size = new System.Drawing.Size(973, 25);
            this.label272.TabIndex = 301;
            this.label272.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label273
            // 
            this.label273.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label273.BackColor = System.Drawing.Color.SandyBrown;
            this.label273.Location = new System.Drawing.Point(7, 16);
            this.label273.Name = "label273";
            this.label273.Size = new System.Drawing.Size(311, 25);
            this.label273.TabIndex = 302;
            this.label273.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.SandyBrown;
            this.label31.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(12, 21);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(54, 18);
            this.label31.TabIndex = 303;
            this.label31.Text = "Result";
            // 
            // label125
            // 
            this.label125.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label125.BackColor = System.Drawing.Color.Yellow;
            this.label125.Location = new System.Drawing.Point(211, 16);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(961, 25);
            this.label125.TabIndex = 301;
            this.label125.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label157
            // 
            this.label157.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label157.BackColor = System.Drawing.Color.SandyBrown;
            this.label157.Location = new System.Drawing.Point(7, 16);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(299, 25);
            this.label157.TabIndex = 302;
            this.label157.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button18
            // 
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(582, 140);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(133, 23);
            this.button18.TabIndex = 186;
            this.button18.Text = "Acc tidak layak tagih";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(443, 140);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(133, 23);
            this.button17.TabIndex = 185;
            this.button17.Text = "Customer Decease";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(304, 141);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(133, 23);
            this.button16.TabIndex = 184;
            this.button16.Text = "Sent to FC";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(721, 111);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(133, 23);
            this.button15.TabIndex = 183;
            this.button15.Text = "Phone No Answer";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // button14
            // 
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(582, 111);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(133, 23);
            this.button14.TabIndex = 182;
            this.button14.Text = "Phone Disconnected";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button13
            // 
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(443, 111);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 23);
            this.button13.TabIndex = 181;
            this.button13.Text = "Phone Busy";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // button11
            // 
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(304, 111);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 23);
            this.button11.TabIndex = 180;
            this.button11.Text = "Phone Leave Message";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // button9
            // 
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(304, 81);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 23);
            this.button9.TabIndex = 179;
            this.button9.Text = "Contact With CP";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(165, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 178;
            this.button5.Text = "Phone Reminder";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 171);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(108, 16);
            this.label37.TabIndex = 177;
            this.label37.Text = "Phone Reminder";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(165, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 176;
            this.button4.Text = "Case / Complain";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 141);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(181, 16);
            this.label36.TabIndex = 175;
            this.label36.Text = "Exclusion / Escalation to SPV";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(165, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 174;
            this.button3.Text = "Phone Other";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 111);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(73, 16);
            this.label35.TabIndex = 173;
            this.label35.Text = "No Contact";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(165, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 172;
            this.button2.Text = "Contact With Borrower";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 81);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(125, 16);
            this.label34.TabIndex = 171;
            this.label34.Text = "Contact without PTP";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(165, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 170;
            this.button1.Text = "PTP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(107, 16);
            this.label33.TabIndex = 169;
            this.label33.Text = "Contact with PTP";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label126);
            this.groupBox5.Controls.Add(this.label127);
            this.groupBox5.Controls.Add(this.label156);
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
            this.groupBox5.Controls.Add(this.lblInhouseScore);
            this.groupBox5.Controls.Add(this.lblForeClosure_amt1);
            this.groupBox5.Controls.Add(this.lblBilingCycle);
            this.groupBox5.Controls.Add(this.lblDPD4);
            this.groupBox5.Controls.Add(this.lblLastPaymentDate);
            this.groupBox5.Controls.Add(this.lblLastPaymentAmount);
            this.groupBox5.Controls.Add(this.lblOpenDate);
            this.groupBox5.Controls.Add(this.txtmsg);
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
            this.groupBox5.Location = new System.Drawing.Point(3, 145);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1190, 324);
            this.groupBox5.TabIndex = 301;
            this.groupBox5.TabStop = false;
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.BackColor = System.Drawing.Color.SandyBrown;
            this.label126.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.Location = new System.Drawing.Point(5, 15);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(155, 18);
            this.label126.TabIndex = 338;
            this.label126.Text = "Financial Information";
            // 
            // label127
            // 
            this.label127.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label127.BackColor = System.Drawing.Color.Yellow;
            this.label127.Location = new System.Drawing.Point(209, 12);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(961, 25);
            this.label127.TabIndex = 337;
            this.label127.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label156
            // 
            this.label156.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label156.BackColor = System.Drawing.Color.SandyBrown;
            this.label156.Location = new System.Drawing.Point(5, 12);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(250, 25);
            this.label156.TabIndex = 339;
            this.label156.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBucket7
            // 
            this.lblBucket7.AutoSize = true;
            this.lblBucket7.Location = new System.Drawing.Point(576, 304);
            this.lblBucket7.Name = "lblBucket7";
            this.lblBucket7.Size = new System.Drawing.Size(58, 16);
            this.lblBucket7.TabIndex = 336;
            this.lblBucket7.Text = "Bucket 7";
            // 
            // lblBucket6
            // 
            this.lblBucket6.AutoSize = true;
            this.lblBucket6.Location = new System.Drawing.Point(576, 279);
            this.lblBucket6.Name = "lblBucket6";
            this.lblBucket6.Size = new System.Drawing.Size(58, 16);
            this.lblBucket6.TabIndex = 335;
            this.lblBucket6.Text = "Bucket 6";
            // 
            // lblBucket5
            // 
            this.lblBucket5.AutoSize = true;
            this.lblBucket5.Location = new System.Drawing.Point(576, 255);
            this.lblBucket5.Name = "lblBucket5";
            this.lblBucket5.Size = new System.Drawing.Size(58, 16);
            this.lblBucket5.TabIndex = 334;
            this.lblBucket5.Text = "Bucket 5";
            // 
            // lblBucket4
            // 
            this.lblBucket4.AutoSize = true;
            this.lblBucket4.Location = new System.Drawing.Point(576, 232);
            this.lblBucket4.Name = "lblBucket4";
            this.lblBucket4.Size = new System.Drawing.Size(58, 16);
            this.lblBucket4.TabIndex = 333;
            this.lblBucket4.Text = "Bucket 4";
            // 
            // lblBucket3
            // 
            this.lblBucket3.AutoSize = true;
            this.lblBucket3.Location = new System.Drawing.Point(576, 207);
            this.lblBucket3.Name = "lblBucket3";
            this.lblBucket3.Size = new System.Drawing.Size(58, 16);
            this.lblBucket3.TabIndex = 332;
            this.lblBucket3.Text = "Bucket 3";
            // 
            // lblBucket2
            // 
            this.lblBucket2.AutoSize = true;
            this.lblBucket2.Location = new System.Drawing.Point(576, 183);
            this.lblBucket2.Name = "lblBucket2";
            this.lblBucket2.Size = new System.Drawing.Size(58, 16);
            this.lblBucket2.TabIndex = 331;
            this.lblBucket2.Text = "Bucket 2";
            // 
            // lblBucket1
            // 
            this.lblBucket1.AutoSize = true;
            this.lblBucket1.Location = new System.Drawing.Point(576, 160);
            this.lblBucket1.Name = "lblBucket1";
            this.lblBucket1.Size = new System.Drawing.Size(58, 16);
            this.lblBucket1.TabIndex = 330;
            this.lblBucket1.Text = "Bucket 1";
            // 
            // lblChargesOverdue
            // 
            this.lblChargesOverdue.AutoSize = true;
            this.lblChargesOverdue.Location = new System.Drawing.Point(576, 137);
            this.lblChargesOverdue.Name = "lblChargesOverdue";
            this.lblChargesOverdue.Size = new System.Drawing.Size(113, 16);
            this.lblChargesOverdue.TabIndex = 329;
            this.lblChargesOverdue.Text = "Charges Overdue";
            // 
            // lblInterestOverdue
            // 
            this.lblInterestOverdue.AutoSize = true;
            this.lblInterestOverdue.Location = new System.Drawing.Point(576, 114);
            this.lblInterestOverdue.Name = "lblInterestOverdue";
            this.lblInterestOverdue.Size = new System.Drawing.Size(105, 16);
            this.lblInterestOverdue.TabIndex = 328;
            this.lblInterestOverdue.Text = "Interest Overdue";
            // 
            // lblPrincipleOverdue
            // 
            this.lblPrincipleOverdue.AutoSize = true;
            this.lblPrincipleOverdue.Location = new System.Drawing.Point(576, 91);
            this.lblPrincipleOverdue.Name = "lblPrincipleOverdue";
            this.lblPrincipleOverdue.Size = new System.Drawing.Size(114, 16);
            this.lblPrincipleOverdue.TabIndex = 327;
            this.lblPrincipleOverdue.Text = "Principle Overdue";
            // 
            // lblAmountOverdue
            // 
            this.lblAmountOverdue.AutoSize = true;
            this.lblAmountOverdue.Location = new System.Drawing.Point(576, 68);
            this.lblAmountOverdue.Name = "lblAmountOverdue";
            this.lblAmountOverdue.Size = new System.Drawing.Size(107, 16);
            this.lblAmountOverdue.TabIndex = 326;
            this.lblAmountOverdue.Text = "Amount Overdue";
            // 
            // lblOutstanding
            // 
            this.lblOutstanding.AutoSize = true;
            this.lblOutstanding.Location = new System.Drawing.Point(576, 45);
            this.lblOutstanding.Name = "lblOutstanding";
            this.lblOutstanding.Size = new System.Drawing.Size(131, 16);
            this.lblOutstanding.TabIndex = 325;
            this.lblOutstanding.Text = "Outstanding Balance";
            // 
            // lblInhouseScore
            // 
            this.lblInhouseScore.AutoSize = true;
            this.lblInhouseScore.Location = new System.Drawing.Point(155, 183);
            this.lblInhouseScore.Name = "lblInhouseScore";
            this.lblInhouseScore.Size = new System.Drawing.Size(125, 16);
            this.lblInhouseScore.TabIndex = 324;
            this.lblInhouseScore.Text = "INHOUSE SCORE3";
            // 
            // lblForeClosure_amt1
            // 
            this.lblForeClosure_amt1.AutoSize = true;
            this.lblForeClosure_amt1.Location = new System.Drawing.Point(155, 160);
            this.lblForeClosure_amt1.Name = "lblForeClosure_amt1";
            this.lblForeClosure_amt1.Size = new System.Drawing.Size(140, 16);
            this.lblForeClosure_amt1.TabIndex = 323;
            this.lblForeClosure_amt1.Text = "FORECLOSURE AMT";
            // 
            // lblBilingCycle
            // 
            this.lblBilingCycle.AutoSize = true;
            this.lblBilingCycle.Location = new System.Drawing.Point(155, 137);
            this.lblBilingCycle.Name = "lblBilingCycle";
            this.lblBilingCycle.Size = new System.Drawing.Size(80, 16);
            this.lblBilingCycle.TabIndex = 322;
            this.lblBilingCycle.Text = "Billing Cycle";
            // 
            // lblDPD4
            // 
            this.lblDPD4.AutoSize = true;
            this.lblDPD4.Location = new System.Drawing.Point(155, 114);
            this.lblDPD4.Name = "lblDPD4";
            this.lblDPD4.Size = new System.Drawing.Size(36, 16);
            this.lblDPD4.TabIndex = 321;
            this.lblDPD4.Text = "DPD";
            // 
            // lblLastPaymentDate
            // 
            this.lblLastPaymentDate.AutoSize = true;
            this.lblLastPaymentDate.Location = new System.Drawing.Point(155, 91);
            this.lblLastPaymentDate.Name = "lblLastPaymentDate";
            this.lblLastPaymentDate.Size = new System.Drawing.Size(120, 16);
            this.lblLastPaymentDate.TabIndex = 320;
            this.lblLastPaymentDate.Text = "Last Payment Date";
            // 
            // lblLastPaymentAmount
            // 
            this.lblLastPaymentAmount.AutoSize = true;
            this.lblLastPaymentAmount.Location = new System.Drawing.Point(155, 68);
            this.lblLastPaymentAmount.Name = "lblLastPaymentAmount";
            this.lblLastPaymentAmount.Size = new System.Drawing.Size(136, 16);
            this.lblLastPaymentAmount.TabIndex = 319;
            this.lblLastPaymentAmount.Text = "Last Payment Amount";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Location = new System.Drawing.Point(155, 45);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(72, 16);
            this.lblOpenDate.TabIndex = 318;
            this.lblOpenDate.Text = "Open Date";
            // 
            // txtmsg
            // 
            this.txtmsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmsg.Location = new System.Drawing.Point(809, 44);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.Size = new System.Drawing.Size(334, 273);
            this.txtmsg.TabIndex = 317;
            this.txtmsg.Text = "Selamat pagi . Hingga saat ini kami belum menerima pembayaran pinjaman anda denga" +
    "n nomor loan . Mohon segera lakukan pembayaran. Terima kasih";
            this.txtmsg.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(440, 304);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 16);
            this.label16.TabIndex = 316;
            this.label16.Text = "Bucket 7";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(440, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 16);
            this.label17.TabIndex = 315;
            this.label17.Text = "Bucket 6";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(440, 255);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 314;
            this.label18.Text = "Bucket 5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(440, 232);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 16);
            this.label19.TabIndex = 313;
            this.label19.Text = "Bucket 4";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 207);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 312;
            this.label20.Text = "Bucket 3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(440, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 311;
            this.label12.Text = "Bucket 2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(440, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 310;
            this.label13.Text = "Bucket 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 16);
            this.label14.TabIndex = 309;
            this.label14.Text = "Charges Overdue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(439, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 308;
            this.label15.Text = "Interest Overdue";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(439, 91);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 16);
            this.label21.TabIndex = 307;
            this.label21.Text = "Principle Overdue";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(439, 68);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 16);
            this.label22.TabIndex = 306;
            this.label22.Text = "Amount Overdue";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(439, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 16);
            this.label23.TabIndex = 305;
            this.label23.Text = "Outstanding Balance";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 183);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(125, 16);
            this.label24.TabIndex = 304;
            this.label24.Text = "INHOUSE SCORE3";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 160);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(140, 16);
            this.label25.TabIndex = 303;
            this.label25.Text = "FORECLOSURE AMT";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 137);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 16);
            this.label26.TabIndex = 302;
            this.label26.Text = "Billing Cycle";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 114);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(36, 16);
            this.label27.TabIndex = 301;
            this.label27.Text = "DPD";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 91);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 16);
            this.label28.TabIndex = 300;
            this.label28.Text = "Last Payment Date";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 68);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 16);
            this.label29.TabIndex = 299;
            this.label29.Text = "Last Payment Amount";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 16);
            this.label30.TabIndex = 298;
            this.label30.Text = "Open Date";
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
            this.groupBox4.Location = new System.Drawing.Point(5, -1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1190, 146);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // lblPother
            // 
            this.lblPother.AutoSize = true;
            this.lblPother.Location = new System.Drawing.Point(917, 123);
            this.lblPother.Name = "lblPother";
            this.lblPother.Size = new System.Drawing.Size(39, 16);
            this.lblPother.TabIndex = 300;
            this.lblPother.Text = "Other";
            // 
            // lblPoffice
            // 
            this.lblPoffice.AutoSize = true;
            this.lblPoffice.Location = new System.Drawing.Point(917, 100);
            this.lblPoffice.Name = "lblPoffice";
            this.lblPoffice.Size = new System.Drawing.Size(41, 16);
            this.lblPoffice.TabIndex = 299;
            this.lblPoffice.Text = "Office";
            // 
            // lblPhome
            // 
            this.lblPhome.AutoSize = true;
            this.lblPhome.Location = new System.Drawing.Point(917, 77);
            this.lblPhome.Name = "lblPhome";
            this.lblPhome.Size = new System.Drawing.Size(44, 16);
            this.lblPhome.TabIndex = 298;
            this.lblPhome.Text = "Home";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(594, 123);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(51, 16);
            this.lblRegion.TabIndex = 297;
            this.lblRegion.Text = "Region";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(594, 100);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 296;
            this.lblGender.Text = "Gender";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(594, 77);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(116, 16);
            this.lblProduct.TabIndex = 295;
            this.lblProduct.Text = "Sub Product Code";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(123, 123);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(36, 16);
            this.lblDOB.TabIndex = 294;
            this.lblDOB.Text = "DOB";
            // 
            // lblCustName1
            // 
            this.lblCustName1.Location = new System.Drawing.Point(123, 100);
            this.lblCustName1.Name = "lblCustName1";
            this.lblCustName1.Size = new System.Drawing.Size(350, 16);
            this.lblCustName1.TabIndex = 293;
            this.lblCustName1.Text = "Customer Name";
            // 
            // lblLoan4
            // 
            this.lblLoan4.AutoSize = true;
            this.lblLoan4.Location = new System.Drawing.Point(123, 77);
            this.lblLoan4.Name = "lblLoan4";
            this.lblLoan4.Size = new System.Drawing.Size(88, 16);
            this.lblLoan4.TabIndex = 292;
            this.lblLoan4.Text = "Loan Number";
            // 
            // lblServiceName2
            // 
            this.lblServiceName2.AutoSize = true;
            this.lblServiceName2.BackColor = System.Drawing.Color.Yellow;
            this.lblServiceName2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblServiceName2.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName2.Location = new System.Drawing.Point(225, 17);
            this.lblServiceName2.Name = "lblServiceName2";
            this.lblServiceName2.Size = new System.Drawing.Size(51, 18);
            this.lblServiceName2.TabIndex = 290;
            this.lblServiceName2.Text = "Loan1";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.Color.SandyBrown;
            this.label121.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.Location = new System.Drawing.Point(4, 17);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(107, 18);
            this.label121.TabIndex = 289;
            this.label121.Text = "Service Name";
            // 
            // label122
            // 
            this.label122.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label122.BackColor = System.Drawing.Color.Yellow;
            this.label122.Location = new System.Drawing.Point(208, 13);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(976, 25);
            this.label122.TabIndex = 288;
            this.label122.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label123
            // 
            this.label123.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label123.BackColor = System.Drawing.Color.SandyBrown;
            this.label123.Location = new System.Drawing.Point(4, 13);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(250, 25);
            this.label123.TabIndex = 291;
            this.label123.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button19
            // 
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(376, 47);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 287;
            this.button19.Text = "Others";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(295, 47);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 286;
            this.button20.Text = "Office";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(214, 47);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 23);
            this.button21.TabIndex = 285;
            this.button21.Text = "Home";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(133, 47);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 23);
            this.button22.TabIndex = 284;
            this.button22.Text = "Mobile";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(837, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 283;
            this.label9.Text = "Other";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(837, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 282;
            this.label10.Text = "Office";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(837, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 281;
            this.label11.Text = "Home";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 280;
            this.label6.Text = "Region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 279;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 278;
            this.label8.Text = "Sub Product Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 277;
            this.label5.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 276;
            this.label4.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 275;
            this.label3.Text = "Loan Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 274;
            this.label1.Text = "Contact No";
            // 
            // grp_phone_remainder
            // 
            this.grp_phone_remainder.Controls.Add(this.comboBox30);
            this.grp_phone_remainder.Controls.Add(this.label222);
            this.grp_phone_remainder.Controls.Add(this.button34);
            this.grp_phone_remainder.Controls.Add(this.label223);
            this.grp_phone_remainder.Controls.Add(this.comboBox31);
            this.grp_phone_remainder.Controls.Add(this.comboBox32);
            this.grp_phone_remainder.Controls.Add(this.label224);
            this.grp_phone_remainder.Controls.Add(this.comboBox33);
            this.grp_phone_remainder.Controls.Add(this.textBox29);
            this.grp_phone_remainder.Controls.Add(this.textBox30);
            this.grp_phone_remainder.Controls.Add(this.textBox31);
            this.grp_phone_remainder.Controls.Add(this.label225);
            this.grp_phone_remainder.Controls.Add(this.label226);
            this.grp_phone_remainder.Controls.Add(this.label227);
            this.grp_phone_remainder.Controls.Add(this.label228);
            this.grp_phone_remainder.Controls.Add(this.label229);
            this.grp_phone_remainder.Controls.Add(this.comboBox34);
            this.grp_phone_remainder.Controls.Add(this.comboBox35);
            this.grp_phone_remainder.Controls.Add(this.label230);
            this.grp_phone_remainder.Controls.Add(this.comboBox36);
            this.grp_phone_remainder.Controls.Add(this.textBox32);
            this.grp_phone_remainder.Controls.Add(this.textBox33);
            this.grp_phone_remainder.Controls.Add(this.textBox35);
            this.grp_phone_remainder.Controls.Add(this.label231);
            this.grp_phone_remainder.Controls.Add(this.label232);
            this.grp_phone_remainder.Controls.Add(this.label233);
            this.grp_phone_remainder.Controls.Add(this.label234);
            this.grp_phone_remainder.Controls.Add(this.label235);
            this.grp_phone_remainder.Controls.Add(this.comboBox37);
            this.grp_phone_remainder.Controls.Add(this.comboBox38);
            this.grp_phone_remainder.Controls.Add(this.textBox39);
            this.grp_phone_remainder.Controls.Add(this.textBox41);
            this.grp_phone_remainder.Controls.Add(this.textBox53);
            this.grp_phone_remainder.Controls.Add(this.textBox54);
            this.grp_phone_remainder.Controls.Add(this.label236);
            this.grp_phone_remainder.Controls.Add(this.label237);
            this.grp_phone_remainder.Controls.Add(this.label238);
            this.grp_phone_remainder.Controls.Add(this.label239);
            this.grp_phone_remainder.Controls.Add(this.label240);
            this.grp_phone_remainder.Controls.Add(this.button35);
            this.grp_phone_remainder.Controls.Add(this.label241);
            this.grp_phone_remainder.Controls.Add(this.button36);
            this.grp_phone_remainder.Controls.Add(this.label242);
            this.grp_phone_remainder.Controls.Add(this.label243);
            this.grp_phone_remainder.Controls.Add(this.label244);
            this.grp_phone_remainder.Location = new System.Drawing.Point(5, 494);
            this.grp_phone_remainder.Name = "grp_phone_remainder";
            this.grp_phone_remainder.Size = new System.Drawing.Size(1202, 292);
            this.grp_phone_remainder.TabIndex = 306;
            this.grp_phone_remainder.TabStop = false;
            // 
            // comboBox30
            // 
            this.comboBox30.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox30.FormattingEnabled = true;
            this.comboBox30.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox30.Location = new System.Drawing.Point(178, 190);
            this.comboBox30.Name = "comboBox30";
            this.comboBox30.Size = new System.Drawing.Size(153, 24);
            this.comboBox30.TabIndex = 386;
            // 
            // label222
            // 
            this.label222.AutoSize = true;
            this.label222.Location = new System.Drawing.Point(14, 190);
            this.label222.Name = "label222";
            this.label222.Size = new System.Drawing.Size(90, 16);
            this.label222.TabIndex = 385;
            this.label222.Text = "PR Hold Date";
            // 
            // button34
            // 
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Location = new System.Drawing.Point(178, 248);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(75, 23);
            this.button34.TabIndex = 384;
            this.button34.Text = "Callback";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // label223
            // 
            this.label223.AutoSize = true;
            this.label223.Location = new System.Drawing.Point(14, 248);
            this.label223.Name = "label223";
            this.label223.Size = new System.Drawing.Size(143, 16);
            this.label223.TabIndex = 383;
            this.label223.Text = "Schedule For Callback";
            // 
            // comboBox31
            // 
            this.comboBox31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox31.FormattingEnabled = true;
            this.comboBox31.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox31.Location = new System.Drawing.Point(889, 76);
            this.comboBox31.Name = "comboBox31";
            this.comboBox31.Size = new System.Drawing.Size(153, 24);
            this.comboBox31.TabIndex = 382;
            // 
            // comboBox32
            // 
            this.comboBox32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox32.FormattingEnabled = true;
            this.comboBox32.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox32.Location = new System.Drawing.Point(889, 190);
            this.comboBox32.Name = "comboBox32";
            this.comboBox32.Size = new System.Drawing.Size(153, 24);
            this.comboBox32.TabIndex = 381;
            // 
            // label224
            // 
            this.label224.AutoSize = true;
            this.label224.Location = new System.Drawing.Point(725, 190);
            this.label224.Name = "label224";
            this.label224.Size = new System.Drawing.Size(90, 16);
            this.label224.TabIndex = 380;
            this.label224.Text = "PR Hold Date";
            // 
            // comboBox33
            // 
            this.comboBox33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox33.FormattingEnabled = true;
            this.comboBox33.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox33.Location = new System.Drawing.Point(889, 160);
            this.comboBox33.Name = "comboBox33";
            this.comboBox33.Size = new System.Drawing.Size(153, 24);
            this.comboBox33.TabIndex = 379;
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox29.Location = new System.Drawing.Point(889, 132);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(153, 22);
            this.textBox29.TabIndex = 378;
            // 
            // textBox30
            // 
            this.textBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox30.Location = new System.Drawing.Point(889, 104);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(153, 22);
            this.textBox30.TabIndex = 377;
            // 
            // textBox31
            // 
            this.textBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox31.Location = new System.Drawing.Point(889, 48);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(153, 22);
            this.textBox31.TabIndex = 376;
            // 
            // label225
            // 
            this.label225.AutoSize = true;
            this.label225.Location = new System.Drawing.Point(725, 160);
            this.label225.Name = "label225";
            this.label225.Size = new System.Drawing.Size(98, 16);
            this.label225.TabIndex = 375;
            this.label225.Text = "PTP Hold Date";
            // 
            // label226
            // 
            this.label226.AutoSize = true;
            this.label226.Location = new System.Drawing.Point(725, 132);
            this.label226.Name = "label226";
            this.label226.Size = new System.Drawing.Size(82, 16);
            this.label226.TabIndex = 374;
            this.label226.Text = "PTP Amount";
            // 
            // label227
            // 
            this.label227.AutoSize = true;
            this.label227.Location = new System.Drawing.Point(725, 104);
            this.label227.Name = "label227";
            this.label227.Size = new System.Drawing.Size(90, 16);
            this.label227.TabIndex = 373;
            this.label227.Text = "Contact Mode";
            // 
            // label228
            // 
            this.label228.AutoSize = true;
            this.label228.Location = new System.Drawing.Point(725, 76);
            this.label228.Name = "label228";
            this.label228.Size = new System.Drawing.Size(193, 16);
            this.label228.TabIndex = 372;
            this.label228.Text = "Action Code / Disposition Code";
            // 
            // label229
            // 
            this.label229.AutoSize = true;
            this.label229.Location = new System.Drawing.Point(725, 48);
            this.label229.Name = "label229";
            this.label229.Size = new System.Drawing.Size(88, 16);
            this.label229.TabIndex = 371;
            this.label229.Text = "Loan Number";
            // 
            // comboBox34
            // 
            this.comboBox34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox34.FormattingEnabled = true;
            this.comboBox34.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox34.Location = new System.Drawing.Point(551, 76);
            this.comboBox34.Name = "comboBox34";
            this.comboBox34.Size = new System.Drawing.Size(153, 24);
            this.comboBox34.TabIndex = 370;
            // 
            // comboBox35
            // 
            this.comboBox35.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox35.FormattingEnabled = true;
            this.comboBox35.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox35.Location = new System.Drawing.Point(551, 190);
            this.comboBox35.Name = "comboBox35";
            this.comboBox35.Size = new System.Drawing.Size(153, 24);
            this.comboBox35.TabIndex = 369;
            // 
            // label230
            // 
            this.label230.AutoSize = true;
            this.label230.Location = new System.Drawing.Point(387, 190);
            this.label230.Name = "label230";
            this.label230.Size = new System.Drawing.Size(90, 16);
            this.label230.TabIndex = 368;
            this.label230.Text = "PR Hold Date";
            // 
            // comboBox36
            // 
            this.comboBox36.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox36.FormattingEnabled = true;
            this.comboBox36.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox36.Location = new System.Drawing.Point(551, 160);
            this.comboBox36.Name = "comboBox36";
            this.comboBox36.Size = new System.Drawing.Size(153, 24);
            this.comboBox36.TabIndex = 367;
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox32.Location = new System.Drawing.Point(551, 132);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(153, 22);
            this.textBox32.TabIndex = 366;
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox33.Location = new System.Drawing.Point(551, 104);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(153, 22);
            this.textBox33.TabIndex = 365;
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox35.Location = new System.Drawing.Point(551, 48);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(153, 22);
            this.textBox35.TabIndex = 364;
            // 
            // label231
            // 
            this.label231.AutoSize = true;
            this.label231.Location = new System.Drawing.Point(387, 160);
            this.label231.Name = "label231";
            this.label231.Size = new System.Drawing.Size(98, 16);
            this.label231.TabIndex = 363;
            this.label231.Text = "PTP Hold Date";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(387, 132);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(82, 16);
            this.label232.TabIndex = 362;
            this.label232.Text = "PTP Amount";
            // 
            // label233
            // 
            this.label233.AutoSize = true;
            this.label233.Location = new System.Drawing.Point(387, 104);
            this.label233.Name = "label233";
            this.label233.Size = new System.Drawing.Size(90, 16);
            this.label233.TabIndex = 361;
            this.label233.Text = "Contact Mode";
            // 
            // label234
            // 
            this.label234.AutoSize = true;
            this.label234.Location = new System.Drawing.Point(387, 76);
            this.label234.Name = "label234";
            this.label234.Size = new System.Drawing.Size(193, 16);
            this.label234.TabIndex = 360;
            this.label234.Text = "Action Code / Disposition Code";
            // 
            // label235
            // 
            this.label235.AutoSize = true;
            this.label235.Location = new System.Drawing.Point(387, 48);
            this.label235.Name = "label235";
            this.label235.Size = new System.Drawing.Size(88, 16);
            this.label235.TabIndex = 359;
            this.label235.Text = "Loan Number";
            // 
            // comboBox37
            // 
            this.comboBox37.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox37.FormattingEnabled = true;
            this.comboBox37.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox37.Location = new System.Drawing.Point(178, 160);
            this.comboBox37.Name = "comboBox37";
            this.comboBox37.Size = new System.Drawing.Size(153, 24);
            this.comboBox37.TabIndex = 358;
            // 
            // comboBox38
            // 
            this.comboBox38.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox38.FormattingEnabled = true;
            this.comboBox38.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox38.Location = new System.Drawing.Point(178, 132);
            this.comboBox38.Name = "comboBox38";
            this.comboBox38.Size = new System.Drawing.Size(153, 24);
            this.comboBox38.TabIndex = 357;
            // 
            // textBox39
            // 
            this.textBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox39.Location = new System.Drawing.Point(178, 220);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(153, 22);
            this.textBox39.TabIndex = 356;
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox41.Location = new System.Drawing.Point(178, 104);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(153, 22);
            this.textBox41.TabIndex = 355;
            // 
            // textBox53
            // 
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(178, 76);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(153, 22);
            this.textBox53.TabIndex = 354;
            // 
            // textBox54
            // 
            this.textBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox54.Location = new System.Drawing.Point(178, 48);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(153, 22);
            this.textBox54.TabIndex = 353;
            // 
            // label236
            // 
            this.label236.AutoSize = true;
            this.label236.Location = new System.Drawing.Point(14, 220);
            this.label236.Name = "label236";
            this.label236.Size = new System.Drawing.Size(62, 16);
            this.label236.TabIndex = 352;
            this.label236.Text = "Remarks";
            // 
            // label237
            // 
            this.label237.AutoSize = true;
            this.label237.Location = new System.Drawing.Point(14, 160);
            this.label237.Name = "label237";
            this.label237.Size = new System.Drawing.Size(98, 16);
            this.label237.TabIndex = 351;
            this.label237.Text = "Contact Person";
            // 
            // label238
            // 
            this.label238.AutoSize = true;
            this.label238.Location = new System.Drawing.Point(14, 132);
            this.label238.Name = "label238";
            this.label238.Size = new System.Drawing.Size(90, 16);
            this.label238.TabIndex = 350;
            this.label238.Text = "Contact Place";
            // 
            // label239
            // 
            this.label239.AutoSize = true;
            this.label239.Location = new System.Drawing.Point(14, 104);
            this.label239.Name = "label239";
            this.label239.Size = new System.Drawing.Size(90, 16);
            this.label239.TabIndex = 349;
            this.label239.Text = "Contact Mode";
            // 
            // label240
            // 
            this.label240.AutoSize = true;
            this.label240.Location = new System.Drawing.Point(14, 76);
            this.label240.Name = "label240";
            this.label240.Size = new System.Drawing.Size(193, 16);
            this.label240.TabIndex = 348;
            this.label240.Text = "Action Code / Disposition Code";
            // 
            // button35
            // 
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Location = new System.Drawing.Point(259, 248);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(75, 23);
            this.button35.TabIndex = 347;
            this.button35.Text = "Next Call";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // label241
            // 
            this.label241.AutoSize = true;
            this.label241.Location = new System.Drawing.Point(14, 48);
            this.label241.Name = "label241";
            this.label241.Size = new System.Drawing.Size(88, 16);
            this.label241.TabIndex = 346;
            this.label241.Text = "Loan Number";
            // 
            // button36
            // 
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Location = new System.Drawing.Point(341, 248);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(75, 23);
            this.button36.TabIndex = 345;
            this.button36.Text = "Cancel";
            this.button36.UseVisualStyleBackColor = true;
            this.button36.Click += new System.EventHandler(this.button36_Click);
            // 
            // label242
            // 
            this.label242.AutoSize = true;
            this.label242.BackColor = System.Drawing.Color.SandyBrown;
            this.label242.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label242.Location = new System.Drawing.Point(12, 21);
            this.label242.Name = "label242";
            this.label242.Size = new System.Drawing.Size(54, 18);
            this.label242.TabIndex = 303;
            this.label242.Text = "Result";
            // 
            // label243
            // 
            this.label243.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label243.BackColor = System.Drawing.Color.Yellow;
            this.label243.Location = new System.Drawing.Point(211, 16);
            this.label243.Name = "label243";
            this.label243.Size = new System.Drawing.Size(973, 25);
            this.label243.TabIndex = 301;
            this.label243.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label244
            // 
            this.label244.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label244.BackColor = System.Drawing.Color.SandyBrown;
            this.label244.Location = new System.Drawing.Point(7, 16);
            this.label244.Name = "label244";
            this.label244.Size = new System.Drawing.Size(311, 25);
            this.label244.TabIndex = 302;
            this.label244.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_phone_not_answer
            // 
            this.grp_phone_not_answer.Controls.Add(this.comboBox39);
            this.grp_phone_not_answer.Controls.Add(this.comboBox40);
            this.grp_phone_not_answer.Controls.Add(this.textBox55);
            this.grp_phone_not_answer.Controls.Add(this.textBox56);
            this.grp_phone_not_answer.Controls.Add(this.textBox57);
            this.grp_phone_not_answer.Controls.Add(this.label245);
            this.grp_phone_not_answer.Controls.Add(this.label246);
            this.grp_phone_not_answer.Controls.Add(this.label247);
            this.grp_phone_not_answer.Controls.Add(this.label248);
            this.grp_phone_not_answer.Controls.Add(this.label249);
            this.grp_phone_not_answer.Controls.Add(this.button37);
            this.grp_phone_not_answer.Controls.Add(this.button38);
            this.grp_phone_not_answer.Controls.Add(this.label250);
            this.grp_phone_not_answer.Controls.Add(this.label251);
            this.grp_phone_not_answer.Controls.Add(this.label252);
            this.grp_phone_not_answer.Location = new System.Drawing.Point(2, 511);
            this.grp_phone_not_answer.Name = "grp_phone_not_answer";
            this.grp_phone_not_answer.Size = new System.Drawing.Size(1202, 292);
            this.grp_phone_not_answer.TabIndex = 307;
            this.grp_phone_not_answer.TabStop = false;
            // 
            // comboBox39
            // 
            this.comboBox39.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox39.FormattingEnabled = true;
            this.comboBox39.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox39.Location = new System.Drawing.Point(176, 131);
            this.comboBox39.Name = "comboBox39";
            this.comboBox39.Size = new System.Drawing.Size(153, 24);
            this.comboBox39.TabIndex = 356;
            // 
            // comboBox40
            // 
            this.comboBox40.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox40.FormattingEnabled = true;
            this.comboBox40.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox40.Location = new System.Drawing.Point(176, 103);
            this.comboBox40.Name = "comboBox40";
            this.comboBox40.Size = new System.Drawing.Size(153, 24);
            this.comboBox40.TabIndex = 355;
            // 
            // textBox55
            // 
            this.textBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox55.Location = new System.Drawing.Point(176, 161);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(153, 22);
            this.textBox55.TabIndex = 354;
            // 
            // textBox56
            // 
            this.textBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox56.Location = new System.Drawing.Point(176, 75);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(153, 22);
            this.textBox56.TabIndex = 353;
            // 
            // textBox57
            // 
            this.textBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox57.Location = new System.Drawing.Point(176, 47);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(153, 22);
            this.textBox57.TabIndex = 352;
            // 
            // label245
            // 
            this.label245.AutoSize = true;
            this.label245.Location = new System.Drawing.Point(12, 161);
            this.label245.Name = "label245";
            this.label245.Size = new System.Drawing.Size(62, 16);
            this.label245.TabIndex = 351;
            this.label245.Text = "Remarks";
            // 
            // label246
            // 
            this.label246.AutoSize = true;
            this.label246.Location = new System.Drawing.Point(12, 131);
            this.label246.Name = "label246";
            this.label246.Size = new System.Drawing.Size(98, 16);
            this.label246.TabIndex = 350;
            this.label246.Text = "Contact Person";
            // 
            // label247
            // 
            this.label247.AutoSize = true;
            this.label247.Location = new System.Drawing.Point(12, 103);
            this.label247.Name = "label247";
            this.label247.Size = new System.Drawing.Size(90, 16);
            this.label247.TabIndex = 349;
            this.label247.Text = "Contact Place";
            // 
            // label248
            // 
            this.label248.AutoSize = true;
            this.label248.Location = new System.Drawing.Point(12, 75);
            this.label248.Name = "label248";
            this.label248.Size = new System.Drawing.Size(90, 16);
            this.label248.TabIndex = 348;
            this.label248.Text = "Contact Mode";
            // 
            // label249
            // 
            this.label249.AutoSize = true;
            this.label249.Location = new System.Drawing.Point(12, 47);
            this.label249.Name = "label249";
            this.label249.Size = new System.Drawing.Size(193, 16);
            this.label249.TabIndex = 347;
            this.label249.Text = "Action Code / Disposition Code";
            // 
            // button37
            // 
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Location = new System.Drawing.Point(176, 198);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(92, 23);
            this.button37.TabIndex = 346;
            this.button37.Text = "Save Activity";
            this.button37.UseVisualStyleBackColor = true;
            // 
            // button38
            // 
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Location = new System.Drawing.Point(278, 198);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(75, 23);
            this.button38.TabIndex = 345;
            this.button38.Text = "Cancel";
            this.button38.UseVisualStyleBackColor = true;
            this.button38.Click += new System.EventHandler(this.button38_Click);
            // 
            // label250
            // 
            this.label250.AutoSize = true;
            this.label250.BackColor = System.Drawing.Color.SandyBrown;
            this.label250.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label250.Location = new System.Drawing.Point(12, 21);
            this.label250.Name = "label250";
            this.label250.Size = new System.Drawing.Size(54, 18);
            this.label250.TabIndex = 303;
            this.label250.Text = "Result";
            // 
            // label251
            // 
            this.label251.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label251.BackColor = System.Drawing.Color.Yellow;
            this.label251.Location = new System.Drawing.Point(211, 16);
            this.label251.Name = "label251";
            this.label251.Size = new System.Drawing.Size(973, 25);
            this.label251.TabIndex = 301;
            this.label251.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label252
            // 
            this.label252.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label252.BackColor = System.Drawing.Color.SandyBrown;
            this.label252.Location = new System.Drawing.Point(7, 16);
            this.label252.Name = "label252";
            this.label252.Size = new System.Drawing.Size(311, 25);
            this.label252.TabIndex = 302;
            this.label252.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_phone_leave_message
            // 
            this.grp_phone_leave_message.Controls.Add(this.comboBox41);
            this.grp_phone_leave_message.Controls.Add(this.textBox58);
            this.grp_phone_leave_message.Controls.Add(this.label253);
            this.grp_phone_leave_message.Controls.Add(this.label254);
            this.grp_phone_leave_message.Controls.Add(this.comboBox42);
            this.grp_phone_leave_message.Controls.Add(this.textBox59);
            this.grp_phone_leave_message.Controls.Add(this.label255);
            this.grp_phone_leave_message.Controls.Add(this.label256);
            this.grp_phone_leave_message.Controls.Add(this.comboBox43);
            this.grp_phone_leave_message.Controls.Add(this.comboBox44);
            this.grp_phone_leave_message.Controls.Add(this.textBox60);
            this.grp_phone_leave_message.Controls.Add(this.textBox61);
            this.grp_phone_leave_message.Controls.Add(this.textBox62);
            this.grp_phone_leave_message.Controls.Add(this.textBox63);
            this.grp_phone_leave_message.Controls.Add(this.label257);
            this.grp_phone_leave_message.Controls.Add(this.label258);
            this.grp_phone_leave_message.Controls.Add(this.label259);
            this.grp_phone_leave_message.Controls.Add(this.label260);
            this.grp_phone_leave_message.Controls.Add(this.label261);
            this.grp_phone_leave_message.Controls.Add(this.button39);
            this.grp_phone_leave_message.Controls.Add(this.label262);
            this.grp_phone_leave_message.Controls.Add(this.button40);
            this.grp_phone_leave_message.Controls.Add(this.label263);
            this.grp_phone_leave_message.Controls.Add(this.label264);
            this.grp_phone_leave_message.Controls.Add(this.label265);
            this.grp_phone_leave_message.Location = new System.Drawing.Point(2, 488);
            this.grp_phone_leave_message.Name = "grp_phone_leave_message";
            this.grp_phone_leave_message.Size = new System.Drawing.Size(1202, 292);
            this.grp_phone_leave_message.TabIndex = 308;
            this.grp_phone_leave_message.TabStop = false;
            // 
            // comboBox41
            // 
            this.comboBox41.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox41.FormattingEnabled = true;
            this.comboBox41.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox41.Location = new System.Drawing.Point(887, 74);
            this.comboBox41.Name = "comboBox41";
            this.comboBox41.Size = new System.Drawing.Size(153, 24);
            this.comboBox41.TabIndex = 366;
            // 
            // textBox58
            // 
            this.textBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox58.Location = new System.Drawing.Point(887, 46);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(153, 22);
            this.textBox58.TabIndex = 365;
            // 
            // label253
            // 
            this.label253.AutoSize = true;
            this.label253.Location = new System.Drawing.Point(723, 74);
            this.label253.Name = "label253";
            this.label253.Size = new System.Drawing.Size(193, 16);
            this.label253.TabIndex = 364;
            this.label253.Text = "Action Code / Disposition Code";
            // 
            // label254
            // 
            this.label254.AutoSize = true;
            this.label254.Location = new System.Drawing.Point(723, 46);
            this.label254.Name = "label254";
            this.label254.Size = new System.Drawing.Size(88, 16);
            this.label254.TabIndex = 363;
            this.label254.Text = "Loan Number";
            // 
            // comboBox42
            // 
            this.comboBox42.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox42.FormattingEnabled = true;
            this.comboBox42.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox42.Location = new System.Drawing.Point(549, 74);
            this.comboBox42.Name = "comboBox42";
            this.comboBox42.Size = new System.Drawing.Size(153, 24);
            this.comboBox42.TabIndex = 362;
            // 
            // textBox59
            // 
            this.textBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox59.Location = new System.Drawing.Point(549, 46);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(153, 22);
            this.textBox59.TabIndex = 361;
            // 
            // label255
            // 
            this.label255.AutoSize = true;
            this.label255.Location = new System.Drawing.Point(385, 74);
            this.label255.Name = "label255";
            this.label255.Size = new System.Drawing.Size(193, 16);
            this.label255.TabIndex = 360;
            this.label255.Text = "Action Code / Disposition Code";
            // 
            // label256
            // 
            this.label256.AutoSize = true;
            this.label256.Location = new System.Drawing.Point(385, 46);
            this.label256.Name = "label256";
            this.label256.Size = new System.Drawing.Size(88, 16);
            this.label256.TabIndex = 359;
            this.label256.Text = "Loan Number";
            // 
            // comboBox43
            // 
            this.comboBox43.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox43.FormattingEnabled = true;
            this.comboBox43.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox43.Location = new System.Drawing.Point(176, 158);
            this.comboBox43.Name = "comboBox43";
            this.comboBox43.Size = new System.Drawing.Size(153, 24);
            this.comboBox43.TabIndex = 358;
            // 
            // comboBox44
            // 
            this.comboBox44.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox44.FormattingEnabled = true;
            this.comboBox44.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox44.Location = new System.Drawing.Point(176, 130);
            this.comboBox44.Name = "comboBox44";
            this.comboBox44.Size = new System.Drawing.Size(153, 24);
            this.comboBox44.TabIndex = 357;
            // 
            // textBox60
            // 
            this.textBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox60.Location = new System.Drawing.Point(176, 188);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(153, 22);
            this.textBox60.TabIndex = 356;
            // 
            // textBox61
            // 
            this.textBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox61.Location = new System.Drawing.Point(176, 102);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(153, 22);
            this.textBox61.TabIndex = 355;
            // 
            // textBox62
            // 
            this.textBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox62.Location = new System.Drawing.Point(176, 74);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(153, 22);
            this.textBox62.TabIndex = 354;
            // 
            // textBox63
            // 
            this.textBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox63.Location = new System.Drawing.Point(176, 46);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(153, 22);
            this.textBox63.TabIndex = 353;
            // 
            // label257
            // 
            this.label257.AutoSize = true;
            this.label257.Location = new System.Drawing.Point(12, 188);
            this.label257.Name = "label257";
            this.label257.Size = new System.Drawing.Size(62, 16);
            this.label257.TabIndex = 352;
            this.label257.Text = "Remarks";
            // 
            // label258
            // 
            this.label258.AutoSize = true;
            this.label258.Location = new System.Drawing.Point(12, 158);
            this.label258.Name = "label258";
            this.label258.Size = new System.Drawing.Size(98, 16);
            this.label258.TabIndex = 351;
            this.label258.Text = "Contact Person";
            // 
            // label259
            // 
            this.label259.AutoSize = true;
            this.label259.Location = new System.Drawing.Point(12, 130);
            this.label259.Name = "label259";
            this.label259.Size = new System.Drawing.Size(90, 16);
            this.label259.TabIndex = 350;
            this.label259.Text = "Contact Place";
            // 
            // label260
            // 
            this.label260.AutoSize = true;
            this.label260.Location = new System.Drawing.Point(12, 102);
            this.label260.Name = "label260";
            this.label260.Size = new System.Drawing.Size(90, 16);
            this.label260.TabIndex = 349;
            this.label260.Text = "Contact Mode";
            // 
            // label261
            // 
            this.label261.AutoSize = true;
            this.label261.Location = new System.Drawing.Point(12, 74);
            this.label261.Name = "label261";
            this.label261.Size = new System.Drawing.Size(193, 16);
            this.label261.TabIndex = 348;
            this.label261.Text = "Action Code / Disposition Code";
            // 
            // button39
            // 
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Location = new System.Drawing.Point(176, 232);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(92, 23);
            this.button39.TabIndex = 347;
            this.button39.Text = "Save Activity";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // label262
            // 
            this.label262.AutoSize = true;
            this.label262.Location = new System.Drawing.Point(12, 46);
            this.label262.Name = "label262";
            this.label262.Size = new System.Drawing.Size(88, 16);
            this.label262.TabIndex = 346;
            this.label262.Text = "Loan Number";
            // 
            // button40
            // 
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Location = new System.Drawing.Point(279, 232);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(75, 23);
            this.button40.TabIndex = 345;
            this.button40.Text = "Cancel";
            this.button40.UseVisualStyleBackColor = true;
            this.button40.Click += new System.EventHandler(this.button40_Click);
            // 
            // label263
            // 
            this.label263.AutoSize = true;
            this.label263.BackColor = System.Drawing.Color.SandyBrown;
            this.label263.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label263.Location = new System.Drawing.Point(12, 21);
            this.label263.Name = "label263";
            this.label263.Size = new System.Drawing.Size(54, 18);
            this.label263.TabIndex = 303;
            this.label263.Text = "Result";
            // 
            // label264
            // 
            this.label264.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label264.BackColor = System.Drawing.Color.Yellow;
            this.label264.Location = new System.Drawing.Point(211, 16);
            this.label264.Name = "label264";
            this.label264.Size = new System.Drawing.Size(973, 25);
            this.label264.TabIndex = 301;
            this.label264.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label265
            // 
            this.label265.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label265.BackColor = System.Drawing.Color.SandyBrown;
            this.label265.Location = new System.Drawing.Point(7, 16);
            this.label265.Name = "label265";
            this.label265.Size = new System.Drawing.Size(311, 25);
            this.label265.TabIndex = 302;
            this.label265.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_with_borrower
            // 
            this.grp_with_borrower.Controls.Add(this.button25);
            this.grp_with_borrower.Controls.Add(this.label140);
            this.grp_with_borrower.Controls.Add(this.comboBox3);
            this.grp_with_borrower.Controls.Add(this.comboBox1);
            this.grp_with_borrower.Controls.Add(this.label141);
            this.grp_with_borrower.Controls.Add(this.comboBox2);
            this.grp_with_borrower.Controls.Add(this.textBox37);
            this.grp_with_borrower.Controls.Add(this.textBox8);
            this.grp_with_borrower.Controls.Add(this.textBox9);
            this.grp_with_borrower.Controls.Add(this.label142);
            this.grp_with_borrower.Controls.Add(this.label143);
            this.grp_with_borrower.Controls.Add(this.label145);
            this.grp_with_borrower.Controls.Add(this.label147);
            this.grp_with_borrower.Controls.Add(this.label148);
            this.grp_with_borrower.Controls.Add(this.comboBox4);
            this.grp_with_borrower.Controls.Add(this.comboBox5);
            this.grp_with_borrower.Controls.Add(this.label149);
            this.grp_with_borrower.Controls.Add(this.comboBox6);
            this.grp_with_borrower.Controls.Add(this.textBox10);
            this.grp_with_borrower.Controls.Add(this.textBox11);
            this.grp_with_borrower.Controls.Add(this.textBox12);
            this.grp_with_borrower.Controls.Add(this.label150);
            this.grp_with_borrower.Controls.Add(this.label164);
            this.grp_with_borrower.Controls.Add(this.label165);
            this.grp_with_borrower.Controls.Add(this.label166);
            this.grp_with_borrower.Controls.Add(this.label168);
            this.grp_with_borrower.Controls.Add(this.comboBox7);
            this.grp_with_borrower.Controls.Add(this.comboBox8);
            this.grp_with_borrower.Controls.Add(this.textBox13);
            this.grp_with_borrower.Controls.Add(this.textBox14);
            this.grp_with_borrower.Controls.Add(this.textBox15);
            this.grp_with_borrower.Controls.Add(this.textBox16);
            this.grp_with_borrower.Controls.Add(this.label169);
            this.grp_with_borrower.Controls.Add(this.label170);
            this.grp_with_borrower.Controls.Add(this.label179);
            this.grp_with_borrower.Controls.Add(this.label180);
            this.grp_with_borrower.Controls.Add(this.label181);
            this.grp_with_borrower.Controls.Add(this.button26);
            this.grp_with_borrower.Controls.Add(this.label182);
            this.grp_with_borrower.Controls.Add(this.button27);
            this.grp_with_borrower.Controls.Add(this.label183);
            this.grp_with_borrower.Controls.Add(this.label184);
            this.grp_with_borrower.Controls.Add(this.label185);
            this.grp_with_borrower.Location = new System.Drawing.Point(3, 500);
            this.grp_with_borrower.Name = "grp_with_borrower";
            this.grp_with_borrower.Size = new System.Drawing.Size(1202, 292);
            this.grp_with_borrower.TabIndex = 302;
            this.grp_with_borrower.TabStop = false;
            // 
            // button25
            // 
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Location = new System.Drawing.Point(181, 228);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 23);
            this.button25.TabIndex = 384;
            this.button25.Text = "Callback";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(17, 228);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(143, 16);
            this.label140.TabIndex = 383;
            this.label140.Text = "Schedule For Callback";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox3.Location = new System.Drawing.Point(892, 80);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(153, 24);
            this.comboBox3.TabIndex = 382;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox1.Location = new System.Drawing.Point(892, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 381;
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(728, 194);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(90, 16);
            this.label141.TabIndex = 380;
            this.label141.Text = "PR Hold Date";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox2.Location = new System.Drawing.Point(892, 164);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(153, 24);
            this.comboBox2.TabIndex = 379;
            // 
            // textBox37
            // 
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox37.Location = new System.Drawing.Point(892, 136);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(153, 22);
            this.textBox37.TabIndex = 378;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Location = new System.Drawing.Point(892, 108);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(153, 22);
            this.textBox8.TabIndex = 377;
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Location = new System.Drawing.Point(892, 52);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 22);
            this.textBox9.TabIndex = 376;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(728, 164);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(98, 16);
            this.label142.TabIndex = 375;
            this.label142.Text = "PTP Hold Date";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(728, 136);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(82, 16);
            this.label143.TabIndex = 374;
            this.label143.Text = "PTP Amount";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(728, 108);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(90, 16);
            this.label145.TabIndex = 373;
            this.label145.Text = "Contact Mode";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(728, 80);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(193, 16);
            this.label147.TabIndex = 372;
            this.label147.Text = "Action Code / Disposition Code";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(728, 52);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(88, 16);
            this.label148.TabIndex = 371;
            this.label148.Text = "Loan Number";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox4.Location = new System.Drawing.Point(554, 80);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(153, 24);
            this.comboBox4.TabIndex = 370;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox5.Location = new System.Drawing.Point(554, 194);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(153, 24);
            this.comboBox5.TabIndex = 369;
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(390, 194);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(90, 16);
            this.label149.TabIndex = 368;
            this.label149.Text = "PR Hold Date";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox6.Location = new System.Drawing.Point(554, 164);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(153, 24);
            this.comboBox6.TabIndex = 367;
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox10.Location = new System.Drawing.Point(554, 136);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 22);
            this.textBox10.TabIndex = 366;
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox11.Location = new System.Drawing.Point(554, 108);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 22);
            this.textBox11.TabIndex = 365;
            // 
            // textBox12
            // 
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Location = new System.Drawing.Point(554, 52);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(153, 22);
            this.textBox12.TabIndex = 364;
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(390, 164);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(98, 16);
            this.label150.TabIndex = 363;
            this.label150.Text = "PTP Hold Date";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(390, 136);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(82, 16);
            this.label164.TabIndex = 362;
            this.label164.Text = "PTP Amount";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(390, 108);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(90, 16);
            this.label165.TabIndex = 361;
            this.label165.Text = "Contact Mode";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(390, 80);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(193, 16);
            this.label166.TabIndex = 360;
            this.label166.Text = "Action Code / Disposition Code";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(390, 52);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(88, 16);
            this.label168.TabIndex = 359;
            this.label168.Text = "Loan Number";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox7.Location = new System.Drawing.Point(181, 164);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(153, 24);
            this.comboBox7.TabIndex = 358;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox8.Location = new System.Drawing.Point(181, 136);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(153, 24);
            this.comboBox8.TabIndex = 357;
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Location = new System.Drawing.Point(181, 194);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(153, 22);
            this.textBox13.TabIndex = 356;
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox14.Location = new System.Drawing.Point(181, 108);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(153, 22);
            this.textBox14.TabIndex = 355;
            // 
            // textBox15
            // 
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox15.Location = new System.Drawing.Point(181, 80);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(153, 22);
            this.textBox15.TabIndex = 354;
            // 
            // textBox16
            // 
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox16.Location = new System.Drawing.Point(181, 52);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(153, 22);
            this.textBox16.TabIndex = 353;
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(17, 194);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(62, 16);
            this.label169.TabIndex = 352;
            this.label169.Text = "Remarks";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(17, 164);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(98, 16);
            this.label170.TabIndex = 351;
            this.label170.Text = "Contact Person";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(17, 136);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(90, 16);
            this.label179.TabIndex = 350;
            this.label179.Text = "Contact Place";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.Location = new System.Drawing.Point(17, 108);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(90, 16);
            this.label180.TabIndex = 349;
            this.label180.Text = "Contact Mode";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.Location = new System.Drawing.Point(17, 80);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(193, 16);
            this.label181.TabIndex = 348;
            this.label181.Text = "Action Code / Disposition Code";
            // 
            // button26
            // 
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Location = new System.Drawing.Point(181, 257);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 23);
            this.button26.TabIndex = 347;
            this.button26.Text = "Next Call";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.Location = new System.Drawing.Point(17, 52);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(88, 16);
            this.label182.TabIndex = 346;
            this.label182.Text = "Loan Number";
            // 
            // button27
            // 
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Location = new System.Drawing.Point(259, 257);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 345;
            this.button27.Text = "Cancel";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.BackColor = System.Drawing.Color.SandyBrown;
            this.label183.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label183.Location = new System.Drawing.Point(12, 21);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(54, 18);
            this.label183.TabIndex = 303;
            this.label183.Text = "Result";
            // 
            // label184
            // 
            this.label184.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label184.BackColor = System.Drawing.Color.Yellow;
            this.label184.Location = new System.Drawing.Point(211, 16);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(973, 25);
            this.label184.TabIndex = 301;
            this.label184.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label185
            // 
            this.label185.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label185.BackColor = System.Drawing.Color.SandyBrown;
            this.label185.Location = new System.Drawing.Point(7, 16);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(311, 25);
            this.label185.TabIndex = 302;
            this.label185.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_ptp
            // 
            this.grp_ptp.Controls.Add(this.button10);
            this.grp_ptp.Controls.Add(this.comboBox10);
            this.grp_ptp.Controls.Add(this.comboBox11);
            this.grp_ptp.Controls.Add(this.label54);
            this.grp_ptp.Controls.Add(this.comboBox12);
            this.grp_ptp.Controls.Add(this.textBox42);
            this.grp_ptp.Controls.Add(this.textBox43);
            this.grp_ptp.Controls.Add(this.textBox44);
            this.grp_ptp.Controls.Add(this.label55);
            this.grp_ptp.Controls.Add(this.label40);
            this.grp_ptp.Controls.Add(this.label44);
            this.grp_ptp.Controls.Add(this.label45);
            this.grp_ptp.Controls.Add(this.label50);
            this.grp_ptp.Controls.Add(this.comboBox13);
            this.grp_ptp.Controls.Add(this.comboBox14);
            this.grp_ptp.Controls.Add(this.label60);
            this.grp_ptp.Controls.Add(this.comboBox15);
            this.grp_ptp.Controls.Add(this.textBox45);
            this.grp_ptp.Controls.Add(this.textBox46);
            this.grp_ptp.Controls.Add(this.textBox47);
            this.grp_ptp.Controls.Add(this.label61);
            this.grp_ptp.Controls.Add(this.label62);
            this.grp_ptp.Controls.Add(this.label63);
            this.grp_ptp.Controls.Add(this.label64);
            this.grp_ptp.Controls.Add(this.label51);
            this.grp_ptp.Controls.Add(this.comboBox16);
            this.grp_ptp.Controls.Add(this.comboBox17);
            this.grp_ptp.Controls.Add(this.comboBox18);
            this.grp_ptp.Controls.Add(this.textBox48);
            this.grp_ptp.Controls.Add(this.textBox49);
            this.grp_ptp.Controls.Add(this.textBox50);
            this.grp_ptp.Controls.Add(this.textBox51);
            this.grp_ptp.Controls.Add(this.textBox52);
            this.grp_ptp.Controls.Add(this.label52);
            this.grp_ptp.Controls.Add(this.label53);
            this.grp_ptp.Controls.Add(this.label75);
            this.grp_ptp.Controls.Add(this.label76);
            this.grp_ptp.Controls.Add(this.label79);
            this.grp_ptp.Controls.Add(this.label80);
            this.grp_ptp.Controls.Add(this.label81);
            this.grp_ptp.Controls.Add(this.button24);
            this.grp_ptp.Controls.Add(this.label82);
            this.grp_ptp.Controls.Add(this.label112);
            this.grp_ptp.Controls.Add(this.label113);
            this.grp_ptp.Controls.Add(this.label139);
            this.grp_ptp.Location = new System.Drawing.Point(7, 490);
            this.grp_ptp.Name = "grp_ptp";
            this.grp_ptp.Size = new System.Drawing.Size(1190, 308);
            this.grp_ptp.TabIndex = 295;
            this.grp_ptp.TabStop = false;
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(99, 265);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 345;
            this.button10.Text = "Cancel";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox10.Location = new System.Drawing.Point(890, 77);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(153, 24);
            this.comboBox10.TabIndex = 344;
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox11.Location = new System.Drawing.Point(890, 191);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(153, 24);
            this.comboBox11.TabIndex = 343;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(726, 191);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(90, 16);
            this.label54.TabIndex = 342;
            this.label54.Text = "PR Hold Date";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox12.Location = new System.Drawing.Point(890, 161);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(153, 24);
            this.comboBox12.TabIndex = 341;
            // 
            // textBox42
            // 
            this.textBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox42.Location = new System.Drawing.Point(890, 133);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(153, 22);
            this.textBox42.TabIndex = 340;
            // 
            // textBox43
            // 
            this.textBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox43.Location = new System.Drawing.Point(890, 105);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(153, 22);
            this.textBox43.TabIndex = 339;
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox44.Location = new System.Drawing.Point(890, 49);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(153, 22);
            this.textBox44.TabIndex = 338;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(726, 161);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(98, 16);
            this.label55.TabIndex = 337;
            this.label55.Text = "PTP Hold Date";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(726, 133);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(82, 16);
            this.label40.TabIndex = 336;
            this.label40.Text = "PTP Amount";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(726, 105);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(90, 16);
            this.label44.TabIndex = 335;
            this.label44.Text = "Contact Mode";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(726, 77);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(193, 16);
            this.label45.TabIndex = 334;
            this.label45.Text = "Action Code / Disposition Code";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(726, 49);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(88, 16);
            this.label50.TabIndex = 333;
            this.label50.Text = "Loan Number";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox13.Location = new System.Drawing.Point(552, 77);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(153, 24);
            this.comboBox13.TabIndex = 332;
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox14.Location = new System.Drawing.Point(552, 191);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(153, 24);
            this.comboBox14.TabIndex = 331;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(388, 191);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(90, 16);
            this.label60.TabIndex = 330;
            this.label60.Text = "PR Hold Date";
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox15.Location = new System.Drawing.Point(552, 161);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(153, 24);
            this.comboBox15.TabIndex = 329;
            // 
            // textBox45
            // 
            this.textBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox45.Location = new System.Drawing.Point(552, 133);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(153, 22);
            this.textBox45.TabIndex = 328;
            // 
            // textBox46
            // 
            this.textBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox46.Location = new System.Drawing.Point(552, 105);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(153, 22);
            this.textBox46.TabIndex = 327;
            // 
            // textBox47
            // 
            this.textBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox47.Location = new System.Drawing.Point(552, 49);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(153, 22);
            this.textBox47.TabIndex = 326;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(388, 161);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(98, 16);
            this.label61.TabIndex = 325;
            this.label61.Text = "PTP Hold Date";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(388, 133);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(82, 16);
            this.label62.TabIndex = 324;
            this.label62.Text = "PTP Amount";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(388, 105);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(90, 16);
            this.label63.TabIndex = 323;
            this.label63.Text = "Contact Mode";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(388, 77);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(193, 16);
            this.label64.TabIndex = 322;
            this.label64.Text = "Action Code / Disposition Code";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(388, 49);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(88, 16);
            this.label51.TabIndex = 321;
            this.label51.Text = "Loan Number";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox16.Location = new System.Drawing.Point(179, 217);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(153, 24);
            this.comboBox16.TabIndex = 320;
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox17.Location = new System.Drawing.Point(179, 161);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(153, 24);
            this.comboBox17.TabIndex = 319;
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox18.Location = new System.Drawing.Point(179, 133);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(153, 24);
            this.comboBox18.TabIndex = 318;
            // 
            // textBox48
            // 
            this.textBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox48.Location = new System.Drawing.Point(179, 245);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(153, 22);
            this.textBox48.TabIndex = 317;
            // 
            // textBox49
            // 
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.Location = new System.Drawing.Point(179, 189);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(153, 22);
            this.textBox49.TabIndex = 316;
            // 
            // textBox50
            // 
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(179, 105);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(153, 22);
            this.textBox50.TabIndex = 315;
            // 
            // textBox51
            // 
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Location = new System.Drawing.Point(179, 77);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(153, 22);
            this.textBox51.TabIndex = 314;
            // 
            // textBox52
            // 
            this.textBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox52.Location = new System.Drawing.Point(179, 49);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(153, 22);
            this.textBox52.TabIndex = 313;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(15, 245);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(62, 16);
            this.label52.TabIndex = 312;
            this.label52.Text = "Remarks";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(15, 217);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(98, 16);
            this.label53.TabIndex = 311;
            this.label53.Text = "PTP Hold Date";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(15, 189);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(82, 16);
            this.label75.TabIndex = 310;
            this.label75.Text = "PTP Amount";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(15, 161);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(98, 16);
            this.label76.TabIndex = 309;
            this.label76.Text = "Contact Person";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(15, 133);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(90, 16);
            this.label79.TabIndex = 308;
            this.label79.Text = "Contact Place";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(15, 105);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(90, 16);
            this.label80.TabIndex = 307;
            this.label80.Text = "Contact Mode";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(15, 77);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(193, 16);
            this.label81.TabIndex = 306;
            this.label81.Text = "Action Code / Disposition Code";
            // 
            // button24
            // 
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Location = new System.Drawing.Point(18, 265);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 305;
            this.button24.Text = "Next Call";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(15, 49);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(88, 16);
            this.label82.TabIndex = 304;
            this.label82.Text = "Loan Number";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.Color.SandyBrown;
            this.label112.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.Location = new System.Drawing.Point(12, 21);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(54, 18);
            this.label112.TabIndex = 303;
            this.label112.Text = "Result";
            // 
            // label113
            // 
            this.label113.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label113.BackColor = System.Drawing.Color.Yellow;
            this.label113.Location = new System.Drawing.Point(211, 16);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(961, 25);
            this.label113.TabIndex = 301;
            this.label113.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label139
            // 
            this.label139.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label139.BackColor = System.Drawing.Color.SandyBrown;
            this.label139.Location = new System.Drawing.Point(7, 16);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(299, 25);
            this.label139.TabIndex = 302;
            this.label139.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_with_cp
            // 
            this.grp_with_cp.Controls.Add(this.button28);
            this.grp_with_cp.Controls.Add(this.label186);
            this.grp_with_cp.Controls.Add(this.comboBox9);
            this.grp_with_cp.Controls.Add(this.comboBox19);
            this.grp_with_cp.Controls.Add(this.label187);
            this.grp_with_cp.Controls.Add(this.comboBox20);
            this.grp_with_cp.Controls.Add(this.textBox17);
            this.grp_with_cp.Controls.Add(this.textBox18);
            this.grp_with_cp.Controls.Add(this.textBox19);
            this.grp_with_cp.Controls.Add(this.label188);
            this.grp_with_cp.Controls.Add(this.label189);
            this.grp_with_cp.Controls.Add(this.label190);
            this.grp_with_cp.Controls.Add(this.label191);
            this.grp_with_cp.Controls.Add(this.label192);
            this.grp_with_cp.Controls.Add(this.comboBox21);
            this.grp_with_cp.Controls.Add(this.comboBox22);
            this.grp_with_cp.Controls.Add(this.label193);
            this.grp_with_cp.Controls.Add(this.comboBox23);
            this.grp_with_cp.Controls.Add(this.textBox20);
            this.grp_with_cp.Controls.Add(this.textBox21);
            this.grp_with_cp.Controls.Add(this.textBox22);
            this.grp_with_cp.Controls.Add(this.label194);
            this.grp_with_cp.Controls.Add(this.label195);
            this.grp_with_cp.Controls.Add(this.label196);
            this.grp_with_cp.Controls.Add(this.label197);
            this.grp_with_cp.Controls.Add(this.label198);
            this.grp_with_cp.Controls.Add(this.comboBox24);
            this.grp_with_cp.Controls.Add(this.comboBox25);
            this.grp_with_cp.Controls.Add(this.textBox23);
            this.grp_with_cp.Controls.Add(this.textBox24);
            this.grp_with_cp.Controls.Add(this.textBox25);
            this.grp_with_cp.Controls.Add(this.textBox26);
            this.grp_with_cp.Controls.Add(this.label199);
            this.grp_with_cp.Controls.Add(this.label200);
            this.grp_with_cp.Controls.Add(this.label201);
            this.grp_with_cp.Controls.Add(this.label202);
            this.grp_with_cp.Controls.Add(this.label203);
            this.grp_with_cp.Controls.Add(this.button29);
            this.grp_with_cp.Controls.Add(this.label204);
            this.grp_with_cp.Controls.Add(this.button30);
            this.grp_with_cp.Controls.Add(this.label205);
            this.grp_with_cp.Controls.Add(this.label206);
            this.grp_with_cp.Controls.Add(this.label207);
            this.grp_with_cp.Location = new System.Drawing.Point(3, 500);
            this.grp_with_cp.Name = "grp_with_cp";
            this.grp_with_cp.Size = new System.Drawing.Size(1202, 292);
            this.grp_with_cp.TabIndex = 304;
            this.grp_with_cp.TabStop = false;
            // 
            // button28
            // 
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Location = new System.Drawing.Point(188, 228);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 384;
            this.button28.Text = "Callback";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.Location = new System.Drawing.Point(24, 228);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(143, 16);
            this.label186.TabIndex = 383;
            this.label186.Text = "Schedule For Callback";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox9.Location = new System.Drawing.Point(899, 80);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(153, 24);
            this.comboBox9.TabIndex = 382;
            // 
            // comboBox19
            // 
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox19.Location = new System.Drawing.Point(899, 194);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(153, 24);
            this.comboBox19.TabIndex = 381;
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.Location = new System.Drawing.Point(735, 194);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(90, 16);
            this.label187.TabIndex = 380;
            this.label187.Text = "PR Hold Date";
            // 
            // comboBox20
            // 
            this.comboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox20.Location = new System.Drawing.Point(899, 164);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(153, 24);
            this.comboBox20.TabIndex = 379;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(899, 136);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(153, 22);
            this.textBox17.TabIndex = 378;
            // 
            // textBox18
            // 
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox18.Location = new System.Drawing.Point(899, 108);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(153, 22);
            this.textBox18.TabIndex = 377;
            // 
            // textBox19
            // 
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox19.Location = new System.Drawing.Point(899, 52);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(153, 22);
            this.textBox19.TabIndex = 376;
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.Location = new System.Drawing.Point(735, 164);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(98, 16);
            this.label188.TabIndex = 375;
            this.label188.Text = "PTP Hold Date";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.Location = new System.Drawing.Point(735, 136);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(82, 16);
            this.label189.TabIndex = 374;
            this.label189.Text = "PTP Amount";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.Location = new System.Drawing.Point(735, 108);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(90, 16);
            this.label190.TabIndex = 373;
            this.label190.Text = "Contact Mode";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.Location = new System.Drawing.Point(735, 80);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(193, 16);
            this.label191.TabIndex = 372;
            this.label191.Text = "Action Code / Disposition Code";
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.Location = new System.Drawing.Point(735, 52);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(88, 16);
            this.label192.TabIndex = 371;
            this.label192.Text = "Loan Number";
            // 
            // comboBox21
            // 
            this.comboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox21.Location = new System.Drawing.Point(561, 80);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(153, 24);
            this.comboBox21.TabIndex = 370;
            // 
            // comboBox22
            // 
            this.comboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox22.Location = new System.Drawing.Point(561, 194);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(153, 24);
            this.comboBox22.TabIndex = 369;
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.Location = new System.Drawing.Point(397, 194);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(90, 16);
            this.label193.TabIndex = 368;
            this.label193.Text = "PR Hold Date";
            // 
            // comboBox23
            // 
            this.comboBox23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox23.Location = new System.Drawing.Point(561, 164);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(153, 24);
            this.comboBox23.TabIndex = 367;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox20.Location = new System.Drawing.Point(561, 136);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(153, 22);
            this.textBox20.TabIndex = 366;
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox21.Location = new System.Drawing.Point(561, 108);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(153, 22);
            this.textBox21.TabIndex = 365;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox22.Location = new System.Drawing.Point(561, 52);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(153, 22);
            this.textBox22.TabIndex = 364;
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.Location = new System.Drawing.Point(397, 164);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(98, 16);
            this.label194.TabIndex = 363;
            this.label194.Text = "PTP Hold Date";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.Location = new System.Drawing.Point(397, 136);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(82, 16);
            this.label195.TabIndex = 362;
            this.label195.Text = "PTP Amount";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.Location = new System.Drawing.Point(397, 108);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(90, 16);
            this.label196.TabIndex = 361;
            this.label196.Text = "Contact Mode";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.Location = new System.Drawing.Point(397, 80);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(193, 16);
            this.label197.TabIndex = 360;
            this.label197.Text = "Action Code / Disposition Code";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.Location = new System.Drawing.Point(397, 52);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(88, 16);
            this.label198.TabIndex = 359;
            this.label198.Text = "Loan Number";
            // 
            // comboBox24
            // 
            this.comboBox24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox24.Location = new System.Drawing.Point(188, 164);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(153, 24);
            this.comboBox24.TabIndex = 358;
            // 
            // comboBox25
            // 
            this.comboBox25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox25.Location = new System.Drawing.Point(188, 136);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(153, 24);
            this.comboBox25.TabIndex = 357;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox23.Location = new System.Drawing.Point(188, 194);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(153, 22);
            this.textBox23.TabIndex = 356;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox24.Location = new System.Drawing.Point(188, 108);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(153, 22);
            this.textBox24.TabIndex = 355;
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox25.Location = new System.Drawing.Point(188, 80);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(153, 22);
            this.textBox25.TabIndex = 354;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox26.Location = new System.Drawing.Point(188, 52);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(153, 22);
            this.textBox26.TabIndex = 353;
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.Location = new System.Drawing.Point(24, 194);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(62, 16);
            this.label199.TabIndex = 352;
            this.label199.Text = "Remarks";
            // 
            // label200
            // 
            this.label200.AutoSize = true;
            this.label200.Location = new System.Drawing.Point(24, 164);
            this.label200.Name = "label200";
            this.label200.Size = new System.Drawing.Size(98, 16);
            this.label200.TabIndex = 351;
            this.label200.Text = "Contact Person";
            // 
            // label201
            // 
            this.label201.AutoSize = true;
            this.label201.Location = new System.Drawing.Point(24, 136);
            this.label201.Name = "label201";
            this.label201.Size = new System.Drawing.Size(90, 16);
            this.label201.TabIndex = 350;
            this.label201.Text = "Contact Place";
            // 
            // label202
            // 
            this.label202.AutoSize = true;
            this.label202.Location = new System.Drawing.Point(24, 108);
            this.label202.Name = "label202";
            this.label202.Size = new System.Drawing.Size(90, 16);
            this.label202.TabIndex = 349;
            this.label202.Text = "Contact Mode";
            // 
            // label203
            // 
            this.label203.AutoSize = true;
            this.label203.Location = new System.Drawing.Point(24, 80);
            this.label203.Name = "label203";
            this.label203.Size = new System.Drawing.Size(193, 16);
            this.label203.TabIndex = 348;
            this.label203.Text = "Action Code / Disposition Code";
            // 
            // button29
            // 
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Location = new System.Drawing.Point(188, 257);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(75, 23);
            this.button29.TabIndex = 347;
            this.button29.Text = "Next Call";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // label204
            // 
            this.label204.AutoSize = true;
            this.label204.Location = new System.Drawing.Point(24, 52);
            this.label204.Name = "label204";
            this.label204.Size = new System.Drawing.Size(88, 16);
            this.label204.TabIndex = 346;
            this.label204.Text = "Loan Number";
            // 
            // button30
            // 
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(271, 257);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 345;
            this.button30.Text = "Cancel";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // label205
            // 
            this.label205.AutoSize = true;
            this.label205.BackColor = System.Drawing.Color.SandyBrown;
            this.label205.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label205.Location = new System.Drawing.Point(12, 21);
            this.label205.Name = "label205";
            this.label205.Size = new System.Drawing.Size(54, 18);
            this.label205.TabIndex = 303;
            this.label205.Text = "Result";
            // 
            // label206
            // 
            this.label206.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label206.BackColor = System.Drawing.Color.Yellow;
            this.label206.Location = new System.Drawing.Point(211, 16);
            this.label206.Name = "label206";
            this.label206.Size = new System.Drawing.Size(973, 25);
            this.label206.TabIndex = 301;
            this.label206.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label207
            // 
            this.label207.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label207.BackColor = System.Drawing.Color.SandyBrown;
            this.label207.Location = new System.Drawing.Point(7, 16);
            this.label207.Name = "label207";
            this.label207.Size = new System.Drawing.Size(311, 25);
            this.label207.TabIndex = 302;
            this.label207.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grp_other_phone
            // 
            this.grp_other_phone.Controls.Add(this.button31);
            this.grp_other_phone.Controls.Add(this.label208);
            this.grp_other_phone.Controls.Add(this.comboBox26);
            this.grp_other_phone.Controls.Add(this.textBox34);
            this.grp_other_phone.Controls.Add(this.label209);
            this.grp_other_phone.Controls.Add(this.label210);
            this.grp_other_phone.Controls.Add(this.comboBox27);
            this.grp_other_phone.Controls.Add(this.textBox36);
            this.grp_other_phone.Controls.Add(this.label211);
            this.grp_other_phone.Controls.Add(this.label212);
            this.grp_other_phone.Controls.Add(this.comboBox28);
            this.grp_other_phone.Controls.Add(this.comboBox29);
            this.grp_other_phone.Controls.Add(this.textBox27);
            this.grp_other_phone.Controls.Add(this.textBox38);
            this.grp_other_phone.Controls.Add(this.textBox40);
            this.grp_other_phone.Controls.Add(this.textBox28);
            this.grp_other_phone.Controls.Add(this.label213);
            this.grp_other_phone.Controls.Add(this.label214);
            this.grp_other_phone.Controls.Add(this.label215);
            this.grp_other_phone.Controls.Add(this.label216);
            this.grp_other_phone.Controls.Add(this.label217);
            this.grp_other_phone.Controls.Add(this.button32);
            this.grp_other_phone.Controls.Add(this.label218);
            this.grp_other_phone.Controls.Add(this.button33);
            this.grp_other_phone.Controls.Add(this.label219);
            this.grp_other_phone.Controls.Add(this.label220);
            this.grp_other_phone.Controls.Add(this.label221);
            this.grp_other_phone.Location = new System.Drawing.Point(3, 494);
            this.grp_other_phone.Name = "grp_other_phone";
            this.grp_other_phone.Size = new System.Drawing.Size(1202, 292);
            this.grp_other_phone.TabIndex = 305;
            this.grp_other_phone.TabStop = false;
            // 
            // button31
            // 
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(187, 226);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(92, 23);
            this.button31.TabIndex = 368;
            this.button31.Text = "Setup Callback";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // label208
            // 
            this.label208.AutoSize = true;
            this.label208.Location = new System.Drawing.Point(23, 226);
            this.label208.Name = "label208";
            this.label208.Size = new System.Drawing.Size(143, 16);
            this.label208.TabIndex = 367;
            this.label208.Text = "Schedule For Callback";
            // 
            // comboBox26
            // 
            this.comboBox26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox26.Location = new System.Drawing.Point(898, 78);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(153, 24);
            this.comboBox26.TabIndex = 366;
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox34.Location = new System.Drawing.Point(898, 50);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(153, 22);
            this.textBox34.TabIndex = 365;
            // 
            // label209
            // 
            this.label209.AutoSize = true;
            this.label209.Location = new System.Drawing.Point(734, 78);
            this.label209.Name = "label209";
            this.label209.Size = new System.Drawing.Size(193, 16);
            this.label209.TabIndex = 364;
            this.label209.Text = "Action Code / Disposition Code";
            // 
            // label210
            // 
            this.label210.AutoSize = true;
            this.label210.Location = new System.Drawing.Point(734, 50);
            this.label210.Name = "label210";
            this.label210.Size = new System.Drawing.Size(88, 16);
            this.label210.TabIndex = 363;
            this.label210.Text = "Loan Number";
            // 
            // comboBox27
            // 
            this.comboBox27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox27.Location = new System.Drawing.Point(560, 78);
            this.comboBox27.Name = "comboBox27";
            this.comboBox27.Size = new System.Drawing.Size(153, 24);
            this.comboBox27.TabIndex = 362;
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox36.Location = new System.Drawing.Point(560, 50);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(153, 22);
            this.textBox36.TabIndex = 361;
            // 
            // label211
            // 
            this.label211.AutoSize = true;
            this.label211.Location = new System.Drawing.Point(396, 78);
            this.label211.Name = "label211";
            this.label211.Size = new System.Drawing.Size(193, 16);
            this.label211.TabIndex = 360;
            this.label211.Text = "Action Code / Disposition Code";
            // 
            // label212
            // 
            this.label212.AutoSize = true;
            this.label212.Location = new System.Drawing.Point(396, 50);
            this.label212.Name = "label212";
            this.label212.Size = new System.Drawing.Size(88, 16);
            this.label212.TabIndex = 359;
            this.label212.Text = "Loan Number";
            // 
            // comboBox28
            // 
            this.comboBox28.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox28.FormattingEnabled = true;
            this.comboBox28.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox28.Location = new System.Drawing.Point(187, 162);
            this.comboBox28.Name = "comboBox28";
            this.comboBox28.Size = new System.Drawing.Size(153, 24);
            this.comboBox28.TabIndex = 358;
            // 
            // comboBox29
            // 
            this.comboBox29.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox29.FormattingEnabled = true;
            this.comboBox29.Items.AddRange(new object[] {
            "PTP"});
            this.comboBox29.Location = new System.Drawing.Point(187, 134);
            this.comboBox29.Name = "comboBox29";
            this.comboBox29.Size = new System.Drawing.Size(153, 24);
            this.comboBox29.TabIndex = 357;
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox27.Location = new System.Drawing.Point(187, 192);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(153, 22);
            this.textBox27.TabIndex = 356;
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox38.Location = new System.Drawing.Point(187, 106);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(153, 22);
            this.textBox38.TabIndex = 355;
            // 
            // textBox40
            // 
            this.textBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox40.Location = new System.Drawing.Point(187, 78);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(153, 22);
            this.textBox40.TabIndex = 354;
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox28.Location = new System.Drawing.Point(187, 50);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(153, 22);
            this.textBox28.TabIndex = 353;
            // 
            // label213
            // 
            this.label213.AutoSize = true;
            this.label213.Location = new System.Drawing.Point(23, 192);
            this.label213.Name = "label213";
            this.label213.Size = new System.Drawing.Size(62, 16);
            this.label213.TabIndex = 352;
            this.label213.Text = "Remarks";
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Location = new System.Drawing.Point(23, 162);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(98, 16);
            this.label214.TabIndex = 351;
            this.label214.Text = "Contact Person";
            // 
            // label215
            // 
            this.label215.AutoSize = true;
            this.label215.Location = new System.Drawing.Point(23, 134);
            this.label215.Name = "label215";
            this.label215.Size = new System.Drawing.Size(90, 16);
            this.label215.TabIndex = 350;
            this.label215.Text = "Contact Place";
            // 
            // label216
            // 
            this.label216.AutoSize = true;
            this.label216.Location = new System.Drawing.Point(23, 106);
            this.label216.Name = "label216";
            this.label216.Size = new System.Drawing.Size(90, 16);
            this.label216.TabIndex = 349;
            this.label216.Text = "Contact Mode";
            // 
            // label217
            // 
            this.label217.AutoSize = true;
            this.label217.Location = new System.Drawing.Point(23, 78);
            this.label217.Name = "label217";
            this.label217.Size = new System.Drawing.Size(193, 16);
            this.label217.TabIndex = 348;
            this.label217.Text = "Action Code / Disposition Code";
            // 
            // button32
            // 
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(187, 255);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(92, 23);
            this.button32.TabIndex = 347;
            this.button32.Text = "Save Activity";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // label218
            // 
            this.label218.AutoSize = true;
            this.label218.Location = new System.Drawing.Point(23, 50);
            this.label218.Name = "label218";
            this.label218.Size = new System.Drawing.Size(88, 16);
            this.label218.TabIndex = 346;
            this.label218.Text = "Loan Number";
            // 
            // button33
            // 
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(285, 254);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(75, 23);
            this.button33.TabIndex = 345;
            this.button33.Text = "Cancel";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // label219
            // 
            this.label219.AutoSize = true;
            this.label219.BackColor = System.Drawing.Color.SandyBrown;
            this.label219.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label219.Location = new System.Drawing.Point(12, 21);
            this.label219.Name = "label219";
            this.label219.Size = new System.Drawing.Size(54, 18);
            this.label219.TabIndex = 303;
            this.label219.Text = "Result";
            // 
            // label220
            // 
            this.label220.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label220.BackColor = System.Drawing.Color.Yellow;
            this.label220.Location = new System.Drawing.Point(211, 16);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(973, 25);
            this.label220.TabIndex = 301;
            this.label220.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label221
            // 
            this.label221.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label221.BackColor = System.Drawing.Color.SandyBrown;
            this.label221.Location = new System.Drawing.Point(7, 16);
            this.label221.Name = "label221";
            this.label221.Size = new System.Drawing.Size(311, 25);
            this.label221.TabIndex = 302;
            this.label221.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoTabPage
            // 
            this.infoTabPage.BackColor = System.Drawing.Color.White;
            this.infoTabPage.Controls.Add(this.panel2);
            this.infoTabPage.Location = new System.Drawing.Point(4, 39);
            this.infoTabPage.Name = "infoTabPage";
            this.infoTabPage.Size = new System.Drawing.Size(1226, 518);
            this.infoTabPage.TabIndex = 2;
            this.infoTabPage.Text = "Additional Information";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox9);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1226, 518);
            this.panel2.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblREMARKS8);
            this.groupBox7.Controls.Add(this.lblREMARKS7);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY8);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY7);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED8);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED7);
            this.groupBox7.Controls.Add(this.lblACTION_CODE8);
            this.groupBox7.Controls.Add(this.lblACTION_CODE7);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE8);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE7);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE8);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE7);
            this.groupBox7.Controls.Add(this.lblREMARKS6);
            this.groupBox7.Controls.Add(this.lblREMARKS5);
            this.groupBox7.Controls.Add(this.lblREMARKS4);
            this.groupBox7.Controls.Add(this.lblREMARKS3);
            this.groupBox7.Controls.Add(this.lblREMARKS2);
            this.groupBox7.Controls.Add(this.lblREMARKS1);
            this.groupBox7.Controls.Add(this.label175);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY6);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY5);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY4);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY3);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY2);
            this.groupBox7.Controls.Add(this.lblCONTACTED_BY1);
            this.groupBox7.Controls.Add(this.label167);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED6);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED5);
            this.groupBox7.Controls.Add(this.lblACTION_CODE6);
            this.groupBox7.Controls.Add(this.lblACTION_CODE5);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE6);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE5);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE6);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE5);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED4);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED3);
            this.groupBox7.Controls.Add(this.lblACTION_CODE4);
            this.groupBox7.Controls.Add(this.lblACTION_CODE3);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE4);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE3);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE4);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE3);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED2);
            this.groupBox7.Controls.Add(this.lblPERSON_CONTACTED1);
            this.groupBox7.Controls.Add(this.lblACTION_CODE2);
            this.groupBox7.Controls.Add(this.lblACTION_CODE1);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE2);
            this.groupBox7.Controls.Add(this.lblCONTACT_PLACE1);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE2);
            this.groupBox7.Controls.Add(this.lblCONTACT_DATE1);
            this.groupBox7.Controls.Add(this.label152);
            this.groupBox7.Controls.Add(this.label153);
            this.groupBox7.Controls.Add(this.label154);
            this.groupBox7.Controls.Add(this.label155);
            this.groupBox7.Controls.Add(this.label158);
            this.groupBox7.Controls.Add(this.label159);
            this.groupBox7.Controls.Add(this.label160);
            this.groupBox7.Controls.Add(this.label161);
            this.groupBox7.Location = new System.Drawing.Point(6, 483);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1190, 289);
            this.groupBox7.TabIndex = 361;
            this.groupBox7.TabStop = false;
            // 
            // lblREMARKS8
            // 
            this.lblREMARKS8.AutoSize = true;
            this.lblREMARKS8.Location = new System.Drawing.Point(970, 236);
            this.lblREMARKS8.Name = "lblREMARKS8";
            this.lblREMARKS8.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS8.TabIndex = 406;
            this.lblREMARKS8.Text = "lblREMARKS8";
            // 
            // lblREMARKS7
            // 
            this.lblREMARKS7.AutoSize = true;
            this.lblREMARKS7.Location = new System.Drawing.Point(970, 213);
            this.lblREMARKS7.Name = "lblREMARKS7";
            this.lblREMARKS7.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS7.TabIndex = 405;
            this.lblREMARKS7.Text = "lblREMARKS7";
            // 
            // lblCONTACTED_BY8
            // 
            this.lblCONTACTED_BY8.AutoSize = true;
            this.lblCONTACTED_BY8.Location = new System.Drawing.Point(764, 237);
            this.lblCONTACTED_BY8.Name = "lblCONTACTED_BY8";
            this.lblCONTACTED_BY8.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY8.TabIndex = 404;
            this.lblCONTACTED_BY8.Text = "lblCONTACTED_BY8";
            // 
            // lblCONTACTED_BY7
            // 
            this.lblCONTACTED_BY7.AutoSize = true;
            this.lblCONTACTED_BY7.Location = new System.Drawing.Point(764, 214);
            this.lblCONTACTED_BY7.Name = "lblCONTACTED_BY7";
            this.lblCONTACTED_BY7.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY7.TabIndex = 403;
            this.lblCONTACTED_BY7.Text = "lblCONTACTED_BY7";
            // 
            // lblPERSON_CONTACTED8
            // 
            this.lblPERSON_CONTACTED8.AutoSize = true;
            this.lblPERSON_CONTACTED8.Location = new System.Drawing.Point(293, 237);
            this.lblPERSON_CONTACTED8.Name = "lblPERSON_CONTACTED8";
            this.lblPERSON_CONTACTED8.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED8.TabIndex = 402;
            this.lblPERSON_CONTACTED8.Text = "lblPERSON_CONTACTED8";
            // 
            // lblPERSON_CONTACTED7
            // 
            this.lblPERSON_CONTACTED7.AutoSize = true;
            this.lblPERSON_CONTACTED7.Location = new System.Drawing.Point(293, 214);
            this.lblPERSON_CONTACTED7.Name = "lblPERSON_CONTACTED7";
            this.lblPERSON_CONTACTED7.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED7.TabIndex = 401;
            this.lblPERSON_CONTACTED7.Text = "lblPERSON_CONTACTED7";
            // 
            // lblACTION_CODE8
            // 
            this.lblACTION_CODE8.AutoSize = true;
            this.lblACTION_CODE8.Location = new System.Drawing.Point(495, 237);
            this.lblACTION_CODE8.Name = "lblACTION_CODE8";
            this.lblACTION_CODE8.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE8.TabIndex = 400;
            this.lblACTION_CODE8.Text = "lblACTION_CODE8";
            // 
            // lblACTION_CODE7
            // 
            this.lblACTION_CODE7.AutoSize = true;
            this.lblACTION_CODE7.Location = new System.Drawing.Point(495, 214);
            this.lblACTION_CODE7.Name = "lblACTION_CODE7";
            this.lblACTION_CODE7.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE7.TabIndex = 399;
            this.lblACTION_CODE7.Text = "lblACTION_CODE7";
            // 
            // lblCONTACT_PLACE8
            // 
            this.lblCONTACT_PLACE8.AutoSize = true;
            this.lblCONTACT_PLACE8.Location = new System.Drawing.Point(160, 237);
            this.lblCONTACT_PLACE8.Name = "lblCONTACT_PLACE8";
            this.lblCONTACT_PLACE8.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE8.TabIndex = 398;
            this.lblCONTACT_PLACE8.Text = "lblCONTACT_PLACE8";
            // 
            // lblCONTACT_PLACE7
            // 
            this.lblCONTACT_PLACE7.AutoSize = true;
            this.lblCONTACT_PLACE7.Location = new System.Drawing.Point(160, 214);
            this.lblCONTACT_PLACE7.Name = "lblCONTACT_PLACE7";
            this.lblCONTACT_PLACE7.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE7.TabIndex = 397;
            this.lblCONTACT_PLACE7.Text = "lblCONTACT_PLACE7";
            // 
            // lblCONTACT_DATE8
            // 
            this.lblCONTACT_DATE8.AutoSize = true;
            this.lblCONTACT_DATE8.Location = new System.Drawing.Point(10, 237);
            this.lblCONTACT_DATE8.Name = "lblCONTACT_DATE8";
            this.lblCONTACT_DATE8.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE8.TabIndex = 396;
            this.lblCONTACT_DATE8.Text = "lblCONTACT_DATE8";
            // 
            // lblCONTACT_DATE7
            // 
            this.lblCONTACT_DATE7.AutoSize = true;
            this.lblCONTACT_DATE7.Location = new System.Drawing.Point(10, 214);
            this.lblCONTACT_DATE7.Name = "lblCONTACT_DATE7";
            this.lblCONTACT_DATE7.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE7.TabIndex = 395;
            this.lblCONTACT_DATE7.Text = "lblCONTACT_DATE7";
            // 
            // lblREMARKS6
            // 
            this.lblREMARKS6.AutoSize = true;
            this.lblREMARKS6.Location = new System.Drawing.Point(970, 190);
            this.lblREMARKS6.Name = "lblREMARKS6";
            this.lblREMARKS6.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS6.TabIndex = 394;
            this.lblREMARKS6.Text = "lblREMARKS6";
            // 
            // lblREMARKS5
            // 
            this.lblREMARKS5.AutoSize = true;
            this.lblREMARKS5.Location = new System.Drawing.Point(970, 167);
            this.lblREMARKS5.Name = "lblREMARKS5";
            this.lblREMARKS5.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS5.TabIndex = 393;
            this.lblREMARKS5.Text = "lblREMARKS5";
            // 
            // lblREMARKS4
            // 
            this.lblREMARKS4.AutoSize = true;
            this.lblREMARKS4.Location = new System.Drawing.Point(970, 144);
            this.lblREMARKS4.Name = "lblREMARKS4";
            this.lblREMARKS4.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS4.TabIndex = 392;
            this.lblREMARKS4.Text = "lblREMARKS4";
            // 
            // lblREMARKS3
            // 
            this.lblREMARKS3.AutoSize = true;
            this.lblREMARKS3.Location = new System.Drawing.Point(970, 121);
            this.lblREMARKS3.Name = "lblREMARKS3";
            this.lblREMARKS3.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS3.TabIndex = 391;
            this.lblREMARKS3.Text = "lblREMARKS3";
            // 
            // lblREMARKS2
            // 
            this.lblREMARKS2.AutoSize = true;
            this.lblREMARKS2.Location = new System.Drawing.Point(970, 98);
            this.lblREMARKS2.Name = "lblREMARKS2";
            this.lblREMARKS2.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS2.TabIndex = 390;
            this.lblREMARKS2.Text = "lblREMARKS2";
            // 
            // lblREMARKS1
            // 
            this.lblREMARKS1.AutoSize = true;
            this.lblREMARKS1.Location = new System.Drawing.Point(970, 75);
            this.lblREMARKS1.Name = "lblREMARKS1";
            this.lblREMARKS1.Size = new System.Drawing.Size(94, 16);
            this.lblREMARKS1.TabIndex = 389;
            this.lblREMARKS1.Text = "lblREMARKS1";
            // 
            // label175
            // 
            this.label175.BackColor = System.Drawing.Color.Yellow;
            this.label175.Location = new System.Drawing.Point(970, 42);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(201, 23);
            this.label175.TabIndex = 388;
            this.label175.Text = "Person Contacted";
            this.label175.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCONTACTED_BY6
            // 
            this.lblCONTACTED_BY6.AutoSize = true;
            this.lblCONTACTED_BY6.Location = new System.Drawing.Point(764, 191);
            this.lblCONTACTED_BY6.Name = "lblCONTACTED_BY6";
            this.lblCONTACTED_BY6.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY6.TabIndex = 387;
            this.lblCONTACTED_BY6.Text = "lblCONTACTED_BY6";
            // 
            // lblCONTACTED_BY5
            // 
            this.lblCONTACTED_BY5.AutoSize = true;
            this.lblCONTACTED_BY5.Location = new System.Drawing.Point(764, 168);
            this.lblCONTACTED_BY5.Name = "lblCONTACTED_BY5";
            this.lblCONTACTED_BY5.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY5.TabIndex = 386;
            this.lblCONTACTED_BY5.Text = "lblCONTACTED_BY5";
            // 
            // lblCONTACTED_BY4
            // 
            this.lblCONTACTED_BY4.AutoSize = true;
            this.lblCONTACTED_BY4.Location = new System.Drawing.Point(764, 145);
            this.lblCONTACTED_BY4.Name = "lblCONTACTED_BY4";
            this.lblCONTACTED_BY4.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY4.TabIndex = 385;
            this.lblCONTACTED_BY4.Text = "lblCONTACTED_BY4";
            // 
            // lblCONTACTED_BY3
            // 
            this.lblCONTACTED_BY3.AutoSize = true;
            this.lblCONTACTED_BY3.Location = new System.Drawing.Point(764, 122);
            this.lblCONTACTED_BY3.Name = "lblCONTACTED_BY3";
            this.lblCONTACTED_BY3.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY3.TabIndex = 384;
            this.lblCONTACTED_BY3.Text = "lblCONTACTED_BY3";
            // 
            // lblCONTACTED_BY2
            // 
            this.lblCONTACTED_BY2.AutoSize = true;
            this.lblCONTACTED_BY2.Location = new System.Drawing.Point(764, 99);
            this.lblCONTACTED_BY2.Name = "lblCONTACTED_BY2";
            this.lblCONTACTED_BY2.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY2.TabIndex = 383;
            this.lblCONTACTED_BY2.Text = "lblCONTACTED_BY2";
            // 
            // lblCONTACTED_BY1
            // 
            this.lblCONTACTED_BY1.AutoSize = true;
            this.lblCONTACTED_BY1.Location = new System.Drawing.Point(764, 76);
            this.lblCONTACTED_BY1.Name = "lblCONTACTED_BY1";
            this.lblCONTACTED_BY1.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACTED_BY1.TabIndex = 382;
            this.lblCONTACTED_BY1.Text = "lblCONTACTED_BY1";
            // 
            // label167
            // 
            this.label167.BackColor = System.Drawing.Color.Yellow;
            this.label167.Location = new System.Drawing.Point(764, 43);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(206, 23);
            this.label167.TabIndex = 381;
            this.label167.Text = "Contact Place";
            this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPERSON_CONTACTED6
            // 
            this.lblPERSON_CONTACTED6.AutoSize = true;
            this.lblPERSON_CONTACTED6.Location = new System.Drawing.Point(293, 191);
            this.lblPERSON_CONTACTED6.Name = "lblPERSON_CONTACTED6";
            this.lblPERSON_CONTACTED6.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED6.TabIndex = 380;
            this.lblPERSON_CONTACTED6.Text = "lblPERSON_CONTACTED6";
            // 
            // lblPERSON_CONTACTED5
            // 
            this.lblPERSON_CONTACTED5.AutoSize = true;
            this.lblPERSON_CONTACTED5.Location = new System.Drawing.Point(293, 168);
            this.lblPERSON_CONTACTED5.Name = "lblPERSON_CONTACTED5";
            this.lblPERSON_CONTACTED5.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED5.TabIndex = 379;
            this.lblPERSON_CONTACTED5.Text = "lblPERSON_CONTACTED5";
            // 
            // lblACTION_CODE6
            // 
            this.lblACTION_CODE6.AutoSize = true;
            this.lblACTION_CODE6.Location = new System.Drawing.Point(495, 191);
            this.lblACTION_CODE6.Name = "lblACTION_CODE6";
            this.lblACTION_CODE6.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE6.TabIndex = 378;
            this.lblACTION_CODE6.Text = "lblACTION_CODE6";
            // 
            // lblACTION_CODE5
            // 
            this.lblACTION_CODE5.AutoSize = true;
            this.lblACTION_CODE5.Location = new System.Drawing.Point(495, 168);
            this.lblACTION_CODE5.Name = "lblACTION_CODE5";
            this.lblACTION_CODE5.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE5.TabIndex = 377;
            this.lblACTION_CODE5.Text = "lblACTION_CODE5";
            // 
            // lblCONTACT_PLACE6
            // 
            this.lblCONTACT_PLACE6.AutoSize = true;
            this.lblCONTACT_PLACE6.Location = new System.Drawing.Point(160, 191);
            this.lblCONTACT_PLACE6.Name = "lblCONTACT_PLACE6";
            this.lblCONTACT_PLACE6.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE6.TabIndex = 376;
            this.lblCONTACT_PLACE6.Text = "lblCONTACT_PLACE6";
            // 
            // lblCONTACT_PLACE5
            // 
            this.lblCONTACT_PLACE5.AutoSize = true;
            this.lblCONTACT_PLACE5.Location = new System.Drawing.Point(160, 168);
            this.lblCONTACT_PLACE5.Name = "lblCONTACT_PLACE5";
            this.lblCONTACT_PLACE5.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE5.TabIndex = 375;
            this.lblCONTACT_PLACE5.Text = "lblCONTACT_PLACE5";
            // 
            // lblCONTACT_DATE6
            // 
            this.lblCONTACT_DATE6.AutoSize = true;
            this.lblCONTACT_DATE6.Location = new System.Drawing.Point(10, 191);
            this.lblCONTACT_DATE6.Name = "lblCONTACT_DATE6";
            this.lblCONTACT_DATE6.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE6.TabIndex = 374;
            this.lblCONTACT_DATE6.Text = "lblCONTACT_DATE6";
            // 
            // lblCONTACT_DATE5
            // 
            this.lblCONTACT_DATE5.AutoSize = true;
            this.lblCONTACT_DATE5.Location = new System.Drawing.Point(10, 168);
            this.lblCONTACT_DATE5.Name = "lblCONTACT_DATE5";
            this.lblCONTACT_DATE5.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE5.TabIndex = 373;
            this.lblCONTACT_DATE5.Text = "lblCONTACT_DATE5";
            // 
            // lblPERSON_CONTACTED4
            // 
            this.lblPERSON_CONTACTED4.AutoSize = true;
            this.lblPERSON_CONTACTED4.Location = new System.Drawing.Point(293, 145);
            this.lblPERSON_CONTACTED4.Name = "lblPERSON_CONTACTED4";
            this.lblPERSON_CONTACTED4.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED4.TabIndex = 372;
            this.lblPERSON_CONTACTED4.Text = "lblPERSON_CONTACTED4";
            // 
            // lblPERSON_CONTACTED3
            // 
            this.lblPERSON_CONTACTED3.AutoSize = true;
            this.lblPERSON_CONTACTED3.Location = new System.Drawing.Point(293, 122);
            this.lblPERSON_CONTACTED3.Name = "lblPERSON_CONTACTED3";
            this.lblPERSON_CONTACTED3.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED3.TabIndex = 371;
            this.lblPERSON_CONTACTED3.Text = "lblPERSON_CONTACTED3";
            // 
            // lblACTION_CODE4
            // 
            this.lblACTION_CODE4.AutoSize = true;
            this.lblACTION_CODE4.Location = new System.Drawing.Point(495, 145);
            this.lblACTION_CODE4.Name = "lblACTION_CODE4";
            this.lblACTION_CODE4.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE4.TabIndex = 370;
            this.lblACTION_CODE4.Text = "lblACTION_CODE4";
            // 
            // lblACTION_CODE3
            // 
            this.lblACTION_CODE3.AutoSize = true;
            this.lblACTION_CODE3.Location = new System.Drawing.Point(495, 122);
            this.lblACTION_CODE3.Name = "lblACTION_CODE3";
            this.lblACTION_CODE3.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE3.TabIndex = 369;
            this.lblACTION_CODE3.Text = "lblACTION_CODE3";
            // 
            // lblCONTACT_PLACE4
            // 
            this.lblCONTACT_PLACE4.AutoSize = true;
            this.lblCONTACT_PLACE4.Location = new System.Drawing.Point(160, 145);
            this.lblCONTACT_PLACE4.Name = "lblCONTACT_PLACE4";
            this.lblCONTACT_PLACE4.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE4.TabIndex = 368;
            this.lblCONTACT_PLACE4.Text = "lblCONTACT_PLACE4";
            // 
            // lblCONTACT_PLACE3
            // 
            this.lblCONTACT_PLACE3.AutoSize = true;
            this.lblCONTACT_PLACE3.Location = new System.Drawing.Point(160, 122);
            this.lblCONTACT_PLACE3.Name = "lblCONTACT_PLACE3";
            this.lblCONTACT_PLACE3.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE3.TabIndex = 367;
            this.lblCONTACT_PLACE3.Text = "lblCONTACT_PLACE3";
            // 
            // lblCONTACT_DATE4
            // 
            this.lblCONTACT_DATE4.AutoSize = true;
            this.lblCONTACT_DATE4.Location = new System.Drawing.Point(10, 145);
            this.lblCONTACT_DATE4.Name = "lblCONTACT_DATE4";
            this.lblCONTACT_DATE4.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE4.TabIndex = 366;
            this.lblCONTACT_DATE4.Text = "lblCONTACT_DATE4";
            // 
            // lblCONTACT_DATE3
            // 
            this.lblCONTACT_DATE3.AutoSize = true;
            this.lblCONTACT_DATE3.Location = new System.Drawing.Point(10, 122);
            this.lblCONTACT_DATE3.Name = "lblCONTACT_DATE3";
            this.lblCONTACT_DATE3.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE3.TabIndex = 365;
            this.lblCONTACT_DATE3.Text = "lblCONTACT_DATE3";
            // 
            // lblPERSON_CONTACTED2
            // 
            this.lblPERSON_CONTACTED2.AutoSize = true;
            this.lblPERSON_CONTACTED2.Location = new System.Drawing.Point(293, 99);
            this.lblPERSON_CONTACTED2.Name = "lblPERSON_CONTACTED2";
            this.lblPERSON_CONTACTED2.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED2.TabIndex = 364;
            this.lblPERSON_CONTACTED2.Text = "lblPERSON_CONTACTED2";
            // 
            // lblPERSON_CONTACTED1
            // 
            this.lblPERSON_CONTACTED1.AutoSize = true;
            this.lblPERSON_CONTACTED1.Location = new System.Drawing.Point(293, 76);
            this.lblPERSON_CONTACTED1.Name = "lblPERSON_CONTACTED1";
            this.lblPERSON_CONTACTED1.Size = new System.Drawing.Size(176, 16);
            this.lblPERSON_CONTACTED1.TabIndex = 363;
            this.lblPERSON_CONTACTED1.Text = "lblPERSON_CONTACTED1";
            // 
            // lblACTION_CODE2
            // 
            this.lblACTION_CODE2.AutoSize = true;
            this.lblACTION_CODE2.Location = new System.Drawing.Point(495, 99);
            this.lblACTION_CODE2.Name = "lblACTION_CODE2";
            this.lblACTION_CODE2.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE2.TabIndex = 362;
            this.lblACTION_CODE2.Text = "lblACTION_CODE2";
            // 
            // lblACTION_CODE1
            // 
            this.lblACTION_CODE1.AutoSize = true;
            this.lblACTION_CODE1.Location = new System.Drawing.Point(495, 76);
            this.lblACTION_CODE1.Name = "lblACTION_CODE1";
            this.lblACTION_CODE1.Size = new System.Drawing.Size(123, 16);
            this.lblACTION_CODE1.TabIndex = 361;
            this.lblACTION_CODE1.Text = "lblACTION_CODE1";
            // 
            // lblCONTACT_PLACE2
            // 
            this.lblCONTACT_PLACE2.AutoSize = true;
            this.lblCONTACT_PLACE2.Location = new System.Drawing.Point(160, 99);
            this.lblCONTACT_PLACE2.Name = "lblCONTACT_PLACE2";
            this.lblCONTACT_PLACE2.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE2.TabIndex = 360;
            this.lblCONTACT_PLACE2.Text = "lblCONTACT_PLACE2";
            // 
            // lblCONTACT_PLACE1
            // 
            this.lblCONTACT_PLACE1.AutoSize = true;
            this.lblCONTACT_PLACE1.Location = new System.Drawing.Point(160, 76);
            this.lblCONTACT_PLACE1.Name = "lblCONTACT_PLACE1";
            this.lblCONTACT_PLACE1.Size = new System.Drawing.Size(143, 16);
            this.lblCONTACT_PLACE1.TabIndex = 359;
            this.lblCONTACT_PLACE1.Text = "lblCONTACT_PLACE1";
            // 
            // lblCONTACT_DATE2
            // 
            this.lblCONTACT_DATE2.AutoSize = true;
            this.lblCONTACT_DATE2.Location = new System.Drawing.Point(10, 99);
            this.lblCONTACT_DATE2.Name = "lblCONTACT_DATE2";
            this.lblCONTACT_DATE2.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE2.TabIndex = 358;
            this.lblCONTACT_DATE2.Text = "lblCONTACT_DATE2";
            // 
            // lblCONTACT_DATE1
            // 
            this.lblCONTACT_DATE1.AutoSize = true;
            this.lblCONTACT_DATE1.Location = new System.Drawing.Point(10, 76);
            this.lblCONTACT_DATE1.Name = "lblCONTACT_DATE1";
            this.lblCONTACT_DATE1.Size = new System.Drawing.Size(137, 16);
            this.lblCONTACT_DATE1.TabIndex = 357;
            this.lblCONTACT_DATE1.Text = "lblCONTACT_DATE1";
            // 
            // label152
            // 
            this.label152.BackColor = System.Drawing.Color.Yellow;
            this.label152.Location = new System.Drawing.Point(495, 43);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(263, 23);
            this.label152.TabIndex = 350;
            this.label152.Text = "Remarks";
            this.label152.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label153
            // 
            this.label153.BackColor = System.Drawing.Color.Yellow;
            this.label153.Location = new System.Drawing.Point(293, 43);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(198, 23);
            this.label153.TabIndex = 348;
            this.label153.Text = "Contacted By";
            this.label153.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label154
            // 
            this.label154.BackColor = System.Drawing.Color.Yellow;
            this.label154.Location = new System.Drawing.Point(155, 43);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(133, 23);
            this.label154.TabIndex = 346;
            this.label154.Text = "Disposition Code";
            this.label154.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label155
            // 
            this.label155.BackColor = System.Drawing.Color.Yellow;
            this.label155.Location = new System.Drawing.Point(10, 43);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(142, 23);
            this.label155.TabIndex = 344;
            this.label155.Text = "Contact Date";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BackColor = System.Drawing.Color.SandyBrown;
            this.label158.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.Location = new System.Drawing.Point(6, 18);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(92, 18);
            this.label158.TabIndex = 341;
            this.label158.Text = "Last Activity";
            // 
            // label159
            // 
            this.label159.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label159.BackColor = System.Drawing.Color.Yellow;
            this.label159.Location = new System.Drawing.Point(210, 15);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(961, 25);
            this.label159.TabIndex = 340;
            this.label159.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label160
            // 
            this.label160.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label160.BackColor = System.Drawing.Color.SandyBrown;
            this.label160.Location = new System.Drawing.Point(6, 16);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(250, 25);
            this.label160.TabIndex = 342;
            this.label160.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label161
            // 
            this.label161.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label161.BackColor = System.Drawing.Color.Yellow;
            this.label161.Location = new System.Drawing.Point(10, 43);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(1161, 25);
            this.label161.TabIndex = 351;
            this.label161.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblDisp6_Id);
            this.groupBox9.Controls.Add(this.lblDisp5_Id);
            this.groupBox9.Controls.Add(this.lblAgent6_c);
            this.groupBox9.Controls.Add(this.lblAgent5_c);
            this.groupBox9.Controls.Add(this.lblCall6_dt);
            this.groupBox9.Controls.Add(this.lblCall5_dt);
            this.groupBox9.Controls.Add(this.lblCall6_Phone);
            this.groupBox9.Controls.Add(this.lblCall5_Phone);
            this.groupBox9.Controls.Add(this.lblDisp4_Id);
            this.groupBox9.Controls.Add(this.lblDisp3_Id);
            this.groupBox9.Controls.Add(this.lblAgent4_c);
            this.groupBox9.Controls.Add(this.lblAgent3_c);
            this.groupBox9.Controls.Add(this.lblCall4_dt);
            this.groupBox9.Controls.Add(this.lblCall3_dt);
            this.groupBox9.Controls.Add(this.lblCall4_Phone);
            this.groupBox9.Controls.Add(this.lblCall3_Phone);
            this.groupBox9.Controls.Add(this.lblDisp2_Id);
            this.groupBox9.Controls.Add(this.lblDisp1_Id);
            this.groupBox9.Controls.Add(this.lblAgent2_c);
            this.groupBox9.Controls.Add(this.lblAgent1_c);
            this.groupBox9.Controls.Add(this.lblCall2_dt);
            this.groupBox9.Controls.Add(this.lblCall1_dt);
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
            this.groupBox9.Location = new System.Drawing.Point(6, 255);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1190, 225);
            this.groupBox9.TabIndex = 359;
            this.groupBox9.TabStop = false;
            // 
            // lblDisp6_Id
            // 
            this.lblDisp6_Id.AutoSize = true;
            this.lblDisp6_Id.Location = new System.Drawing.Point(481, 196);
            this.lblDisp6_Id.Name = "lblDisp6_Id";
            this.lblDisp6_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp6_Id.TabIndex = 380;
            this.lblDisp6_Id.Text = "lblDisp6_Id";
            // 
            // lblDisp5_Id
            // 
            this.lblDisp5_Id.AutoSize = true;
            this.lblDisp5_Id.Location = new System.Drawing.Point(481, 172);
            this.lblDisp5_Id.Name = "lblDisp5_Id";
            this.lblDisp5_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp5_Id.TabIndex = 379;
            this.lblDisp5_Id.Text = "lblDisp5_Id";
            // 
            // lblAgent6_c
            // 
            this.lblAgent6_c.AutoSize = true;
            this.lblAgent6_c.Location = new System.Drawing.Point(685, 196);
            this.lblAgent6_c.Name = "lblAgent6_c";
            this.lblAgent6_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent6_c.TabIndex = 378;
            this.lblAgent6_c.Text = "Agent6_c";
            // 
            // lblAgent5_c
            // 
            this.lblAgent5_c.AutoSize = true;
            this.lblAgent5_c.Location = new System.Drawing.Point(685, 172);
            this.lblAgent5_c.Name = "lblAgent5_c";
            this.lblAgent5_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent5_c.TabIndex = 377;
            this.lblAgent5_c.Text = "Agent5_c";
            // 
            // lblCall6_dt
            // 
            this.lblCall6_dt.AutoSize = true;
            this.lblCall6_dt.Location = new System.Drawing.Point(217, 196);
            this.lblCall6_dt.Name = "lblCall6_dt";
            this.lblCall6_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall6_dt.TabIndex = 376;
            this.lblCall6_dt.Text = "lblCall6_dt";
            // 
            // lblCall5_dt
            // 
            this.lblCall5_dt.AutoSize = true;
            this.lblCall5_dt.Location = new System.Drawing.Point(217, 172);
            this.lblCall5_dt.Name = "lblCall5_dt";
            this.lblCall5_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall5_dt.TabIndex = 375;
            this.lblCall5_dt.Text = "lblCall5_dt";
            // 
            // lblCall6_Phone
            // 
            this.lblCall6_Phone.AutoSize = true;
            this.lblCall6_Phone.Location = new System.Drawing.Point(10, 196);
            this.lblCall6_Phone.Name = "lblCall6_Phone";
            this.lblCall6_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall6_Phone.TabIndex = 374;
            this.lblCall6_Phone.Text = "lblCall6_Phone";
            // 
            // lblCall5_Phone
            // 
            this.lblCall5_Phone.AutoSize = true;
            this.lblCall5_Phone.Location = new System.Drawing.Point(10, 172);
            this.lblCall5_Phone.Name = "lblCall5_Phone";
            this.lblCall5_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall5_Phone.TabIndex = 373;
            this.lblCall5_Phone.Text = "lblCall5_Phone";
            // 
            // lblDisp4_Id
            // 
            this.lblDisp4_Id.AutoSize = true;
            this.lblDisp4_Id.Location = new System.Drawing.Point(481, 148);
            this.lblDisp4_Id.Name = "lblDisp4_Id";
            this.lblDisp4_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp4_Id.TabIndex = 372;
            this.lblDisp4_Id.Text = "lblDisp4_Id";
            // 
            // lblDisp3_Id
            // 
            this.lblDisp3_Id.AutoSize = true;
            this.lblDisp3_Id.Location = new System.Drawing.Point(481, 124);
            this.lblDisp3_Id.Name = "lblDisp3_Id";
            this.lblDisp3_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp3_Id.TabIndex = 371;
            this.lblDisp3_Id.Text = "lblDisp3_Id";
            // 
            // lblAgent4_c
            // 
            this.lblAgent4_c.AutoSize = true;
            this.lblAgent4_c.Location = new System.Drawing.Point(685, 148);
            this.lblAgent4_c.Name = "lblAgent4_c";
            this.lblAgent4_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent4_c.TabIndex = 370;
            this.lblAgent4_c.Text = "Agent4_c";
            // 
            // lblAgent3_c
            // 
            this.lblAgent3_c.AutoSize = true;
            this.lblAgent3_c.Location = new System.Drawing.Point(685, 124);
            this.lblAgent3_c.Name = "lblAgent3_c";
            this.lblAgent3_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent3_c.TabIndex = 369;
            this.lblAgent3_c.Text = "Agent3_c";
            // 
            // lblCall4_dt
            // 
            this.lblCall4_dt.AutoSize = true;
            this.lblCall4_dt.Location = new System.Drawing.Point(217, 148);
            this.lblCall4_dt.Name = "lblCall4_dt";
            this.lblCall4_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall4_dt.TabIndex = 368;
            this.lblCall4_dt.Text = "lblCall4_dt";
            // 
            // lblCall3_dt
            // 
            this.lblCall3_dt.AutoSize = true;
            this.lblCall3_dt.Location = new System.Drawing.Point(217, 124);
            this.lblCall3_dt.Name = "lblCall3_dt";
            this.lblCall3_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall3_dt.TabIndex = 367;
            this.lblCall3_dt.Text = "lblCall3_dt";
            // 
            // lblCall4_Phone
            // 
            this.lblCall4_Phone.AutoSize = true;
            this.lblCall4_Phone.Location = new System.Drawing.Point(10, 148);
            this.lblCall4_Phone.Name = "lblCall4_Phone";
            this.lblCall4_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall4_Phone.TabIndex = 366;
            this.lblCall4_Phone.Text = "lblCall4_Phone";
            // 
            // lblCall3_Phone
            // 
            this.lblCall3_Phone.AutoSize = true;
            this.lblCall3_Phone.Location = new System.Drawing.Point(10, 124);
            this.lblCall3_Phone.Name = "lblCall3_Phone";
            this.lblCall3_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall3_Phone.TabIndex = 365;
            this.lblCall3_Phone.Text = "lblCall3_Phone";
            // 
            // lblDisp2_Id
            // 
            this.lblDisp2_Id.AutoSize = true;
            this.lblDisp2_Id.Location = new System.Drawing.Point(481, 100);
            this.lblDisp2_Id.Name = "lblDisp2_Id";
            this.lblDisp2_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp2_Id.TabIndex = 364;
            this.lblDisp2_Id.Text = "lblDisp2_Id";
            // 
            // lblDisp1_Id
            // 
            this.lblDisp1_Id.AutoSize = true;
            this.lblDisp1_Id.Location = new System.Drawing.Point(481, 76);
            this.lblDisp1_Id.Name = "lblDisp1_Id";
            this.lblDisp1_Id.Size = new System.Drawing.Size(74, 16);
            this.lblDisp1_Id.TabIndex = 363;
            this.lblDisp1_Id.Text = "lblDisp1_Id";
            // 
            // lblAgent2_c
            // 
            this.lblAgent2_c.AutoSize = true;
            this.lblAgent2_c.Location = new System.Drawing.Point(685, 100);
            this.lblAgent2_c.Name = "lblAgent2_c";
            this.lblAgent2_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent2_c.TabIndex = 362;
            this.lblAgent2_c.Text = "Agent2_c";
            // 
            // lblAgent1_c
            // 
            this.lblAgent1_c.AutoSize = true;
            this.lblAgent1_c.Location = new System.Drawing.Point(685, 76);
            this.lblAgent1_c.Name = "lblAgent1_c";
            this.lblAgent1_c.Size = new System.Drawing.Size(63, 16);
            this.lblAgent1_c.TabIndex = 361;
            this.lblAgent1_c.Text = "Agent1_c";
            // 
            // lblCall2_dt
            // 
            this.lblCall2_dt.AutoSize = true;
            this.lblCall2_dt.Location = new System.Drawing.Point(217, 100);
            this.lblCall2_dt.Name = "lblCall2_dt";
            this.lblCall2_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall2_dt.TabIndex = 360;
            this.lblCall2_dt.Text = "lblCall2_dt";
            // 
            // lblCall1_dt
            // 
            this.lblCall1_dt.AutoSize = true;
            this.lblCall1_dt.Location = new System.Drawing.Point(217, 76);
            this.lblCall1_dt.Name = "lblCall1_dt";
            this.lblCall1_dt.Size = new System.Drawing.Size(69, 16);
            this.lblCall1_dt.TabIndex = 359;
            this.lblCall1_dt.Text = "lblCall1_dt";
            // 
            // lblCall2_Phone
            // 
            this.lblCall2_Phone.AutoSize = true;
            this.lblCall2_Phone.Location = new System.Drawing.Point(10, 100);
            this.lblCall2_Phone.Name = "lblCall2_Phone";
            this.lblCall2_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall2_Phone.TabIndex = 358;
            this.lblCall2_Phone.Text = "lblCall2_Phone";
            // 
            // lblCall1_Phone
            // 
            this.lblCall1_Phone.AutoSize = true;
            this.lblCall1_Phone.Location = new System.Drawing.Point(10, 76);
            this.lblCall1_Phone.Name = "lblCall1_Phone";
            this.lblCall1_Phone.Size = new System.Drawing.Size(97, 16);
            this.lblCall1_Phone.TabIndex = 357;
            this.lblCall1_Phone.Text = "lblCall1_Phone";
            // 
            // label103
            // 
            this.label103.BackColor = System.Drawing.Color.Yellow;
            this.label103.Location = new System.Drawing.Point(685, 42);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(288, 23);
            this.label103.TabIndex = 350;
            this.label103.Text = "Agent";
            this.label103.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label108
            // 
            this.label108.BackColor = System.Drawing.Color.Yellow;
            this.label108.Location = new System.Drawing.Point(481, 42);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(198, 23);
            this.label108.TabIndex = 348;
            this.label108.Text = "Display";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label99
            // 
            this.label99.BackColor = System.Drawing.Color.Yellow;
            this.label99.Location = new System.Drawing.Point(212, 42);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(268, 23);
            this.label99.TabIndex = 346;
            this.label99.Text = "Date";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.Yellow;
            this.label102.Location = new System.Drawing.Point(10, 42);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(198, 23);
            this.label102.TabIndex = 344;
            this.label102.Text = "Phone";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.SandyBrown;
            this.label68.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(6, 16);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(104, 18);
            this.label68.TabIndex = 341;
            this.label68.Text = "Today Activity";
            // 
            // label69
            // 
            this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label69.BackColor = System.Drawing.Color.Yellow;
            this.label69.Location = new System.Drawing.Point(210, 15);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(961, 25);
            this.label69.TabIndex = 340;
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label70
            // 
            this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label70.BackColor = System.Drawing.Color.SandyBrown;
            this.label70.Location = new System.Drawing.Point(6, 15);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(250, 25);
            this.label70.TabIndex = 342;
            this.label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label38.BackColor = System.Drawing.Color.Yellow;
            this.label38.Location = new System.Drawing.Point(10, 43);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(1161, 25);
            this.label38.TabIndex = 351;
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label32);
            this.groupBox8.Controls.Add(this.lblAO_additional2);
            this.groupBox8.Controls.Add(this.lblAO_additional1);
            this.groupBox8.Controls.Add(this.lblPrincipal_additional2);
            this.groupBox8.Controls.Add(this.lblPrincipal_additional1);
            this.groupBox8.Controls.Add(this.lblDPD_additional2);
            this.groupBox8.Controls.Add(this.lblDPD_additional1);
            this.groupBox8.Controls.Add(this.lblLoad_additional2);
            this.groupBox8.Controls.Add(this.lblLoad_additional1);
            this.groupBox8.Controls.Add(this.label98);
            this.groupBox8.Controls.Add(this.label97);
            this.groupBox8.Controls.Add(this.label96);
            this.groupBox8.Controls.Add(this.label95);
            this.groupBox8.Controls.Add(this.label65);
            this.groupBox8.Controls.Add(this.label66);
            this.groupBox8.Controls.Add(this.label67);
            this.groupBox8.Location = new System.Drawing.Point(6, 149);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1190, 104);
            this.groupBox8.TabIndex = 358;
            this.groupBox8.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 358;
            this.label2.Text = "#2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(176, 51);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(21, 16);
            this.label32.TabIndex = 357;
            this.label32.Text = "#1";
            // 
            // lblAO_additional2
            // 
            this.lblAO_additional2.AutoSize = true;
            this.lblAO_additional2.Location = new System.Drawing.Point(564, 75);
            this.lblAO_additional2.Name = "lblAO_additional2";
            this.lblAO_additional2.Size = new System.Drawing.Size(113, 16);
            this.lblAO_additional2.TabIndex = 356;
            this.lblAO_additional2.Text = "lblAO_additional2";
            // 
            // lblAO_additional1
            // 
            this.lblAO_additional1.AutoSize = true;
            this.lblAO_additional1.Location = new System.Drawing.Point(564, 51);
            this.lblAO_additional1.Name = "lblAO_additional1";
            this.lblAO_additional1.Size = new System.Drawing.Size(113, 16);
            this.lblAO_additional1.TabIndex = 355;
            this.lblAO_additional1.Text = "lblAO_additional1";
            // 
            // lblPrincipal_additional2
            // 
            this.lblPrincipal_additional2.AutoSize = true;
            this.lblPrincipal_additional2.Location = new System.Drawing.Point(788, 75);
            this.lblPrincipal_additional2.Name = "lblPrincipal_additional2";
            this.lblPrincipal_additional2.Size = new System.Drawing.Size(146, 16);
            this.lblPrincipal_additional2.TabIndex = 352;
            this.lblPrincipal_additional2.Text = "lblPrincipal_additional2";
            // 
            // lblPrincipal_additional1
            // 
            this.lblPrincipal_additional1.AutoSize = true;
            this.lblPrincipal_additional1.Location = new System.Drawing.Point(788, 51);
            this.lblPrincipal_additional1.Name = "lblPrincipal_additional1";
            this.lblPrincipal_additional1.Size = new System.Drawing.Size(146, 16);
            this.lblPrincipal_additional1.TabIndex = 351;
            this.lblPrincipal_additional1.Text = "lblPrincipal_additional1";
            // 
            // lblDPD_additional2
            // 
            this.lblDPD_additional2.AutoSize = true;
            this.lblDPD_additional2.Location = new System.Drawing.Point(412, 75);
            this.lblDPD_additional2.Name = "lblDPD_additional2";
            this.lblDPD_additional2.Size = new System.Drawing.Size(123, 16);
            this.lblDPD_additional2.TabIndex = 350;
            this.lblDPD_additional2.Text = "lblDPD_additional2";
            // 
            // lblDPD_additional1
            // 
            this.lblDPD_additional1.AutoSize = true;
            this.lblDPD_additional1.Location = new System.Drawing.Point(412, 51);
            this.lblDPD_additional1.Name = "lblDPD_additional1";
            this.lblDPD_additional1.Size = new System.Drawing.Size(123, 16);
            this.lblDPD_additional1.TabIndex = 349;
            this.lblDPD_additional1.Text = "lblDPD_additional1";
            // 
            // lblLoad_additional2
            // 
            this.lblLoad_additional2.AutoSize = true;
            this.lblLoad_additional2.Location = new System.Drawing.Point(210, 75);
            this.lblLoad_additional2.Name = "lblLoad_additional2";
            this.lblLoad_additional2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoad_additional2.Size = new System.Drawing.Size(125, 16);
            this.lblLoad_additional2.TabIndex = 348;
            this.lblLoad_additional2.Text = "lblLoad_additional2";
            // 
            // lblLoad_additional1
            // 
            this.lblLoad_additional1.AutoSize = true;
            this.lblLoad_additional1.Location = new System.Drawing.Point(210, 51);
            this.lblLoad_additional1.Name = "lblLoad_additional1";
            this.lblLoad_additional1.Size = new System.Drawing.Size(125, 16);
            this.lblLoad_additional1.TabIndex = 347;
            this.lblLoad_additional1.Text = "lblLoad_additional1";
            // 
            // label98
            // 
            this.label98.BackColor = System.Drawing.Color.Yellow;
            this.label98.Location = new System.Drawing.Point(788, 12);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(178, 23);
            this.label98.TabIndex = 346;
            this.label98.Text = "Principle Overdue";
            this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label97
            // 
            this.label97.BackColor = System.Drawing.Color.Yellow;
            this.label97.Location = new System.Drawing.Point(564, 12);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(224, 23);
            this.label97.TabIndex = 345;
            this.label97.Text = "Amount Overdue";
            this.label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label96
            // 
            this.label96.BackColor = System.Drawing.Color.Yellow;
            this.label96.Location = new System.Drawing.Point(412, 12);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(153, 23);
            this.label96.TabIndex = 344;
            this.label96.Text = "DPD";
            this.label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label95
            // 
            this.label95.BackColor = System.Drawing.Color.Yellow;
            this.label95.Location = new System.Drawing.Point(213, 12);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(199, 23);
            this.label95.TabIndex = 343;
            this.label95.Text = "Loan Number";
            this.label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.SandyBrown;
            this.label65.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(6, 16);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(88, 18);
            this.label65.TabIndex = 341;
            this.label65.Text = "Other Loan";
            // 
            // label66
            // 
            this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label66.BackColor = System.Drawing.Color.Yellow;
            this.label66.Location = new System.Drawing.Point(210, 15);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(961, 25);
            this.label66.TabIndex = 340;
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label67
            // 
            this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label67.BackColor = System.Drawing.Color.SandyBrown;
            this.label67.Location = new System.Drawing.Point(6, 15);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(202, 25);
            this.label67.TabIndex = 342;
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblaccno);
            this.groupBox6.Controls.Add(this.lblPother2);
            this.groupBox6.Controls.Add(this.lblPoffice2);
            this.groupBox6.Controls.Add(this.lblPhome2);
            this.groupBox6.Controls.Add(this.lblRegion2);
            this.groupBox6.Controls.Add(this.lblGender2);
            this.groupBox6.Controls.Add(this.lblProduct2);
            this.groupBox6.Controls.Add(this.lblDOB2);
            this.groupBox6.Controls.Add(this.lblCustomerName3);
            this.groupBox6.Controls.Add(this.lblLoan6);
            this.groupBox6.Controls.Add(this.label71);
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
            this.groupBox6.Location = new System.Drawing.Point(6, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1190, 146);
            this.groupBox6.TabIndex = 192;
            this.groupBox6.TabStop = false;
            // 
            // lblaccno
            // 
            this.lblaccno.AutoSize = true;
            this.lblaccno.Location = new System.Drawing.Point(120, 48);
            this.lblaccno.Name = "lblaccno";
            this.lblaccno.Size = new System.Drawing.Size(88, 16);
            this.lblaccno.TabIndex = 301;
            this.lblaccno.Text = "Loan Number";
            // 
            // lblPother2
            // 
            this.lblPother2.AutoSize = true;
            this.lblPother2.Location = new System.Drawing.Point(917, 123);
            this.lblPother2.Name = "lblPother2";
            this.lblPother2.Size = new System.Drawing.Size(39, 16);
            this.lblPother2.TabIndex = 300;
            this.lblPother2.Text = "Other";
            // 
            // lblPoffice2
            // 
            this.lblPoffice2.AutoSize = true;
            this.lblPoffice2.Location = new System.Drawing.Point(917, 100);
            this.lblPoffice2.Name = "lblPoffice2";
            this.lblPoffice2.Size = new System.Drawing.Size(41, 16);
            this.lblPoffice2.TabIndex = 299;
            this.lblPoffice2.Text = "Office";
            // 
            // lblPhome2
            // 
            this.lblPhome2.AutoSize = true;
            this.lblPhome2.Location = new System.Drawing.Point(917, 77);
            this.lblPhome2.Name = "lblPhome2";
            this.lblPhome2.Size = new System.Drawing.Size(44, 16);
            this.lblPhome2.TabIndex = 298;
            this.lblPhome2.Text = "Home";
            // 
            // lblRegion2
            // 
            this.lblRegion2.AutoSize = true;
            this.lblRegion2.Location = new System.Drawing.Point(593, 118);
            this.lblRegion2.Name = "lblRegion2";
            this.lblRegion2.Size = new System.Drawing.Size(51, 16);
            this.lblRegion2.TabIndex = 297;
            this.lblRegion2.Text = "Region";
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Location = new System.Drawing.Point(593, 95);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(52, 16);
            this.lblGender2.TabIndex = 296;
            this.lblGender2.Text = "Gender";
            // 
            // lblProduct2
            // 
            this.lblProduct2.AutoSize = true;
            this.lblProduct2.Location = new System.Drawing.Point(593, 72);
            this.lblProduct2.Name = "lblProduct2";
            this.lblProduct2.Size = new System.Drawing.Size(116, 16);
            this.lblProduct2.TabIndex = 295;
            this.lblProduct2.Text = "Sub Product Code";
            // 
            // lblDOB2
            // 
            this.lblDOB2.AutoSize = true;
            this.lblDOB2.Location = new System.Drawing.Point(120, 118);
            this.lblDOB2.Name = "lblDOB2";
            this.lblDOB2.Size = new System.Drawing.Size(36, 16);
            this.lblDOB2.TabIndex = 294;
            this.lblDOB2.Text = "DOB";
            // 
            // lblCustomerName3
            // 
            this.lblCustomerName3.Location = new System.Drawing.Point(120, 95);
            this.lblCustomerName3.Name = "lblCustomerName3";
            this.lblCustomerName3.Size = new System.Drawing.Size(350, 16);
            this.lblCustomerName3.TabIndex = 293;
            this.lblCustomerName3.Text = "Customer Name";
            // 
            // lblLoan6
            // 
            this.lblLoan6.AutoSize = true;
            this.lblLoan6.Location = new System.Drawing.Point(120, 72);
            this.lblLoan6.Name = "lblLoan6";
            this.lblLoan6.Size = new System.Drawing.Size(88, 16);
            this.lblLoan6.TabIndex = 292;
            this.lblLoan6.Text = "Loan Number";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Yellow;
            this.label71.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label71.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(225, 14);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(51, 18);
            this.label71.TabIndex = 290;
            this.label71.Text = "Loan1";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.SandyBrown;
            this.label72.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(4, 14);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(107, 18);
            this.label72.TabIndex = 289;
            this.label72.Text = "Service Name";
            // 
            // label73
            // 
            this.label73.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label73.BackColor = System.Drawing.Color.Yellow;
            this.label73.Location = new System.Drawing.Point(208, 13);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(976, 25);
            this.label73.TabIndex = 288;
            this.label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label74
            // 
            this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label74.BackColor = System.Drawing.Color.SandyBrown;
            this.label74.Location = new System.Drawing.Point(4, 13);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(250, 25);
            this.label74.TabIndex = 291;
            this.label74.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(837, 121);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(39, 16);
            this.label128.TabIndex = 283;
            this.label128.Text = "Other";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(837, 98);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(41, 16);
            this.label129.TabIndex = 282;
            this.label129.Text = "Office";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(837, 75);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(44, 16);
            this.label130.TabIndex = 281;
            this.label130.Text = "Home";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(473, 116);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(51, 16);
            this.label131.TabIndex = 280;
            this.label131.Text = "Region";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(473, 93);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(52, 16);
            this.label132.TabIndex = 279;
            this.label132.Text = "Gender";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(473, 70);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(116, 16);
            this.label133.TabIndex = 278;
            this.label133.Text = "Sub Product Code";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(10, 116);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(36, 16);
            this.label134.TabIndex = 277;
            this.label134.Text = "DOB";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(10, 93);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(104, 16);
            this.label135.TabIndex = 276;
            this.label135.Text = "Customer Name";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(10, 70);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(88, 16);
            this.label136.TabIndex = 275;
            this.label136.Text = "Loan Number";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(10, 46);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(73, 16);
            this.label137.TabIndex = 274;
            this.label137.Text = "Contact No";
            // 
            // customerTabPage
            // 
            this.customerTabPage.BackColor = System.Drawing.Color.White;
            this.customerTabPage.Controls.Add(this.panel3);
            this.customerTabPage.Location = new System.Drawing.Point(4, 39);
            this.customerTabPage.Name = "customerTabPage";
            this.customerTabPage.Size = new System.Drawing.Size(1226, 518);
            this.customerTabPage.TabIndex = 3;
            this.customerTabPage.Text = "Customer Address";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.groupBox12);
            this.panel3.Controls.Add(this.groupBox11);
            this.panel3.Controls.Add(this.groupBox10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1226, 518);
            this.panel3.TabIndex = 2;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.textBox7);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Controls.Add(this.textBox6);
            this.groupBox12.Controls.Add(this.label42);
            this.groupBox12.Controls.Add(this.label146);
            this.groupBox12.Controls.Add(this.textBox1);
            this.groupBox12.Controls.Add(this.textBox2);
            this.groupBox12.Controls.Add(this.textBox3);
            this.groupBox12.Controls.Add(this.textBox4);
            this.groupBox12.Controls.Add(this.textBox5);
            this.groupBox12.Controls.Add(this.button23);
            this.groupBox12.Controls.Add(this.label46);
            this.groupBox12.Controls.Add(this.label47);
            this.groupBox12.Controls.Add(this.label78);
            this.groupBox12.Controls.Add(this.label144);
            this.groupBox12.Controls.Add(this.label151);
            this.groupBox12.Controls.Add(this.label162);
            this.groupBox12.Controls.Add(this.label163);
            this.groupBox12.Location = new System.Drawing.Point(3, 373);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1190, 300);
            this.groupBox12.TabIndex = 362;
            this.groupBox12.TabStop = false;
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Location = new System.Drawing.Point(224, 236);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(600, 22);
            this.textBox7.TabIndex = 406;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(25, 236);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(48, 16);
            this.label41.TabIndex = 405;
            this.label41.Text = "Mobile";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Location = new System.Drawing.Point(224, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(600, 22);
            this.textBox6.TabIndex = 404;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(25, 210);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(83, 16);
            this.label42.TabIndex = 403;
            this.label42.Text = "Contact No 2";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(25, 50);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(93, 16);
            this.label146.TabIndex = 402;
            this.label146.Text = "Address Type";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(224, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 22);
            this.textBox1.TabIndex = 401;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(224, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 22);
            this.textBox2.TabIndex = 400;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(224, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(600, 22);
            this.textBox3.TabIndex = 399;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(224, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(600, 22);
            this.textBox4.TabIndex = 398;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(224, 75);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(600, 22);
            this.textBox5.TabIndex = 397;
            // 
            // button23
            // 
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(224, 263);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 23);
            this.button23.TabIndex = 396;
            this.button23.Text = "Update";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(25, 183);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(83, 16);
            this.label46.TabIndex = 393;
            this.label46.Text = "Contact No 1";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(25, 155);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(29, 16);
            this.label47.TabIndex = 392;
            this.label47.Text = "City";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(25, 75);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(82, 16);
            this.label78.TabIndex = 391;
            this.label78.Text = "Full Address";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(225, 50);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(39, 16);
            this.label144.TabIndex = 360;
            this.label144.Text = "Other";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.BackColor = System.Drawing.Color.SandyBrown;
            this.label151.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.Location = new System.Drawing.Point(6, 20);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(131, 18);
            this.label151.TabIndex = 341;
            this.label151.Text = "Add New Address";
            // 
            // label162
            // 
            this.label162.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label162.BackColor = System.Drawing.Color.Yellow;
            this.label162.Location = new System.Drawing.Point(210, 15);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(961, 25);
            this.label162.TabIndex = 340;
            this.label162.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label163
            // 
            this.label163.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label163.BackColor = System.Drawing.Color.SandyBrown;
            this.label163.Location = new System.Drawing.Point(6, 15);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(250, 25);
            this.label163.TabIndex = 342;
            this.label163.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label48);
            this.groupBox11.Controls.Add(this.label49);
            this.groupBox11.Controls.Add(this.label83);
            this.groupBox11.Controls.Add(this.label114);
            this.groupBox11.Controls.Add(this.label138);
            this.groupBox11.Controls.Add(this.lblMOBILE_O);
            this.groupBox11.Controls.Add(this.lblMOBILE_E);
            this.groupBox11.Controls.Add(this.lblMOBILE_P);
            this.groupBox11.Controls.Add(this.lblCONTACT2_O);
            this.groupBox11.Controls.Add(this.lblCONTACT1_O);
            this.groupBox11.Controls.Add(this.lblCONTACT2_E);
            this.groupBox11.Controls.Add(this.lblCONTACT1_E);
            this.groupBox11.Controls.Add(this.lblCONTACT2_P);
            this.groupBox11.Controls.Add(this.lblCONTACT1_P);
            this.groupBox11.Controls.Add(this.lblCITY_O);
            this.groupBox11.Controls.Add(this.lblALAMAT_O);
            this.groupBox11.Controls.Add(this.lblCITY_E);
            this.groupBox11.Controls.Add(this.lblALAMAT_E);
            this.groupBox11.Controls.Add(this.lblCITY_P);
            this.groupBox11.Controls.Add(this.lblALAMAT_P);
            this.groupBox11.Controls.Add(this.label171);
            this.groupBox11.Controls.Add(this.label172);
            this.groupBox11.Controls.Add(this.label173);
            this.groupBox11.Controls.Add(this.label174);
            this.groupBox11.Controls.Add(this.label176);
            this.groupBox11.Controls.Add(this.label177);
            this.groupBox11.Controls.Add(this.label178);
            this.groupBox11.Location = new System.Drawing.Point(3, 145);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1190, 225);
            this.groupBox11.TabIndex = 361;
            this.groupBox11.TabStop = false;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(25, 202);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(48, 16);
            this.label48.TabIndex = 395;
            this.label48.Text = "Mobile";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(25, 178);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(83, 16);
            this.label49.TabIndex = 394;
            this.label49.Text = "Contact No 2";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(25, 154);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(83, 16);
            this.label83.TabIndex = 393;
            this.label83.Text = "Contact No 1";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(25, 130);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(29, 16);
            this.label114.TabIndex = 392;
            this.label114.Text = "City";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(25, 75);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(82, 16);
            this.label138.TabIndex = 391;
            this.label138.Text = "Full Address";
            // 
            // lblMOBILE_O
            // 
            this.lblMOBILE_O.AutoSize = true;
            this.lblMOBILE_O.Location = new System.Drawing.Point(842, 202);
            this.lblMOBILE_O.Name = "lblMOBILE_O";
            this.lblMOBILE_O.Size = new System.Drawing.Size(87, 16);
            this.lblMOBILE_O.TabIndex = 379;
            this.lblMOBILE_O.Text = "lblMOBILE_O";
            // 
            // lblMOBILE_E
            // 
            this.lblMOBILE_E.AutoSize = true;
            this.lblMOBILE_E.Location = new System.Drawing.Point(490, 202);
            this.lblMOBILE_E.Name = "lblMOBILE_E";
            this.lblMOBILE_E.Size = new System.Drawing.Size(86, 16);
            this.lblMOBILE_E.TabIndex = 375;
            this.lblMOBILE_E.Text = "lblMOBILE_E";
            // 
            // lblMOBILE_P
            // 
            this.lblMOBILE_P.AutoSize = true;
            this.lblMOBILE_P.Location = new System.Drawing.Point(134, 202);
            this.lblMOBILE_P.Name = "lblMOBILE_P";
            this.lblMOBILE_P.Size = new System.Drawing.Size(86, 16);
            this.lblMOBILE_P.TabIndex = 373;
            this.lblMOBILE_P.Text = "lblMOBILE_P";
            // 
            // lblCONTACT2_O
            // 
            this.lblCONTACT2_O.AutoSize = true;
            this.lblCONTACT2_O.Location = new System.Drawing.Point(842, 178);
            this.lblCONTACT2_O.Name = "lblCONTACT2_O";
            this.lblCONTACT2_O.Size = new System.Drawing.Size(110, 16);
            this.lblCONTACT2_O.TabIndex = 372;
            this.lblCONTACT2_O.Text = "lblCONTACT2_O";
            // 
            // lblCONTACT1_O
            // 
            this.lblCONTACT1_O.AutoSize = true;
            this.lblCONTACT1_O.Location = new System.Drawing.Point(842, 154);
            this.lblCONTACT1_O.Name = "lblCONTACT1_O";
            this.lblCONTACT1_O.Size = new System.Drawing.Size(110, 16);
            this.lblCONTACT1_O.TabIndex = 371;
            this.lblCONTACT1_O.Text = "lblCONTACT1_O";
            // 
            // lblCONTACT2_E
            // 
            this.lblCONTACT2_E.AutoSize = true;
            this.lblCONTACT2_E.Location = new System.Drawing.Point(490, 178);
            this.lblCONTACT2_E.Name = "lblCONTACT2_E";
            this.lblCONTACT2_E.Size = new System.Drawing.Size(109, 16);
            this.lblCONTACT2_E.TabIndex = 368;
            this.lblCONTACT2_E.Text = "lblCONTACT2_E";
            // 
            // lblCONTACT1_E
            // 
            this.lblCONTACT1_E.AutoSize = true;
            this.lblCONTACT1_E.Location = new System.Drawing.Point(490, 154);
            this.lblCONTACT1_E.Name = "lblCONTACT1_E";
            this.lblCONTACT1_E.Size = new System.Drawing.Size(109, 16);
            this.lblCONTACT1_E.TabIndex = 367;
            this.lblCONTACT1_E.Text = "lblCONTACT1_E";
            // 
            // lblCONTACT2_P
            // 
            this.lblCONTACT2_P.AutoSize = true;
            this.lblCONTACT2_P.Location = new System.Drawing.Point(134, 178);
            this.lblCONTACT2_P.Name = "lblCONTACT2_P";
            this.lblCONTACT2_P.Size = new System.Drawing.Size(109, 16);
            this.lblCONTACT2_P.TabIndex = 366;
            this.lblCONTACT2_P.Text = "lblCONTACT2_P";
            // 
            // lblCONTACT1_P
            // 
            this.lblCONTACT1_P.AutoSize = true;
            this.lblCONTACT1_P.Location = new System.Drawing.Point(134, 154);
            this.lblCONTACT1_P.Name = "lblCONTACT1_P";
            this.lblCONTACT1_P.Size = new System.Drawing.Size(109, 16);
            this.lblCONTACT1_P.TabIndex = 365;
            this.lblCONTACT1_P.Text = "lblCONTACT1_P";
            // 
            // lblCITY_O
            // 
            this.lblCITY_O.AutoSize = true;
            this.lblCITY_O.Location = new System.Drawing.Point(842, 130);
            this.lblCITY_O.Name = "lblCITY_O";
            this.lblCITY_O.Size = new System.Drawing.Size(68, 16);
            this.lblCITY_O.TabIndex = 364;
            this.lblCITY_O.Text = "lblCITY_O";
            // 
            // lblALAMAT_O
            // 
            this.lblALAMAT_O.Location = new System.Drawing.Point(842, 75);
            this.lblALAMAT_O.Name = "lblALAMAT_O";
            this.lblALAMAT_O.Size = new System.Drawing.Size(330, 55);
            this.lblALAMAT_O.TabIndex = 363;
            this.lblALAMAT_O.Text = "lblALAMAT_O";
            // 
            // lblCITY_E
            // 
            this.lblCITY_E.AutoSize = true;
            this.lblCITY_E.Location = new System.Drawing.Point(490, 130);
            this.lblCITY_E.Name = "lblCITY_E";
            this.lblCITY_E.Size = new System.Drawing.Size(67, 16);
            this.lblCITY_E.TabIndex = 360;
            this.lblCITY_E.Text = "lblCITY_E";
            // 
            // lblALAMAT_E
            // 
            this.lblALAMAT_E.Location = new System.Drawing.Point(489, 75);
            this.lblALAMAT_E.Name = "lblALAMAT_E";
            this.lblALAMAT_E.Size = new System.Drawing.Size(340, 55);
            this.lblALAMAT_E.TabIndex = 359;
            this.lblALAMAT_E.Text = "lblALAMAT_E";
            // 
            // lblCITY_P
            // 
            this.lblCITY_P.AutoSize = true;
            this.lblCITY_P.Location = new System.Drawing.Point(134, 130);
            this.lblCITY_P.Name = "lblCITY_P";
            this.lblCITY_P.Size = new System.Drawing.Size(67, 16);
            this.lblCITY_P.TabIndex = 358;
            this.lblCITY_P.Text = "lblCITY_P";
            // 
            // lblALAMAT_P
            // 
            this.lblALAMAT_P.Location = new System.Drawing.Point(134, 75);
            this.lblALAMAT_P.Name = "lblALAMAT_P";
            this.lblALAMAT_P.Size = new System.Drawing.Size(340, 55);
            this.lblALAMAT_P.TabIndex = 357;
            this.lblALAMAT_P.Text = "lblALAMAT_P";
            // 
            // label171
            // 
            this.label171.BackColor = System.Drawing.Color.Yellow;
            this.label171.Location = new System.Drawing.Point(842, 43);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(330, 23);
            this.label171.TabIndex = 348;
            this.label171.Text = "Other";
            this.label171.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label172
            // 
            this.label172.BackColor = System.Drawing.Color.Yellow;
            this.label172.Location = new System.Drawing.Point(485, 43);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(350, 23);
            this.label172.TabIndex = 346;
            this.label172.Text = "Office";
            this.label172.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label173
            // 
            this.label173.BackColor = System.Drawing.Color.Yellow;
            this.label173.Location = new System.Drawing.Point(128, 43);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(350, 23);
            this.label173.TabIndex = 344;
            this.label173.Text = "Home";
            this.label173.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.BackColor = System.Drawing.Color.SandyBrown;
            this.label174.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label174.Location = new System.Drawing.Point(6, 20);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(138, 18);
            this.label174.TabIndex = 341;
            this.label174.Text = "Customer Address";
            // 
            // label176
            // 
            this.label176.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label176.BackColor = System.Drawing.Color.Yellow;
            this.label176.Location = new System.Drawing.Point(210, 15);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(961, 25);
            this.label176.TabIndex = 340;
            this.label176.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label177
            // 
            this.label177.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label177.BackColor = System.Drawing.Color.SandyBrown;
            this.label177.Location = new System.Drawing.Point(6, 15);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(250, 25);
            this.label177.TabIndex = 342;
            this.label177.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label178
            // 
            this.label178.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label178.BackColor = System.Drawing.Color.Yellow;
            this.label178.Location = new System.Drawing.Point(10, 43);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(1161, 25);
            this.label178.TabIndex = 351;
            this.label178.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Controls.Add(this.lblPother3);
            this.groupBox10.Controls.Add(this.lblPoffice3);
            this.groupBox10.Controls.Add(this.lblPhome3);
            this.groupBox10.Controls.Add(this.lblRegion3);
            this.groupBox10.Controls.Add(this.lblGender3);
            this.groupBox10.Controls.Add(this.lblProduct3);
            this.groupBox10.Controls.Add(this.lblDOB3);
            this.groupBox10.Controls.Add(this.lblCustomerName4);
            this.groupBox10.Controls.Add(this.lblLoan7);
            this.groupBox10.Controls.Add(this.label84);
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
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1190, 146);
            this.groupBox10.TabIndex = 193;
            this.groupBox10.TabStop = false;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(117, 46);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(88, 16);
            this.label43.TabIndex = 301;
            this.label43.Text = "Loan Number";
            // 
            // lblPother3
            // 
            this.lblPother3.AutoSize = true;
            this.lblPother3.Location = new System.Drawing.Point(917, 123);
            this.lblPother3.Name = "lblPother3";
            this.lblPother3.Size = new System.Drawing.Size(39, 16);
            this.lblPother3.TabIndex = 300;
            this.lblPother3.Text = "Other";
            // 
            // lblPoffice3
            // 
            this.lblPoffice3.AutoSize = true;
            this.lblPoffice3.Location = new System.Drawing.Point(917, 100);
            this.lblPoffice3.Name = "lblPoffice3";
            this.lblPoffice3.Size = new System.Drawing.Size(41, 16);
            this.lblPoffice3.TabIndex = 299;
            this.lblPoffice3.Text = "Office";
            // 
            // lblPhome3
            // 
            this.lblPhome3.AutoSize = true;
            this.lblPhome3.Location = new System.Drawing.Point(917, 77);
            this.lblPhome3.Name = "lblPhome3";
            this.lblPhome3.Size = new System.Drawing.Size(44, 16);
            this.lblPhome3.TabIndex = 298;
            this.lblPhome3.Text = "Home";
            // 
            // lblRegion3
            // 
            this.lblRegion3.AutoSize = true;
            this.lblRegion3.Location = new System.Drawing.Point(591, 118);
            this.lblRegion3.Name = "lblRegion3";
            this.lblRegion3.Size = new System.Drawing.Size(51, 16);
            this.lblRegion3.TabIndex = 297;
            this.lblRegion3.Text = "Region";
            // 
            // lblGender3
            // 
            this.lblGender3.AutoSize = true;
            this.lblGender3.Location = new System.Drawing.Point(591, 95);
            this.lblGender3.Name = "lblGender3";
            this.lblGender3.Size = new System.Drawing.Size(52, 16);
            this.lblGender3.TabIndex = 296;
            this.lblGender3.Text = "Gender";
            // 
            // lblProduct3
            // 
            this.lblProduct3.AutoSize = true;
            this.lblProduct3.Location = new System.Drawing.Point(591, 72);
            this.lblProduct3.Name = "lblProduct3";
            this.lblProduct3.Size = new System.Drawing.Size(74, 16);
            this.lblProduct3.TabIndex = 295;
            this.lblProduct3.Text = "lblProduct3";
            // 
            // lblDOB3
            // 
            this.lblDOB3.AutoSize = true;
            this.lblDOB3.Location = new System.Drawing.Point(117, 118);
            this.lblDOB3.Name = "lblDOB3";
            this.lblDOB3.Size = new System.Drawing.Size(36, 16);
            this.lblDOB3.TabIndex = 294;
            this.lblDOB3.Text = "DOB";
            // 
            // lblCustomerName4
            // 
            this.lblCustomerName4.Location = new System.Drawing.Point(117, 95);
            this.lblCustomerName4.Name = "lblCustomerName4";
            this.lblCustomerName4.Size = new System.Drawing.Size(350, 16);
            this.lblCustomerName4.TabIndex = 293;
            this.lblCustomerName4.Text = "Customer Name";
            // 
            // lblLoan7
            // 
            this.lblLoan7.AutoSize = true;
            this.lblLoan7.Location = new System.Drawing.Point(117, 72);
            this.lblLoan7.Name = "lblLoan7";
            this.lblLoan7.Size = new System.Drawing.Size(88, 16);
            this.lblLoan7.TabIndex = 292;
            this.lblLoan7.Text = "Loan Number";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Yellow;
            this.label84.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label84.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(225, 18);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(51, 18);
            this.label84.TabIndex = 290;
            this.label84.Text = "Loan1";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.SandyBrown;
            this.label85.Font = new System.Drawing.Font("Arial", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(4, 18);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(107, 18);
            this.label85.TabIndex = 289;
            this.label85.Text = "Service Name";
            // 
            // label86
            // 
            this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label86.BackColor = System.Drawing.Color.Yellow;
            this.label86.Location = new System.Drawing.Point(208, 13);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(976, 25);
            this.label86.TabIndex = 288;
            this.label86.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label87
            // 
            this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label87.BackColor = System.Drawing.Color.SandyBrown;
            this.label87.Location = new System.Drawing.Point(4, 13);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(250, 25);
            this.label87.TabIndex = 291;
            this.label87.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(837, 121);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(39, 16);
            this.label88.TabIndex = 283;
            this.label88.Text = "Other";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(837, 98);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(41, 16);
            this.label89.TabIndex = 282;
            this.label89.Text = "Office";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(837, 75);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(44, 16);
            this.label90.TabIndex = 281;
            this.label90.Text = "Home";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(472, 116);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(51, 16);
            this.label91.TabIndex = 280;
            this.label91.Text = "Region";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(472, 93);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(52, 16);
            this.label92.TabIndex = 279;
            this.label92.Text = "Gender";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(472, 70);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(116, 16);
            this.label93.TabIndex = 278;
            this.label93.Text = "Sub Product Code";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(10, 116);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(36, 16);
            this.label94.TabIndex = 277;
            this.label94.Text = "DOB";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(10, 93);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(104, 16);
            this.label109.TabIndex = 276;
            this.label109.Text = "Customer Name";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(10, 70);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(88, 16);
            this.label110.TabIndex = 275;
            this.label110.Text = "Loan Number";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(10, 46);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(73, 16);
            this.label111.TabIndex = 274;
            this.label111.Text = "Contact No";
            // 
            // FCallData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1234, 561);
            this.Controls.Add(this.mainTabControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FCallData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FCallData_Load);
            this.mainTabControl.ResumeLayout(false);
            this.homeTabPage.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dialerTabPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grp_phone_disconected.ResumeLayout(false);
            this.grp_phone_disconected.PerformLayout();
            this.grp_action.ResumeLayout(false);
            this.grp_action.PerformLayout();
            this.grp_phone_busy.ResumeLayout(false);
            this.grp_phone_busy.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grp_phone_remainder.ResumeLayout(false);
            this.grp_phone_remainder.PerformLayout();
            this.grp_phone_not_answer.ResumeLayout(false);
            this.grp_phone_not_answer.PerformLayout();
            this.grp_phone_leave_message.ResumeLayout(false);
            this.grp_phone_leave_message.PerformLayout();
            this.grp_with_borrower.ResumeLayout(false);
            this.grp_with_borrower.PerformLayout();
            this.grp_ptp.ResumeLayout(false);
            this.grp_ptp.PerformLayout();
            this.grp_with_cp.ResumeLayout(false);
            this.grp_with_cp.PerformLayout();
            this.grp_other_phone.ResumeLayout(false);
            this.grp_other_phone.PerformLayout();
            this.infoTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.customerTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage homeTabPage;
        private System.Windows.Forms.TabPage dialerTabPage;
        private System.Windows.Forms.TabPage customerTabPage;
        private System.Windows.Forms.TabPage infoTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label lblDPD2;
        private System.Windows.Forms.Label lblPrincipal3;
        private System.Windows.Forms.Label lblLoan3;
        private System.Windows.Forms.Label lblDPD1;
        private System.Windows.Forms.Label lblPrincipal2;
        private System.Windows.Forms.Label LblPrincipal1;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblLoan2;
        private System.Windows.Forms.Label lblLoan1;
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
        private System.Windows.Forms.Label lblBucket7;
        private System.Windows.Forms.Label lblBucket6;
        private System.Windows.Forms.Label lblBucket5;
        private System.Windows.Forms.Label lblBucket4;
        private System.Windows.Forms.Label lblBucket3;
        private System.Windows.Forms.Label lblBucket2;
        private System.Windows.Forms.Label lblBucket1;
        private System.Windows.Forms.Label lblChargesOverdue;
        private System.Windows.Forms.Label lblInterestOverdue;
        private System.Windows.Forms.Label lblPrincipleOverdue;
        private System.Windows.Forms.Label lblAmountOverdue;
        private System.Windows.Forms.Label lblOutstanding;
        private System.Windows.Forms.Label lblInhouseScore;
        private System.Windows.Forms.Label lblForeClosure_amt1;
        private System.Windows.Forms.Label lblBilingCycle;
        private System.Windows.Forms.Label lblDPD4;
        private System.Windows.Forms.Label lblLastPaymentDate;
        private System.Windows.Forms.Label lblLastPaymentAmount;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.TextBox txtmsg;
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
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPother;
        private System.Windows.Forms.Label lblPoffice;
        private System.Windows.Forms.Label lblPhome;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblCustName1;
        private System.Windows.Forms.Label lblLoan4;
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblPother2;
        private System.Windows.Forms.Label lblPoffice2;
        private System.Windows.Forms.Label lblPhome2;
        private System.Windows.Forms.Label lblRegion2;
        private System.Windows.Forms.Label lblGender2;
        private System.Windows.Forms.Label lblProduct2;
        private System.Windows.Forms.Label lblDOB2;
        private System.Windows.Forms.Label lblCustomerName3;
        private System.Windows.Forms.Label lblLoan6;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblAO_additional2;
        private System.Windows.Forms.Label lblAO_additional1;
        private System.Windows.Forms.Label lblPrincipal_additional2;
        private System.Windows.Forms.Label lblPrincipal_additional1;
        private System.Windows.Forms.Label lblDPD_additional2;
        private System.Windows.Forms.Label lblDPD_additional1;
        private System.Windows.Forms.Label lblLoad_additional2;
        private System.Windows.Forms.Label lblLoad_additional1;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label lblDisp6_Id;
        private System.Windows.Forms.Label lblDisp5_Id;
        private System.Windows.Forms.Label lblAgent6_c;
        private System.Windows.Forms.Label lblAgent5_c;
        private System.Windows.Forms.Label lblCall6_dt;
        private System.Windows.Forms.Label lblCall5_dt;
        private System.Windows.Forms.Label lblCall6_Phone;
        private System.Windows.Forms.Label lblCall5_Phone;
        private System.Windows.Forms.Label lblDisp4_Id;
        private System.Windows.Forms.Label lblDisp3_Id;
        private System.Windows.Forms.Label lblAgent4_c;
        private System.Windows.Forms.Label lblAgent3_c;
        private System.Windows.Forms.Label lblCall4_dt;
        private System.Windows.Forms.Label lblCall3_dt;
        private System.Windows.Forms.Label lblCall4_Phone;
        private System.Windows.Forms.Label lblCall3_Phone;
        private System.Windows.Forms.Label lblDisp2_Id;
        private System.Windows.Forms.Label lblDisp1_Id;
        private System.Windows.Forms.Label lblAgent2_c;
        private System.Windows.Forms.Label lblAgent1_c;
        private System.Windows.Forms.Label lblCall2_dt;
        private System.Windows.Forms.Label lblCall1_dt;
        private System.Windows.Forms.Label lblCall2_Phone;
        private System.Windows.Forms.Label lblCall1_Phone;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblCONTACTED_BY5;
        private System.Windows.Forms.Label lblCONTACTED_BY4;
        private System.Windows.Forms.Label lblCONTACTED_BY3;
        private System.Windows.Forms.Label lblCONTACTED_BY2;
        private System.Windows.Forms.Label lblCONTACTED_BY1;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label lblPERSON_CONTACTED6;
        private System.Windows.Forms.Label lblPERSON_CONTACTED5;
        private System.Windows.Forms.Label lblACTION_CODE6;
        private System.Windows.Forms.Label lblACTION_CODE5;
        private System.Windows.Forms.Label lblCONTACT_PLACE6;
        private System.Windows.Forms.Label lblCONTACT_PLACE5;
        private System.Windows.Forms.Label lblCONTACT_DATE6;
        private System.Windows.Forms.Label lblCONTACT_DATE5;
        private System.Windows.Forms.Label lblPERSON_CONTACTED4;
        private System.Windows.Forms.Label lblPERSON_CONTACTED3;
        private System.Windows.Forms.Label lblACTION_CODE4;
        private System.Windows.Forms.Label lblACTION_CODE3;
        private System.Windows.Forms.Label lblCONTACT_PLACE4;
        private System.Windows.Forms.Label lblCONTACT_PLACE3;
        private System.Windows.Forms.Label lblCONTACT_DATE4;
        private System.Windows.Forms.Label lblCONTACT_DATE3;
        private System.Windows.Forms.Label lblPERSON_CONTACTED2;
        private System.Windows.Forms.Label lblPERSON_CONTACTED1;
        private System.Windows.Forms.Label lblACTION_CODE2;
        private System.Windows.Forms.Label lblACTION_CODE1;
        private System.Windows.Forms.Label lblCONTACT_PLACE2;
        private System.Windows.Forms.Label lblCONTACT_PLACE1;
        private System.Windows.Forms.Label lblCONTACT_DATE2;
        private System.Windows.Forms.Label lblCONTACT_DATE1;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.Label lblREMARKS6;
        private System.Windows.Forms.Label lblREMARKS5;
        private System.Windows.Forms.Label lblREMARKS4;
        private System.Windows.Forms.Label lblREMARKS3;
        private System.Windows.Forms.Label lblREMARKS2;
        private System.Windows.Forms.Label lblREMARKS1;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label lblCONTACTED_BY6;
        private System.Windows.Forms.Label lblREMARKS8;
        private System.Windows.Forms.Label lblREMARKS7;
        private System.Windows.Forms.Label lblCONTACTED_BY8;
        private System.Windows.Forms.Label lblCONTACTED_BY7;
        private System.Windows.Forms.Label lblPERSON_CONTACTED8;
        private System.Windows.Forms.Label lblPERSON_CONTACTED7;
        private System.Windows.Forms.Label lblACTION_CODE8;
        private System.Windows.Forms.Label lblACTION_CODE7;
        private System.Windows.Forms.Label lblCONTACT_PLACE8;
        private System.Windows.Forms.Label lblCONTACT_PLACE7;
        private System.Windows.Forms.Label lblCONTACT_DATE8;
        private System.Windows.Forms.Label lblCONTACT_DATE7;
        private System.Windows.Forms.Label lblaccno;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label lblPother3;
        private System.Windows.Forms.Label lblPoffice3;
        private System.Windows.Forms.Label lblPhome3;
        private System.Windows.Forms.Label lblRegion3;
        private System.Windows.Forms.Label lblGender3;
        private System.Windows.Forms.Label lblProduct3;
        private System.Windows.Forms.Label lblDOB3;
        private System.Windows.Forms.Label lblCustomerName4;
        private System.Windows.Forms.Label lblLoan7;
        private System.Windows.Forms.Label label84;
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
        private System.Windows.Forms.Label lblMOBILE_O;
        private System.Windows.Forms.Label lblMOBILE_E;
        private System.Windows.Forms.Label lblMOBILE_P;
        private System.Windows.Forms.Label lblCONTACT2_O;
        private System.Windows.Forms.Label lblCONTACT1_O;
        private System.Windows.Forms.Label lblCONTACT2_E;
        private System.Windows.Forms.Label lblCONTACT1_E;
        private System.Windows.Forms.Label lblCONTACT2_P;
        private System.Windows.Forms.Label lblCONTACT1_P;
        private System.Windows.Forms.Label lblCITY_O;
        private System.Windows.Forms.Label lblALAMAT_O;
        private System.Windows.Forms.Label lblCITY_E;
        private System.Windows.Forms.Label lblALAMAT_E;
        private System.Windows.Forms.Label lblCITY_P;
        private System.Windows.Forms.Label lblALAMAT_P;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.GroupBox grp_ptp;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.GroupBox grp_with_borrower;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.GroupBox grp_with_cp;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Label label200;
        private System.Windows.Forms.Label label201;
        private System.Windows.Forms.Label label202;
        private System.Windows.Forms.Label label203;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label label204;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Label label205;
        private System.Windows.Forms.Label label206;
        private System.Windows.Forms.Label label207;
        private System.Windows.Forms.GroupBox grp_other_phone;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Label label208;
        private System.Windows.Forms.ComboBox comboBox26;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.Label label209;
        private System.Windows.Forms.Label label210;
        private System.Windows.Forms.ComboBox comboBox27;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.Label label211;
        private System.Windows.Forms.Label label212;
        private System.Windows.Forms.ComboBox comboBox28;
        private System.Windows.Forms.ComboBox comboBox29;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label213;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.Label label215;
        private System.Windows.Forms.Label label216;
        private System.Windows.Forms.Label label217;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Label label218;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Label label219;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.Label label221;
        private System.Windows.Forms.GroupBox grp_phone_remainder;
        private System.Windows.Forms.ComboBox comboBox30;
        private System.Windows.Forms.Label label222;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Label label223;
        private System.Windows.Forms.ComboBox comboBox31;
        private System.Windows.Forms.ComboBox comboBox32;
        private System.Windows.Forms.Label label224;
        private System.Windows.Forms.ComboBox comboBox33;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label225;
        private System.Windows.Forms.Label label226;
        private System.Windows.Forms.Label label227;
        private System.Windows.Forms.Label label228;
        private System.Windows.Forms.Label label229;
        private System.Windows.Forms.ComboBox comboBox34;
        private System.Windows.Forms.ComboBox comboBox35;
        private System.Windows.Forms.Label label230;
        private System.Windows.Forms.ComboBox comboBox36;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.Label label231;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label233;
        private System.Windows.Forms.Label label234;
        private System.Windows.Forms.Label label235;
        private System.Windows.Forms.ComboBox comboBox37;
        private System.Windows.Forms.ComboBox comboBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.Label label236;
        private System.Windows.Forms.Label label237;
        private System.Windows.Forms.Label label238;
        private System.Windows.Forms.Label label239;
        private System.Windows.Forms.Label label240;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Label label241;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Label label242;
        private System.Windows.Forms.Label label243;
        private System.Windows.Forms.Label label244;
        private System.Windows.Forms.GroupBox grp_phone_not_answer;
        private System.Windows.Forms.ComboBox comboBox39;
        private System.Windows.Forms.ComboBox comboBox40;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox57;
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
        private System.Windows.Forms.GroupBox grp_phone_leave_message;
        private System.Windows.Forms.ComboBox comboBox41;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.Label label253;
        private System.Windows.Forms.Label label254;
        private System.Windows.Forms.ComboBox comboBox42;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.Label label255;
        private System.Windows.Forms.Label label256;
        private System.Windows.Forms.ComboBox comboBox43;
        private System.Windows.Forms.ComboBox comboBox44;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.Label label257;
        private System.Windows.Forms.Label label258;
        private System.Windows.Forms.Label label259;
        private System.Windows.Forms.Label label260;
        private System.Windows.Forms.Label label261;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Label label262;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.Label label263;
        private System.Windows.Forms.Label label264;
        private System.Windows.Forms.Label label265;
        private System.Windows.Forms.GroupBox grp_phone_busy;
        private System.Windows.Forms.ComboBox comboBox45;
        private System.Windows.Forms.ComboBox comboBox46;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.Label label266;
        private System.Windows.Forms.Label label267;
        private System.Windows.Forms.Label label268;
        private System.Windows.Forms.Label label269;
        private System.Windows.Forms.Label label270;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Label label271;
        private System.Windows.Forms.Label label272;
        private System.Windows.Forms.Label label273;
        private System.Windows.Forms.GroupBox grp_action;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.GroupBox grp_phone_disconected;
        private System.Windows.Forms.ComboBox comboBox47;
        private System.Windows.Forms.ComboBox comboBox48;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.Label label274;
        private System.Windows.Forms.Label label275;
        private System.Windows.Forms.Label label276;
        private System.Windows.Forms.Label label277;
        private System.Windows.Forms.Label label278;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Label label279;
        private System.Windows.Forms.Label label280;
        private System.Windows.Forms.Label label281;
        //private System.Windows.Forms.TextBox txtUserDefined1;
        //private System.Windows.Forms.Label lblUserDefined1;
        //private System.Windows.Forms.Label lblUserDefined2;
        //private System.Windows.Forms.TextBox txtUserDefined2;
        //private System.Windows.Forms.Label lblUserDefined3;
        //private System.Windows.Forms.Label lblUserDefined4;
        //private System.Windows.Forms.Label lblUserDefined5;
        //private System.Windows.Forms.Label lblUserDefined6;
        //private System.Windows.Forms.Label lblUserDefined7;
        //private System.Windows.Forms.Label lblUserDefined8;
        //private System.Windows.Forms.Label lblUserDefined9;
        //private System.Windows.Forms.Label lblUserDefined10;
        //private System.Windows.Forms.TextBox txtUserDefined9;
        //private System.Windows.Forms.TextBox txtUserDefined10;
        //private System.Windows.Forms.TextBox txtUserDefined3;
        //private System.Windows.Forms.TextBox txtUserDefined4;
        //private System.Windows.Forms.TextBox txtUserDefined5;
        //private System.Windows.Forms.TextBox txtUserDefined6;
        //private System.Windows.Forms.TextBox txtUserDefined7;
        //private System.Windows.Forms.TextBox txtUserDefined8;
        //private System.Windows.Forms.Label lblUserDefined12;
        //private System.Windows.Forms.Label lblUserDefined11;
        //private System.Windows.Forms.Label lblUserDefined19;
        //private System.Windows.Forms.Label lblUserDefined18;
        //private System.Windows.Forms.Label lblUserDefined17;
        //private System.Windows.Forms.Label lblUserDefined16;
        //private System.Windows.Forms.Label lblUserDefined15;
        //private System.Windows.Forms.Label lblUserDefined14;
        //private System.Windows.Forms.Label lblUserDefined13;
        //private System.Windows.Forms.Label lblUserDefined20;
        //private System.Windows.Forms.TextBox txtUserDefined14;
        //private System.Windows.Forms.TextBox txtUserDefined13;
        //private System.Windows.Forms.TextBox txtUserDefined12;
        //private System.Windows.Forms.TextBox txtUserDefined11;
        //private System.Windows.Forms.TextBox txtUserDefined20;
        //private System.Windows.Forms.TextBox txtUserDefined19;
        //private System.Windows.Forms.TextBox txtUserDefined18;
        //private System.Windows.Forms.TextBox txtUserDefined17;
        //private System.Windows.Forms.TextBox txtUserDefined16;
        //private System.Windows.Forms.TextBox txtUserDefined15;
        //private System.Windows.Forms.Label lblCallbackMemo;
        //private System.Windows.Forms.TextBox txtCallbackMemo;
        //private System.Windows.Forms.Button btnSave;
        //private System.Windows.Forms.Button btnCancel;
        //private System.Windows.Forms.Label lblService;
        //private System.Windows.Forms.TextBox txtService;
        //private System.Windows.Forms.Label lblDNIS;
        //private System.Windows.Forms.TextBox txtDNIS;
        //private System.Windows.Forms.Label lblCallerId;
        //private System.Windows.Forms.TextBox txtCallerId;
        //private System.Windows.Forms.Label lblPhone;
        //private System.Windows.Forms.TextBox txtPhone;


        private Panel pnlAnswerCall;
        private Button btnRejectCall;
        private Button btnAcceptCall;
        private Label lblAnswerCallCountDown;
		private CCall mpCall;
		private CApp mpApp;
		private System.Threading.Timer mpUnloadTimer;
        private int miAnswerCallTickCount;
        private System.Threading.Timer mpAnswerCallTimer;
        FList CallRejectionForm;
       

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private void MainForm_Load(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = homeTabPage;
            grp_action.Visible = true;
            load_group(false);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_ptp();
        //    //form.ShowDialog();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_contact_with_borrower();
        //    //form.ShowDialog();
        //}

        //private void button9_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_contact_with_cp();
        //    //form.ShowDialog();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_other();
        //    //form.ShowDialog();
        //}

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_leave_message();
        //    //form.ShowDialog();
        //}

        //private void button13_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_busy();
        //    //form.ShowDialog();
        //}

        //private void button14_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_disconnected();
        //    //form.ShowDialog();
        //}

        //private void button15_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_no_answer();
        //    //form.ShowDialog();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_case_or_complain();
        //    //form.ShowDialog();
        //}

        //private void button16_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_sent_to_fa();
        //    //form.ShowDialog();
        //}

        //private void button17_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_customer_decease();
        //    //form.ShowDialog();
        //}

        //private void button18_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_acc_tidak_layak_tagih();
        //    //form.ShowDialog();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //var form = new act_phone_reminder();
        //    //form.ShowDialog();
        //}
        public FCallData1(CCall pCall, CApp pApp)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            load_group(false);
            grp_action.Visible = true;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            mpCall = pCall;
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
        ////private void InitializeComponent()
        ////{
        ////          this.txtUserDefined1 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined1 = new System.Windows.Forms.Label();
        ////          this.lblUserDefined2 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined2 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined3 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined3 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined4 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined4 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined5 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined5 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined6 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined6 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined7 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined7 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined8 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined8 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined9 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined9 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined10 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined10 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined20 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined20 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined19 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined19 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined18 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined18 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined17 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined17 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined16 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined16 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined15 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined15 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined14 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined14 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined13 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined13 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined12 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined12 = new System.Windows.Forms.TextBox();
        ////          this.lblUserDefined11 = new System.Windows.Forms.Label();
        ////          this.txtUserDefined11 = new System.Windows.Forms.TextBox();
        ////          this.txtCallbackMemo = new System.Windows.Forms.TextBox();
        ////          this.lblCallbackMemo = new System.Windows.Forms.Label();
        ////          this.btnSave = new System.Windows.Forms.Button();
        ////          this.btnCancel = new System.Windows.Forms.Button();
        ////          this.lblService = new System.Windows.Forms.Label();
        ////          this.txtService = new System.Windows.Forms.TextBox();
        ////          this.lblDNIS = new System.Windows.Forms.Label();
        ////          this.txtDNIS = new System.Windows.Forms.TextBox();
        ////          this.lblCallerId = new System.Windows.Forms.Label();
        ////          this.txtCallerId = new System.Windows.Forms.TextBox();
        ////          this.lblPhone = new System.Windows.Forms.Label();
        ////          this.txtPhone = new System.Windows.Forms.TextBox();
        ////          this.pnlAnswerCall = new System.Windows.Forms.Panel();
        ////          this.btnAcceptCall = new System.Windows.Forms.Button();
        ////          this.btnRejectCall = new System.Windows.Forms.Button();
        ////          this.lblAnswerCallCountDown = new System.Windows.Forms.Label();
        ////          this.pnlAnswerCall.SuspendLayout();
        ////          this.SuspendLayout();
        ////          // 
        ////          // txtUserDefined1
        ////          // 
        ////          this.txtUserDefined1.Location = new System.Drawing.Point(127, 83);
        ////          this.txtUserDefined1.Name = "txtUserDefined1";
        ////          this.txtUserDefined1.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined1.TabIndex = 0;
        ////          this.txtUserDefined1.TextChanged += new System.EventHandler(this.txtUserDefined1_TextChanged);
        ////          // 
        ////          // lblUserDefined1
        ////          // 
        ////          this.lblUserDefined1.Location = new System.Drawing.Point(20, 82);
        ////          this.lblUserDefined1.Name = "lblUserDefined1";
        ////          this.lblUserDefined1.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined1.TabIndex = 1;
        ////          this.lblUserDefined1.Text = "User Defined";
        ////          this.lblUserDefined1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined1.Click += new System.EventHandler(this.lblUserDefined1_Click);
        ////          // 
        ////          // lblUserDefined2
        ////          // 
        ////          this.lblUserDefined2.Location = new System.Drawing.Point(20, 110);
        ////          this.lblUserDefined2.Name = "lblUserDefined2";
        ////          this.lblUserDefined2.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined2.TabIndex = 3;
        ////          this.lblUserDefined2.Text = "User Defined";
        ////          this.lblUserDefined2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined2.Click += new System.EventHandler(this.lblUserDefined2_Click);
        ////          // 
        ////          // txtUserDefined2
        ////          // 
        ////          this.txtUserDefined2.Location = new System.Drawing.Point(127, 111);
        ////          this.txtUserDefined2.Name = "txtUserDefined2";
        ////          this.txtUserDefined2.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined2.TabIndex = 2;
        ////          this.txtUserDefined2.TextChanged += new System.EventHandler(this.txtUserDefined2_TextChanged);
        ////          // 
        ////          // lblUserDefined3
        ////          // 
        ////          this.lblUserDefined3.Location = new System.Drawing.Point(20, 138);
        ////          this.lblUserDefined3.Name = "lblUserDefined3";
        ////          this.lblUserDefined3.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined3.TabIndex = 5;
        ////          this.lblUserDefined3.Text = "User Defined";
        ////          this.lblUserDefined3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined3.Click += new System.EventHandler(this.lblUserDefined3_Click);
        ////          // 
        ////          // txtUserDefined3
        ////          // 
        ////          this.txtUserDefined3.Location = new System.Drawing.Point(127, 139);
        ////          this.txtUserDefined3.Name = "txtUserDefined3";
        ////          this.txtUserDefined3.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined3.TabIndex = 4;
        ////          this.txtUserDefined3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        ////          // 
        ////          // lblUserDefined4
        ////          // 
        ////          this.lblUserDefined4.Location = new System.Drawing.Point(20, 166);
        ////          this.lblUserDefined4.Name = "lblUserDefined4";
        ////          this.lblUserDefined4.Size = new System.Drawing.Size(100, 20);
        ////          this.lblUserDefined4.TabIndex = 7;
        ////          this.lblUserDefined4.Text = "User Defined";
        ////          this.lblUserDefined4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined4.Click += new System.EventHandler(this.lblUserDefined4_Click);
        ////          // 
        ////          // txtUserDefined4
        ////          // 
        ////          this.txtUserDefined4.Location = new System.Drawing.Point(127, 166);
        ////          this.txtUserDefined4.Name = "txtUserDefined4";
        ////          this.txtUserDefined4.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined4.TabIndex = 6;
        ////          this.txtUserDefined4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
        ////          // 
        ////          // lblUserDefined5
        ////          // 
        ////          this.lblUserDefined5.Location = new System.Drawing.Point(20, 193);
        ////          this.lblUserDefined5.Name = "lblUserDefined5";
        ////          this.lblUserDefined5.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined5.TabIndex = 9;
        ////          this.lblUserDefined5.Text = "User Defined";
        ////          this.lblUserDefined5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined5.Click += new System.EventHandler(this.lblUserDefined5_Click);
        ////          // 
        ////          // txtUserDefined5
        ////          // 
        ////          this.txtUserDefined5.Location = new System.Drawing.Point(127, 194);
        ////          this.txtUserDefined5.Name = "txtUserDefined5";
        ////          this.txtUserDefined5.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined5.TabIndex = 8;
        ////          this.txtUserDefined5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
        ////          // 
        ////          // lblUserDefined6
        ////          // 
        ////          this.lblUserDefined6.Location = new System.Drawing.Point(20, 221);
        ////          this.lblUserDefined6.Name = "lblUserDefined6";
        ////          this.lblUserDefined6.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined6.TabIndex = 11;
        ////          this.lblUserDefined6.Text = "User Defined";
        ////          this.lblUserDefined6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined6.Click += new System.EventHandler(this.lblUserDefined6_Click);
        ////          // 
        ////          // txtUserDefined6
        ////          // 
        ////          this.txtUserDefined6.Location = new System.Drawing.Point(127, 222);
        ////          this.txtUserDefined6.Name = "txtUserDefined6";
        ////          this.txtUserDefined6.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined6.TabIndex = 10;
        ////          this.txtUserDefined6.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
        ////          // 
        ////          // lblUserDefined7
        ////          // 
        ////          this.lblUserDefined7.Location = new System.Drawing.Point(20, 249);
        ////          this.lblUserDefined7.Name = "lblUserDefined7";
        ////          this.lblUserDefined7.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined7.TabIndex = 13;
        ////          this.lblUserDefined7.Text = "User Defined";
        ////          this.lblUserDefined7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined7.Click += new System.EventHandler(this.lblUserDefined7_Click);
        ////          // 
        ////          // txtUserDefined7
        ////          // 
        ////          this.txtUserDefined7.Location = new System.Drawing.Point(127, 250);
        ////          this.txtUserDefined7.Name = "txtUserDefined7";
        ////          this.txtUserDefined7.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined7.TabIndex = 12;
        ////          this.txtUserDefined7.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
        ////          // 
        ////          // lblUserDefined8
        ////          // 
        ////          this.lblUserDefined8.Location = new System.Drawing.Point(20, 276);
        ////          this.lblUserDefined8.Name = "lblUserDefined8";
        ////          this.lblUserDefined8.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined8.TabIndex = 15;
        ////          this.lblUserDefined8.Text = "User Defined";
        ////          this.lblUserDefined8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined8.Click += new System.EventHandler(this.lblUserDefined8_Click);
        ////          // 
        ////          // txtUserDefined8
        ////          // 
        ////          this.txtUserDefined8.Location = new System.Drawing.Point(127, 277);
        ////          this.txtUserDefined8.Name = "txtUserDefined8";
        ////          this.txtUserDefined8.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined8.TabIndex = 14;
        ////          this.txtUserDefined8.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
        ////          // 
        ////          // lblUserDefined9
        ////          // 
        ////          this.lblUserDefined9.Location = new System.Drawing.Point(20, 304);
        ////          this.lblUserDefined9.Name = "lblUserDefined9";
        ////          this.lblUserDefined9.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined9.TabIndex = 17;
        ////          this.lblUserDefined9.Text = "User Defined";
        ////          this.lblUserDefined9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined9.Click += new System.EventHandler(this.lblUserDefined9_Click);
        ////          // 
        ////          // txtUserDefined9
        ////          // 
        ////          this.txtUserDefined9.Location = new System.Drawing.Point(127, 305);
        ////          this.txtUserDefined9.Name = "txtUserDefined9";
        ////          this.txtUserDefined9.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined9.TabIndex = 16;
        ////          this.txtUserDefined9.TextChanged += new System.EventHandler(this.txtUserDefined9_TextChanged);
        ////          // 
        ////          // lblUserDefined10
        ////          // 
        ////          this.lblUserDefined10.Location = new System.Drawing.Point(20, 332);
        ////          this.lblUserDefined10.Name = "lblUserDefined10";
        ////          this.lblUserDefined10.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined10.TabIndex = 19;
        ////          this.lblUserDefined10.Text = "User Defined";
        ////          this.lblUserDefined10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined10.Click += new System.EventHandler(this.lblUserDefined10_Click);
        ////          // 
        ////          // txtUserDefined10
        ////          // 
        ////          this.txtUserDefined10.Location = new System.Drawing.Point(127, 333);
        ////          this.txtUserDefined10.Name = "txtUserDefined10";
        ////          this.txtUserDefined10.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined10.TabIndex = 18;
        ////          this.txtUserDefined10.TextChanged += new System.EventHandler(this.txtUserDefined10_TextChanged);
        ////          // 
        ////          // lblUserDefined20
        ////          // 
        ////          this.lblUserDefined20.Location = new System.Drawing.Point(327, 333);
        ////          this.lblUserDefined20.Name = "lblUserDefined20";
        ////          this.lblUserDefined20.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined20.TabIndex = 39;
        ////          this.lblUserDefined20.Text = "User Defined";
        ////          this.lblUserDefined20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          this.lblUserDefined20.Click += new System.EventHandler(this.label1_Click);
        ////          // 
        ////          // txtUserDefined20
        ////          // 
        ////          this.txtUserDefined20.Location = new System.Drawing.Point(433, 333);
        ////          this.txtUserDefined20.Name = "txtUserDefined20";
        ////          this.txtUserDefined20.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined20.TabIndex = 38;
        ////          // 
        ////          // lblUserDefined19
        ////          // 
        ////          this.lblUserDefined19.Location = new System.Drawing.Point(327, 305);
        ////          this.lblUserDefined19.Name = "lblUserDefined19";
        ////          this.lblUserDefined19.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined19.TabIndex = 37;
        ////          this.lblUserDefined19.Text = "User Defined";
        ////          this.lblUserDefined19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined19
        ////          // 
        ////          this.txtUserDefined19.Location = new System.Drawing.Point(433, 305);
        ////          this.txtUserDefined19.Name = "txtUserDefined19";
        ////          this.txtUserDefined19.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined19.TabIndex = 36;
        ////          // 
        ////          // lblUserDefined18
        ////          // 
        ////          this.lblUserDefined18.Location = new System.Drawing.Point(327, 277);
        ////          this.lblUserDefined18.Name = "lblUserDefined18";
        ////          this.lblUserDefined18.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined18.TabIndex = 35;
        ////          this.lblUserDefined18.Text = "User Defined";
        ////          this.lblUserDefined18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined18
        ////          // 
        ////          this.txtUserDefined18.Location = new System.Drawing.Point(433, 277);
        ////          this.txtUserDefined18.Name = "txtUserDefined18";
        ////          this.txtUserDefined18.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined18.TabIndex = 34;
        ////          // 
        ////          // lblUserDefined17
        ////          // 
        ////          this.lblUserDefined17.Location = new System.Drawing.Point(327, 250);
        ////          this.lblUserDefined17.Name = "lblUserDefined17";
        ////          this.lblUserDefined17.Size = new System.Drawing.Size(100, 20);
        ////          this.lblUserDefined17.TabIndex = 33;
        ////          this.lblUserDefined17.Text = "User Defined";
        ////          this.lblUserDefined17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined17
        ////          // 
        ////          this.txtUserDefined17.Location = new System.Drawing.Point(433, 250);
        ////          this.txtUserDefined17.Name = "txtUserDefined17";
        ////          this.txtUserDefined17.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined17.TabIndex = 32;
        ////          // 
        ////          // lblUserDefined16
        ////          // 
        ////          this.lblUserDefined16.Location = new System.Drawing.Point(327, 222);
        ////          this.lblUserDefined16.Name = "lblUserDefined16";
        ////          this.lblUserDefined16.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined16.TabIndex = 31;
        ////          this.lblUserDefined16.Text = "User Defined";
        ////          this.lblUserDefined16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined16
        ////          // 
        ////          this.txtUserDefined16.Location = new System.Drawing.Point(433, 222);
        ////          this.txtUserDefined16.Name = "txtUserDefined16";
        ////          this.txtUserDefined16.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined16.TabIndex = 30;
        ////          // 
        ////          // lblUserDefined15
        ////          // 
        ////          this.lblUserDefined15.Location = new System.Drawing.Point(327, 194);
        ////          this.lblUserDefined15.Name = "lblUserDefined15";
        ////          this.lblUserDefined15.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined15.TabIndex = 29;
        ////          this.lblUserDefined15.Text = "User Defined";
        ////          this.lblUserDefined15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined15
        ////          // 
        ////          this.txtUserDefined15.Location = new System.Drawing.Point(433, 194);
        ////          this.txtUserDefined15.Name = "txtUserDefined15";
        ////          this.txtUserDefined15.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined15.TabIndex = 28;
        ////          this.txtUserDefined15.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
        ////          // 
        ////          // lblUserDefined14
        ////          // 
        ////          this.lblUserDefined14.Location = new System.Drawing.Point(327, 166);
        ////          this.lblUserDefined14.Name = "lblUserDefined14";
        ////          this.lblUserDefined14.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined14.TabIndex = 27;
        ////          this.lblUserDefined14.Text = "User Defined";
        ////          this.lblUserDefined14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined14
        ////          // 
        ////          this.txtUserDefined14.Location = new System.Drawing.Point(433, 166);
        ////          this.txtUserDefined14.Name = "txtUserDefined14";
        ////          this.txtUserDefined14.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined14.TabIndex = 26;
        ////          // 
        ////          // lblUserDefined13
        ////          // 
        ////          this.lblUserDefined13.Location = new System.Drawing.Point(327, 139);
        ////          this.lblUserDefined13.Name = "lblUserDefined13";
        ////          this.lblUserDefined13.Size = new System.Drawing.Size(100, 20);
        ////          this.lblUserDefined13.TabIndex = 25;
        ////          this.lblUserDefined13.Text = "User Defined";
        ////          this.lblUserDefined13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined13
        ////          // 
        ////          this.txtUserDefined13.Location = new System.Drawing.Point(433, 139);
        ////          this.txtUserDefined13.Name = "txtUserDefined13";
        ////          this.txtUserDefined13.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined13.TabIndex = 24;
        ////          // 
        ////          // lblUserDefined12
        ////          // 
        ////          this.lblUserDefined12.Location = new System.Drawing.Point(327, 111);
        ////          this.lblUserDefined12.Name = "lblUserDefined12";
        ////          this.lblUserDefined12.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined12.TabIndex = 23;
        ////          this.lblUserDefined12.Text = "User Defined";
        ////          this.lblUserDefined12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined12
        ////          // 
        ////          this.txtUserDefined12.Location = new System.Drawing.Point(433, 111);
        ////          this.txtUserDefined12.Name = "txtUserDefined12";
        ////          this.txtUserDefined12.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined12.TabIndex = 22;
        ////          // 
        ////          // lblUserDefined11
        ////          // 
        ////          this.lblUserDefined11.Location = new System.Drawing.Point(327, 83);
        ////          this.lblUserDefined11.Name = "lblUserDefined11";
        ////          this.lblUserDefined11.Size = new System.Drawing.Size(100, 21);
        ////          this.lblUserDefined11.TabIndex = 21;
        ////          this.lblUserDefined11.Text = "User Defined";
        ////          this.lblUserDefined11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtUserDefined11
        ////          // 
        ////          this.txtUserDefined11.Location = new System.Drawing.Point(433, 83);
        ////          this.txtUserDefined11.Name = "txtUserDefined11";
        ////          this.txtUserDefined11.Size = new System.Drawing.Size(180, 20);
        ////          this.txtUserDefined11.TabIndex = 20;
        ////          // 
        ////          // txtCallbackMemo
        ////          // 
        ////          this.txtCallbackMemo.Location = new System.Drawing.Point(20, 438);
        ////          this.txtCallbackMemo.Multiline = true;
        ////          this.txtCallbackMemo.Name = "txtCallbackMemo";
        ////          this.txtCallbackMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        ////          this.txtCallbackMemo.Size = new System.Drawing.Size(593, 62);
        ////          this.txtCallbackMemo.TabIndex = 40;
        ////          this.txtCallbackMemo.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
        ////          // 
        ////          // lblCallbackMemo
        ////          // 
        ////          this.lblCallbackMemo.Location = new System.Drawing.Point(20, 415);
        ////          this.lblCallbackMemo.Name = "lblCallbackMemo";
        ////          this.lblCallbackMemo.Size = new System.Drawing.Size(100, 21);
        ////          this.lblCallbackMemo.TabIndex = 41;
        ////          this.lblCallbackMemo.Text = "Callback Memo:";
        ////          this.lblCallbackMemo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // btnSave
        ////          // 
        ////          this.btnSave.Location = new System.Drawing.Point(463, 515);
        ////          this.btnSave.Name = "btnSave";
        ////          this.btnSave.Size = new System.Drawing.Size(72, 26);
        ////          this.btnSave.TabIndex = 42;
        ////          this.btnSave.Text = "Save";
        ////          // 
        ////          // btnCancel
        ////          // 
        ////          this.btnCancel.Location = new System.Drawing.Point(544, 515);
        ////          this.btnCancel.Name = "btnCancel";
        ////          this.btnCancel.Size = new System.Drawing.Size(72, 26);
        ////          this.btnCancel.TabIndex = 43;
        ////          this.btnCancel.Text = "Cancel";
        ////          this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        ////          // 
        ////          // lblService
        ////          // 
        ////          this.lblService.Location = new System.Drawing.Point(20, 14);
        ////          this.lblService.Name = "lblService";
        ////          this.lblService.Size = new System.Drawing.Size(100, 21);
        ////          this.lblService.TabIndex = 45;
        ////          this.lblService.Text = "Service";
        ////          this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtService
        ////          // 
        ////          this.txtService.BackColor = System.Drawing.SystemColors.InactiveBorder;
        ////          this.txtService.Location = new System.Drawing.Point(127, 14);
        ////          this.txtService.Name = "txtService";
        ////          this.txtService.Size = new System.Drawing.Size(180, 20);
        ////          this.txtService.TabIndex = 44;
        ////          // 
        ////          // lblDNIS
        ////          // 
        ////          this.lblDNIS.Location = new System.Drawing.Point(20, 37);
        ////          this.lblDNIS.Name = "lblDNIS";
        ////          this.lblDNIS.Size = new System.Drawing.Size(100, 21);
        ////          this.lblDNIS.TabIndex = 47;
        ////          this.lblDNIS.Text = "DNIS";
        ////          this.lblDNIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtDNIS
        ////          // 
        ////          this.txtDNIS.BackColor = System.Drawing.SystemColors.InactiveBorder;
        ////          this.txtDNIS.Location = new System.Drawing.Point(127, 37);
        ////          this.txtDNIS.Name = "txtDNIS";
        ////          this.txtDNIS.Size = new System.Drawing.Size(180, 20);
        ////          this.txtDNIS.TabIndex = 46;
        ////          // 
        ////          // lblCallerId
        ////          // 
        ////          this.lblCallerId.Location = new System.Drawing.Point(327, 35);
        ////          this.lblCallerId.Name = "lblCallerId";
        ////          this.lblCallerId.Size = new System.Drawing.Size(100, 20);
        ////          this.lblCallerId.TabIndex = 51;
        ////          this.lblCallerId.Text = "CallerId";
        ////          this.lblCallerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtCallerId
        ////          // 
        ////          this.txtCallerId.BackColor = System.Drawing.SystemColors.InactiveBorder;
        ////          this.txtCallerId.Location = new System.Drawing.Point(433, 37);
        ////          this.txtCallerId.Name = "txtCallerId";
        ////          this.txtCallerId.Size = new System.Drawing.Size(180, 20);
        ////          this.txtCallerId.TabIndex = 50;
        ////          // 
        ////          // lblPhone
        ////          // 
        ////          this.lblPhone.Location = new System.Drawing.Point(327, 14);
        ////          this.lblPhone.Name = "lblPhone";
        ////          this.lblPhone.Size = new System.Drawing.Size(100, 21);
        ////          this.lblPhone.TabIndex = 49;
        ////          this.lblPhone.Text = "Phone";
        ////          this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        ////          // 
        ////          // txtPhone
        ////          // 
        ////          this.txtPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
        ////          this.txtPhone.Location = new System.Drawing.Point(433, 14);
        ////          this.txtPhone.Name = "txtPhone";
        ////          this.txtPhone.Size = new System.Drawing.Size(180, 20);
        ////          this.txtPhone.TabIndex = 48;
        ////          // 
        ////          // pnlAnswerCall
        ////          // 
        ////          this.pnlAnswerCall.Controls.Add(this.lblAnswerCallCountDown);
        ////          this.pnlAnswerCall.Controls.Add(this.btnRejectCall);
        ////          this.pnlAnswerCall.Controls.Add(this.btnAcceptCall);
        ////          this.pnlAnswerCall.Location = new System.Drawing.Point(207, 372);
        ////          this.pnlAnswerCall.Name = "pnlAnswerCall";
        ////          this.pnlAnswerCall.Size = new System.Drawing.Size(220, 34);
        ////          this.pnlAnswerCall.TabIndex = 52;
        ////          // 
        ////          // btnAcceptCall
        ////          // 
        ////          this.btnAcceptCall.Location = new System.Drawing.Point(5, 5);
        ////          this.btnAcceptCall.Name = "btnAcceptCall";
        ////          this.btnAcceptCall.Size = new System.Drawing.Size(72, 26);
        ////          this.btnAcceptCall.TabIndex = 0;
        ////          this.btnAcceptCall.Text = "Accept";
        ////          this.btnAcceptCall.UseVisualStyleBackColor = true;
        ////          this.btnAcceptCall.Click += new System.EventHandler(this.btnAcceptCall_Click);
        ////          // 
        ////          // btnRejectCall
        ////          // 
        ////          this.btnRejectCall.Location = new System.Drawing.Point(144, 5);
        ////          this.btnRejectCall.Name = "btnRejectCall";
        ////          this.btnRejectCall.Size = new System.Drawing.Size(72, 26);
        ////          this.btnRejectCall.TabIndex = 1;
        ////          this.btnRejectCall.Text = "Reject";
        ////          this.btnRejectCall.UseVisualStyleBackColor = true;
        ////          this.btnRejectCall.Click += new System.EventHandler(this.btnRejectCall_Click);
        ////          // 
        ////          // lblAnswerCallCountDown
        ////          // 
        ////          this.lblAnswerCallCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        ////          this.lblAnswerCallCountDown.Location = new System.Drawing.Point(81, 9);
        ////          this.lblAnswerCallCountDown.Name = "lblAnswerCallCountDown";
        ////          this.lblAnswerCallCountDown.Size = new System.Drawing.Size(59, 18);
        ////          this.lblAnswerCallCountDown.TabIndex = 2;
        ////          this.lblAnswerCallCountDown.Text = "000";
        ////          this.lblAnswerCallCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        ////          // 
        ////          // FCallData
        ////          // 
        ////          this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        ////          this.ClientSize = new System.Drawing.Size(634, 418);
        ////          this.Controls.Add(this.pnlAnswerCall);
        ////          this.Controls.Add(this.lblCallerId);
        ////          this.Controls.Add(this.txtCallerId);
        ////          this.Controls.Add(this.lblPhone);
        ////          this.Controls.Add(this.txtPhone);
        ////          this.Controls.Add(this.lblDNIS);
        ////          this.Controls.Add(this.txtDNIS);
        ////          this.Controls.Add(this.lblService);
        ////          this.Controls.Add(this.txtService);
        ////          this.Controls.Add(this.btnCancel);
        ////          this.Controls.Add(this.btnSave);
        ////          this.Controls.Add(this.lblCallbackMemo);
        ////          this.Controls.Add(this.txtCallbackMemo);
        ////          this.Controls.Add(this.lblUserDefined20);
        ////          this.Controls.Add(this.txtUserDefined20);
        ////          this.Controls.Add(this.lblUserDefined19);
        ////          this.Controls.Add(this.txtUserDefined19);
        ////          this.Controls.Add(this.lblUserDefined18);
        ////          this.Controls.Add(this.txtUserDefined18);
        ////          this.Controls.Add(this.lblUserDefined17);
        ////          this.Controls.Add(this.txtUserDefined17);
        ////          this.Controls.Add(this.lblUserDefined16);
        ////          this.Controls.Add(this.txtUserDefined16);
        ////          this.Controls.Add(this.lblUserDefined15);
        ////          this.Controls.Add(this.txtUserDefined15);
        ////          this.Controls.Add(this.lblUserDefined14);
        ////          this.Controls.Add(this.txtUserDefined14);
        ////          this.Controls.Add(this.lblUserDefined13);
        ////          this.Controls.Add(this.txtUserDefined13);
        ////          this.Controls.Add(this.lblUserDefined12);
        ////          this.Controls.Add(this.txtUserDefined12);
        ////          this.Controls.Add(this.lblUserDefined11);
        ////          this.Controls.Add(this.txtUserDefined11);
        ////          this.Controls.Add(this.lblUserDefined10);
        ////          this.Controls.Add(this.txtUserDefined10);
        ////          this.Controls.Add(this.lblUserDefined9);
        ////          this.Controls.Add(this.txtUserDefined9);
        ////          this.Controls.Add(this.lblUserDefined8);
        ////          this.Controls.Add(this.txtUserDefined8);
        ////          this.Controls.Add(this.lblUserDefined7);
        ////          this.Controls.Add(this.txtUserDefined7);
        ////          this.Controls.Add(this.lblUserDefined6);
        ////          this.Controls.Add(this.txtUserDefined6);
        ////          this.Controls.Add(this.lblUserDefined5);
        ////          this.Controls.Add(this.txtUserDefined5);
        ////          this.Controls.Add(this.lblUserDefined4);
        ////          this.Controls.Add(this.txtUserDefined4);
        ////          this.Controls.Add(this.lblUserDefined3);
        ////          this.Controls.Add(this.txtUserDefined3);
        ////          this.Controls.Add(this.lblUserDefined2);
        ////          this.Controls.Add(this.txtUserDefined2);
        ////          this.Controls.Add(this.lblUserDefined1);
        ////          this.Controls.Add(this.txtUserDefined1);
        ////          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        ////          this.Name = "FCallData";
        ////          this.Text = "Call Data";
        ////          //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FCallData_FormClosed);
        ////          this.Load += new System.EventHandler(this.FCallData_Load);
        ////          this.pnlAnswerCall.ResumeLayout(false);
        ////          this.ResumeLayout(false);
        ////          this.PerformLayout();

        ////}
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_ptp.Visible = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_ptp.Visible = false;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_ptp.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_with_borrower.Visible = true;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_with_borrower.Visible = false;

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_with_cp.Visible = true;
        }
        private void button30_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_with_cp.Visible = false;

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_other_phone.Visible = true;
        }
        private void button33_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_other_phone.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_remainder.Visible = true;

        }

        private void button36_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_remainder.Visible = false;

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_not_answer.Visible = true;

        }

        private void button38_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_not_answer.Visible = false;

        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_leave_message.Visible = true;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_leave_message.Visible = false;
        }
        private void button13_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_busy.Visible = true;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_busy.Visible = false;

        }
        private void button14_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = false;
            grp_phone_disconected.Visible = true;
        }

        private void button44_Click_1(object sender, EventArgs e)
        {
            load_group(false);
            grp_action.Visible = true;
            grp_phone_disconected.Visible = false;

        }
        private void load_group(bool values)
        {
            grp_ptp.Visible = values;
            grp_with_borrower.Visible = values;
            grp_with_cp.Visible = values;
            grp_other_phone.Visible = values;
            grp_phone_remainder.Visible = values;
            grp_phone_not_answer.Visible = values;
            grp_phone_leave_message.Visible = values;
            grp_phone_busy.Visible = values;
            grp_phone_disconected.Visible = values;

        }

        public void CApp_StateChange(Object pSender, CStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new StateChangeHandler(this.CApp_StateChange), new Object[] { pSender, pArgs });
                return;
            }

            switch (pArgs.NewState.Id)
            {
                case AgentStateId.asACTIVE:
                case AgentStateId.asACTIVE_INTERNAL:
                    if (mpCall.ResponseRequired && mpAnswerCallTimer != null)
                    {
                        ResetAnswerCallPanel();
 
                        //Hide panel
                        pnlAnswerCall.Visible = false;

                        //Start Unload Timer which fires only once in the next 4 seconds
                        System.Threading.TimerCallback timerDelegate = new System.Threading.TimerCallback(mpUnloadTimer_Fire);
                        mpUnloadTimer = new System.Threading.Timer(timerDelegate, this, 4000, System.Threading.Timeout.Infinite);
                    }
                    break;
                
                //If went to Idle or NotReady (eg, because Call offering was rejected or timed out), close the form
                case AgentStateId.asIDLE:
                case AgentStateId.asNOT_READY:
                    this.Close();
                    break;
            }
         }
        public class Account : IReturn<AccountResponse>
        {
            public int ServiceId { get; set; }
            public string AccountNo { get; set; }
        }

        public class AccountResponse
        {
            public string TableName { get; set; }
            public List<Metadata> Metadata { get; set; } = new List<Metadata>();
        }

        public class Metadata
        {
            public string FieldName { get; set; }
            public string FieldValue { get; set; }
            public string FieldType { get; set; }
        }
        private void FCallData_Load(object sender, System.EventArgs e)
        {
            mpApp.StateChange += new StateChangeHandler(this.CApp_StateChange);
            var ServiceName = mpApp.AssignedServices.GetByKey(mpCall.ServiceID).ServiceName;

            var AccountNo = mpCall.UserDefinedItems[0].value;
            string baseUrl = "http://localhost:5000";
            var client = new JsonServiceClient(baseUrl);
            var response = client.Post<AccountResponse>("/api/v1/account", new Account { ServiceId = mpCall.ServiceID, AccountNo = AccountNo });
            if (response != null)
            {

                var LOANNO = "";
                var CUSTID = "";
                var CUSTNAME = "";
                var FORECLOSURE_AMT = "";
                var OTH_LOANNO1 = "";
                var DPD = "";
                var OTH_DPD1 = "";
                var OTH_PRINCIPLE1 = "";
                var OTH_LOANNO2 = "";
                var OTH_DPD2 = "";
                var OTH_PRINCIPLE2 = "";

                var C_CONTACT2_P = "";
                var C_MOBILE_P = "";
                var C_CONTACT1_E = "";
                var MOBILE_O = "";
                var OTH_PRINCIPLE3 = "";
                var OTH_DPD3 = "";

                var DOB = "";
                var PRODUCT = "";//CURRENT_ORG
                var SEX = "";
                var ZIPCODE = "";
                var CONTACT1_P = "";
                var CONTACT1_E = "";
                var CONTACT1_O = "";

                var LAST_PAYMENT_AMT = "";
                var LAST_PAYMENT_DATE = "";
                var OPENED_DATE = "";
                var COLL_CYCLE = "";
                var AMT_OVERDUE = "";
                var PRINCIPLE_OVERDUE = "";
                var INTEREST_OVERDUE = "";
                var TOTCHARGES_OVERDUE = "";
                var PRINCIPLE_OUTSTD = "";
                var INHOUSE_SCORE3 = "";
                var BUCKET1 = "";
                var BUCKET2 = "";
                var BUCKET3 = "";
                var BUCKET4 = "";
                var BUCKET5 = "";
                var BUCKET6 = "";
                var BUCKET7 = "";

                var Call1_Phone = "";
                var Call2_Phone = "";
                var Call3_Phone = "";
                var Call4_Phone = "";
                var Call5_Phone = "";
                var Call6_Phone = "";
                var Call1_dt = "";
                var Call2_dt = "";
                var Call3_dt = "";
                var Call4_dt = "";
                var Call5_dt = "";
                var Call6_dt = "";
                var Disp1_Id = "";
                var Disp2_Id = "";
                var Disp3_Id = "";
                var Disp4_Id = "";
                var Disp5_Id = "";
                var Disp6_Id = "";
                var Agent1_c = "";
                var Agent2_c = "";
                var Agent3_c = "";
                var Agent4_c = "";
                var Agent5_c = "";
                var Agent6_c = "";
                var OTH_BALANCE1 = "";
                var OTH_BALANCE2 = "";

                var CONTACT_DATE1 = "";
                var CONTACT_PLACE1 = "";
                var PERSON_CONTACTED1 = "";
                var ACTION_CODE1 = "";
                var CONTACTED_BY1 = "";
                var REMARKS1 = "";
                var CONTACT_DATE2 = "";
                var CONTACT_PLACE2 = "";
                var PERSON_CONTACTED2 = "";
                var ACTION_CODE2 = "";
                var CONTACTED_BY2 = "";
                var REMARKS2 = "";
                var CONTACT_DATE3 = "";
                var CONTACT_PLACE3 = "";
                var PERSON_CONTACTED3 = "";
                var ACTION_CODE3 = "";
                var CONTACTED_BY3 = "";
                var REMARKS3 = "";
                var CONTACT_DATE4 = "";
                var CONTACT_PLACE4 = "";
                var PERSON_CONTACTED4 = "";
                var ACTION_CODE4 = "";
                var CONTACTED_BY4 = "";
                var REMARKS4 = "";
                var CONTACT_DATE5 = "";
                var CONTACT_PLACE5 = "";
                var PERSON_CONTACTED5 = "";
                var ACTION_CODE5 = "";
                var CONTACTED_BY5 = "";
                var REMARKS5 = "";
                var CONTACT_DATE6 = "";
                var CONTACT_PLACE6 = "";
                var PERSON_CONTACTED6 = "";
                var ACTION_CODE6 = "";
                var CONTACTED_BY6 = "";
                var REMARKS6 = "";
                var CONTACT_DATE7 = "";
                var CONTACT_PLACE7 = "";
                var PERSON_CONTACTED7 = "";
                var ACTION_CODE7 = "";
                var CONTACTED_BY7 = "";
                var REMARKS7 = "";
                var CONTACT_DATE8 = "";
                var CONTACT_PLACE8 = "";
                var PERSON_CONTACTED8 = "";
                var ACTION_CODE8 = "";
                var CONTACTED_BY8 = "";
                var REMARKS8 = "";




                var ALAMAT_P = "";
                var ADD_CONTACT1_P = "";
                var CONTACT2_P = "";
                var MOBILE_P = "";
                var CITY_P = "";
                var ALAMAT_E = "";
                var ADD_CONTACT1_E = "";
                var CONTACT2_E = "";
                var MOBILE_E = "";
                var CITY_E = "";
                var ALAMAT_O = "";
                var ADD_CONTACT1_O = "";
                var CONTACT2_O = "";
                var ADD_MOBILE_O = "";
                var CITY_O = "";




                for (int i = 0; i < response.Metadata.Count; i++)
                {
                    #region Home
                    var data = response.Metadata[i];
                    if (data.FieldName.ToString() == "LOANNO")
                        LOANNO = data.FieldValue;//B1.Loan Number LEFT - UserDefined1
                    if (data.FieldName.ToString() == "CUSTID")
                        CUSTID = data.FieldValue;
                    if (data.FieldName.ToString() == "CUSTNAME")
                        CUSTNAME = data.FieldValue.Trim();
                    if (data.FieldName.ToString() == "FORECLOSURE_AMT")
                        FORECLOSURE_AMT = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "OTH_LOANNO1")
                        OTH_LOANNO1 = data.FieldValue;
                    if (data.FieldName.ToString() == "DPD")
                        DPD = data.FieldValue;
                    if (data.FieldName.ToString() == "OTH_DPD1")
                        OTH_DPD1 = data.FieldValue;
                    if (data.FieldName.ToString() == "OTH_LOANNO2")
                        OTH_LOANNO2 = data.FieldValue;
                    if (data.FieldName.ToString() == "OTH_DPD2")
                        OTH_DPD2 = data.FieldValue;
                    if (data.FieldName.ToString() == "PRINCIPLE_OVERDUE")
                        OTH_PRINCIPLE1 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "OTH_PRINCIPLE1")
                        OTH_PRINCIPLE2 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "OTH_PRINCIPLE2")
                        OTH_PRINCIPLE3 = MoneyFormat(data.FieldValue, 2);

                    if (data.FieldName.ToString() == "C_CONTACT2_P")
                        C_CONTACT2_P = data.FieldValue;
                    if (data.FieldName.ToString() == "C_MOBILE_P")
                        C_MOBILE_P = data.FieldValue;
                    if (data.FieldName.ToString() == "C_CONTACT1_E")
                        C_CONTACT1_E = data.FieldValue;
                    if (data.FieldName.ToString() == "MOBILE_O")
                        MOBILE_O = data.FieldValue;

                    #endregion
                    lblaccno.Text = CUSTID;
                    #region Contact
                    if (data.FieldName.ToString() == "DOB")
                        DOB = data.FieldValue;
                    if (data.FieldName.ToString() == "PRODUCT_CODE")
                        PRODUCT = data.FieldValue;

                    if (data.FieldName.ToString() == "AMT_OVERDUE")
                        AMT_OVERDUE = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "SEX")
                        SEX = data.FieldValue;
                    if (data.FieldName.ToString() == "ZIPCODE")
                        ZIPCODE = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT1_P")
                        CONTACT1_P += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT2_P")
                        CONTACT1_P += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT3_P")
                        CONTACT1_P += data.FieldValue.Trim() + " ";
                    if (data.FieldName.ToString() == "CONTACT1_E")
                        CONTACT1_E += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT2_E")
                        CONTACT1_E += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT3_E")
                        CONTACT1_E += data.FieldValue.Trim() + " ";
                    if (data.FieldName.ToString() == "CONTACT1_O")
                        CONTACT1_O += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT2_O")
                        CONTACT1_O += data.FieldValue.Trim() + " / ";
                    if (data.FieldName.ToString() == "CONTACT3_O")
                        CONTACT1_O += data.FieldValue.Trim() + " ";

                    #endregion

                    #region Additonal

                    if (data.FieldName.ToString() == "OPENED_DATE")
                        OPENED_DATE = data.FieldValue;
                    if (data.FieldName.ToString() == "LAST_PAYMENT_AMT")
                        LAST_PAYMENT_AMT = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "LAST_PAYMENT_DATE")
                        LAST_PAYMENT_DATE = data.FieldValue;
                    if (data.FieldName.ToString() == "COLL_CYCLE")
                        COLL_CYCLE = data.FieldValue;
                    if (data.FieldName.ToString() == "INHOUSE_SCORE3")
                        INHOUSE_SCORE3 = MoneyFormat(data.FieldValue, 2);


                    if (data.FieldName.ToString() == "PRINCIPLE_OUTSTD")
                        PRINCIPLE_OUTSTD = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "PRINCIPLE_OVERDUE")
                        PRINCIPLE_OVERDUE = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "INTEREST_OVERDUE")
                        INTEREST_OVERDUE = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "TOTCHARGES_OVERDUE")
                        TOTCHARGES_OVERDUE = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET1")
                        BUCKET1 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET2")
                        BUCKET2 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET3")
                        BUCKET3 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET4")
                        BUCKET4 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET5")
                        BUCKET5 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET6")
                        BUCKET6 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "BUCKET7")
                        BUCKET7 = MoneyFormat(data.FieldValue, 2);

                    if (data.FieldName.ToString() == "Call1_Phone")
                        Call1_Phone = data.FieldValue;
                    if (data.FieldName.ToString() == "Call2_Phone")
                        Call2_Phone = data.FieldValue;
                    if (data.FieldName.ToString() == "Call3_Phone")
                        Call3_Phone = data.FieldValue;
                    if (data.FieldName.ToString() == "Call4_Phone")
                        Call4_Phone = data.FieldValue;
                    if (data.FieldName.ToString() == "Call5_Phone")
                        Call5_Phone = data.FieldValue;
                    if (data.FieldName.ToString() == "Call6_Phone")
                        Call6_Phone = data.FieldValue;

                    if (data.FieldName.ToString() == "Call1_dt")
                        Call1_dt = data.FieldValue;
                    if (data.FieldName.ToString() == "Call2_dt")
                        Call2_dt = data.FieldValue;
                    if (data.FieldName.ToString() == "Call3_dt")
                        Call3_dt = data.FieldValue;
                    if (data.FieldName.ToString() == "Call4_dt")
                        Call4_dt = data.FieldValue;
                    if (data.FieldName.ToString() == "Call5_dt")
                        Call5_dt = data.FieldValue;
                    if (data.FieldName.ToString() == "Call6_dt")
                        Call6_dt = data.FieldValue;

                    if (data.FieldName.ToString() == "Disp1_Id")
                        Disp1_Id = data.FieldValue;
                    if (data.FieldName.ToString() == "Disp2_Id")
                        Disp2_Id = data.FieldValue;
                    if (data.FieldName.ToString() == "Disp3_Id")
                        Disp3_Id = data.FieldValue;
                    if (data.FieldName.ToString() == "Disp4_Id")
                        Disp4_Id = data.FieldValue;
                    if (data.FieldName.ToString() == "Disp5_Id")
                        Disp5_Id = data.FieldValue;
                    if (data.FieldName.ToString() == "Disp6_Id")
                        Disp6_Id = data.FieldValue;


                    if (data.FieldName.ToString() == "Agent1_c")
                        Agent1_c = data.FieldValue;
                    if (data.FieldName.ToString() == "Agent2_c")
                        Agent2_c = data.FieldValue;
                    if (data.FieldName.ToString() == "Agent3_c")
                        Agent3_c = data.FieldValue;
                    if (data.FieldName.ToString() == "Agent4_c")
                        Agent4_c = data.FieldValue;
                    if (data.FieldName.ToString() == "Agent5_c")
                        Agent5_c = data.FieldValue;
                    if (data.FieldName.ToString() == "Agent6_c")
                        Agent6_c = data.FieldValue;

                    if (data.FieldName.ToString() == "OTH_BALANCE1")
                        OTH_BALANCE1 = MoneyFormat(data.FieldValue, 2);
                    if (data.FieldName.ToString() == "OTH_BALANCE2")
                        OTH_BALANCE2 = MoneyFormat(data.FieldValue, 2);

                    if (data.FieldName.ToString() == "CONTACT_DATE1")
                        CONTACT_DATE1 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE2")
                        CONTACT_DATE2 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE3")
                        CONTACT_DATE3 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE4")
                        CONTACT_DATE4 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE5")
                        CONTACT_DATE5 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE6")
                        CONTACT_DATE6 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE7")
                        CONTACT_DATE7 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_DATE8")
                        CONTACT_DATE8 = data.FieldValue;

                    if (data.FieldName.ToString() == "CONTACT_PLACE1")
                        CONTACT_PLACE1 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE2")
                        CONTACT_PLACE2 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE3")
                        CONTACT_PLACE3 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE4")
                        CONTACT_PLACE4 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE5")
                        CONTACT_PLACE5 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE6")
                        CONTACT_PLACE6 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE7")
                        CONTACT_PLACE7 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT_PLACE8")
                        CONTACT_PLACE8 = data.FieldValue;

                    if (data.FieldName.ToString() == "PERSON_CONTACTED1")
                        PERSON_CONTACTED1 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED2")
                        PERSON_CONTACTED2 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED3")
                        PERSON_CONTACTED3 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED4")
                        PERSON_CONTACTED4 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED5")
                        PERSON_CONTACTED5 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED6")
                        PERSON_CONTACTED6 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED7")
                        PERSON_CONTACTED7 = data.FieldValue;
                    if (data.FieldName.ToString() == "PERSON_CONTACTED8")
                        PERSON_CONTACTED8 = data.FieldValue;

                    if (data.FieldName.ToString() == "ACTION_CODE1")
                        ACTION_CODE1 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE2")
                        ACTION_CODE2 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE3")
                        ACTION_CODE3 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE4")
                        ACTION_CODE4 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE5")
                        ACTION_CODE5 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE6")
                        ACTION_CODE6 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE7")
                        ACTION_CODE7 = data.FieldValue;
                    if (data.FieldName.ToString() == "ACTION_CODE8")
                        ACTION_CODE8 = data.FieldValue;

                    if (data.FieldName.ToString() == "CONTACTED_BY1")
                        CONTACTED_BY1 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY2")
                        CONTACTED_BY2 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY3")
                        CONTACTED_BY3 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY4")
                        CONTACTED_BY4 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY5")
                        CONTACTED_BY5 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY6")
                        CONTACTED_BY6 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY7")
                        CONTACTED_BY7 = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACTED_BY8")
                        CONTACTED_BY8 = data.FieldValue;

                    if (data.FieldName.ToString() == "REMARKS1")
                        REMARKS1 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS2")
                        REMARKS2 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS3")
                        REMARKS3 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS4")
                        REMARKS4 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS5")
                        REMARKS5 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS6")
                        REMARKS6 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS7")
                        REMARKS7 = data.FieldValue;
                    if (data.FieldName.ToString() == "REMARKS8")
                        REMARKS8 = data.FieldValue;

                    #endregion

                    #region Address
                    if (data.FieldName.ToString() == "ALAMAT_P")
                        ALAMAT_P = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT1_P")
                        ADD_CONTACT1_P = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT2_P")
                        CONTACT2_P = data.FieldValue;
                    if (data.FieldName.ToString() == "MOBILE_P")
                        MOBILE_P = data.FieldValue;
                    if (data.FieldName.ToString() == "CITY_P")
                        CITY_P = data.FieldValue;


                    if (data.FieldName.ToString() == "ALAMAT_E")
                        ALAMAT_E = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT1_E")
                        ADD_CONTACT1_E = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT2_E")
                        CONTACT2_E = data.FieldValue;
                    if (data.FieldName.ToString() == "MOBILE_E")
                        MOBILE_E = data.FieldValue;
                    if (data.FieldName.ToString() == "CITY_E")
                        CITY_E = data.FieldValue;

                    if (data.FieldName.ToString() == "ALAMAT_O")
                        ALAMAT_O = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT1_O")
                        ADD_CONTACT1_O = data.FieldValue;
                    if (data.FieldName.ToString() == "CONTACT2_O")
                        CONTACT2_O = data.FieldValue;
                    if (data.FieldName.ToString() == "MOBILE_O")
                        ADD_MOBILE_O = data.FieldValue;
                    if (data.FieldName.ToString() == "CITY_O")
                        CITY_O = data.FieldValue;
                    #endregion

                }
                const int FREQ_GSHARP = 415;
                const int DURATION_EIGHTH = 200;
                #region Home
                lblServiceName.Text = ServiceName;
                lblServiceName2.Text = ServiceName;
                lblLoan1.Text = LOANNO;
                lblLoan2.Text = OTH_LOANNO1;
                lblLoan3.Text = OTH_LOANNO2;

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

                txtmsg.Text = "Selamat pagi " + strPrefix + ". Hingga saat ini kami belum menerima pembayaran pinjaman anda dengan nomor loan " + LOANNO.Trim() + ". Mohon segera lakukan pembayaran. Terima kasih";
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
                lblPrincipal_additional1.Text = OTH_PRINCIPLE1;
                lblPrincipal_additional2.Text = OTH_PRINCIPLE2;


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
                lblACTION_CODE8.Text = ACTION_CODE8;

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

        public void mpUnloadTimer_Fire(Object state)
		{
			if (this.InvokeRequired)
			{
                this.Invoke(new System.Threading.TimerCallback(mpUnloadTimer_Fire), new Object[] { state });
                return;
            }

   //         mpUnloadTimer.Dispose();
			//mpUnloadTimer = null;
			//this.Close();
		}

        public void mpAnswerCallTimer_Fire(Object state)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new System.Threading.TimerCallback(mpAnswerCallTimer_Fire), new Object[] { state });
                return;
            }

            miAnswerCallTickCount--;

            if (miAnswerCallTickCount < 0)
                ResetAnswerCallPanel();
            else
                lblAnswerCallCountDown.Text = miAnswerCallTickCount.ToString("000");
        }

        private void ResetAnswerCallPanel()
        {
            if (mpAnswerCallTimer != null)
                mpAnswerCallTimer.Dispose();
            mpAnswerCallTimer = null;

            btnAcceptCall.Enabled = false;
            btnRejectCall.Enabled = false;

            //Unload rejections reasons dialog, if loaded
            if (CallRejectionForm != null)
                CallRejectionForm.Close();
            CallRejectionForm = null;
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

        private void FCallData_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
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
	}
}
