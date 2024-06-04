using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GPSSadao01.Startup))]
namespace GPSSadao01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
