using System;

namespace Data
{
    [Serializable]
    public class Niveles
    {
        public Int16 IdNivel { get; set; }

        public string NombreNivel { get; set; }

        public decimal PorcentajeGanacia { get; set; }
    }
}
