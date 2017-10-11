using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeahawksWeb.Startup))]
namespace SeahawksWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
