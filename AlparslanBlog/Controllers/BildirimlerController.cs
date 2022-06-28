using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.Controllers
{

    public class BildirimlerController : Controller
    {   
        BildirimlerManager bm = new BildirimlerManager(new EFBildirimRepository());
        public IActionResult Bildirimleriniz()
        {
            var getir = bm.HepsiniGetir();
            return View(getir);
        }
    }
}
