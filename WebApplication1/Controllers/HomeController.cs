using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public IActionResult Index()
        {
            // Initialize a new PriceQuotationModel instance
            var model = new PriceQuotationModel();
            // Return the Index view with the model
            return View(model);
        }

        // POST: Home/Calculate
        [HttpPost]
        public IActionResult Calculate(PriceQuotationModel model)
        {
            // Check if the model state is valid
            if (ModelState.IsValid)
            {
                // Return the Index view with the model if valid
                return View("Index", model);
            }
            // Return the Index view with the model if not valid
            return View("Index", model);
        }

        // GET: Home/Clear
        public IActionResult Clear()
        {
            // Initialize a new PriceQuotationModel instance
            var model = new PriceQuotationModel();
            // Return the Index view with the model
            return View("Index", model);
        }
    }
}
