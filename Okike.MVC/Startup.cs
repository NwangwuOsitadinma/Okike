using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Okike.MVC.Startup))]
namespace Okike.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
