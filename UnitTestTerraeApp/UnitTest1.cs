using Biblioteca.Modelo;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTerraeApp
{
    [TestClass]
    public class UnitTest1
    {
        private Biblioteca.Modelo.AplicationUser aplicationUser;
        private readonly UserManager<AplicationUser> _userManager;
        private readonly SignInManager<AplicationUser> _signInManager;

        
       

        //public void RegisterTest_register()
        //{
        //    var registerModel = new TerraeApp.Models.Register.RegisterViewModel();
        //    var user = new Biblioteca.Modelo.AplicationUser();
        //    //var userManager = new UserManager<user>;
        //    // var singInManager = SignInManager<user>;


        //    var registercs = new TerraeApp.Controllers.AccountController(_userManager, _signInManager );

        //    var result = registercs.Register(registerModel);

        //    Assert.IsNull(registerModel.ConfirmarContraseña);
            

        //   // Assert.  (result.Status);


        //}
    }
}
