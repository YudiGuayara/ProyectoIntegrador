using System;

namespace SGPA.Models
{
    public class ProyectoEquipo
    {
        public int Id { get; set; }
        
        // Foreign key
        public int IdProyecto { get; set; }
        
        // Navigation property - Proyecto (nullable)
        public Proyecto? Proyecto { get; set; }
        
        // Foreign key
        public int IdEquipo { get; set; }
        
        // Navigation property - Equipo (nullable)
        public Equipo? Equipo { get; set; }
        
        public DateTime FechaAsignacion { get; set; } = DateTime.UtcNow;
    }
}
