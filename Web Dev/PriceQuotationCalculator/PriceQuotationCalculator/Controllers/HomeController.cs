using Microsoft.AspNetCore.Mvc;
using PriceQuotationCalculator.Models;

namespace PriceQuotationCalculator.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Discount = 0;
			ViewBag.Total = 0;
			return View();
		}
		[HttpPost]
		public IActionResult Index(PriceQuotationModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.Discount = model.CalculateDiscountAmount();
				ViewBag.Total = model.CalculateTotal();
			}
			else
			{
				ViewBag.Discount = 0;
				ViewBag.Total = 0;
			}
			return View(model);
		}
	}
}