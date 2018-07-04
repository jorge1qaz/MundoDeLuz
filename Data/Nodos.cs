using System;

namespace Data
{
    [Serializable]
    public class Nodos
    {
        public string IdNodo { get; set; }

        public Int16 IdCategoria { get; set; }

        public Int16 Cantidad { get; set; }

        public string IdUsuario { get; set; }

        public Int16 IdNivel { get; set; }
    }
}
