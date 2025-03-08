using System; // Asegúrate de incluir esta directiva para DateTime

namespace SGPA.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public int IdTarea { get; set; }
        public int IdUsuario { get; set; }
        public string? Contenido { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Tarea? Tarea { get; set; } // Asegúrate de que Tarea esté definido correctamente y sea nulable
        public Usuario? Usuario { get; set; } // Asegúrate de que Usuario esté definido correctamente y sea nulable
    }
}
