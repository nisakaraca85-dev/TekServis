using System.ComponentModel.DataAnnotations;

namespace TekServis.Models
{
    public class Cihaz
    {
        [Key]
        public int CihazID { get; set; }

        // Her cihazın bir sahibi olmalı (not null)
        public int MusteriID { get; set; }

        [Required]
        [StringLength(100)]
        public string CihazAdi { get; set; } = string.Empty;

        public string? Marka { get; set; }

        public string? Model { get; set; }

        [StringLength(50)]
        public string? SeriNo { get; set; }
    }
}