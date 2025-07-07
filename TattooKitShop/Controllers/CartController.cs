using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
