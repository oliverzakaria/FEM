using Cafe.Mortgage.Api.ServiceInterface.Data;
using Cafe.Mortgage.Api.ServiceInterface.Data.Entities;
using Cafe.Mortgage.Api.ServiceInterface.Filters;
using Cafe.Mortgage.Api.ServiceModel;
using Dapper;
using log4net;
using ServiceStack.Text;
using ServiceStack;
using System.Configuration;
using System.Data.SqlClient;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    [ValidateCafeKey]
    public class GetAccountService : ServiceStack.Service
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(GetAccountService));

        //public GetAccountResponse GetJson(GetAccount request)
        //{
        //    return Post(request);
        //}

        public GetAccountResponse Any(GetAccount request)
        {
            var cfgSetting = ConfigurationManager.ConnectionStrings["Cfg"];
            var appSetting = ConfigurationManager.ConnectionStrings["App"];

            var response = new GetAccountResponse();

            try
            {
                using (var connection = new SqlConnection(cfgSetting.ConnectionString.DecryptPwd()))
                {
                    //string query = "SELECT b.Table_Id, b.Table_desc FROM AODService_Tables AS a JOIN Table_Stat AS b ON a.Table_Id = b.Table_Id WHERE a.Service_Id = @ServiceId";
                    //var stats = connection.Query<Table_Stat>(query, new { ServiceId = request.ServiceId });
                    var helper = new SqlHelper(appSetting.ConnectionString.DecryptPwd());

                    //foreach (var stat in stats)
                    //{
                    string query = $"select *, " +
$"case when d.Disp_Type=2 then d.Disp_c " +
$"	 else 'PDA' end Disp1_Desc, " +
$"case when e.Disp_Type=2 then e.Disp_c " +
$"	 else 'PDA' end Disp2_Desc, " +
$"case when f.Disp_Type=2 then f.Disp_c " +
$"	 else 'PDA' end Disp3_Desc, " +
$"case when g.Disp_Type=2 then g.Disp_c " +
$"	 else 'PDA' end Disp4_Desc, " +
$"case when h.Disp_Type=2 then h.Disp_c " +
$"	 else 'PDA' end Disp5_Desc, " +
$"case when i.Disp_Type=2 then i.Disp_c " +
$"	 else 'PDA' end Disp6_Desc " +
$" from {request.TableName} t " +
$"left join config_epro.dbo.Disposition d on d.Disp_Id = t.Disp1_Id " +
$"left join config_epro.dbo.Disposition e on e.Disp_Id = t.Disp2_Id " +
$"left join config_epro.dbo.Disposition f on f.Disp_Id = t.Disp3_Id " +
$"left join config_epro.dbo.Disposition g on g.Disp_Id = t.Disp4_Id " +
$"left join config_epro.dbo.Disposition h on h.Disp_Id = t.Disp5_Id " +
$"left join config_epro.dbo.Disposition i on i.Disp_Id = t.Disp6_Id " +
                    $" WHERE LOANNO = @AccountNo";

                        var table = helper.ExecuteQuery(query, new SqlParameter("AccountNo", request.AccountNo));
                        if (table.Rows.Count == 1)
                        {
                        response.TableName = request.TableName;// stat.Table_desc;
                            foreach (System.Data.DataColumn column in table.Columns)
                            {
                                response.Metadata.Add(new Metadata
                                {
                                    FieldName = column.ColumnName,
                                    FieldValue = table.Rows[0][column].ToString(),
                                    FieldType = column.DataType.ToString()
                                });
                            }

                            //break;
                        }
                    //}

                    return response;
                }
            }
            catch (System.Exception ex)
            {
                _log.Error("Error in GetAccountService.Any: ", ex);
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}
