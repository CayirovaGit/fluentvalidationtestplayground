using System.Diagnostics;
using fluentvalidationtestplayground.Dtos.Customer;
using fluentvalidationtestplayground.Models;
using fluentvalidationtestplayground.Validators.Customer;
using Microsoft.AspNetCore.Mvc;

namespace fluentvalidationtestplayground.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult Index(CreateCustomerDto dto)
        {
            if(!ModelState.IsValid)
            {
                // Validation failed, return the view with validation messages
                return View(dto);
            }
            return RedirectToAction("Privacy"); //or do something else
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
