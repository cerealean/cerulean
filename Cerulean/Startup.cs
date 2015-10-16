using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cerulean.Startup))]
namespace Cerulean
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
