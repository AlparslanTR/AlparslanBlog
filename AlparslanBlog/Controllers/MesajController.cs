using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace AlparslanBlog.Controllers
{
    public class MesajController : Controller
    {
        Mesajlar2Manager mm = new Mesajlar2Manager(new EFMesajlar2Repository());
        YazarManager ym = new YazarManager(new EFYazarRepository());
        Context c = new Context();
        [Authorize]
        public IActionResult Mesajlarınız()
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir = mm.HepsiniGetirYazarGelenMesaj(yazaradi);
            return View(getir);
        }
        public IActionResult Mesajım(int id)
        {
            var getir = mm.GetirID(id);
            return View(getir);
        }
        [HttpGet]
        public IActionResult MesajYaz()
        {
            List<SelectListItem> yazarlar = (from x in ym.HepsiniGetir()
                                                select new SelectListItem
                                                {
                                                    Text = x.YazarAd,
                                                    Value = x.YazarID.ToString(),
                                                }).ToList();
            ViewBag.yazarlar = yazarlar;
            return View();
        }
        [HttpPost]
        public IActionResult MesajYaz(Mesajlar2 p)
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            p.GonderenMailID = yazaradi;
            p.MesajTarih = System.DateTime.Now;
            p.MesajDurumu = true;
            mm.TEkle(p);
            return RedirectToAction("Mesajlarınız", "Mesaj");
        }
    }
}
