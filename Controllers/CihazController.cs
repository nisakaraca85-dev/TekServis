using Microsoft.AspNetCore.Mvc;
using TekServis.Data;
using TekServis.Models;

namespace TekServis.Controllers
{
    public class CihazController : Controller
    {
        private readonly AppDbContext _context;

        public CihazController(AppDbContext context)
        {
            _context = context;
        }

        // 1. LİSTELEME: Tüm cihazları gösterir
        public IActionResult Index()
        {
            var cihazlar = _context.Cihazlar.ToList();
            return View(cihazlar);
        }

        // 2. EKLEME SAYFASI
        public IActionResult Create()
        {
            return View();
        }

        // 3. EKLEME İŞLEMİ
        [HttpPost]
        public IActionResult Create(Cihaz cihaz)
        {
            try
            {
                _context.Cihazlar.Add(cihaz);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(cihaz);
            }
        }
    }
}