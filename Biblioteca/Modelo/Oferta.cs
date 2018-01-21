using System;

namespace Biblioteca.Modelo
{
    public class Oferta
    {
        private int id;
        private string titulo;
        private string descripcion;
        private DateTime fechaInicio;
        private string provincia;
        private int numeroCandidatos;
        private Empresa empresa;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public int NumeroCandidatos { get => numeroCandidatos; set => numeroCandidatos = value; }
        public virtual Empresa Empresa { get => empresa; set => empresa = value; }
    }
}