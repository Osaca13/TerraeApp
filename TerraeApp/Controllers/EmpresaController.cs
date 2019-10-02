using Biblioteca;
using Microsoft.AspNetCore.Mvc;
using TerraeApp.Models.Empresa;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TerraeApp.Controllers
{
    public class EmpresaController : Controller
    {
        private IEmpresa _empresa;

        public EmpresaController(IEmpresa empresa)
        {
            _empresa = empresa;
        }

        public IActionResult Index()
        {
            int id = 4;
            var empresa = _empresa.GetById(id);

            var empresaCV = new EmpresaDetallesModel
            {
                IdModels = empresa.Id,
                NombreModels = empresa.Nombre,
                CIFModels = empresa.CIF,
                DireccionModels = empresa.Direccion,
                TelefonoModels = empresa.Telefono,
                ProvinciaModels = empresa.Provincia,
                //OfertaModels = empresa.Oferta

               
            };
            return View(empresaCV);
        }
    }
}
