using CRUD_Operations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Operations.Controllers
{
    public class EmployeeController : Controller
    {
        public Context context = new Context();

        public IActionResult Index()
        {
            var employees = context.Employees.ToList();
            return View(employees);
        }

        public IActionResult SearchById()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SearchById(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null)
            {
                ViewBag.Message = "Employee not found.";
                return View();
            }
            return View("Details", employee);
        }

        public IActionResult Details(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        public IActionResult Edit(int id)
        {
            var employee = context.Employees.Find(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                context.Employees.Update(employee);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }


    }
}
