using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class ClientPolicyService : BaseService<ClientPolicy, ClientPolicyViewModel>, IClientPolicyService
    {
        public ClientPolicyService(DbContext context)
            : base(context)
        {

        }
    }
}
