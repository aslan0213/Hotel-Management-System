using Microsoft.AspNetCore.Mvc;

namespace HotelManagmentSystem.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
