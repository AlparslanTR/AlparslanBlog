using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AlparslanBlog.ViewComponents.Admin_Head_Alanı
{
    public class AdminBilgiTasimaNavbar : ViewComponent
    {
        YazarManager ym = new YazarManager(new EFYazarRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir = ym.YazarGetirID(yazaradi);
            return View(getir);
        }
    }
}
