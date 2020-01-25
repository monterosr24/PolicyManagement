using PolicyManagement.Models.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace PolicyManagement.Repository.Interfaces
{
    public class Repository<TContext> : IRepository where TContext : DbContext
    {
        private readonly TContext _context;

        public Repository(TContext context)
        {
            _context = context;
        }

        public TEntity Create<TEntity>(TEntity entity, string createdBy) where TEntity : BaseModel
        {
            entity.CreatedDate = DateTime.Now;
            entity.CreatedUser = createdBy;
            return _context.Set<TEntity>().Add(entity);
        }

        public void Update<TEntity>(TEntity entity, string modifiedBy) where TEntity : BaseModel
        {
            entity.ModifydDate = DateTime.Now;
            entity.UpdatedUser = modifiedBy;
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete<TEntity>(object id) where TEntity : BaseModel
        {
            TEntity entity = _context.Set<TEntity>().Find(id);

            Delete(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : BaseModel
        {
            var dbSet = _context.Set<TEntity>();

            if(_context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }

            dbSet.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll<TEntity>() where TEntity : BaseModel
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetId<TEntity>(int id) where TEntity : BaseModel
        {
            return _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task SaveAsync()
        {
            try
            {
                return _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
