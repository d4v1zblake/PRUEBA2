using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRUEBA2BNG.Startup))]
namespace PRUEBA2BNG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
