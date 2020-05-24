using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrácticaSemanal2.Startup))]
namespace PrácticaSemanal2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
