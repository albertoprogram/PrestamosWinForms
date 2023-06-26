using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosWinForms.Entidades
{
    internal class Cliente
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string? NumeroTelefono { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
    }
}
