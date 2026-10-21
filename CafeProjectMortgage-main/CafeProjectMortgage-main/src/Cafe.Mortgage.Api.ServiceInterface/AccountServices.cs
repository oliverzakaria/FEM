//using Cafe.Mortgage.Api.ServiceInterface.Data;
//using Cafe.Mortgage.Api.ServiceInterface.Data.Entities;
//using Cafe.Mortgage.Api.ServiceModel;
//using Dapper;
//using System;
//using System.Configuration;
//using System.Data.SqlClient;

//namespace Cafe.Mortgage.Api.ServiceInterface
//{
//    public class AccountServices : ServiceStack.Service
//    {
//        public GetAccountResponse Post(GetAccount request)
//        {
//            var cfgSetting = ConfigurationManager.ConnectionStrings["Cfg"];
//            var appSetting = ConfigurationManager.ConnectionStrings["App"];

//            using (var connection = new SqlConnection(cfgSetting.ConnectionString))
//            {
//                GetAccountResponse response = new GetAccountResponse();

//                string query = "SELECT b.Table_Id, b.Table_desc FROM AODService_Tables AS a JOIN Table_Stat AS b ON a.Table_Id = b.Table_Id WHERE a.Service_Id = @ServiceId";
//                var stats = connection.Query<Table_Stat>(query, new { ServiceId = request.ServiceId });

//                var helper = new SqlHelper(appSetting.ConnectionString);

//                foreach (var stat in stats)
//                {
//                    query = $"SELECT * FROM {stat.Table_desc} WHERE LOANNO = @AccountNo";

//                    var table = helper.ExecuteQuery(query, new SqlParameter("AccountNo", request.AccountNo));
//                    if (table.Rows.Count == 1)
//                    {
//                        response.TableName = stat.Table_desc;
//                        foreach (System.Data.DataColumn column in table.Columns)
//                        {
//                            response.Metadata.Add(new Metadata
//                            {
//                                FieldName = column.ColumnName,
//                                FieldValue = table.Rows[0][column].ToString(),
//                                FieldType = column.DataType.ToString()
//                            });
//                        }

//                        break;
//                    }
//                }

//                return response;
//            }
//        }

//        //public UpdateAccountResponse Put(UpdateAccount request)
//        //{
//        //    var response = new UpdateAccountResponse
//        //    {
//        //        Success = true,
//        //        ErrorMessage = string.Empty,
//        //        TableName = request.TableName,
//        //        Metadata = new Metadata2()
//        //    };

//        //    if (request == null || string.IsNullOrEmpty(request.TableName) || request.Data == null)
//        //    {
//        //        response.Success = false;
//        //        response.ErrorMessage = "INVALID REQUEST";
//        //        return response;
//        //    }

//        //    var appSetting = ConfigurationManager.ConnectionStrings["App"];

