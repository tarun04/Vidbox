using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidBox.Startup))]
namespace VidBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
