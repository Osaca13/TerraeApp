using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Modelo;
using Biblioteca;
using TerraeApp.Models.Empleado;
using Microsoft.EntityFrameworkCore;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TerraeApp.Controllers
{
    public class EmpleadoController : Controller
    {
        private IEmpleado _empleado;
        public EmpleadoController(IEmpleado empleado)
        {
            _empleado = empleado;
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
                //Carnet = empleado.Carnet.ToString(),
                DireccionPostal = empleado.Direccion,
                Fechanacimiento = empleado.FechaNacimiento,
                //Ofertas = empleado.Oferta
            };


            return View(empleadoCV);
        }
    }
}
