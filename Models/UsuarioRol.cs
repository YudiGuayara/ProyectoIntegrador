using System;

namespace SGPA.Models
{
    public class UsuarioRol
    {
        public int Id { get; set; }
        public string? IdUsuario { get; set; } // Permite valores nulos usando el operador '?' si es apropiado
        public int IdRol { get; set; }

        public Usuario? Usuario { get; set; }
        public Rol? Rol { get; set; }
    }
}
