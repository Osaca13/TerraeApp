using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerraeApp.Models.Members
{
    public class LoginViewModel
    {
        [Required]
        public string _nombreUsuario = "NoLogin";
       
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        [Required, DataType(DataType.Password)]
        public string Contraseña { get; set; }

        [Display(Name = "Recuérdame")]
        public bool RememberMe { get; set; }
    }
}
