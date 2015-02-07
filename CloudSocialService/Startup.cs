using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CloudSocialService.Startup))]
namespace CloudSocialService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
