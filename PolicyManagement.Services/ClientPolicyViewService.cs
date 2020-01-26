using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class ClientPolicyViewService : BaseServiceView<ClientPolicyView, ClientPolicyViewModel>, IClientPolicyViewService
    {
        public ClientPolicyViewService(DbContext context)
            :base(context)
        {

        }
    }
}
