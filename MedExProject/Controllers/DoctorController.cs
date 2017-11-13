using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedExProject.Controllers
{
    public class DoctorController : Controller
    {
        List<List<String>> initialList = new List<List<String>>();
        int Index = 0;
        // GET: personal information
        public ActionResult Personal()
        {
            return View();
        }

        [HttpPost]
        public List<List<String>> enterData(FormCollection form)
        {
            List<String> DoctorInfoList = new List<String>();
            DoctorInfoList.Add(form["First Name"].ToString());
            DoctorInfoList.Add(form["Last Name"].ToString());
            DoctorInfoList.Add(form["Phone Number"].ToString());
            DoctorInfoList.Add(form["Email"].ToString());
            initialList.Add(DoctorInfoList);

            return initialList;
        }

        // GET: license information
        public ActionResult License()
        {
            return View();
        }

        // GET: post information
        public ActionResult ViewInfo()
        {
            return View();
        }

    }
}