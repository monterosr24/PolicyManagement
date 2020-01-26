using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class ClientPolicyViewService : BaseServiceView<ClientPolicyView, ClientPolicyViewModel>
    {
        public ClientPolicyViewService(DbContext context)
            :base(context)
        {

        }
    }
}
