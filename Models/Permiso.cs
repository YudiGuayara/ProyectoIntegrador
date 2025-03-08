using System.ComponentModel.DataAnnotations.Schema; // Asegúrate de incluir esta directiva si estás usando atributos de DataAnnotations

namespace SGPA.Models
{
    public class Permiso
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public string? Nombre { get; set; }

        // Propiedad para la clave foránea
        [ForeignKey("Rol")]
        public int? IdRol { get; set; } 

        public Rol? Rol { get; set; } // Propiedad de navegación
    }
}
