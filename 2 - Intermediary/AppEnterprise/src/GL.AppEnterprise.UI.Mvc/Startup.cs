using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GL.AppEnterprise.UI.Mvc.Startup))]
namespace GL.AppEnterprise.UI.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
