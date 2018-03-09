using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BLOGDeportes.Models
{
    public class Evento
    {
        public int EventoID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre del Evento")]
        public string NomEvento { get; set; }
        [Required]
        [StringLength(80)]
        [Display(Name = "Ciudad del Evento")]
        public string CiudadEvento { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Lugar del Evento")]
        public string LugarEvento { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Descripcion { get; set; }
        [Required]
        [Display(Name = "Fecha del Evento")]
        public DateTime FechaEvento { get; set; }
        [Required]
        public string Foto { get; set; }
        [Required]
        public int Estado { get; set; }

        public virtual ICollection<Detalle> Detalle { get; set; }

        public Evento()
        {
            FechaEvento = DateTime.Now;
        }
    }
}