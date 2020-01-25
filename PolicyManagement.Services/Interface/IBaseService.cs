using System.Collections.Generic;
namespace PolicyManagement.Services.Interface
{
    public interface IBaseService<TEntityModel>
    {
        TEntityModel GetId(int id);
        IEnumerable<TEntityModel> GetAll();
        TEntityModel Create(TEntityModel toInsert, string user);
        TEntityModel Update(int id, TEntityModel toUpdate, string user);
    }
}
