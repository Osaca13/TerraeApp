using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biblioteca;
using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaServices
{
    public class EmpleadoServices : IEmpleado
    {
        private BibliotecaContext _context;
        public EmpleadoServices(BibliotecaContext context)
        {
            _context = context;
        }

        public void Add(Empleado nuevoEmpleado)
        {
            _context.Add(nuevoEmpleado);
        }

        public void Delete(Empleado eliminarEmpleado)
        {
            _context.Remove(eliminarEmpleado);
        }

        public IEnumerable<Empleado> GetAll()
        {
            return _context.Empleados
                .Include( Empleado => Empleado.ExperienciaLaboral)
                .Include( Empleado => Empleado.Carnet)
                .Include( Empleado => Empleado.Oferta);
        }

        public Empleado GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Carnet GetCarnet(int id)
        {
            return GetById(id).Carnet;
        }

        public string GetDireccion(int id)
        {
            return GetById(id).Direccion;
        }

        public ExperienciaLaboral GetExperienciaLaboral(int id)
        {
            return GetById(id).ExperienciaLaboral;
        }

        public DateTime GetFechaNacimiento(int id)
        {
            return GetById(id).FechaNacimiento;
        }

        public string GetIdentidad(int id)
        {
            return GetById(id).Identidad;
        }

        public string GetNombre(int id)
        {
            return GetById(id).Nombre;
        }

        public string GetNumeroTelefono(int id)
        {
            return GetById(id).NumeroTelefono;
        }

        public IEnumerable<Oferta> GetOferta(int id)
        {
            return GetById(id).Oferta;
        }

        public string GetPrimerApellido(int id)
        {
            return GetById(id).PrimerApellido;
        }

        public string GetProvincia(int id)
        {
            return GetById(id).Provincia;
        }

        public string GetSegundoApellido(int id)
        {
            return GetById(id).SegundoApellido;
        }

        public void Update(Empleado actualizarEmpleado)
        {
            _context.Update(actualizarEmpleado);
        }

       
    }
}
