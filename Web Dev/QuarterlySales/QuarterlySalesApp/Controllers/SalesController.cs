using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuarterlySalesApp.Models;

namespace QuarterlySalesApp.Controllers
{
    public class SalesController : Controller
    {
        private readonly SalesContext context;

        public SalesController(SalesContext context)
        {
            context = context;
        }

        public IActionResult Index(int? employeeId)
        {
            var sales = context.Sales.Include(s => s.Employee);

            if (employeeId != null)
            {
                sales = (Microsoft.EntityFrameworkCore.Query.IIncludableQueryable<Sales, Employee>)sales.Where(s => s.EmployeeId == employeeId);
            }

            ViewBag.Employees = context.Employees.ToList();

            return View(sales.ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Employees = context.Employees.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Sales sales)
        {
            if (ModelState.IsValid)
            {
                if (context.Sales.Any(s => s.Quarter == sales.Quarter &&
                                            s.Year == sales.Year &&
                                            s.EmployeeId == sales.EmployeeId))
                {
                    ModelState.AddModelError("SalesExists", "Sales data for the same quarter, year, and employee already exists.");
                    ViewBag.Employees = context.Employees.ToList();
                    return View(sales);
                }

                context.Sales.Add(sales);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Employees = context.Employees.ToList();
            return View(sales);
        }
    }
}
