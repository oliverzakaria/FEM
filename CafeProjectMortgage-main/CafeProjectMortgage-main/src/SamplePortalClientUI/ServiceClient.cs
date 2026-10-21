using ServiceStack;
using System.Collections.Generic;

namespace SamplePortalClientUI
{
    public static class ServiceClient
    {
        public static JsonServiceClient CreateClient(string baseUrl, Dictionary<string, string> headers)
        {
            var client = new JsonServiceClient(baseUrl);
            //foreach (var header in headers)
            //{
            //    client.Headers.Add(header.Key, header.Value);
            //}
            client.RequestFilter = req =>
            {
                foreach (var header in headers)
                {
                    req.Headers.Add(header.Key, header.Value);
                }
            };
            return client;
        }
    }
}
