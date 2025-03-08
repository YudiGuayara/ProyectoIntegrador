namespace SGPA.Models
{
    public class Progreso
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public int? IdTarea { get; set; } // Propiedad para la clave foránea

        public Tarea? Tarea { get; set; }
        public DateTime FechaProgreso { get; set; } = DateTime.UtcNow;
        public double Porcentaje { get; set; }
    }
}
