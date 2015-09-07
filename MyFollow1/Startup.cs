using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFollow1.Startup))]
namespace MyFollow1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
