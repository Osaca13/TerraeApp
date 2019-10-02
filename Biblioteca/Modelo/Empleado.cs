using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Biblioteca.Modelo
{
    public class Empleado
    {
        private int id;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Identidad { get => identidad; set => identidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public ExperienciaLaboral ExperienciaLaboral { get => experienciaLaboral; set => experienciaLaboral = value; }
        public Carnet Carnet { get => carnet; set => carnet = value; }
        public ObservableCollection<Oferta> Oferta { get => oferta; set => oferta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        

        [Required]
        private string nombre;
        [Required]
        private string primerApellido;
        private string segundoApellido;
        [Required]
        private string identidad;
        [Required]
        private string direccion;
        [Required]
        private string provincia;
        private DateTime fechaNacimiento;
        [Required]
        private string numeroTelefono;
        private ExperienciaLaboral experienciaLaboral;
        private Carnet carnet;
        private ObservableCollection<Oferta> oferta;


    }
}
