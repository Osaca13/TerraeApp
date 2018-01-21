using System.Collections.Generic;

namespace Biblioteca.Modelo
{
    public class Carnet
    {
        private int id;
        private List<CodigoPath> codigo;

        public List<CodigoPath> Codigo { get => codigo; set => codigo = value; }
        public int Id { get => id; set => id = value; }
    }

    public class CodigoPath
    {
        private int id;
        private string path;

        public string Path { get => path; set => path = value; }
        public int Id { get => id; set => id = value; }
    }
}