using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedExProject.Controllers
{
    public class DoctorController : Controller
    {
        // GET: personal information
        public ActionResult Personal()
        {
            return View();
        }

        [HttpPost]
        public String enterData(FormCollection form)
        {
            ViewBag.fName = form["First Name"].ToString();
            ViewBag.lName = form["Last Name"].ToString();
            ViewBag.phone = form["Phone Number"].ToString();
            ViewBag.email = form["Email"].ToString();
            return "Signing in : " + ViewBag.email;
        }

        // GET: license information
        public ActionResult License()
        {
            return View();
        }
    }
}