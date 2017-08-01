using mvc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class LOGINController : Controller
    {
        // GET: LOGIN
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName, string Password)
        {
          
            DBContext db = new DBContext();

            if (UserName == "Admin" && Password == "1121997")
            {

            }
            else
            {
                login existUser = db.login2.FirstOrDefault(a => a.Password == Password && a.UserName == UserName);
                if (existUser != null)
                {
                    return RedirectToAction("Index", "Profile");
                }
                else
                {

                }
            }
            return View();
        }
        // GET: LOGIN/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LOGIN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LOGIN/Create
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

        // GET: LOGIN/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LOGIN/Edit/5
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

        // GET: LOGIN/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LOGIN/Delete/5
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
