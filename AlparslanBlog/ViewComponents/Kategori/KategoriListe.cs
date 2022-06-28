using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.ViewComponents.Kategori
{
    public class KategoriListe:ViewComponent
    {
       KategoriManager km = new KategoriManager(new EFKategoriRepository());
        public IViewComponentResult Invoke()
        {
            var deger = km.HepsiniGetir();
            return View(deger);
        }
    }
   
}
