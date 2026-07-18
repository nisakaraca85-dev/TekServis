using Microsoft.AspNetCore.Mvc;
using TekServis.Data;
using TekServis.Core;

namespace TekServis.Controllers
{
    [YetkiKontrol("SuperAdmin", "Admin")]
    public class MusteriController : BaseController
    {
        private readonly AppDbContext _context;

        // Veri tabanı köprümüzü (DbContext) buraya bağlıyoruz
        public MusteriController(AppDbContext context)
        {
            _context = context;
        }

        // 1. LİSTELEME: Tüm müşterileri ekranda gösteren sayfa
        public IActionResult Index()
        {
            var musteriler = _context.Musteriler.ToList();
            return View(musteriler);
        }

        // 2. EKLEME SAYFASI: Yeni müşteri ekleme ekranını açan kod
        public IActionResult Create()
        {
            return View();
        }

        // 3. EKLEME İŞLEMİ: Formdan gelen verileri veri tabanına kaydeden kod
        [HttpPost]
        public IActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                _context.Musteriler.Add(musteri);
                _context.SaveChanges(); // SQL'e kaydetme emri
                return RedirectToAction("Index"); // İşlem bitince listeye geri dön
            }
            return View(musteri);
        }
    }
}