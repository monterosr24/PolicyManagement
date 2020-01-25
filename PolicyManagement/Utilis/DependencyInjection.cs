using System.Web.Mvc;

namespace PolicyManagement.Utilis
{
    public static class DependencyInjection
    {
        public static T GetInstanceOf<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
    }
}