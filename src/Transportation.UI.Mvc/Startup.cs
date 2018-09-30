using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transportation.UI.Mvc.Startup))]
namespace Transportation.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
