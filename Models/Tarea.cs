using System;
using System.Collections.Generic;

namespace SGPA.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? IdProyecto { get; set; } // Propiedad para la clave foránea

        public Proyecto? Proyecto { get; set; }
        public ICollection<Progreso>? Progresos { get; set; }
        public ICollection<Comentario>? Comentarios { get; set; }

        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
    }
}
