using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomerMedia.Startup))]
namespace CustomerMedia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
