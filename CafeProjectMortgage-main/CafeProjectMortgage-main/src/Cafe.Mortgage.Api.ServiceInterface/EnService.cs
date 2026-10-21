using Cafe.Mortgage.Api.ServiceModel;
using ServiceStack;
using System;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    public class EnService : ServiceStack.Service
    {
        public EnResponse Any(En request)
        {
            string key = Environment.GetEnvironmentVariable("FEM_AES_KEY") ?? "eOf+3QXWI/icWPEWYcd9xUU1QxTX97FGoE121/fAHG0=";
            string iv = Environment.GetEnvironmentVariable("FEM_AES_IV") ?? "zfJe+5MAxjk9VtjH1XcYtA==";

            return new EnResponse { Result = AesUtils.Encrypt(request.Text, Convert.FromBase64String(key), Convert.FromBase64String(iv)) };
        }
    }
}
