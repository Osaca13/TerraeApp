using Biblioteca.Modelo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca
{
    public interface IBibliotecaContext
    {
        DbSet<Carnet> Carnets { get; set; }

        DbSet<CodigoPath> CodigoPaths { get; set; }
        DbSet<Empleado> Empleados { get; set; }
        DbSet<Empresa> Empresas { get; set; }
        DbSet<ExperienciaLaboral> ExperienciaLaborales { get; set; }
        DbSet<Oferta> Ofertas { get; set; }

        
    }
}