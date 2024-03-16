using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AjaxContentController : Controller
    {
        public IActionResult HeaderCart()
        {
            return ViewComponent("HeaderCart");
        }
        public IActionResult HeaderFavourites()
        {
            return ViewComponent("NumberCart");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
