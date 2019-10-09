using System;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Biblioteca
{
    public class BibliotecaContext: IdentityDbContext<AplicationUser>, IBibliotecaContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)  
        {
          
        
        }

        

        private DbSet<Empleado> empleados;
        private DbSet<Empresa> empresas;
        private DbSet<Carnet> carnets;
        private DbSet<ExperienciaLaboral> experienciaLaborales;
        private DbSet<Oferta> ofertas;

        public DbSet<Empleado> Empleados { get => empleados; set => empleados = value; }
        public DbSet<Empresa> Empresas { get => empresas; set => empresas = value; }
        public DbSet<Carnet> Carnets { get => carnets; set => carnets = value; }
        public DbSet<ExperienciaLaboral> ExperienciaLaborales { get => experienciaLaborales; set => experienciaLaborales = value; }
        public DbSet<Oferta> Ofertas { get => ofertas; set => ofertas = value; }
        public DbSet<CodigoPath> CodigoPaths { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
