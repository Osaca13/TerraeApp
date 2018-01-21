using System;
using Biblioteca.Modelo;

namespace TerraeApp.Models.Oferta
{
    public class OfertaIndexListingModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Provincia { get; set; }
        public int NumeroCandidatos { get; set; }
       public string NombreEmpresa { get; set; }
    }
}
