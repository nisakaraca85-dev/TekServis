using System;

namespace TekServis.Models
{
    public class Musteri : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string AdSoyad { get; set; }

        // Hataları çözecek eski ID eşleşmesi:
        public int MusteriID { get => ID; set => ID = value; }
    }
}