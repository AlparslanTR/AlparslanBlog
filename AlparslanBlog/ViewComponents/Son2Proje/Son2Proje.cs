using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.ViewComponents.Son2Proje
{
    public class Son2Proje:ViewComponent
    {
        ProjelerManager pm = new ProjelerManager(new EFProjelerRepository());
        public IViewComponentResult Invoke()
        {
            var getir = pm.GetirIki();
            return View(getir);
        }

    }
}
