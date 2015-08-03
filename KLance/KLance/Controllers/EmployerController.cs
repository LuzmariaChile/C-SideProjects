using KLance.Models;
using KLance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KLance.Controllers
{
    public class EmployerController : Controller
    {
        KLanceDbContainer db = new KLanceDbContainer(); // creating a reference to our database 
        //it's global to the class

        // GET: Employer
        public ActionResult Index()
        {
            var employers = from p in db.People
                            join e in db.Employers
                            on p.SSN equals e.SSN
                            select p; //this query will not execute until it is called

            return View(employers); //query will not execute until this line when View calls the variable
        }

        // GET: Employer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employer/Create
        public ActionResult Create()
        {
            //var person = new Person();
            //person.StateList = new SelectList(Helper.State);

            //return View(person);
            var viewModel = new EmployerViewModel()
            {
                Employer = new Employer(),
                Person = new Person(),
                Register = new RegisterViewModel()
            };
            return View(viewModel); 
        }

        // POST: Employer/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                
                db.People.Add(person);
                var employer = new Employer { SSN = person.SSN, Person = person }; // create a new employer with same SSN as person and establish relationship with Person//

                db.Employers.Add(employer);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employer/Edit/5
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

        // GET: Employer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employer/Delete/5
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
