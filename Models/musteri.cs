using System.ComponentModel.DataAnnotations;

namespace TekServis.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [Required]
        [StringLength(100)]
        public string AdSoyad { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(100)]
        public string Eposta { get; set; }

        public string Adres { get; set; }
    }
}