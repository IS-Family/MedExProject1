using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedExProject.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Personal()
        {
            return View();
        }

        // GET: Doctor
        public ActionResult License()
        {
            return View();
        }
    }
}