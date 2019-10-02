using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Modelo
{
    public class AplicationUser: IdentityUser
    {
        [Required]
        public string NombreUsuario { get; set; }

        [Required]
        public string Contraseña { get; set; }

    }
}
