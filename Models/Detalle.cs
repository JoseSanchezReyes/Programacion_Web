using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BLOGDeportes.Models
{
    public class Detalle
    {
        public int DetalleID { get; set; }
        [Required]
        public int EventoID { get; set; }
        [Required]
        public int CategoriaID { get; set; }
        [Required]
        public Double Distancia { get; set; }
        [Required]
        [Display(Name = "Fecha Detalle")]
        public DateTime FechaDetalle { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Evento Evento { get; set; }

        public Detalle()
        {
            FechaDetalle = DateTime.Now;
        }
    }
}