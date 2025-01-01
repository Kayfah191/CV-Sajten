using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CV_Sajten.Models;

namespace CV_Sajten.Controllers
{
    public class KontoController : Controller
    {
        private UserManager<Anvandare> anvandareManager;
        private SignInManager<Anvandare> signInManager;

        public KontoController(UserManager<Anvandare> anvandareMngr, SignInManager<Anvandare> signInMngr)
        {
            this.anvandareManager = anvandareMngr;
            this.signInManager = signInMngr;
        }

        [HttpGet]
        public IActionResult Registrera()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrera(Registrera registreraModel)
        {
            if (ModelState.IsValid)
            {
                Anvandare anvandare = new Anvandare();
                anvandare.Namn = registreraModel.AnvandarNamn;

                var resultat = await anvandareManager.CreateAsync(anvandare, registreraModel.Losenord);
                if (resultat.Succeeded)
                {
                    await signInManager.SignInAsync(anvandare, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var fel in resultat.Errors)
                    {
                        ModelState.AddModelError("", fel.Description);
                    }
                }
            }
            return View(registreraModel);
        }

        [HttpGet]
        public IActionResult LoggaIn()
        {
            Inlogg loginViewModel = new Inlogg();
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LoggaIn(Inlogg inloggModel)
        {
            if (ModelState.IsValid)
            {
                var resultat = await signInManager.PasswordSignInAsync(
                    inloggModel.AnvandarNamn,
                    inloggModel.Losenord,
                    isPersistent: inloggModel.RememberMe,
                    lockoutOnFailure: false);

                if (resultat.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Fel användarnamn eller lösenord.");
                }
            }
            return View(inloggModel);
        }

        [HttpPost]
        public async Task<IActionResult> LoggaUt()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }


}
