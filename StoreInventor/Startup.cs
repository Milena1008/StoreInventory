using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreInventor.Startup))]
namespace StoreInventor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
