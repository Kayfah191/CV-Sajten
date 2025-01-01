using System.Diagnostics;
using CV_Sajten.Models;
using Microsoft.AspNetCore.Mvc;

namespace CV_Sajten.Controllers
{
    public class HomeController : Controller


    {

        
        private DatabasContext cv;


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DatabasContext AnvandareService)
        {
            _logger = logger;
            cv = AnvandareService;
        }

        public IActionResult Index()
        {
            IQueryable<Cv> cvList = from cv in cv.Cvs select cv;
            
            return View(cvList.ToList());
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
