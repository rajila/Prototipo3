using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prototipo3.Startup))]
namespace Prototipo3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
