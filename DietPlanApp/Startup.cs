using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DietPlanApp.Startup))]
namespace DietPlanApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
