using System;
using System.Collections.Generic;

namespace AbmClientes.Models
{
    public partial class Cliente
    {
        public int Dni { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Mail { get; set; }
    }
}
