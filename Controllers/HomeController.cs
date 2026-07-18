using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TekServis.Core;

namespace TekServis.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}