using PolicyManagement.Services.Interface;
using System.Web.Mvc;

namespace PolicyManagement.Controllers
{
    public class PolicyController : Controller
    {
        private IPolicyService policyService;

        public PolicyController(IPolicyService service)
        {
            policyService = service;
        }
        // GET: Policy
        public ActionResult Index()
        {
            var policies =  policyService.GetAll();
            return View(policies);
        }

        // GET: Policy/Details/5
        public ActionResult Details(int id)
        {
            var policy = policyService.GetId(id);
            return View(policy);
        }

        // GET: Policy/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // GET: Policy/Edit/5
        public ActionResult Edit(int id)
        {
            var policy = policyService.GetId(id);
            return View(policy);
        }
    }
}
