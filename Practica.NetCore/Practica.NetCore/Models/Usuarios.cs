using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practica.NetCore.Models
{
    public class Usuarios
    {
        [Display (Name ="Nombre")]
        [Required (ErrorMessage = "Este campo es requerido")]
        public String Nombre { get; set; }

        [Display(Name = "Edad")]
        [Required(ErrorMessage = "Este campo es requerido")]
       
        public int Edad { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String Sexo { get; set; }

        [Display(Name = "Tipo De Estudio")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public String TipoDeEstudio {get; set; }
    }
}
