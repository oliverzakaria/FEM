using Funq;
using ServiceStack;
using Cafe.Mortgage.Api.ServiceInterface;
using ServiceStack.Auth;

namespace Cafe.Mortgage.Api
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("Cafe.Mortgage.Api", typeof(MyServices).Assembly)
        {
        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            //Plugins.Add(new AuthFeature(() => new CustomUserSession(),
            //    new IAuthProvider[]
            //    {
            //        //new CredentialsAuthProvider(AppSettings), //HTML Form post of UserName/Password credentials
            //        //new BasicAuthProvider(AppSettings), //Sign-in with Basic Auth
            //        new ApiKeyAuthProvider(AppSettings), //Sign-in with API Key
            //    }));

            //SetConfig(new HostConfig
            //{
            //    //DebugMode = AppSettings.Get(nameof(HostConfig.DebugMode), false),
            //    DefaultContentType = MimeTypes.Json,
            //    EnableFeatures = Feature.All.Remove(Feature.Metadata),
            //});

            Config.DefaultContentType = MimeTypes.Json;
            Config.EnableFeatures = Feature.All.Remove(Feature.Metadata);
            Config.GlobalResponseHeaders.Remove("X-Powered-By");
        }
    }

    public class CustomUserSession : AuthUserSession
    {
    }
}