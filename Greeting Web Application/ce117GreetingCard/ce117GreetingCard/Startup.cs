using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ce117GreetingCard.Startup))]
namespace ce117GreetingCard
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
