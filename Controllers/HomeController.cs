using Microsoft.AspNetCore.Mvc;

namespace HotelManagmentSystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
