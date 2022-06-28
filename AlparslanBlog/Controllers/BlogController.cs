using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading;
using System;
using DataAccesLayer.Concrete;
using X.PagedList;

namespace AlparslanBlog.Controllers
{
   
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogManager bm = new BlogManager(new EFBlogRepository());
        KategoriManager km = new KategoriManager(new EFKategoriRepository());
        BlogKurallari bk = new BlogKurallari();
        public IActionResult Anasayfa()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Bloglarım(int page = 1, int pageSize = 9)
        {  
            var liste = bm.kategoriadigetir().ToPagedList(page,pageSize);
            return View(liste);
        }
        [AllowAnonymous]
        public IActionResult Detaylar(int id)
        {
            ViewBag.d = id;
            var deger=bm.GetirIdBlog(id);
            return View(deger);         
        }
        public IActionResult YazarBlogListesi()
        {    
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir=bm.KategoriAdiGetirYazar(yazaradi);
            return View(getir);
        }
        [HttpGet]
        public IActionResult BlogEkle()
        {
           List<SelectListItem>Kategoriler=(from x in km.HepsiniGetir()
                                             select new SelectListItem
                                             {
                                           Text=x.KategoriAd,
                                           Value =x.KategoriID.ToString(),
                                             }).ToList();
            ViewBag.ktg = Kategoriler;
            return View();
        }
        [HttpPost]
        public IActionResult BlogEkle(Blog p)
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            ValidationResult result =bk.Validate(p);
            if (result.IsValid)
            {
                p.BlogOlusturmaTarihi = System.DateTime.Now;
                p.BlogDurum = true;
                p.YazarID = yazaradi;
                bm.TEkle(p);
                Thread.Sleep(2000);
                return RedirectToAction("YazarBlogListesi","Blog");
            }
            else
            {
                foreach (var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult Sil(int id)
        {
            var deger =bm.GetirID(id);
            bm.TSil(deger);
            Thread.Sleep(2000);
            return RedirectToAction("YazarBlogListesi", "Blog");
        }
        [HttpGet]
        public IActionResult Düzenle(int id)
        {
            List<SelectListItem> Kategoriler = (from x in km.HepsiniGetir()
                                                select new SelectListItem
                                                {
                                                    Text = x.KategoriAd,
                                                    Value = x.KategoriID.ToString(),
                                                }).ToList();
            ViewBag.ktg = Kategoriler;
            var deger = bm.GetirID(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult Düzenle(Blog p)
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            p.YazarID = yazaradi;
            p.BlogOlusturmaTarihi = System.DateTime.Now;
            p.BlogDurum = true;
            bm.TGuncelle(p);
            Thread.Sleep(2000);
            return RedirectToAction("YazarBlogListesi", "Blog");
        }
    }
}
