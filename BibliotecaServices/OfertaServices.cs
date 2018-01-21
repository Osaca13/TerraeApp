using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca;
using Biblioteca.Modelo;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaServices
{
    public class OfertaServices : IOferta
    {
        private BibliotecaContext _context;
        public OfertaServices(BibliotecaContext context)
        {
            _context = context;
        }

        public void Add(Oferta nuevaOferta)
        {
            _context.Add(nuevaOferta);
            _context.SaveChanges();
           
        }

        public void Delete(Oferta eliminarOferta)
        {
            _context.Remove(eliminarOferta);
        }

        public IEnumerable<Oferta> GetAll()
        {
            return _context.Ofertas
                .Include(Oferta => Oferta.Empresa);
        }

        public Oferta GetById(int id)
        {
            return 
                GetAll()
                .FirstOrDefault(c => c.Id == id);

        }

        public string GetDescripcion(int id)
        {
            return GetById(id).Descripcion;
        }

        public string GetEmpresa(int id)
        {
            return GetById(id).Empresa.Nombre;
        }

        public DateTime GetFechaInicio(int id)
        {
            return GetById(id).FechaInicio;
        }

        public int GetNumeroCandidatos(int id)
        {
            return GetById(id).NumeroCandidatos;
        }

        public string GetProvincia(int id)
        {
            return GetById(id).Provincia;
        }

        public string GetTitulo(int id)
        {
            return GetById(id).Titulo;
        }

        public void Update(Oferta actualizarOferta)
        {
            _context.Update(actualizarOferta);
            _context.SaveChanges();

        }
    }
}
