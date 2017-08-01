using mvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration newRegisrtation)
        {

            DBContext db = new DBContext();
            db.registration.Add(newRegisrtation);
            db.SaveChanges();
             
            return View();
        }
    }
}