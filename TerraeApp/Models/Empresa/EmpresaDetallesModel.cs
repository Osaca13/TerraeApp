using Biblioteca;
using System.Collections.ObjectModel;

namespace TerraeApp.Models.Empresa
{
    public class EmpresaDetallesModel
    {
        public int IdModels { get; set; }
        public string NombreModels { get; set; }
        public string CIFModels { get; set; }
        public string DireccionModels { get; set; }
        public int TelefonoModels { get; set; }
        public string ProvinciaModels { get; set; }
        public ObservableCollection<Biblioteca.Modelo.Oferta> OfertaModels { get; set; }


    }
}
