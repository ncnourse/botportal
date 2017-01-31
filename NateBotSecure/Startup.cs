using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NateBotSecure.Startup))]
namespace NateBotSecure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
