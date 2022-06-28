using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.ViewComponents.Admin_Head_Alanı
{
    public class AdminBildirimler: ViewComponent
    {
        BildirimlerManager bm = new BildirimlerManager(new EFBildirimRepository());
        public IViewComponentResult Invoke()
        {
            var getir = bm.HepsiniGetir();
            return View(getir);
        }
    }
}
