
using Autofac;
using Biblioteca;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace TerraeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            CreateFactory();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();

        public static void CreateFactory() 
        {
            var container = Factory.FactoryConfig.Container();

            using (var scope = container.BeginLifetimeScope())
            {
                scope.Resolve<IBibliotecaContext>();
                scope.Resolve<IEmpleado>();
                scope.Resolve<IEmpresa>();
                scope.Resolve<IOferta>();
                scope.Resolve<IExperienciaLaboral>();

            }
        }
    }
}
