using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using parcelhubwebsite.Models; // Update this namespace according to your project's structure

namespace parcelhubwebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor to inject the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: /Home/Index
        public IActionResult Index()
        {
            return View(); // Return the Index view
        }

        // GET: /Home/Contact
        public IActionResult Contact()
        {
            return View(); // Return the Contact view
        }

        // This method handles errors and should return an Error view
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Pass the RequestId to the ErrorViewModel
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
