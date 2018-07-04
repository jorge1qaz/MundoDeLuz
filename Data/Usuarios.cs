using System;

namespace Data
{
    [Serializable]
    public class Usuarios
    {
        public string IdUsuario { get; set; }

        public string Contrasenia { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string NumeroTelefonico { get; set; }

        public string Identificacion { get; set; }

        public Int16 IdBanco { get; set; }

        public string CuentaBancaria { get; set; }
    }
}
