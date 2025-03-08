using System.ComponentModel.DataAnnotations;

namespace SGPA.Models
{
    public class Register
    {
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "La dirección de correo electrónico es requerida.")]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}
