using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnD___Campaign_Dashboard_v._1.Startup))]
namespace DnD___Campaign_Dashboard_v._1
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
