
using System.Threading.Tasks;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TerraeApp.Models.Members;
using System.Web;
using Microsoft.Extensions.Logging;
using TerraeApp.Models.Register;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TerraeApp.Controllers
{
    public class MembersHomeController : Controller
    {
        private string Identidad;
        //private readonly ILogger<AplicationUser> _logger;
        private readonly UserManager<AplicationUser> _userManager;
        private readonly SignInManager<AplicationUser> _signInManager;
        public MembersHomeController(UserManager<AplicationUser> userManager, SignInManager<AplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           // _logger = logger;
          //  var usuarioLogueado = HttpContext.User.Identity.Name;

        }
        // GET: /<controller>/
        [HttpGet]
        
        public IActionResult Login(string returnUrl)
        {
           // if (_signInManager.Context.User != null) 
           // {
           //  _signInManager.SignOutAsync();
           // }
           
           // ViewBag.Title = "Login page";
           ViewBag.ReturnUrl = returnUrl;
            
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            
            if (!ModelState.IsValid)
            {
                var comprobarRegistro= new RegisterViewModel { NombreUsuario = login.NombreUsuario,
                    Contraseña = login.Contraseña };
                return View("../Account/Comprobacion", comprobarRegistro);
            }
            
            ViewBag.Title = "Login page";

            if (ModelState.IsValid)
            {
                var user = new AplicationUser
                {
                   
                    NombreUsuario = login.NombreUsuario,
                    UserName = login.NombreUsuario,
                    Email = login.NombreUsuario,
                    Contraseña = login.Contraseña
                };

                var result = await _signInManager.PasswordSignInAsync(user, login.Contraseña, login.RememberMe, false);
                

                if (result.Succeeded)
                {  
                    Identidad = user.Id;
                    return RedirectToAction("Index", "Home", Identidad);

                }
                else
                {
                    ModelState.AddModelError("", "Error en Login");
                    
                }
            }
            return View(login);
        }

        public async Task<IActionResult> Logout(LoginViewModel login)
        {

            await _signInManager.PasswordSignInAsync(login.NombreUsuario, login.Contraseña, true, false);
            return View();
        }
    }
}
