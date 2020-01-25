using System.Data.Entity;
using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;

namespace PolicyManagement.Services
{
    public class PolicyService : BaseService<Policy, PolicyViewModel>, IPolicyService
    {
        public PolicyService(DbContext context) : base(context)
        {
        }
    }
}