//        //    try
//        //    {
//        //        using (var connection = new SqlConnection(appSetting.ConnectionString))
//        //        {
//        //            string query = $"UPDATE {request.TableName} " +
//        //                "SET CARDNO = @CARDNO, " +
//        //                //"ACCNO = @ACCNO, " +
//        //                "CUSTID = @CUSTID, " +
//        //                "CUSTNAME = @CUSTNAME, " +
//        //                "ALAMAT_P = @ALAMAT_P, " +
//        //                "CONTACT1_P = @CONTACT1_P, " +
//        //                "CONTACT2_P = @CONTACT2_P, " +
//        //                "MOBILE_P = @MOBILE_P, " +
//        //                "CITY_P = @CITY_P, " +
//        //                "ALAMAT_E = @ALAMAT_E, " +
//        //                "CONTACT1_E = @CONTACT1_E, " +
//        //                "CONTACT2_E = @CONTACT2_E, " +
//        //                "MOBILE_E = @MOBILE_E, " +
//        //                "CITY_E = @CITY_E, " +
//        //                "ALAMAT_O = @ALAMAT_O, " +
//        //                "CONTACT1_O = @CONTACT1_O, " +
//        //                "CONTACT2_O = @CONTACT2_O, " +
//        //                "MOBILE_O = @MOBILE_O, " +
//        //                "CITY_O = @CITY_O, " +
//        //                "DOB = @DOB, " +
//        //                "SEX = @SEX, " +
//        //                "SCORE_X = @SCORE_X, " +
//        //                "CURRENT_ORG = @CURRENT_ORG, " +
//        //                "SCORE_30DPD = @SCORE_30DPD, " +
//        //                "ZIPCODE = @ZIPCODE, " +
//        //                "OPENED_DATE = @OPENED_DATE, " +
//        //                "LAST_PAYMENT_AMT = @LAST_PAYMENT_AMT, " +
//        //                "LAST_PAYMENT_DATE = @LAST_PAYMENT_DATE, " +
//        //                "ACC_BLOCK_CODE1 = @ACC_BLOCK_CODE1, " +
//        //                "PAYMENT_DUE_DATE = @PAYMENT_DUE_DATE, " +
//        //                "COLL_CYCLE = @COLL_CYCLE, " +
//        //                "DEL_STRING = @DEL_STRING, " +
//        //                "CURR_ACC_BAL = @CURR_ACC_BAL, " +
//        //                "CREDIT_LIMIT = @CREDIT_LIMIT, " +
//        //                "OVER_LIMIT = @OVER_LIMIT, " +
//        //                "TOT_AMT_DUE = @TOT_AMT_DUE, " +
//        //                "AMT_OVERDUE = @AMT_OVERDUE, " +
//        //                "TOT_CURR_DUE = @TOT_CURR_DUE, " +
//        //                "BUCKET1 = @BUCKET1, " +
//        //                "BUCKET2 = @BUCKET2, " +
//        //                "CUST_MEMO_LINE = @CUST_MEMO_LINE, " +
//        //                "MARKING_CODE = @MARKING_CODE, " +
//        //                "REASON_CODE = @REASON_CODE, " +
//        //                "REASON_DESC = @REASON_DESC, " +
//        //                "REMARKS = @REMARKS, " +
//        //                "CONTACT_DATE1 = @CONTACT_DATE1, " +
//        //                "CONTACT_TIME1 = @CONTACT_TIME1, " +
//        //                "CONTACT_MODE1 = @CONTACT_MODE1, " +
//        //                "CONTACT_PLACE1 = @CONTACT_PLACE1, " +
//        //                "PERSON_CONTACTED1 = @PERSON_CONTACTED1, " +
//        //                "ACTION_CODE1 = @ACTION_CODE1, " +
//        //                "CONTACTED_BY1 = @CONTACTED_BY1, " +
//        //                "REMARKS1 = @REMARKS1, " +
//        //                "CONTACT_DATE2 = @CONTACT_DATE2, " +
//        //                "CONTACT_TIME2 = @CONTACT_TIME2, " +
//        //                "CONTACT_MODE2 = @CONTACT_MODE2, " +
//        //                "CONTACT_PLACE2 = @CONTACT_PLACE2, " +
//        //                "PERSON_CONTACTED2 = @PERSON_CONTACTED2, " +
//        //                "ACTION_CODE2 = @ACTION_CODE2, " +
//        //                "CONTACTED_BY2 = @CONTACTED_BY2, " +
//        //                "REMARKS2 = @REMARKS2, " +
//        //                "CONTACT_DATE3 = @CONTACT_DATE3, " +
//        //                "CONTACT_TIME3 = @CONTACT_TIME3, " +
//        //                "CONTACT_MODE3 = @CONTACT_MODE3, " +
//        //                "CONTACT_PLACE3 = @CONTACT_PLACE3, " +
//        //                "PERSON_CONTACTED3 = @PERSON_CONTACTED3, " +
//        //                "ACTION_CODE3 = @ACTION_CODE3, " +
//        //                "CONTACTED_BY3 = @CONTACTED_BY3, " +
//        //                "REMARKS3 = @REMARKS3, " +
//        //                "CONTACT_DATE4 = @CONTACT_DATE4, " +
//        //                "CONTACT_TIME4 = @CONTACT_TIME4, " +
//        //                "CONTACT_MODE4 = @CONTACT_MODE4, " +
//        //                "CONTACT_PLACE4 = @CONTACT_PLACE4, " +
//        //                "PERSON_CONTACTED4 = @PERSON_CONTACTED4, " +
//        //                "ACTION_CODE4 = @ACTION_CODE4, " +
//        //                "CONTACTED_BY4 = @CONTACTED_BY4, " +
//        //                "REMARKS4 = @REMARKS4, " +
//        //                "CONTACT_DATE5 = @CONTACT_DATE5, " +
//        //                "CONTACT_TIME5 = @CONTACT_TIME5, " +
//        //                "CONTACT_MODE5 = @CONTACT_MODE5, " +
//        //                "CONTACT_PLACE5 = @CONTACT_PLACE5, " +
//        //                "PERSON_CONTACTED5 = @PERSON_CONTACTED5, " +
//        //                "ACTION_CODE5 = @ACTION_CODE5, " +
//        //                "CONTACTED_BY5 = @CONTACTED_BY5, " +
//        //                "REMARKS5 = @REMARKS5, " +
//        //                "CONTACT_DATE6 = @CONTACT_DATE6, " +
//        //                "CONTACT_TIME6 = @CONTACT_TIME6, " +
//        //                "CONTACT_MODE6 = @CONTACT_MODE6, " +
//        //                "CONTACT_PLACE6 = @CONTACT_PLACE6, " +
//        //                "PERSON_CONTACTED6 = @PERSON_CONTACTED6, " +
//        //                "ACTION_CODE6 = @ACTION_CODE6, " +
//        //                "CONTACTED_BY6 = @CONTACTED_BY6, " +
//        //                "REMARKS6 = @REMARKS6, " +
//        //                "USER_CODE3 = @USER_CODE3, " +
//        //                "OTH_CARDNO1 = @OTH_CARDNO1, " +
//        //                "OTH_CYCLE_DUE1 = @OTH_CYCLE_DUE1, " +
//        //                "OTH_CURR_ACC_BAL1 = @OTH_CURR_ACC_BAL1, " +
//        //                "OTH_COLL_CYCLE1 = @OTH_COLL_CYCLE1, " +
//        //                "OTH_CARDNO2 = @OTH_CARDNO2, " +
//        //                "OTH_CYCLE_DUE2 = @OTH_CYCLE_DUE2, " +
//        //                "OTH_CURR_ACC_BAL2 = @OTH_CURR_ACC_BAL2, " +
//        //                "OTH_COLL_CYCLE2 = @OTH_COLL_CYCLE2, " +
//        //                "INHOUSE_SCORE = @INHOUSE_SCORE, " +
//        //                "QUEUE = @QUEUE, " +
//        //                "PRODUCT_CODE = @PRODUCT_CODE, " +
//        //                "SPECIAL_STAGE = @SPECIAL_STAGE, " +
//        //                "CYCLE_DUE = @CYCLE_DUE, " +
//        //                "CHARGE_OFF_FLAG = @CHARGE_OFF_FLAG, " +
//        //                "PURPOSE = @PURPOSE, " +
//        //                "RECOVERY = @RECOVERY, " +
//        //                "REGION = @REGION, " +
//        //                "INPUT_MARKING_CODE = @INPUT_MARKING_CODE, " +
//        //                "INPUT_REASON_CODE = @INPUT_REASON_CODE, " +
//        //                "INPUT_REASON_DESC = @INPUT_REASON_DESC, " +
//        //                "INPUT_REMARKS = @INPUT_REMARKS, " +
//        //                "NEW_PHONE1 = @NEW_PHONE1, " +
//        //                "NEW_PHONE2 = @NEW_PHONE2, " +
//        //                "NEW_MOBILE = @NEW_MOBILE, " +
//        //                "NEWADDRESS_L1 = @NEWADDRESS_L1, " +
//        //                "NEWADDRESS_L2 = @NEWADDRESS_L2, " +
//        //                "NEWADDRESS_L3 = @NEWADDRESS_L3, " +
//        //                "NEW_CITY = @NEW_CITY, " +
//        //                "PTPDATE = @PTPDATE, " +
//        //                "PTPAMOUNT = @PTPAMOUNT, " +
//        //                "INPUT_REMARKS1 = @INPUT_REMARKS1, " +
//        //                "INPUT_REMARKS2 = @INPUT_REMARKS2, " +
//        //                "INPUT_REMARKS3 = @INPUT_REMARKS3, " +
//        //                "INPUT_REMARKS4 = @INPUT_REMARKS4, " +
//        //                "INPUT_REMARKS5 = @INPUT_REMARKS5, " +
//        //                "INPUT_REMARKS6 = @INPUT_REMARKS6, " +
//        //                "INPUT_CONTACT_PLACE1 = @INPUT_CONTACT_PLACE1, " +
//        //                "INPUT_CONTACT_PLACE2 = @INPUT_CONTACT_PLACE2, " +
//        //                "INPUT_CONTACT_PLACE3 = @INPUT_CONTACT_PLACE3, " +
//        //                "INPUT_CONTACT_PLACE4 = @INPUT_CONTACT_PLACE4, " +
//        //                "INPUT_CONTACT_PLACE5 = @INPUT_CONTACT_PLACE5, " +
//        //                "INPUT_CONTACT_PLACE6 = @INPUT_CONTACT_PLACE6, " +
//        //                "IN_PERSON_CONTACT1 = @IN_PERSON_CONTACT1, " +
//        //                "IN_PERSON_CONTACT2 = @IN_PERSON_CONTACT2, " +
//        //                "IN_PERSON_CONTACT3 = @IN_PERSON_CONTACT3, " +
//        //                "IN_PERSON_CONTACT4 = @IN_PERSON_CONTACT4, " +
//        //                "IN_PERSON_CONTACT5 = @IN_PERSON_CONTACT5, " +
//        //                "IN_PERSON_CONTACT6 = @IN_PERSON_CONTACT6, " +
//        //                "C_CONTACT1_P = @C_CONTACT1_P, " +
//        //                "C_CONTACT2_P = @C_CONTACT2_P, " +
//        //                "C_MOBILE_P = @C_MOBILE_P, " +
//        //                "C_CONTACT1_E = @C_CONTACT1_E, " +
//        //                "C_CONTACT2_E = @C_CONTACT2_E, " +
//        //                "C_MOBILE_E = @C_MOBILE_E, " +
//        //                "CM_SPLCAT = @CM_SPLCAT, " +
//        //                "CM_DELRES = @CM_DELRES, " +
//        //                "DPD60 = @DPD60, " +
//        //                "DPD90 = @DPD90, " +
//        //                "DPD120 = @DPD120, " +
//        //                "DPD150 = @DPD150, " +
//        //                "PTPDATE2 = @PTPDATE2, " +
//        //                "PTPAMOUNT2 = @PTPAMOUNT2, " +
//        //                "ACTION2 = @ACTION2, " +
//        //                "PTPDATE3 = @PTPDATE3, " +
//        //                "PTPAMOUNT3 = @PTPAMOUNT3, " +
//        //                "ACTION3 = @ACTION3, " +
//        //                "TZ = @TZ, " +
//        //                "Area_c = @Area_c, " +
//        //                "TimeZone_Id = @TimeZone_Id, " +
//        //                "Dial_Count = @Dial_Count, " +
//        //                "Call1_Phone = @Call1_Phone, " +
//        //                "Call1_dt = @Call1_dt, " +
//        //                "Disp1_Id = @Disp1_Id, " +
//        //                "Agent1_c = @Agent1_c, " +
//        //                "Call2_Phone = @Call2_Phone, " +
//        //                "Call2_dt = @Call2_dt, " +
//        //                "Disp2_Id = @Disp2_Id, " +
//        //                "Agent2_c = @Agent2_c, " +
//        //                "Call3_Phone = @Call3_Phone, " +
//        //                "Call3_dt = @Call3_dt, " +
//        //                "Disp3_Id = @Disp3_Id, " +
//        //                "Agent3_c = @Agent3_c, " +
//        //                "Callback_dt = @Callback_dt, " +
//        //                "Callback_Phone = @Callback_Phone, " +
//        //                "DoNotCall = @DoNotCall, " +
//        //                "DynaOrder = @DynaOrder, " +
//        //                "Phone1TimeZoneId = @Phone1TimeZoneId, " +
//        //                "Phone2TimeZoneId = @Phone2TimeZoneId, " +
//        //                "Phone3TimeZoneId = @Phone3TimeZoneId, " +
//        //                "Call4_Phone = @Call4_Phone, " +
//        //                "Phone4TimeZoneId = @Phone4TimeZoneId, " +
//        //                "Call4_dt = @Call4_dt, " +
//        //                "Disp4_Id = @Disp4_Id, " +
//        //                "Agent4_c = @Agent4_c, " +
//        //                "Call5_Phone = @Call5_Phone, " +
//        //                "Phone5TimeZoneId = @Phone5TimeZoneId, " +
//        //                "Call5_dt = @Call5_dt, " +
//        //                "Disp5_Id = @Disp5_Id, " +
//        //                "Agent5_c = @Agent5_c, " +
//        //                "Call6_Phone = @Call6_Phone, " +
//        //                "Phone6TimeZoneId = @Phone6TimeZoneId, " +
//        //                "Call6_dt = @Call6_dt, " +
//        //                "Disp6_Id = @Disp6_Id, " +
//        //                "Agent6_c = @Agent6_c " +
//        //                "WHERE LOANNO = @AccountNo";
                    
