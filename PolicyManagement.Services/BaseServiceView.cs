using AutoMapper;
using PolicyManagement.Models.Model;
using PolicyManagement.Repository;
using PolicyManagement.Repository.Interfaces;
using PolicyManagement.Services.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace PolicyManagement.Services
{
    public class BaseServiceView<TEntity, TEntityModel> : IBaseServiceView<TEntity, TEntityModel>
        where TEntity : BaseView
    {
        private readonly DbContext _context;
        protected readonly IRepositoryView _repository;

        protected BaseServiceView(DbContext context)
        {
            _context = context;
            _repository = new RepositoryView<DbContext>(_context);
        }

        public IEnumerable<TEntityModel> GetAll()
        {
            var entity = _repository.GetAll<TEntity>();
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityModel>>(entity);
        }

        public IEnumerable<TEntityModel> Get(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = _repository.Get<TEntity>(predicate);
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TEntityModel>>(entities);

        }
    }
}
