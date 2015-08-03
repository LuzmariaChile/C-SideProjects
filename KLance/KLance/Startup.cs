using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KLance.Startup))]
namespace KLance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
