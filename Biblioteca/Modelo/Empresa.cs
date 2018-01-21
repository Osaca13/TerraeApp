using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Biblioteca.Modelo
{
    public class Empresa
    {
        private int id;

        private string nombre;
        private string cIF;
        private string direccion;
        private int telefono;
        private string provincia;
        private ObservableCollection<Oferta> oferta;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CIF { get => cIF; set => cIF = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Provincia { get => provincia; set => provincia = value; }
        public ObservableCollection<Oferta> Oferta { get => oferta; set => oferta = value; }
    }
}
