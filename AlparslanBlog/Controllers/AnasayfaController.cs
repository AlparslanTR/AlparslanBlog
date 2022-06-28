using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.Controllers
{
    [AllowAnonymous]
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult HayatYazılımlaBaslar()
        {
            return View();
        }
        public ActionResult KendiAlgoritmanızıOlusturun()
        {
            return View();
        }
        public ActionResult KendinizeBirDilBerirleyin()
        {
            return View();
        }
        public ActionResult PojeleriniziYazilimcilarlaPaylasin()
        {
            return View();
        }
    }
}
