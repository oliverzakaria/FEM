using System;
using System.Runtime.Serialization;

namespace Cafe.Mortgage.Api.ServiceModel
{
    [DataContract]
	public class Metadata2
	{
		[DataMember]
		public int Record_Num { get; set; }
        [DataMember]
        public string LOANNO { get; set; }
        [DataMember]
        public string CUSTID { get; set; }
        [DataMember]
        public string CUSTNAME { get; set; }
        [DataMember]
        public string ALAMAT_P { get; set; }
        [DataMember]
        public string CONTACT1_P { get; set; }
        [DataMember]
        public string CONTACT2_P { get; set; }
        [DataMember]
        public string MOBILE_P { get; set; }
        [DataMember]
        public string CITY_P { get; set; }
        [DataMember]
        public string ALAMAT_E { get; set; }
        [DataMember]
        public string CONTACT1_E { get; set; }
        [DataMember]
        public string CONTACT2_E { get; set; }
        [DataMember]
        public string MOBILE_E { get; set; }
        [DataMember]
        public string CITY_E { get; set; }
        [DataMember]
        public string ALAMAT_O { get; set; }
        [DataMember]
        public string CONTACT1_O { get; set; }
        [DataMember]
        public string CONTACT2_O { get; set; }
        [DataMember]
        public string MOBILE_O { get; set; }
        [DataMember]
        public string CITY_O { get; set; }
        [DataMember]
        public string DOB { get; set; }
        [DataMember]
        public string SEX { get; set; }
        [DataMember]
        public string PROFFESION { get; set; }
        [DataMember]
        public string CURRENT_ORG { get; set; }
        [DataMember]
        public string DESIG { get; set; }
        [DataMember]
        public string ZIPCODE { get; set; }
        [DataMember]
        public string OPENED_DATE { get; set; }
        [DataMember]
        public decimal LAST_PAYMENT_AMT { get; set; }
        [DataMember]
        public string LAST_PAYMENT_DATE { get; set; }
        [DataMember]
        public int DPD { get; set; }
        [DataMember]
        public int COLL_CYCLE { get; set; }
        [DataMember]
        public decimal AMT_OVERDUE { get; set; }
        [DataMember]
        public decimal PRINCIPLE_OVERDUE { get; set; }
        [DataMember]
        public decimal INTEREST_OVERDUE { get; set; }
        [DataMember]
        public decimal TOTCHARGES_OVERDUE { get; set; }
        [DataMember]
        public decimal BUCKET1 { get; set; }
        [DataMember]
        public decimal BUCKET2 { get; set; }
        [DataMember]
        public decimal PRINCIPLE_OUTSTD { get; set; }
        [DataMember]
        public string SAVE_ACCOUNT { get; set; }
        [DataMember]
        public decimal FORECLOSURE_AMT { get; set; }
        [DataMember]
        public string CONTACT_DATE1 { get; set; }
        [DataMember]
        public string CONTACT_TIME1 { get; set; }
        [DataMember]
        public string CONTACT_MODE1 { get; set; }
        [DataMember]
        public string CONTACT_PLACE1 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED1 { get; set; }
        [DataMember]
        public string ACTION_CODE1 { get; set; }
        [DataMember]
        public string CONTACTED_BY1 { get; set; }
        [DataMember]
        public string REMARKS1 { get; set; }
        [DataMember]
        public string CONTACT_DATE2 { get; set; }
        [DataMember]
        public string CONTACT_TIME2 { get; set; }
        [DataMember]
        public string CONTACT_MODE2 { get; set; }
        [DataMember]
        public string CONTACT_PLACE2 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED2 { get; set; }
        [DataMember]
        public string ACTION_CODE2 { get; set; }
        [DataMember]
        public string CONTACTED_BY2 { get; set; }
        [DataMember]
        public string REMARKS2 { get; set; }
        [DataMember]
        public string CONTACT_DATE3 { get; set; }
        [DataMember]
        public string CONTACT_TIME3 { get; set; }
        [DataMember]
        public string CONTACT_MODE3 { get; set; }
        [DataMember]
        public string CONTACT_PLACE3 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED3 { get; set; }
        [DataMember]
        public string ACTION_CODE3 { get; set; }
        [DataMember]
        public string CONTACTED_BY3 { get; set; }
        [DataMember]
        public string REMARKS3 { get; set; }
        [DataMember]
        public string CONTACT_DATE4 { get; set; }
        [DataMember]
        public string CONTACT_TIME4 { get; set; }
        [DataMember]
        public string CONTACT_MODE4 { get; set; }
        [DataMember]
        public string CONTACT_PLACE4 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED4 { get; set; }
        [DataMember]
        public string ACTION_CODE4 { get; set; }
        [DataMember]
        public string CONTACTED_BY4 { get; set; }
        [DataMember]
        public string REMARKS4 { get; set; }
        [DataMember]
        public string CONTACT_DATE5 { get; set; }
        [DataMember]
        public string CONTACT_TIME5 { get; set; }
        [DataMember]
        public string CONTACT_MODE5 { get; set; }
        [DataMember]
        public string CONTACT_PLACE5 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED5 { get; set; }
        [DataMember]
        public string ACTION_CODE5 { get; set; }
        [DataMember]
        public string CONTACTED_BY5 { get; set; }
        [DataMember]
        public string REMARKS5 { get; set; }
        [DataMember]
        public string CONTACT_DATE6 { get; set; }
        [DataMember]
        public string CONTACT_TIME6 { get; set; }
        [DataMember]
        public string CONTACT_MODE6 { get; set; }
        [DataMember]
        public string CONTACT_PLACE6 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED6 { get; set; }
        [DataMember]
        public string ACTION_CODE6 { get; set; }
        [DataMember]
        public string CONTACTED_BY6 { get; set; }
        [DataMember]
        public string REMARKS6 { get; set; }
        [DataMember]
        public string CONTACT_DATE7 { get; set; }
        [DataMember]
        public string CONTACT_TIME7 { get; set; }
        [DataMember]
        public string CONTACT_MODE7 { get; set; }
        [DataMember]
        public string CONTACT_PLACE7 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED7 { get; set; }
        [DataMember]
        public string ACTION_CODE7 { get; set; }
        [DataMember]
        public string CONTACTED_BY7 { get; set; }
        [DataMember]
        public string REMARKS7 { get; set; }
        [DataMember]
        public string CONTACT_DATE8 { get; set; }
        [DataMember]
        public string CONTACT_TIME8 { get; set; }
        [DataMember]
        public string CONTACT_MODE8 { get; set; }
        [DataMember]
        public string CONTACT_PLACE8 { get; set; }
        [DataMember]
        public string PERSON_CONTACTED8 { get; set; }
        [DataMember]
        public string ACTION_CODE8 { get; set; }
        [DataMember]
        public string CONTACTED_BY8 { get; set; }
        [DataMember]
        public string REMARKS8 { get; set; }
        [DataMember]
        public string OTH_LOANNO1 { get; set; }
        [DataMember]
        public int OTH_DPD1 { get; set; }
        [DataMember]
        public decimal OTH_BALANCE1 { get; set; }
        [DataMember]
        public decimal OTH_PRINCIPLE1 { get; set; }
        [DataMember]
        public string OTH_LOANNO2 { get; set; }
        [DataMember]
        public int OTH_DPD2 { get; set; }
        [DataMember]
        public decimal OTH_BALANCE2 { get; set; }
        [DataMember]
        public decimal OTH_PRINCIPLE2 { get; set; }
        [DataMember]
        public string QUEUE { get; set; }
        [DataMember]
        public string PRODUCT_CODE { get; set; }
        [DataMember]
        public string SPECIAL_STAGE { get; set; }
        [DataMember]
        public string CHARGE_OFF_FLAG { get; set; }
        [DataMember]
        public string PURPOSE { get; set; }
        [DataMember]
        public string NEW_PHONE1 { get; set; }
        [DataMember]
        public string NEW_PHONE2 { get; set; }
        [DataMember]
        public string NEW_MOBILE { get; set; }
        [DataMember]
        public string NEW_ADDRESS_L1 { get; set; }
        [DataMember]
        public string NEW_ADDRESS_L2 { get; set; }
        [DataMember]
        public string NEW_ADDRESS_L3 { get; set; }
        [DataMember]
        public string NEW_CITY { get; set; }
        [DataMember]
        public string PTPDATE { get; set; }
        [DataMember]
        public decimal PTPAMOUNT { get; set; }
        [DataMember]
        public string INPUT_REMARKS1 { get; set; }
        [DataMember]
        public string INPUT_REMARKS2 { get; set; }
        [DataMember]
        public string INPUT_REMARKS3 { get; set; }
        [DataMember]
        public string INPUT_REMARKS4 { get; set; }
        [DataMember]
        public string INPUT_REMARKS5 { get; set; }
        [DataMember]
        public string INPUT_REMARKS6 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE1 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE2 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE3 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE4 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE5 { get; set; }
        [DataMember]
        public string INPUT_CONTACT_PLACE6 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT1 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT2 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT3 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT4 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT5 { get; set; }
        [DataMember]
        public string IN_PERSON_CONTACT6 { get; set; }
        [DataMember]
        public string C_CONTACT1_P { get; set; }
        [DataMember]
        public string C_CONTACT2_P { get; set; }
        [DataMember]
        public string C_MOBILE_P { get; set; }
        [DataMember]
        public string C_CONTACT1_E { get; set; }
        [DataMember]
        public string C_CONTACT2_E { get; set; }
        [DataMember]
        public string C_MOBILE_E { get; set; }
        [DataMember]
        public decimal INHOUSE_SCORE3 { get; set; }
        [DataMember]
        public decimal BUCKET3 { get; set; }
        [DataMember]
        public decimal BUCKET4 { get; set; }
        [DataMember]
        public decimal BUCKET5 { get; set; }
        [DataMember]
        public decimal BUCKET6 { get; set; }
        [DataMember]
        public decimal BUCKET7 { get; set; }
        [DataMember]
        public string PTPDATE2 { get; set; }
        [DataMember]
        public decimal PTPAMOUNT2 { get; set; }
        [DataMember]
        public string ACTION2 { get; set; }
        [DataMember]
        public string PTPDATE3 { get; set; }
        [DataMember]
        public decimal PTPAMOUNT3 { get; set; }
        [DataMember]
        public string ACTION3 { get; set; }
        [DataMember]
        public string TZ { get; set; }
        [DataMember]
        public string Area_c { get; set; }
        [DataMember]
        public int TimeZone_Id { get; set; }
        [DataMember]
        public int Dial_Count { get; set; }
        [DataMember]
        public string Call1_Phone { get; set; }
        [DataMember]
        public DateTime Call1_dt { get; set; }
        [DataMember]
        public int Disp1_Id { get; set; }
        [DataMember]
        public string Agent1_c { get; set; }
        [DataMember]
        public string Call2_Phone { get; set; }
        [DataMember]
        public DateTime Call2_dt { get; set; }
        [DataMember]
        public int Disp2_Id { get; set; }
        [DataMember]
        public string Agent2_c { get; set; }
        [DataMember]
        public string Call3_Phone { get; set; }
        [DataMember]
        public DateTime Call3_dt { get; set; }
        [DataMember]
        public int Disp3_Id { get; set; }
        [DataMember]
        public string Agent3_c { get; set; }
        [DataMember]
        public DateTime Callback_dt { get; set; }
        [DataMember]
        public string Callback_Phone { get; set; }
        [DataMember]
        public string DoNotCall { get; set; }
        [DataMember]
        public int DynaOrder { get; set; }
        [DataMember]
        public int Phone1TimeZoneId { get; set; }
        [DataMember]
        public int Phone2TimeZoneId { get; set; }
        [DataMember]
        public int Phone3TimeZoneId { get; set; }
        [DataMember]
        public string Call4_Phone { get; set; }
        [DataMember]
        public int Phone4TimeZoneId { get; set; }
        [DataMember]
        public DateTime Call4_dt { get; set; }
        [DataMember]
        public int Disp4_Id { get; set; }
        [DataMember]
        public string Agent4_c { get; set; }
        [DataMember]
        public string Call5_Phone { get; set; }
        [DataMember]
        public int Phone5TimeZoneId { get; set; }
        [DataMember]
        public DateTime Call5_dt { get; set; }
        [DataMember]
        public int Disp5_Id { get; set; }
        [DataMember]
        public string Agent5_c { get; set; }
        [DataMember]
        public string Call6_Phone { get; set; }
        [DataMember]
        public int Phone6TimeZoneId { get; set; }
        [DataMember]
        public DateTime Call6_dt { get; set; }
        [DataMember]
        public int Disp6_Id { get; set; }
        [DataMember]
        public string Agent6_c { get; set; }
	}
}