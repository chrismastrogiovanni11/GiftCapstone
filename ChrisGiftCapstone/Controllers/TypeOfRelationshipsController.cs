﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChrisGiftCapstone.Controllers
{
    public class TypeOfRelationshipsController : Controller
    {
        // GET: TypeOfRelationships
        public ActionResult Index()
        {
            return View();
        }

        // GET: TypeOfRelationships/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TypeOfRelationships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeOfRelationships/Create
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

        // GET: TypeOfRelationships/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TypeOfRelationships/Edit/5
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

        // GET: TypeOfRelationships/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TypeOfRelationships/Delete/5
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
