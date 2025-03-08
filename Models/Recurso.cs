using System;

namespace SGPA.Models
{
    public class Recurso
{
    public int Id { get; set; }
    
    // Propiedad nullable para Nombre
    public string? Nombre { get; set; }
    
    // Propiedad nullable para Descripcion
    public string? Descripcion { get; set; }
    
    public double CantidadDisponible { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}

}
