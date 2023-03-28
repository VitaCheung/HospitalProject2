using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalProject2.Controllers
{
    public class VolunteersController : Controller
    {
        // GET: Volunteers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Volunteers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Volunteers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Volunteers/Create
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

        // GET: Volunteers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Volunteers/Edit/5
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

        // GET: Volunteers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Volunteers/Delete/5
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
