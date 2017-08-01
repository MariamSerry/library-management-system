using mvc2.core;
using mvc2.Model1;
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
           Userserver _userService = new Userserver();
            _userService.Add(newRegisrtation);
           
             
            return View();
        }
    }
}