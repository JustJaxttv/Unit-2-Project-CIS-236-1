using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_2_Project.Models;

namespace Unit_2_Project.Controllers
{
    // Controller to manage actions
    public class HomeController : Controller
    {
        // Injection for DbContext
        private EmployeeDBContext context { get; set; }

        // Accepts DbContext
        public HomeController(EmployeeDBContext context)
        {
            this.context = context;
        }

        // Retrievs list of employees from database
        public IActionResult Index()
        {
            var employees = context.Employees.OrderBy(c => c.Id).ToList();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Employee());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var employee = context.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Id == 0) context.Employees.Add(employee);
                else
                    context.Employees.Update(employee);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (employee.Id == 0) ? "Add" : "Edit";
                return View(employee);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var employee = context.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            context.Employees.Remove(employee); context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
