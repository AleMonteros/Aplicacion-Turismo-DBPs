using System;
using System.ComponentModel.DataAnnotations;

namespace AppSocialTour.Models
{
    public class RestBar
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required]
        public string Horario { get; set; }

        [Required]
        [MaxLength(15)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(100)]
        public string SitioWeb { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Datos { get; set; }
    }
}