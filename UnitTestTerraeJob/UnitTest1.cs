using Microsoft.VisualStudio.TestTools.UnitTesting;
using TerraeApp.Controllers;
using TerraeApp.Models.Register;


namespace UnitTestTerraeJob
{
    [TestClass]
    public class AccountControllerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]

        public void RegisterTest_user()
        {
            var register = new AccountController();
            var registermodel = new RegisterViewModel();

            var result = register.Register(registermodel);

            Assert.IsNotNull(result);
        }
       
    }
}
