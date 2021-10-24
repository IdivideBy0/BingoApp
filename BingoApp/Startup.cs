using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BingoApp.Startup))]
namespace BingoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}