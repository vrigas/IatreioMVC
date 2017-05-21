using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IatreioMVC.Startup))]
namespace IatreioMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
