using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ICD.Startup))]
namespace ICD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
