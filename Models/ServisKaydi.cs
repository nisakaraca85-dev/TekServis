using System;
using System.ComponentModel.DataAnnotations;

namespace TekServis.Models
{
    public class ServisKaydi
    {
        [Key]
        public int KayitID { get; set; }

        public int CihazID { get; set; }

        public string? ArizaAciklamasi { get; set; }

        public string? Durum { get; set; }

        public decimal? Fiyat { get; set; }

        public DateTime GelisTarihi { get; set; }

        public DateTime? TeslimTarihi { get; set; }

        public int TeknisyenID { get; set; }
    }
}