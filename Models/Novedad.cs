using System;
using System.ComponentModel.DataAnnotations;

namespace AppSocialTour.Models
{
    public class Novedad
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Noticia { get; set; }

        [Required]
        [MaxLength(500)]
        public string Lugar { get; set; }

        [Required]
        [MaxLength(500)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(100)]
        public string Mensaje { get; set; }

    }
}