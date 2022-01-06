using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Debes introducir un email valido.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]        
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Contraseña")]
        [MaxLength(6, ErrorMessage = "El campo {0} no puede tener mas de {1} carácteres")]
        public string Password { get; set; }

        [Display(Name = "Confirmación de contraseña")]        
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [MaxLength(6, ErrorMessage = "El campo {0} debe tener una longitud mínima de {1} carácteres")]
        [Compare("Password", ErrorMessage ="La contraseña y confirmación de contraseña no son iguales.")]
        public string PasswordConfirm { get; set; }
    }
}
