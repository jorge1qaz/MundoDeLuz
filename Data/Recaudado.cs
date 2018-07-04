using System;

namespace Data
{
    [Serializable]
    public class Recaudado
    {

        public Int16 IdNivel { get; set; }

        public string IdNodo { get; set; }

        public decimal DineroAcumulado { get; set; }
    }
}
