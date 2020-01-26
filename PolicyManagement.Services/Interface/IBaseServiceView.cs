using System.Collections.Generic;

namespace PolicyManagement.Services.Interface
{
    public interface IBaseServiceView<TEntityModel>
    {
        IEnumerable<TEntityModel> GetAll();
    }
}
