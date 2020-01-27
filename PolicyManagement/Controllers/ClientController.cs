using PolicyManagement.Services.Interface;
using System.Web.Mvc;

namespace PolicyManagement.Controllers
{
    public class ClientController : Controller
    {
        private IClientService clientService;

        public ClientController(IClientService service)
        {
            clientService = service;  
        }
        // GET: Client
        [Authorize]
        public ActionResult Index()
        {
            var clients = clientService.GetAll();
            return View(clients);
        }

        // GET: Client/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            var client = clientService.GetId(id);
            return View(client);
        }

        // GET: Client/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // GET: Client/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var client = clientService.GetId(id);
            return View(client);
        }
    }
}
