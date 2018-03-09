using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BLOGDeportes.Startup))]
namespace BLOGDeportes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
