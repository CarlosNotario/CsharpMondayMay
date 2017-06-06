using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HogWarsh.Models;

namespace HogWarsh.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ActionResult Enroll()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActuallyEnroll(Student student)
        {
            return View();
        }
    }
}