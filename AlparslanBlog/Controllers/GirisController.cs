using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;


namespace AlparslanBlog.Controllers
{
    public class GirisController : Controller
    {
        YazarManager ym = new YazarManager(new EFYazarRepository());
        YazarKurallari yk = new YazarKurallari();
        [HttpGet]
        [AllowAnonymous]
        public IActionResult KayıtOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayıtOl(Yazar p)
        {
            ValidationResult result=yk.Validate(p);
            if (result.IsValid)
            {
                p.YazarDurumu = true;
                p.YazarHakkinda = "Denemeler";
                p.YazarResim = "https://i.hizliresim.com/43nokb4.jpg";
                ym.TEkle(p);
                Thread.Sleep(1500);
                return RedirectToAction("Bloglarım", "Blog");
            }
            else
            {
                foreach(var x in result.Errors)
                {
                    ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
                }
            }
            return View();
           
        }
        [AllowAnonymous]
        public IActionResult GirisYap()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> GirisYap(Yazar p)
        {
            Context c = new Context(); 
            var giris=c.yazarss.FirstOrDefault(x => x.YazarMail==p.YazarMail && x.YazarSifre==p.YazarSifre);
            if (giris!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.YazarMail)
                };
                var useridentity= new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Profilim", "Yazarlar");
            }
            else
            {
                return View();
            }
        }
        public async Task <IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("GirisYap", "Giris");
        }
    }
}

//Context c = new Context();
//var giris = c.yazarss.FirstOrDefault(x => x.YazarMail == p.YazarMail && x.YazarSifre == p.YazarSifre);
//if (giris != null)
//{
//    HttpContext.Session.SetString("username", p.YazarMail);
//    return RedirectToAction("YazarProfil", "Yazarlar");
//}
//else
//{
//    return View();
//}