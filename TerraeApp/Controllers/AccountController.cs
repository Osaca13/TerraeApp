using Microsoft.AspNetCore.Mvc;
using TerraeApp.Models.Register;
using Microsoft.AspNetCore.Identity;
using Biblioteca.Modelo;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TerraeApp.Controllers
{
    public class AccountController : Controller
    {
        
        private readonly UserManager<AplicationUser> _userManager;
        private readonly SignInManager<AplicationUser> _signInManager;
        public AccountController(UserManager<AplicationUser> userManager, SignInManager<AplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            
        }

        

        [HttpGet]
        public IActionResult Register()
        {
            return View();
            //return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if(!ModelState.IsValid) return View("Comprobacion", register);
            if (ModelState.IsValid)
            {


                var user = new AplicationUser
                {
                    NombreUsuario = register.NombreUsuario,
                    UserName = register.NombreUsuario,
                    Email = register.NombreUsuario,
                    Contraseña = register.Contraseña
                };

                var result = await _userManager.CreateAsync(user);

                

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //foreach (var error in result.Errors)
                    //{
                    //    ModelState.AddModelError("", error.Description);

                    //}

                    return View("Comprobacion", register);
                       
                }
            }
                return View(register);



        }

        [HttpGet]
        public IActionResult Comprobacion()
        {
            return View();
        }
    }
}
