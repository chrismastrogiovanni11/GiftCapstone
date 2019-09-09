using ChrisGiftCapstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChrisGiftCapstone.Controllers
{
    public class GiftEventsController : Controller
    {
        ApplicationDbContext DbContext;
        public GiftEventsController()
        {
            DbContext = new ApplicationDbContext();
        }
        // GET: GiftEvents
        public ActionResult Index()
        {
            var events = DbContext.GiftEvents.ToList();
            return View(events);
        }

        // GET: GiftEvents/Details/5
        public ActionResult Details(int id)
        {
            var events = DbContext.GiftEvents.Where(e => e.Id == id).Single();
            return View(events);
        }

        // GET: GiftEvents/Create
        public ActionResult Create()
        {
            GiftEvent giftEvent = new GiftEvent();
            return View(giftEvent);
        }

        // POST: GiftEvents/Create
        [HttpPost]
        public ActionResult Create(GiftEvent giftEvent)
        {

            // TODO: Add insert logic here
                DbContext.GiftEvents.Add(giftEvent);
                DbContext.SaveChanges();
                return RedirectToAction("Index");
  

        }

        // GET: GiftEvents/Edit/5
        public ActionResult Edit(int id)
        {
            var events = DbContext.GiftEvents.Where(e => e.Id == id).Single();
            return View();
        }

        // POST: GiftEvents/Edit/5
        [HttpPost]
        public ActionResult Edit(GiftEvent giftEvent)
        {

            // TODO: Add update logic here
                var giftEventContext = DbContext.GiftEvents.Single(g => g.Id == giftEvent.Id);
                giftEventContext.EventName = giftEvent.EventName;
                giftEventContext.EventDate = giftEvent.EventDate;
                DbContext.SaveChanges();
                return RedirectToAction("Index");


        }

        // GET: GiftEvents/Delete/5
        public ActionResult Delete(int id)
        {
            var giftEvent = DbContext.GiftEvents.Where(e => e.Id == id).FirstOrDefault();
            return View(giftEvent);
        }

        // POST: GiftEvents/Delete/5
        [HttpPost]
        public ActionResult Delete(GiftEvent giftEvent)
        {

            // TODO: Add delete logic here
                giftEvent = DbContext.GiftEvents.Where(e => e.Id == giftEvent.Id).SingleOrDefault();
                DbContext.GiftEvents.Remove(giftEvent);
                return RedirectToAction("Index");


        }
    }
}
