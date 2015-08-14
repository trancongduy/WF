using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VMS.WebTest.Startup))]
namespace VMS.WebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
