using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CandyCorner.Startup))]
namespace CandyCorner
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
