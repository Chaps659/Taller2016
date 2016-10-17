using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoBetaDDD.MVC.Startup))]
namespace ProyectoBetaDDD.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
