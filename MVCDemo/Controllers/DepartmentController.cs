using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    
    public class DepartmentController : Controller
    {
        SampleEntities2 db = new SampleEntities2();
        // GET: Department
        public ActionResult Department()
        {
            List<tblDepartment> departments = db.tblDepartment.ToList();
            return View(departments);
        }
        public ActionResult Names()
        {
            List<tblDepartment> departments = db.tblDepartment.ToList();
            return View(departments);
        }


        
      


    }
}