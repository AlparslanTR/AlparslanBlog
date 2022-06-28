using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace AlparslanBlog.Controllers
{
    [AllowAnonymous]
    public class AbonelerController : Controller
    {
        AboneManager am = new AboneManager(new EFAbonelerRepository());
        
        [HttpGet]
        public PartialViewResult AboneOl()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AboneOl(Aboneler p)
        {
            p.MailDurum = true;
            am.AboneEkle(p);
            Thread.Sleep(1500);
            return PartialView();
        }
    }
}
