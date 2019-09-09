using ChrisGiftCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ChrisGiftCapstone.Controllers
{
    public class GiftGetterController : Controller
    {
        private ApplicationDbContext DbContext;

        public GiftGetterController()
        {
            DbContext = new ApplicationDbContext();
        }

        // GET: Users
        public ActionResult Index()
        {
            var giftGetter = DbContext.GiftGetters.Include(p => p.Giftee).ToList();
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            var user = DbContext.GiftGetters.Where(u => u.Id == id).Single();
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            var user = new GiftGetter();
            return View(user);
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(GiftGetter giftGetter)
        {

                DbContext.GiftGetters.Add(giftGetter);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
      
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            var getter = DbContext.GiftGetters.Where(g => g.Id == id).Single();
            return View(getter);
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(GiftGetter giftGetter)
        {

            // TODO: Add update logic here
            var purchaser = DbContext.GiftGetters.Where(p => p.Id == giftGetter.Id).Single();
                return RedirectToAction("Index");


        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            var getter = DbContext.GiftGetters.Where(g => g.Id == id).SingleOrDefault();
            return View(getter);
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(GiftGetter giftGetter)
        {

            // TODO: Add delete logic here
            var purchaser = DbContext.GiftGetters.Where(g => g.Id == giftGetter.Id).FirstOrDefault();
            DbContext.GiftGetters.Remove(purchaser);
            DbContext.SaveChanges();
                return RedirectToAction("Index");

        }
    }
}
