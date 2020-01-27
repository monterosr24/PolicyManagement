using PolicyManagement.Models.Model;
using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
using System.Data.Entity;

namespace PolicyManagement.Services
{
    public class CustomerPoliciesViewService : BaseServiceView<CustomerPoliciesView, CustomerPoliciesViewModel>, ICustomerPoliciesViewService
    {
        public CustomerPoliciesViewService(DbContext context)
            :base(context)
        {

        }
    }
}
