using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        //public string Index1(int id )
        //{
        //   //Read query strin from URL >>>> localhost:1245 / Home / index / 1 ? name = Eslam  مثال يقرأ
        //    //return "Hey " + Request.QueryString["name"] + " Your Id = " + id;

        //    return "Hey " + Request.QueryString["name"] + " Your Id = " + id;

        //}
        public ActionResult Index1()
        {
            List<string> countries = new List<string>()
            {
                "Egypt","Frensh","American","Soudia","Lebnan","Gazaer"
            };
            ViewBag.countries = countries;
            return View(ViewBag.countries);
        }

    }
}