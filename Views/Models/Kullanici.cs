using System;

namespace TekServis.Models
{
    // Diğer modellerimiz gibi BaseEntity'den miras alıyor
    public class Kullanici : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }

        // Kullanıcının rolünü burada tutacağız: "SuperAdmin" veya "NormalUser"
        public string Rol { get; set; }
    }
}