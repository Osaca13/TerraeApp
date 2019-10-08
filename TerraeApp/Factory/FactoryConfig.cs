using Autofac;
using Biblioteca;
using BibliotecaServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerraeApp.Factory
{
    public static class FactoryConfig
    {
        public static IContainer Container() 
        {
            var builder = new ContainerBuilder();


            builder.RegisterType<BibliotecaContext>().As<IBibliotecaContext>();
            builder.RegisterType<EmpleadoServices>().As<IEmpleado>();
            builder.RegisterType<EmpresaServices>().As<IEmpresa>();
            builder.RegisterType<OfertaServices>().As<IOferta>();
            builder.RegisterType<ExperienciaLaboralServices>().As<IExperienciaLaboral>();

            return builder.Build();
        }

        private static IServiceCollection GetServices(IServiceCollection serviceCollection) 
        {
            serviceCollection.AddTransient<IOferta, OfertaServices>();
            return serviceCollection;
        }

    }
}
