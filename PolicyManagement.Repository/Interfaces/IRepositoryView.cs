using PolicyManagement.Models.Model;
using System.Collections.Generic;

namespace PolicyManagement.Repository.Interfaces
{
    public interface IRepositoryView
    {
        IEnumerable<TEntity> GetAll<TEntity>()
          where TEntity : BaseView;
    }
}
