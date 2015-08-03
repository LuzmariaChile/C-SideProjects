using KLance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KLance.ViewModels
{
    public class EmployerViewModel
    {
        public Employer Employer { get; set; }
        public Person Person { get; set; }
        public RegisterViewModel Register { get; set; }

        //KLanceDbContainer db = new KLanceDbContainer(); // creating a reference to our database 
        ////it's global to the class

        //public void AddEmployer(EmployerViewModel employer) //parameters are local to the method employers is lower case
        //{
        //    db.People.Add(employer.Person);
        //    var emp = new Employer{SSN = employer.Person.SSN, Person = employer.Person};
        //    db.Employers.Add(emp);
        //    //Add to the users table when we have the table created
        //    db.SaveChanges();
        //}
    }
}