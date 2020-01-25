using Microsoft.Owin;
using Ninject;
using Owin;
using PolicyManagement.Utilis;
using System.Web.Mvc;

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
            DependencyResolver.SetResolver(
                new DependencyInjectionResolver(kernel)
            );
        }

    }
}
