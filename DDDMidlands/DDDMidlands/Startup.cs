using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DDDMidlands.Startup))]
namespace DDDMidlands
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
