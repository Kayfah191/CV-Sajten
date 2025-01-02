using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CV_Sajten.Models;
using Microsoft.EntityFrameworkCore;

namespace CV_Sajten.Controllers
{
    public class AccountController : Controller
    {

        private DatabasContext _context;
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private Anvandare anvandare;
        public AccountController(UserManager<User> userMngr,
        SignInManager<User> signInMngr, DatabasContext context)
        {
            this.userManager = userMngr;
            this.signInManager = signInMngr;
            this._context = context;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Registrering registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User anvandare = new User();
                anvandare.UserName = registerViewModel.AnvandarNamn;
                var result =
                await userManager.CreateAsync(anvandare, registerViewModel.Losenord);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(anvandare, isPersistent: true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(registerViewModel);
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            Inlog loginViewModel = new Inlog();
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(Inlog loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                loginViewModel.AnvandarNamn,
                loginViewModel.Losenord,
                isPersistent: loginViewModel.RememberMe,
                lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Fel användarnam/lösenord.");
                }
            }
            return View(loginViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public async Task<IActionResult> Profilss(int id)
        {

            Console.WriteLine($"Profilmetod anropad med id: {id}");

            var cv = await _context.Cvs.FirstOrDefaultAsync(c => c.Id == id);

            if (cv == null)
            {
                return NotFound();
            }

            return View(cv);
        }

        [HttpGet]
        public async Task<IActionResult> Profil(int id)
        {
            
            var cv = await _context.Cvs
                                   .FirstOrDefaultAsync(c => c.Id == id); 

            Console.WriteLine($"CV för användare: {cv?.Id}");

            if (cv == null)
            {
                return NotFound();
            }

            var anvandare = await _context.Anvandares
                                           .FirstOrDefaultAsync(u => u.ID == cv.AnvandareID);

            Console.WriteLine($"Anvandare som hittades: {anvandare?.Namn}");

            if (anvandare == null)
            {
                return NotFound();
            }

            
            var model = new ProfilViewModel
            {
                Anvandare = anvandare,
                Cv = cv
            };

            return View(model);
        }
    }
    }