//        //            connection.Execute(query, new
//        //            {
//        //                CARDNO = request.Data.CARDNO,
//        //                CUSTID = request.Data.CUSTID,
//        //                CUSTNAME = request.Data.CUSTNAME,
//        //                ALAMAT_P = request.Data.ALAMAT_P,
//        //                CONTACT1_P = request.Data.CONTACT1_P,
//        //                CONTACT2_P = request.Data.CONTACT2_P,
//        //                MOBILE_P = request.Data.MOBILE_P,
//        //                CITY_P = request.Data.CITY_P,
//        //                ALAMAT_E = request.Data.ALAMAT_E,
//        //                CONTACT1_E = request.Data.CONTACT1_E,
//        //                CONTACT2_E = request.Data.CONTACT2_E,
//        //                MOBILE_E = request.Data.MOBILE_E,
//        //                CITY_E = request.Data.CITY_E,
//        //                ALAMAT_O = request.Data.ALAMAT_O,
//        //                CONTACT1_O = request.Data.CONTACT1_O,
//        //                CONTACT2_O = request.Data.CONTACT2_O,
//        //                MOBILE_O = request.Data.MOBILE_O,
//        //                CITY_O = request.Data.CITY_O,
//        //                DOB = request.Data.DOB,
//        //                SEX = request.Data.SEX,
//        //                SCORE_X = request.Data.SCORE_X,
//        //                CURRENT_ORG = request.Data.CURRENT_ORG,
//        //                SCORE_30DPD = request.Data.SCORE_30DPD,
//        //                ZIPCODE = request.Data.ZIPCODE,
//        //                OPENED_DATE = request.Data.OPENED_DATE,
//        //                LAST_PAYMENT_AMT = request.Data.LAST_PAYMENT_AMT,
//        //                LAST_PAYMENT_DATE = request.Data.LAST_PAYMENT_DATE,
//        //                ACC_BLOCK_CODE1 = request.Data.ACC_BLOCK_CODE1,
//        //                PAYMENT_DUE_DATE = request.Data.PAYMENT_DUE_DATE,
//        //                COLL_CYCLE = request.Data.COLL_CYCLE,
//        //                DEL_STRING = request.Data.DEL_STRING,
//        //                CURR_ACC_BAL = request.Data.CURR_ACC_BAL,
//        //                CREDIT_LIMIT = request.Data.CREDIT_LIMIT,
//        //                OVER_LIMIT = request.Data.OVER_LIMIT,
//        //                TOT_AMT_DUE = request.Data.TOT_AMT_DUE,
//        //                AMT_OVERDUE = request.Data.AMT_OVERDUE,
//        //                TOT_CURR_DUE = request.Data.TOT_CURR_DUE,
//        //                BUCKET1 = request.Data.BUCKET1,
//        //                BUCKET2 = request.Data.BUCKET2,
//        //                CUST_MEMO_LINE = request.Data.CUST_MEMO_LINE,
//        //                MARKING_CODE = request.Data.MARKING_CODE,
//        //                REASON_CODE = request.Data.REASON_CODE,
//        //                REASON_DESC = request.Data.REASON_DESC,
//        //                REMARKS = request.Data.REMARKS,
//        //                CONTACT_DATE1 = request.Data.CONTACT_DATE1,
//        //                CONTACT_TIME1 = request.Data.CONTACT_TIME1,
//        //                CONTACT_MODE1 = request.Data.CONTACT_MODE1,
//        //                CONTACT_PLACE1 = request.Data.CONTACT_PLACE1,
//        //                PERSON_CONTACTED1 = request.Data.PERSON_CONTACTED1,
//        //                ACTION_CODE1 = request.Data.ACTION_CODE1,
//        //                CONTACTED_BY1 = request.Data.CONTACTED_BY1,
//        //                REMARKS1 = request.Data.REMARKS1,
//        //                CONTACT_DATE2 = request.Data.CONTACT_DATE2,
//        //                CONTACT_TIME2 = request.Data.CONTACT_TIME2,
//        //                CONTACT_MODE2 = request.Data.CONTACT_MODE2,
//        //                CONTACT_PLACE2 = request.Data.CONTACT_PLACE2,
//        //                PERSON_CONTACTED2 = request.Data.PERSON_CONTACTED2,
//        //                ACTION_CODE2 = request.Data.ACTION_CODE2,
//        //                CONTACTED_BY2 = request.Data.CONTACTED_BY2,
//        //                REMARKS2 = request.Data.REMARKS2,
//        //                CONTACT_DATE3 = request.Data.CONTACT_DATE3,
//        //                CONTACT_TIME3 = request.Data.CONTACT_TIME3,
//        //                CONTACT_MODE3 = request.Data.CONTACT_MODE3,
//        //                CONTACT_PLACE3 = request.Data.CONTACT_PLACE3,
//        //                PERSON_CONTACTED3 = request.Data.PERSON_CONTACTED3,
//        //                ACTION_CODE3 = request.Data.ACTION_CODE3,
//        //                CONTACTED_BY3 = request.Data.CONTACTED_BY3,
//        //                REMARKS3 = request.Data.REMARKS3,
//        //                CONTACT_DATE4 = request.Data.CONTACT_DATE4,
//        //                CONTACT_TIME4 = request.Data.CONTACT_TIME4,
//        //                CONTACT_MODE4 = request.Data.CONTACT_MODE4,
//        //                CONTACT_PLACE4 = request.Data.CONTACT_PLACE4,
//        //                PERSON_CONTACTED4 = request.Data.PERSON_CONTACTED4,
//        //                ACTION_CODE4 = request.Data.ACTION_CODE4,
//        //                CONTACTED_BY4 = request.Data.CONTACTED_BY4,
//        //                REMARKS4 = request.Data.REMARKS4,
//        //                CONTACT_DATE5 = request.Data.CONTACT_DATE5,
//        //                CONTACT_TIME5 = request.Data.CONTACT_TIME5,
//        //                CONTACT_MODE5 = request.Data.CONTACT_MODE5,
//        //                CONTACT_PLACE5 = request.Data.CONTACT_PLACE5,
//        //                PERSON_CONTACTED5 = request.Data.PERSON_CONTACTED5,
//        //                ACTION_CODE5 = request.Data.ACTION_CODE5,
//        //                CONTACTED_BY5 = request.Data.CONTACTED_BY5,
//        //                REMARKS5 = request.Data.REMARKS5,
//        //                CONTACT_DATE6 = request.Data.CONTACT_DATE6,
//        //                CONTACT_TIME6 = request.Data.CONTACT_TIME6,
//        //                CONTACT_MODE6 = request.Data.CONTACT_MODE6,
//        //                CONTACT_PLACE6 = request.Data.CONTACT_PLACE6,
//        //                PERSON_CONTACTED6 = request.Data.PERSON_CONTACTED6,
//        //                ACTION_CODE6 = request.Data.ACTION_CODE6,
//        //                CONTACTED_BY6 = request.Data.CONTACTED_BY6,
//        //                REMARKS6 = request.Data.REMARKS6,
//        //                USER_CODE3 = request.Data.USER_CODE3,
//        //                OTH_CARDNO1 = request.Data.OTH_CARDNO1,
//        //                OTH_CYCLE_DUE1 = request.Data.OTH_CYCLE_DUE1,
//        //                OTH_CURR_ACC_BAL1 = request.Data.OTH_CURR_ACC_BAL1,
//        //                OTH_COLL_CYCLE1 = request.Data.OTH_COLL_CYCLE1,
//        //                OTH_CARDNO2 = request.Data.OTH_CARDNO2,
//        //                OTH_CYCLE_DUE2 = request.Data.OTH_CYCLE_DUE2,
//        //                OTH_CURR_ACC_BAL2 = request.Data.OTH_CURR_ACC_BAL2,
//        //                OTH_COLL_CYCLE2 = request.Data.OTH_COLL_CYCLE2,
//        //                INHOUSE_SCORE = request.Data.INHOUSE_SCORE,
//        //                QUEUE = request.Data.QUEUE,
//        //                PRODUCT_CODE = request.Data.PRODUCT_CODE,
//        //                SPECIAL_STAGE = request.Data.SPECIAL_STAGE,
//        //                CYCLE_DUE = request.Data.CYCLE_DUE,
//        //                CHARGE_OFF_FLAG = request.Data.CHARGE_OFF_FLAG,
//        //                PURPOSE = request.Data.PURPOSE,
//        //                RECOVERY = request.Data.RECOVERY,
//        //                REGION = request.Data.REGION,
//        //                INPUT_MARKING_CODE = request.Data.INPUT_MARKING_CODE,
//        //                INPUT_REASON_CODE = request.Data.INPUT_REASON_CODE,
//        //                INPUT_REASON_DESC = request.Data.INPUT_REASON_DESC,
//        //                INPUT_REMARKS = request.Data.INPUT_REMARKS,
//        //                NEW_PHONE1 = request.Data.NEW_PHONE1,
//        //                NEW_PHONE2 = request.Data.NEW_PHONE2,
//        //                NEW_MOBILE = request.Data.NEW_MOBILE,
//        //                NEWADDRESS_L1 = request.Data.NEWADDRESS_L1,
//        //                NEWADDRESS_L2 = request.Data.NEWADDRESS_L2,
//        //                NEWADDRESS_L3 = request.Data.NEWADDRESS_L3,
//        //                NEW_CITY = request.Data.NEW_CITY,
//        //                PTPDATE = request.Data.PTPDATE,
//        //                PTPAMOUNT = request.Data.PTPAMOUNT,
//        //                INPUT_REMARKS1 = request.Data.INPUT_REMARKS1,
//        //                INPUT_REMARKS2 = request.Data.INPUT_REMARKS2,
//        //                INPUT_REMARKS3 = request.Data.INPUT_REMARKS3,
//        //                INPUT_REMARKS4 = request.Data.INPUT_REMARKS4,
//        //                INPUT_REMARKS5 = request.Data.INPUT_REMARKS5,
//        //                INPUT_REMARKS6 = request.Data.INPUT_REMARKS6,
//        //                INPUT_CONTACT_PLACE1 = request.Data.INPUT_CONTACT_PLACE1,
//        //                INPUT_CONTACT_PLACE2 = request.Data.INPUT_CONTACT_PLACE2,
//        //                INPUT_CONTACT_PLACE3 = request.Data.INPUT_CONTACT_PLACE3,
//        //                INPUT_CONTACT_PLACE4 = request.Data.INPUT_CONTACT_PLACE4,
//        //                INPUT_CONTACT_PLACE5 = request.Data.INPUT_CONTACT_PLACE5,
//        //                INPUT_CONTACT_PLACE6 = request.Data.INPUT_CONTACT_PLACE6,
//        //                IN_PERSON_CONTACT1 = request.Data.IN_PERSON_CONTACT1,
//        //                IN_PERSON_CONTACT2 = request.Data.IN_PERSON_CONTACT2,
//        //                IN_PERSON_CONTACT3 = request.Data.IN_PERSON_CONTACT3,
//        //                IN_PERSON_CONTACT4 = request.Data.IN_PERSON_CONTACT4,
//        //                IN_PERSON_CONTACT5 = request.Data.IN_PERSON_CONTACT5,
//        //                IN_PERSON_CONTACT6 = request.Data.IN_PERSON_CONTACT6,
//        //                C_CONTACT1_P = request.Data.C_CONTACT1_P,
//        //                C_CONTACT2_P = request.Data.C_CONTACT2_P,
//        //                C_MOBILE_P = request.Data.C_MOBILE_P,
//        //                C_CONTACT1_E = request.Data.C_CONTACT1_E,
//        //                C_CONTACT2_E = request.Data.C_CONTACT2_E,
//        //                C_MOBILE_E = request.Data.C_MOBILE_E,
//        //                CM_SPLCAT = request.Data.CM_SPLCAT,
//        //                CM_DELRES = request.Data.CM_DELRES,
//        //                DPD60 = request.Data.DPD60,
//        //                DPD90 = request.Data.DPD90,
//        //                DPD120 = request.Data.DPD120,
//        //                DPD150 = request.Data.DPD150,
//        //                PTPDATE2 = request.Data.PTPDATE2,
//        //                PTPAMOUNT2 = request.Data.PTPAMOUNT2,
//        //                ACTION2 = request.Data.ACTION2,
//        //                PTPDATE3 = request.Data.PTPDATE3,
//        //                PTPAMOUNT3 = request.Data.PTPAMOUNT3,
//        //                ACTION3 = request.Data.ACTION3,
//        //                TZ = request.Data.TZ,
//        //                Area_c = request.Data.Area_c,
//        //                TimeZone_Id = request.Data.TimeZone_Id,
//        //                Dial_Count = request.Data.Dial_Count,
//        //                Call1_Phone = request.Data.Call1_Phone,
//        //                Call1_dt = request.Data.Call1_dt,
//        //                Disp1_Id = request.Data.Disp1_Id,
//        //                Agent1_c = request.Data.Agent1_c,
//        //                Call2_Phone = request.Data.Call2_Phone,
//        //                Call2_dt = request.Data.Call2_dt,
//        //                Disp2_Id = request.Data.Disp2_Id,
//        //                Agent2_c = request.Data.Agent2_c,
//        //                Call3_Phone = request.Data.Call3_Phone,
//        //                Call3_dt = request.Data.Call3_dt,
//        //                Disp3_Id = request.Data.Disp3_Id,
//        //                Agent3_c = request.Data.Agent3_c,
//        //                Callback_dt = request.Data.Callback_dt,
//        //                Callback_Phone = request.Data.Callback_Phone,
//        //                DoNotCall = request.Data.DoNotCall,
//        //                DynaOrder = request.Data.DynaOrder,
//        //                Phone1TimeZoneId = request.Data.Phone1TimeZoneId,
//        //                Phone2TimeZoneId = request.Data.Phone2TimeZoneId,
//        //                Phone3TimeZoneId = request.Data.Phone3TimeZoneId,
//        //                Call4_Phone = request.Data.Call4_Phone,
//        //                Phone4TimeZoneId = request.Data.Phone4TimeZoneId,
//        //                Call4_dt = request.Data.Call4_dt,
//        //                Disp4_Id = request.Data.Disp4_Id,
//        //                Agent4_c = request.Data.Agent4_c,
//        //                Call5_Phone = request.Data.Call5_Phone,
//        //                Phone5TimeZoneId = request.Data.Phone5TimeZoneId,
//        //                Call5_dt = request.Data.Call5_dt,
//        //                Disp5_Id = request.Data.Disp5_Id,
//        //                Agent5_c = request.Data.Agent5_c,
//        //                Call6_Phone = request.Data.Call6_Phone,
//        //                Phone6TimeZoneId = request.Data.Phone6TimeZoneId,
//        //                Call6_dt = request.Data.Call6_dt,
//        //                Disp6_Id = request.Data.Disp6_Id,
//        //                Agent6_c = request.Data.Agent6_c,
//        //                AccountNo = request.AccountNo
//        //            });

