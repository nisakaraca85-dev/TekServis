using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TekServis.Controllers
{
    public class BaseController : Controller
    {
        public string AktifKullaniciAd => HttpContext.Session.GetString("KullaniciAd");
        public string AktifKullaniciRol => HttpContext.Session.GetString("KullaniciRol");

        public bool GirişYapilmisMi()
        {
            return !string.IsNullOrEmpty(AktifKullaniciAd);
        }

        // --- YENİ EKLENEN KISIM ---
        // Herhangi bir sayfaya istek geldiğinde ilk burası devreye girer
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            // Eğer kullanıcı giriş yapmamışsa VE şu an zaten Account (Login) sayfasında DEĞİLSE
            if (!GirişYapilmisMi() && context.RouteData.Values["controller"]?.ToString() != "Account")
            {
                // Kullanıcıyı direkt Giriş Yap sayfasına yönlendir!
                // Eski hatalı yönlendirme satırını sil, yerine tam olarak bunu yapıştır:
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login" }));
            }
        }
    }
}