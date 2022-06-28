using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace AlparslanBlog.Controllers
{
    [AllowAnonymous]
    public class İletişimController : Controller
    {
        
        IletisimManager im = new IletisimManager(new EFIletisimRepository());

        [HttpGet]
        public IActionResult BizeUlaş()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BizeUlaş(Iletisim p)
        {
            p.IletisimDurum = true;
            p.IletisimTarih = System.DateTime.Now;
            im.IletisimEkle(p);
            Thread.Sleep(2000);
            return RedirectToAction("BizeUlaş", "İletişim");
        }
    }
}
