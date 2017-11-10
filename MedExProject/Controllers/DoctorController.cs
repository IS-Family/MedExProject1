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
            String fName = form["First Name"].ToString();
            String lName = form["Last Name"].ToString();
            String  telephone = form["Telephone"].ToString();
            String email = form["Email"].ToString();
            return "Signing in : " + email;
        }

        // GET: license information
        public ActionResult License()
        {
            return View();
        }
    }
}