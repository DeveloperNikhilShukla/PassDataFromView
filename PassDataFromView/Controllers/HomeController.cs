using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PassDataFromView.Models;
using PassDataFromView.Controllers;

namespace PassDataFromView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult ReciveDataUsingStrongBind(StudentInformation _StudentInformation)
        {
            ViewData["myEntry"] = "your name is ='" + _StudentInformation.name + "'  your collage is ='" + _StudentInformation.Collage + "'   your age is ='" + _StudentInformation.age + "'";
            TempData["myEntry"] = ViewData["myEntry"];
            return View("index");
        }


        [HttpPost]
        public ActionResult ReciveDataUsingParameaters(string name,string collage,string age)
        {
            ViewData["myEntry"] = "your name is ='" + name + "'  your collage is ='" + collage + "'   your age is ='" + age + "'";
            TempData["myEntry"] = ViewData["myEntry"];
            return View("index");
        }


        [HttpPost]
        public ActionResult PostDataUsingRequest()
        {

            string name= Request["name"];
            string collage = Request["collage"];
            string age = Request["age"];

            ViewData["myEntry"] = "your name is ='" + name + "'  your collage is ='" + collage + "'   your age is ='" + age + "'";
            TempData["myEntry"] = ViewData["myEntry"];

            return View("index");
        }


        [HttpPost]
        public ActionResult postdatausingformcollection(FormCollection from)
        {

            string name = from["name"];
            string collage = from["collage"];
            string age = from["age"];

            ViewData["myEntry"] = "your name is ='" + name + "'  your collage is ='" + collage + "'   your age is ='" + age + "'";
            TempData["myEntry"] = ViewData["myEntry"];

            return View("index");
        }


        public ActionResult postdatausinggetmethd(FormCollection from)
        {

            string name = from["name"];
            string collage = from["collage"];
            string age = from["age"];

            ViewData["myEntry"] = "your name is ='" + name + "'  your collage is ='" + collage + "'   your age is ='" + age + "'";
            TempData["myEntry"] = ViewData["myEntry"];

            return View("index");
        }

    }
}