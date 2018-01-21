using Biblioteca;
using BibliotecaServices;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerraeApp.Models.Oferta;

namespace TerraeApp.Controllers
{
    public class OfertaController : Controller
    {
        private IOferta _oferta;
        public OfertaController(IOferta oferta)
        {
            _oferta = oferta;
        }

        public IActionResult Index()
        {
            var ofertaModelo = _oferta.GetAll();

            var listado = ofertaModelo
                .Select(resultado => new OfertaIndexListingModel
                {
                    Id = resultado.Id,
                    Provincia = resultado.Provincia,
                    Titulo = resultado.Titulo,
                    NombreEmpresa = resultado.Empresa.Nombre,
                    Descripcion = resultado.Descripcion,
                    FechaInicio = resultado.FechaInicio,
                    NumeroCandidatos = resultado.NumeroCandidatos
                     
                });

            var modelo = new OfertaIndexModel()
            {
                GetOfertaIndexModel = listado
            };
            return View(modelo);

        }

        public IActionResult Detalles()
        {
            int id = 1;
            var oferta = _oferta.GetById(id);

            var modelo = new OfertaDetallesModel
            {
                Id = id,
                Titulo = oferta.Titulo,
                Descripcion = oferta.Descripcion,
                FechaPublicacion = oferta.FechaInicio,
                NombreEmpresa = oferta.Empresa.Nombre,
                NumeroCandidatos = oferta.NumeroCandidatos

            };

            return View(modelo);
        }
    }
}
