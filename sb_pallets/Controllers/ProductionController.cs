using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sb_pallets.Controllers
{
    public class ProductionController : Controller
    {
        //
        // GET: /Production/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Production/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Production/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Production/Create

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

        //
        // GET: /Production/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Production/Edit/5

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

        //
        // GET: /Production/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Production/Delete/5

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
