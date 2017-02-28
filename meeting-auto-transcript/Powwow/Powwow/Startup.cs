using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Powwow.Startup))]
namespace Powwow
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
