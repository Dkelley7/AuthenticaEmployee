using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticaEmployee.Startup))]
namespace AuthenticaEmployee
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            EmpInjector.Initialize();
        }
    }
}
