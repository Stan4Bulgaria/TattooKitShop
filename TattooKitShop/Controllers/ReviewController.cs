using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
