using System;

namespace TekServis.Models
{
    public class Teknisyen : BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string UzmanlikAlani { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }

        // Hataları çözecek eski alanlar:
        public string AdSoyad { get; set; }
        public int TeknisyenID { get => ID; set => ID = value; }
    }
}