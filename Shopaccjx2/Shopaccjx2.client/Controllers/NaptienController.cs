using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shopaccjx2.client.Controllers
{
    public class NaptienController : Controller
    {
        // GET: Naptien
        public ActionResult Index()
        {
            return View();
        }

        // GET: Naptien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Naptien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Naptien/Create
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

        // GET: Naptien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Naptien/Edit/5
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

        // GET: Naptien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Naptien/Delete/5
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
