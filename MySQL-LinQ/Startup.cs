using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySQL_LinQ.Startup))]
namespace MySQL_LinQ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