//        //            var account = connection.QueryFirstOrDefault<AppAccount>($"SELECT * FROM {request.TableName} WHERE LOANNO = @AccountNo",
//        //                new { AccountNo = request.AccountNo });

//        //            response.Metadata = new Metadata
//        //            {
//        //                Record_Num = account.Record_Num,
//        //                CARDNO = account.CARDNO,
//        //                ACCNO = account.ACCNO,
//        //                CUSTID = account.CUSTID,
//        //                CUSTNAME = account.CUSTNAME,
//        //                ALAMAT_P = account.ALAMAT_P,
//        //                CONTACT1_P = account.CONTACT1_P,
//        //                CONTACT2_P = account.CONTACT2_P,
//        //                MOBILE_P = account.MOBILE_P,
//        //                CITY_P = account.CITY_P,
//        //                ALAMAT_E = account.ALAMAT_E,
//        //                CONTACT1_E = account.CONTACT1_E,
//        //                CONTACT2_E = account.CONTACT2_E,
//        //                MOBILE_E = account.MOBILE_E,
//        //                CITY_E = account.CITY_E,
//        //                ALAMAT_O = account.ALAMAT_O,
//        //                CONTACT1_O = account.CONTACT1_O,
//        //                CONTACT2_O = account.CONTACT2_O,
//        //                MOBILE_O = account.MOBILE_O,
//        //                CITY_O = account.CITY_O,
//        //                DOB = account.DOB,
//        //                SEX = account.SEX,
//        //                SCORE_X = account.SCORE_X,
//        //                CURRENT_ORG = account.CURRENT_ORG,
//        //                SCORE_30DPD = account.SCORE_30DPD,
//        //                ZIPCODE = account.ZIPCODE,
//        //                OPENED_DATE = account.OPENED_DATE,
//        //                LAST_PAYMENT_AMT = account.LAST_PAYMENT_AMT,
//        //                LAST_PAYMENT_DATE = account.LAST_PAYMENT_DATE,
//        //                ACC_BLOCK_CODE1 = account.ACC_BLOCK_CODE1,
//        //                PAYMENT_DUE_DATE = account.PAYMENT_DUE_DATE,
//        //                COLL_CYCLE = account.COLL_CYCLE,
//        //                DEL_STRING = account.DEL_STRING,
//        //                CURR_ACC_BAL = account.CURR_ACC_BAL,
//        //                CREDIT_LIMIT = account.CREDIT_LIMIT,
//        //                OVER_LIMIT = account.OVER_LIMIT,
//        //                TOT_AMT_DUE = account.TOT_AMT_DUE,
//        //                AMT_OVERDUE = account.AMT_OVERDUE,
//        //                TOT_CURR_DUE = account.TOT_CURR_DUE,
//        //                BUCKET1 = account.BUCKET1,
//        //                BUCKET2 = account.BUCKET2,
//        //                CUST_MEMO_LINE = account.CUST_MEMO_LINE,
//        //                MARKING_CODE = account.MARKING_CODE,
//        //                REASON_CODE = account.REASON_CODE,
//        //                REASON_DESC = account.REASON_DESC,
//        //                REMARKS = account.REMARKS,
//        //                CONTACT_DATE1 = account.CONTACT_DATE1,
//        //                CONTACT_TIME1 = account.CONTACT_TIME1,
//        //                CONTACT_MODE1 = account.CONTACT_MODE1,
//        //                CONTACT_PLACE1 = account.CONTACT_PLACE1,
//        //                PERSON_CONTACTED1 = account.PERSON_CONTACTED1,
//        //                ACTION_CODE1 = account.ACTION_CODE1,
//        //                CONTACTED_BY1 = account.CONTACTED_BY1,
//        //                REMARKS1 = account.REMARKS1,
//        //                CONTACT_DATE2 = account.CONTACT_DATE2,
//        //                CONTACT_TIME2 = account.CONTACT_TIME2,
//        //                CONTACT_MODE2 = account.CONTACT_MODE2,
//        //                CONTACT_PLACE2 = account.CONTACT_PLACE2,
//        //                PERSON_CONTACTED2 = account.PERSON_CONTACTED2,
//        //                ACTION_CODE2 = account.ACTION_CODE2,
//        //                CONTACTED_BY2 = account.CONTACTED_BY2,
//        //                REMARKS2 = account.REMARKS2,
//        //                CONTACT_DATE3 = account.CONTACT_DATE3,
//        //                CONTACT_TIME3 = account.CONTACT_TIME3,
//        //                CONTACT_MODE3 = account.CONTACT_MODE3,
//        //                CONTACT_PLACE3 = account.CONTACT_PLACE3,
//        //                PERSON_CONTACTED3 = account.PERSON_CONTACTED3,
//        //                ACTION_CODE3 = account.ACTION_CODE3,
//        //                CONTACTED_BY3 = account.CONTACTED_BY3,
//        //                REMARKS3 = account.REMARKS3,
//        //                CONTACT_DATE4 = account.CONTACT_DATE4,
//        //                CONTACT_TIME4 = account.CONTACT_TIME4,
//        //                CONTACT_MODE4 = account.CONTACT_MODE4,
//        //                CONTACT_PLACE4 = account.CONTACT_PLACE4,
//        //                PERSON_CONTACTED4 = account.PERSON_CONTACTED4,
//        //                ACTION_CODE4 = account.ACTION_CODE4,
//        //                CONTACTED_BY4 = account.CONTACTED_BY4,
//        //                REMARKS4 = account.REMARKS4,
//        //                CONTACT_DATE5 = account.CONTACT_DATE5,
//        //                CONTACT_TIME5 = account.CONTACT_TIME5,
//        //                CONTACT_MODE5 = account.CONTACT_MODE5,
//        //                CONTACT_PLACE5 = account.CONTACT_PLACE5,
//        //                PERSON_CONTACTED5 = account.PERSON_CONTACTED5,
//        //                ACTION_CODE5 = account.ACTION_CODE5,
//        //                CONTACTED_BY5 = account.CONTACTED_BY5,
//        //                REMARKS5 = account.REMARKS5,
//        //                CONTACT_DATE6 = account.CONTACT_DATE6,
//        //                CONTACT_TIME6 = account.CONTACT_TIME6,
//        //                CONTACT_MODE6 = account.CONTACT_MODE6,
//        //                CONTACT_PLACE6 = account.CONTACT_PLACE6,
//        //                PERSON_CONTACTED6 = account.PERSON_CONTACTED6,
//        //                ACTION_CODE6 = account.ACTION_CODE6,
//        //                CONTACTED_BY6 = account.CONTACTED_BY6,
//        //                REMARKS6 = account.REMARKS6,
//        //                USER_CODE3 = account.USER_CODE3,
//        //                OTH_CARDNO1 = account.OTH_CARDNO1,
//        //                OTH_CYCLE_DUE1 = account.OTH_CYCLE_DUE1,
//        //                OTH_CURR_ACC_BAL1 = account.OTH_CURR_ACC_BAL1,
//        //                OTH_COLL_CYCLE1 = account.OTH_COLL_CYCLE1,
//        //                OTH_CARDNO2 = account.OTH_CARDNO2,
//        //                OTH_CYCLE_DUE2 = account.OTH_CYCLE_DUE2,
//        //                OTH_CURR_ACC_BAL2 = account.OTH_CURR_ACC_BAL2,
//        //                OTH_COLL_CYCLE2 = account.OTH_COLL_CYCLE2,
//        //                INHOUSE_SCORE = account.INHOUSE_SCORE,
//        //                QUEUE = account.QUEUE,
//        //                PRODUCT_CODE = account.PRODUCT_CODE,
//        //                SPECIAL_STAGE = account.SPECIAL_STAGE,
//        //                CYCLE_DUE = account.CYCLE_DUE,
//        //                CHARGE_OFF_FLAG = account.CHARGE_OFF_FLAG,
//        //                PURPOSE = account.PURPOSE,
//        //                RECOVERY = account.RECOVERY,
//        //                REGION = account.REGION,
//        //                INPUT_MARKING_CODE = account.INPUT_MARKING_CODE,
//        //                INPUT_REASON_CODE = account.INPUT_REASON_CODE,
//        //                INPUT_REASON_DESC = account.INPUT_REASON_DESC,
//        //                INPUT_REMARKS = account.INPUT_REMARKS,
//        //                NEW_PHONE1 = account.NEW_PHONE1,
//        //                NEW_PHONE2 = account.NEW_PHONE2,
//        //                NEW_MOBILE = account.NEW_MOBILE,
//        //                NEWADDRESS_L1 = account.NEWADDRESS_L1,
//        //                NEWADDRESS_L2 = account.NEWADDRESS_L2,
//        //                NEWADDRESS_L3 = account.NEWADDRESS_L3,
//        //                NEW_CITY = account.NEW_CITY,
//        //                PTPDATE = account.PTPDATE,
//        //                PTPAMOUNT = account.PTPAMOUNT,
//        //                INPUT_REMARKS1 = account.INPUT_REMARKS1,
//        //                INPUT_REMARKS2 = account.INPUT_REMARKS2,
//        //                INPUT_REMARKS3 = account.INPUT_REMARKS3,
//        //                INPUT_REMARKS4 = account.INPUT_REMARKS4,
//        //                INPUT_REMARKS5 = account.INPUT_REMARKS5,
//        //                INPUT_REMARKS6 = account.INPUT_REMARKS6,
//        //                INPUT_CONTACT_PLACE1 = account.INPUT_CONTACT_PLACE1,
//        //                INPUT_CONTACT_PLACE2 = account.INPUT_CONTACT_PLACE2,
//        //                INPUT_CONTACT_PLACE3 = account.INPUT_CONTACT_PLACE3,
//        //                INPUT_CONTACT_PLACE4 = account.INPUT_CONTACT_PLACE4,
//        //                INPUT_CONTACT_PLACE5 = account.INPUT_CONTACT_PLACE5,
//        //                INPUT_CONTACT_PLACE6 = account.INPUT_CONTACT_PLACE6,
//        //                IN_PERSON_CONTACT1 = account.IN_PERSON_CONTACT1,
//        //                IN_PERSON_CONTACT2 = account.IN_PERSON_CONTACT2,
//        //                IN_PERSON_CONTACT3 = account.IN_PERSON_CONTACT3,
//        //                IN_PERSON_CONTACT4 = account.IN_PERSON_CONTACT4,
//        //                IN_PERSON_CONTACT5 = account.IN_PERSON_CONTACT5,
//        //                IN_PERSON_CONTACT6 = account.IN_PERSON_CONTACT6,
//        //                C_CONTACT1_P = account.C_CONTACT1_P,
//        //                C_CONTACT2_P = account.C_CONTACT2_P,
//        //                C_MOBILE_P = account.C_MOBILE_P,
//        //                C_CONTACT1_E = account.C_CONTACT1_E,
//        //                C_CONTACT2_E = account.C_CONTACT2_E,
//        //                C_MOBILE_E = account.C_MOBILE_E,
//        //                CM_SPLCAT = account.CM_SPLCAT,
//        //                CM_DELRES = account.CM_DELRES,
//        //                DPD60 = account.DPD60,
//        //                DPD90 = account.DPD90,
//        //                DPD120 = account.DPD120,
//        //                DPD150 = account.DPD150,
//        //                PTPDATE2 = account.PTPDATE2,
//        //                PTPAMOUNT2 = account.PTPAMOUNT2,
//        //                ACTION2 = account.ACTION2,
//        //                PTPDATE3 = account.PTPDATE3,
//        //                PTPAMOUNT3 = account.PTPAMOUNT3,
//        //                ACTION3 = account.ACTION3,
//        //                TZ = account.TZ,
//        //                Area_c = account.Area_c,
//        //                TimeZone_Id = account.TimeZone_Id,
//        //                Dial_Count = account.Dial_Count,
//        //                Call1_Phone = account.Call1_Phone,
//        //                Call1_dt = account.Call1_dt,
//        //                Disp1_Id = account.Disp1_Id,
//        //                Agent1_c = account.Agent1_c,
//        //                Call2_Phone = account.Call2_Phone,
//        //                Call2_dt = account.Call2_dt,
//        //                Disp2_Id = account.Disp2_Id,
//        //                Agent2_c = account.Agent2_c,
//        //                Call3_Phone = account.Call3_Phone,
//        //                Call3_dt = account.Call3_dt,
//        //                Disp3_Id = account.Disp3_Id,
//        //                Agent3_c = account.Agent3_c,
//        //                Callback_dt = account.Callback_dt,
//        //                Callback_Phone = account.Callback_Phone,
//        //                DoNotCall = account.DoNotCall,
//        //                DynaOrder = account.DynaOrder,
//        //                Phone1TimeZoneId = account.Phone1TimeZoneId,
//        //                Phone2TimeZoneId = account.Phone2TimeZoneId,
//        //                Phone3TimeZoneId = account.Phone3TimeZoneId,
//        //                Call4_Phone = account.Call4_Phone,
//        //                Phone4TimeZoneId = account.Phone4TimeZoneId,
//        //                Call4_dt = account.Call4_dt,
//        //                Disp4_Id = account.Disp4_Id,
//        //                Agent4_c = account.Agent4_c,
//        //                Call5_Phone = account.Call5_Phone,
//        //                Phone5TimeZoneId = account.Phone5TimeZoneId,
//        //                Call5_dt = account.Call5_dt,
//        //                Disp5_Id = account.Disp5_Id,
//        //                Agent5_c = account.Agent5_c,
//        //                Call6_Phone = account.Call6_Phone,
//        //                Phone6TimeZoneId = account.Phone6TimeZoneId,
//        //                Call6_dt = account.Call6_dt,
//        //                Disp6_Id = account.Disp6_Id,
//        //                Agent6_c = account.Agent6_c
//        //            };
//        //        }

//        //        return response;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        response.Success = false;
//        //        response.ErrorMessage = ex.Message;
//        //    }
            
//        //    return response;
//        //}
//    }
//}
