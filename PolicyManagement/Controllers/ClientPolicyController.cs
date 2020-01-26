using PolicyManagement.Services.Interface;
using System.Web.Mvc;

namespace PolicyManagement.Controllers
{
    public class ClientPolicyController : Controller
    {
        private IClientPolicyViewService clientPolicyViewService;

        public ClientPolicyController(IClientPolicyViewService service)
        {
            clientPolicyViewService = service;
        }

        // GET: ClientPolicy
        public ActionResult ClientPolicy(int id)
        {
            var result = clientPolicyViewService.Get(x => x.ClientId == id);
            return View(result);
        }
        
    }
}
