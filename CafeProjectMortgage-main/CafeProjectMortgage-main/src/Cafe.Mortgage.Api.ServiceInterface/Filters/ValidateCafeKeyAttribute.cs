using ServiceStack;
using ServiceStack.Web;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Mortgage.Api.ServiceInterface.Filters
{
    public class ValidateCafeKeyAttribute : RequestFilterAttribute
    {
        public override void Execute(IRequest req, IResponse res, object requestDto)
        {
            var key = req.Headers["X-Api-Key"];
            if (!IsValidKey(key))
            {
                res.StatusCode = (int)HttpStatusCode.Unauthorized;
                res.EndRequest();
                return;
            }
            //req.Items["company"] = company; //if info needed in Services
        }

        private bool IsValidKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                return false;

            var validKeys = ConfigurationManager.AppSettings["ApiKeys"].Split(',');
            //var validKeys = new List<string> { "valid-key-1", "valid-key-2" };
            return validKeys.Contains(key);
        }
    }
}