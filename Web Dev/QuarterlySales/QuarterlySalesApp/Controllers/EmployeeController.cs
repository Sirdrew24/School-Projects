using Microsoft.AspNetCore.Mvc;
using QuarterlySalesApp.Models;

namespace QuarterlySalesApp.Controllers
{
    public class EmployeeController : Controller
    {
        private SalesContext context { get; set; }
        public EmployeeController(SalesContext ctx) => context = ctx;
        
        public IActionResult Index() => RedirectToAction("Index", "Home");

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Employees = context.Employees.OrderBy(e => e.Firstname).ToList();
            return View();
        }
    }
}
