using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        public IActionResult Index()
        {
            var listDestinations = destinationManager.GetAllList();
            return View(listDestinations);
        }
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.id = id;
            var getDestinationsById = destinationManager.GetTById(id);
            return View(getDestinationsById);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
