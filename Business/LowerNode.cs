using System;

namespace Business
{
    [Serializable]
    public class LowerNode
    {
        public string NodoSuperior { get; set; }

        public Int16 IdCategoria { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NombreNivel { get; set; }

        public decimal DineroAcumulado { get; set; }

        public Int16 Cantidad { get; set; }
    }
}
