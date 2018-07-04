using System;

namespace Data
{
    [Serializable]
    public class Categorias
    {
        public Int16 IdCategoria { get; set; }

        public string NombreCategoria { get; set; }

        public decimal Monto { get; set; }
    }
}
