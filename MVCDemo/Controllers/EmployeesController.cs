using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeesController : Controller
    {
        SampleEntities2 db = new SampleEntities2();
        // GET: Employees
        public ActionResult Index(int departmentId)
        {
            List<tblEmployee> employees = db.tblEmployee.Where(emp=>emp.DepartmentId==departmentId).ToList();
            return View(employees);
        }

        public ActionResult Details()
        {
            //ViewBag.emp = db.tableEmployee.ToList();  طريقة اولي 
            List<tblEmployee> employees = db.tblEmployee.ToList();
            return View(employees); 
        }

        public ActionResult Search(int id=1)
        {
            var emp = db.tblEmployee.Find(id);
            //ViewBag.emp = db.tblEmployee.Single(emp => emp.EmloyeeId == id);
            return View(emp);
        }

        public ActionResult Details2()
        {
            //ViewBag.emp = db.tableEmployee.ToList();  طريقة اولي 

            List<tblEmployee> employees = db.tblEmployee.ToList();
            return View(employees);
        }


        //******Create********
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblEmployee e)
        {
            //tblEmployee e = new tblEmployee();
            //e.Name = f["Name"];
            //e.Gender = f["Gender"];
            //e.City = f["City"];
            //e.Gender = f["DepartmentId"];
            db.tblEmployee.Add(e);
            db.SaveChanges();
            return RedirectToAction("Details","Employees");
        }


        //*******Update*********
        [HttpGet]
        public ActionResult Edit(int id)
        {
            
            var emp =db.tblEmployee.Find(id);
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(tblEmployee e)
        {
            //var olddata = db.tblEmployee.Find(e.EmloyeeId);
            //olddata.Name = e.Name;
            //olddata.Gender = e.Gender;
            //olddata.City = e.City;
            //olddata.DepartmentId = e.DepartmentId;

            db.Entry(e).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("Details", "Employees");
        }

        //********Delete*******
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var emp = db.tblEmployee.Find(id);
            return View(emp);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult delete(int id)
        {
            var emp = db.tblEmployee.Find(id);
            db.tblEmployee.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Details", "Employees");
        }




    }
}