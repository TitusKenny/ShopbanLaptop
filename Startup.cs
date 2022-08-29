using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dacs.Startup))]
namespace Dacs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
