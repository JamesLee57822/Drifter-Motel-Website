using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Drifter_Motel_Website.Startup))]
namespace Drifter_Motel_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
