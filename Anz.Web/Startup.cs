using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Anz.Web.Startup))]
namespace Anz.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
