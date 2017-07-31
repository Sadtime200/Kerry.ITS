using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kerry.ITS.Startup))]
namespace Kerry.ITS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
