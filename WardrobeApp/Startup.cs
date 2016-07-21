using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardrobeApp.Startup))]
namespace WardrobeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
