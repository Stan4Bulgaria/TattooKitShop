using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
