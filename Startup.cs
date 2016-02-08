using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiscGolfWebApplication.Startup))]
namespace DiscGolfWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
