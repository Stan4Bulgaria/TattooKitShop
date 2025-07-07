using Microsoft.AspNetCore.Mvc;

namespace TattooKitShop.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
