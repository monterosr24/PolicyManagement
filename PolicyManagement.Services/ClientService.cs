using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class ClientService: BaseService<Client,ClientViewModel>, IClientService
    {
        public ClientService(DbContext context)
            :base(context)
        {

        }
    }
}
