using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DanielleBarnard8778SAPrg522.Startup))]
namespace DanielleBarnard8778SAPrg522
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
