using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager km = new KategoriManager(new EFKategoriRepository());
        public IActionResult Index()
        {
            var listele = km.HepsiniGetir();
            return View(listele);
        }
    }
}
