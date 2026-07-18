using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TekServis.Controllers
{
    public class YetkiKontrolAttribute : ActionFilterAttribute
    {
        private readonly string[] _izinVerilenRoller;

        public YetkiKontrolAttribute(params string[] roller)
        {
            _izinVerilenRoller = roller;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Session'dan giriş yapan kullanıcının rolünü alıyoruz
            var kullaniciRol = filterContext.HttpContext.Session.GetString("KullaniciRol");

            // 1. Eğer kullanıcı giriş yapmadıysa doğrudan Giriş (Login) sayfasına fırlat
            if (string.IsNullOrEmpty(kullaniciRol))
            {
                filterContext.Result = new RedirectToActionResult("Login", "Account", null);
                return;
            }

            // 2. Eğer kullanıcı "SuperAdmin" ise hiçbir engele takılmadan her yere girebilsin
            if (kullaniciRol == "SuperAdmin")
            {
                base.OnActionExecuting(filterContext);
                return;
            }

            // 3. Eğer kullanıcının rolü, bu sayfa için izin verilen roller listesinde yoksa engelle!
            // Kullanıcıyı ana sayfaya göndersin ve hata uyarısı versin.
            if (!_izinVerilenRoller.Contains(kullaniciRol))
            {
                filterContext.Result = new RedirectToActionResult("Index", "Home", null);
            }

            base.OnActionExecuting(filterContext);
        }
    }
}