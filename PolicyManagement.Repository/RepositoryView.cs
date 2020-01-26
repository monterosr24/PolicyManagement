using PolicyManagement.Models.Model;
using PolicyManagement.Repository.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace PolicyManagement.Repository
{
    public class RepositoryView<TContext> : IRepositoryView where TContext : DbContext
    {
        private readonly TContext _context;

        public RepositoryView(TContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : BaseView
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}
