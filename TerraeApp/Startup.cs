using Biblioteca;
using BibliotecaServices;
using System.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Modelo;
using Microsoft.AspNetCore.Identity;
using TerraeApp.Configuration;

namespace TerraeApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            // Configuration = configuration;

            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddRazorPagesOptions( options => {
                    options.Conventions.AuthorizeFolder("/MembersHome/Login");
                    options.Conventions.AuthorizePage("/MemberHome/Logout");
                });
            services.AddSingleton(Configuration);
            services.AddScoped<IOferta, OfertaServices>();
            services.AddScoped<IEmpleado, EmpleadoServices>();
            services.AddScoped<IEmpresa, EmpresaServices>();
            services.AddScoped<IExperienciaLaboral, ExperienciaLaboralServices>();
            services.AddDbContext<BibliotecaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BibliotecaConnection")));
            services.AddIdentity<AplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<BibliotecaContext>()
                .AddDefaultTokenProviders();
            //services.AddHttpContextAccesor();

            services.Configure<IdentityOptions>(
                options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequiredLength = 5;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                });
            services.ConfigureApplicationCookie(options => options.LoginPath = "/MembersHome/Login");

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
           // new UserRoleSeed(app.ApplicationServices.GetService<RoleManager<IdentityRole>>()).SeedAsync();
        }
    }
}
