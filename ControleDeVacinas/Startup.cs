using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControleDeVacinas.Startup))]
namespace ControleDeVacinas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
