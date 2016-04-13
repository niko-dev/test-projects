using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppliMVC.Startup))]
namespace AppliMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
