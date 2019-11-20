using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAsp.Startup))]
namespace HelloAsp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
