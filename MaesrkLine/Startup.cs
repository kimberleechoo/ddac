using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaesrkLine.Startup))]
namespace MaesrkLine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
