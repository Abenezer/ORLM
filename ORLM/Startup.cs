using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ORLM.Startup))]
namespace ORLM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
