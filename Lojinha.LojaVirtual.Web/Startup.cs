using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lojinha.LojaVirtual.Web.Startup))]
namespace Lojinha.LojaVirtual.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
