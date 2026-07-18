using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using TekServis.Data;
using TekServis.Core;

namespace TekServis.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // Giriş Sayfası Ekranı (GET)
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Giriş Yapma İşlemi (POST)
        [HttpPost]
        public IActionResult Login(string eposta, string sifre)
        {
            // Veri tabanında bu e-posta ve şifreye ait kullanıcı var mı?
            var kullanıcı = _context.Kullanicilar
                .FirstOrDefault(u => u.Eposta == eposta && u.Sifre == sifre);

            if (kullanıcı != null)
            {
                // Giriş başarılı! Kullanıcının adını ve ROLÜNÜ oturuma (Session) kaydediyoruz
                HttpContext.Session.SetString("KullaniciAd", kullanıcı.AdSoyad);
                HttpContext.Session.SetString("KullaniciRol", kullanıcı.Rol);

                // Kullanıcıyı ana sayfaya yönlendiriyoruz
                return RedirectToAction("Index", "Home");
            }

            // Bilgiler hatalıysa sayfaya uyarı gönderiyoruz
            ViewBag.Hata = "E-posta veya şifre hatalı!";
            return View();
        }

        // Çıkış Yapma İşlemi
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}