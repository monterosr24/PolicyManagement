using Ninject;
using PolicyManagement.Data;

namespace PolicyManagement.Utilis
{
    public class DependencyInjectionResolver : NinjectResolver<ApplicationDbContext>
    {
        public DependencyInjectionResolver(IKernel kernel) : base(kernel)
        {
        }
    }
}