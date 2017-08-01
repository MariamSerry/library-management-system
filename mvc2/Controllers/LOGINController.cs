using mvc2.core;
using mvc2.Model1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class LOGINController : Controller
    {
       public Userserver _userService = new Userserver();
        // GET: LOGIN;
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName, string Password)
        {
            bool isVerified = _userService.Check(UserName, Password);

            if (isVerified==true)
            {
                return RedirectToAction("Index", "Profile");
            }
            else
            {
                return RedirectToAction("Index", "Registration");
            }
           

           
            return View();
        }
        // GET: LOGIN/Details/5
      
    }
}
