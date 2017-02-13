using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GYM.MvcSite.Startup))]
namespace GYM.MvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
