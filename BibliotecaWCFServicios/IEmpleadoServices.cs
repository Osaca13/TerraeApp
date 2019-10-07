using System;
using System.Collections.Generic;
using System.ServiceModel;
using Biblioteca.Modelo;

namespace BibliotecaWCFServicios
{
    [ServiceContract]
    public interface IEmpleadoServices
    {
        [OperationContract]
        int Add(Empleado nuevoEmpleado);

        [OperationContract]
        void Delete(Empleado eliminarEmpleado);

        [OperationContract]
        IEnumerable<Empleado> GetAll();

        [OperationContract]
        Empleado GetById(int id);

        [OperationContract]
        Carnet GetCarnet(int id);

        [OperationContract]
        string GetDireccion(int id);

        [OperationContract]
        ExperienciaLaboral GetExperienciaLaboral(int id);

        [OperationContract]
        DateTime GetFechaNacimiento(int id);

        [OperationContract]
        string GetIdentidad(int id);

        [OperationContract]
        string GetNombre(int id);

        [OperationContract]
        string GetNumeroTelefono(int id);

        [OperationContract]
        IEnumerable<Oferta> GetOferta(int id);

        [OperationContract]
        string GetPrimerApellido(int id);

        [OperationContract]
        string GetProvincia(int id);

        [OperationContract]
        string GetSegundoApellido(int id);

        [OperationContract]
        void Update(Empleado actualizarEmpleado);
    }
}