using PolicyManagement.Models.Model;
using PolicyManagement.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace PolicyManagement.Repository
{
    public class RepositoryView<TContext> : IRepositoryView where TContext : DbContext
    {
        private readonly TContext _context;

        public RepositoryView(TContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> Get<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : BaseView
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }
        
        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : BaseView
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
