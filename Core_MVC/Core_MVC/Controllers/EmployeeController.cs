using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Core_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        Context db = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var values = db.Employees.Include(x => x.Department).ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult NewEmp()
        {
            List<SelectListItem> values = (from x in db.Departments.ToList() select new SelectListItem { Text = x.DepartmentName, Value = x.DepartmentID.ToString() }).ToList();
            ViewBag.vls = values;

            return View();
        }
        [HttpPost]
        public IActionResult NewEmp(Employee p)
        {
            var emp = db.Departments.Where(x => x.DepartmentID == p.Department.DepartmentID).FirstOrDefault();
            p.Department = emp;
            db.Employees.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmp(int id)
        {
            var emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult FetchEmp(int id)
        {
            var emp = db.Employees.Find(id);
            var dep = db.Departments.ToList();
            ViewBag.dep = new SelectList(dep, "DepartmentID", "DepartmentName", id);

            return View("FetchEmp", emp);
        }
        [HttpPost]
        public IActionResult UpdateEmp(Employee p)
        {
            var emp = db.Employees.Find(p.EmployeeID);
            emp.EmployeeName = p.EmployeeName;
            emp.EmployeeSurname = p.EmployeeSurname;
            emp.EmployeeCity = p.EmployeeCity;
            //emp.Department.DepartmentID = p.DepartmentID;
            emp.DepartmentID = p.Department.DepartmentID;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
