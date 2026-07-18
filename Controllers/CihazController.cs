using Microsoft.AspNetCore.Mvc;
using TekServis.Data;
using TekServis.Core;

namespace TekServis.Controllers
{
    [YetkiKontrol("SuperAdmin")]
    public class CihazController : BaseController
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