using BusinessLayer.Concrete;
using DataAccesLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AlparslanBlog.ViewComponents.Blog
{
    public class YazarSonBlog:ViewComponent
    {
        BlogManager ym = new BlogManager(new EFBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var getir = ym.Son5Blog();
            return View(getir);
        }
    }
}
