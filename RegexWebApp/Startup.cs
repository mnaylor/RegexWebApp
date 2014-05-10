using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegexWebApp.Startup))]
namespace RegexWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
