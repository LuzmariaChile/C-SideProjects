using KLance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KLance.Controllers
{
    public class JobSeekerController : Controller
    {
        KLanceDbContainer db = new KLanceDbContainer();
        // GET: JobSeeker
        public ActionResult Index()
        {
            var jobseekers = from p in db.People
                            join js in db.JobSeekers
                            on p.SSN equals js.SSN
                            select p; //this query will not execute until it is called

            return View(jobseekers);
        }

        // GET: JobSeeker/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JobSeeker/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobSeeker/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here
  
                db.People.Add(person);
                var jobSeeker = new JobSeeker {SSN = person.SSN, Person= person};

                db.JobSeekers.Add(jobSeeker);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JobSeeker/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JobSeeker/Edit/5
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

        // GET: JobSeeker/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JobSeeker/Delete/5
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
