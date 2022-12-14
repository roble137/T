using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AplicacionWebColegio.Data.Models
{
    [Table("Personas")]
    public class Persona
    {

        [Required(ErrorMessage = "El campo {0} es requerido...")]
        [Display(Name = "Nombres")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1}")]
        public string Nombres { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido...")]
        [Display(Name = "Apellidos")]
        [StringLength(50, ErrorMessage = "La longitud máxima del campo {0} es de {1}")]
        public string Apellidos { get; set; }


        [Required(ErrorMessage="El campo {0} es requerido")]
        [Display(Name = "Fecha Nacimiento")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
    }
}
