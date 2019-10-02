
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TerraeApp.Models.Register
{
    public class RegisterViewModel
    {
        [Required, MaxLength(256), Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }

        [Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Contraseña") ]
        public string Contraseña { get; set; }

        //[NotMapped]
        //[Required, MinLength(6), MaxLength(50), DataType(DataType.Password), Display(Name = "Confirmar Contraseña")]
        //[Compare("Contraseña", ErrorMessage = "Las contraseñas no coinciden")]
        //public string ConfirmarContraseña { get; }
    }
}
