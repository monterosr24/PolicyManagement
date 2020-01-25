using Ninject;
using Ninject.Web.Common;
using PolicyManagement.Services;
using PolicyManagement.Services.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Mvc;

namespace PolicyManagement.Utilis
{
    public abstract class NinjectResolver<TDbContext> : IDependencyResolver
        where TDbContext : DbContext
    {
        private readonly IKernel _kernel;

        public NinjectResolver()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<DbContext>().To<TDbContext>().InRequestScope();

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
            _kernel.Bind<IPolicyService>().To<PolicyService>().InRequestScope();
        }
    }
}