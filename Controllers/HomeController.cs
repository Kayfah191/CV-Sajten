using System.Diagnostics;
using CV_Sajten.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Sajten.Controllers
{
    public class HomeController : Controller


    {

        private DatabasContext anvandare;
        public HomeController(DatabasContext AnvandareService)
        {
            anvandare = AnvandareService;
        }


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DatabasContext service)
        {
            _logger = logger;
            anvandare = service;
        }

        public IActionResult Index()
        {
            return View();
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
