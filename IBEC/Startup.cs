using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IBEC.Startup))]
namespace IBEC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
