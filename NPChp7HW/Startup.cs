using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NPChp7HW.Startup))]
namespace NPChp7HW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
