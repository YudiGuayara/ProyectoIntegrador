using System.Collections.Generic;

namespace SGPA.Models
{
    public class Rol
{
    public int Id { get; set; }
    
    // Propiedad nullable para Nombre
    public string? Nombre { get; set; }
    
    // Propiedad nullable para Permisos
    public ICollection<Permiso>? Permisos { get; set; }
    
    // Propiedad nullable para UsuarioRoles
    public ICollection<UsuarioRol>? UsuarioRoles { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}

}
