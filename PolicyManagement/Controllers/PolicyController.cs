using PolicyManagement.Models.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PolicyManagement.Controllers
{
    public class PolicyController : Controller
    {
        // GET: Policy
        public ActionResult Index()
        {
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:49995/api/policy/").Result;
            var policy = response.Content.ReadAsAsync<IEnumerable<PolicyViewModel>>().Result;
            return View(policy);
        }

        // GET: Policy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Policy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Policy/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Policy/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Policy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Policy/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
