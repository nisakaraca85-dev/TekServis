using Microsoft.AspNetCore.Mvc;
using TekServis.Data;
using TekServis.Models;

namespace TekServis.Controllers
{
    public class TeknisyenController : Controller
    {
        private readonly AppDbContext _context;

        public TeknisyenController(AppDbContext context)
        {
            _context = context;
        }

        // 1. LİSTELEME: Tüm teknisyenleri gösterir
        public IActionResult Index()
        {
            var teknisyenler = _context.Teknisyenler.ToList();
            return View(teknisyenler);
        }

        // 2. EKLEME SAYFASI
        public IActionResult Create()
        {
            return View();
        }

        // 3. EKLEME İŞLEMİ
        [HttpPost]
        public IActionResult Create(Teknisyen teknisyen)
        {
            try
            {
                _context.Teknisyenler.Add(teknisyen);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(teknisyen);
            }
        }
    }
}