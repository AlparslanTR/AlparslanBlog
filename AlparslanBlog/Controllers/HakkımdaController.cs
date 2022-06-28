using BusinessLayer.Concrete;
using DataAccesLayer.Entity_Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.Controllers
{
    public class HakkımdaController : Controller
    {
        HakkimdaManager hm = new HakkimdaManager(new EFHakkimdaRepository());

        [AllowAnonymous]
        public IActionResult BizKimiz()
        {
            var listele = hm.HepsiniGetir();
            return View(listele);
        }
    }
}
