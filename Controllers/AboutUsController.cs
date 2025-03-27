using Microsoft.AspNetCore.Mvc;

namespace HotelManagmentSystem.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
