using Microsoft.AspNetCore.Mvc;
using TekServis.Data;
using TekServis.Models;

namespace TekServis.Controllers
{
    public class ServisKayitController : Controller
    {
        private readonly AppDbContext _context;

        public ServisKayitController(AppDbContext context)
        {
            _context = context;
        }

        // 1. TÜM SERVİS KAYITLARINI LİSTELE
        public IActionResult Index()
        {
            var kayitlar = _context.ServisKayitlari.ToList();
            return View(kayitlar);
        }

        // 2. YENİ KAYIT EKLEME SAYFASI
        public IActionResult Create()
        {
            return View();
        }

        // 3. YENİ KAYIT EKLEME İŞLEMİ
        [HttpPost]
        public IActionResult Create(ServisKaydi servisKayit)
        {
            try
            {
                _context.ServisKayitlari.Add(servisKayit);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(servisKayit);
            }
        }
    }
}