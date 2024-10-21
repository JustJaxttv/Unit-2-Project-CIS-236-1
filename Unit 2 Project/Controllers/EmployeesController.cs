using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Unit_2_Project.Models;

namespace Unit_2_Project.Controllers
{
    // Controller to manage actions
    public class EmployeesController : Controller
    {
        // Injection for DbContext
        private EmployeeDBContext context { get; set; }

        // Accepts DbContext
        public EmployeesController(EmployeeDBContext context)
        {
            this.context = context;
        }

        // Retrievs list of employees from database
        public IActionResult Index()
        {
            var employees = context.Employees.OrderBy(c => c.Id).ToList();
            return View(employees);
        }
    }
}
