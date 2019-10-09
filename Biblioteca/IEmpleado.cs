using System;
using System.Collections.Generic;
using System.ServiceModel;
using Biblioteca.Modelo;

namespace Biblioteca
{
    [ServiceContract]
    public interface IEmpleado
    {
        IEnumerable<Empleado> GetAll();
        Empleado GetById(int id);
        int Add(Empleado nuevoEmpleado);
        void Delete(Empleado eliminarEmpleado);
        void Update(Empleado actualizarEmpleado);
        string GetNombre(int id);
        string GetPrimerApellido(int id);
        string GetSegundoApellido(int id);
        string GetIdentidad(int id);
        string GetDireccion(int id);
        string GetProvincia(int id);
        DateTime GetFechaNacimiento(int id);
        string GetNumeroTelefono(int id);
        ExperienciaLaboral GetExperienciaLaboral(int id);
        Carnet GetCarnet(int id);
        IEnumerable<Oferta> GetOferta(int id);


    }
}
