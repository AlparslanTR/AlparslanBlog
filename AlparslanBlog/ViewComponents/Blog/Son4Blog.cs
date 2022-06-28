using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AlparslanBlog.ViewComponents.Blog
{
    public class Son4Blog : ViewComponent
    {
        BlogManager ym = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var giris = User.Identity.Name;
            var yazaradi = c.yazarss.Where(x => x.YazarMail == giris).Select(x => x.YazarID).FirstOrDefault();
            var deger = ym.kategoriadigetir4();
            return View(deger);
        }
    }
}
