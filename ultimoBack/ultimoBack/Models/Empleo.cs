using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ultimoBack.Models
{
    public class Empleo
    {
        [Key]
        public int id { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Puesto")]
        public string puesto { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Empresa")]
        public string empresa { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Recriuter")]
        public string recriuter { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Correo")]
        public string correo { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "fecha")]
        public string fecha { get; set; }
    }
}
