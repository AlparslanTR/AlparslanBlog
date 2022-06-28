using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AlparslanBlog.ViewComponents.Gönderilen_Mesajları_Listeleme
{
    public class AlinanMesajlar : ViewComponent
    {
        Mesajlar2Manager mm = new Mesajlar2Manager(new EFMesajlar2Repository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var getir = mm.GonderilenMesajlar(yazaradi);
            return View(getir);
        }
    }
}
