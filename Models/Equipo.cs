using System;
using System.Collections.Generic;

namespace SGPA.Models
{
    public class Equipo
{
    public int Id { get; set; }
    
    // Propiedad nullable para Nombre
    public string? Nombre { get; set; }
    
    // Propiedad nullable para Descripcion
    public string? Descripcion { get; set; }
    
    // Propiedad nullable para ProyectoEquipos
    public ICollection<ProyectoEquipo>? ProyectoEquipos { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
}

}
