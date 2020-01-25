using Microsoft.Owin;
using Ninject;
using Owin;
using PolicyManagement.Utilis;

[assembly: OwinStartupAttribute(typeof(PolicyManagement.Startup))]
namespace PolicyManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }

        private static void RegisterServices(IKernel kernel)
        {
            ServicesResolver.RegistreServices(new DependencyInjectionResolver(kernel));
        }

    }
}
