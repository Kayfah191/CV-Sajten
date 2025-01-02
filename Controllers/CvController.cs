
using CV_Sajten.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;



namespace CV_Sajten.Controllers
{
    public class CvController:Controller
    {
        private DatabasContext cvs;
    
      public CvController(DatabasContext service)
        {
            cvs = service;
        }

        //[Authorize] vet ej, varför det inte funkar 

        [HttpGet]
        public IActionResult Add()

        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            Cv cv = new Cv();
            List<SelectListItem> anvandares = cvs.Anvandares.Select
                (x => new SelectListItem { Text = x.Namn, Value = x.ID.ToString() }).ToList();
            ViewBag.options = anvandares;
            Console.WriteLine("Returning LäggTill view");
            return View("LäggTill",cv);
        }

        [HttpPost]
        public IActionResult Add(Cv cv)
        {
            if (ModelState.IsValid)
            {
                cvs.Add(cv);
                cvs.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                List<SelectListItem> anvandares = cvs.Anvandares.Select
                (x => new SelectListItem { Text = x.Namn, Value = x.ID.ToString() }).ToList();
                ViewBag.options = anvandares;
                return View("LäggTill",cv);
            }

        }

        [Authorize]
        [HttpGet]
        public IActionResult Remove(string id)
        {
            Cv cv = cvs.Cvs.Find(id);
            return View(cv);
        }

        [HttpPost]
        public IActionResult Remove(Cv cv)
        {
            cvs.Remove(cv);
            cvs.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}


