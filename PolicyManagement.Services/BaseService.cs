using System.Collections.Generic;
using System.Data.Entity;
using AutoMapper;
using PolicyManagement.Models.Model;
using PolicyManagement.Repository.Interfaces;
using PolicyManagement.Services.Interface;

namespace PolicyManagement.Services
{
    public abstract class BaseService<TEntity, TEntityModel> : IBaseService<TEntityModel>
        where TEntity : BaseModel
    {
        private readonly DbContext _context;
        private readonly IRepository _repository;

        protected BaseService(DbContext context)
        {
            _context = context;
            _repository = new Repository<DbContext>(_context);
        }

        public virtual TEntityModel Create(TEntityModel toInsert, string user)
        {
            var entity = Mapper.Map<TEntityModel, TEntity>(toInsert);

            entity = _repository.Create(entity, user);

            _repository.Save();

            return Mapper.Map<TEntity, TEntityModel>(entity);
        }

        public virtual IEnumerable<TEntityModel> GetAll()
        {
            var entity = _repository.GetAll<TEntity>();
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable< TEntityModel>>(entity);
        }

        public virtual TEntityModel GetId(int id)
        {
            var entity = _repository.GetId<TEntity>(id);
            return Mapper.Map<TEntity, TEntityModel>(entity);
        }

        public virtual TEntityModel Update(int id, TEntityModel toUpdate, string user)
        {
            var entity = _repository.GetId<TEntity>(id);

            entity = Mapper.Map(toUpdate, entity);

            _repository.Update(entity, user);

            return Mapper.Map<TEntity, TEntityModel>(entity);
        }
        
    }
}
