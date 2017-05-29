using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGarage3_Ostersund.Startup))]
namespace MVCGarage3_Ostersund
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
