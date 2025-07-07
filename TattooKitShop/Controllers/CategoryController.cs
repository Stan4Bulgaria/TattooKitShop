using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
