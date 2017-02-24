using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GYM.Presentation.MvcSite.Startup))]
namespace GYM.Presentation.MvcSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
