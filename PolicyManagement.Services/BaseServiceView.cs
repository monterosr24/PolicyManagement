using AutoMapper;
using PolicyManagement.Models.Model;
using PolicyManagement.Repository;
using PolicyManagement.Repository.Interfaces;
using PolicyManagement.Services.Interface;
using System.Collections.Generic;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class BaseServiceView<TEntity, TEntityModel> : IBaseServiceView<TEntityModel>
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
    }
}
