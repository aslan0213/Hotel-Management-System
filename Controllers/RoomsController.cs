using Microsoft.AspNetCore.Mvc;

namespace HotelManagmentSystem.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
