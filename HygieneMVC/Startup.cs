using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HygieneMVC.Startup))]
namespace HygieneMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
