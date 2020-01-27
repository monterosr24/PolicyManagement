using PolicyManagement.Services.Interface;
using System.Web.Mvc;

namespace PolicyManagement.Controllers
{
    public class CustomerPoliciesViewController : Controller
    {
        private ICustomerPoliciesViewService clientPolicyViewService;

        public CustomerPoliciesViewController(ICustomerPoliciesViewService service)
        {
            clientPolicyViewService = service;

        }

        // GET: ClientPolicy
        [Authorize]
        public ActionResult Index(int id)
        {
            var result = clientPolicyViewService.Get(x => x.ClientId == id);
            return View(result);
        }
        
    }
}
