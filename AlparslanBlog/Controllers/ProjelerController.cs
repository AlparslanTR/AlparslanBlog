using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using X.PagedList;

namespace AlparslanBlog.Controllers
{
    
    public class ProjelerController : Controller
    {
        ProjelerManager pm = new ProjelerManager(new EFProjelerRepository());
        YazarManager ym = new YazarManager(new EFYazarRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Projelerim(int page = 1, int pageSize = 9)
        {
            var listele=pm.HepsiniGetir().ToPagedList(page, pageSize);
            return View(listele);
        }
        [AllowAnonymous]
        public IActionResult Detaylar(int id)
        {
            var getir = pm.GetirIdProje(id);
            return View(getir);
        }
        public IActionResult YazarProjeListesi()
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir = pm.KategoriAdiGetirYazar(yazaradi);
            return View(getir);
        }
        [HttpGet]
        public IActionResult Düzenle(int id)
        {
            List<SelectListItem> Yazarlar = (from x in ym.HepsiniGetir()
                                                select new SelectListItem
                                                {
                                                    Text = x.YazarAd,
                                                    Value = x.YazarID.ToString(),
                                                }).ToList();
            ViewBag.ktg = Yazarlar;
            var getir = pm.GetirID(id);
            return View(getir);
        }
        [HttpPost]
        public IActionResult Düzenle(Projeler p)
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            p.YazarID = yazaradi;
            p.ProjeTarihi = System.DateTime.Now;
            pm.TGuncelle(p);
            Thread.Sleep(2000);
            return RedirectToAction("YazarProjeListesi", "Projeler");
        }
        public IActionResult Sil(int id)
        {
            var sil = pm.GetirID(id);
            pm.TSil(sil);
            Thread.Sleep(2000);
            return RedirectToAction("YazarProjeListesi", "Projeler");
        }
        [HttpGet]
        public IActionResult ProjeEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProjeEkle(Projeler p)
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            p.ProjeTarihi = System.DateTime.Now;
            p.YazarID = yazaradi;
            pm.TEkle(p);
            Thread.Sleep(2000);
            return RedirectToAction("YazarProjeListesi", "Projeler");
        }
    }
}
