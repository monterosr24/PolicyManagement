using PolicyManagement.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PolicyManagement.Repository.Interfaces
{
    public interface IRepository
    {
        TEntity Create<TEntity>(TEntity entity, string createdBy)
           where TEntity : BaseModel;

        void Update<TEntity>(TEntity entity, string modifiedBy)
            where TEntity : BaseModel;

        void Delete<TEntity>(object id)
            where TEntity : BaseModel;

        void Delete<TEntity>(TEntity entity)
            where TEntity : BaseModel;

        IEnumerable<TEntity> GetAll<TEntity>(Expression<Func<TEntity, bool>> predicate)
           where TEntity : BaseModel;

        void Save();

        Task SaveAsync();
    }
}
