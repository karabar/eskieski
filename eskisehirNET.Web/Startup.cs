using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eskisehirNET.Web.Startup))]
namespace eskisehirNET.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
