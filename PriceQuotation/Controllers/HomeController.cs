using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;
using System.Diagnostics;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Discount = 0;
            ViewBag.TotalCost = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Discount = model.CalculateDiscount();
                ViewBag.TotalCost = model.CalculateTotalCost();
            }
            else
            {
                ViewBag.Discount = 0;
                ViewBag.TotalCost = 0;
            }
            return View(model);
        }
    }
}