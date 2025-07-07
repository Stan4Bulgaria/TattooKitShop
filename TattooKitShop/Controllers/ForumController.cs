using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
