using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElSol_test1.Startup))]
namespace ElSol_test1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
