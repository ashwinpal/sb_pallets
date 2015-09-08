using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using sb_pallets.Models;

namespace sb_pallets.Controllers
{
    public class VendorController : Controller
    {

        VendorClass vendorObj = new VendorClass();

        //
        // GET: /Vendor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Vendor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vendor/Create

        public ActionResult Create()
        {
            Vendor_Detail lastVendor = vendorObj.getLastItem();

            if (lastVendor != null)
                ViewBag.vendorId = lastVendor.vendor_id + 1;
            else
                ViewBag.vendorId = 1;

            return View();
        }

        //
        // POST: /Vendor/Create

        [HttpPost]
        public ActionResult Create(Vendor_Detail newVendor, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                newVendor.vendor_address = collection["vendor_address"];

                vendorObj.addItem(newVendor);

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vendor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vendor/Edit/5

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
        // GET: /Vendor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vendor/Delete/5

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
