using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AlparslanBlog.ViewComponents.AdminMesajlar
{
    public class AdminMesajlar : ViewComponent
    {
        Mesajlar2Manager mm = new Mesajlar2Manager(new EFMesajlar2Repository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir = mm.HepsiniGetirYazarGelenMesaj(yazaradi);
            return View(getir);
        }
    }
}
