using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaVentasPI.Startup))]
namespace SistemaVentasPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
