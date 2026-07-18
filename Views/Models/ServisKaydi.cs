using System;

namespace TekServis.Models
{
    public class ServisKaydi : BaseEntity
    {
        public int CihazID { get; set; }
        public int TeknisyenID { get; set; }
        public string SorunAciklamasi { get; set; }
        public string YapilanIslem { get; set; }
        public decimal Ucret { get; set; }
        public string Durum { get; set; }

        // Hataları çözecek eksik orijinal alanlar:
        public decimal Fiyat { get; set; }
        public DateTime GelisTarihi { get; set; } = DateTime.Now;
        public string ArizaAciklamasi { get; set; }
        public int KayitID { get; set; }
    }
}