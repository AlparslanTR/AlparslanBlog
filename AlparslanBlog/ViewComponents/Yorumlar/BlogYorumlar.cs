using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
namespace AlparslanBlog.ViewComponents.Yorumlar
{
    public class BlogYorumlar : ViewComponent
    {
        YorumlarManager ym = new YorumlarManager(new EFYorumlarRepository());
        public IViewComponentResult Invoke(int id)
        {
            var getir = ym.HepsiniGetir(id);
            return View(getir);
        }
    }
}
