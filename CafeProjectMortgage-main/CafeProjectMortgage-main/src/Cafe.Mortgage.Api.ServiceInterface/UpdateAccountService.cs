using Cafe.Mortgage.Api.ServiceInterface.Filters;
using Cafe.Mortgage.Api.ServiceModel;
using Dapper;
using log4net;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    [ValidateCafeKey]
    public class UpdateAccountService : ServiceStack.Service
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(UpdateAccountService));

        public UpdateAccountResponse Put(UpdateAccount request)
        {
            var appSetting = ConfigurationManager.ConnectionStrings["App"];
            var cfgSetting = ConfigurationManager.ConnectionStrings["Cfg"];

            var response = new UpdateAccountResponse();

            if (request == null)
            {
                response.Success = false;
                response.ErrorMessage = "INVALID REQUEST";
                return response;
            }

            try
            {
                string[] otherActions = new string[] {
                    AppConstants.PhoneOther,
                    AppConstants.PhoneLeaveMessage,
                    AppConstants.PhoneBusy,
                    AppConstants.PhoneDisconnected,
                    AppConstants.PhoneNoAnswer,
                    AppConstants.CaseComplain,
                    AppConstants.SentToFC,
                    AppConstants.CustomerDecease,
                    AppConstants.AccTidakLayakTagih,
                    AppConstants.PhoneReminder
                };

                using (var connection = new SqlConnection(appSetting.ConnectionString.DecryptPwd()))
                {
                    if (request.Action.ToUpper() == AppConstants.Address)
                    {
                        string query = $"UPDATE {request.TableName} " +
                            "SET NEW_ADDRESS_L1 = @NEW_ADDRESS_L1, " +
                            "NEW_ADDRESS_L2 = @NEW_ADDRESS_L2, " +
                            "NEW_ADDRESS_L3 = @NEW_ADDRESS_L3, " +
                            "NEW_CITY = @NEW_CITY, " +
                            "NEW_PHONE1 = @NEW_PHONE1, " +
                            "NEW_PHONE2 = @NEW_PHONE2, " +
                            "NEW_MOBILE = @NEW_MOBILE " +
                            "WHERE LOANNO = @AccountNo";

                        connection.Execute(query, new
                        {
                            NEW_ADDRESS_L1 = request.Data.Address.NEW_ADDRESS_L1,
                            NEW_ADDRESS_L2 = request.Data.Address.NEW_ADDRESS_L2,
                            NEW_ADDRESS_L3 = request.Data.Address.NEW_ADDRESS_L3,
                            NEW_CITY = request.Data.Address.NEW_CITY,
                            NEW_PHONE1 = request.Data.Address.NEW_PHONE1,
                            NEW_PHONE2 = request.Data.Address.NEW_PHONE2,
                            NEW_MOBILE = request.Data.Address.NEW_MOBILE,
                            AccountNo = request.AccountNo
                        });
                    }
                    else if (request.Action.ToUpper() == AppConstants.PTP)
                    {
                        string query = $"UPDATE {request.TableName} " +
                            "SET INPUT_CONTACT_PLACE6 = INPUT_CONTACT_PLACE5 " +
                            ",INPUT_CONTACT_PLACE5 = INPUT_CONTACT_PLACE4 " +
                            ",INPUT_CONTACT_PLACE4 = INPUT_CONTACT_PLACE3 " +
                            ",INPUT_CONTACT_PLACE3 = INPUT_CONTACT_PLACE2 " +
                            ",INPUT_CONTACT_PLACE2 = INPUT_CONTACT_PLACE1 " +
                            ",INPUT_CONTACT_PLACE1 = @INPUT_CONTACT_PLACE1 " +
                            ",IN_PERSON_CONTACT6 = IN_PERSON_CONTACT5 " +
                            ",IN_PERSON_CONTACT5 = IN_PERSON_CONTACT4 " +
                            ",IN_PERSON_CONTACT4 = IN_PERSON_CONTACT3 " +
                            ",IN_PERSON_CONTACT3 = IN_PERSON_CONTACT2 " +
                            ",IN_PERSON_CONTACT2 = IN_PERSON_CONTACT1 " +
                            ",IN_PERSON_CONTACT1 = @IN_PERSON_CONTACT1 " +
                            ",INPUT_REMARKS6 = INPUT_REMARKS5 " +
                            ",INPUT_REMARKS5 = INPUT_REMARKS4 " +
                            ",INPUT_REMARKS4 = INPUT_REMARKS3 " +
                            ",INPUT_REMARKS3 = INPUT_REMARKS2 " +
                            ",INPUT_REMARKS2 = INPUT_REMARKS1 " +
                            ",INPUT_REMARKS1 = @INPUT_REMARKS1 " +
                            ",ACTION2 = @ACTION2 " +
                            ",ACTION3 = @ACTION3 " +
                            ",PTPAMOUNT = @PTPAMOUNT " +
                            ",PTPDATE = @PTPDATE " +
                            ",PTPAMOUNT2 = @PTPAMOUNT2 " +
                            ",PTPDATE2 = @PTPDATE2 " +
                            ",PTPAMOUNT3 = @PTPAMOUNT3 " +
                            ",PTPDATE3 = @PTPDATE3 ";

                        string where = "WHERE LOANNO = @AccountNo";

                        connection.Execute(query + where, new
                        {
                            INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                            IN_PERSON_CONTACT1 = request.Data.Other.IN_PERSON_CONTACT1,
                            INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                            ACTION2 = request.Data.Other.ACTION2,
                            ACTION3 = request.Data.Other.ACTION3,
                            PTPAMOUNT = request.Data.Other.PTPAMOUNT,
                            PTPDATE = request.Data.Other.PTPDATE,
                            PTPAMOUNT2 = request.Data.Other.PTPAMOUNT2,
                            PTPDATE2 = request.Data.Other.PTPDATE2,
                            PTPAMOUNT3 = request.Data.Other.PTPAMOUNT3,
                            PTPDATE3 = request.Data.Other.PTPDATE3,
                            AccountNo = request.AccountNo
                        });

                        using (var conn = new SqlConnection(cfgSetting.ConnectionString.DecryptPwd()))
                        {
                            if (!string.IsNullOrEmpty(request.AccountNo1))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo1",
                                new { AccountNo1 = request.AccountNo1 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                            }

                            if (!string.IsNullOrEmpty(request.AccountNo2))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo2",
                                new { AccountNo2 = request.AccountNo2 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                            }
                        }
                    }
                    else if (request.Action.ToUpper() == AppConstants.Borrower)
                    {
                        string query = $"UPDATE {request.TableName} " +
                            "SET INPUT_CONTACT_PLACE6 = INPUT_CONTACT_PLACE5 " +
                            ",INPUT_CONTACT_PLACE5 = INPUT_CONTACT_PLACE4 " +
                            ",INPUT_CONTACT_PLACE4 = INPUT_CONTACT_PLACE3 " +
                            ",INPUT_CONTACT_PLACE3 = INPUT_CONTACT_PLACE2 " +
                            ",INPUT_CONTACT_PLACE2 = INPUT_CONTACT_PLACE1 " +
                            ",INPUT_CONTACT_PLACE1 = @INPUT_CONTACT_PLACE1 " +
                            ",IN_PERSON_CONTACT6 = IN_PERSON_CONTACT5 " +
                            ",IN_PERSON_CONTACT5 = IN_PERSON_CONTACT4 " +
                            ",IN_PERSON_CONTACT4 = IN_PERSON_CONTACT3 " +
                            ",IN_PERSON_CONTACT3 = IN_PERSON_CONTACT2 " +
                            ",IN_PERSON_CONTACT2 = IN_PERSON_CONTACT1 " +
                            ",IN_PERSON_CONTACT1 = @IN_PERSON_CONTACT1 " +
                            ",INPUT_REMARKS6 = INPUT_REMARKS5 " +
                            ",INPUT_REMARKS5 = INPUT_REMARKS4 " +
                            ",INPUT_REMARKS4 = INPUT_REMARKS3 " +
                            ",INPUT_REMARKS3 = INPUT_REMARKS2 " +
                            ",INPUT_REMARKS2 = INPUT_REMARKS1 " +
                            ",INPUT_REMARKS1 = @INPUT_REMARKS1 " +
                            ",ACTION2 = @ACTION2 " +
                            ",ACTION3 = @ACTION3 " +
                            ",PTPAMOUNT2 = @PTPAMOUNT2 " +
                            ",PTPDATE2 = @PTPDATE2 " +
                            ",PTPAMOUNT3 = @PTPAMOUNT3 " +
                            ",PTPDATE3 = @PTPDATE3 ";

                        string where = "WHERE LOANNO = @AccountNo";


                        connection.Execute(query + where, new
                        {
                            INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                            IN_PERSON_CONTACT1 = "BORRWR",
                            INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                            ACTION2 = request.Data.Other.ACTION2,
                            ACTION3 = request.Data.Other.ACTION3,
                            PTPAMOUNT2 = request.Data.Other.PTPAMOUNT2,
                            PTPDATE2 = request.Data.Other.PTPDATE2,
                            PTPAMOUNT3 = request.Data.Other.PTPAMOUNT3,
                            PTPDATE3 = request.Data.Other.PTPDATE3,
                            AccountNo = request.AccountNo
                        });

                        using (var conn = new SqlConnection(cfgSetting.ConnectionString.DecryptPwd()))
                        {
                            if (!string.IsNullOrEmpty(request.AccountNo1))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo1",
                                new { AccountNo1 = request.AccountNo1 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                            }

                            if (!string.IsNullOrEmpty(request.AccountNo2))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo2",
                                new { AccountNo2 = request.AccountNo2 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                            }
                        }
                    }
                    else if (request.Action.ToUpper() == AppConstants.CP)
                    {
                        string query = $"UPDATE {request.TableName} " +
                            "SET INPUT_CONTACT_PLACE6 = INPUT_CONTACT_PLACE5 " +
                            ",INPUT_CONTACT_PLACE5 = INPUT_CONTACT_PLACE4 " +
                            ",INPUT_CONTACT_PLACE4 = INPUT_CONTACT_PLACE3 " +
                            ",INPUT_CONTACT_PLACE3 = INPUT_CONTACT_PLACE2 " +
                            ",INPUT_CONTACT_PLACE2 = INPUT_CONTACT_PLACE1 " +
                            ",INPUT_CONTACT_PLACE1 = @INPUT_CONTACT_PLACE1 " +
                            ",IN_PERSON_CONTACT6 = IN_PERSON_CONTACT5 " +
                            ",IN_PERSON_CONTACT5 = IN_PERSON_CONTACT4 " +
                            ",IN_PERSON_CONTACT4 = IN_PERSON_CONTACT3 " +
                            ",IN_PERSON_CONTACT3 = IN_PERSON_CONTACT2 " +
                            ",IN_PERSON_CONTACT2 = IN_PERSON_CONTACT1 " +
                            ",IN_PERSON_CONTACT1 = @IN_PERSON_CONTACT1 " +
                            ",INPUT_REMARKS6 = INPUT_REMARKS5 " +
                            ",INPUT_REMARKS5 = INPUT_REMARKS4 " +
                            ",INPUT_REMARKS4 = INPUT_REMARKS3 " +
                            ",INPUT_REMARKS3 = INPUT_REMARKS2 " +
                            ",INPUT_REMARKS2 = INPUT_REMARKS1 " +
                            ",INPUT_REMARKS1 = @INPUT_REMARKS1 " +
                            ",ACTION2 = @ACTION2 " +
                            ",ACTION3 = @ACTION3 " +
                            ",PTPAMOUNT2 = @PTPAMOUNT2 " +
                            ",PTPDATE2 = @PTPDATE2 " +
                            ",PTPAMOUNT3 = @PTPAMOUNT3 " +
                            ",PTPDATE3 = @PTPDATE3 ";

                        string where = "WHERE LOANNO = @AccountNo";

                        connection.Execute(query + where, new
                        {
                            INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                            IN_PERSON_CONTACT1 = "BORRWR",
                            INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                            ACTION2 = request.Data.Other.ACTION2,
                            ACTION3 = request.Data.Other.ACTION3,
                            PTPAMOUNT2 = request.Data.Other.PTPAMOUNT2,
                            PTPDATE2 = request.Data.Other.PTPDATE2,
                            PTPAMOUNT3 = request.Data.Other.ACTION3 != "PTP" ? 0 : request.Data.Other.PTPAMOUNT3,
                            PTPDATE3 = request.Data.Other.PTPDATE3,
                            AccountNo = request.AccountNo
                        });

                        using (var conn = new SqlConnection(cfgSetting.ConnectionString.DecryptPwd()))
                        {
                            if (!string.IsNullOrEmpty(request.AccountNo1))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo1",
                                new { AccountNo1 = request.AccountNo1 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo1 = request.AccountNo1 });
                                }
                            }

                            if (!string.IsNullOrEmpty(request.AccountNo2))
                            {
                                var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo2",
                                new { AccountNo2 = request.AccountNo2 });

                                if (count > 0)
                                {
                                    if (request.IsPrev)
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                                else
                                {
                                    if (request.IsPrev)
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                    else
                                        conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                            new { AccountNo2 = request.AccountNo2 });
                                }
                            }
                        }
                    }
                    else if (otherActions.Contains(request.Action.ToUpper()))
                    {
                        string query = $"UPDATE {request.TableName} " +
                            "SET INPUT_CONTACT_PLACE6 = INPUT_CONTACT_PLACE5 " +
                            ",INPUT_CONTACT_PLACE5 = INPUT_CONTACT_PLACE4 " +
                            ",INPUT_CONTACT_PLACE4 = INPUT_CONTACT_PLACE3 " +
                            ",INPUT_CONTACT_PLACE3 = INPUT_CONTACT_PLACE2 " +
                            ",INPUT_CONTACT_PLACE2 = INPUT_CONTACT_PLACE1 " +
                            ",INPUT_CONTACT_PLACE1 = @INPUT_CONTACT_PLACE1 " +
                            ",IN_PERSON_CONTACT6 = IN_PERSON_CONTACT5 " +
                            ",IN_PERSON_CONTACT5 = IN_PERSON_CONTACT4 " +
                            ",IN_PERSON_CONTACT4 = IN_PERSON_CONTACT3 " +
                            ",IN_PERSON_CONTACT3 = IN_PERSON_CONTACT2 " +
                            ",IN_PERSON_CONTACT2 = IN_PERSON_CONTACT1 " +
                            ",IN_PERSON_CONTACT1 = @IN_PERSON_CONTACT1 " +
                            ",INPUT_REMARKS6 = INPUT_REMARKS5 " +
                            ",INPUT_REMARKS5 = INPUT_REMARKS4 " +
                            ",INPUT_REMARKS4 = INPUT_REMARKS3 " +
                            ",INPUT_REMARKS3 = INPUT_REMARKS2 " +
                            ",INPUT_REMARKS2 = INPUT_REMARKS1 " +
                            ",INPUT_REMARKS1 = @INPUT_REMARKS1 " +
                            ",ACTION2 = @ACTION2 " +
                            ",ACTION3 = @ACTION3 ";

                        string where = "WHERE LOANNO = @AccountNo";

                        if (request.Action.ToUpper() == AppConstants.PhoneOther ||
                            request.Action.ToUpper() == AppConstants.PhoneLeaveMessage ||
                            request.Action.ToUpper() == AppConstants.CaseComplain ||
                            request.Action.ToUpper() == AppConstants.SentToFC ||
                            request.Action.ToUpper() == AppConstants.CustomerDecease ||
                            request.Action.ToUpper() == AppConstants.AccTidakLayakTagih)
                        {
                            connection.Execute(query + where, new
                            {
                                INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                                IN_PERSON_CONTACT1 = request.Data.Other.IN_PERSON_CONTACT1,
                                INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                                ACTION2 = request.Data.Other.ACTION2,
                                ACTION3 = request.Data.Other.ACTION3,
                                AccountNo = request.AccountNo
                            });
                        }
                        else if (request.Action.ToUpper() == AppConstants.PhoneBusy)
                        {
                            connection.Execute(query + where, new
                            {
                                INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                                IN_PERSON_CONTACT1 = "NOBODY",
                                INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                                ACTION2 = "PB",
                                ACTION3 = "PB",
                                AccountNo = request.AccountNo
                            });
                        }
                        else if (request.Action.ToUpper() == AppConstants.PhoneDisconnected)
                        {
                            connection.Execute(query + where, new
                            {
                                INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                                IN_PERSON_CONTACT1 = "NOBODY",
                                INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                                ACTION2 = "PD",
                                ACTION3 = "PD",
                                AccountNo = request.AccountNo
                            });
                        }
                        else if (request.Action.ToUpper() == AppConstants.PhoneNoAnswer)
                        {
                            connection.Execute(query + where, new
                            {
                                INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                                IN_PERSON_CONTACT1 = "NOBODY",
                                INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                                ACTION2 = "PN",
                                ACTION3 = "PN",
                                AccountNo = request.AccountNo
                            });
                        }
                        else if (request.Action.ToUpper() == AppConstants.PhoneReminder)
                        {
                            query = query + ",PTPAMOUNT2 = @PTPAMOUNT2 " +
                                ",PTPDATE2 = @PTPDATE2 " +
                                ",PTPAMOUNT3 = @PTPAMOUNT3 " +
                                ",PTPDATE3 = @PTPDATE3" +
                                ",PTPDATE = @PTPDATE " ;

                            connection.Execute(query + where, new
                            {
                                INPUT_CONTACT_PLACE1 = request.Data.Other.INPUT_CONTACT_PLACE1,
                                IN_PERSON_CONTACT1 = "CH",
                                INPUT_REMARKS1 = request.Data.Other.INPUT_REMARKS1,
                                ACTION2 = request.Data.Other.ACTION2,
                                ACTION3 = request.Data.Other.ACTION3,
                                PTPAMOUNT2 = request.Data.Other.PTPAMOUNT2,
                                PTPDATE2 = request.Data.Other.PTPDATE2,
                                PTPAMOUNT3 = request.Data.Other.PTPAMOUNT3,
                                PTPDATE3 = request.Data.Other.PTPDATE3,
                                AccountNo = request.AccountNo,
                                PTPDATE = request.Data.Other.PTPDATE,
                            });

                            using (var conn = new SqlConnection(cfgSetting.ConnectionString.DecryptPwd()))
                            {
                                if (!string.IsNullOrEmpty(request.AccountNo1))
                                {
                                    var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo1",
                                    new { AccountNo1 = request.AccountNo1 });

                                    if (count > 0)
                                    {
                                        if (request.IsPrev)
                                            conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                                new { AccountNo1 = request.AccountNo1 });
                                        else
                                            conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo1",
                                                new { AccountNo1 = request.AccountNo1 });
                                    }
                                    else
                                    {
                                        if (request.IsPrev)
                                            conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                                new { AccountNo1 = request.AccountNo1 });
                                        else
                                            conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo1,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                                new { AccountNo1 = request.AccountNo1 });
                                    }
                                }

                                if (!string.IsNullOrEmpty(request.AccountNo2))
                                {
                                    var count = conn.QuerySingle<int>("SELECT COUNT(*) FROM CallTableExclusionList WHERE [ExclusionValue] = @AccountNo2",
                                    new { AccountNo2 = request.AccountNo2 });

                                    if (count > 0)
                                    {
                                        if (request.IsPrev)
                                            conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE(), [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                                new { AccountNo2 = request.AccountNo2 });
                                        else
                                            conn.Execute("UPDATE CallTableExclusionList SET [EndDt] = GETDATE()+1, [StartDt] = GETDATE()-2, [ModifiedDt] = GETDATE() where [ExclusionValue] = @AccountNo2",
                                                new { AccountNo2 = request.AccountNo2 });
                                    }
                                    else
                                    {
                                        if (request.IsPrev)
                                            conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE(),GETDATE()+1,GETDATE(),7)",
                                                new { AccountNo2 = request.AccountNo2 });
                                        else
                                            conn.Execute("INSERT INTO CallTableExclusionList([ExclusionTypeId],[ExclusionValue],[Application_Id],[StartDt],[EndDt],[ModifiedDt],[TimeZone_Id]) values(2,@AccountNo2,0,GETDATE()-2,GETDATE()+1,GETDATE(),7)",
                                                new { AccountNo2 = request.AccountNo2 });
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        response.Success = false;
                        response.ErrorMessage = "INVALID UPDATE ACTION";
                    }
                }
            }
            catch (System.Exception ex)
            {
                _log.Error("Error in UpdateAccountService: ", ex);
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}
