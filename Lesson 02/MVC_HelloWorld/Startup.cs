using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_HelloWorld.Startup))]
namespace MVC_HelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
