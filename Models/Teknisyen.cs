using System.ComponentModel.DataAnnotations;

namespace TekServis.Models
{
    public class Teknisyen
    {
        [Key]
        public int TeknisyenID { get; set; }

        [Required]
        [StringLength(100)]
        public string AdSoyad { get; set; }

        [StringLength(50)]
        public string? UzmanlikAlani { get; set; }

        [StringLength(20)]
        public string? Telefon { get; set; }

        [StringLength(100)]
        public string? Eposta { get; set; }
    }
}