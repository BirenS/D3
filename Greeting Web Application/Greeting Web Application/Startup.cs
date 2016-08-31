using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Greeting_Web_Application.Startup))]
namespace Greeting_Web_Application
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
