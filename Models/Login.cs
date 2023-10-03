using System.ComponentModel.DataAnnotations;


namespace ServicioSocial.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Usuario requerido")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Password requerido")]
        public string Password { get; set; }
    }
}