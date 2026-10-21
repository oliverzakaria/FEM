using ServiceStack;
using Cafe.Mortgage.Api.ServiceModel;

namespace Cafe.Mortgage.Api.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
