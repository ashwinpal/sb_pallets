﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using sb_pallets.Models;

namespace sb_pallets.Controllers
{
    public class PurchaseController : Controller
    {
        VendorClass vobj = new VendorClass();
        ItemClass iobj = new ItemClass();
        PurchaseClass pobj = new PurchaseClass();

        //
        // GET: /Purchase/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Purchase/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Purchase/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Purchase/Create

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
        // GET: /Purchase/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Purchase/Edit/5

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
        // GET: /Purchase/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Purchase/Delete/5

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

        public ActionResult AutocompleteVendor()
        {
            var options = iobj.getAllItemIds();

            // var options = new[] { "Apple", "Pineapple", "Banana"};

            return Json(options, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AutocompleteItem()
        {
            var options =new[] {1, 2, 12, 13};

            // var options = new[] { "Apple", "Pineapple", "Banana" };

            return Json(options, JsonRequestBehavior.AllowGet);

        }

        public ActionResult FindItem(int id)
        {
            return Json((Item_Detail)iobj.getItemById(id), JsonRequestBehavior.AllowGet);
        }
    }
}