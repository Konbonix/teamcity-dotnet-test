using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(teamcity_dotnet_test.Startup))]
namespace teamcity_dotnet_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
