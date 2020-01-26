using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PolicyManagement.Services.Interface
{
    public interface IBaseServiceView<TEntity, TEntityModel>
    {
        IEnumerable<TEntityModel> GetAll();
        IEnumerable<TEntityModel> Get(Expression<Func<TEntity, bool>> predicate);
    }
}
