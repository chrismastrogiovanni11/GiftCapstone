using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChrisGiftCapstone.Controllers
{
    public class SubcategoriesController : Controller
    {
        // GET: Subcategories
        public ActionResult Index()
        {
            return View();
        }

        // GET: Subcategories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subcategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subcategories/Create
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

        // GET: Subcategories/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subcategories/Edit/5
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

        // GET: Subcategories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subcategories/Delete/5
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
