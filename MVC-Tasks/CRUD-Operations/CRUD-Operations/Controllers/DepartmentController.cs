using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_Operations.Models;

namespace CRUD_Operations.Controllers
{
    public class DepartmentController : Controller
    {
        Context context = new Context();

        // GET: Department/Index
        public IActionResult Index()
        {
            var departments = context.Departments.ToList();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                context.Departments.Add(department);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public IActionResult Details(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null) return NotFound();
            return View(department);
        }

        public IActionResult Edit(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null) return NotFound();
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                context.Departments.Update(department);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        public IActionResult Delete(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null) return NotFound();
            return View(department);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var department = context.Departments.Find(id);
            if (department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult SearchById()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SearchById(int id)
        {
            var department = context.Departments.Find(id);
            if (department == null)
            {
                ViewBag.Message = "Department not found.";
                return View();
            }
            return View("Details", department);
        }
    }

}
