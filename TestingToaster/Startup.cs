using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingToaster.Startup))]
namespace TestingToaster
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
