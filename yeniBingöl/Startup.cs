using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(yeniBingöl.Startup))]
namespace yeniBingöl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
