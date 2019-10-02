using System;
using System.Collections.Generic;
using System.Linq;

using Biblioteca;
using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaServices
{
    public class ExperienciaLaboralServices : IExperienciaLaboral
    {
        private BibliotecaContext _context;

        public ExperienciaLaboralServices(BibliotecaContext context)
        {
            _context = context;
        }

        public void Add(ExperienciaLaboral nuevaExperiencia)
        {
            _context.Add(nuevaExperiencia);
        }

        public void Delete(ExperienciaLaboral eliminarExperiencia)
        {
            _context.Remove(eliminarExperiencia);
        }

        public IEnumerable<ExperienciaLaboral> GetAll()
        {
           return _context.ExperienciaLaborales
                .Include(ExperienciaLaboral => ExperienciaLaboral.Especialidad);
        }

        public ExperienciaLaboral GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<EspecialidadPath> GetEspecialidadPath(int id)
        {
            return GetById(id).Especialidad;
        }

        public DateTime GetFechaFinal(int id)
        {
            return GetById(id).FechaFinal;
        }

        public DateTime GetFechaInicio(int id)
        {
            return GetById(id).FechaInicio;
        }

        public void Update(ExperienciaLaboral actualizarExperiencia)
        {
            _context.Update(actualizarExperiencia);
        }
    }
}
