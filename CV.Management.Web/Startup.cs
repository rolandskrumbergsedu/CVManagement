using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CV.Management.Web.Startup))]
namespace CV.Management.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
