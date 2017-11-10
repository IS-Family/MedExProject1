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

        // GET: license information
        public ActionResult License()
        {
            return View();
        }
    }
}