using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Modelo;
using Biblioteca;
using TerraeApp.Models.Empleado;
using Microsoft.EntityFrameworkCore;
using BibliotecaServices;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TerraeApp.Controllers
{
    public class EmpleadoController : Controller
    {
        private BibliotecaContext _context;
        private IEmpleado _empleado;
        public EmpleadoController(IEmpleado empleado, BibliotecaContext context)
        {
            _empleado = empleado;
            _context = context;
        }

        public IActionResult Index()
        {
            int id = 1;
            
            var empleado = _empleado.GetById(id);

            var empleadoCV = new EmpleadoDetallesModel
            {
                Identidad = empleado.Identidad,
                Nombre = empleado.Nombre,
                PrimerApellido = empleado.PrimerApellido,
                SegundoApellido = empleado.SegundoApellido,
                Ofertas = empleado.Oferta,
                DireccionPostal = empleado.Direccion,
                Fechanacimiento = empleado.FechaNacimiento,
                ExperienciaLaboral = empleado.ExperienciaLaboral
            };


            return View(empleadoCV);
        }

        [HttpGet]
        public IActionResult Curriculum()
        {
            return View();

        }

        [HttpPost]
        
        public ActionResult Curriculum(EmpleadoDetallesModel empleadoDetalles)
        {
            var nuevo = new EmpleadoServices(_context);
            if (ModelState.IsValid)
            {
                var empleado = new Empleado
                    {
                    Nombre = empleadoDetalles.Nombre,
                    PrimerApellido = empleadoDetalles.PrimerApellido,
                    SegundoApellido = empleadoDetalles.SegundoApellido,
                    Identidad = empleadoDetalles.Identidad,
                    Direccion = empleadoDetalles.DireccionPostal,
                    Provincia = empleadoDetalles.Provincia,
                    NumeroTelefono = empleadoDetalles.NumeroTelefono
                    };


                nuevo.Add(empleado);


            }
            else
            {
                ModelState.AddModelError("", "Error en Login");

            }
            
            return View();
        }
    }
}
