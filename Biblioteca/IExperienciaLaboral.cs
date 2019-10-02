using Biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public interface IExperienciaLaboral
    {
        
            IEnumerable<ExperienciaLaboral> GetAll();
            ExperienciaLaboral GetById(int id);
            void Add(ExperienciaLaboral nuevaExperiencia);
            void Delete(ExperienciaLaboral eliminarExperiencia);
            void Update(ExperienciaLaboral actualizarExperiencia);
            DateTime GetFechaInicio(int id);
            DateTime GetFechaFinal(int id);
            IEnumerable<EspecialidadPath> GetEspecialidadPath(int id);
    }
}
