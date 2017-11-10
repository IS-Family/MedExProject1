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
            String fName = form["Email address"].ToString();
            String lName = form["Email address"].ToString();
            String  phoneNumber = form["Email address"].ToString();
            String email = form["Email address"].ToString();
            return "Signing in : " + email;
        }

        // GET: license information
        public ActionResult License()
        {
            return View();
        }
    }
}