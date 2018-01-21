using System;
using System.Collections.ObjectModel;


namespace TerraeApp.Models.Empleado
{
    public class EmpleadoDetallesModel
    {
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string identidad;
        private string direccionPostal;
        private string provincia;
        private DateTime fechanacimiento;
        private string numeroTelefono;
        private string carnet;
        private ObservableCollection<Biblioteca.Modelo.Oferta> ofertas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Identidad { get => identidad; set => identidad = value; }
        public string DireccionPostal { get => direccionPostal; set => direccionPostal = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public DateTime Fechanacimiento { get => fechanacimiento; set => fechanacimiento = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public ObservableCollection<Biblioteca.Modelo.Oferta> Ofertas { get => ofertas; set => ofertas = value; }
    }
}
