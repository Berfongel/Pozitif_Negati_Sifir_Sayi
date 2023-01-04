using Microsoft.AspNetCore.Mvc;
using PozitifNegatifSifirWebApplication.Models;
using System.Diagnostics;

namespace PozitifNegatifSifirWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(PozitifNegatifSifir pozitifNegatifSifir)
        {
            var sayi = pozitifNegatifSifir.Sayi;
            if (sayi > 0)
            {
                ViewBag.Message = "Pozitif Sayıdır";
            }

            else if (sayi == 0)
            {

                ViewBag.Message = "Sayı Ne Negatif Ne Pozitif Sayıdır";

            }

            else
            {
                ViewBag.Message = "Sayı  Negatif Sayıdır";

            }
            return View("pozitifNegatifSifir");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}