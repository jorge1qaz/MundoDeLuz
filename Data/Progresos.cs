using System;

namespace Data
{
    [Serializable]
    public class Progresos
    {
        public int IdProgreso { get; set; }

        public string NodoSuperior { get; set; }

        public string NodoInferior { get; set; }

        public Int16 IdCategoria { get; set; }

        public Boolean Aprobacion { get; set; }
    }
}
