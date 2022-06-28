using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.ViewComponents.Blog
{
    public class SonBlog3:ViewComponent
    {
        BlogManager ym = new BlogManager(new EFBlogRepository());
        public IViewComponentResult Invoke()
        {
            var deger = ym.Son3Blog();
            return View(deger);
        }
    }
}
