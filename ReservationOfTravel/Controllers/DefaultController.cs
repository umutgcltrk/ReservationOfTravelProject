using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
