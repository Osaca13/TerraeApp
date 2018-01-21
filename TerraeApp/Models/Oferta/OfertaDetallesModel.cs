using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca;
using Biblioteca.Modelo;

namespace TerraeApp.Models.Oferta
{
    public class OfertaDetallesModel
    {
        private int id;
        private string titulo;
        private string descripcion;
        private DateTime fechaPublicacion;
        private string provincia;
        private int numeroCandidatos;
        private string nombreEmpresa;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public int NumeroCandidatos { get => numeroCandidatos; set => numeroCandidatos = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
    }
}
