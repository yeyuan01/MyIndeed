using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyIndeed.Startup))]
namespace MyIndeed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
