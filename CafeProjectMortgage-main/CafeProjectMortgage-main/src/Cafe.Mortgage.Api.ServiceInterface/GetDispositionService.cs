using Cafe.Mortgage.Api.ServiceInterface.Data.Entities;
using Cafe.Mortgage.Api.ServiceInterface.Filters;
using Cafe.Mortgage.Api.ServiceModel;
using log4net;
using ServiceStack.OrmLite;
using System.Configuration;
using System.Linq;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    [ValidateCafeKey]
    public class GetDispositionService : ServiceStack.Service
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(GetDispositionService));

        public GetDispositionResponse Get(GetDisposition request)
        {
            var cfgSetting = ConfigurationManager.ConnectionStrings["Cfg"];
            var dbFactory = new OrmLiteConnectionFactory(cfgSetting.ConnectionString.DecryptPwd(), SqlServerDialect.Provider);

            var response = new GetDispositionResponse();

            try
            {
                using (var db = dbFactory.Open())
                {
                    var results = db.Select<Disposition>(x => x.Disp_Type == 2);

                    response.Data = results.Select(x => new DispositionMetadata
                    {
                        Id = x.Disp_Id,
                        Description = x.Disposition_Desc,
                        Type = x.CallBack_f == 1 ? "CallBack" :
                            x.Sales_f == 1 ? "Sale" :
                            x.Refusal_f == 1 ? "Refusal" :
                            x.Exclusions_f == 1 ? "Exclusion" : "",
                        Code = x.Disp_c
                    }).ToList();
                }

                //using (var connection = new SqlConnection(cfgSetting.ConnectionString))
                //{
                //    var dispositions = connection.Query<Disposition>("SELECT * FROM Disposition WHERE Disp_Type = 2");
                //    if (dispositions != null && dispositions.Count() > 0)
                //    {
                //        response.Data = dispositions.Select(x => new DispositionMetadata
                //        {
                //            Id = x.Disp_Id,
                //            Description = x.Disp_c
                //        }).ToList();
                //    }
                //}
            }
            catch (System.Exception ex)
            {
                _log.Error("Error retrieving dispositions", ex);
                response.Success = false;
                response.ErrorMessage = ex.Message;
            }

            return response;
        }
    }
}
