using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kerry.ITS.WEB.Startup))]
namespace Kerry.ITS.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
