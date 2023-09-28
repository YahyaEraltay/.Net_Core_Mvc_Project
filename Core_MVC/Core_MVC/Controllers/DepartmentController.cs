using Core_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        Context db = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var values = db.Departments.ToList();

            return View(values);
        }
        [HttpGet]
        public IActionResult NewDep()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDep(Department p)
        {
            db.Departments.Add(p);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult DeleteDep(int id)
        {
            var delete = db.Departments.Find(id);
            db.Departments.Remove(delete);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult FetchDep(int id)
        {
            var fetch = db.Departments.Find(id);

            return View("FetchDep", fetch);
        }
        public IActionResult UpdateDep(Department p)
        {
            var dep = db.Departments.Find(p.DepartmentID);
            dep.DepartmentName = p.DepartmentName;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult DetEmp(int id)
        {
            var detail = db.Employees.Where(x => x.DepartmentID == id).ToList();
            var DepName = db.Departments.Where(x => x.DepartmentID == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.DepN = DepName;

            return View(detail);
        }
    }
}
