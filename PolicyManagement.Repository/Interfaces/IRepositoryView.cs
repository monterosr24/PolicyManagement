using PolicyManagement.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PolicyManagement.Repository.Interfaces
{
    public interface IRepositoryView
    {
        IEnumerable<TEntity> GetAll<TEntity>()
          where TEntity : BaseView;

        IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> predicate)
             where TEntity : BaseView;
    }
}
