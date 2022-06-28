using Microsoft.AspNetCore.Mvc;

namespace AlparslanBlog.Controllers
{
    public class Error : Controller
    {
        public IActionResult Hata404()
        {
            return View();
        }

}
}
