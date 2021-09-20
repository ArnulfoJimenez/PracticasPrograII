using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaPresencial2.Models
{
    public class Usuario
    {
   [Display (Name = "Nombre")]
   [Required(ErrorMessage = "Error este campo es requirido")]
        public String Nombre { get; set; }

   [Display(Name = "Edad")]
   [Required(ErrorMessage = "Error este campo es requirido")]
   public int Edad { get; set; }

    [Display(Name = "Sexo")]
    [Required(ErrorMessage = "Error este campo es requirido")]
    public String Sexo { get; set; }

    [Display(Name = "Tipo De estudio")]
    [Required(ErrorMessage = "Error este campo es requirido")]
     public String TipoDeEstudio { get; set; }
    }
}