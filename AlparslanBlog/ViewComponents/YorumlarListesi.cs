using AlparslanBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AlparslanBlog.ViewComponents
{
    public class YorumlarListesi:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var yorumdeger = new List<KullaniciYorumlar>
            {
                new KullaniciYorumlar
                {
                    Id =1,
                    Ad="Alparslan"
                },
                new KullaniciYorumlar
                {
                    Id =2,
                    Ad="Gazi"
                },
            };
            return View(yorumdeger);
        }
    }
}
