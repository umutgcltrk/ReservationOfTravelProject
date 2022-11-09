using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationRepository());
        public IViewComponentResult Invoke()
        {
            var ListDestinations = destinationManager.GetAllList();
            return View(ListDestinations);
        }
    }
}
