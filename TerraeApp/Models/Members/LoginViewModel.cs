using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        [BindProperty]
        public string NombreUsuario { get; set; }

        [Required, DataType(DataType.Password)]
        [BindProperty]
        public string Contraseña { get; set; }

        [Display(Name = "Recuérdame")]
        [BindProperty]
        public bool RememberMe { get; set; }
    }
}
