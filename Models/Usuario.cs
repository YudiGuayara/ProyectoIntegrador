using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SGPA.Models
{
    public class Usuario : IdentityUser
    {
        public string? NombreUsuario { get; set; }
        public string? Contrasena { get; set; }
        public string? Correo { get; set; }

        public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
        public ICollection<Comentario>? Comentarios { get; set; }
    }
}
