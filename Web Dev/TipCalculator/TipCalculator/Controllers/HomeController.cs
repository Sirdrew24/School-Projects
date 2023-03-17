using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Percent15 = 0;
			ViewBag.Percent20 = 0;
			ViewBag.Percent25 = 0;
			return View();
		}
		[HttpPost]
		public IActionResult Index(TipCalculatorModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.Percent15 = model.Percent15Tip();
				ViewBag.Percent20 = model.Percent20Tip();
				ViewBag.Percent25 = model.Percent25Tip();

			}
			else
			{
				ViewBag.Percent15 = 0;
				ViewBag.Percent20 = 0;
				ViewBag.Percent25 = 0;
			}
			return View(model);
		}
	}
}