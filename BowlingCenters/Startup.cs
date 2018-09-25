using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BowlingCenters.Startup))]
namespace BowlingCenters
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
