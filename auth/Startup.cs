using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(auth.Startup))]
namespace auth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
