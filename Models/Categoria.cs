using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BLOGDeportes.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre de la Categoria")]
        public String NomCategoria { get; set; }
        [Required]
        public int Estado { get; set; }
        [Required]
        [Display(Name = "Fecha de Creacion de la Categoria")]
        public DateTime FechaCategoria { get; set; }

        public virtual ICollection<Detalle> Detalle { get; set; }

        public Categoria()
        {
            FechaCategoria = DateTime.Now;
        }
    }
}