using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;

namespace PolicyManagement.Utilis
{
    public abstract class NinjectResolver<TDbContext> : IDependencyResolver
        where TDbContext : DbContext
    {
        private IKernel _kernel;

        public NinjectResolver(IKernel kernel)
        {
            _kernel = kernel;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // Añadir los binds aquí.
            //_kernel.Bind<IMiInterface>().To(MiClaseDerivada)();
        }
    }
}