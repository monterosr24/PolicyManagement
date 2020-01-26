using PolicyManagement.Models.ModelView;
using PolicyManagement.Services.Interface;
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
        private IPolicyService policyService;

        public PolicyController(IPolicyService service)
        {
            policyService = service;
        }
        // GET: Policy
        public ActionResult Index()
        {
            var policy =  policyService.GetAll();
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
