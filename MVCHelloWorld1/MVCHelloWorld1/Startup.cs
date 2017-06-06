using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHelloWorld1.Startup))]
namespace MVCHelloWorld1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
