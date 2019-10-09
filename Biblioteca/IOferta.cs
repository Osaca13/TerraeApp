using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using Biblioteca.Modelo;

namespace Biblioteca
{
    [ServiceContract]
    public interface IOferta
    {
        IEnumerable<Oferta> GetAll();
        Oferta GetById(int id);
        void Add(Oferta nuevaOferta);
        void Delete(Oferta eliminarOferta);
        void Update(Oferta actualizarOferta);
        string GetTitulo(int id);
        string GetDescripcion(int id);
        string GetProvincia(int id);
        DateTime GetFechaInicio(int id);
        int GetNumeroCandidatos(int id);
        string GetEmpresa(int id);
    }
}
 