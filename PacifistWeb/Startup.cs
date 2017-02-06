using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(PacifistWeb.Startup))]

namespace PacifistWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
