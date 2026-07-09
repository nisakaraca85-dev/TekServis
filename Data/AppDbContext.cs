using Microsoft.EntityFrameworkCore;
using TekServis.Models;

namespace TekServis.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // C# Modellerimiz ile SQL Tablolarımızı eşleştiriyoruz
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Cihaz> Cihazlar { get; set; }
        public DbSet<ServisKaydi> ServisKayitlari { get; set; }
        public DbSet<Teknisyen> Teknisyenler { get; set; }
    }
}