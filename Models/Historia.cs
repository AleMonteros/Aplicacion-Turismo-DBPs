using System;
using System.ComponentModel.DataAnnotations;

namespace AppSocialTour.Models
{
    public class Historia
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(500)]
        public string Desarrollo { get; set; }

        [Required]
        [MaxLength(500)]
        public string PaginasReferencia { get; set; }

        [Required]
        [MaxLength(100)]
        public string Historiador { get; set; }

        [MaxLength(100)]
        public string EmailHistoriador { get; set; }

    }
}