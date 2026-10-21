using Cafe.Mortgage.Api.ServiceInterface.Filters;
using Cafe.Mortgage.Api.ServiceModel;
using log4net;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.IO;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    [ValidateCafeKey]
    public class GetParamService : ServiceStack.Service
    {
        private static readonly ILog _log = LogManager.GetLogger(typeof(GetParamService));

        public GetParamResponse Post(GetParam request)
        {
            try
            {
                var response = new GetParamResponse();

                string appPath = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(appPath, "bin", "Params", request.ParamName);

                if (!string.IsNullOrEmpty(request.ParamType))
                    path += $"{request.ParamType.ToUpper()}";
                path += ".json";

                response.Metadata = JsonSerializer.DeserializeFromStream<Dictionary<string, string>>(
                    System.IO.File.OpenRead(path));

                return response;
            }
            catch (Exception ex)
            {
                _log.Error($"Error in GetParamService for ParamName: {request.ParamName}, ParamType: {request.ParamType}", ex);
                throw;
            }
        }
    }
}
