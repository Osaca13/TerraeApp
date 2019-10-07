using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca;
using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaServices
{
    public class EmpresaServices : IEmpresa
    {
        private readonly BibliotecaContext _context;

        public EmpresaServices(BibliotecaContext context)
        {
            _context = context;
        }

        public void Add(Empresa nuevoEmpresa)
        {
            _context.Add(nuevoEmpresa);
        }

        public void Delete(Empresa eliminarEmpresa)
        {
            _context.Remove(eliminarEmpresa);
        }

        public IEnumerable<Empresa> GetAll()
        {
            return _context.Empresas
                .Include( Empresa => Empresa.Oferta);
        }

        public Empresa GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public string GetCIF(int id)
        {
            return GetById(id).CIF;
        }

        public string GetDireccion(int id)
        {
            return GetById(id).Direccion;
        }

        public string GetNombre(int id)
        {
            return GetById(id).Nombre;
        }

        public int GetNumeroTelefono(int id)
        {
            return GetById(id).Telefono;
        }

        public IEnumerable<Oferta> GetOferta(int id)
        {
            return GetById(id).Oferta;
        }

        public string GetProvincia(int id)
        {
            return GetById(id).Provincia;
        }

        public void Update(Empresa actualizarEmpresa)
        {
            _context.Update(actualizarEmpresa);
        }
    }
}
