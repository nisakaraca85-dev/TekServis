using System;

namespace TekServis.Models
{
    public class Cihaz : BaseEntity
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNo { get; set; }
        public string CihazTipi { get; set; }
        public int MusteriID { get; set; }
        public string CihazAdi { get; set; }

        // Hataları çözecek eski ID eşleşmesi:
        public int CihazID { get => ID; set => ID = value; }
    }
}