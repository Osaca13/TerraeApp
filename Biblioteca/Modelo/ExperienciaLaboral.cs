using System;
using System.Collections.Generic;

namespace Biblioteca.Modelo
{
    public class ExperienciaLaboral
    {
        private int id;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private string descripcion;
        private List<EspecialidadPath> especialidad;

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFinal { get => fechaFinal; set => fechaFinal = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<EspecialidadPath> Especialidad { get => especialidad; set => especialidad = value; }
        public int Id { get => id; set => id = value; }
    }

    public class EspecialidadPath
    {
        private int id;
        private string path;

        public int Id { get => id; set => id = value; }
        public string Path { get => path; set => path = value; }
    }
}