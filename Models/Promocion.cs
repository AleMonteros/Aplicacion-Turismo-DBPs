using System;
using System.ComponentModel.DataAnnotations;

namespace AppSocialTour.Models
{
    public class Promocion
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(500)]
        public string Promo { get; set; }

        [Required]
        [MaxLength(500)]
        public string TipoNegocio { get; set; }

        [Required]
        [MaxLength(500)]
        public string NombreNegocio { get; set; }

        [Required]
        [MaxLength(500)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(100)]
        public string DatosPromo { get; set; }

    }
}