using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigsTake100.Startup))]
namespace GigsTake100
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
