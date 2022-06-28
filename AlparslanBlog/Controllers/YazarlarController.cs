using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NPOI.SS.Formula.Functions;
using System;
using System.Linq;
using System.Threading;

namespace AlparslanBlog.Controllers
{
    public class YazarlarController : Controller
    {
        YazarManager ym = new YazarManager(new EFYazarRepository());
        YazarKurallari yz=  new YazarKurallari();
        [Authorize]
        public IActionResult Index()
        {
            var giris = User.Identity.Name;
            ViewBag.d = giris;
            Context c = new Context();
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            ViewBag.yazar=yazaradi;
            return View();
        }

        [HttpGet]
        public IActionResult Profilim()
        {
            Context c = new Context();
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var profil = ym.GetirID(yazaradi);
            return View(profil);
        }
        [HttpPost]
        public IActionResult Profilim(Yazar p)
        {
           ValidationResult results = yz.Validate(p);
            if (results.IsValid)
            {
                p.YazarDurumu = true;
                ym.TGuncelle(p);
                Thread.Sleep(2000);
                RedirectToAction("Profilim", "Yazarlar");
            }
            else
            {
                foreach (var x in results.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
       
        public IActionResult KontrolPaneli()
        {
           Context c = new Context();
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            ViewBag.tbs=c.blogss.Count().ToString();
            ViewBag.sbs = c.blogss.Where(x => x.YazarID == yazaradi).Count().ToString();
            var son7= DateTime.Now.Date.AddDays(-7);
            ViewBag.sg7 =c.blogss.Where(x=>x.BlogOlusturmaTarihi >= son7).Count();
            return View();
        }
       

        // Profil Sayfasında Yer Alan Css Bilgisi İçeren Sayfalar Burada Yer Alıyor.//
        public IActionResult CssButonlar()
        {
            return View();
        }
        public IActionResult CssYazıTürleri()
        {
            return View();
        }
        public IActionResult CssIconlar()
        {
            return View();
        }
        public IActionResult FormTürleri()
        {
            return View();
        }
        public IActionResult ChartTabloları()
        {
            return View();
        }
        public IActionResult TabloTürleri()
        {
            return View();
        }
    }
}
