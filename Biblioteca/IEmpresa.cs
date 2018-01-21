using System;
using System.Collections.Generic;
using Biblioteca.Modelo;

namespace Biblioteca
{
    public interface IEmpresa
    {
       
        IEnumerable<Empresa> GetAll();
        Empresa GetById(int id);
        void Add(Empresa nuevoEmpresa);
        void Delete(Empresa eliminarEmpresa);
        void Update(Empresa actualizarEmpresa);
        string GetNombre(int id);
        string GetCIF(int id);
        string GetDireccion(int id);
        string GetProvincia(int id);
        int GetNumeroTelefono(int id);
        IEnumerable<Oferta> GetOferta(int id);

    }
}

