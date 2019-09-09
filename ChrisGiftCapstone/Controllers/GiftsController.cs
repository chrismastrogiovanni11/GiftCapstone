using ChrisGiftCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChrisGiftCapstone.Controllers
{

    public class GiftsController : Controller
    {
        ApplicationDbContext DbContext;

        public GiftsController()
        {
            DbContext = new ApplicationDbContext();
        }
        // GET: Gifts
        public ActionResult Index()
        {
            return View();
        }

        // GET: Gifts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Gifts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Gifts/Create
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

        // GET: Gifts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Gifts/Edit/5
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

        // GET: Gifts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Gifts/Delete/5
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
