using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektniCentar.Startup))]
namespace ProjektniCentar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
