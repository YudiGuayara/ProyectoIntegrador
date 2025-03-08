using System;
using System.Collections.Generic;

namespace SGPA.Models
{
   public class Proyecto
{
    public int Id { get; set; }
    
    // Propiedad nullable para Nombre
    public string? Nombre { get; set; }
    
    // Propiedad nullable para Descripcion
    public string? Descripcion { get; set; }
    
    // Propiedad nullable para Tareas
    public ICollection<Tarea>? Tareas { get; set; }
    
    // Propiedad nullable para ProyectoEquipos
    public ICollection<ProyectoEquipo>? ProyectoEquipos { get; set; }
    
    public double Progreso { get; set; }
    
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    
    public DateTime? FechaInicio { get; set; }
    
    public DateTime? FechaFinalizacion { get; set; }
}

}
