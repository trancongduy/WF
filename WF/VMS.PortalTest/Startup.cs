using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMS.PortalTest.Startup))]
namespace VMS.PortalTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
