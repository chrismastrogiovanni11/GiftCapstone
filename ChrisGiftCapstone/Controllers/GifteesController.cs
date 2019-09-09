using ChrisGiftCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ChrisGiftCapstone.Controllers
{
    public class GifteesController : Controller
    {
        private ApplicationDbContext DbContext;
        public GifteesController()
        {
            DbContext = new ApplicationDbContext();
        }
        // GET: Giftees
        public ActionResult Index()
        {
            var giftee = DbContext.Giftees.Include(g => g.Category).Include(k => k.LengthOfRelationship).Include(p => p.Age).Include(j => j.FirstName).Include(h => h.LastName).Include(f => f.TypeOfRelationship).ToList();
            return View();
        }

        // GET: Giftees/Details/5
        public ActionResult Details(int id)
        {
            var giftee = DbContext.Giftees.Include(g => g.Category).Include(k => k.LengthOfRelationship).Include(p => p.Age).Include(j => j.FirstName).Include(h => h.LastName).Include(f => f.TypeOfRelationship).Where(l => l.Id == id);
            return View(giftee);
        }

        // GET: Giftees/Create
        public ActionResult Create()
        {
            Giftee giftee = new Giftee();
            return View(giftee);
        }

        // POST: Giftees/Create
        [HttpPost]
        public ActionResult Create(Giftee giftee)
        {

            // TODO: Add insert logic here
            DbContext.Giftees.Add(giftee);
            DbContext.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Giftees/Edit/5
        public ActionResult Edit(int id)
        {
            var giftee = DbContext.Giftees.Where(g => g.Id == id).Single();
            return View(giftee);
        }

        // POST: Giftees/Edit/5
        [HttpPost]
        public ActionResult Edit(Giftee giftee)
        {
            var GifteeInDB = DbContext.Giftees.Single(g => g.Id == giftee.Id);
            GifteeInDB.LengthOfRelationshipId = giftee.LengthOfRelationshipId;
            GifteeInDB.LengthOfRelationship = giftee.LengthOfRelationship;
            GifteeInDB.TypeOfRelationship = giftee.TypeOfRelationship;
            GifteeInDB.TypeOfRelationshipId = giftee.TypeOfRelationshipId;
            GifteeInDB.Age = giftee.Age;
            GifteeInDB.FirstName = giftee.FirstName;
            GifteeInDB.LastName = giftee.LastName;
            GifteeInDB.CategoryId = giftee.CategoryId;
            GifteeInDB.Category = giftee.Category;
                DbContext.SaveChanges();
                return RedirectToAction("Index");
        }

        // GET: Giftees/Delete/5
        public ActionResult Delete(int id)
        {
            var giftee = DbContext.Giftees.Where(g => g.Id == id).SingleOrDefault();
            return View(giftee);
        }

        // POST: Giftees/Delete/5
        [HttpPost]
        public ActionResult Delete(Giftee giftee)
        {

            var giftGetter = DbContext.Giftees.Where(g => g.Id == giftee.Id).FirstOrDefault();
            DbContext.Giftees.Remove(giftGetter);
            DbContext.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
